CREATE PROCEDURE sp_Employee_Delete
    @EmployeeId INT
AS
BEGIN
    DELETE FROM Employees WHERE Id = @EmployeeId;
END;