CREATE TABLE Donantes (
    DonanteID NUMBER PRIMARY KEY,
    Nombre VARCHAR2(100) NOT NULL,
    Correo VARCHAR2(100),
    Telefono VARCHAR2(15)
);

CREATE TABLE Organizaciones (
    OrganizacionID NUMBER PRIMARY KEY,
    Nombre VARCHAR2(100) NOT NULL,
    Correo VARCHAR2(100),
    Telefono VARCHAR2(15)
);

CREATE TABLE Donaciones (
    DonacionID NUMBER PRIMARY KEY,
    DonanteID NUMBER,
    OrganizacionID NUMBER,
    Monto NUMBER(10,2),
    Fecha DATE,
    FOREIGN KEY (DonanteID) REFERENCES Donantes(DonanteID),
    FOREIGN KEY (OrganizacionID) REFERENCES Organizaciones(OrganizacionID)
);

CREATE TABLE Campañas (
    CampañaID NUMBER PRIMARY KEY,
    Nombre VARCHAR2(100) NOT NULL,
    Objetivo NUMBER(10,2),
    FechaInicio DATE,
    FechaFin DATE
);

CREATE SEQUENCE DonantesSeq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE OrganizacionesSeq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE DonacionesSeq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE CampañasSeq START WITH 1 INCREMENT BY 1;