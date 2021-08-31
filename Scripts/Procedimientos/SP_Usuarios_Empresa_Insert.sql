USE [Transportes]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Usuarios_Empresa_Insert')
DROP PROCEDURE SP_Usuarios_Empresa_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Usuarios_Empresa_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Usuario2 varchar(10),
	@c_codigo_eps char(2),
	@Id_Usuario varchar(10)
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
		select @Existe = count(Id_Usuario2) from dbo.t_Usuario_Empresa a where (a.Id_Usuario=@Id_Usuario2 and a.c_codigo_eps=@c_codigo_eps)

		if @Existe>0 
		
			select 0
				
		else
		
			INSERT INTO dbo.t_Usuario_Empresa
	           (Id_Usuario
	           ,c_codigo_eps
	           ,Id_Usuario_Crea
	           ,F_Usuario_Crea)
	     	VALUES
	           (@Id_Usuario2
	           ,@c_codigo_eps
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
