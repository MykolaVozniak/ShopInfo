CREATE TABLE [dbo].[Purchases] (
    [Id]           INT      IDENTITY (1, 1) NOT NULL,
    [ProductId]    INT      NOT NULL,
    [UserId]       INT      NOT NULL,
    [PurchaseTime] DATETIME NOT NULL,
    CONSTRAINT [PK_Purchases] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Purchases_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]),
    CONSTRAINT [FK_Purchases_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

