USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Valvulas_Delete')
DROP PROCEDURE SP_Valvulas_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Valvulas_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Bloque char(4),
	@Id_Valvula char(3),
	@N_Arboles int,
	@N_Replantes int,
	@N_Morras int,
	@N_Micros int,
	@N_Caudales numeric(10,2),
	@M3 numeric(10,2),
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
			delete from t_ValvulasDet 
			where Id_Bloque=@Id_Bloque and 
				Id_Valvula=@Id_Valvula and
				N_Micros=@N_Micros and
				N_Caudales = @N_Caudales and 
				M3 =@M3
		else
			update dbo.t_Valvulas set Activo=0
		    where Id_Bloque = @Id_Bloque and 
				   Id_Valvula =@Id_Valvula
		     	
		
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
