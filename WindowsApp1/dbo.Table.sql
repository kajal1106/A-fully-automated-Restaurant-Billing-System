CREATE TABLE [dbo].[FULL_Menu]
(
	[Item_code] INT NOT NULL PRIMARY KEY, 
    [Item_name] NVARCHAR(50) NOT NULL, 
    [Category] VARCHAR(MAX) NOT NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [Price] INT NOT NULL, 
    [Tax] INT NULL, 
     
)
