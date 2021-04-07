Create database KalendarScopicDB;

Use KalendarScopicDB

	create table User_tbl (
		Id int IDENTITY(1,1) PRIMARY KEY,
		Name varchar(25) not null,
		Email varchar(35) not null,
		Password varchar(15) not null
	);
	create table Event_tbl(
		Id int IDENTITY(1,1) PRIMARY KEY,
		AuthorId nvarchar(450) FOREIGN KEY REFERENCES AspNetUsers(Id) not null,
		Title varchar(25) not null,
		Event_Description varchar(128),
		Start_Time SmallDateTime not null,
		End_Time SmallDateTime not null,
		Tag varchar(20),
		IsGroup char not null
	);
	create table GroupParticipant_tbl(
		Id int IDENTITY(1,1) PRIMARY KEY,
		EventId int FOREIGN KEY REFERENCES Event_tbl(Id) not null,
		UserId nvarchar(450) FOREIGN KEY REFERENCES AspNetUsers(Id) not null,
		ResponseStatus varchar(20) not null
		
		);


;