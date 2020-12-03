USE [ShellPest]
GO

/****** Object:  Table [dbo].[t_Pais]    Script Date: 03/12/2020 01:47:31 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[t_Pais](
	[Id_Pais] [char](3) NOT NULL,
	[Nombre_Pais] [varchar](30) NOT NULL,
	[Id_Usuario_Crea] [varchar](10) NOT NULL,
	[F_Fecha_Crea] [datetime] NOT NULL,
	[Id_Usuario_Mod] [varchar](10) NULL,
	[F_Fecha_Mod] [datetime] NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[Id_Pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[t_Pais]  WITH CHECK ADD  CONSTRAINT [FK_t_Pais_t_Usuarios] FOREIGN KEY([Id_Usuario_Crea])
REFERENCES [dbo].[t_Usuarios] ([Id_Usuario])
GO

ALTER TABLE [dbo].[t_Pais] CHECK CONSTRAINT [FK_t_Pais_t_Usuarios]
GO

ALTER TABLE [dbo].[t_Pais]  WITH CHECK ADD  CONSTRAINT [FK_t_Pais_t_Usuarios1] FOREIGN KEY([Id_Usuario_Mod])
REFERENCES [dbo].[t_Usuarios] ([Id_Usuario])
GO

ALTER TABLE [dbo].[t_Pais] CHECK CONSTRAINT [FK_t_Pais_t_Usuarios1]
GO

