CREATE TABLE [dbo].[Roles] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [ShopId]          INT            NOT NULL,
    [RoleName]        NVARCHAR (50)  NOT NULL,
    [RoleDescription] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Roles_Shops] FOREIGN KEY ([ShopId]) REFERENCES [dbo].[Shops] ([Id])
);

