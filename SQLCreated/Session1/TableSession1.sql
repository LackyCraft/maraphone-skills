create table Position (
	PositionId int primary key not null identity,
	PositionName varchar(50) not null,
	PositionDescription varchar(1000),
	PayPeriod varchar(10) not null,
	Payrate decimal(10,2) not null
)

create table Staff (
	StaffId int primary key not null identity,
	FirstName varchar(80) not null,
	LastName varchar(80) not null,
	Email varchar(100) not null,
	DateOfDBirth datetime not null,
	Gender varchar(10) not null,
	PositionId int not null foreign key references Position(PositionId),
	Comments varchar(2000) 
)

create table Timesheet (
	TimesheetId int not null identity primary key,
	StaffId int not null foreign key references Staff(StaffId),
	StartDateTime datetime,
	EndDateTime datetime,
	PayAmount decimal(10,2)
)

