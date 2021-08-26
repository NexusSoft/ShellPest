USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Impor_InvIni_Inventum_Insert')
DROP PROCEDURE SP_Impor_InvIni_Inventum_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Impor_InvIni_Inventum_Insert] 
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


					   
			insert into t_Entradas (c_codigo_ent
			    ,c_codigo_tmv
			    ,d_documento_ent
			    ,c_codigo_alm
			    ,Id_Usuario_Crea
			    ,F_Usuario_Crea
			    )
				(SELECT 
				CONVERT(Varchar(50),GETDATE(),12)+inv.c_codigo_alm+'01' as c_codigo_ent,'00' as c_codigo_tmv,GETDATE() as d_documento_ent ,c_codigo_alm,'ADMIN' as Id_Usuario_Crea,GETDATE() as F_Usuario_Crea
			FROM agv.dbo.invmovimiento as inv
			group by inv.c_codigo_alm) 
			
			
			DECLARE @table TABLE ( Almacenes CHAR(2),Columna integer)
				
			insert into @table (Almacenes,Columna)(SELECT 
				c_codigo_alm,ROW_NUMBER() OVER(order by c_codigo_alm )
			FROM agv.dbo.invmovimiento 
			group by c_codigo_alm)
			
			DECLARE @Cont INT = 1;
			WHILE(@Cont <= (SELECT count(c_codigo_alm) FROM agv.dbo.invmovimiento where c_codigo_alm=(select almacenes from @table where Columna=@Cont) group by c_codigo_alm)) BEGIN
			    insert into t_Movimientos (c_tipodoc_mov
			      ,c_coddoc_mov
			      ,c_codigo_pro
			      ,n_movipro_mov
			      ,n_exiant_mov
			      ,n_cantidad_mov
				  ,ult_CodMov_Inv)
				(SELECT 'E' as c_tipodoc_mov,
					CONVERT(Varchar(50),GETDATE(),12)+c_codigo_alm+'01' as c_coddoc_mov, 
					c_codigo_pro,
					--ROW_NUMBER() OVER(order by c_codigo_alm,c_codigo_pro )  AS  Secuencia,
					1 n_movipro_mov,
					0 As Existencia,
					sum(n_cantidad_mov) as n_cantidad_mov,
					(select isnull(max(c_codigo_mov),'0000000001') from agv.dbo.invmovimiento where c_codigo_alm=(select almacenes from @table where Columna=@Cont))
				FROM agv.dbo.invmovimiento
				where c_codigo_alm=(select almacenes from @table where Columna=@Cont)
				
				group by c_codigo_alm,c_codigo_pro  HAVING  sum(n_cantidad_mov)>0)
			    set @Cont += 1;
			END
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
