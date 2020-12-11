USE [ShellPest]
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Huerta_Select')
DROP PROCEDURE SP_Huerta_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Huerta_Select
	-- Add the parameters for the stored procedure here
	@Activo bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		SELECT Huerta.Id_Huerta, Huerta.Nombre_Huerta, Huerta.Registro_Huerta, 
			Huerta.Id_Duenio, Duenio.Nombre_Productor, Huerta.Id_Estado, Estado.Nombre_Estado, 
			Huerta.Id_Ciudad, Ciudades.Nombre_Ciudad, Huerta.Id_Calidad, 
			Calidades.Nombre_Calidad, Huerta.Id_Cultivo, Cultivo.Nombre_Cultivo, 
			Huerta.zona_Huerta, Huerta.banda_Huerta, Huerta.este_Huerta, Huerta.norte_Huerta, 
			Huerta.asnm_Huerta, Huerta.latitud_Huerta, Huerta.longitud_Huerta, 
			Huerta.Activa_Huerta,
			Huerta.Id_Usuario_Crea
	      ,us.Nombre_Usuario as Creador
	      ,Huerta.Id_Usuario_Mod 
	      ,usm.Nombre_Usuario as Modificador
		FROM t_Huerta as Huerta
		INNER JOIN t_productor  as Duenio ON Huerta.Id_Duenio = Duenio.Id_Productor
		INNER JOIN t_Estado as Estado ON Huerta.Id_Estado = Estado.Id_Estado 
		INNER JOIN t_Ciudades as Ciudades ON Huerta.Id_Ciudad = Ciudades.Id_Ciudad 
		INNER JOIN t_Calidad as Calidades ON Huerta.Id_Calidad = Calidades.Id_Calidad 
		INNER JOIN t_Cultivo as Cultivo ON Huerta.Id_Cultivo = Cultivo.Id_Cultivo
		inner join t_Usuarios as us on us.Id_Usuario=Huerta.Id_Usuario_Crea 
		left join t_Usuarios as usm on usm.Id_Usuario=Huerta.Id_Usuario_Mod 
		where Huerta.Activa_Huerta=@Activo

END
GO
