USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Cambios_Riego_Delete')
DROP PROCEDURE SP_Cambios_Riego_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Cambios_Riego_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Bloque char(4),
	@Id_Valvula char(3),
	@Id_Cambio int,
	@SinDet bit
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try
	
	
			
				   
		if @SinDet=0		   
			delete from t_Cambio_Riego_Det 
			where Id_Bloque=@Id_Bloque and 
				Id_Valvula=@Id_Valvula and
				Id_Cambio=@Id_Cambio 
		else
			delete dbo.t_Cambios_Riego 
		    where Id_Cambio = @Id_Cambio
		     	
		
		if @SinDet=1
			delete dbo.t_Cambio_Riego_Det 
		    where Id_Cambio = @Id_Cambio
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
