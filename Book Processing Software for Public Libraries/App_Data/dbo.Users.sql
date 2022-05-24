CREATE TABLE [dbo].[Users] (
    [Id]       INT          NOT NULL,
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    [isAdmin]  VARCHAR (50) NOT NULL,
	[cardNumber]  VARCHAR (50) NOT NULL,
	[cardPIN]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

