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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Catalogos_Presentaciones_Select')
DROP PROCEDURE SP_WS_Catalogos_Presentaciones_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_WS_Catalogos_Presentaciones_Select
	-- Add the parameters for the stored procedure here
	@Fecha varchar(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Presentacion,
			Nombre_Presentacion ,
			Id_TipoAplicacion ,
			Id_Unidad 
		from t_Presentacion 
		where Activo ='1' and ((F_Usuario_Crea >= @Fecha) OR (F_Usuario_Mod >= @Fecha))
		
END
GO
