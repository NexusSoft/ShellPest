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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_actividad_campo_Select')
DROP PROCEDURE SP_actividad_campo_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_actividad_campo_Select
	-- Add the parameters for the stored procedure here

	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select ac.c_codigo_act ,
			act.v_nombre_act ,
			ac.Id_Unidad,
			uni.Abreviatura,
			ac.c_codigo_cam,
			cam.v_nombre_cam  
		from ShellPest.dbo.t_Actividad_Campo ac
		left join ShellPest.dbo.t_Unidad as uni on uni.Id_Unidad =ac.Id_Unidad 
		left join GrupoAGV.dbo.cosactividad as act on act.c_codigo_act =ac.c_codigo_act 
		left join GrupoAGV.dbo.coscampo as cam on cam.c_codigo_cam =ac.c_codigo_cam 

END
GO


