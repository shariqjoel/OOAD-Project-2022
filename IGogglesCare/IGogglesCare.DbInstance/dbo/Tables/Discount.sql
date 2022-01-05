CREATE TABLE [dbo].[Discount] (
    [Id]              BIGINT   NOT NULL,
    [DiscountPercent] BIGINT   NULL,
    [Expiry]          DATETIME NULL,
    [IsActive]        BIT      NULL,
    [CreatedDate]     DATETIME NULL,
    [UpdatedDate]     DATETIME NULL,
    [CreatedBy]       BIGINT   NULL,
    [UpdatedBy]       BIGINT   NULL,
    CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED ([Id] ASC)
);

