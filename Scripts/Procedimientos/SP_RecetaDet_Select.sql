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
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_RecetaDet_Select')
DROP PROCEDURE SP_RecetaDet_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_RecetaDet_Select
	-- Add the parameters for the stored procedure here
	@Id_Receta char(7),
	@c_codigo_eps char(2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		declare @Consulta varchar(600)
		set @Consulta='select dt.Id_Receta '
	      set @Consulta=@Consulta+',dt.Secuencia '
		  set @Consulta=@Consulta+',dt.c_codigo_pro '
		  set @Consulta=@Consulta+',dt.v_nombre_pro '
		  --set @Consulta=@Consulta+',dt.c_codigo_cac '
		  --set @Consulta=@Consulta+',dt.v_nombre_cac '
		  set @Consulta=@Consulta+',pro.v_intervaloseguridad_pro '
		  set @Consulta=@Consulta+',pro.v_perentrada_pro '
		  set @Consulta=@Consulta+',dt.c_codigo_uni '
          set @Consulta=@Consulta+',uni.v_nombre_uni '
		  set @Consulta=@Consulta+',dt.Dosis '
		  set @Consulta=@Consulta+',dt.Cantidad_Unitaria '
		  set @Consulta=@Consulta+',dt.Descripcion '
	      set @Consulta=@Consulta+',dt.Id_Usuario_Crea '
	      set @Consulta=@Consulta+',us.Nombre_Usuario as Creador '
	      set @Consulta=@Consulta+',dt.Id_Usuario_Mod '
	      set @Consulta=@Consulta+',usm.Nombre_Usuario as Modificador '
		set @Consulta=@Consulta+'from t_RecetaDet as dt '
		set @Consulta=@Consulta+'inner join t_Usuarios as us on us.Id_Usuario=dt.Id_Usuario_Crea '
		set @Consulta=@Consulta+'left join t_Usuarios as usm on usm.Id_Usuario=dt.Id_Usuario_Mod '
		set @Consulta=@Consulta+'left join '+(select v_basedatos_coi from vistas.dbo.conempresa where c_codigo_eps=@c_codigo_eps)+'.dbo.invunidad as uni on uni.c_codigo_uni=dt.c_codigo_uni '
		set @Consulta=@Consulta+'left join '+(select v_basedatos_coi from vistas.dbo.conempresa where c_codigo_eps=@c_codigo_eps)+'.dbo.invproducto as pro on pro.c_codigo_pro=dt.c_codigo_pro'
		set @Consulta=@Consulta+'where dt.Id_Receta='+char(39)+@Id_Receta+char(39)+' and dt.c_codigo_eps='+char(39)+@c_codigo_eps+char(39)
	
	exec (@Consulta)

END
GO
