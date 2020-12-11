USE [ShellPest]
GO

/****** Object:  StoredProcedure [dbo].[SP_Productor_Select]    Script Date: 03/12/2020 01:45:14 p. m. ******/
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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Productor_Select')
DROP PROCEDURE SP_Productor_Select
GO
	
CREATE PROCEDURE SP_Productor_Select	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select dt.Id_Productor
	      ,dt.Nombre_Productor
	      ,dt.Id_Usuario_Crea
	      ,us.Nombre_Usuario as Creador
	      ,dt.Id_Usuario_Mod 
	      ,usm.Nombre_Usuario as Modificador
		from t_Productor as dt
		inner join t_Usuarios as us on us.Id_Usuario=dt.Id_Usuario_Crea 
		left join t_Usuarios as usm on usm.Id_Usuario=dt.Id_Usuario_Mod 

END


GO

