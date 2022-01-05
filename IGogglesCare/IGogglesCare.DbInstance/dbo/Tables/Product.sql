CREATE TABLE [dbo].[Product] (
    [Id]              BIGINT         NOT NULL,
    [Name]            NVARCHAR (MAX) NULL,
    [Descriptions]    NVARCHAR (MAX) NULL,
    [Material]        NVARCHAR (MAX) NULL,
    [SKU]             NVARCHAR (MAX) NULL,
    [Price]           BIGINT         NULL,
    [EyeHeight]       BIGINT         NULL,
    [EyeWidth]        BIGINT         NULL,
    [NoseBridge]      BIGINT         NULL,
    [TempleSize]      BIGINT         NULL,
    [FrameSize]       BIGINT         NULL,
    [FrameShape]      BIGINT         NULL,
    [IsFeatured]      BIT            NULL,
    [IsActive]        BIT            NULL,
    [CreatedDate]     DATETIME       NULL,
    [UpdatedDate]     DATETIME       NULL,
    [CreatedBy]       BIGINT         NULL,
    [UpdatedBy]       BIGINT         NULL,
    [ProductQuantity] BIGINT         NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC)
);

