USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Receta_Insert')
DROP PROCEDURE SP_Receta_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Receta_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Receta char(7),
	@Fecha_Receta datetime,
	@Id_AsesorTecnico char(3),
	@Id_MonitoreoPE char(10),
	@Id_Cultivo char(2),
	@Id_TipoAplicacion char(3),
	@Id_Presentacion char(4),
	@Observaciones varchar(150),
	@Intervalo_Seguridad numeric(15,1),
	@Intervalo_Reingreso numeric(15,1),
	@Id_Usuario varchar(10),
	@Para char(1)
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
			select @maximo=right(Concat('0000', isnull(max(Id_Receta),0)+1),4) from dbo.t_Receta where Id_AsesorTecnico=@Id_AsesorTecnico

			declare @Existe int
			select @Existe = count(Id_Receta) from dbo.t_Receta a where (a.Id_Receta=@Id_Receta)

			if @Existe>0 
			
				UPDATE dbo.t_Receta
			        SET Fecha_Receta=@Fecha_Receta,
					Id_AsesorTecnico=@Id_AsesorTecnico,
					Id_MonitoreoPE=@Id_MonitoreoPE,
					Id_Cultivo=@Id_Cultivo,
					Id_TipoAplicacion=@Id_TipoAplicacion,
					Id_Presentacion=@Id_Presentacion,
					Observaciones=@Observaciones,
					Intervalo_Seguridad=@Intervalo_Seguridad,
					Intervalo_Reingreso=@Intervalo_Reingreso,
					Id_Huerta=@Id_Huerta,
			        Id_Usuario_Mod=@Id_Usuario,
		       		F_Usuario_Mod=getdate(),
					Para=@Para
			    WHERE
			    	Id_Receta=@Id_Receta
					
			else
			
				INSERT INTO dbo.t_Receta
		           (Id_Receta
		           ,Fecha_Receta
				   ,Id_AsesorTecnico
				   ,Id_MonitoreoPE
				   ,Id_Cultivo
				   ,Id_TipoAplicacion
				   ,Id_Presentacion
				   ,Observaciones
				   ,Intervalo_Seguridad
				   ,Intervalo_Reingreso
		           ,Id_Usuario_Crea
	           		,F_Usuario_Crea
					,Activo
					,c_codigo_eps
					,Id_Huerta
					,Para)
		     	VALUES
		           (@Id_AsesorTecnico+@maximo
		           ,@Fecha_Receta
				   ,@Id_AsesorTecnico
				   ,@Id_MonitoreoPE
				   ,@Id_Cultivo
				   ,@Id_TipoAplicacion
				   ,@Id_Presentacion
				   ,@Observaciones
				   ,@Intervalo_Seguridad
				   ,@Intervalo_Reingreso
		           ,@Id_Usuario
	           		,getdate()
					,'1'
					,@c_codigo_eps
					,@Id_Huerta
					,@Para)
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
