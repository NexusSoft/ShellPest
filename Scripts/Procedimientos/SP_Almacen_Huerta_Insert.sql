USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Almacen_Huerta_Insert')
DROP PROCEDURE SP_Almacen_Huerta_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Almacen_Huerta_Insert] 
	-- Add the parameters for the stored procedure here
	@c_codigo_alm char(2),
	@c_codigo_hue char(4)
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
			select @Existe = count(c_codigo_alm) from dbo.t_Almacen_Huerto a where (a.c_codigo_alm=@c_codigo_alm and a.c_codigo_hue=@c_codigo_hue)

			if @Existe>0 
				set @correcto=0
					
			else
			
				INSERT INTO dbo.t_Almacen_Huerto
		           (c_codigo_alm,
				   c_codigo_hue)
		     	VALUES
		           (@c_codigo_alm
		           ,@c_codigo_hue)
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
