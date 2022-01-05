CREATE TABLE [dbo].[Category] (
    [Id]          BIGINT         NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Image]       NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [UpdatedBy]   BIGINT         NULL,
    [IsActive]    BIT            NULL,
    [CreatedDate] DATETIME       NULL,
    [UpdatedDate] DATETIME       NULL,
    [CreatedBy]   BIGINT         NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Id] ASC)
);

