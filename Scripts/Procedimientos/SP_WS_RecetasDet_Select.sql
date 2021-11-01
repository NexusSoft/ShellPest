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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_RecetasDet_Select')
DROP PROCEDURE SP_WS_RecetasDet_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_WS_RecetasDet_Select
	-- Add the parameters for the stored procedure here
	@Id_Usuario varchar(10)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select Id_Receta ,
			Secuencia ,
			c_codigo_pro ,
			v_nombre_pro,
			c_codigo_cac ,
			v_nombre_cac ,
			c_codigo_uni ,
			Dosis ,
			Cantidad_Unitaria ,
			Descripcion ,
			RD.c_codigo_eps 
		from ShellPest.dbo.t_RecetaDet as RD
		inner join ShellPest.dbo.t_Usuario_Empresa as UE on UE.c_codigo_eps = RD.c_codigo_eps 
		where UE.Id_Usuario =@Id_Usuario and RD.Id_Receta in (select Id_Receta from ShellPest.dbo.t_Receta where Activo=1)
		
END
GO
