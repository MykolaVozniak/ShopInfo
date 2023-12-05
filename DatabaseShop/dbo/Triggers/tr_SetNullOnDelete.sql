CREATE TRIGGER tr_SetNullOnDelete
ON [dbo].[Categories]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE c
    SET c.[MotherCategoryId] = NULL
    FROM [dbo].[Categories] c
    INNER JOIN deleted d ON c.[MotherCategoryId] = d.[Id];
END;