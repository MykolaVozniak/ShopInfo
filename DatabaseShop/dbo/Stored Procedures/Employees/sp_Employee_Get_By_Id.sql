CREATE PROCEDURE sp_Employee_Get_By_Id
    @EmployeeId INT
AS
BEGIN
    SELECT * FROM Employees WHERE Id = @EmployeeId;
END;