CREATE PROCEDURE sp_Shop_Create
    @ShopName NVARCHAR(MAX),
    @City NVARCHAR(MAX),
    @Adress NVARCHAR(MAX),
    @Email NVARCHAR(MAX),
    @Phone NVARCHAR(20),
    @PostalCode NVARCHAR(20)
AS
BEGIN
    INSERT INTO Shops (ShopName, City, Adress, Email, Phone, PostalCode)
    VALUES (@ShopName, @City, @Adress, @Email, @Phone, @PostalCode);
END;