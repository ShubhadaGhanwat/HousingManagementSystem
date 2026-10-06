
----------- Database -------

CREATE DATABASE SPHMSDb;
USE SPHMSDb

------- 1. Society-------

Create table Societies(
SocietyId INT IDENTITY PRIMARY KEY,
SocietyName NVARCHAR(40) NOT NULL,
EstablishedDate DATETIME NULL,
DevelopedBy NVARCHAR(30) NULL,
Address NVARCHAR(100) NOT NULL,
City VARCHAR(20) NOT NULL,
State VARCHAR(30) NOT NULL,
Pincode VARCHAR(10) NULL,
Phone VARCHAR(20) NOT NULL,  
Email VARCHAR(50) NOT NULL ,
Logo VARCHAR(30) NULL,
Description VARCHAR(100) NULL ,
Flag int default 0,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

------------2 . Wings -----------

CREATE TABLE Wings(
WingId INT IDENTITY PRIMARY KEY,
WingName VARCHAR(10) NOT NULL,
WingCode VARCHAR(10) NOT NULL,
NumberOfFloors int NOT NULL,
Flag int default 0,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

---------- 3. Flats------------

CREATE TABLE Flats(
FlatId INT IDENTITY PRIMARY KEY,
WingId INT CONSTRAINT FKFlatid REFERENCES Wings(WingId) NOT NULL,
FlatNumber VARCHAR(20) NOT NULL,
FloorNumber INT NOT NULL,
FlatType VARCHAR(20),
AreaSqft VARCHAR(90),
Flag int default 0,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

----------- 4. Residents----------


CREATE TABLE Residents(
ResidentId INT IDENTITY PRIMARY KEY,
Id nvarchar(450) Constraint FkId REFERENCES  AspNetUsers(Id) NOT NULL,
FullName VARCHAR(30) NOT NULL,
Gender VARCHAR(10),
Age VARCHAR(10),
BirthDate Date,
PhoneNumber VARCHAR(20) NOT NULL,
EmailAddress VARCHAR(40) NOT NULL,
NumberOfMembers INT NOT NULL ,
ProfilePhoto NVARCHAR(100) NULL,
FlatId int CONSTRAINT FKResidentFlatid REFERENCES Flats(FlatId) NOT NULL,
WingId INT CONSTRAINT FKwingid REFERENCES Wings(WingId) NOT NULL,
ResidentType VARCHAR(80),
MoveInDate DATETIME NOT NULL,
MoveOutDate DATETIME NULL,
IsPrimaryResident BIT NOT NULL DEFAULT 0 ,
Flag int default 0,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

-----------5. Commitees--------

CREATE TABLE Commitees(
CommiteeId INT IDENTITY PRIMARY KEY,
Position VARCHAR(80) NOT NULL ,
Description NVARCHAR(80) NULL,
Flag int default 0 NOT NULL,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

------------6. CommiteeMembers---------

CREATE TABLE CommiteeMembers(
CommiteeMemberId INT IDENTITY PRIMARY KEY,
CommiteeId INT CONSTRAINT FKcommiteeid REFERENCES Commitees(CommiteeId)NOT NULL,
Id nvarchar(450) Constraint FkUserId REFERENCES  AspNetUsers(Id) NOT NULL,
StartDate DATETIME NOT NULL,
EndDate DATETIME NULL,
WorkingPeriod VARCHAR(90) NULL,
HightligtedWork VARCHAR(200) NULL,
Flag int default 0 NOT NULL,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

--------7.MaintainanceBills------------

CREATE TABLE MaintainanceBills(
MaintainanceId INT IDENTITY PRIMARY KEY,
Id nvarchar(450) Constraint FkaspuserId REFERENCES  AspNetUsers(Id) NOT NULL,
FlatId int CONSTRAINT FKmaintainanceFlatid REFERENCES Flats(FlatId) NOT NULL,
WingId INT CONSTRAINT FKmaintainancewingid REFERENCES Wings(WingId) NOT NULL,
BillDate DATE,
GeneratedAT DATETIME,
WaterCharges DECIMAL(18,2),
ParkingCharges DECIMAL(18,2) ,
OtherCharges DECIMAL(18,2),
DUEDATE DATE,
MaintainanceAmount DECIMAL(18,2),
PaidAmount DECIMAL(18,2),
UnpaidAmount DECIMAL(18,2),
TotalAmount DECIMAL(18,2),
Discount VARCHAR(20),
Penalty DECIMAL(18,2),
PayementStatus VARCHAR(20),
PaymentMode VARCHAR(20),
PayementDate DATETIME,
TransactionReference VARCHAR(100),
Flag int default 0 NOT NULL,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

--------------8.Complaint Categories----------

CREATE TABLE ComplaintCategories(
ComplaintCategoryId INT IDENTITY PRIMARY KEY,
Title VARCHAR(30) NOT NULL,
Description VARCHAR(200) NULL,
Flag int default 0 NOT NULL,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

------------9.Complaints----------

CREATE TABLE Complaints(
ComplaintId INT IDENTITY PRIMARY KEY,
ComplaintCategoryId INT CONSTRAINT FKComplainid REFERENCES ComplaintCategories(ComplaintCategoryId) NOT NULL,
Id nvarchar(450) Constraint FkComplaintuserId REFERENCES  AspNetUsers(Id) NOT NULL,
Title VARCHAR(30),
Description VARCHAR(100),
Priority VARCHAR(30),
ComplaintStatus VARCHAR(20),
Remarks VARCHAR(70),
Flag int default 0 NOT NULL,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

----------10. Notices------

CREATE TABLE Notices(
NoticeId INT IDENTITY PRIMARY KEY,
Title VARCHAR(30) NOT NULL,
Description  NVARCHAR(400) NOT NULL,
PublishDate DATETIME NOT NULL,
ExpiryDate DATETIME NULL,
Attachement NVARCHAR(200) NULL,
FeaturedImage NVARCHAR(300) NULL,
Flag int default 0  ,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

----------11.Events----

CREATE TABLE Events(
EventId INT IDENTITY PRIMARY KEY,
EventTitle VARCHAR(20),
Description NVARCHAR(400),
EventDate DATETIME,
StartTime DATETIME,
EndTime DATETIME,
Location VARCHAR(100),
Flag int default 0  ,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

---------12.Event Images table-------

CREATE TABLE EventImages(
EventImageId INT IDENTITY PRIMARY KEY,
EventId INT CONSTRAINT FKeventid REFERENCES Events(EventId) NOT NULL,
ImagePath VARCHAR(500) NOT NULL,
ImageTitle VARCHAR(200) NULL,
DisplayOrder INT NOT NULL DEFAULT 1,
Flag int default 0  ,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
); 

----------13.Facilities----------

CREATE TABLE Facilities(
FacilityId INT IDENTITY PRIMARY KEY,
FacilityName VARCHAR(50) NOT NULL,
Description VARCHAR(70) NULL,
Flag int default 0 ,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

------------14 FacilitiesImages-----

CREATE TABLE FacilityImages(
FacilityImageId INT IDENTITY PRIMARY KEY,
FacilityId INT CONSTRAINT FKfacilityid REFERENCES Facilities(FacilityId ),
Title VARCHAR(100),
FacilityImage VARCHAR(800),
DisplayOrder INT NOT NULL DEFAULT 1,
Flag int default 0  ,
CreatedAt DATETIME NOT NULL,
UpdatedAt DATETIME NULL,
DeletedAt DATETIME NULL,
RestoredAt DATETIME NULL
);

-------------15. Visitors-----------

CREATE TABLE Visitors(
VistorId INT IDENTITY PRIMARY KEY,

FullName VARCHAR(50),
PhoneNumber VARCHAR(12),
VehicleNumber VARCHAR(12),
VistorType VARCHAR(20),
Purpose VARCHAR(40),
EntryTime DATETIME,
ExitTime DATETIME,
Remarks VARCHAR(30),
);
