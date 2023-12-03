CREATE PROCEDURE sp_Employee_Edit
    @EmployeeId INT,
    @UserId INT,
    @RoleId INT,
    @HireDate DATETIME,
    @IsOwner BIT
AS
BEGIN
    UPDATE Employees
    SET
        UserId = @UserId,
        RoleId = @RoleId,
        HireDate = @HireDate,
        IsOwner = @IsOwner
    WHERE Id = @EmployeeId;
END;