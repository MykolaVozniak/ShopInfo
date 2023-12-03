CREATE PROCEDURE sp_Role_Create
    @ShopId INT,
    @RoleName NVARCHAR(50),
    @RoleDescription NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Roles (ShopId, RoleName, RoleDescription)
    VALUES (@ShopId, @RoleName, @RoleDescription);
END;