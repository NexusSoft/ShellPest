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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Catalogos_ValvulasDet_Select')
DROP PROCEDURE SP_WS_Catalogos_ValvulasDet_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_WS_Catalogos_ValvulasDet_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		SELECT  VD.Id_Bloque as Id_BloqueVD
	      ,VD.Id_Valvula
	      ,VD.N_Micros
		  ,VD.N_Caudales
		  ,VD.M3
  		FROM t_ValvulasDet as VD  inner join t_Valvulas as V on V.Id_Valvula=VD.Id_Valvula and V.Id_Bloque=VD.Id_Bloque  where V.Activo=1
END
GO
