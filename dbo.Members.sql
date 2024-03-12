CREATE TABLE [dbo].[Members] (
    [FullName]         VARCHAR (MAX)   NULL,
    [Gender]           VARCHAR (MAX)   NULL,
    [Age]              INT             NULL,
    [DateOfBirth]      DATE            NULL,
    [Address]          VARCHAR (255)   NULL,
    [DateOfMembership] DATE            NULL,
    [ShareCapital]     DECIMAL (20, 2) NULL,
    [Attendance]       VARCHAR (255)   NULL, 
    [No.] INT IDENTITY(1,1) PRIMARY KEY
);

