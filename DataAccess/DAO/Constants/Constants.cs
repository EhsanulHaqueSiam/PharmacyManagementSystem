using System;

namespace PharmacyManagementSystem.DataAccess.Constants {
    public static class AdminSqlQueries {
        public const string GET_ADMIN_BY_ID = "SELECT * FROM Admin WHERE A_ID = @adminId AND IsDeleted = 0";
        public const string GET_ADMIN_BY_USERNAME = "SELECT * FROM Admin WHERE A_UserName COLLATE Latin1_General_BIN = @username AND IsDeleted = 0";
        public const string GET_ADMIN_BY_EMAIL = "SELECT * FROM Admin WHERE A_Mail = @email AND IsDeleted = 0";
        public const string SEARCH_ADMINS_BY_PARTIAL_USERNAME = "SELECT * FROM Admin WHERE A_UserName LIKE @partialUsername AND IsDeleted = 0";
        public const string SEARCH_ADMINS_BY_PARTIAL_PHONE = "SELECT * FROM Admin WHERE A_Number LIKE @partialPhone AND IsDeleted = 0";
        public const string INSERT_ADMIN = "INSERT INTO Admin (A_UserName, A_Name, A_Dob, A_Number, A_Pass, A_Mail) VALUES (@userName, @name, @dob, @number, @pass, @mail)";
        public const string UPDATE_ADMIN = "UPDATE Admin SET A_UserName = @userName, A_Name = @name, A_Dob = @dob, A_Number = @number, A_Pass = @pass, A_Mail = @mail WHERE A_ID = @adminId";
        public const string DELETE_ADMIN = "DELETE FROM Admin WHERE A_ID = @adminId";
        public const string SOFT_DELETE_ADMIN = "UPDATE Admin SET IsDeleted = 1 WHERE A_ID = @adminId";
        public const string GET_ALL_ADMINS = "SELECT * FROM Admin WHERE IsDeleted = 0";
        public const string COUNT_ADMINS = "SELECT COUNT(*) FROM Admin WHERE IsDeleted = 0";
        public const string VALIDATE_ADMIN_LOGIN = "SELECT A_ID FROM Admin " +
                                           "WHERE (A_UserName COLLATE Latin1_General_BIN = @UserName OR A_Mail = @Email) " +
                                           "AND A_Pass = @Password " +
                                           "AND IsDeleted = 0";

    }

    public static class PharmacistQueries {
        public const string GET_PHARMACIST_BY_ID = "SELECT * FROM Pharmacist WHERE P_ID = @Id AND IsDeleted = 0";
        public const string GET_PHARMACIST_BY_USERNAME = "SELECT * FROM Pharmacist WHERE P_UserName COLLATE Latin1_General_BIN = @username AND IsDeleted = 0";
        public const string GET_PHARMACIST_BY_EMAIL = "SELECT * FROM Pharmacist WHERE P_Mail = @email AND IsDeleted = 0";
        public const string SEARCH_PHARMACISTS_BY_PARTIAL_USERNAME = "SELECT * FROM Pharmacist WHERE P_UserName LIKE @partialUsername AND IsDeleted = 0";
        public const string SEARCH_PHARMACISTS_BY_PARTIAL_PHONE = "SELECT * FROM Pharmacist WHERE P_Number LIKE @partialPhone AND IsDeleted = 0";
        public const string INSERT_PHARMACIST = "INSERT INTO Pharmacist (P_UserName, P_Name, P_Dob, P_Number, P_Pass, P_Mail) VALUES (@UserName, @Name, @Dob, @Number, @Pass, @Mail)";
        public const string UPDATE_PHARMACIST = "UPDATE Pharmacist SET P_UserName = @UserName, P_Name = @Name, P_Dob = @Dob, P_Number = @Number, P_Pass = @Pass, P_Mail = @Mail WHERE P_ID = @Id";
        public const string DELETE_PHARMACIST = "DELETE FROM Pharmacist WHERE P_ID = @Id";
        public const string SOFT_DELETE_PHARMACIST = "UPDATE Pharmacist SET IsDeleted = 1 WHERE P_ID = @Id";
        public const string GET_ALL_PHARMACISTS = "SELECT * FROM Pharmacist WHERE IsDeleted = 0";
        public const string COUNT_PHARMACISTS = "SELECT COUNT(*) FROM Pharmacist WHERE IsDeleted = 0";
        public const string VALIDATE_PHARMACIST_LOGIN = "SELECT P_ID FROM Pharmacist " +
                                                "WHERE (P_UserName COLLATE Latin1_General_BIN = @UserName OR P_Mail = @Email) " +
                                                "AND P_Pass = @Password " +
                                                "AND IsDeleted = 0";

    }

    public static class CustomerQueries {
        public const string GET_CUSTOMER_BY_ID = "SELECT * FROM Customer WHERE C_ID = @Id AND IsDeleted = 0";
        public const string GET_CUSTOMER_BY_USERNAME = "SELECT * FROM Customer WHERE C_UserName COLLATE Latin1_General_BIN = @UserName AND IsDeleted = 0";
        public const string GET_CUSTOMER_BY_EMAIL = "SELECT * FROM Customer WHERE C_Mail = @Email AND IsDeleted = 0";
        public const string SEARCH_CUSTOMERS_BY_PARTIAL_USERNAME = "SELECT * FROM Customer WHERE C_UserName LIKE @PartialUsername AND IsDeleted = 0";
        public const string SEARCH_CUSTOMERS_BY_PARTIAL_PHONE = "SELECT * FROM Customer WHERE C_Number LIKE @PartialPhone AND IsDeleted = 0";
        public const string INSERT_CUSTOMER = "INSERT INTO Customer (C_UserName, C_Name, C_Number, C_Pass, C_Mail, C_Dob) " +
                                      "VALUES (@UserName, @Name, @Number, @Pass, @Mail, @Dob)";
        public const string UPDATE_CUSTOMER = "UPDATE Customer SET C_UserName = @UserName, C_Name = @Name, C_Number = @Number, " +
                                      "C_Pass = @Pass, C_Mail = @Mail, C_Dob = @Dob WHERE C_ID = @Id";
        public const string DELETE_CUSTOMER = "DELETE FROM Customer WHERE C_ID = @Id";
        public const string SOFT_DELETE_CUSTOMER = "UPDATE Customer SET IsDeleted = 1 WHERE C_ID = @Id";
        public const string GET_ALL_CUSTOMERS = "SELECT * FROM Customer WHERE IsDeleted = 0";
        public const string GET_FREQUENT_CUSTOMERS = "SELECT C_ID, COUNT(*) AS PurchaseCount " +
                                                     "FROM Transactions GROUP BY C_ID ORDER BY PurchaseCount DESC";
        public const string COUNT_CUSTOMERS = "SELECT COUNT(*) FROM Customer WHERE IsDeleted = 0";
        public const string VALIDATE_CUSTOMER_LOGIN = "SELECT C_ID FROM Customer " +
                                      "WHERE (C_UserName COLLATE Latin1_General_BIN = @usernameOrEmail OR C_Mail = @usernameOrEmail) " +
                                      "AND C_Pass = @password " +
                                      "AND IsDeleted = 0";

    }

    public static class MedicineQueries {
        public const string GET_MEDICINE_BY_ID = "SELECT * FROM Medicine WHERE M_ID = @Id AND IsDeleted = 0";
        public const string GET_MEDICINE_BY_NAME = "SELECT * FROM Medicine WHERE M_Name LIKE @Name AND IsDeleted = 0";
        public const string GET_MEDICINE_BY_CHEMICAL_NAME = "SELECT * FROM Medicine WHERE M_ChemicalName LIKE @ChemicalName AND IsDeleted = 0";
        public const string GET_ALL_MEDICINES = "SELECT * FROM Medicine WHERE IsDeleted = 0";
        public const string GET_EXPIRED_MEDICINES = "SELECT * FROM Medicine WHERE Expiry_Date < GETDATE() AND IsDeleted = 0";
        public const string GET_VALID_MEDICINES = "SELECT * FROM Medicine WHERE Expiry_Date > GETDATE() AND IsDeleted = 0";  
        public const string GET_MEDICINES_BY_DATE_RANGE = "SELECT * FROM Medicine WHERE M_Date BETWEEN @startDate AND @endDate AND IsDeleted = 0";
        public const string GET_MEDICINES_BY_PRICE_RANGE = "SELECT * FROM Medicine WHERE M_PricePerUnit BETWEEN @minPrice AND @maxPrice AND IsDeleted = 0";
        public const string GET_LOW_STOCK_MEDICINES = "SELECT * FROM Medicine WHERE M_Quantity <= @threshold AND IsDeleted = 0";
        public const string GET_MEDICINES_CLOSE_TO_EXPIRY = "SELECT * FROM Medicine WHERE Expiry_Date BETWEEN GETDATE() AND @expiryDate AND IsDeleted = 0";
        public const string GET_RECENTLY_ADDED_MEDICINES = "SELECT * FROM Medicine WHERE M_Date BETWEEN @startDate AND @endDate AND IsDeleted = 0";
        public const string GET_MOST_PURCHASED_MEDICINES = "SELECT M_ID, SUM(Quantity) AS TotalQuantity FROM CustomerMedicine GROUP BY M_ID ORDER BY TotalQuantity DESC";
        public const string GET_MOST_EXPENSIVE_MEDICINES = "SELECT * FROM Medicine WHERE IsDeleted = 0 ORDER BY M_PricePerUnit DESC";
        public const string GET_CHEAPEST_MEDICINES = "SELECT * FROM Medicine WHERE IsDeleted = 0 ORDER BY M_PricePerUnit ASC";
        public const string INSERT_MEDICINE = "INSERT INTO Medicine (M_Name, M_ChemicalName, M_Quantity, M_PricePerUnit, M_Date, Expiry_Date) VALUES (@Name, @ChemicalName, @Quantity, @PricePerUnit, @Date, @ExpiryDate)";
        public const string UPDATE_MEDICINE = "UPDATE Medicine SET M_Name = @Name, M_ChemicalName = @ChemicalName, M_Quantity = @Quantity, M_PricePerUnit = @PricePerUnit, M_Date = @Date, Expiry_Date = @ExpiryDate WHERE M_ID = @Id";
        public const string DELETE_MEDICINE = "DELETE FROM Medicine WHERE M_ID = @Id";
        public const string SOFT_DELETE_MEDICINE = "UPDATE Medicine SET IsDeleted = 1 WHERE M_ID = @Id";
        public const string COUNT_VALID_MEDICINES = "SELECT COUNT(*) FROM Medicine WHERE Expiry_Date > GETDATE() AND IsDeleted = 0";
        public const string COUNT_EXPIRED_MEDICINES = "SELECT COUNT(*) FROM Medicine WHERE Expiry_Date < GETDATE() AND IsDeleted = 0";
        public const string COUNT_TOTAL_MEDICINES = "SELECT COUNT(*) FROM Medicine WHERE IsDeleted = 0";
    }



    public static class CouponQueries {
        public const string GET_COUPON_BY_ID = "SELECT * FROM Coupon WHERE C_ID = @Id AND IsDeleted = 0";
        public const string INSERT_COUPON = "INSERT INTO Coupon (C_Code, C_DiscountPercent, C_IsSingleUse, C_ExpiryDate) VALUES (@Code, @DiscountPercent, @IsSingleUse, @ExpiryDate)";
        public const string UPDATE_COUPON = "UPDATE Coupon SET C_Code = @Code, C_DiscountPercent = @DiscountPercent, C_IsSingleUse = @IsSingleUse, C_ExpiryDate = @ExpiryDate WHERE C_ID = @Id";
        public const string DELETE_COUPON = "DELETE FROM Coupon WHERE C_ID = @Id";
        public const string SOFT_DELETE_COUPON = "UPDATE Coupon SET IsDeleted = 1 WHERE C_ID = @Id";
        public const string GET_ALL_COUPONS = "SELECT * FROM Coupon WHERE IsDeleted = 0";
        public const string GET_UNEXPIRED_COUPONS = "SELECT * FROM Coupon WHERE C_ExpiryDate >= GETDATE() AND IsDeleted = 0";
    }

    public static class TransactionQueries {
        public const string GET_TRANSACTION_BY_ID = "SELECT * FROM Transactions WHERE T_ID = @Id";
        public const string INSERT_TRANSACTION = "INSERT INTO Transactions (T_Date, T_TotalAmount, T_PaymentType, C_ID) VALUES (@Date, @TotalAmount, @PaymentType, @CustomerId)";
        public const string UPDATE_TRANSACTION = "UPDATE Transactions SET T_Date = @Date, T_TotalAmount = @TotalAmount, T_PaymentType = @PaymentType, C_ID = @CustomerId WHERE T_ID = @Id";
        public const string DELETE_TRANSACTION = "DELETE FROM Transactions WHERE T_ID = @Id";
        public const string GET_ALL_TRANSACTIONS = "SELECT * FROM Transactions";
        public const string GET_TRANSACTIONS_BY_DATE_RANGE = "SELECT * FROM Transactions WHERE T_Date BETWEEN @startDate AND @endDate";
    }
}
