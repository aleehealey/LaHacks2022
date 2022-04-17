Use LaHacks

drop table if exists [UserEvent]
Create Table [UserEvent]
(
	[Id] bigint not null primary key Identity(1,1),
   [UserId] bigint not null foreign key references [User]([Id]) ,
   [StartTime] Datetime not null  ,
   [Duration] int not null  ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)