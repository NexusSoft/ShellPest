USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Presentacion_Insert')
DROP PROCEDURE SP_Presentacion_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Presentacion_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Presentacion char(4),
	@Nombre_Presentacion varchar(100),
	@Id_Unidad char(2),
	@Id_TipoAplicacion char(3),
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
			select @maximo=right(Concat('0000', isnull(max(Id_Presentacion),0)+1),4) from dbo.t_Presentacion

			declare @Existe int
			select @Existe = count(Id_Presentacion) from dbo.t_Presentacion a where (a.Id_Presentacion=@Id_Presentacion)

			if @Existe>0 
			
				UPDATE dbo.t_Presentacion
			        SET Nombre_Presentacion=@Nombre_Presentacion,
					Id_TipoAplicacion=@Id_TipoAplicacion,
					Id_Unidad=@Id_Unidad,
			        Id_Usuario_Mod=@Id_Usuario,
		       		F_Usuario_Mod=getdate()
			    WHERE
			    	Id_Presentacion=@Id_Presentacion
					
			else
			
				INSERT INTO dbo.t_Presentacion
		           (Id_Presentacion
		           ,Nombre_Presentacion
				   ,Id_TipoAplicacion
				   ,Id_Unidad
		           ,Id_Usuario_Crea
	           		,F_Usuario_Crea
					,Activo)
		     	VALUES
		           (@maximo
		           ,@Nombre_Presentacion
				   ,@Id_TipoAplicacion
				   ,@Id_Unidad
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
