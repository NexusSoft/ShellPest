USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Valvulas_Insert')
DROP PROCEDURE SP_Valvulas_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Valvulas_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Bloque char(4),
	@Id_Valvula char(3),
	@N_Valvula int,
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
	
	declare @Existe int
		select @Existe = count(Id_Valvula) from dbo.t_Valvulas a where (a.Id_Valvula=@Id_Valvula and a.Id_bloque=@Id_bloque)
		
		declare @Maximo int
		if @Id_Valvula=''
			select @Maximo = count(Id_Valvula)+1 from dbo.t_Valvulas a where ( a.Id_bloque=@Id_bloque)

		if @Existe>0
			update dbo.t_Valvulas 
			set N_Valvula=@N_Valvula,N_Arboles=@N_Arboles, N_Replantes=@N_Replantes, N_Morras=@N_Morras
			where Id_Bloque=@Id_Bloque and Id_Valvula=@Id_Valvula
		else
			INSERT INTO dbo.t_Valvulas
		           (Id_Bloque,
				   Id_Valvula,
				   N_Valvula,
				   N_Arboles,
				   N_Replantes,
				   N_Morras,
				   Activo)	
		     	VALUES
		           (@Id_Bloque,
				   @Maximo,
				   @N_Valvula,
				   @N_Arboles,
				   @N_Replantes,
				   @N_Morras,
				   1)
			
		if @Existe>0
			INSERT INTO t_ValvulasDet
				(Id_Bloque,
				Id_Valvula,
				N_Micros,
				N_Caudales,
				M3)
			VALUES
				(@Id_Bloque,
				@Id_Valvula,
				@N_Micros,
				@N_Caudales,
				@M3)   
		else if @SinDet=0		   
			INSERT INTO t_ValvulasDet
				(Id_Bloque,
				Id_Valvula,
				N_Micros,
				N_Caudales,
				M3)
			VALUES
				(@Id_Bloque,
				@Maximo,
				@N_Micros,
				@N_Caudales,
				@M3)
	
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
