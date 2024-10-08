CREATE TABLE [dbo].[users] (
    [id]         INT          IDENTITY (1, 1) NOT NULL,
    [first_name] VARCHAR (50) NOT NULL,
    [last_name]  VARCHAR (50) NOT NULL,
    [email]      VARCHAR (50) NOT NULL,
    [age]        INT          DEFAULT ((18)) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([email] ASC)
);

