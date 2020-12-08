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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Perfiles_Pantallas_Select')
DROP PROCEDURE SP_Perfiles_Pantallas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Perfiles_Pantallas_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select PP.Id_Pantalla
	      ,Nombre_Pantalla
		  ,PP.Id_Perfil
		  ,Nombre_Perfil
		  ,pp.Id_Usuario_Crea
	      ,us.Nombre_Usuario as Creador
	      ,pp.Id_Usuario_Mod 
	      ,usm.Nombre_Usuario as Modificador
		from Perfiles_Pantallas as PP
		left join Pantallas as P on P.Id_Pantalla=PP.Id_Pantalla
		left join Perfiles as S on S.Id_Perfil=PP.Id_Perfil
		left join t_Usuarios as us on us.Id_Usuario=pp.Id_Usuario_Crea 
		left join t_Usuarios as usm on usm.Id_Usuario=pp.Id_Usuario_Mod 
END
GO
