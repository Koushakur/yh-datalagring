-- alter procedure ProcedureName -- När man redan skapat proceduren och vill uppdatera den
create procedure ProcedureName
	@ArticleNumber nvarchar(256),
	@Variablenameghkl nvarchar(256) output
as
begin 
	select @Variablenameghkl = [Name] from Products where ArticleNumber = @ArticleNumber

	if @Variablenameghkl is null
		print 'Didnt find it'
end


declare @VariableName nvarchar(400) set @VariableName = 'Yo'

/* Debug message of sorts? */
select 'asda ' + @VariableName + ' asd' as columnNameHere
print @VariableName

begin try
	begin transaction
		if exists (select 1 from Products where ArticleNumber = @VariableName)
			delete _;
	commit transaction
end try

begin catch
	rollback transaction
end catch

