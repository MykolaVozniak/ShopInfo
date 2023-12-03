CREATE PROCEDURE sp_User_Delete
    @UserId INT
AS
BEGIN
    DELETE FROM Users WHERE Id = @UserId;
END;