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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_RiegoV2_Select')
DROP PROCEDURE SP_RiegoV2_Select
GO
	
CREATE PROCEDURE SP_RiegoV2_Select	
	@Fecha datetime,
	@Id_Bloque char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select r.Id_Bloque,
			b.Nombre_Bloque,
			r.Fecha,
			r.Hora,
			r.c_codigo_eps,
			r.Caudal_Inicio,
			r.Caudal_Fin,
			r.ET,
			r.Hora_Fin,
			r.Precipitacion_Sistema,
			r.Temperatura,
			r.Horas_Riego 
		from t_Riego as r 
		inner join t_Bloque as b on b.Id_Bloque=r.Id_Bloque
		where r.Fecha=@Fecha and r.Id_Bloque=@Id_Bloque

END


GO