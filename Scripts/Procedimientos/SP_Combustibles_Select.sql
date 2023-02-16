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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Combustibles_Select')
DROP PROCEDURE SP_Combustibles_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Combustibles_Select
	-- Add the parameters for the stored procedure here
	@Fecha date
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select S.d_fechaconsumo_gas,
			S.Id_ActivosGas,
			A.v_descripcorta_act ,
			S.v_Bloques_gas,
			S.c_codigo_act ,
			ACT.v_nombre_act ,
			S.c_folio_gas,
			S.d_fecha_crea,
			S.c_codigo_eps,
			S.Id_Huerta,
			H.Nombre_Huerta ,
			S.c_codigo_emp,
			E.v_nombre_emp +' '+E.v_apellidopat_emp +' '+E.v_apellidomat_emp as Operador,
			S.v_tipo_gas,
			S.v_cantutilizada_gas * -1 as v_cantutilizada_gas,
			(select IT.v_cantingreso_gas - CT.v_cantutilizada_gas as  Cant_Conbustible
				from 
				(select  isnull(sum(isnull(TI.v_cantingreso_gas,0)),0) as v_cantingreso_gas 
					from t_Gasolina_Ingreso as TI 
					where TI.c_codigo_eps =S.c_codigo_eps 
					and TI.Id_Huerta =S.Id_Huerta 
					and TI.d_fechaingreso_gas < S.d_fechaconsumo_gas 
					and rtrim(ltrim(TI.v_tipo_gas)) =rtrim(ltrim(S.v_tipo_gas)) ) as IT
				left join ( 
					select  isnull(sum(isnull(TC.v_cantutilizada_gas,0)),0) as v_cantutilizada_gas 
					from t_Gasolina_Consumo as TC 
					where TC.c_codigo_eps =S.c_codigo_eps 
					and TC.Id_Huerta =S.Id_Huerta 
					and TC.d_fechaconsumo_gas < S.d_fechaconsumo_gas 
					and rtrim(ltrim(TC.v_tipo_gas)) =rtrim(ltrim(S.v_tipo_gas)) ) as CT
				on 1=1) as Saldo,
			S.v_observaciones_gas,
			S.n_rendimiento_act,
			S.c_unidad_act,
			U.Abreviatura
		from ShellPest.dbo.t_Gasolina_Consumo as S 
		left join ShellPest.dbo.t_Huerta as H on H.Id_Huerta =S.Id_Huerta 
		left join AGV.dbo.afiactivo as A on A.c_codigo_act =S.Id_ActivosGas 
		left join GrupoAGV.dbo.cosactividad as ACT on ACt.c_codigo_act =S.c_codigo_act 
		left join GrupoAGV.dbo.nomempleados as E on E.c_codigo_emp =S.c_codigo_emp 
		left join t_Unidad as U on U.Id_Unidad=S.c_unidad_act
		where S.d_fechaconsumo_gas=@Fecha
		
		UNION all
		
		select I.d_fechaingreso_gas ,
			'0000' as Activo,
			'Recarga de combustible' as Nombre_activo,
			'0000' as Bloque,
			'0000' as Actividad,
			'Recarga de combustible' as Concepto,
			I.c_folio_gas ,
			I.d_fecha_crea ,
			I.c_codigo_eps ,
			I.Id_Huerta ,
			H.Nombre_Huerta ,
			I.c_codigo_emp ,
			E.v_nombre_emp +' '+E.v_apellidopat_emp +' '+E.v_apellidomat_emp as Operador,
			I.v_tipo_gas ,
			I.v_cantingreso_gas ,
			(select IT.v_cantingreso_gas - CT.v_cantutilizada_gas as  Cant_Conbustible
				from 
				(select  isnull(sum(isnull(TI.v_cantingreso_gas,0)),0) as v_cantingreso_gas 
					from t_Gasolina_Ingreso as TI 
					where TI.c_codigo_eps =I.c_codigo_eps 
					and TI.Id_Huerta =I.Id_Huerta 
					and TI.d_fechaingreso_gas < I.d_fechaingreso_gas 
					and rtrim(ltrim(TI.v_tipo_gas)) =rtrim(ltrim(I.v_tipo_gas)) ) as IT
				left join ( 
					select  isnull(sum(isnull(TC.v_cantutilizada_gas,0)),0) as v_cantutilizada_gas 
					from t_Gasolina_Consumo as TC 
					where TC.c_codigo_eps =I.c_codigo_eps 
					and TC.Id_Huerta =I.Id_Huerta 
					and TC.d_fechaconsumo_gas < I.d_fechaingreso_gas 
					and rtrim(ltrim(TC.v_tipo_gas)) =rtrim(ltrim(I.v_tipo_gas)) ) as CT
				on 1=1) as Saldo,
			I.v_observaciones_gas,
			'0' as Rendimiento,
			'N/A' as Unidad ,
			'N/A' as Abrevia
		from ShellPest.dbo.t_Gasolina_Ingreso as I 
		left join ShellPest.dbo.t_Huerta as H on H.Id_Huerta =I.Id_Huerta 
		left join GrupoAGV.dbo.nomempleados as E on E.c_codigo_emp =I.c_codigo_emp 
		where I.d_fechaingreso_gas=@Fecha
END
GO
