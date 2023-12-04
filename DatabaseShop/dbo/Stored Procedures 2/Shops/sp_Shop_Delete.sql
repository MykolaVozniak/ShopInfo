CREATE PROCEDURE sp_Shop_Delete
    @ShopId INT
AS
BEGIN
    DELETE FROM Shops WHERE Id = @ShopId;
END;