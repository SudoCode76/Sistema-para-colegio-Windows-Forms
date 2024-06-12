USE [master]
GO
/****** Object:  Database [SistemaColegio]    Script Date: 11/06/2024 22:43:01 ******/
CREATE DATABASE [SistemaColegio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaColegio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SistemaColegio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaColegio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SistemaColegio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SistemaColegio] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaColegio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaColegio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaColegio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaColegio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaColegio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaColegio] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaColegio] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SistemaColegio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaColegio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaColegio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaColegio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaColegio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaColegio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaColegio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaColegio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaColegio] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaColegio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaColegio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaColegio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaColegio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaColegio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaColegio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaColegio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaColegio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaColegio] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaColegio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaColegio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaColegio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaColegio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaColegio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SistemaColegio] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SistemaColegio] SET QUERY_STORE = ON
GO
ALTER DATABASE [SistemaColegio] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SistemaColegio]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[idCurso] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NOT NULL,
	[nivel] [nvarchar](50) NULL,
	[estado] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleEstudiante]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleEstudiante](
	[idDetalle] [int] IDENTITY(1,1) NOT NULL,
	[idEstudiante] [int] NULL,
	[ultimoCursoCursado] [nvarchar](50) NULL,
	[nombreColegiosAnteriores] [nvarchar](200) NULL,
	[observaciones] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[idEstudiante] [int] IDENTITY(1,1) NOT NULL,
	[CI] [nvarchar](20) NOT NULL,
	[nombreCompleto] [nvarchar](100) NOT NULL,
	[genero] [nvarchar](10) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[nacionalidad] [nvarchar](50) NULL,
	[direccion] [nvarchar](200) NULL,
	[tutor] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEstudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripcion]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripcion](
	[idInscripcion] [int] IDENTITY(1,1) NOT NULL,
	[idEstudiante] [int] NULL,
	[idCurso] [int] NULL,
	[fechaInscripcion] [date] NULL,
	[observacion] [nvarchar](200) NULL,
	[detalleMedico] [nvarchar](200) NULL,
	[educacionAnterior] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[idInscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[idMateria] [int] IDENTITY(1,1) NOT NULL,
	[nombreMateria] [nvarchar](100) NOT NULL,
	[gestion] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mensualidades]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mensualidades](
	[idMensualidad] [int] IDENTITY(1,1) NOT NULL,
	[idEstudiante] [int] NULL,
	[monto] [decimal](10, 2) NULL,
	[observacion] [nvarchar](200) NULL,
	[estado] [nvarchar](20) NULL,
	[fechaPago] [date] NULL,
	[totalPago] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMensualidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notas]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notas](
	[idNota] [int] IDENTITY(1,1) NOT NULL,
	[idEstudiante] [int] NULL,
	[idMateria] [int] NULL,
	[primerTrimestre] [decimal](5, 2) NULL,
	[segundoTrimestre] [decimal](5, 2) NULL,
	[tercerTrimestre] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idNota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Padres]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Padres](
	[idPadre] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NOT NULL,
	[direccion] [nvarchar](200) NULL,
	[telefono] [nvarchar](20) NULL,
	[parentesco] [nvarchar](50) NULL,
	[estado] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPadre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[idPermiso] [int] IDENTITY(1,1) NOT NULL,
	[estado] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Privilegios]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Privilegios](
	[idPrivilegio] [int] IDENTITY(1,1) NOT NULL,
	[tipoPrivilegio] [nvarchar](50) NULL,
	[nombrePrivilegio] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPrivilegio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[idProfesor] [int] IDENTITY(1,1) NOT NULL,
	[CIP] [nvarchar](20) NOT NULL,
	[nombreCompleto] [nvarchar](100) NOT NULL,
	[genero] [nvarchar](10) NULL,
	[nivelCurso] [nvarchar](50) NULL,
	[direccion] [nvarchar](200) NULL,
	[correo] [nvarchar](100) NULL,
	[celular] [nvarchar](20) NULL,
	[nacionalidad] [nvarchar](50) NULL,
	[estado] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idProfesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/06/2024 22:43:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[nombreUsuario] [nvarchar](20) NOT NULL,
	[contrasena] [nvarchar](20) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellidoPaterno] [nvarchar](50) NOT NULL,
	[apellidoMaterno] [nvarchar](50) NOT NULL,
	[tipoUsuario] [nvarchar](50) NOT NULL,
	[idPermiso] [int] NULL,
	[idPrivilegio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[nombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetalleEstudiante]  WITH CHECK ADD FOREIGN KEY([idEstudiante])
REFERENCES [dbo].[Estudiantes] ([idEstudiante])
GO
ALTER TABLE [dbo].[Inscripcion]  WITH CHECK ADD FOREIGN KEY([idEstudiante])
REFERENCES [dbo].[Estudiantes] ([idEstudiante])
GO
ALTER TABLE [dbo].[Mensualidades]  WITH CHECK ADD FOREIGN KEY([idEstudiante])
REFERENCES [dbo].[Estudiantes] ([idEstudiante])
GO
ALTER TABLE [dbo].[Notas]  WITH CHECK ADD FOREIGN KEY([idEstudiante])
REFERENCES [dbo].[Estudiantes] ([idEstudiante])
GO
ALTER TABLE [dbo].[Notas]  WITH CHECK ADD FOREIGN KEY([idMateria])
REFERENCES [dbo].[Materia] ([idMateria])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([idPermiso])
REFERENCES [dbo].[Permisos] ([idPermiso])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([idPrivilegio])
REFERENCES [dbo].[Privilegios] ([idPrivilegio])
GO
USE [master]
GO
ALTER DATABASE [SistemaColegio] SET  READ_WRITE 
GO
