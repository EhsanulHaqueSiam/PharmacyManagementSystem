-- Admin Table
CREATE TABLE Admin (
    A_ID INT PRIMARY KEY IDENTITY(1,1),
    A_UserName VARCHAR(100) UNIQUE NOT NULL,
    A_Name VARCHAR(100) NOT NULL,
    A_Dob DATE,
    A_Number VARCHAR(15) CHECK (LEN(A_Number) BETWEEN 10 AND 15), -- Phone number validation
    A_Pass VARCHAR(50) NOT NULL,
    A_Mail VARCHAR(100) UNIQUE NOT NULL,
    IsDeleted BIT DEFAULT 0
);

-- Pharmacist Table
CREATE TABLE Pharmacist (
    P_ID INT PRIMARY KEY IDENTITY(1,1),
    P_UserName VARCHAR(100) UNIQUE NOT NULL,
    P_Name VARCHAR(100) NOT NULL,
    P_Dob DATE,
    P_Number VARCHAR(15) CHECK (LEN(P_Number) BETWEEN 10 AND 15), -- Phone number validation
    P_Pass VARCHAR(50) NOT NULL,
    P_Mail VARCHAR(100) UNIQUE NOT NULL,
    IsDeleted BIT DEFAULT 0
);

-- Customer Table
CREATE TABLE Customer (
    C_ID INT PRIMARY KEY IDENTITY(1,1),
    C_UserName VARCHAR(100) UNIQUE NOT NULL,
    C_Name VARCHAR(100) NOT NULL,
    C_Dob DATE, -- Added date of birth for the customer
    C_Number VARCHAR(15) CHECK (LEN(C_Number) BETWEEN 10 AND 15), -- Phone number validation
    C_Pass VARCHAR(50) NOT NULL,
    C_Mail VARCHAR(100) UNIQUE NOT NULL,
    IsDeleted BIT DEFAULT 0
);

-- Medicine Table
CREATE TABLE Medicine (
    M_ID INT PRIMARY KEY IDENTITY(1,1),
    M_Name VARCHAR(100) NOT NULL,
    M_ChemicalName VARCHAR(100),
    M_Quantity INT CHECK (M_Quantity >= 0),
    M_PricePerUnit DECIMAL(10,2) CHECK (M_PricePerUnit >= 0),
    M_Date DATE,
    Expiry_Date DATE CHECK (Expiry_Date > GETDATE()), -- Ensures Expiry_Date is in the future
    IsDeleted BIT DEFAULT 0
);

-- Coupon Table
CREATE TABLE Coupon (
    C_ID INT PRIMARY KEY IDENTITY(1,1),
    C_Code VARCHAR(50) UNIQUE NOT NULL, -- Ensures coupon codes are unique
    C_DiscountPercent DECIMAL(5,2) CHECK (C_DiscountPercent >= 0 AND C_DiscountPercent <= 100),
    C_IsSingleUse BIT,
    C_ExpiryDate DATE CHECK (C_ExpiryDate > GETDATE()), -- Ensures ExpiryDate is in the future
    IsDeleted BIT DEFAULT 0
);

-- Transactions Table
CREATE TABLE Transactions (
    T_ID INT PRIMARY KEY IDENTITY(1,1),
    T_Date DATE NOT NULL,
    T_TotalAmount DECIMAL(10,2) CHECK (T_TotalAmount >= 0),
    T_PaymentType VARCHAR(50) NOT NULL,
    C_ID INT FOREIGN KEY REFERENCES Customer(C_ID) ON DELETE CASCADE -- Ensures referential integrity
);

-- Admin adds/removes Pharmacist
CREATE TABLE AdminPharmacist (
    A_ID INT FOREIGN KEY REFERENCES Admin(A_ID) ON DELETE CASCADE,
    P_ID INT FOREIGN KEY REFERENCES Pharmacist(P_ID) ON DELETE CASCADE,
    PRIMARY KEY (A_ID, P_ID)
);

-- Pharmacist adds/removes Customer
CREATE TABLE PharmacistCustomer (
    P_ID INT FOREIGN KEY REFERENCES Pharmacist(P_ID) ON DELETE CASCADE,
    C_ID INT FOREIGN KEY REFERENCES Customer(C_ID) ON DELETE CASCADE,
    PRIMARY KEY (P_ID, C_ID)
);

-- Customer uses Coupon
CREATE TABLE CustomerCoupon (
    C_ID INT FOREIGN KEY REFERENCES Customer(C_ID) ON DELETE CASCADE,
    C_ID_Coupon INT FOREIGN KEY REFERENCES Coupon(C_ID) ON DELETE CASCADE, -- Ensures referential integrity
    PRIMARY KEY (C_ID, C_ID_Coupon)
);

-- Transaction details: Customer buys Medicine
CREATE TABLE CustomerMedicine (
    T_ID INT FOREIGN KEY REFERENCES Transactions(T_ID) ON DELETE CASCADE,
    M_ID INT FOREIGN KEY REFERENCES Medicine(M_ID),
    Quantity INT CHECK (Quantity > 0),
    PRIMARY KEY (T_ID, M_ID)
);

-- Create Indexes to Improve Performance for Common Queries
CREATE INDEX idx_Customer_UserName ON Customer (C_UserName);
CREATE INDEX idx_Pharmacist_UserName ON Pharmacist (P_UserName);
CREATE INDEX idx_Medicine_Name ON Medicine (M_Name);

-- Add IsDeleted Flag to Existing Tables
-- ALTER TABLE Admin ADD IsDeleted BIT DEFAULT 0;
-- ALTER TABLE Pharmacist ADD IsDeleted BIT DEFAULT 0;
-- ALTER TABLE Customer ADD IsDeleted BIT DEFAULT 0;
-- ALTER TABLE Medicine ADD IsDeleted BIT DEFAULT 0;
-- ALTER TABLE Coupon ADD IsDeleted BIT DEFAULT 0;
-- ALTER TABLE Customer DROP COLUMN C_Address;
