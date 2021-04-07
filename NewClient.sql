CREATE PROCEDURE NewClient(
@Name varchar(25),
@Email varchar(35),
@Password varchar(15)
)
as

insert into KalendarScopicDB.dbo.User_tbl(Name, Email, Password)
	values(@Name, @Email, @Password)
