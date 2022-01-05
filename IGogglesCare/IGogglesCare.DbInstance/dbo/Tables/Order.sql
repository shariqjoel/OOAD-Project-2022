CREATE TABLE [dbo].[Order] (
    [Id]              BIGINT         NOT NULL,
    [CustomerId]      NVARCHAR (MAX) NULL,
    [CustomerName]    NVARCHAR (MAX) NULL,
    [Company]         NVARCHAR (MAX) NULL,
    [BillingAddress]  NVARCHAR (MAX) NULL,
    [ShippingAddress] NVARCHAR (MAX) NULL,
    [ContactNumber]   NVARCHAR (MAX) NULL,
    [Email]           NVARCHAR (MAX) NULL,
    [OrderDate]       DATETIME       NULL,
    [OrderStatus]     NVARCHAR (MAX) NULL,
    [IsActive]        BIT            NULL,
    [CreatedDate]     DATETIME       NULL,
    [UpdatedDate]     DATETIME       NULL,
    [CreatedBy]       BIGINT         NULL,
    [UpdatedBy]       BIGINT         NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([Id] ASC)
);

