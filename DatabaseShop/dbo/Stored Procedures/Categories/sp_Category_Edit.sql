CREATE PROCEDURE sp_Category_Edit
    @CategoryId INT,
    @MotherCategoryId INT,
    @ShopId INT,
    @CategoryName NVARCHAR(25),
    @CategoryDescription NVARCHAR(MAX)
AS
BEGIN
    UPDATE Categories
    SET
        MotherCategoryId = @MotherCategoryId,
        ShopId = @ShopId,
        CategoryName = @CategoryName,
        CategoryDescription = @CategoryDescription
    WHERE Id = @CategoryId;
END;