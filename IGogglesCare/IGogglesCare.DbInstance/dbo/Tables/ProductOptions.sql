CREATE TABLE [dbo].[ProductOptions] (
    [Id]          BIGINT NOT NULL,
    [CT_OptionId] BIGINT NULL,
    [ProductId]   BIGINT NULL,
    CONSTRAINT [PK_ProductOptions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductOptions_CT_Option] FOREIGN KEY ([CT_OptionId]) REFERENCES [dbo].[CT_Option] ([Id]),
    CONSTRAINT [FK_ProductOptions_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

