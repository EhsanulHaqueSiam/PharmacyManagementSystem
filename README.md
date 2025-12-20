# Pharmacy Management System 💊

A comprehensive .NET-based desktop application for pharmacy operations management featuring multi-role environment, modern UI, and secure authentication.

## ✨ Features

| Feature | Description |
|---------|-------------|
| 👥 **Role-Based Access** | Admin, Pharmacist, and Customer interfaces |
| 💊 **Inventory Management** | Full CRUD operations for medicine records |
| ⏰ **Expiry Tracking** | Automated alerts for expired/low-stock medicines |
| 💰 **Sales System** | Dynamic pricing, coupon/discount support |
| 🔐 **OTP Security** | Email-based password recovery |
| 🎨 **Modern UI** | Guna.UI2 for sleek, responsive design |

## 🛠️ Tech Stack

| Category | Technology |
|----------|------------|
| **Language** | C# |
| **Framework** | .NET Framework 4.7.2 |
| **UI Library** | Guna.UI2 WinForms |
| **Database** | Microsoft SQL Server |
| **Email/OTP** | MailKit, MimeKit |
| **Security** | BouncyCastle Cryptography |

## 📁 Project Structure

```
├── AdminstratorUC/         # Admin user controls
├── PharmacistUC/           # Pharmacist controls
│   ├── MedicineManagement  # CRUD operations
│   ├── SellingPanel        # Sales interface
│   └── ValidityChecker     # Expiry alerts
├── CustomerUC/             # Customer-facing features
├── CustomerSignInUC/       # Customer authentication
├── DataAccess/             # Database interaction layer
├── Model/                  # Domain models
├── OTP/                    # Secure OTP handling
├── SQLQuery.sql            # Complete database schema
└── Program.cs              # Entry point
```

## 🗃️ Database Tables

- **Admin** - Administrator accounts
- **Pharmacist** - Pharmacist users
- **Customer** - Customer accounts
- **Medicine** - Inventory with expiry tracking
- **Coupons** - Discount management
- **Transactions** - Sales records

## 🚀 Getting Started

1. Clone the repository
2. Open `PharmacyManagementSystem.sln` in Visual Studio
3. Run `SQLQuery.sql` on SQL Server to create database
4. Update connection string in `config.xml`
5. Build and run the project

## 📋 Requirements

- Visual Studio 2019+
- .NET Framework 4.7.2
- SQL Server 2017+
- NuGet packages (auto-restored)

## 👤 Author

**Ehsanul Haque Siam** - [@EhsanulHaqueSiam](https://github.com/EhsanulHaqueSiam)

## 📄 License

MIT License - See [LICENSE.txt](LICENSE.txt)