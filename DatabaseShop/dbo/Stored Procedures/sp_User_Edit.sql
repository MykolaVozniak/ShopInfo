CREATE PROCEDURE sp_User_Edit
    @UserId INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @MiddleName NVARCHAR(50),
    @Birthdate DATE,
    @Email NVARCHAR(MAX),
    @Phone NVARCHAR(20),
    @Password NVARCHAR(MAX)
AS
BEGIN
    UPDATE Users
    SET
        FirstName = @FirstName,
        LastName = @LastName,
        MiddleName = @MiddleName,
        Birthdate = @Birthdate,
        Email = @Email,
        Phone = @Phone,
        Password = @Password
    WHERE Id = @UserId;
END;