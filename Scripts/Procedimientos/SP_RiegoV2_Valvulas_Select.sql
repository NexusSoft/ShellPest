USE [ShellPest]
GO

/****** Object:  StoredProcedure [dbo].[SP_Pais_Select]    Script Date: 03/12/2020 01:45:14 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_RiegoV2_Valvulas_Select')
DROP PROCEDURE SP_RiegoV2_Valvulas_Select
GO
	
CREATE PROCEDURE SP_RiegoV2_Valvulas_Select	
	@Id_Cambio int,
	@Id_Bloque char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select V.Id_Valvula,
				V.N_Valvula
			from t_Valvulas as V 
			inner join t_Cambio_Riego_Det as CRD on CRD.Id_Bloque=V.Id_Bloque and CRD.Id_Valvula=V.Id_Valvula  where CRD.Id_Bloque=@Id_Bloque and Id_Cambio=@Id_Cambio

END


GO