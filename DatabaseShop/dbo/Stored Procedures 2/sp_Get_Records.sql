CREATE PROCEDURE sp_Get_Records
    @TableName NVARCHAR(255), 
    @nCount INT,
    @isASC BIT
AS
BEGIN
    DECLARE @SqlQuery NVARCHAR(MAX);

    SET @SqlQuery = N'SELECT TOP (@nCount) * FROM ' + QUOTENAME(@TableName) +
    CASE WHEN @isASC = 1 THEN ' ORDER BY ID ASC' ELSE ' ORDER BY ID DESC' END;

    EXEC sp_executesql @SqlQuery, N'@nCount INT', @nCount;
END;