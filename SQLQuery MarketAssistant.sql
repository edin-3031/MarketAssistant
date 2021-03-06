USE master
GO

CREATE DATABASE MarketAssistant
GO

USE MarketAssistant
GO

CREATE TABLE Administrator(
AdministratorID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Ime NVARCHAR(MAX) NULL,
Prezime NVARCHAR(MAX) NULL,
Mail NVARCHAR(100) NULL UNIQUE,
Telefon NVARCHAR(100) NULL UNIQUE,
Adresa NVARCHAR(MAX) NULL,
DatumRodjenja Datetime NULL,
DatumZaposlenja Datetime NULL,
Staz INT NULL,
Spol bit NULL,
Slika VARBINARY(MAX) NULL
);
GO

CREATE TABLE KorisnickiRacun(
KorisnickiRacunID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
KorisnickoIme NVARCHAR(MAX) NULL,
SifraSalt NVARCHAR(MAX) NULL,
SifraHash NVARCHAR(MAX) NULL,
Aktivan bit NULL,
AdminID_FK INT FOREIGN KEY REFERENCES Administrator(AdministratorID) NULL
);
GO

CREATE TABLE Brend(
BrendID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Naziv NVARCHAR(100) NULL UNIQUE
);
GO

CREATE TABLE Vrsta(
VrstaID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Naziv NVARCHAR(100) NULL UNIQUE
);
GO

CREATE TABLE Proizvod(
ProizvodID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Naziv NVARCHAR(MAX) NULL,
DatumProizvodnje Datetime NULL,
TrajeDo Datetime NULL,
Sastav NVARCHAR(MAX) NULL,
Opis NVARCHAR(MAX) NULL,
Slika VARBINARY(MAX) NULL,
BrendID_FK INT FOREIGN KEY REFERENCES Brend(BrendID) NULL,
VrstaID_FK INT FOREIGN KEY REFERENCES Vrsta(VrstaID) NULL,
AdminID_FK INT FOREIGN KEY REFERENCES Administrator(AdministratorID) NULL,
);
GO

CREATE TABLE Market(
MarketID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Naziv NVARCHAR(MAX) NULL,
Adresa NVARCHAR(MAX) NULL,
AdminID_FK INT FOREIGN KEY REFERENCES Administrator(AdministratorID) NULL
);
GO

CREATE TABLE QR_Code(
QR_CodeID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Slika VARBINARY(MAX) NULL,
MarketID_FK INT FOREIGN KEY REFERENCES Market(MarketID) NULL
);
GO

CREATE TABLE Sema(
SemaID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Sema NVARCHAR(MAX) NULL,
MarketID_FK INT FOREIGN KEY REFERENCES Market(MarketID) NULL
);
GO

CREATE TABLE market_proizvod(
mpID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
MarketID_FK INT FOREIGN KEY REFERENCES Market(MarketID) NULL,
ProizvodID_FK INT FOREIGN KEY REFERENCES Proizvod(ProizvodID) NULL,
NaStanju INT NULL,
DatumDobavljanja Datetime NULL,
Rasprodano bit NULL
);
GO