USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Deteccion_Insert')
DROP PROCEDURE SP_Deteccion_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Deteccion_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Deteccion int,
	@Nombre_Deteccion varchar(10),
	@Id_Usuario varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo int
		select @maximo= isnull(max(Id_Deteccion),0)+1 from dbo.t_Deteccion

		declare @Existe int
		select @Existe = count(Id_Deteccion) from dbo.t_Deteccion a where (a.Id_Deteccion=@Id_Deteccion)

		if @Existe>0 
		
			UPDATE dbo.t_Deteccion
		        SET Nombre_Deteccion=@Nombre_Deteccion,
		        Id_Usuario_Mod=@Id_Usuario,
		        F_Usuario_Mod=getdate()
		    WHERE
		    	Id_Deteccion=@Id_Deteccion
				
		else
		
			INSERT INTO dbo.t_Deteccion
	           (Id_Deteccion
	           ,Nombre_Deteccion
	           ,Id_Usuario_Crea
	           ,F_Usuario_Crea)
	     	VALUES
	           (@maximo
	           ,@Nombre_Deteccion
	           ,@Id_Usuario
	           ,getdate())
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
