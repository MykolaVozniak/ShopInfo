CREATE PROCEDURE sp_Product_Get_By_Id
    @ProductId INT
AS
BEGIN
    SELECT * FROM Products WHERE Id = @ProductId;
END;