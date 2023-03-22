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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_ValvulasDet_Select')
DROP PROCEDURE SP_ValvulasDet_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_ValvulasDet_Select
	-- Add the parameters for the stored procedure here
	@Id_Bloque char(4),
	@N_Valvula char(3)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	select VD.Id_Bloque,
		B.Nombre_Bloque,
		VD.Id_Valvula,
		VD.N_Micros,
		VD.N_Caudales,
		VD.M3 
	from ShellPest.dbo.t_ValvulasDet as VD
	inner join t_Valvulas as V on V.Id_Bloque=VD.Id_Bloque and V.Id_Valvula=VD.Id_Valvula
	left join ShellPest.dbo.t_Bloque as B on B.Id_Bloque=VD.Id_Bloque
	where VD.Id_Bloque=@Id_Bloque and V.N_Valvula=@N_Valvula and V.Activo=1
				
END
GO
