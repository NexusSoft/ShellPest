USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_PodaDet_Insert')
DROP PROCEDURE SP_PodaDet_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_PodaDet_Insert] 
	-- Add the parameters for the stored procedure here
	@Fecha datetime,
    @Id_bloque char(4),
    @Actividad char(4),
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
		select @Existe = count(Id_Bloque) from dbo.t_PodasDet a where (a.Fecha=@Fecha and a.Id_bloque=@Id_bloque and a.c_codigo_eps=@c_codigo_eps and a.Actividad=@Actividad)

		if @Existe=0 
		
			INSERT INTO dbo.t_PodasDet
	           (Fecha
	           ,Id_bloque
			   ,c_codigo_eps
			   ,Actividad )
	     	VALUES
	           (@Fecha
	           ,@Id_bloque
			   ,@c_codigo_eps
			   ,@Actividad
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
