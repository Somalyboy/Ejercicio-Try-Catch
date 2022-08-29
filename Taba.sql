CREATE TABLE persona(
	ci int primary key,
	nombre varchar(255) NOT NULL,
	apellido varchar(255) NOT NULL,
	telefono int NOT NULL,
	email varchar(255) NULL UNIQUE
);

