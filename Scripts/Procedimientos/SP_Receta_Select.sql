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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Receta_Select')
DROP PROCEDURE SP_Receta_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Receta_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select dt.Id_Receta
	      ,dt.Fecha_Receta
		  ,dt.Id_AsesorTecnico
		  ,ast.Nombre_AsesorTecnico
		  ,dt.Id_MonitoreoPE
		  ,dt.Id_Cultivo
		  ,cul.Nombre_Cultivo
		  ,dt.Id_TipoAplicacion
		  ,ta.Nombre_TipoAplicacion
		  ,dt.Id_Presentacion
		  ,pre.Nombre_Presentacion
		  ,pre.Id_Unidad
		  ,uni.v_nombre_uni
		  ,dt.Observaciones
		  ,dt.Intervalo_Seguridad
		  ,dt.Intervalo_Reingreso
	      ,dt.Id_Usuario_Crea
	      ,us.Nombre_Usuario as Creador
	      ,dt.Id_Usuario_Mod 
	      ,usm.Nombre_Usuario as Modificador
		  ,dt.Activo
		  ,dt.Id_Huerta
		  ,dt.Para
		from t_Receta as dt
		inner join t_AsesorTecnico as ast on ast.Id_AsesorTecnico=dt.Id_AsesorTecnico
		inner join t_Cultivo as cul on cul.Id_Cultivo=dt.Id_Cultivo
		inner join t_TipoAplicacion as ta on ta.Id_TipoAplicacion=dt.Id_TipoAplicacion
		inner join t_Presentacion pre on pre.Id_Presentacion=dt.Id_Presentacion
		inner join agv.dbo.invunidad as uni on uni.c_codigo_uni=pre.Id_Unidad
		inner join t_Usuarios as us on us.Id_Usuario=dt.Id_Usuario_Crea 
		left join t_Usuarios as usm on usm.Id_Usuario=dt.Id_Usuario_Mod 
		where dt.c_codigo_eps=@c_codigo_eps
		

END
GO
