CREATE TABLE AdminTbl (
    Username NVARCHAR(50) PRIMARY KEY,
    Password NVARCHAR(50)
);

CREATE TABLE UserManagementTbl (
    Name NVARCHAR(100),
    PhNo CHAR(10),
    DOB DATE,
    Gender NVARCHAR(10),
    NoOfMembers INT,
    CardType NVARCHAR(20),
    RationCardNo NVARCHAR(50),
    Address NVARCHAR(200),
    Username NVARCHAR(50) PRIMARY KEY,
    Password NVARCHAR(50)
);
