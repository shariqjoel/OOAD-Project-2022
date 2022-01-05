CREATE TABLE [dbo].[Role] (
    [Id]          BIGINT         NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [UpdatedBy]   BIGINT         NULL,
    [IsActive]    BIT            NULL,
    [CreatedDate] DATETIME       NULL,
    [UpdatedDate] DATETIME       NULL,
    [CreatedBy]   BIGINT         NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED ([Id] ASC)
);

