CREATE PROCEDURE sp_Category_Delete
    @CategoryId INT
AS
BEGIN
    DELETE FROM Categories WHERE Id = @CategoryId;
END;