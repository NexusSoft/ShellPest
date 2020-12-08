USE [Transportes]
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Bloque_Select')
DROP PROCEDURE SP_Bloque_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Bloque_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select dt.Id_Bloque
	      ,dt.Nombre_Bloque
	      ,dt.Id_Huerta
	      ,hue.Nombre_Huerta
	      ,dt.Id_Usuario_Crea
	      ,us.Nombre_Usuario as Creador
	      ,dt.Id_Usuario_Mod 
	      ,usm.Nombre_Usuario as Modificador
		from t_Bloque as dt
		inner join t_Usuarios as us on us.Id_Usuario=dt.Id_Usuario_Crea 
		left join t_Usuarios as usm on usm.Id_Usuario=dt.Id_Usuario_Mod 
		left join t_huerta as hue on hue.Id_huerta=dt.Id_huerta

END
GO
