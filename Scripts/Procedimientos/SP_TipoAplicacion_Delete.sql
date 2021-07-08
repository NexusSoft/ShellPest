USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteInsert]    Script Date: 25/08/2018 12:39:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_TipoAplicacion_Delete')
DROP PROCEDURE SP_TipoAplicacion_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_TipoAplicacion_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_TipoAplicacion char(3),
	@Usuario varchar(10),
	@Activo char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		update dbo.t_TipoAplicacion set Activo=@Activo, Id_Usuario_Mod=@Usuario, F_Usuario_Mod=getdate() where Id_TipoAplicacion=@Id_TipoAplicacion

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END
