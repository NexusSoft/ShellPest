USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Receta_Huerta_Delete')
DROP PROCEDURE SP_Receta_Huerta_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Receta_Huerta_Delete] 
	-- Add the parameters for the stored procedure here
	@c_codigo_eps char(2),
	@Id_Huerta char(5),
	@Id_Receta char(7)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try


			delete from dbo.t_Receta_Huerta where c_codigo_eps =@c_codigo_eps and Id_Huerta=@Id_Huerta and Id_Receta=@Id_Receta
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
