
-- Get User data
-- Modified:
--			23/12/2022 - Initial script

USE TabletopArmyCreator
GO

CREATE OR ALTER PROCEDURE Users.GetUserData
(
	@UserId INT
)
AS
BEGIN
	SELECT ut.Username
	FROM Users.UsersTable ut
END