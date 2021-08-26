USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Salidas_Det_Insert')
DROP PROCEDURE SP_Salidas_Det_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Salidas_Det_Insert] 
	-- Add the parameters for the stored procedure here
	@c_tipodoc_mov char(1),
	@c_coddoc_mov char(10),
	@c_codigo_pro varchar(15),
	@n_movipro_mov numeric(15, 0),
	@n_exiant_mov numeric(14,4),
	@n_cantidad_mov numeric(14,4),
	@Id_Bloque char(4)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try

			
			declare @Existe int
			select @Existe = count(c_coddoc_mov) from dbo.t_Movimientos a where (a.c_coddoc_mov=@c_coddoc_mov and a.Secuencia=@Secuencia)

			if @Existe>0 
				insert into t_Movimientos (c_tipodoc_mov
		           ,c_coddoc_mov
				   ,c_codigo_pro
				   ,n_movipro_mov
				   ,n_exiant_mov
				   ,n_cantidad_mov
				   ,Id_Bloque)
				  (select c_tipodoc_mov
		           ,c_coddoc_mov
				   ,c_codigo_pro
				   ,n_movipro_mov
				   ,n_exiant_mov
				   ,n_cantidad_mov
				   ,Id_Bloque from t_Movimientos where c_coddoc_mov='-0')
			else
				INSERT INTO dbo.t_Movimientos
		           (c_tipodoc_mov
		           ,c_coddoc_mov
				   ,c_codigo_pro
				   ,n_movipro_mov
				   ,n_exiant_mov
				   ,n_cantidad_mov
				   ,Id_Bloque)
		     	VALUES
		           (@c_tipodoc_mov
		           ,@c_coddoc_mov
				   ,@c_codigo_pro
				   ,@n_movipro_mov
				   ,@n_exiant_mov
				   ,@n_cantidad_mov
				   ,@Id_Bloque)
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
