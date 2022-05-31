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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Perfil_Pantallas_Disponibles_Select')
DROP PROCEDURE SP_Perfil_Pantallas_Disponibles_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Perfil_Pantallas_Disponibles_Select
	-- Add the parameters for the stored procedure here
	@Id_Perfil char(3)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select PaP.Id_Pantalla,PaP.Nombre_Pantalla from t_pantallas as PaP where PaP.Id_Pantalla not in (
			select PP.Id_Pantalla
			from t_perfiles_pantallas as PP
			inner join t_pantallas as P on P.Id_Pantalla=PP.Id_Pantalla
			inner join t_perfiles as S on S.Id_Perfil=PP.Id_Perfil
			where S.Id_Perfil =@Id_Perfil
		)
		 

END
GO
