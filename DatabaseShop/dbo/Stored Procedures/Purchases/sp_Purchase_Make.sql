CREATE PROCEDURE sp_Purchase_Make
    @ProductId INT,
    @UserId INT,
    @PurchaseTime DATETIME
AS
BEGIN
    INSERT INTO Purchases (ProductId, UserId, PurchaseTime)
    VALUES (@ProductId, @UserId, @PurchaseTime);
END;