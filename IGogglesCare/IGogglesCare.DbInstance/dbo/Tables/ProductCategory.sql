CREATE TABLE [dbo].[ProductCategory] (
    [Id]         BIGINT NOT NULL,
    [ProductId]  BIGINT NULL,
    [CategoryId] BIGINT NULL,
    CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductCategory_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id]),
    CONSTRAINT [FK_ProductCategory_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

