CREATE PROCEDURE sp_User_Update
    @UserId INT,
    @FirstName NVARCHAR(255),
    @LastName NVARCHAR(255),
    @MiddleName NVARCHAR(255),
    @Birthdate DATE,
    @Email NVARCHAR(255),
    @Phone NVARCHAR(20),
    @Password NVARCHAR(255)
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
    WHERE
        Id = @UserId;
END;