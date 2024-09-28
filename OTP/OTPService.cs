using MailKit.Net.Smtp;
using MimeKit;
using PharmacyManagementSystem.DataAccess;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PharmacyManagementSystem.OTP {
    public sealed class OTPService : IDisposable {
        private static readonly Lazy<OTPService> _instance = new Lazy<OTPService>(() => new OTPService());

        private static string smtpEmail;
        private static string smtpPassword;
        private static string smtpServer;
        private static int smtpPort;
        private static int otpValidityInMinutes = 10;
        private static string generatedOtp;
        private static DateTime otpGeneratedTime;

        private bool _disposed = false;

        // Private constructor to prevent instantiation
        private OTPService() {
            LoadConfiguration();
        }

        // Public property to get the single instance
        public static OTPService Instance {
            get {
                return _instance.Value;
            }
        }

        // Load configuration settings using ConfigLoader
        private void LoadConfiguration() {
            try {
                smtpEmail = ConfigLoader.Instance.GetSmtpEmail();
                smtpPassword = ConfigLoader.Instance.GetSmtpPassword();
                smtpServer = ConfigLoader.Instance.GetSmtpServer();
                smtpPort = ConfigLoader.Instance.GetSmtpPort();
                Logger.Log("Configuration loaded successfully using ConfigLoader.");
            } catch (Exception ex) {
                Logger.LogError(ex);
                throw new ApplicationException("Error loading configuration.");
            }
        }

        // Generate a 6-digit OTP and timestamp it
        public string GenerateOTP() {
            Random random = new Random();
            generatedOtp = random.Next(100000, 999999).ToString();
            otpGeneratedTime = DateTime.Now;
            Logger.Log($"OTP generated: {generatedOtp}");
            return generatedOtp;
        }

        // Hash the OTP for secure storage/validation
        public string HashOTP(string otp) {
            using (SHA256 sha256 = SHA256.Create()) {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(otp));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Convert an image file to Base64 string, supporting JPEG and PNG
        private string ConvertImageToBase64(string imagePath) {
            try {
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                string extension = Path.GetExtension(imagePath).ToLower();
                string base64String = Convert.ToBase64String(imageBytes);

                // Determine MIME type based on file extension
                string mimeType;
                if (extension == ".png") {
                    mimeType = "data:image/png;base64,";
                } else if (extension == ".jpg" || extension == ".jpeg") {
                    mimeType = "data:image/jpeg;base64,";
                } else {
                    throw new ApplicationException("Unsupported image format");
                }

                return $"{mimeType}{base64String}";
            } catch (Exception ex) {
                Logger.LogError(ex);
                throw new ApplicationException("Error converting image to base64.");
            }
        }

        // Load HTML template, replace OTP and image placeholders
        public string LoadHtmlTemplate(string otp) {
            try {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(basePath, "OTP", "otp_template.html");

                string htmlTemplate = File.ReadAllText(filePath);
                htmlTemplate = htmlTemplate.Replace("{{OTP}}", otp);

                string currentDateTime = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm tt");
                htmlTemplate = htmlTemplate.Replace("{{DateTime}}", currentDateTime);

                return htmlTemplate;
            } catch (Exception ex) {
                Logger.LogError(ex);
                throw new ApplicationException("Error loading HTML template.");
            }
        }

        // Send email using Gmail SMTP with HTML content synchronously
        public void SendOTPEmail(string toEmail, string otp) {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("AIUB Pharmacy", smtpEmail));
            emailMessage.To.Add(new MailboxAddress("", toEmail));
            emailMessage.Subject = "Your OTP Code";

            string emailBody = LoadHtmlTemplate(otp);
            emailMessage.Body = new TextPart("html") {
                Text = emailBody
            };

            using (var client = new SmtpClient()) {
                try {
                    client.Connect(smtpServer, smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate(smtpEmail, smtpPassword);
                    client.Send(emailMessage);
                    Logger.Log($"OTP email sent to {toEmail}");
                    client.Disconnect(true);
                } catch (Exception ex) {
                    Logger.LogError(ex);
                    throw new ApplicationException("Error sending OTP email.");
                }
            }
        }

        // Validate OTP input and expiration
        public bool ValidateOTP(string inputOtp) {
            if ((DateTime.Now - otpGeneratedTime).TotalMinutes > otpValidityInMinutes) {
                Logger.Log("OTP expired.");
                return false; // OTP expired
            }

            if (inputOtp == generatedOtp) {
                Logger.Log("OTP validation successful.");
                return true; // OTP matches
            }

            Logger.Log("OTP validation failed.");
            return false; // OTP does not match
        }

        // Dispose method for cleanup
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected dispose method
        protected void Dispose(bool disposing) {
            if (!_disposed) {
                if (disposing) {
                    // Cleanup resources
                    smtpEmail = null;
                    smtpPassword = null;
                    smtpServer = null;
                    generatedOtp = null;
                }
                _disposed = true;
            }
        }

        // Finalizer in case dispose wasn't called
        ~OTPService() {
            Dispose(false);
        }
    }
}
