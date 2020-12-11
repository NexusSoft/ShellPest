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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Estado_Select')
DROP PROCEDURE SP_Estado_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Estado_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select est.Id_Estado
	      ,est.Nombre_Estado
		  ,est.Id_Pais
		  ,P.Nombre_Pais 
		  ,est.Id_Usuario_Crea
	      ,us.Nombre_Usuario as Creador
	      ,est.Id_Usuario_Mod 
	      ,usm.Nombre_Usuario as Modificador
		from t_Estado as est
		left join t_Pais as P on P.Id_Pais=est.Id_Pais
		left join t_Usuarios as us on us.Id_Usuario=est.Id_Usuario_Crea 
		left join t_Usuarios as usm on usm.Id_Usuario=est.Id_Usuario_Mod 

END
GO
