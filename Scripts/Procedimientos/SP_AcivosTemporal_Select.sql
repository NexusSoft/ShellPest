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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_AcivosTemporal_Select')
DROP PROCEDURE SP_AcivosTemporal_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_AcivosTemporal_Select
	-- Add the parameters for the stored procedure here
	@id_usuario varchar(10),
	@Fecha varchar(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		SELECT act.c_codigo_act as Id_ActivosGas , act.v_descripcorta_act, act.v_serie_act, act.c_codigo_fam, act.c_codigo_are 
		from AGV.dbo.afiactivo as act
		inner join t_Huerta_Dep as hd on hd.c_codigo_dep = act.c_codigo_are 
		inner join t_Usuario_Huerta as us on us.Id_Huerta = hd.Id_Huerta
		where c_codigo_fam 
		in ('0003' , '0004' , '0006') and c_activo_act = '1' 
		and us.Id_Usuario = @id_usuario
		and (act.d_creacion_act >=@Fecha or act.d_modifi_act>=@Fecha	)
		group by act.c_codigo_act,act.v_descripcorta_act, act.v_serie_act, act.c_codigo_fam, act.c_codigo_are	
			union 
 		select ltrim(rtrim(c_codigo_act)) as c_codigo_act ,v_nombre_act,v_serie_act,c_codigo_fam,c_codigo_are from t_Activos_Temporal 	
END
GO
