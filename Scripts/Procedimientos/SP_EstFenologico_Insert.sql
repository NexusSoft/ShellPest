USE [ShellPest]
GO
/****** Object:  StoredProcedure [dbo].[SP_BSC_ClienteGeneral]    Script Date: 25/08/2018 12:40:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_EstFenologico_Insert')
DROP PROCEDURE SP_EstFenologico_Insert
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_EstFenologico_Insert] 
	-- Add the parameters for the stored procedure here
	@Id_Fenologico char(2),
	@Nombre_Fenologico varchar(50),
	@PoE varchar(1)
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
		select @maximo= right(Concat('00',isnull(max(Id_Fenologico),0)+1),2) from dbo.t_Est_Fenologico

		declare @Existe int
		select @Existe = count(Id_Fenologico) from dbo.t_Est_Fenologico a where (a.Id_Fenologico=@Id_Fenologico)

		if @Existe>0 
		
			UPDATE dbo.t_Est_Fenologico
		        SET Nombre_Fenologico=@Nombre_Fenologico,
		        PoE=@PoE
		    WHERE
		    	Id_Fenologico=@Id_Fenologico
				
		else
		
			INSERT INTO dbo.t_Est_Fenologico
	           (Id_Fenologico
	           ,Nombre_Fenologico
	           ,PoE)
	     	VALUES
	           (@maximo
	           ,@Nombre_Fenologico
	           ,@PoE)
		
		commit transaction T1;
		set @correcto=1
	end try
	begin catch
		rollback transaction T1;
		set @correcto=0
	end catch

	select @correcto resultado
END
