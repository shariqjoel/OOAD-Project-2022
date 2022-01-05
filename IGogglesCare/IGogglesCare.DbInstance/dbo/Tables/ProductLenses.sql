CREATE TABLE [dbo].[ProductLenses] (
    [Id]        BIGINT NOT NULL,
    [ProductId] BIGINT NULL,
    [LensesId]  BIGINT NULL,
    CONSTRAINT [PK_ProductLenses] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductLenses_LensesType] FOREIGN KEY ([LensesId]) REFERENCES [dbo].[LensesType] ([Id]),
    CONSTRAINT [FK_ProductLenses_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

