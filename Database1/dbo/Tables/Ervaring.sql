CREATE TABLE [dbo].[Ervaring] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [DatumVan]     DATETIME2 (7)  NOT NULL,
    [DatumTm]      DATETIME2 (7)  NULL,
    [Organisatie]  NVARCHAR (MAX) NULL,
    [Functie]      NVARCHAR (MAX) NULL,
    [Project]      NVARCHAR (MAX) NOT NULL,
    [Beschrijving] NVARCHAR (MAX) NOT NULL,
    [CvId]         INT            NULL,
    CONSTRAINT [PK_Ervaring] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Ervaring_Cv_CvId] FOREIGN KEY ([CvId]) REFERENCES [dbo].[Cv] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Ervaring_CvId]
    ON [dbo].[Ervaring]([CvId] ASC);

