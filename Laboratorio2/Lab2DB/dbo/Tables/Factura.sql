CREATE TABLE [dbo].[Factura] (
    [idFactura]    INT      NOT NULL,
    [FechaFactura] DATETIME NOT NULL,
    [PrecioTotal]  MONEY    DEFAULT ((0.00)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idFactura] ASC)
);

