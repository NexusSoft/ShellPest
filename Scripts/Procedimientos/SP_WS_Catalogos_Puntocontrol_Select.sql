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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Catalogos_Puntocontrol_Select')
DROP PROCEDURE SP_WS_Catalogos_Puntocontrol_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_WS_Catalogos_Puntocontrol_Select
	-- Add the parameters for the stored procedure here
	@Fecha varchar(8),
	@Id_Usuario varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select dt.Id_PuntoControl,dt.Id_Bloque,dt.Nombre_PuntoControl,dt.n_coordenadaX,dt.n_coordenadaY,dt.Id_Usuario_Crea,dt.F_Usuario_Crea,dt.Id_Usuario_Mod,dt.F_Usuario_Mod,dt.c_codigo_eps
		from t_Puntocontrol as dt
		inner join t_Usuario_Empresa as UE on UE.c_codigo_eps=dt.c_codigo_eps
		where (dt.F_Usuario_Crea>=@Fecha or dt.F_Usuario_Mod>=@Fecha) and UE.Id_Usuario=@Id_Usuario
		 and Activo=1		
END
GO