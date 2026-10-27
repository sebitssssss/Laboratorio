CREATE DATABASE IF NOT EXISTS testdb;
USE testdb;

CREATE TABLE IF NOT EXISTS productos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    stock INT NOT NULL
);

INSERT INTO productos (nombre, precio, stock) VALUES
('Teclado', 25000.00, 10),
('Mouse', 12000.50, 25),
('Monitor', 180000.00, 5);
