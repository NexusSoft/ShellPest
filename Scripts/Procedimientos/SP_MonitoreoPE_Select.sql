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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_MonitoreoPE_Select')
DROP PROCEDURE SP_MonitoreoPE_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_MonitoreoPE_Select
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select PE.Id_PuntoControl,
            	Fecha,
            	hue.Nombre_Huerta ,
            	blq.Nombre_Bloque ,
            	pto.Nombre_PuntoControl
        from t_Monitoreo_PE_Encabezado as PE 
        left join t_Puntocontrol as pto on pto.Id_PuntoControl =PE.Id_PuntoControl 
        left join t_Bloque as blq on blq.Id_Bloque =pto.Id_Bloque
        left join t_Huerta as hue on hue.Id_Huerta =blq.Id_Huerta 

END
GO
