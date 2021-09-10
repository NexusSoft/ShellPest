USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Control_ExistenciaProAlm_Select')
DROP PROCEDURE SP_WS_Control_ExistenciaProAlm_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_WS_Control_ExistenciaProAlm_Select] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto char(10)

	begin transaction T1;
	begin try

			select Tg.c_codigo_eps,TG.c_codigo_pro,TG.c_codigo_alm,sum(Existencia) as Existencia from (
			select S.c_codigo_sal,S.c_codigo_eps,S.c_codigo_alm,M.c_codigo_pro,(sum(M.n_exiant_mov) + sum(M.n_cantidad_mov)) as Existencia from t_Salidas as S
			inner join t_Movimientos as M on M.c_coddoc_mov=S.c_codigo_sal and M.c_codigo_eps=S.c_codigo_eps
			group by S.c_codigo_sal,S.c_codigo_eps,S.c_codigo_alm,M.c_codigo_pro
			union
			select E.c_codigo_ent,E.c_codigo_eps,E.c_codigo_alm,M.c_codigo_pro,(sum(M.n_exiant_mov) + sum(M.n_cantidad_mov)) as Existencia from t_Entradas as E
			inner join t_Movimientos as M on M.c_coddoc_mov=E.c_codigo_ent and M.c_codigo_eps=E.c_codigo_eps
			group by E.c_codigo_ent,E.c_codigo_eps,E.c_codigo_alm,M.c_codigo_pro) as TG
			group by  TG.c_codigo_eps,TG.c_codigo_alm,TG.c_codigo_pro
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
