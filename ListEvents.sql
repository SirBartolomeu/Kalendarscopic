Create Procedure ListEvents(
@AuthorId int)

as

select Id,
		Title, 
		Event_Description, 
		Start_Time, 
		End_Time, 
		Tag, 
		IsGroup
from KalendarScopicDB.dbo.Event_tbl where AuthorId = @AuthorId

