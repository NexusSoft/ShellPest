USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Aplicacion_Det_Insert')
DROP PROCEDURE SP_Aplicacion_Det_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Aplicacion_Det_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Aplicacion char(10),
	@Fecha char(8),
	@c_codigo_pro varchar(15),
	@Dosis numeric(18,2),
	@Unidades_aplicadas numeric(18, 2),
	@Id_Usuario varchar(10),
	@Anio char(2)
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
			select @Existe = count(Id_Aplicacion) from dbo.t_Aplicacion_Det a where (a.Id_Aplicacion=@Id_Aplicacion and a.c_codigo_pro=@c_codigo_pro)

			if @Existe>0 
				insert into t_Aplicacion_Det (Id_Aplicacion
		           ,Fecha
		           ,c_codigo_pro
				   ,Dosis
				   ,Unidades_aplicadas
				   ,Id_Usuario_Crea
	           	   ,F_Usuario_Crea)
				  (select Id_Aplicacion
		           ,Fecha
		           ,c_codigo_pro
				   ,Dosis
				   ,Unidades_aplicadas
				   ,Id_Usuario_Crea
	           	   ,F_Usuario_Crea from t_Aplicacion_Det where Id_Aplicacion='-0')
			else
				INSERT INTO dbo.t_Aplicacion_Det
		           (Id_Aplicacion
		           ,Fecha
		           ,c_codigo_pro
				   ,Dosis
				   ,Unidades_aplicadas
				   ,Id_Usuario_Crea
	           	   ,F_Usuario_Crea)
		     	VALUES
		           (@Id_Aplicacion
		           ,@Fecha
				   ,@c_codigo_pro
				   ,@Dosis
				   ,@Unidades_aplicadas
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
