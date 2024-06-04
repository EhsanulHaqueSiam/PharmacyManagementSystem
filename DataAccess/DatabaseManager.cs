using System;
using System.Collections.Concurrent;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.DataAccess {
    public sealed class SqlDatabaseManager {
        private static readonly Lazy<SqlDatabaseManager> instance =
            new Lazy<SqlDatabaseManager>(() => new SqlDatabaseManager());

        private readonly ConcurrentQueue<SqlConnection> _connectionPool;
        private readonly int _poolSize;
        private readonly SemaphoreSlim _semaphore;

        private SqlDatabaseManager() {
            // Initialize connection pool
            _poolSize = 10; // Set pool size
            _connectionPool = new ConcurrentQueue<SqlConnection>();
            _semaphore = new SemaphoreSlim(_poolSize, _poolSize);

            // Pre-populate the connection pool
            for (int i = 0; i < _poolSize; i++) {
                _connectionPool.Enqueue(CreateConnection());
            }
        }

        public static SqlDatabaseManager Instance => instance.Value;

        private SqlConnection CreateConnection() {
            var connectionString = ConfigLoader.Instance.GetConnectionString();
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public async Task<SqlConnection> GetConnectionAsync() {
            await _semaphore.WaitAsync();
            if (_connectionPool.TryDequeue(out SqlConnection connection)) {
                if (connection.State == ConnectionState.Closed) {
                    connection.Open();
                }
                return connection;
            } else {
                throw new InvalidOperationException("Failed to get a connection from the pool.");
            }
        }

        public void ReleaseConnection(SqlConnection connection) {
            if (connection == null) {
                throw new ArgumentNullException(nameof(connection));
            }

            if (connection.State == ConnectionState.Open) {
                _connectionPool.Enqueue(connection);
                _semaphore.Release();
            } else {
                connection.Dispose();
                _connectionPool.Enqueue(CreateConnection());
            }
        }

        public async Task ExecuteAsync(Func<SqlConnection, Task> action) {
            var connection = await GetConnectionAsync();
            try {
                await action(connection);
            } finally {
                ReleaseConnection(connection);
            }
        }

        public async Task<T> ExecuteAsync<T>(Func<SqlConnection, Task<T>> func) {
            var connection = await GetConnectionAsync();
            try {
                return await func(connection);
            } finally {
                ReleaseConnection(connection);
            }
        }
    }

}
