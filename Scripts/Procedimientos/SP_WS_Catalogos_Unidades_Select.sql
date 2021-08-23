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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Catalogos_Unidades_Select')
DROP PROCEDURE SP_WS_Catalogos_Unidades_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_WS_Catalogos_Unidades_Select
	-- Add the parameters for the stored procedure here
	@Fecha varchar(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select c_codigo_uni,
			v_nombre_uni,
			v_abrevia_uni 
		from agv.dbo.invunidad 
		where c_activo_uni ='1'
		and (d_modifi_uni>=@Fecha or d_creacion_uni>=@Fecha)		
END
GO
