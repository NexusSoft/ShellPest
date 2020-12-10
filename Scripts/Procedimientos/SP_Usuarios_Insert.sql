USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Usuarios_Insert')
DROP PROCEDURE SP_Usuarios_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Usuarios_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Usuario varchar(10),
	@Nombre_Usuario varchar(50),
	@Contrasena varchar(20),
	@Id_Perfil char(3),
	@Id_Usuario_Crea varchar(10)
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
		select @Existe = count(Id_Usuario) from dbo.t_Usuarios a where (a.Id_Usuario=@Id_Usuario)

		if @Existe>0 
		
			UPDATE dbo.t_Usuarios
		        SET Nombre_Usuario=@Nombre_Usuario,
				Contrasena=@Contrasena,
				Id_Perfil=@Id_Perfil,
				Id_Usuario_Mod=@Id_Usuario_Crea,
		        F_Usuario_Mod=getdate()
		    WHERE
		    	Id_Usuario=@Id_Usuario
				
		else
			INSERT INTO dbo.t_Usuarios
	           (Id_Usuario
	           ,Nombre_Usuario
			   ,Contrasena
			   ,Id_Perfil
			   ,Id_Usuario_Crea
	           ,F_Usuario_Crea
			   ,Activo)
	     	VALUES
	           (@Id_Usuario
	           ,@Nombre_Usuario
			   ,@Contrasena
			   ,@Id_Perfil
			   ,@Id_Usuario_Crea
	           ,getdate()
			   ,1)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
