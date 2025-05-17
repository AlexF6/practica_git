CREATE DATABASE db_aeropuerto;
GO

USE db_aeropuerto;
GO

-- Crear tabla Pilotos
CREATE TABLE Pilotos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Cedula NVARCHAR(100),
    Nombre NVARCHAR(100),
    Pago DECIMAL(18,2)
);

-- Crear tabla Aviones
CREATE TABLE Aviones (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Codigo NVARCHAR(50),
    Modelo NVARCHAR(100),
    FechaCompra DATETIME,
    Piloto INT NOT NULL,
    CONSTRAINT FK_Aviones_Pilotos FOREIGN KEY (Piloto) REFERENCES Pilotos(Id)
);

-- Insertar datos en Pilotos
INSERT INTO Pilotos (Cedula, Nombre, Pago) VALUES 
('10101010', 'Carlos Pérez', 3500.00),
('20202020', 'Ana Torres', 4200.50),
('30303030', 'Luis Gómez', 3900.75);

-- Insertar datos en Aviones
INSERT INTO Aviones (Codigo, Modelo, FechaCompra, Piloto) VALUES 
('AV001', 'Boeing 737', '2020-03-15', 1),
('AV002', 'Airbus A320', '2019-07-22', 1),
('AV003', 'Cessna 172', '2021-05-10', 2),
('AV004', 'Embraer E190', '2022-08-01', 3);
