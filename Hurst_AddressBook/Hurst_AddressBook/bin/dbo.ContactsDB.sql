CREATE TABLE [dbo].[ContactsDB] (
    [Id]          INT          NOT NULL IDENTITY,
    [FirstName]   VARCHAR (50) NOT NULL,
    [LastName]    VARCHAR (50) NOT NULL,
    [Address]     VARCHAR (50) NOT NULL,
    [State]       VARCHAR (50) NOT NULL,
    [City]        VARCHAR (50) NOT NULL,
    [Zip]         VARCHAR (50) NOT NULL,
    [PhoneNumber] VARCHAR (50) NOT NULL,
    [Email]       VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

