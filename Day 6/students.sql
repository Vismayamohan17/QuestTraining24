CREATE TABLE [dbo].[students] (
    [id]    INT           IDENTITY (1, 1) NOT NULL,
    [name]  VARCHAR (50)  NOT NULL,
    [email] VARCHAR (100) NOT NULL,
    [class] INT           DEFAULT ((1)) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([email] ASC)
);

