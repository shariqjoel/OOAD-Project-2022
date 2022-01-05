CREATE TABLE [dbo].[LensesType] (
    [Id]          BIGINT         NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_LensesType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

