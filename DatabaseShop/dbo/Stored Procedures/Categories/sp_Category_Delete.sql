CREATE PROCEDURE sp_Category_Delete
    @CategoryId INT
AS
BEGIN
    UPDATE [dbo].[Categories] SET [MotherCategoryId] = NULL WHERE [MotherCategoryId] = @CategoryId;
    DELETE FROM Categories WHERE Id = @CategoryId;
END;