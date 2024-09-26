using System;
using System.Collections.Concurrent;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace PharmacyManagementSystem.DataAccess {
    public sealed class SqlDatabaseManager {
        private static readonly Lazy<SqlDatabaseManager> instance =
            new Lazy<SqlDatabaseManager>(() => new SqlDatabaseManager());

        private readonly ConcurrentQueue<SqlConnection> _connectionPool;
        private readonly int _poolSize;
        private readonly SemaphoreSlim _semaphore;

        private SqlDatabaseManager() {
            if (ConfigLoader.Instance.IsInDesignMode()) {
                // Skip connection creation in design mode
                return;
            }

            try {
                _poolSize = 10; // Set pool size
                _connectionPool = new ConcurrentQueue<SqlConnection>();
                _semaphore = new SemaphoreSlim(_poolSize, _poolSize);

                // Pre-populate the connection pool
                for (int i = 0; i < _poolSize; i++) {
                    _connectionPool.Enqueue(CreateConnection());
                }
            } catch (Exception ex) {
                // Log exception details for further debugging
                Console.WriteLine($"Error initializing SqlDatabaseManager: {ex.Message}");
                throw new InvalidOperationException("Failed to initialize the SQL Database Manager.", ex);
            }
        }


        public static SqlDatabaseManager Instance => instance.Value;

        /// <summary>
        /// Creates a new SQL connection using the connection string from ConfigLoader.
        /// </summary>
        /// <returns>A new SqlConnection object.</returns>
        private SqlConnection CreateConnection() {
            try {
                var connectionString = ConfigLoader.Instance.GetConnectionString();
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            } catch (Exception ex) {
                // Log exception here, throw an appropriate custom exception, or handle it as needed.
                throw new InvalidOperationException("Failed to create SQL connection.", ex);
            }
        }

        /// <summary>
        /// Retrieves an open connection from the connection pool.
        /// </summary>
        /// <returns>An open SqlConnection from the pool.</returns>
        public SqlConnection GetConnection() {
            if (ConfigLoader.Instance.IsInDesignMode()) {
                // Return null or mock connection in design mode
                return null;
            }
            _semaphore.Wait();

            if (_connectionPool.TryDequeue(out SqlConnection connection)) {
                if (connection.State != ConnectionState.Open) {
                    // Try to open the connection if it's not open
                    try {
                        connection.Open();
                    } catch {
                        // Dispose the faulty connection and create a new one
                        connection.Dispose();
                        connection = CreateConnection();
                    }
                }
                return connection;
            } else {
                throw new InvalidOperationException("Failed to get a connection from the pool.");
            }
        }

        /// <summary>
        /// Releases the given SQL connection back to the pool.
        /// </summary>
        /// <param name="connection">The connection to release.</param>
        public void ReleaseConnection(SqlConnection connection) {
            if (connection == null) {
                throw new ArgumentNullException(nameof(connection));
            }

            if (connection.State == ConnectionState.Open) {
                _connectionPool.Enqueue(connection); // Only enqueue if it's valid
            } else {
                // Dispose closed or invalid connections and replace with a fresh one
                connection.Dispose();
                _connectionPool.Enqueue(CreateConnection());
            }
            _semaphore.Release();
        }

        /// <summary>
        /// Executes a given action using a connection from the pool.
        /// </summary>
        /// <param name="action">The action to execute with the connection.</param>
        public void Execute(Action<SqlConnection> action) {
            var connection = GetConnection();
            try {
                action(connection);
            } catch (Exception ex) {
                // Log or handle exception here
                throw new Exception("An error occurred during database operation.", ex);
            } finally {
                ReleaseConnection(connection);
            }
        }

        /// <summary>
        /// Executes a given function that returns a value using a connection from the pool.
        /// </summary>
        /// <typeparam name="T">The return type of the function.</typeparam>
        /// <param name="func">The function to execute with the connection.</param>
        /// <returns>The result of the function execution.</returns>
        public T Execute<T>(Func<SqlConnection, T> func) {
            var connection = GetConnection();
            try {
                return func(connection);
            } catch (Exception ex) {
                // Log or handle exception here
                throw new Exception("An error occurred during database operation.", ex);
            } finally {
                ReleaseConnection(connection);
            }
        }
    }
}
