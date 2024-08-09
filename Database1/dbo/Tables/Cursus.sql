CREATE TABLE [dbo].[Cursus] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Naam]        NVARCHAR (MAX) NULL,
    [Instituut]   NVARCHAR (MAX) NULL,
    [Datum]       DATETIME2 (7)  NOT NULL,
    [Certificaat] BIT            NULL,
    [CvId]        INT            NULL,
    CONSTRAINT [PK_Cursus] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cursus_Cv_CvId] FOREIGN KEY ([CvId]) REFERENCES [dbo].[Cv] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Cursus_CvId]
    ON [dbo].[Cursus]([CvId] ASC);

