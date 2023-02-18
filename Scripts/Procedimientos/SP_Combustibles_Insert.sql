USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Combustibles_Insert')
DROP PROCEDURE SP_Combustibles_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Combustibles_Insert] 
	-- Add the parameters for the stored procedure here
	@c_folio_gas char(40),
	@d_fecha_gas date,
	@c_codigo_eps char(2),
	@Id_Huerta char(5),
	@v_Bloques_gas varchar(50),
	@Id_ActivosGas char(4),
	@c_codigo_emp char(10),
	@c_codigo_act char(10),
	@v_tipo_gas varchar(50),
	@v_cant_gas numeric(10, 2),
	@v_horometro_gas varchar(50),
	@v_kminicial_gas numeric(18, 2),
	@v_kmfinal_gas numeric(18, 2),
	@v_observaciones_gas varchar(50),
	@n_rendimiento_act numeric(18,2),
	@c_unidad_act char(2),
	@EntOSal char(1)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try
	
	exec SP_Combustibles_Delete @c_folio_gas,@d_fecha_gas,@c_codigo_eps,@Id_Huerta,@v_Bloques_gas,@Id_ActivosGas,@c_codigo_emp,@c_codigo_act,@v_tipo_gas,@EntOSal;

	if @EntOSal='S' 

		INSERT INTO dbo.t_Gasolina_Consumo
		           (d_fecha_crea,
				   c_folio_gas,
				   d_fechaconsumo_gas,
				   c_codigo_eps,
				   Id_Huerta,
				   v_Bloques_gas,
				   Id_ActivosGas,
				   c_codigo_emp,
				   c_codigo_act,
				   v_tipo_gas,
				   v_cantutilizada_gas,
				   v_horometro_gas,
				   v_kminicial_gas,
				   v_kmfinal_gas,
				   v_observaciones_gas,
				   n_rendimiento_act,
				   c_unidad_act)	

		     	VALUES
		           (getdate(),
				   @c_folio_gas,
				   @d_fecha_gas,
				   @c_codigo_eps,
				   @Id_Huerta,
				   @v_Bloques_gas,
				   @Id_ActivosGas,
				   @c_codigo_emp,
				   @c_codigo_act,
				   @v_tipo_gas,
				   @v_cant_gas,
				   @v_horometro_gas,
				   @v_kminicial_gas,
				   @v_kmfinal_gas,
				   @v_observaciones_gas,
				   @n_rendimiento_act,
				   @c_unidad_act)
	else
		
		INSERT INTO dbo.t_Gasolina_Ingreso
		           (d_fecha_crea,
					c_folio_gas	,
					d_fechaingreso_gas,
					c_codigo_eps,
					Id_Huerta,
					c_codigo_emp,
					v_tipo_gas,
					v_cantingreso_gas,
					v_observaciones_gas)	

		     	VALUES
		           (getdate(),
					@c_folio_gas,
					@d_fecha_gas,
					@c_codigo_eps,
					@Id_Huerta,
					@c_codigo_emp,
					@v_tipo_gas,
					@v_cant_gas,
					@v_observaciones_gas)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
