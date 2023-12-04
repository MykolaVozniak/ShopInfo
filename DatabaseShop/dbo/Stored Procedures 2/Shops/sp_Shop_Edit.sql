CREATE PROCEDURE sp_Shop_Edit
    @ShopId INT,
    @ShopName NVARCHAR(MAX),
    @City NVARCHAR(MAX),
    @Adress NVARCHAR(MAX),
    @Email NVARCHAR(MAX),
    @Phone NVARCHAR(20),
    @PostalCode NVARCHAR(20)
AS
BEGIN
    UPDATE Shops
    SET
        ShopName = @ShopName,
        City = @City,
        Adress = @Adress,
        Email = @Email,
        Phone = @Phone,
        PostalCode = @PostalCode
    WHERE Id = @ShopId;
END;