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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Catalogos_CambiosRiegoDet_Select')
DROP PROCEDURE SP_WS_Catalogos_CambiosRiegoDet_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_WS_Catalogos_CambiosRiegoDet_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		SELECT  CRD.Id_Bloque as Id_BloqueCD
	      ,CRD.Id_Cambio
	      ,CRD.Id_Valvula
		  ,C.N_Cambio
  		FROM t_Cambio_Riego_Det as CRD
		inner join t_Cambios_Riego as C on C.Id_Cambio=CRD.Id_Cambio
END
GO
