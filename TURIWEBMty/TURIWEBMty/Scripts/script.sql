USE [TURIWEBMty]
GO
/****** Object:  Table [dbo].[logio]    Script Date: 11/28/2016 17:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logio](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Correo] [nvarchar](max) NULL,
	[Contraseña] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.logio] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horario]    Script Date: 11/28/2016 17:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Hora] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Horario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 11/28/2016 17:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Municipio]    Script Date: 11/28/2016 17:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Municipios] [nvarchar](max) NULL,
	[Poblacion] [int] NOT NULL,
	[Superficie] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Municipio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ubicacion]    Script Date: 11/28/2016 17:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ubicacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMunicipio] [int] NOT NULL,
	[Municipios_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Ubicacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transporte]    Script Date: 11/28/2016 17:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transporte](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Transportee] [nvarchar](max) NULL,
	[IdHorario] [datetime] NOT NULL,
	[Horarios_ID] [int] NULL,
 CONSTRAINT [PK_dbo.Transporte] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lugar]    Script Date: 11/28/2016 17:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lugar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NoLugar] [nvarchar](max) NULL,
	[IdMunicipio] [int] NOT NULL,
	[IdTransporte] [int] NOT NULL,
	[IdUbicacion] [int] NOT NULL,
	[Municipios_Id] [int] NULL,
	[Transportes_Id] [int] NULL,
	[Ubicaciones_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Lugar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_dbo.Lugar_dbo.Municipio_Municipios_Id]    Script Date: 11/28/2016 17:26:19 ******/
ALTER TABLE [dbo].[Lugar]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Lugar_dbo.Municipio_Municipios_Id] FOREIGN KEY([Municipios_Id])
REFERENCES [dbo].[Municipio] ([Id])
GO
ALTER TABLE [dbo].[Lugar] CHECK CONSTRAINT [FK_dbo.Lugar_dbo.Municipio_Municipios_Id]
GO
/****** Object:  ForeignKey [FK_dbo.Lugar_dbo.Transporte_Transportes_Id]    Script Date: 11/28/2016 17:26:19 ******/
ALTER TABLE [dbo].[Lugar]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Lugar_dbo.Transporte_Transportes_Id] FOREIGN KEY([Transportes_Id])
REFERENCES [dbo].[Transporte] ([Id])
GO
ALTER TABLE [dbo].[Lugar] CHECK CONSTRAINT [FK_dbo.Lugar_dbo.Transporte_Transportes_Id]
GO
/****** Object:  ForeignKey [FK_dbo.Lugar_dbo.Ubicacion_Ubicaciones_Id]    Script Date: 11/28/2016 17:26:19 ******/
ALTER TABLE [dbo].[Lugar]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Lugar_dbo.Ubicacion_Ubicaciones_Id] FOREIGN KEY([Ubicaciones_Id])
REFERENCES [dbo].[Ubicacion] ([Id])
GO
ALTER TABLE [dbo].[Lugar] CHECK CONSTRAINT [FK_dbo.Lugar_dbo.Ubicacion_Ubicaciones_Id]
GO
/****** Object:  ForeignKey [FK_dbo.Transporte_dbo.Horario_Horarios_ID]    Script Date: 11/28/2016 17:26:19 ******/
ALTER TABLE [dbo].[Transporte]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transporte_dbo.Horario_Horarios_ID] FOREIGN KEY([Horarios_ID])
REFERENCES [dbo].[Horario] ([ID])
GO
ALTER TABLE [dbo].[Transporte] CHECK CONSTRAINT [FK_dbo.Transporte_dbo.Horario_Horarios_ID]
GO
/****** Object:  ForeignKey [FK_dbo.Ubicacion_dbo.Municipio_Municipios_Id]    Script Date: 11/28/2016 17:26:19 ******/
ALTER TABLE [dbo].[Ubicacion]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Ubicacion_dbo.Municipio_Municipios_Id] FOREIGN KEY([Municipios_Id])
REFERENCES [dbo].[Municipio] ([Id])
GO
ALTER TABLE [dbo].[Ubicacion] CHECK CONSTRAINT [FK_dbo.Ubicacion_dbo.Municipio_Municipios_Id]
GO
