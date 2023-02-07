USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Control_Podas_Insert')
DROP PROCEDURE SP_WS_Control_Podas_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_WS_Control_Podas_Insert] 
	-- Add the parameters for the stored procedure here
	@Fecha date,
	@Id_Bloque char(4),
	@N_arboles numeric(18,0),
	@Observaciones varchar(80),
	@Id_Usuario_Crea varchar(10),
	@c_codigo_eps char(2),
	@actividad char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto char(10)

	begin transaction T1;
	begin try


					   
			declare @ExistePoda int
			select @ExistePoda = count(Id_Bloque) from dbo.t_Podas a where (a.Fecha=@Fecha and a.Id_Bloque=@Id_Bloque)

			if @ExistePoda>0 
				UPDATE dbo.t_Podas set  
					N_arboles=@N_arboles,
					Observaciones=@Observaciones
				where Fecha=@Fecha and Id_Bloque=@Id_Bloque
			else
				INSERT INTO dbo.t_Podas
		           (Fecha
		           ,Id_Bloque
				   ,N_arboles
				   ,Observaciones
	           	   ,Id_Usuario_Crea
				   ,F_Usuario_Crea
				   ,c_codigo_eps)
		     	VALUES
		           (@Fecha
		           ,@Id_Bloque
				   ,@N_arboles
				   ,@Observaciones
	           	   ,@Id_Usuario_Crea
				   ,getdate()
				   ,@c_codigo_eps)
			
			declare @ExisteDet int
			select @ExisteDet = count(Id_Bloque) from dbo.t_PodasDet a where (a.Fecha=@Fecha and a.Id_Bloque=@Id_Bloque and a.actividad=@actividad)

			if @ExisteDet=0 
				INSERT INTO dbo.t_PodasDet
		           (Fecha
		           ,Id_Bloque
				   ,actividad
				   ,c_codigo_eps)
		     	VALUES
		           (@Fecha
		           ,@Id_Bloque
				   ,@actividad
				   ,@c_codigo_eps)
			
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
