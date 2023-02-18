USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Combustibles_Delete')
DROP PROCEDURE SP_Combustibles_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Combustibles_Delete] 
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

	if @EntOSal='S' 

		Delete from dbo.t_Gasolina_Consumo where 
				   c_folio_gas=@c_folio_gas and
				   d_fechaconsumo_gas=@d_fecha_gas and
				   c_codigo_eps=@c_codigo_eps and
				   Id_Huerta=@Id_Huerta and
				   v_Bloques_gas=@v_Bloques_gas and
				   Id_ActivosGas=@Id_ActivosGas and
				   c_codigo_emp=@c_codigo_emp and
				   c_codigo_act=@c_codigo_act and
				   v_tipo_gas=@v_tipo_gas

		else
		
		Delete from dbo.t_Gasolina_Ingreso where
					c_folio_gas=@c_folio_gas and
					d_fechaingreso_gas=@d_fecha_gas and
					c_codigo_eps=@c_codigo_eps and
					Id_Huerta=@Id_Huerta and
					c_codigo_emp=@c_codigo_emp and
					v_tipo_gas=@v_tipo_gas
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
