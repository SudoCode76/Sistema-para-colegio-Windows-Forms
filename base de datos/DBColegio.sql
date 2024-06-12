CREATE DATABASE SistemaColegio;

USE SistemaColegio;


DROP DATABASE [SistemaColegio];

CREATE TABLE Usuarios(
	nombreUsuario NVARCHAR(20) PRIMARY KEY NOt NULL,
	contrasena NVARCHAR(20) NOT NULL,
	nombre NVARCHAR(50)  NOT NULL,
	apellidoPaterno NVARCHAR(50) NOT NULL,
	apellidoMaterno NVARCHAR(50) NOT NULL,
	tipoUsuario NVARCHAR(50) NOT NULL,
);
GO
INSERT INTO Usuarios VALUES('admin','admin','nombreAdmin','appPatAdmin','appMatAdmin','Administrador')
INSERT INTO Usuarios VALUES('profesor','profesor','nombreprofesor','appPatprofesor','appMatprofesor','Profesor')

SELECT * FROM Usuarios;





-- Permiso
CREATE TABLE Permiso (
    IdPermiso INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50)
);

-- Cargo
CREATE TABLE Cargo (
    IdCargo INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL
);

-- Grupo
CREATE TABLE Grupo (
    IdGrupo INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50)
);

-- Usuarios








-- Privilegio
CREATE TABLE Privilegio (
    IdPrivilegio INT IDENTITY(1,1) PRIMARY KEY,
    IdPermiso INT,
    IdGrupo INT,
    Nombre NVARCHAR(50),
    FOREIGN KEY (IdPermiso) REFERENCES Permiso(IdPermiso),
    FOREIGN KEY (IdGrupo) REFERENCES Grupo(IdGrupo)
);

-- Estudiante
CREATE TABLE Estudiante (
    IdEstudiante INT IDENTITY(1,1) PRIMARY KEY,
    Ci NVARCHAR(20) UNIQUE NOT NULL,
    Nombres NVARCHAR(50) NOT NULL,
    Apellidos NVARCHAR(100) NOT NULL,
    Genero NVARCHAR(20) NOT NULL,
    Direccion NVARCHAR(255) NOT NULL, -- Aumentado el tamaño
    FechaNacimiento DATE NOT NULL,
    Celular NVARCHAR(50),
    Nacionalidad NVARCHAR(50)
);

-- NivelCurso
CREATE TABLE NivelCurso (
    IdNivelCurso INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Nivel NVARCHAR(50) NOT NULL
);

-- Profesores
CREATE TABLE Profesores (
    IdProfesor INT IDENTITY(1,1) PRIMARY KEY,
    IdCargo INT,
    IdPrivilegio INT,
    IdNivelCurso INT,
    NombreCompleto NVARCHAR(100) NOT NULL,
    Ci NVARCHAR(20),
    Genero NVARCHAR(20),
    FechaNacimiento DATE NOT NULL,
    Celular NVARCHAR(50) NOT NULL,
    Direccion NVARCHAR(255) NOT NULL, -- Aumentado el tamaño
    Correo NVARCHAR(150), -- Aumentado el tamaño
    Nacionalidad NVARCHAR(50) NOT NULL,
    FOREIGN KEY (IdCargo) REFERENCES Cargo(IdCargo),
    FOREIGN KEY (IdPrivilegio) REFERENCES Privilegio(IdPrivilegio),
    FOREIGN KEY (IdNivelCurso) REFERENCES NivelCurso(IdNivelCurso)
);

-- Padre
CREATE TABLE Padre (
    IdPadre INT IDENTITY(1,1) PRIMARY KEY,
    NombreCompleto NVARCHAR(50) NOT NULL,
    Genero NVARCHAR(50) NOT NULL,
    Telefono NVARCHAR(50) NOT NULL,
    RelacionEstudiante NVARCHAR(50) NOT NULL,
    IdEstudiante INT,
    IdNivelCurso INT,
    FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante),
    FOREIGN KEY (IdNivelCurso) REFERENCES NivelCurso(IdNivelCurso)
);

-- Materia
CREATE TABLE Materia (
    IdMateria INT IDENTITY(1,1) PRIMARY KEY,
    IdNivelCurso INT,
    Nombre NVARCHAR(50) NOT NULL,
    FOREIGN KEY (IdNivelCurso) REFERENCES NivelCurso(IdNivelCurso)
);

CREATE TABLE Cursos(
    idCursoINT INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    nivel NVARCHAR(50),
    estado NVARCHAR(20)
)
SELECT * FROM Materia;
SELECT IdCurso, Nombre FROM Cursos;
SELECT * FROM Cursos;
SELECT * FROM Notas;
SELECT * FROM Mensualidades;
INSERT INTO Notas VALUES (1, 1, 65, 75, 86)


-- Inscripción, Programación, Nota, Calendario Escolar, Administrativo, TipoPago, Mensualidad
-- Aquí puedes continuar con las tablas restantes siguiendo el mismo patrón de correcciones.




-- Inscripción
CREATE TABLE Inscripcion (
    IdInscripcion INT IDENTITY(1,1) PRIMARY KEY,
    IdEstudiante INT,
    IdNivelCurso INT,
    FechaInscripcion DATE NOT NULL,
    ContactoEmergencia NVARCHAR(50) NOT NULL,
    EducacionAnterior NVARCHAR(50) NOT NULL,
    Enfermedad NVARCHAR(50),
    Observaciones NVARCHAR(255),
    FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante),
    FOREIGN KEY (IdNivelCurso) REFERENCES NivelCurso(IdNivelCurso)
);

-- Calendario Escolar
CREATE TABLE CalendarioEscolar (
    IdCalendarioEscolar INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(255),
    FechaInicio DATE NOT NULL,
    FechaFinal DATE
);



-- Programación
CREATE TABLE Programacion (
    IdProgramacion INT IDENTITY(1,1) PRIMARY KEY,
    IdProfesor INT,
    IdMateria INT,
    IdCalendarioEscolar INT,
    Dia NVARCHAR(20) NOT NULL,
    HorarioInicio NVARCHAR(20) NOT NULL,
    HorarioFin NVARCHAR(20) NOT NULL,
    FOREIGN KEY (IdProfesor) REFERENCES Profesores(IdProfesor),
    FOREIGN KEY (IdMateria) REFERENCES Materia(IdMateria),
    FOREIGN KEY (IdCalendarioEscolar) REFERENCES CalendarioEscolar(IdCalendarioEscolar)
);

-- Nota
CREATE TABLE Nota (
    IdNota INT IDENTITY(1,1) PRIMARY KEY,
    IdInscripcion INT,
    IdMateria INT,
    PrimerTrimestre INT,
    SegundoTrimestre INT,
    TercerTrimestre INT,
    FOREIGN KEY (IdInscripcion) REFERENCES Inscripcion(IdInscripcion),
    FOREIGN KEY (IdMateria) REFERENCES Materia(IdMateria)
);

-- Administrativo
CREATE TABLE Administrativo (
    IdAdministrativo INT IDENTITY(1,1) PRIMARY KEY,
    IdCargo INT,
    IdPrivilegio INT,
    Nombre NVARCHAR(50) NOT NULL,
    Ci NVARCHAR(20) NOT NULL,
    Genero NVARCHAR(20),
    FechaNacimiento DATE NOT NULL,
    Celular NVARCHAR(20) NOT NULL,
    Direccion NVARCHAR(255),
    Correo NVARCHAR(150),
    Nacionalidad NVARCHAR(50),
    FOREIGN KEY (IdCargo) REFERENCES Cargo(IdCargo),
    FOREIGN KEY (IdPrivilegio) REFERENCES Privilegio(IdPrivilegio)
);

-- Tipo de Pago
CREATE TABLE TipoPago (
    IdTipoPago INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Monto INT
);

-- Mensualidad
CREATE TABLE Mensualidad (
    IdMensualidad INT IDENTITY(1,1) PRIMARY KEY,
    IdInscripcion INT,
    IdTipoPago INT,
    FechaPago DATE NOT NULL,
    MontoPago INT NOT NULL,
    FOREIGN KEY (IdInscripcion) REFERENCES Inscripcion(IdInscripcion),
    FOREIGN KEY (IdTipoPago) REFERENCES TipoPago(IdTipoPago)
);

