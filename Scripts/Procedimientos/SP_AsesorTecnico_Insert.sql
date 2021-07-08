USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_AsesorTecnico_Insert')
DROP PROCEDURE SP_AsesorTecnico_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_AsesorTecnico_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_AsesorTecnico char(3),
	@Nombre_AsesorTecnico varchar(50),
	@Usuario varchar(10)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		declare @maximo char(3)
		select @maximo=right(Concat('000', isnull(max(Id_AsesorTecnico),0)+1),3) from dbo.t_AsesorTecnico

		declare @Existe int
		select @Existe = count(Id_AsesorTecnico) from dbo.t_AsesorTecnico a where (a.Id_AsesorTecnico=@Id_AsesorTecnico)

		if @Existe>0 
		
			UPDATE dbo.t_AsesorTecnico
		        SET Nombre_AsesorTecnico=@Nombre_AsesorTecnico,
				Id_Usuario_Mod=@Usuario,
				F_Usuario_Mod=GETDATE()
		    WHERE
		    	Id_AsesorTecnico=@Id_AsesorTecnico
				
		else
		
			INSERT INTO dbo.t_AsesorTecnico
	           (Id_AsesorTecnico
	           ,Nombre_AsesorTecnico
			   ,Id_Usuario_Crea
			   ,F_Usuario_Crea
			   ,Activo)
	     	VALUES
	           (@maximo
	           ,@Nombre_AsesorTecnico
			   ,@Usuario
			   ,GETDATE()
			   ,'1')
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END