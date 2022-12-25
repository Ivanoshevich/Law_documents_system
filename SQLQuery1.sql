CREATE TABLE [dbo].[remains_TEZ]
(
	[Idremains_TEZ] INT NOT NULL PRIMARY KEY,
	[Quantity] NVARCHAR(45) NOT NULL ,
	[idType TEZ] INT NOT NULL 
)
CREATE TABLE [dbo].[TEZ_transfer]
(
	[idTEZ_transfer] INT NOT NULL PRIMARY KEY,
	[transfer_date] DATE NOT NULL,
	[idRepair_center] INT NOT NULL,
	[Price] NVARCHAR(45) NOT NULL,
	[Degree_of_breakdown] NVARCHAR(45),
	[idType TEZ] INT NOT NULL,
)
CREATE TABLE [dbo].[Acceptance]
(
	[idOperation] INT NOT NULL PRIMARY KEY,
	[Date_of_Supplier] NVARCHAR(45) NOT NULL,	
	[Quantity] NVARCHAR(45) NOT NULL,	
	[TTN] NVARCHAR(45) NOT NULL,
	[idType TEZ] INT NOT NULL,
	[IdSuppliers] INT NOT NULL,

)
CREATE TABLE [dbo].[ATC]
(
	[IdATC] INT NOT NULL PRIMARY KEY,
	[Number of ATC] NVARCHAR(45) NOT NULL,
	[Location of ATC] NVARCHAR(45) NOT NULL,
)
CREATE TABLE [dbo].[Type TEZ]
(
	[idType TEZ] INT NOT NULL PRIMARY KEY,
	[Designation] NVARCHAR(45) NOT NULL,
    [Factory number of TEZ] NVARCHAR(45) NULL,
	[IdATC] INT NULL,
	[idRepair_center] INT NULL,
)
CREATE TABLE [dbo].[Repair_center]
(
	[idRepair_center] INT NOT NULL PRIMARY KEY,
	[Designation] NVARCHAR(45) NOT NULL 
)



