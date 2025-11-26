CREATE DATABASE asistencia_db;

USE asistencia_db;

CREATE TABLE usuarios (
id INT AUTO_INCREMENT PRIMARY KEY,
nombreCompleto VARCHAR(50) NOT NULL,
nombreUsuario VARCHAR(50) NOT NULL,
contrasena VARCHAR(50) NOT NULL
);

CREATE TABLE asistencias (
id INT AUTO_INCREMENT PRIMARY KEY,
nombre VARCHAR(50) NOT NULL,
fecha DATE NOT NULL,
hora_entrada TIME NOT NULL,
hora_salida