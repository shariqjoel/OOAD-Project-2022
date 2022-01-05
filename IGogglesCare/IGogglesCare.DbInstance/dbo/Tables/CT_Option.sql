CREATE TABLE [dbo].[CT_Option] (
    [Id]          BIGINT         NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_CT_Option] PRIMARY KEY CLUSTERED ([Id] ASC)
);

