CREATE PROCEDURE sp_Category_Get_By_Id
    @CategoryId INT
AS
BEGIN
    SELECT * FROM Categories WHERE Id = @CategoryId;
END;