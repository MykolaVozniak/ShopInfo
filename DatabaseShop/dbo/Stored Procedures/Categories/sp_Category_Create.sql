CREATE PROCEDURE sp_Category_Create
    @MotherCategoryId INT,
    @ShopId INT,
    @CategoryName NVARCHAR(25),
    @CategoryDescription NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Categories (MotherCategoryId, ShopId, CategoryName, CategoryDescription)
    VALUES (@MotherCategoryId, @ShopId, @CategoryName, @CategoryDescription);
END;