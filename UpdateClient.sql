CREATE PROCEDURE UpdateClient(
@Id int,
@Name varchar(25),
@Email varchar(35),
@Password varchar(15)
)
as
Update KalendarScopicDB.dbo.User_tbl
set Name = @Name, Email = @Email, Password = @Password
	where Id = @Id