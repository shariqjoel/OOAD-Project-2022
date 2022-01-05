CREATE TABLE [dbo].[Users] (
    [Id]              BIGINT         NOT NULL,
    [Name]            NVARCHAR (MAX) NULL,
    [EmailAddress]    NVARCHAR (MAX) NULL,
    [Phone]           NVARCHAR (MAX) NULL,
    [Password]        NVARCHAR (MAX) NULL,
    [BillingAddress]  NVARCHAR (MAX) NULL,
    [ShippingAddress] NVARCHAR (MAX) NULL,
    [IsActive]        BIT            NULL,
    [CreatedDate]     DATETIME       NULL,
    [UpdatedDate]     DATETIME       NULL,
    [CreatedBy]       BIGINT         NULL,
    [UpdatedBy]       BIGINT         NULL,
    [RoleId]          BIGINT         NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Users_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([Id])
);

