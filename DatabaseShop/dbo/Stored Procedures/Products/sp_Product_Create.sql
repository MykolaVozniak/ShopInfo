CREATE PROCEDURE sp_Product_Create
    @CategoryId INT,
    @ProductName NVARCHAR(50),
    @SKU INT,
    @Price MONEY,
    @ImageURL NVARCHAR(255),
    @TaxGroup NVARCHAR(50),
    @Is18Plus BIT,
    @IsExciseApplicable BIT
AS
BEGIN
    INSERT INTO Products (CategoryId, ProductName, SKU, Price, ImageURL, TaxGroup, Is18Plus, IsExciseApplicable)
    VALUES (@CategoryId, @ProductName, @SKU, @Price, @ImageURL, @TaxGroup, @Is18Plus, @IsExciseApplicable);
END;