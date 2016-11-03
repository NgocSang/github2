Create database github2
Go
Use github2
go

create table account(
	username char(10),
	password char(30),
	primary key (username)

)

create table product(
	ID int,
	name nvarchar(30),
	price decimal,
	origin nvarchar(30),
	quantity int,
	primary key(ID)
)
create table report(
	ID int,
	mastercard char(10),
	Ammountmastercard int,
	debitcard  char(10),
	Ammountdebitcard int,
	date_transation date,
	primary key(ID)
)

create proc Sp_Account_Signup
	@username char(10),
	@password char(30)
as
begin	
	declare @count int
	declare @res bit
	select @count = count(*) from account where @username = username
	if @count = 0
		begin
			set @res = 1
			insert into account values (@username,@password)
		end
	else
		set @res = 0

	select @res
end

select * from account
