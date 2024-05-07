create database sistemacolegio

use sistemacolegio

create table usuarios(
	Idusuario int IDENTITY (1,1) primary key,
	Ci int unique not null,
	Nombres nvarchar (50) not null,
	Apellidos nvarchar (100) not null,
	Email nvarchar (150) not null,
	Contraseña nvarchar (50) not null,
	Estado bit,
	idPermiso int foreign key references Permiso (IdPermiso),
	IdCargo int foreign key references Cargo (IdCargo)
)

Create table Grupo(
	IdGrupo int IDENTITY (1,1) primary key,
	Nombre varchar (50)
)

Create table Cargo(
	IdCargo int IDENTITY (1,1) primary key,
	Nombre varchar (50) not null
)

Create table Permiso(
	IdPermiso int IDENTITY (1,1) primary key,
	Nombre varchar (50)
)

Create table Privilegio(
	IdPrivilegio int IDENTITY (1,1) primary key,
	idPermiso int foreign key references Permiso (IdPermiso),
	IdGrupo int foreign key references Grupo (IdGrupo),
	Nombre varchar (50)
)
------------------------------------------------------------------------------

Create table Estudiante(
	IdEstudiante int IDENTITY (1,1) primary key,
	Ci varchar (20) unique not null,
	Nombres varchar (50) not null,
	Apellidos varchar (100) not null,
	Genero varchar (20) not null,
	Dirección nvarchar (50) not null,
	FechaNacimiento date not null,
	Celular varchar (50),
	Nacionalidad varchar (50)
)

Create table NivelCurso(
	IdNivelCurso int IDENTITY (1,1) primary key,
	Nombre varchar (50) not null,
	Nivel varchar (50) not null
)

Create table Profesores(
	IdProfesor int IDENTITY (1,1) primary key,
	IdCargo int Foreign key references Cargo (IdCargo),
	IdPrivilegio int Foreign key references Privilegio (IdPrivilegio),
	IdNivelCurso int Foreign key references NivelCurso (IdNivelCurso),
	NombreCompleto varchar (100) not null,
	ci varchar (20),
	Genero varchar (20),
	FechaNacimiento date not null,
	Celular varchar (50) not null,
	Direccion varchar (50) not null,
	Correo varchar (50),
	Nacionalidad varchar (50) not null
)

Create table Padre(
	IdPadre int IDENTITY (1,1) primary key,
	NombreCompleto varchar (50) not null,
	Genero varchar (50) not null,
	Telefono varchar (50) not null,
	RelacionEstudiante varchar (50) not null,
	IdEstudiante int Foreign key references Estudiante (IdEstudiante),
	IdNivelCurso int Foreign key references NivelCurso (IdNivelCurso)
)

Create table Materia(
	IdMateria int IDENTITY (1,1) primary key,
	IdNivelCurso int Foreign key references NivelCurso (IdNivelCurso),
	Nombre varchar (50) not null
)

Create table Programacion(
	IdProgramacion int IDENTITY (1,1) primary key,
	IdInscripcion int Foreign key references Inscripcion (IdInscripcion),
	IdProfesor int Foreign key references Profesores (IdProfesor),
	IdMateria int Foreign key references Materias (IdMateria),
	IdCalendarioEscolar int Foreign key references CalendarioEscolar (IdCalendarioEscolar),
	Dia varchar (20) not null,
	HorarioInicio varchar (20) not null,
	HorarioFin varchar (20) not null
)

Create table Inscripcion(
	IdInscripcion int IDENTITY (1,1) primary key,
	IdEstudiantes int Foreign key references Estudiante (IdEstudiante),
	IdNivelCurso int Foreign key references NivelCurso (IdNivelCurso),
	IdPadre int Foreign key references Padre (IdPadre),
	FechaInscripcion date not null,
	ContactoEmergencia varchar (50) not null,
	EducacionAnterior varchar (20) not null,
	Enfermedad varchar (50) not null,
	Obvervaciones varchar (100)
)

Create table DetalleInscripcion(
	IdDetalleInscripcion int IDENTITY (1,1) primary key,
	IdInscripcion int Foreign key references Inscripcion (IdInscripcion),
	IdMateria int Foreign key references Materia (IdMateria),
)

Create table Nota(
	IdNota int IDENTITY (1,1) primary key,
	IdInscripcion int Foreign key references Inscripcion (IdInscripcion),
	IdMateria int Foreign key references Materia (IdMateria),
	PrimerTrimestre int null,
	SegundoTrimestre int null,
	TercerTrimestre int null
)

Create table CalendarioEscolar(
	IdCalendarioEscolar int IDENTITY (1,1) primary key,
	Nombre varchar (50) not null,
	Descripcion varchar (50) null,
	FechaInicio date not null,
	FechaFinal date null
)

Create table Administrativo(
	IdAdministrativo int IDENTITY (1,1) primary key,
	IdCargo int Foreign key references Cargo (IdCargo),
	IdPrivilegio int Foreign key references Privilegio (IdPrivilegio), 
	Nombre varchar (50) not null,
	Ci varchar (20) not null,
	Genero varchar (20) null,
	FechaNacimiento date not null,
	Celular varchar (20) not null,
	Direccion varchar (50) null,
	Correo varchar (50) null,
	Nacionalidad varchar (50)
)
Create table TipoPago(
	IdTipoPago int IDENTITY (1,1) primary key,
	Nombre varchar (50) not null,
	Monto int null
)

Create table Mensualidad(
	IdMensualidad int IDENTITY (1,1) primary key,
	IdInscripcion int Foreign key references Inscripcion (IdInscripcion),
	IdTipoPago int Foreign key references TipoPago (IdTipoPago),
	FechaPago date not null,
	MontoPago int not null
)
------------------------------------------------------------------------------
--PROCEDIMIENTOS ALMACENADOS
Create procedure CrearUsuarios(

)