CREATE DATABASE [Examen-PlenarioSistemas];
GO
USE [Examen-PlenarioSistemas];
-- EJERCICIOS DE DDL
-- Crear base de datos
CREATE TABLE Personas
(PersonaID INT IDENTITY NOT NULL,
Nombre varchar(50) NOT NULL,
FechaNacimiento datetime NOT NULL,
CreditoMaximo numeric(20,2)NOT NULL,
PRIMARY KEY (PersonaID));

CREATE TABLE Telefonos
(TelefonoID INT IDENTITY NOT NULL,
PersonaID INT NOT NULL,
Telefono varchar(50) NOT NULL,
PRIMARY KEY(TelefonoID),
foreign key(PersonaID) REFERENCES Personas(PersonaID));
