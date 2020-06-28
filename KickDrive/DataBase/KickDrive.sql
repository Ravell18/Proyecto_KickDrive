create database BDKickDrive
use BDKickDrive
go
create table Vehicles
(
Idvehicles int not null identity,
NProp varchar (35),
Brand varchar (35),
NSerie int,
Model varchar (35),
TipServ varchar (35),
NMotor int,
TComb varchar (35),
DocLeg varchar (35),
TipLlantas varchar (35),
CapPerson int,
CapTon int,
Placas int,
OfExp varchar (35),
NRegist int
constraint PK_Idvehicles primary key (Idvehicles)
)
create table Driver
(
DriverId int not null identity,
DriverName  varchar (35),
INE  varchar (35),
License  varchar (35),
NSS int,
FrontPhoto  varchar (35),
ProfilePhoto varchar (35),
constraint PK_DriverId primary key (DriverId)
)
Create table Routes
(
RoutesId int identity,
Incidents varchar (35),
timeE varchar (35),
timeS varchar (35),
NYES varchar (35),
Adults varchar (35),
DriverId int,
IdVehicles int
constraint PK_RoutesId primary key (RoutesId),
constraint fk_DriverId foreign key (DriverId) references Driver(DriverId),
constraint fk_IdVehicle foreign key (IdVehicles) references Vehicles(IdVehicles)
)

Create table ReportRoute
(
ReportId int,
DriverName varchar (35),
RoutesId int,
Email varchar (35),
Message varchar (35)
constraint PK_ReportId primary key (ReportId),
constraint fk_RoutesId foreign key (RoutesId) references Routes(RoutesId),
)

