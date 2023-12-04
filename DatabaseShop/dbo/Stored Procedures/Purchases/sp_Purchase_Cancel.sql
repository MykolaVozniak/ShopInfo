CREATE PROCEDURE sp_Purchase_Cancel
    @PurchaseId INT
AS
BEGIN
    DELETE FROM Purchases WHERE Id = @PurchaseId;
END;