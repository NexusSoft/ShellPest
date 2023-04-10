USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_RiegoV2_Insert')
DROP PROCEDURE SP_RiegoV2_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_RiegoV2_Insert] 
	-- Add the parameters for the stored procedure here
	@Fecha	datetime,
	@Hora	time(7),
	@Id_Bloque	char(4),
	@Precipitacion_Sistema	numeric(18, 4),
	@Caudal_Inicio	decimal(18, 4),
	@Caudal_Fin	decimal(18, 4),
	@Horas_riego	decimal(18, 4),
	@Id_Usuario_Crea	varchar(10),
	@c_codigo_eps	char(2),
	@Temperatura	numeric(15,1),
	@ET	numeric(15,1),
	@F_UsuCrea datetime,
	@Hora_Fin time(7),
	@F_Envio datetime,
	@Id_Cambio int
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
		select @Existe = count(Id_Bloque) from dbo.t_Riego a where (a.Fecha=@Fecha and a.Hora=@Hora and a.Id_Bloque=@Id_Bloque)

		if @Existe>0
			update dbo.t_Riego 
			set Hora_Fin=@Hora_Fin,ET=@ET, Temperatura=@Temperatura, Caudal_Fin=@Caudal_Fin,Caudal_Inicio=@Caudal_Inicio,Precipitacion_Sistema=@Precipitacion_Sistema
			where Id_Bloque=@Id_Bloque and Fecha=@Fecha and Hora=@Hora
		else
			INSERT INTO dbo.t_Riego
		           (Id_Bloque,
				   Fecha,
				   Hora,
				   Hora_Fin,
				   Precipitacion_Sistema,
				   Caudal_Inicio,
				   Caudal_Fin,
				   Id_Usuario_Crea,
				   F_Usuario_Crea,
				   c_codigo_eps,
				   Temperatura,
				   ET,
				   F_Envio)	
		     	VALUES
		           (@Id_Bloque,
				   @Fecha,
				   @Hora,
				   @Hora_Fin,
				   @Precipitacion_Sistema,
				   @Caudal_Inicio,
				   @Caudal_Fin,
				   @Id_Usuario_Crea,
				   GETDATE(),
				   @c_codigo_eps,
				   @Temperatura,
				   @ET,
				   @F_Envio)
			
		delete from t_Riego_Valvulas where Id_Bloque=@Id_Bloque and Fecha=@Fecha and Hora=@Hora 

		insert into t_Riego_Valvulas (Id_Bloque
			  ,Fecha
			  ,Hora
			  ,Id_Valvula) 
		 (select @Id_Bloque,
				   @Fecha,
				   @Hora, V.Id_Valvula 
			from t_Valvulas as V 
			inner join t_Cambio_Riego_Det as CRD on CRD.Id_Bloque=V.Id_Bloque and CRD.Id_Valvula=V.Id_Valvula  where CRD.Id_Bloque=@Id_Bloque and Id_Cambio=@Id_Cambio)
			   
			
	
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
