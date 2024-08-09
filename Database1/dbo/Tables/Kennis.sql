CREATE TABLE [dbo].[Kennis] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Kennisgebied] NVARCHAR (MAX) NOT NULL,
    [Kennisniveau] INT            NOT NULL,
    [Jaren]        INT            NOT NULL,
    [CvId]         INT            NULL,
    CONSTRAINT [PK_Kennis] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Kennis_Cv_CvId] FOREIGN KEY ([CvId]) REFERENCES [dbo].[Cv] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Kennis_CvId]
    ON [dbo].[Kennis]([CvId] ASC);

