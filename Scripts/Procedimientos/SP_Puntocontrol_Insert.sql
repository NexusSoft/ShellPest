USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Puntocontrol_Insert')
DROP PROCEDURE SP_Puntocontrol_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Puntocontrol_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Puntocontrol char(4),
	@Nombre_Puntocontrol varchar(50),
	@Id_Bloque char(4),
	@n_coordenadaX numeric(18,4),
	@n_coordenadaY numeric(18,4),
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
		select @maximo= right(Concat('0000',isnull(max(Id_Puntocontrol),0)+1),4) from dbo.t_Puntocontrol

		declare @Existe int
		select @Existe = count(Id_Puntocontrol) from dbo.t_Puntocontrol a where (a.Id_Puntocontrol=@Id_Puntocontrol)

		if @Existe>0 
		
			UPDATE dbo.t_Puntocontrol
		        SET Nombre_Puntocontrol=@Nombre_Puntocontrol,
		        Id_Bloque=@Id_Bloque,
		        n_coordenadaX=@n_coordenadaX,
		        n_coordenadaY=@n_coordenadaY,
		        Id_Usuario_Mod=@Id_Usuario,
		        F_Usuario_Mod=getdate()
		    WHERE
		    	Id_Puntocontrol=@Id_Puntocontrol
				
		else
		
			INSERT INTO dbo.t_Puntocontrol
	           (Id_Puntocontrol
	           ,Nombre_Puntocontrol
	           ,Id_Bloque
	           ,n_coordenadaX
	           ,n_coordenadaY
	           ,Id_Usuario_Crea
	           ,F_Usuario_Crea)
	     	VALUES
	           (@maximo
	           ,@Nombre_Puntocontrol
	           ,@Id_Bloque
	           ,@n_coordenadaX
	           ,@n_coordenadaY
	           ,@Id_Usuario
	           ,getdate())
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
