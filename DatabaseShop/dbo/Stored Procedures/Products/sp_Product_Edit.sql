CREATE PROCEDURE sp_Product_Edit
    @ProductId INT,
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
    UPDATE Products
    SET
        CategoryId = @CategoryId,
        ProductName = @ProductName,
        SKU = @SKU,
        Price = @Price,
        ImageURL = @ImageURL,
        TaxGroup = @TaxGroup,
        Is18Plus = @Is18Plus,
        IsExciseApplicable = @IsExciseApplicable
    WHERE Id = @ProductId;
END;