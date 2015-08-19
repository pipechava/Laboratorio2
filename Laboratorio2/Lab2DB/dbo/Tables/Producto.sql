CREATE TABLE [dbo].[Producto] (
    [idProducto]     INT          NOT NULL,
    [nombreProducto] VARCHAR (45) NOT NULL,
    [PrecioProducto] MONEY        DEFAULT ((0.00)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idProducto] ASC)
);

