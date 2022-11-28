USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_WS_Control_Revision_Insert')
DROP PROCEDURE SP_WS_Control_Revision_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_WS_Control_Revision_Insert] 
	-- Add the parameters for the stored procedure here
	@Fecha date,
	@Id_Bloque char(4),
	@Fruta bit,
	@Floracion bit,
	@N_Arboles numeric(10,2),
	@Observaciones varchar(60),
	@Nivel_Humedad numeric(10,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto char(10)

	begin transaction T1;
	begin try


					   
			declare @Existe int
			select @Existe = count(Id_Bloque) from dbo.t_Revision a where (a.Fecha=@Fecha and a.Id_Bloque=@Id_Bloque)

			if @Existe>0 
				UPDATE dbo.t_Revision set Fruta=@Fruta, 
					Floracion=@Floracion, 
					N_Arboles=@N_Arboles,
					Observaciones=@Observaciones,
					Nivel_Humedad=@Nivel_Humedad
				where Fecha=@Fecha and Id_Bloque=@Id_Bloque
			else
				INSERT INTO dbo.t_Revision
		           (Fecha
		           ,Id_Bloque
		           ,Fruta
				   ,Floracion
				   ,N_Arboles
				   ,Observaciones
	           	   ,Nivel_Humedad)
		     	VALUES
		           (@Fecha
		           ,@Id_Bloque
		           ,@Fruta
				   ,@Floracion
				   ,@N_Arboles
				   ,@Observaciones
	           	   ,@Nivel_Humedad)
			
			
			commit transaction T1;
			set @correcto=1
		end try
		begin catch
			rollback transaction T1;
			set @correcto=0
		end catch

		select @correcto resultado
END
