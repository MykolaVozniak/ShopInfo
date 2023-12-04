CREATE PROCEDURE sp_Shop_Get_By_Id
    @ShopId INT
AS
BEGIN
    SELECT * FROM Shops WHERE Id = @ShopId;
END;