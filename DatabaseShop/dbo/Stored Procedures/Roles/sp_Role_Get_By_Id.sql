CREATE PROCEDURE sp_Role_Get_By_Id
    @RoleId INT
AS
BEGIN
    SELECT * FROM Roles WHERE Id = @RoleId;
END;