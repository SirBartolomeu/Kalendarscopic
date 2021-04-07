CREATE PROCEDURE NewEvent(
		@AuthorId int,
		@Title varchar(25) ,
		@Event_Description varchar(128),
		@Start_Time SmallDateTime,
		@End_Time SmallDateTime,
		@Tag varchar(20),
		@IsGroup char
)
as

insert into KalendarScopicDB.dbo.Event_tbl(AuthorId, Title, Event_Description, Start_Time, End_Time, Tag, IsGroup)
	values(@AuthorId, @Title, @Event_Description, @Start_Time, @End_Time, @Tag, @IsGroup)