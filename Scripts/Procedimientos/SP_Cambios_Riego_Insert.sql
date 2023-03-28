USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Cambios_Riego_Insert')
DROP PROCEDURE SP_Cambios_Riego_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Cambios_Riego_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Bloque char(4),
	@Id_Cambio int,
	@N_Cambio int,
	@Id_Valvula char(3),
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
	
	declare @Existe int
		select @Existe = count(Id_Cambio) from dbo.t_Cambios_Riego a where (a.Id_Cambio=@Id_Cambio)
		
		declare @Maximo int
		if @Id_Cambio=''
			select @Maximo = count(Id_Cambio)+1 from dbo.t_Cambios_Riego a 

		if @Existe>0
			update dbo.t_Cambios_Riego 
			set N_Cambio=@N_Cambio
			where  Id_Cambio=@Id_Cambio
		else
			INSERT INTO dbo.t_Cambios_Riego
		           (Id_Cambio,
				   N_Cambio)	
		     	VALUES
		           (@Maximo,
				   @N_Cambio)
			
		if @Existe>0
			INSERT INTO t_Cambio_Riego_Det
				(Id_Bloque,
				Id_Valvula,
				Id_Cambio)
			VALUES
				(@Id_Bloque,
				@Id_Valvula,
				@Id_Cambio)   
		else if @SinDet=0		   
			INSERT INTO t_Cambio_Riego_Det
				(Id_Bloque,
				Id_Valvula,
				Id_Cambio)
			VALUES
				(@Id_Bloque,
				@Id_Valvula,
				@Maximo)
	
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
