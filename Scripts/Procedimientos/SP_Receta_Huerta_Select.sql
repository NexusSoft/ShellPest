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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Receta_Huerta_Select')
DROP PROCEDURE SP_Receta_Huerta_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Receta_Huerta_Select
	-- Add the parameters for the stored procedure here
	@c_codigo_eps char(2),
	@Id_Receta char(7)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select dt.c_codigo_eps 
	      ,dt.Id_Huerta,
		  dt.Id_Receta,
		  hue.Nombre_Huerta
		from t_Receta_Huerta as dt
		inner join t_Huerta as hue on hue.Id_Huerta=dt.Id_huerta and hue.c_codigo_eps=dt.c_codigo_eps
		where dt.c_codigo_eps=@c_codigo_eps and Id_Receta=@Id_Receta
		

END
GO