Create procedure ListGroupEvents(@UserId int)
as
select EventId, ResponseStatus from GroupParticipant_tbl where UserId = @UserId