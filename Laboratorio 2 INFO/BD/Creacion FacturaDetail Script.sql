USE [Lab2DB]
GO

ALTER TABLE [dbo].[FacturaDetail] DROP CONSTRAINT [FK__FacturaDe__Produ__173876EA]
GO

ALTER TABLE [dbo].[FacturaDetail] DROP CONSTRAINT [FK__FacturaDe__Factu__164452B1]
GO

/****** Object:  Table [dbo].[FacturaDetail]    Script Date: 8/19/2015 3:03:48 PM ******/
DROP TABLE [dbo].[FacturaDetail]
GO

/****** Object:  Table [dbo].[FacturaDetail]    Script Date: 8/19/2015 3:03:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FacturaDetail](
	[Factura_idFactura] [int] NOT NULL,
	[Producto_idProducto] [int] NOT NULL,
	[CantidadProducto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Factura_idFactura] ASC,
	[Producto_idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[FacturaDetail]  WITH CHECK ADD FOREIGN KEY([Factura_idFactura])
REFERENCES [dbo].[Factura] ([idFactura])
GO

ALTER TABLE [dbo].[FacturaDetail]  WITH CHECK ADD FOREIGN KEY([Producto_idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO


