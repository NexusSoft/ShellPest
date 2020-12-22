USE [ShellPest]
GO

/****** Object:  StoredProcedure [dbo].[SP_Riego_Insert]    Script Date: 03/12/2020 01:44:56 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Riego_Insert')
DROP PROCEDURE SP_Riego_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Riego_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Bloque char(4),
	@Fecha_Riego datetime,
	@Horas_Riego numeric(7,2),
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


		declare @Existe int
		select @Existe = count(Id_Bloque) from dbo.t_Riego a where (a.Id_Bloque=@Id_Bloque and a.Fecha_Riego=@Fecha_Riego)

		if @Existe>0 
		
			UPDATE dbo.t_Riego
		        SET Horas_Riego=@Horas_Riego,Id_Usuario_Mod=@Id_Usuario,F_Usuario_Mod=GETDATE()
		    WHERE
		    	Id_Bloque=@Id_Bloque and Fecha_Riego=@Fecha_Riego
				
		else
		
			INSERT INTO dbo.t_Riego
	           (Id_Bloque
	           ,Fecha_Riego,Horas_Riego,Id_Usuario_Crea,F_Usuario_Crea)
	     	VALUES
	           (@Id_Bloque
	           ,@Fecha_Riego,@Horas_Riego,@Id_Usuario,GETDATE())
		
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

