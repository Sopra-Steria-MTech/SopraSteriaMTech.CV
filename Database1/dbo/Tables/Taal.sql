CREATE TABLE [dbo].[Taal] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Naam]         NVARCHAR (MAX) NOT NULL,
    [Schriftelijk] INT            NOT NULL,
    [Mondeling]    INT            NOT NULL,
    [CvId]         INT            NULL,
    CONSTRAINT [PK_Taal] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Taal_Cv_CvId] FOREIGN KEY ([CvId]) REFERENCES [dbo].[Cv] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Taal_CvId]
    ON [dbo].[Taal]([CvId] ASC);

