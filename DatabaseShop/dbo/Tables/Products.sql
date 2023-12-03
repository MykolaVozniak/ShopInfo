CREATE TABLE [dbo].[Products] (
    [Id]                 INT            IDENTITY (1, 1) NOT NULL,
    [CategoryId]         INT            NOT NULL,
    [ProductName]        NVARCHAR (50)  NOT NULL,
    [SKU]                INT            NOT NULL,
    [Price]              MONEY          NULL,
    [ImageURL]           NVARCHAR (255) NULL,
    [TaxGroup]           NVARCHAR (50)  NOT NULL,
    [Is18Plus]           BIT            NOT NULL,
    [IsExciseApplicable] BIT            NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Products_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id])
);

