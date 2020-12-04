USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Enfermedad_Insert')
DROP PROCEDURE SP_Enfermedad_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Enfermedad_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Enfermedad char(4),
	@Nombre_Enfermedad varchar(70),
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
		select @maximo= right(Concat('0000',isnull(max(Id_Enfermedad),0)+1),4) from dbo.t_Enfermedad

		declare @Existe int
		select @Existe = count(Id_Enfermedad) from dbo.t_Enfermedad a where (a.Id_Enfermedad=@Id_Enfermedad)

		if @Existe>0 
		
			UPDATE dbo.t_Enfermedad
		        SET Nombre_Enfermedad=@Nombre_Enfermedad,
		        Id_Usuario_Mod=@Id_Usuario,
		        F_Usuario_Mod=getdate()
		    WHERE
		    	Id_Enfermedad=@Id_Enfermedad
				
		else
		
			INSERT INTO dbo.t_Enfermedad
	           (Id_Enfermedad
	           ,Nombre_Enfermedad
	           ,Id_Usuario_Crea
	           ,F_Usuario_Crea)
	     	VALUES
	           (@maximo
	           ,@Nombre_Enfermedad
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
