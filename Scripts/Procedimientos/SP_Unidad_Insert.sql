USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Unidad_Insert')
DROP PROCEDURE SP_Unidad_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Unidad_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Unidad char(2),
	@Nombre_Unidad varchar(30),
	@Abreviatura varchar(10),
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


			declare @maximo char(2)
			select @maximo=right(Concat('00', isnull(max(Id_Unidad),0)+1),2) from dbo.t_Unidad

			declare @Existe int
			select @Existe = count(Id_Unidad) from dbo.t_Unidad a where (a.Id_Unidad=@Id_Unidad)

			if @Existe>0 
			
				UPDATE dbo.t_Unidad
			        SET Nombre_Unidad=@Nombre_Unidad,
					Abreviatura=@Abreviatura,
			        Id_Usuario_Mod=@Id_Usuario,
		       		F_Usuario_Mod=getdate()
			    WHERE
			    	Id_Unidad=@Id_Unidad
					
			else
			
				INSERT INTO dbo.t_Unidad
		           (Id_Unidad
		           ,Nombre_Unidad
				   ,Abreviatura
		           ,Id_Usuario_Crea
	           		,F_Usuario_Crea
					,Activo)
		     	VALUES
		           (@maximo
		           ,@Nombre_Unidad
				   ,@Abreviatura
		           ,@Id_Usuario
	           		,getdate()
					,'1')
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
