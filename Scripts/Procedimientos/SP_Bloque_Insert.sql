USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Bloque_Insert')
DROP PROCEDURE SP_Bloque_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Bloque_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Bloque char(4),
	@Id_Huerta char(4),
	@Nombre_Bloque varchar(70),
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
		select @maximo= right(Concat('0000',isnull(max(Id_Bloque),0)+1),4) from dbo.t_Bloque

		declare @Existe int
		select @Existe = count(Id_Bloque) from dbo.t_Bloque a where (a.Id_Bloque=@Id_Bloque)

		if @Existe>0 
		
			UPDATE dbo.t_Bloque
		        SET Nombre_Bloque=@Nombre_Bloque,
		        Id_Huerta=@Id_Huerta,
		        Id_Usuario_Mod=@Id_Usuario,
		        F_Usuario_Mod=getdate()
		    WHERE
		    	Id_Bloque=@Id_Bloque
				
		else
		
			INSERT INTO dbo.t_Bloque
	           (Id_Bloque
	           ,Nombre_Bloque
	           ,Id_Huerta
	           ,Id_Usuario_Crea
	           ,F_Usuario_Crea)
	     	VALUES
	           (@maximo
	           ,@Nombre_Bloque
	           ,@Id_Huerta
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
