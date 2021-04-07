Create PROCEDURE DeleteEvent(
		@EventId int

)

as

delete from KalendarScopicDB.dbo.GroupParticipant_tbl where EventId = @EventId

delete from KalendarScopicDB.dbo.Event_tbl 
	where Id = @EventId