using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.DataAccess.Constants {
    public static class AdminSqlQueries {
        public const string GET_ADMIN_BY_ID = "SELECT * FROM Admin WHERE A_ID = @adminId";
        public const string GET_ADMIN_BY_USERNAME = "SELECT * FROM Admin WHERE A_UserName = @username";
        public const string INSERT_ADMIN = "INSERT INTO Admin (A_UserName, A_Name, A_Dob, A_Number, A_Pass, A_Mail) " +
                                           "VALUES (@userName, @name, @dob, @number, @pass, @mail)";
        public const string UPDATE_ADMIN = "UPDATE Admin SET A_UserName = @userName, A_Name = @name, A_Dob = @dob, " +
                                           "A_Number = @number, A_Pass = @pass, A_Mail = @mail WHERE A_ID = @adminId";
        public const string DELETE_ADMIN = "DELETE FROM Admin WHERE A_ID = @adminId";
        public const string GET_ALL_ADMINS = "SELECT * FROM Admin";

    }

    public static class PharmacistQueries {
        public const string InsertPharmacist = "INSERT INTO Pharmacist (P_UserName, P_Name, P_Dob, P_Number, P_Pass, P_Mail) VALUES (@UserName, @Name, @Dob, @Number, @Pass, @Mail)";
        public const string GetPharmacistById = "SELECT * FROM Pharmacist WHERE P_ID = @Id";
        public const string GetAllPharmacists = "SELECT * FROM Pharmacist";
        public const string UpdatePharmacist = "UPDATE Pharmacist SET P_UserName = @UserName, P_Name = @Name, P_Dob = @Dob, P_Number = @Number, P_Pass = @Pass, P_Mail = @Mail WHERE P_ID = @Id";
        public const string DeletePharmacist = "DELETE FROM Pharmacist WHERE P_ID = @Id";
    }

    public static class CustomerQueries {
        public const string InsertCustomer = "INSERT INTO Customer (C_UserName, C_Name, C_Address, C_Number, C_Pass, C_Mail) VALUES (@UserName, @Name, @Address, @Number, @Pass, @Mail)";
        public const string GetCustomerById = "SELECT * FROM Customer WHERE C_ID = @Id";
        public const string GetAllCustomers = "SELECT * FROM Customer";
        public const string UpdateCustomer = "UPDATE Customer SET C_UserName = @UserName, C_Name = @Name, C_Address = @Address, C_Number = @Number, C_Pass = @Pass, C_Mail = @Mail WHERE C_ID = @Id";
        public const string DeleteCustomer = "DELETE FROM Customer WHERE C_ID = @Id";
    }

    public static class MedicineQueries {
        public const string InsertMedicine = "INSERT INTO Medicine (M_Name, M_ChemicalName, M_Quantity, M_PricePerUnit, M_Date, Expiry_Date) VALUES (@Name, @ChemicalName, @Quantity, @PricePerUnit, @Date, @ExpiryDate)";
        public const string GetMedicineById = "SELECT * FROM Medicine WHERE M_ID = @Id";
        public const string GetAllMedicines = "SELECT * FROM Medicine";
        public const string UpdateMedicine = "UPDATE Medicine SET M_Name = @Name, M_ChemicalName = @ChemicalName, M_Quantity = @Quantity, M_PricePerUnit = @PricePerUnit, M_Date = @Date, Expiry_Date = @ExpiryDate WHERE M_ID = @Id";
        public const string DeleteMedicine = "DELETE FROM Medicine WHERE M_ID = @Id";
    }

    public static class CouponQueries {
        public const string InsertCoupon = "INSERT INTO Coupon (C_Code, C_DiscountPercent, C_IsSingleUse, C_ExpiryDate) VALUES (@Code, @DiscountPercent, @IsSingleUse, @ExpiryDate)";
        public const string GetCouponById = "SELECT * FROM Coupon WHERE C_ID = @Id";
        public const string GetAllCoupons = "SELECT * FROM Coupon";
        public const string UpdateCoupon = "UPDATE Coupon SET C_Code = @Code, C_DiscountPercent = @DiscountPercent, C_IsSingleUse = @IsSingleUse, C_ExpiryDate = @ExpiryDate WHERE C_ID = @Id";
        public const string DeleteCoupon = "DELETE FROM Coupon WHERE C_ID = @Id";
    }

    public static class TransactionQueries {
        public const string InsertTransaction = "INSERT INTO Transactions (T_Date, T_TotalAmount, T_PaymentType, C_ID) VALUES (@Date, @TotalAmount, @PaymentType, @CustomerId)";
        public const string GetTransactionById = "SELECT * FROM Transactions WHERE T_ID = @Id";
        public const string GetAllTransactions = "SELECT * FROM Transactions";
        public const string UpdateTransaction = "UPDATE Transactions SET T_Date = @Date, T_TotalAmount = @TotalAmount, T_PaymentType = @PaymentType, C_ID = @CustomerId WHERE T_ID = @Id";
        public const string DeleteTransaction = "DELETE FROM Transactions WHERE T_ID = @Id";
    }
}
