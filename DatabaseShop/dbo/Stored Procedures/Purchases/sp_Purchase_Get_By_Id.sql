CREATE PROCEDURE sp_Purchase_Get_By_Id
    @PurchaseId INT
AS
BEGIN
    SELECT * FROM Purchases WHERE Id = @PurchaseId;
END;