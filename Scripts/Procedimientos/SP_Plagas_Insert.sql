USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Plagas_Insert')
DROP PROCEDURE SP_Plagas_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Plagas_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Plagas char(4),
	@Nombre_Plagas varchar(70),
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
		select @maximo= right(Concat('0000',isnull(max(Id_Plagas),0)+1),4) from dbo.t_Plagas

		declare @Existe int
		select @Existe = count(Id_Plagas) from dbo.t_Plagas a where (a.Id_Plagas=@Id_Plagas)

		if @Existe>0 
		
			UPDATE dbo.t_Plagas
		        SET Nombre_Plagas=@Nombre_Plagas,
		        Id_Usuario_Mod=@Id_Usuario,
		        F_Usuario_Mod=getdate()
		    WHERE
		    	Id_Plagas=@Id_Plagas
				
		else
		
			INSERT INTO dbo.t_Plagas
	           (Id_Plagas
	           ,Nombre_Plagas
	           ,Id_Usuario_Crea
	           ,F_Usuario_Crea)
	     	VALUES
	           (@maximo
	           ,@Nombre_Plagas
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
