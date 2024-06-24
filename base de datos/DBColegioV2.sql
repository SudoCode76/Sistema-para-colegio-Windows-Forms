-- Crear la base de datos
CREATE DATABASE SistemaColegio;

-- Usar la base de datos creada
USE SistemaColegio;




-- Crear la tabla Usuarios
CREATE TABLE Usuarios (
    nombreUsuario NVARCHAR(20) PRIMARY KEY,
    contrasena NVARCHAR(20) NOT NULL,
    nombre NVARCHAR(50) NOT NULL,
    apellidoPaterno NVARCHAR(50) NOT NULL,
    apellidoMaterno NVARCHAR(50) NOT NULL,
    tipoUsuario NVARCHAR(50) NOT NULL,
    
);
INSERT INTO Usuarios VALUES('admin','admin','nombreAdmin','appPatAdmin','appMatAdmin','Administrador')
SELECT * FROM Usuarios;


-- Crear la tabla Estudiantes
CREATE TABLE Estudiantes (
    idEstudiante INT IDENTITY(1,1) PRIMARY KEY,
    CI NVARCHAR(20) NOT NULL,
    nombreCompleto NVARCHAR(100) NOT NULL,
    genero NVARCHAR(10) NOT NULL,
    fechaNacimiento DATE NOT NULL,
    nacionalidad NVARCHAR(50),
    direccion NVARCHAR(200),
    tutor NVARCHAR(100),
    estado NVARCHAR(20) -- ACTI-DESACT
);
INSERT INTO Estudiantes (CI, nombreCompleto, genero, fechaNacimiento, nacionalidad, direccion, tutor, estado)
VALUES 
('12345678', 'Juan Perez', 'Masculino', '2005-05-15', 'Boliviana', 'Calle Falsa 123', 'Pedro Perez', 'ACTIVO'),
('87654321', 'Maria Garcia', 'Femenino', '2006-07-22', 'Boliviana', 'Avenida Siempre Viva 456', 'Ana Garcia', 'ACTIVO');
SELECT * FROM Estudiantes;



-- Crear la tabla Cursos
CREATE TABLE Cursos (
    idCurso INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    nivel NVARCHAR(50),
    estado NVARCHAR(20)
);
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Primero de Primaria', 'Primaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Segundo de Primaria', 'Primaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Tercero de Primaria', 'Primaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Cuarto de Primaria', 'Primaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Quinto de Primaria', 'Primaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Sexto de Primaria', 'Primaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Primero de Secundaria', 'Secundaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Segundo de Secundaria', 'Secundaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Tercero de Secundaria', 'Secundaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Cuarto de Secundaria', 'Secundaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Quinto de Secundaria', 'Secundaria', 'Activo');
INSERT INTO Cursos (nombre, nivel, estado) VALUES ('Sexto de Secundaria', 'Secundaria', 'Activo');
SELECT * FROM Cursos;



-- Crear la tabla Materia
CREATE TABLE Materia (
    idMateria INT IDENTITY(1,1) PRIMARY KEY,
    nombreMateria NVARCHAR(100) NOT NULL,
    gestion NVARCHAR(50)
);
INSERT INTO Materia (nombreMateria, gestion) VALUES ('Matemáticas', '2024');
INSERT INTO Materia (nombreMateria, gestion) VALUES ('Ciencias', '2024');
INSERT INTO Materia (nombreMateria, gestion) VALUES ('Historia', '2024');
INSERT INTO Materia (nombreMateria, gestion) VALUES ('Geografía', '2024');
INSERT INTO Materia (nombreMateria, gestion) VALUES ('Lenguaje', '2024');
INSERT INTO Materia (nombreMateria, gestion) VALUES ('Física', '2024');
INSERT INTO Materia (nombreMateria, gestion) VALUES ('Química', '2024');
INSERT INTO Materia (nombreMateria, gestion) VALUES ('Educación Física', '2024');
SELECT * FROM Materia;
-- Crear la tabla Grupos
CREATE TABLE Grupos (
    idGrupo INT IDENTITY(1,1) PRIMARY KEY,
    nombreGrupo NVARCHAR(100) NOT NULL
);

-- Crear la tabla DetalleEstudiante
CREATE TABLE DetalleEstudiante (
    idDetalle INT IDENTITY(1,1) PRIMARY KEY,
    idEstudiante INT,
    ultimoCursoCursado NVARCHAR(50),
    nombreColegiosAnteriores NVARCHAR(200),
    observaciones NVARCHAR(200),
    FOREIGN KEY (idEstudiante) REFERENCES Estudiantes(idEstudiante)
);

-- Crear la tabla Inscripcion
CREATE TABLE Inscripcion (
    idInscripcion INT IDENTITY(1,1) PRIMARY KEY,
    idEstudiante INT,
    idCurso INT,
    fechaInscripcion DATE,
    observacion NVARCHAR(200),
    detalleMedico NVARCHAR(200),
    educacionAnterior NVARCHAR(200),
    FOREIGN KEY (idEstudiante) REFERENCES Estudiantes(idEstudiante),
    FOREIGN KEY (idCurso) REFERENCES Cursos(idCurso)
);
SELECT * FROM Inscripcion;

-- Crear la tabla Mensualidades Estudiantes
CREATE TABLE Mensualidades (
    idMensualidad INT IDENTITY(1,1) PRIMARY KEY,
    idEstudiante INT,
    monto DECIMAL(10, 2),
    observacion NVARCHAR(200),
    estado NVARCHAR(20),
    fechaPago DATE,
    totalPago DECIMAL(10, 2),
    FOREIGN KEY (idEstudiante) REFERENCES Estudiantes(idEstudiante)
);
SELECT * FROM Mensualidades;

-- Crear la tabla Notas
CREATE TABLE Notas (
    idNota INT IDENTITY(1,1) PRIMARY KEY,
    idEstudiante INT,
    idMateria INT,
    primerTrimestre DECIMAL(5, 2),
    segundoTrimestre DECIMAL(5, 2),
    tercerTrimestre DECIMAL(5, 2),
    FOREIGN KEY (idEstudiante) REFERENCES Estudiantes(idEstudiante),
    FOREIGN KEY (idMateria) REFERENCES Materia(idMateria)
);

INSERT INTO Notas (idEstudiante, idMateria, primerTrimestre, segundoTrimestre, tercerTrimestre)
VALUES 
((SELECT idEstudiante FROM Estudiantes WHERE CI = '12345678'), 
 (SELECT idMateria FROM Materia WHERE nombreMateria = 'Matemáticas'), 
 85.5, 90.0, 88.0),
 
((SELECT idEstudiante FROM Estudiantes WHERE CI = '12345678'), 
 (SELECT idMateria FROM Materia WHERE nombreMateria = 'Ciencias'), 
 80.0, 85.0, 87.0),

((SELECT idEstudiante FROM Estudiantes WHERE CI = '87654321'), 
 (SELECT idMateria FROM Materia WHERE nombreMateria = 'Historia'), 
 78.0, 82.5, 80.0),

((SELECT idEstudiante FROM Estudiantes WHERE CI = '87654321'), 
 (SELECT idMateria FROM Materia WHERE nombreMateria = 'Matemáticas'), 
 90.0, 92.5, 95.0);


SELECT * FROM Notas;

-- Crear la tabla Padres
CREATE TABLE Padres (
    idPadre INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    direccion NVARCHAR(200),
    telefono NVARCHAR(20),
    parentesco NVARCHAR(50),
    estado NVARCHAR(20),
    idEstudiante INT,
    FOREIGN KEY (idEstudiante) REFERENCES Estudiantes(idEstudiante)
);







-- Crear la tabla GestionEscolar
CREATE TABLE GestionEscolar (
    idGestion INT IDENTITY(1,1) PRIMARY KEY,
    anioEscolar NVARCHAR(50)
);

-- Crear la tabla Administradores
CREATE TABLE Administradores (
    idAdministrador INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100);
    cargo NVARCHAR(100)
);

SELECT * FROM Administradores;
DELETE FROM Administradores;

-- Crear la tabla RegistroAdministradores
CREATE TABLE RegistroAdministradores (
    idRegistro INT IDENTITY(1,1) PRIMARY KEY,
    idAdministrador INT,
    fechaRegistro DATE,
    FOREIGN KEY (idAdministrador) REFERENCES Administradores(idAdministrador)
);

-- Añadir columna 'apellido' a la tabla 'Administradores'
ALTER TABLE Administradores
ADD apellido NVARCHAR(100);

-- Crear tabla 'Cargos'
CREATE TABLE Cargos (
    idCargo INT IDENTITY(1,1) PRIMARY KEY,
    nombreCargo NVARCHAR(100) NOT NULL
);

-- Insertar cargos predefinidos
INSERT INTO Cargos (nombreCargo) VALUES ('Director');
INSERT INTO Cargos (nombreCargo) VALUES ('Secretario');
INSERT INTO Cargos (nombreCargo) VALUES ('Coordinador');

