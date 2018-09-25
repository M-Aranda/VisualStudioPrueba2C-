CREATE DATABASE registroDeAutomovilesUsadosMAAT
GO

USE registroDeAutomovilesUsadosMAAT
GO

CREATE TABLE ultimoDuenio(
run VARCHAR (20),
nombreCompleto VARCHAR (30),
telefono VARCHAR (30),
PRIMARY KEY (run)
)
GO

CREATE TABLE automovil(
id INT IDENTITY,
patente VARCHAR (20),
marca VARCHAR (20),
anio INT,
detalles VARCHAR (50),
datosUltimoDuenio VARCHAR (20),
FOREIGN KEY (datosUltimoDuenio) REFERENCES ultimoDuenio (run),
PRIMARY KEY (id)
)
GO

INSERT INTO ultimoDuenio VALUES('20898088-2', 'Marcelo Aranda','+958677107')
INSERT INTO ultimoDuenio VALUES('16461541-3', 'Gonzalo Aranda','+958666107')
INSERT INTO ultimoDuenio VALUES('17250967-3', 'María Elena Del Carmen','+958688107')
GO

INSERT INTO automovil VALUES('AAAA-11','Ford',2000,'En buen estado, precio negociable','20898088-2')
INSERT INTO automovil VALUES('BBBB-22','Subaru',2005,'Kilometraje superior a 5000','16461541-3')
INSERT INTO automovil VALUES('CCCC-33','Chevrolet',2010,'Parabrisas roto','17250967-3')
GO



/*
DROP DATABASE registroDeAutomovilesUsadosMAAT
GO
*/