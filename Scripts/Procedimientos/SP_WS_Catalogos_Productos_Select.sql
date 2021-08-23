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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Catalogos_Productos_Select')
DROP PROCEDURE SP_WS_Catalogos_Productos_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_WS_Catalogos_Productos_Select
	-- Add the parameters for the stored procedure here
	@Fecha varchar(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select c_codigo_pro,
			v_nombre_pro,
			c_codigo_uni,
			n_stockminimo_pro,
			n_movimiento_pro 
		from agv.dbo.invproducto 
		where c_activo_pro='1'
		and (d_modifi_pro >=@Fecha or d_creacion_pro >=@Fecha)		
END
GO
