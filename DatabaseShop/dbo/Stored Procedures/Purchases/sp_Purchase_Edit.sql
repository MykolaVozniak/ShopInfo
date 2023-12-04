CREATE PROCEDURE sp_Purchase_Edit
    @PurchaseId INT,
    @ProductId INT,
    @UserId INT,
    @PurchaseTime DATETIME
AS
BEGIN
    UPDATE Purchases
    SET
        ProductId = @ProductId,
        UserId = @UserId,
        PurchaseTime = @PurchaseTime
    WHERE Id = @PurchaseId;
END;