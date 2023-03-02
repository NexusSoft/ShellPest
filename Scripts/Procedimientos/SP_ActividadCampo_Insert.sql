USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_ActividadCampo_Insert')
DROP PROCEDURE SP_ActividadCampo_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_ActividadCampo_Insert] 
	-- Add the parameters for the stored procedure here
	@c_codigo_act char(4),
	@c_codigo_cam char(2),
	@Id_Unidad char(2)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

		
			DELETE  from dbo.t_Actividad_Campo   
		    WHERE
		    	c_codigo_act=@c_codigo_act
				and c_codigo_cam=@c_codigo_cam
				
		
		
			INSERT INTO dbo.t_Actividad_Campo
	           (c_codigo_act,c_codigo_cam,Id_Unidad)
	     	VALUES
	           (@c_codigo_act
			   ,@c_codigo_cam
			   ,@Id_Unidad)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END