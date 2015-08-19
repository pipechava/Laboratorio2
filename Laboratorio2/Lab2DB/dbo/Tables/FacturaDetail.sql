CREATE TABLE [dbo].[FacturaDetail] (
    [Factura_idFactura]   INT NOT NULL,
    [Producto_idProducto] INT NOT NULL,
    [CantidadProducto]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Factura_idFactura] ASC, [Producto_idProducto] ASC),
    FOREIGN KEY ([Factura_idFactura]) REFERENCES [dbo].[Factura] ([idFactura]),
    FOREIGN KEY ([Producto_idProducto]) REFERENCES [dbo].[Producto] ([idProducto])
);

