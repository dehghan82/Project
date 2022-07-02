CREATE TABLE [dbo].[TableUser]
(
	[user_name] VARCHAR(MAX) NOT NULL PRIMARY KEY, 
    [password] VARCHAR(MAX) NOT NULL, 
    [name] VARCHAR(50) NOT NULL, 
    [phone_number] VARCHAR(MAX) NOT NULL, 
    [mojodi] INT NULL
)
