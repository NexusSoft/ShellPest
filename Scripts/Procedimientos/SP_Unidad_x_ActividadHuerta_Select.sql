USE [Shellpest]
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Unidad_x_ActividadHuerta_Select')
DROP PROCEDURE SP_Unidad_x_ActividadHuerta_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Unidad_x_ActividadHuerta_Select
	-- Add the parameters for the stored procedure here
	@c_codigo_cam char(2),
	@c_codigo_act char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Unidad
		from t_Actividad_Campo 
		where c_codigo_cam=@c_codigo_cam
		and c_codigo_act=@c_codigo_act

END
GO
