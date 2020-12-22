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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Riego_Select')
DROP PROCEDURE SP_Riego_Select
GO
	
CREATE PROCEDURE SP_Riego_Select	
	@Fecha_Riego datetime	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select r.Id_Bloque,
			b.Nombre_Bloque,
			r.Fecha_Riego,
			r.Horas_Riego 
		from t_Riego as r 
		inner join t_Bloque as b on b.Id_Bloque=r.Id_Bloque
		inner join t_Usuarios as us on us.Id_Usuario=r.Id_Usuario_Crea 
		left join t_Usuarios as usm on usm.Id_Usuario=r.Id_Usuario_Mod 
		where r.Fecha_Riego=@Fecha_Riego

END


GO

