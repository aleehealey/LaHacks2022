Use LaHacks

drop table if exists [Event]
Create Table [Event]
(
	[Id] bigint not null primary key Identity(1,1),
   [GroupId] bigint not null foreign key references [Group]([Id]) ,
   [ActivityId] bigint not null foreign key references [Activity]([Id]) ,
   [StartTime] Datetime not null  ,
   [Duration] int not null  ,
   [EventGoogleId] bigint not null  ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)