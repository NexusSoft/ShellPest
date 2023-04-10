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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_RiegoValvulas_Select')
DROP PROCEDURE SP_RiegoValvulas_Select
GO
	
CREATE PROCEDURE SP_RiegoValvulas_Select	
	@Fecha datetime,
	@Id_Bloque char(4),
	@Hora time
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select V.Id_Valvula ,
			V.N_Valvula ,
			V.N_Arboles ,
			V.N_Replantes ,
			V.N_Morras  ,
			V.Id_Bloque ,
			VD.N_Micros ,
			VD.N_Caudales ,
			VD.M3 
		from ShellPest.dbo.t_Valvulas as V 
		inner join ShellPest.dbo.t_ValvulasDet as VD on VD.Id_Bloque =V.Id_Bloque and VD.Id_Valvula =V.Id_Valvula 
		where V.Id_Valvula in (select Id_Valvula 
				from ShellPest.dbo.t_Riego_Valvulas 
				where Id_Bloque=@Id_Bloque and Fecha=@Fecha and Hora=@Hora)
			and V.Id_Bloque =@Id_Bloque

END


GO