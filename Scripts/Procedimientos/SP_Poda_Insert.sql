USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Poda_Insert')
DROP PROCEDURE SP_Poda_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Poda_Insert] 
	-- Add the parameters for the stored procedure here
	@Fecha datetime,
    @Id_bloque char(4),
    @N_arboles numeric(18,0),
    @Observaciones varchar(80),
    @Id_Usuario_Crea varchar(10),
    @F_Usuario_Crea datetime,
    @c_codigo_eps char(2)
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
		select @Existe = count(Id_Bloque) from dbo.t_Podas a where (a.Fecha=@Fecha and a.Id_bloque=@Id_bloque and a.c_codigo_eps=@c_codigo_eps)

		if @Existe>0 
		
			UPDATE dbo.t_Podas
		        SET N_arboles=@N_arboles,
				Observaciones=@Observaciones
		    WHERE
		    	Fecha=@Fecha
				and Id_bloque=@Id_bloque
				and c_codigo_eps=@c_codigo_eps
				
		else
			INSERT INTO dbo.t_Podas
	           (Fecha
	           ,Id_bloque
			   ,c_codigo_eps
			   ,N_arboles
			   ,Observaciones
			   ,Id_Usuario_Crea
	           ,F_Usuario_Crea )
	     	VALUES
	           (@Fecha
	           ,@Id_bloque
			   ,@c_codigo_eps
			   ,@N_arboles
			   ,@Observaciones
			   ,@Id_Usuario_Crea
	           ,getdate()
			   )
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
