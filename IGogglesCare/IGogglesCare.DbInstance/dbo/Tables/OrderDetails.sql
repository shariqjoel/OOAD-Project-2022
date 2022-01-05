CREATE TABLE [dbo].[OrderDetails] (
    [Id]        BIGINT         NOT NULL,
    [OrderId]   BIGINT         NULL,
    [ProductId] BIGINT         NULL,
    [SKU]       NVARCHAR (MAX) NULL,
    [Quantity]  BIGINT         NULL,
    CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OrderDetails_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([Id])
);

