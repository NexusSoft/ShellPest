USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_RiegoValvulasV2_Insert')
DROP PROCEDURE SP_RiegoValvulasV2_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_RiegoValvulasV2_Insert] 
	-- Add the parameters for the stored procedure here
	@Fecha	datetime,
	@Hora	time(7),
	@Id_Bloque	char(4),
	@Id_Cambio int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try
	
	
		insert into t_Riego_Valvulas (Id_Bloque
			  ,Fecha
			  ,Hora
			  ,Id_Valvula) 
		 (select @Id_Bloque,
				   @Fecha,
				   @Hora, V.Id_Valvula 
			from t_Valvulas as V 
			inner join t_Cambio_Riego_Det as CRD on CRD.Id_Bloque=V.Id_Bloque and CRD.Id_Valvula=V.Id_Valvula  where CRD.Id_Bloque=@Id_Bloque and Id_Cambio=@Id_Cambio)
			   
			
	
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
