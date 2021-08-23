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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Almacen_Huerta_Select')
DROP PROCEDURE SP_Almacen_Huerta_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Almacen_Huerta_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select alm.v_nombre_alm,
			hue.v_nombre_hue,
			ah.c_codigo_alm,
			ah.c_codigo_hue
		from t_Almacen_Huerto as ah
			left join agv.dbo.invalmacen as alm on alm.c_codigo_alm=ah.c_codigo_hue
			left join agv.dbo.t_huerto as hue on hue.c_codigo_hue=ah.c_codigo_hue
		where alm.c_activo_alm='1' and hue.c_activo_hue='1'

END
GO
