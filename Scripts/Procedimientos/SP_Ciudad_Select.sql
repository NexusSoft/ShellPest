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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Ciudad_Select')
DROP PROCEDURE SP_Ciudad_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Ciudad_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select est.Id_Ciudad
	      ,est.Nombre_Ciudad
		  ,est.Id_Estado
		  ,P.Nombre_Estado
		  ,est.Id_Usuario_Crea
	      ,us.Nombre_Usuario as Creador
	      ,est.Id_Usuario_Mod 
	      ,usm.Nombre_Usuario as Modificador
		from t_Ciudades as est
		left join t_Estado as P on P.Id_Estado=est.Id_Estado
		left join t_Usuarios as us on us.Id_Usuario=est.Id_Usuario_Crea 
		left join t_Usuarios as usm on usm.Id_Usuario=est.Id_Usuario_Mod 

END
GO
