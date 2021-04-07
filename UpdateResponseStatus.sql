Create procedure UpdateResponseStatus(@UserId int, @ResponseStatus varchar(20))
as
update GroupParticipant_tbl
set ResponseStatus = @ResponseStatus
 where UserId = @UserId