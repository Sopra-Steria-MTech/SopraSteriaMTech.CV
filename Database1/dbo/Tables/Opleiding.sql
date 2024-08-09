CREATE TABLE [dbo].[Opleiding] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [School]   NVARCHAR (MAX) NOT NULL,
    [Niveau]   NVARCHAR (MAX) NULL,
    [DatumVan] DATETIME2 (7)  NOT NULL,
    [DatumTm]  DATETIME2 (7)  NULL,
    [Diploma]  BIT            NOT NULL,
    [CvId]     INT            NULL,
    CONSTRAINT [PK_Opleiding] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Opleiding_Cv_CvId] FOREIGN KEY ([CvId]) REFERENCES [dbo].[Cv] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Opleiding_CvId]
    ON [dbo].[Opleiding]([CvId] ASC);

