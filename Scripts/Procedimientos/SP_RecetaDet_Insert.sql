USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_RecetaDet_Insert')
DROP PROCEDURE SP_RecetaDet_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_RecetaDet_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Receta char(7),
	@Secuencia int,
	@c_codigo_pro char(15),
	@v_nombre_pro varchar(100),
	@c_codigo_cac char(3),
    @v_nombre_cac varchar(50),
    @c_codigo_uni char(2),
    @Dosis numeric(18,2),
    @Cantidad_Unitaria numeric(18,2),
    @Descripcion varchar(150),
	@Id_Usuario varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T1;
	begin try


			declare @maximo int
			select @maximo= isnull(max(Id_Receta),0)+1 from dbo.t_RecetaDet where Id_Receta=@Id_Receta

			declare @Existe int
			select @Existe = count(Id_Receta) from dbo.t_RecetaDet a where (a.Id_Receta=@Id_Receta and Secuencia=@Secuencia)

			if @Existe>0 
			
				UPDATE dbo.t_RecetaDet
			        SET c_codigo_pro=@c_codigo_pro,
					v_nombre_pro=@v_nombre_pro,
                     c_codigo_cac=@c_codigo_cac,
                    v_nombre_cac=@v_nombre_cac,
                    c_codigo_uni=@c_codigo_uni,
                    Dosis=@Dosis,
                    Cantidad_Unitaria=@Cantidad_Unitaria,
                    Descripcion=@Descripcion,
			        Id_Usuario_Mod=@Id_Usuario,
		       		F_Usuario_Mod=getdate()
			    WHERE
			    	Id_Receta=@Id_Receta
					
			else
			
				INSERT INTO dbo.t_RecetaDet
		           (Id_Receta,
		           Secuencia,
				   c_codigo_pro,
                    v_nombre_pro,
                    c_codigo_cac,
                    v_nombre_cac,
                    c_codigo_uni,
                    Dosis,
                    Cantidad_Unitaria,
                    Descripcion
		           ,Id_Usuario_Crea
	           		,F_Usuario_Crea
				)
		     	VALUES
		           (@Id_Receta
		           ,@maximo
				   ,@c_codigo_pro
                    ,@v_nombre_pro
                    ,@c_codigo_cac
                    ,@v_nombre_cac
                    ,@c_codigo_uni
                    ,@Dosis
                    ,@Cantidad_Unitaria
                    ,@Descripcion
		           ,@Id_Usuario
	           		,getdate()
					)
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
