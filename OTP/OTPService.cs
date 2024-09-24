
using MailKit.Net.Smtp;
using MimeKit;
using PharmacyManagementSystem.DataAccess;
using System;
using System.IO;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace PharmacyManagementSystem.OTP {
    public class OTPService {
        private static string smtpEmail;
        private static string smtpPassword;
        private static string smtpServer;
        private static int smtpPort;
        private static int otpValidityInMinutes = 10; // OTP expires in 10 minutes
        private static string generatedOtp;
        private static DateTime otpGeneratedTime;

        // Load configuration settings using ConfigLoader
        public static void LoadConfiguration() {
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
        public static string GenerateOTP() {
            Random random = new Random();
            generatedOtp = random.Next(100000, 999999).ToString();
            otpGeneratedTime = DateTime.Now;
            Logger.Log($"OTP generated: {generatedOtp}");
            return generatedOtp;
        }

        // Hash the OTP for secure storage/validation
        public static string HashOTP(string otp) {
            using (SHA256 sha256 = SHA256.Create()) {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(otp));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Load HTML template and replace OTP placeholder
        public static string LoadHtmlTemplate(string otp) {
            try {
                string htmlTemplate = File.ReadAllText("otp_template.html");
                return htmlTemplate.Replace("{{OTP}}", otp); // Replace the placeholder {{OTP}} with the actual OTP
            } catch (Exception ex) {
                Logger.LogError(ex);
                throw new ApplicationException("Error loading HTML template.");
            }
        }

        // Send email using Gmail SMTP with HTML content synchronously
        public static void SendOTPEmail(string toEmail, string otp) {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Your Company", smtpEmail));
            emailMessage.To.Add(new MailboxAddress("", toEmail));
            emailMessage.Subject = "Your OTP Code";

            string emailBody = LoadHtmlTemplate(otp);
            emailMessage.Body = new TextPart("html") {
                Text = emailBody
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient()) {
                try {
                    client.Connect(smtpServer, smtpPort, false);
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
        public static bool ValidateOTP(string inputOtp) {
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
    }

}
