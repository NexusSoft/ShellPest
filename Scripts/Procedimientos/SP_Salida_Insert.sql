USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salida_Insert')
DROP PROCEDURE SP_Salida_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salida_Insert] 
	-- Add the parameters for the stored procedure here
	@c_codigo_sal char(10),
	@c_codigo_ent char(10),
	@c_codigo_tmv char(2),
	@c_codigo_tra char(10),
	@d_documento_sal datetime,
	@c_codigo_alm char(2),
	@c_codigo_eps char(2),
	@Id_Responsable varchar(10),
	@Id_Aplicacion char(10),
	@Id_Usuario varchar(10),
	@F_Creacion char(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto char(10)

	begin transaction T1;
	begin try


					   
			declare @Existe int
			select @Existe = count(c_codigo_sal) from dbo.t_Salidas a where (a.c_codigo_sal=@c_codigo_sal)

			if @Existe>0 
				UPDATE dbo.t_Salidas set c_codigo_eps=@c_codigo_eps, 
					Id_Responsable=@Id_Responsable, 
					Id_Aplicacion=@Id_Aplicacion,
					Id_Usuario_Mod=@Id_Usuario,
					F_Usuario_Mod=@F_Creacion
				where c_codigo_sal=@c_codigo_sal
			else
				INSERT INTO dbo.t_Salidas
		           (c_codigo_sal
		           ,c_codigo_ent
		           ,c_codigo_tmv
				   ,c_codigo_tra
				   ,d_documento_sal
				   ,c_codigo_alm
	           	   ,c_codigo_eps
				   ,Id_Usuario_Crea
				   ,F_Usuario_Crea)
		     	VALUES
		           (@c_codigo_sal
		           ,@c_codigo_ent
				   ,@c_codigo_tmv
				   ,@c_codigo_tra
				   ,@d_documento_sal
				   ,@c_codigo_alm
				   ,@c_codigo_eps
		           ,@Id_Usuario
	           		,@F_Creacion)
			
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
