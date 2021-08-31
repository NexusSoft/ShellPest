USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Catalogos_UsuarioEmpresa_Select')
DROP PROCEDURE SP_WS_Catalogos_UsuarioEmpresa_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_WS_Catalogos_UsuarioEmpresa_Select] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto char(10)

	begin transaction T1;
	begin try

			select Id_Usuario as Usu_Emp,
				c_codigo_eps
			from t_Usuario_Empresa 
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
