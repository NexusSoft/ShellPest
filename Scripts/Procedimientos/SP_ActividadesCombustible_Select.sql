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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_ActividadesCombustible_Select')
DROP PROCEDURE SP_ActividadesCombustible_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_ActividadesCombustible_Select
	-- Add the parameters for the stored procedure here
	@c_codigo_cam char(2)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		Select distinct C.v_nombre_act, AC.c_codigo_cam, AC.c_codigo_act,AC.Id_Unidad
	from t_Actividad_Campo as AC 
	left join GrupoAGV.dbo.cosactividad as C 
	on  AC.c_codigo_act = C.c_codigo_act 
	where AC.c_codigo_cam = @c_codigo_cam or AC.c_codigo_cam = '00'
END
GO


