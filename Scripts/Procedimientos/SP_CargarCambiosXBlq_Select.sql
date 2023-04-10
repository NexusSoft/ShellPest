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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_CargarCambiosXBlq_Select')
DROP PROCEDURE SP_CargarCambiosXBlq_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_CargarCambiosXBlq_Select
	-- Add the parameters for the stored procedure here
	@Id_Bloque char(4)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	select distinct CR.Id_Cambio,
		CR.N_Cambio	
	from t_Cambios_Riego as CR
	left join t_Cambio_Riego_Det as CRD on CRD.Id_Cambio=CR.Id_Cambio
	where CRD.Id_Bloque=@Id_Bloque
				
END
GO
