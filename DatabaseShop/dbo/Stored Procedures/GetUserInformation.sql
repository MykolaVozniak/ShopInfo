CREATE PROCEDURE GetUserInformation
    @UserId INT
AS
BEGIN
    SELECT 
        [Id],
        [FirstName],
        [LastName],
        [MiddleName],
        [Birthdate],
        [Email],
        [Phone]
    FROM 
        [dbo].[Users]
    WHERE 
        [Id] = @UserId;
END;