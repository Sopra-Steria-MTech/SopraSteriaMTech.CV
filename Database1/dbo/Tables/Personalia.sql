CREATE TABLE [dbo].[Personalia] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [Naam]          NVARCHAR (MAX)  NOT NULL,
    [Geboortedatum] DATETIME2 (7)   NOT NULL,
    [Woonplaats]    NVARCHAR (MAX)  NULL,
    [Foto]          VARBINARY (MAX) NULL,
    [Hobbies]       NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_Personalia] PRIMARY KEY CLUSTERED ([Id] ASC)
);

