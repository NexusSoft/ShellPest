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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_EmpresasXUsuario_Select')
DROP PROCEDURE SP_EmpresasXUsuario_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_EmpresasXUsuario_Select
	-- Add the parameters for the stored procedure here
	@Id_Usuario varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select E.c_codigo_eps,
			E.v_nombre_eps,
			E.v_basedatos_coi
		from t_Usuario_Empresa as UE
		inner join vistas.dbo.conempresa as E on E.c_codigo_eps=UE.c_codigo_eps
		where UE.Id_Usuario=@Id_Usuario and E.c_activo_eps='1'

END
GO
