Create PROCEDURE UpdateEvent(
		@Id int,
		@Title varchar(25) ,
		@Event_Description varchar(128),
		@Start_Time SmallDateTime,
		@End_Time SmallDateTime,
		@Tag varchar(20),
		@IsGroup char
)
as

update KalendarScopicDB.dbo.Event_tbl
set Title = @Title, Event_Description = @Event_Description, Start_Time = @Start_Time, End_Time = @End_Time, Tag = @Tag, IsGroup = @IsGroup
	where Id = @Id