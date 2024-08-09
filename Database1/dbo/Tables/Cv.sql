CREATE TABLE [dbo].[Cv] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [PersonaliaId] INT NULL,
    CONSTRAINT [PK_Cv] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cv_Personalia_PersonaliaId] FOREIGN KEY ([PersonaliaId]) REFERENCES [dbo].[Personalia] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Cv_PersonaliaId]
    ON [dbo].[Cv]([PersonaliaId] ASC);

