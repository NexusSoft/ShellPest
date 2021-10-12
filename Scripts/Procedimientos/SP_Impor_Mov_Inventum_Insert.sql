USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Impor_Mov_Inventum_Insert')
DROP PROCEDURE SP_Impor_Mov_Inventum_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Impor_Mov_Inventum_Insert] 
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


					   
			DECLARE @table TABLE ( Almacenes CHAR(2),Columna integer)

		DECLARE @Cont INT = 1;

			if (@c_codigo_eps='01')
			begin		   
				if ((select sum(inv.n_cantidad_mov) as mov  
					FROM agv.dbo.invmovimiento as inv
					left join agv.dbo.invsalida as TTS on TTS.c_codigo_sal =inv.c_coddoc_mov  and TTS.c_codigo_tem =inv.c_codigo_tem 
					where inv.c_codigo_mov>(select isnull(max(ult_CodMov_Inv),'0000000000') 
						from t_Movimientos 
						where c_codigo_eps=@c_codigo_eps)
					and TTS.c_codigo_tmv!='04'
					group by inv.c_codigo_alm)
					<
					0)
				begin
				
					insert into t_Salidas (c_codigo_sal
						,c_codigo_tmv
						,d_documento_sal
						,c_codigo_alm
						,Id_Usuario_Crea
						,F_Usuario_Crea
						,c_codigo_eps
						)
						(SELECT CONVERT(Varchar(50),GETDATE(),12)+inv.c_codigo_alm+(select right(Concat('00',(sum(T.N)+1)),2) 
							From (select count(E.c_codigo_ent) as N 
									from t_Entradas as E 
									where E.c_codigo_alm=inv.c_codigo_alm 
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_ent)=Convert(date,getdate())
									union 
									select count(S.c_codigo_sal) as N 
									from t_Salidas as S 
									where S.c_codigo_alm=inv.c_Codigo_alm 
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_sal)=Convert(date,getdate())
								) 
							as T) as c_codigo_ent, 
							S.c_codigo_tmv,
							GETDATE() as d_documento_ent ,
							inv.c_codigo_alm,
							@Id_Usuario as Id_Usuario_Crea,
							GETDATE() as F_Usuario_Crea,
							@c_codigo_eps
						FROM agv.dbo.invmovimiento as inv
						left join agv.dbo.invsalida as S on S.c_codigo_sal =inv.c_coddoc_mov and S.c_codigo_tem =inv.c_codigo_tem 
						where inv.c_codigo_mov>(select isnull(max(ult_CodMov_Inv),'0000000000') from t_Movimientos where c_codigo_eps=@c_codigo_eps)
						group by inv.c_codigo_alm,S.c_codigo_tmv) 
			
				end
				else 
				begin
				
					insert into t_Entradas (c_codigo_ent
						,c_codigo_tmv
						,d_documento_ent
						,c_codigo_alm
						,Id_Usuario_Crea
						,F_Usuario_Crea
						,c_codigo_eps
						)
						(SELECT CONVERT(Varchar(50),GETDATE(),12)+inv.c_codigo_alm+(
							select right(Concat('00',(sum(T.N)+1)),2) 
							From (select count(TE.c_codigo_ent) as N 
									from t_Entradas as TE 
									where TE.c_codigo_alm=inv.c_codigo_alm 
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_ent)=Convert(date,getdate())
									union 
									select count(TS.c_codigo_sal) as N 
									from t_Salidas as TS 
									where TS.c_codigo_alm=inv.c_Codigo_alm 
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_sal)=Convert(date,getdate())
								)
							as T) as c_codigo_ent,
							E.c_codigo_tmv,
							GETDATE() as d_documento_ent,
							inv.c_codigo_alm,
							@Id_Usuario as Id_Usuario_Crea,
							GETDATE() as F_Usuario_Crea
							,@c_codigo_eps
						FROM agv.dbo.invmovimiento as inv
						left join agv.dbo.inventrada as E on E.c_codigo_ent =inv.c_coddoc_mov and E.c_codigo_tem =inv.c_codigo_tem 
						where inv.c_codigo_mov>(select isnull(max(ult_CodMov_Inv),'0000000000') from t_Movimientos where c_codigo_eps=@c_codigo_eps)
						group by inv.c_codigo_alm,E.c_codigo_tmv) 
				
				end
				
				insert into @table (Almacenes,Columna)(SELECT 
					c_codigo_alm,ROW_NUMBER() OVER(order by c_codigo_alm )
				FROM agv.dbo.invmovimiento 
				group by c_codigo_alm)
			
				set @Cont = 1;
			
				WHILE(@Cont 
					<= 
					(SELECT count(c_codigo_alm) FROM agv.dbo.invmovimiento where c_codigo_alm=(select almacenes from @table where Columna=@Cont) group by c_codigo_alm)) 
				BEGIN
				
					insert into t_Movimientos (c_tipodoc_mov
					  ,c_coddoc_mov
					  ,c_codigo_pro
					  ,n_movipro_mov
					  ,n_exiant_mov
					  ,n_cantidad_mov
					  ,ult_CodMov_Inv
					  ,c_codigo_eps)
					(SELECT case when sum(TI.n_cantidad_mov)>0 then 'E' when sum(TI.n_cantidad_mov)<0 then 'S' else 'F' end as c_tipodoc_mov,
						CONVERT(Varchar(50),GETDATE(),12)+TI.c_codigo_alm+(select right(Concat('00',(sum(T.N)+1)),2) 
							From (select count(c_codigo_ent) as N 
									from t_Entradas as E 
									where c_codigo_alm=(select almacenes from @table where Columna=@Cont) 
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_ent)=Convert(date,getdate())
									union 
									select count(c_codigo_sal) as N 
									from t_Salidas as S 
									where c_codigo_alm=(select almacenes from @table where Columna=@Cont)
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_sal)=Convert(date,getdate())
								) 
							as T) as c_coddoc_mov, 
						TI.c_codigo_pro,
								--ROW_NUMBER() OVER(order by c_codigo_alm,c_codigo_pro )  AS  Secuencia,
						(select isnull(max(MT.n_movipro_mov)+1,0) 
							from t_Movimientos as MT 
							where MT.c_codigo_pro=TI.c_codigo_pro and c_codigo_eps=@c_codigo_eps) As n_movipro_mov,
						(sum(TI.n_exiant_mov) + sum(TI.n_cantidad_mov)) As Existencia,
						sum(TI.n_cantidad_mov) as n_cantidad_mov,
						(select isnull(max(c_codigo_mov),'0000000000') 
							from agv.dbo.invmovimiento 
							where c_codigo_alm=(select almacenes from @table where Columna=@Cont)),
						@c_codigo_eps
					FROM agv.dbo.invmovimiento TI
					left join agv.dbo.invsalida as TS on TS.c_codigo_sal=TI.c_coddoc_mov and TI.c_codigo_tem=TS.c_codigo_tem
					where TI.c_codigo_alm=(select almacenes from @table where Columna=@Cont)
					and TS.c_codigo_tmv!='04'
					and TI.c_codigo_mov>(select isnull(max(ult_CodMov_Inv),'0000000000') 
						from t_Movimientos 
						where TI.c_codigo_alm=(select almacenes 
							from @table where Columna=@Cont)
							and c_codigo_eps=@c_codigo_eps)
					group by TI.c_codigo_alm,TI.c_codigo_pro  
					HAVING  sum(TI.n_cantidad_mov)!=0)
				
					set @Cont += 1;
				END
			end

			if (@c_codigo_eps='12')
			begin		   
				if ((select sum(inv.n_cantidad_mov) as mov  
					FROM El_Mirador.dbo.invmovimiento as inv
					left join El_Mirador.dbo.invsalida as TTS on TTS.c_codigo_sal =inv.c_coddoc_mov  and TTS.c_codigo_tem =inv.c_codigo_tem 
					where inv.c_codigo_mov>(select isnull(max(ult_CodMov_Inv),'0000000000') 
						from t_Movimientos 
						where c_codigo_eps=@c_codigo_eps)
					and TTS.c_codigo_tmv!='04'
					group by inv.c_codigo_alm)
					<
					0)
				begin
				
					insert into t_Salidas (c_codigo_sal
						,c_codigo_tmv
						,d_documento_sal
						,c_codigo_alm
						,Id_Usuario_Crea
						,F_Usuario_Crea
						,c_codigo_eps
						)
						(SELECT CONVERT(Varchar(50),GETDATE(),12)+inv.c_codigo_alm+(select right(Concat('00',(sum(T.N)+1)),2) 
							From (select count(E.c_codigo_ent) as N 
									from t_Entradas as E 
									where E.c_codigo_alm=inv.c_codigo_alm 
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_ent)=Convert(date,getdate())
									union 
									select count(S.c_codigo_sal) as N 
									from t_Salidas as S 
									where S.c_codigo_alm=inv.c_Codigo_alm 
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_sal)=Convert(date,getdate())
								) 
							as T) as c_codigo_ent, 
							S.c_codigo_tmv,
							GETDATE() as d_documento_ent ,
							inv.c_codigo_alm,
							@Id_Usuario as Id_Usuario_Crea,
							GETDATE() as F_Usuario_Crea,
							@c_codigo_eps
						FROM El_Mirador.dbo.invmovimiento as inv
						left join El_Mirador.dbo.invsalida as S on S.c_codigo_sal =inv.c_coddoc_mov and S.c_codigo_tem =inv.c_codigo_tem 
						where inv.c_codigo_mov>(select isnull(max(ult_CodMov_Inv),'0000000000') from t_Movimientos where c_codigo_eps=@c_codigo_eps)
						group by inv.c_codigo_alm,S.c_codigo_tmv) 
			
				end
				else 
				begin
				
					insert into t_Entradas (c_codigo_ent
						,c_codigo_tmv
						,d_documento_ent
						,c_codigo_alm
						,Id_Usuario_Crea
						,F_Usuario_Crea
						,c_codigo_eps
						)
						(SELECT CONVERT(Varchar(50),GETDATE(),12)+inv.c_codigo_alm+(
							select right(Concat('00',(sum(T.N)+1)),2) 
							From (select count(TE.c_codigo_ent) as N 
									from t_Entradas as TE 
									where TE.c_codigo_alm=inv.c_codigo_alm 
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_ent)=Convert(date,getdate())
									union 
									select count(TS.c_codigo_sal) as N 
									from t_Salidas as TS 
									where TS.c_codigo_alm=inv.c_Codigo_alm 
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_sal)=Convert(date,getdate())
								)
							as T) as c_codigo_ent,
							E.c_codigo_tmv,
							GETDATE() as d_documento_ent,
							inv.c_codigo_alm,
							@Id_Usuario as Id_Usuario_Crea,
							GETDATE() as F_Usuario_Crea
							,@c_codigo_eps
						FROM El_Mirador.dbo.invmovimiento as inv
						left join El_Mirador.dbo.inventrada as E on E.c_codigo_ent =inv.c_coddoc_mov and E.c_codigo_tem =inv.c_codigo_tem 
						where inv.c_codigo_mov>(select isnull(max(ult_CodMov_Inv),'0000000000') from t_Movimientos where c_codigo_eps=@c_codigo_eps)
						group by inv.c_codigo_alm,E.c_codigo_tmv) 
				
				end
				
				insert into @table (Almacenes,Columna)(SELECT 
					c_codigo_alm,ROW_NUMBER() OVER(order by c_codigo_alm )
				FROM El_Mirador.dbo.invmovimiento 
				group by c_codigo_alm)
			
				set @Cont = 1;
			
				WHILE(@Cont 
					<= 
					(SELECT count(c_codigo_alm) FROM El_Mirador.dbo.invmovimiento where c_codigo_alm=(select almacenes from @table where Columna=@Cont) group by c_codigo_alm)) 
				BEGIN
				
					insert into t_Movimientos (c_tipodoc_mov
					  ,c_coddoc_mov
					  ,c_codigo_pro
					  ,n_movipro_mov
					  ,n_exiant_mov
					  ,n_cantidad_mov
					  ,ult_CodMov_Inv
					  ,c_codigo_eps)
					(SELECT case when sum(TI.n_cantidad_mov)>0 then 'E' when sum(TI.n_cantidad_mov)<0 then 'S' else 'F' end as c_tipodoc_mov,
						CONVERT(Varchar(50),GETDATE(),12)+TI.c_codigo_alm+(select right(Concat('00',(sum(T.N)+1)),2) 
							From (select count(c_codigo_ent) as N 
									from t_Entradas as E 
									where c_codigo_alm=(select almacenes from @table where Columna=@Cont) 
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_ent)=Convert(date,getdate())
									union 
									select count(c_codigo_sal) as N 
									from t_Salidas as S 
									where c_codigo_alm=(select almacenes from @table where Columna=@Cont)
									and c_codigo_eps=@c_codigo_eps
									and Convert(date,d_documento_sal)=Convert(date,getdate())
								) 
							as T) as c_coddoc_mov, 
						TI.c_codigo_pro,
								--ROW_NUMBER() OVER(order by c_codigo_alm,c_codigo_pro )  AS  Secuencia,
						(select isnull(max(MT.n_movipro_mov)+1,0) 
							from t_Movimientos as MT 
							where MT.c_codigo_pro=TI.c_codigo_pro and c_codigo_eps=@c_codigo_eps) As n_movipro_mov,
						(sum(TI.n_exiant_mov) + sum(TI.n_cantidad_mov)) As Existencia,
						sum(TI.n_cantidad_mov) as n_cantidad_mov,
						(select isnull(max(c_codigo_mov),'0000000000') 
							from El_Mirador.dbo.invmovimiento 
							where c_codigo_alm=(select almacenes from @table where Columna=@Cont)),
						@c_codigo_eps
					FROM El_Mirador.dbo.invmovimiento TI
					left join El_Mirador.dbo.invsalida as TS on TS.c_codigo_sal=TI.c_coddoc_mov and TI.c_codigo_tem=TS.c_codigo_tem
					where TI.c_codigo_alm=(select almacenes from @table where Columna=@Cont)
					and TS.c_codigo_tmv!='04'
					and TI.c_codigo_mov>(select isnull(max(ult_CodMov_Inv),'0000000000') 
						from t_Movimientos 
						where TI.c_codigo_alm=(select almacenes 
							from @table where Columna=@Cont)
							and c_codigo_eps=@c_codigo_eps)
					group by TI.c_codigo_alm,TI.c_codigo_pro  
					HAVING  sum(TI.n_cantidad_mov)!=0)
				
					set @Cont += 1;
				END
			end
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
