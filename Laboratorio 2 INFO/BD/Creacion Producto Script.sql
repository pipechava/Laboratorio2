USE [Lab2DB]
GO

ALTER TABLE [dbo].[Producto] DROP CONSTRAINT [DF__Producto__Precio__108B795B]
GO

/****** Object:  Table [dbo].[Producto]    Script Date: 8/19/2015 3:03:40 PM ******/
DROP TABLE [dbo].[Producto]
GO

/****** Object:  Table [dbo].[Producto]    Script Date: 8/19/2015 3:03:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Producto](
	[idProducto] [int] NOT NULL,
	[nombreProducto] [varchar](45) NOT NULL,
	[PrecioProducto] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0.00)) FOR [PrecioProducto]
GO


