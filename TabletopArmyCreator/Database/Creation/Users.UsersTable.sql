
-- Create the Users Table
-- Modified:
--			23/12/2022 - Initial script

USE TabletopArmyCreator

IF(NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'UsersTable' AND TABLE_SCHEMA = 'Users'))
BEGIN
	CREATE TABLE Users.UsersTable(
									UserID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
									Username NVARCHAR(50) NOT NULL,
									ModifiedWhen DATETIME NOT NULL DEFAULT(GETDATE())
								)
END