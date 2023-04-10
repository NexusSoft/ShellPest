USE [ShellPest]
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_PrecargarListaBloqGas_Select')
DROP PROCEDURE SP_PrecargarListaBloqGas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_PrecargarListaBloqGas_Select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @bloques varchar(200),@Fecha datetime,@Huerta char(2),@gas varchar(50),@emp char(6),@Activo char(4),@actividad char(4)

 
WHILE (SELECT count(Id_Huerta) FROM t_Gasolina_Consumo where CHARINDEX(',',v_Bloques_gas)>0 and concat(d_fechaconsumo_gas,
		rtrim(ltrim(Id_Huerta)),
		rtrim(ltrim(v_tipo_gas)),
		rtrim(ltrim(c_codigo_emp)),
		rtrim(ltrim(c_codigo_act)),
		rtrim(ltrim(Id_ActivosGas))) not in (select concat(rtrim(ltrim(Fecha)),
		rtrim(ltrim(c_codigo_cam)),
		rtrim(ltrim(v_tipo_gas)),
		rtrim(ltrim(c_codigo_emp)),
		rtrim(ltrim(c_codigo_act)),
		rtrim(ltrim(Id_ActivosGas))) from t_Gasolina_mixbloques)) >0  
BEGIN 

	select @bloques=v_Bloques_gas,
		@Fecha=d_fechaconsumo_gas,
		@Huerta=Id_Huerta,
		@gas=v_tipo_gas,
		@emp=c_codigo_emp,
		@Activo=Id_ActivosGas,
		@actividad=c_codigo_act
	from t_Gasolina_Consumo
	where CHARINDEX(',',v_Bloques_gas)>0
		and  concat(d_fechaconsumo_gas,
		rtrim(ltrim(Id_Huerta)),
		rtrim(ltrim(v_tipo_gas)),
		rtrim(ltrim(c_codigo_emp)),
		rtrim(ltrim(c_codigo_act)),
		rtrim(ltrim(Id_ActivosGas))) not in (select concat(rtrim(ltrim(Fecha)),
		rtrim(ltrim(c_codigo_cam)),
		rtrim(ltrim(v_tipo_gas)),
		rtrim(ltrim(c_codigo_emp)),
		rtrim(ltrim(c_codigo_act)),
		rtrim(ltrim(Id_ActivosGas))) from t_Gasolina_mixbloques)
	
   insert t_Gasolina_mixbloques (c_codigo_lot,Fecha,c_codigo_cam,Id_ActivosGas,c_codigo_emp,c_codigo_act,v_tipo_gas) 
   (select rtrim(ltrim(value)),@Fecha,@Huerta,@Activo,@emp,@actividad,@gas from STRING_SPLIT( @bloques, ','))
      CONTINUE  
  
end


				
END
GO
