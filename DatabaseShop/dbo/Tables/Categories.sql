CREATE TABLE [dbo].[Categories] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [MotherCategoryId]    INT            NULL,
    [ShopId]              INT            NOT NULL,
    [CategoryName]        NVARCHAR (25)  NOT NULL,
    [CategoryDescription] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Categories_Categories1] FOREIGN KEY ([MotherCategoryId]) REFERENCES [dbo].[Categories] ([Id]),
    CONSTRAINT [FK_Categories_Shops] FOREIGN KEY ([ShopId]) REFERENCES [dbo].[Shops] ([Id])
);

