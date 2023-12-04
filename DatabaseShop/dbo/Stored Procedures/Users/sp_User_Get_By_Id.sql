CREATE PROCEDURE sp_User_Get_By_Id
    @UserId INT
AS
BEGIN
    SELECT * FROM Users WHERE Id = @UserId;
END;