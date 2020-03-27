create procedure aspPacientes2

	@Nome as varchar(100),
	@CPF as varchar(11),
	@Datas as varchar(8),
	@Pescricao as varchar(10)

as
begin

	insert into tblPacientes
	(Nome, CPF, Datas, Pescricao)
	values
	(@Nome, @CPF, @Datas, @Pescricao)

	select @@IDENTITY as retorno

end