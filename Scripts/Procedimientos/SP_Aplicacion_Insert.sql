USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Aplicacion_Insert')
DROP PROCEDURE SP_Aplicacion_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Aplicacion_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Aplicacion char(10),
	@Id_Huerta char(4),
	@Observaciones varchar(100),
	@Id_TipoAplicacion char(3),
	@Id_Presentacion char(4),
	@Id_Usuario varchar(10),
	@Anio char(2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto char(10)

	begin transaction T1;
	begin try


			declare @maximo char(10)
			select @maximo=count(A.Id_Aplicacion)+@Anio+@Id_Huerta from t_Aplicacion as A
            left join (select datepart(year,min(ADT.Fecha)) as Fecha,
                        ADT.Id_Aplicacion 
                       from t_Aplicacion_Det as ADT 
                       group by ADT.Id_Aplicacion ) as AD on A.Id_Aplicacion=AD.Id_Aplicacion
                       where rtrim(ltrim(A.Id_Huerta))=@Id_Huerta
					   and AD.Fecha =@Anio

			
				INSERT INTO dbo.t_Aplicacion
		           (Id_Aplicacion
		           ,Id_Huerta
		           ,Observaciones
				   ,Id_TipoAplicacion
				   ,Id_Presentacion
				   ,Id_Usuario_Crea
	           	   ,F_Usuario_Crea)
		     	VALUES
		           (@maximo
		           ,@Id_Huerta
				   ,@Observaciones
				   ,@Id_TipoAplicacion
				   ,@Id_Presentacion
		           ,@Id_Usuario
	           		,getdate())
			
			commit transaction T1;
			set @correcto=@maximo
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
