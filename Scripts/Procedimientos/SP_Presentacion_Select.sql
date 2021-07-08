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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Presentacion_Select')
DROP PROCEDURE SP_Presentacion_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Presentacion_Select
	-- Add the parameters for the stored procedure here
	@Activo char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select dt.Id_Presentacion
	      ,dt.Nombre_Presentacion
		  ,dt.Id_TipoAplicacion
		  ,t.Nombre_TipoAplicacion
		  ,dt.Id_Unidad
		  ,uni.Nombre_Unidad
	      ,dt.Id_Usuario_Crea
	      ,us.Nombre_Usuario as Creador
	      ,dt.Id_Usuario_Mod 
	      ,usm.Nombre_Usuario as Modificador
		from t_Presentacion as dt
		inner join t_TipoAplicacion as t on t.Id_TipoAplicacion=dt.Id_TipoAplicacion
		inner join t_Unidad as uni on uni.Id_Unidad=dt.Id_Unidad
		inner join t_Usuarios as us on us.Id_Usuario=dt.Id_Usuario_Crea 
		left join t_Usuarios as usm on usm.Id_Usuario=dt.Id_Usuario_Mod 
		where dt.Activo=@Activo

END
GO
