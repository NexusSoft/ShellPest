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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Podas_Select')
DROP PROCEDURE SP_Podas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Podas_Select
	-- Add the parameters for the stored procedure here
	@Fecha datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Fecha, P.Id_bloque, N_arboles, Observaciones, P.Id_Usuario_Crea, P.F_Usuario_Crea, P.c_codigo_eps,B.Nombre_Bloque,B.Id_Huerta
		from t_Podas as P
		left join t_Bloque as B on B.Id_Bloque=P.Id_bloque and B.TipoBloque='B'
		where Fecha=@Fecha

END
GO
