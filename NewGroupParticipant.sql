Create procedure NewGroupParticipant(@Name varchar(25), @EventId int)
as
Declare @UserId int;

set @UserId = (


 select u.Id from KalendarScopicDB.dbo.User_tbl u where u.Name = @Name)

insert into KalendarScopicDB.dbo.GroupParticipant_tbl(UserId, EventId, ResponseStatus)
values(@UserId, @EventId, 'Pending')