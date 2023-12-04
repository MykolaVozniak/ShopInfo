CREATE PROCEDURE sp_Role_Delete
    @RoleId INT
AS
BEGIN
    DELETE FROM Roles WHERE Id = @RoleId;
END;