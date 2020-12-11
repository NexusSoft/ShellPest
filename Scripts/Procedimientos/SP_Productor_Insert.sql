USE [ShellPest]
GO

/****** Object:  StoredProcedure [dbo].[SP_Productor_Insert]    Script Date: 03/12/2020 01:44:56 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Productor_Insert')
DROP PROCEDURE SP_Productor_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Productor_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Productor int,
	@Nombre_Productor varchar(70),
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
		select @maximo= isnull(max(Id_Productor),0)+1 from dbo.t_Productor

		declare @Existe int
		select @Existe = count(Id_Productor) from dbo.t_Productor a where (a.Id_Productor=@Id_Productor)

		if @Existe>0 
		
			UPDATE dbo.t_Productor
		        SET Nombre_Productor=@Nombre_Productor,Id_Usuario_Mod=@Id_Usuario,F_Usuario_Mod=GETDATE()
		    WHERE
		    	Id_Productor=@Id_Productor
				
		else
		
			INSERT INTO dbo.t_Productor
	           (Id_Productor
	           ,Nombre_Productor,Id_Usuario_Crea,F_Usuario_Crea)
	     	VALUES
	           (@maximo
	           ,@Nombre_Productor,@Id_Usuario,GETDATE())
		
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

