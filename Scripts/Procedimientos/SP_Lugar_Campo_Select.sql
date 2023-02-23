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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Lugar_Campo_Select')
DROP PROCEDURE SP_Lugar_Campo_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Lugar_Campo_Select
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT  lc.c_codigo_cam,
		c.v_nombre_cam,
		lc.c_codigo_lug,
		l.v_nombre_lug
  	FROM t_lugar_campo as lc
  	left join GrupoAGV.dbo.nomlugarp as l on l.c_codigo_lug=lc.c_codigo_lug
  	left join GrupoAGV.dbo.coscampo as c on c.c_codigo_cam=lc.c_codigo_cam
				
END
GO
