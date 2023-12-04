CREATE PROCEDURE sp_Role_Edit
    @RoleId INT,
    @ShopId INT,
    @RoleName NVARCHAR(50),
    @RoleDescription NVARCHAR(MAX)
AS
BEGIN
    UPDATE Roles
    SET
        ShopId = @ShopId,
        RoleName = @RoleName,
        RoleDescription = @RoleDescription
    WHERE Id = @RoleId;
END;