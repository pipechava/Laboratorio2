USE [Lab2DB]
GO

ALTER TABLE [dbo].[Factura] DROP CONSTRAINT [DF__Factura__PrecioT__1367E606]
GO

/****** Object:  Table [dbo].[Factura]    Script Date: 8/19/2015 3:03:32 PM ******/
DROP TABLE [dbo].[Factura]
GO

/****** Object:  Table [dbo].[Factura]    Script Date: 8/19/2015 3:03:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Factura](
	[idFactura] [int] NOT NULL,
	[FechaFactura] [datetime] NOT NULL,
	[PrecioTotal] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Factura] ADD  DEFAULT ((0.00)) FOR [PrecioTotal]
GO


