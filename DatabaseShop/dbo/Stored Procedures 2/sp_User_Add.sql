CREATE PROCEDURE sp_User_Add
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @MiddleName NVARCHAR(50),
    @Birthdate DATE,
    @Email NVARCHAR(MAX),
    @Phone NVARCHAR(20),
    @Password NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Users (FirstName, LastName, MiddleName, Birthdate, Email, Phone, Password)
    VALUES (@FirstName, @LastName, @MiddleName, @Birthdate, @Email, @Phone, @Password);
END;