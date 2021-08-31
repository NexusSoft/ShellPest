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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Rpt_Salidas_Select')
DROP PROCEDURE SP_Rpt_Salidas_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_Rpt_Salidas_Select
	-- Add the parameters for the stored procedure here
	@Fini char(10),
	@Ffin char(10),
	@Almacen varchar(2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		SELECT inv.c_codigo_pro, 
			pro.v_nombre_pro, 
			inv.n_cantidad_mov, 
			sal.c_codigo_alm, 
			usu.Nombre_Usuario, 
			inv.Id_Bloque , 
			uni.v_abrevia_uni,
			tmv.v_nombre_tmv, 
			alm.v_nombre_alm, 
			sal.c_codigo_ent, 
			sal.d_documento_sal, 
			sal.c_codigo_tmv, 
			sal.c_codigo_tra, 
			sal.c_codigo_sal
		FROM t_Movimientos as inv, 
			agv.dbo.invproducto as pro
			left join agv.dbo.invunidad as uni on uni.c_codigo_uni =pro.c_codigo_uni,
			agv.dbo.invtipomovimiento as tmv, 
			agv.dbo.invalmacen as alm, 
			t_Salidas as sal
			left join t_Usuarios as usu on usu.Id_Usuario =sal.Id_Responsable
		WHERE ( pro.c_codigo_pro = inv.c_codigo_pro ) 
			and ( sal.c_codigo_alm = alm.c_codigo_alm ) 
			and ( sal.c_codigo_tmv = tmv.c_codigo_tmv ) 
			and ( sal.c_codigo_sal = inv.c_coddoc_mov ) 
			and ( ( sal.d_documento_sal >= @Fini ) 
				AND ( sal.d_documento_sal <= @Ffin ) 
				 ) 
				AND (( 'A' = 'A' and sal.c_codigo_alm like '%'+@Almacen+'%')
					OR ('S' = 'A' and sal.c_codigo_alm in (select c_codigo_alm from agv.dbo.invalmacen  where c_codigo_aso like ''))
					Or ('Z' = 'A' and sal.c_codigo_alm in (select c_codigo_alm from agv.dbo.invalmacen  where c_codigo_aso in
					(select c_codigo_aso from agv.dbo.assasociado (nolock) where c_codigo_zon like '') )))

END
GO
