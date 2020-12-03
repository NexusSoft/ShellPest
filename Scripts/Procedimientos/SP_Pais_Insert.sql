USE [ShellPest]
GO

/****** Object:  StoredProcedure [dbo].[SP_Pais_Insert]    Script Date: 03/12/2020 01:44:56 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Pais_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Pais char(3),
	@Nombre_Pais varchar(30),
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

		declare @maximo char(4)
		select @maximo=right(Concat('000', isnull(max(Id_Pais),0)+1),3) from dbo.t_Pais

		declare @Existe int
		select @Existe = count(Id_Pais) from dbo.t_Pais a where (a.Id_Pais=@Id_Pais)

		if @Existe>0 
		
			UPDATE dbo.t_Pais
		        SET Nombre_Pais=@Nombre_Pais,Id_Usuario_Mod=@Id_Usuario,F_Fecha_Mod=GETDATE()
		    WHERE
		    	Id_Pais=@Id_Pais
				
		else
		
			INSERT INTO dbo.t_Pais
	           (Id_Pais
	           ,Nombre_Pais,Id_Usuario_Crea,F_Fecha_Crea)
	     	VALUES
	           (@maximo
	           ,@Nombre_Pais,@Id_Usuario,GETDATE())
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END



GO

