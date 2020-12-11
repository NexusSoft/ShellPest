USE [ShellPest]
GO

/****** Object:  StoredProcedure [dbo].[SP_Productor_Delete]    Script Date: 03/12/2020 01:44:36 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_Productor_Delete')
DROP PROCEDURE SP_Productor_Delete
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Productor_Delete] 
	-- Add the parameters for the stored procedure here
	@Id_Productor int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @correcto bit

	begin transaction T2;
	begin try
		
		delete from dbo.t_Productor where Id_Productor=@Id_Productor

		commit transaction T2;
		set @correcto=1
	end try
	begin catch
		rollback transaction T2;
		set @correcto=0
	end catch

	select @correcto resultado
END



GO

