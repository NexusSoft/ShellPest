USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Catalogos_AlmacenHuerto_Select')
DROP PROCEDURE SP_WS_Catalogos_AlmacenHuerto_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_WS_Catalogos_AlmacenHuerto_Select] 
	-- Add the parameters for the stored procedure here
	@Id_Usuario varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto char(10)

	begin transaction T1;
	begin try

		select TG.v_nombre_alm, TG.v_nombre_hue, TG.c_codigo_alm, TG.c_codigo_hue, TG.c_codigo_eps from (
				select alm.v_nombre_alm,
					hue.Nombre_Huerta as v_nombre_hue,
					ah.c_codigo_alm,
					ah.c_codigo_hue,
					'01' as c_codigo_eps
				from t_Almacen_Huerto as ah
					left join agv.dbo.invalmacen as alm on alm.c_codigo_alm=ah.c_codigo_alm and ah.c_codigo_eps='01'
					left join t_huerta as hue on hue.Id_Huerta=ah.c_codigo_hue and hue.c_codigo_eps='01'
				where alm.c_activo_alm='1' and hue.Activa_Huerta='1'
		
				union
				
				select alm.v_nombre_alm,
					hue.Nombre_Huerta as v_nombre_hue,
					ah.c_codigo_alm,
					ah.c_codigo_hue,
					'12' as c_codigo_eps
				from t_Almacen_Huerto as ah
					left join El_Mirador.dbo.invalmacen as alm on alm.c_codigo_alm=ah.c_codigo_alm and ah.c_codigo_eps='12'
					left join t_huerta as hue on hue.Id_Huerta=ah.c_codigo_hue and hue.c_codigo_eps='12'
				where alm.c_activo_alm='1' and hue.Activa_Huerta='1'
			) as TG
		inner join t_Usuario_Empresa as UE on UE.c_codigo_eps = TG.c_codigo_eps
		where UE.Id_Usuario =@Id_Usuario
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
