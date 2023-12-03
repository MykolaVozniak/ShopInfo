CREATE TABLE [dbo].[Shops] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [ShopName]   NVARCHAR (MAX) NOT NULL,
    [City]       NVARCHAR (MAX) NOT NULL,
    [Adress]     NVARCHAR (MAX) NOT NULL,
    [Email]      NVARCHAR (MAX) NOT NULL,
    [Phone]      NVARCHAR (20)  NOT NULL,
    [PostalCode] NVARCHAR (20)  NOT NULL,
    CONSTRAINT [PK__Shops] PRIMARY KEY CLUSTERED ([Id] ASC)
);

