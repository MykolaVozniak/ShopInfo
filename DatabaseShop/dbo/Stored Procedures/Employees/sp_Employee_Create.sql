CREATE PROCEDURE sp_Employee_Create
    @UserId INT,
    @RoleId INT,
    @HireDate DATETIME,
    @IsOwner BIT
AS
BEGIN
    INSERT INTO Employees (UserId, RoleId, HireDate, IsOwner)
    VALUES (@UserId, @RoleId, @HireDate, @IsOwner);
END;