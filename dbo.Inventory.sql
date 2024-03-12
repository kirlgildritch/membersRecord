CREATE TABLE [dbo].[Inventory]

(
	 [SKU]         VARCHAR (50)    NOT NULL,
    [Name]        VARCHAR (100)   NOT NULL,
    [Category]    VARCHAR (50)    NOT NULL,
    [Price]       DECIMAL (18, 2) NULL,
    [Description] VARCHAR (255)   NULL,
    [Quantity]    INT             NULL

)
