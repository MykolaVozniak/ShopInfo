CREATE PROCEDURE sp_Product_Delete
    @ProductId INT
AS
BEGIN
    DELETE FROM Products WHERE Id = @ProductId;
END;