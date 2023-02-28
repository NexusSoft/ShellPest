USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_CosCampo_Select')
DROP PROCEDURE SP_CosCampo_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_CosCampo_Select] 
	-- Add the parameters for the stored procedure here
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

		
			select cam.v_nombre_cam ,
				hue.c_codigo_cam  
			from ShellPest.dbo.t_Huerta as hue 
			inner join GrupoAGV.dbo.coscampo as cam on hue.c_codigo_cam =cam.c_codigo_cam 
			WHERE hue.c_codigo_eps =@c_codigo_eps
			group by cam.v_nombre_cam ,hue.c_codigo_cam
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END