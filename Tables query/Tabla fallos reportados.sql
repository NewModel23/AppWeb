USE [TIEMPOS_MUERTOS]
GO

/****** Object:  Table [MAGNA\p.rguerrero].[FALLOS_REPORTADOS]    Script Date: 18/01/2018 12:06:19 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[FALLOS_REPORTADOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DATETIME] [date] NULL,
	[HORA] [numeric](2, 0) NULL,
	[FECHA_MAGNA] [date] NULL,
	[PARTE] [numeric](15, 0) NULL,
	[DESCRIPCION] [varchar](100) NULL,
	[AMBIENTE] [varchar](20) NULL,
	[TIPO_FALLA] [varchar](50) NULL,
	[MODO_FALLA] [varchar](50) NULL,
	[CAUSA_FALLA] [varchar](50) NULL,
	[MINUTOS] [numeric](3, 0) NULL,
	[MIN_PRODUCCION] [numeric](3, 0) NULL,
	[MIN_FALLA] [numeric](3, 0) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


