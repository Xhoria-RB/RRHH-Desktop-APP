create database RRHH
go
use RRHH
go
--Raw definition of tables according to the teacher's ppt
create table Competencias(
IdCompetencia int identity(1,1) primary key,
Descripcion_Competencias varchar(100) not null,
Estado_Competencias bit default 1
);

create table Idiomas(
IdIdioma int identity(1,1) primary key,
Nombre_Idiomas varchar(50) not null,
Estado_Idiomas bit default 1
);

create table Capacitaciones(
IdCapacitacion int identity(1,1) primary key,
Descripcion_Capacitaciones varchar(100) not null,
Nivel_Capacitaciones varchar(15) not null check(Nivel_Capacitaciones in ('Grado', 'Post-Grado', 'Maestría', 'Doctorado', 'Técnico', 'Gestión')),
FechaDesde_Capacitaciones datetime not null,
FechaHasta_Capacitaciones datetime not null,
Institucion_Capacitaciones varchar(100) not null,
);

create table Departamentos(
IdDepartamento int identity(1,1) primary key,
Descripcion_Departamentos varchar(100) not null,
Estado_Departamentos bit default 1
);

create table Puestos(
IdPuesto int identity(1,1) primary key,
Nombre_Puestos varchar(50) not null,
IdDepartamento_Puestos int foreign key references Departamentos(IdDepartamento),
NivelRiesgo_Puestos varchar(10) not null check(NivelRiesgo_Puestos in ('Alto', 'Medio', 'Bajo')),
SalarioMinimo_Puestos decimal(10,2) not null,
SalarioMaximo_Puestos decimal(10,2) not null,
Estado_Puestos bit default 1
);

create table Personas(
IdPersona int identity(1,1) primary key,
Nombre_Personas varchar(20) not null,
Apellido_Personas varchar(30) not null,
Cedula_Personas varchar(20) not null,
Sexo_Personas char(1) check (Sexo_Personas in ('M', 'F')),
);

create table Candidatos(
IdCandidato int identity(1,1) primary key,
IdPersona_Candidatos int not null foreign key references Personas(IdPersona),
PuestoAspirado_Candidatos int foreign key references Puestos(IdPuesto),
SalarioAspirado_Candidatos decimal(10,2) not null,
Recomendacion_Candidatos varchar(50) not null,
Estado_Candidatos bit default 1
);

create table ExpLaborales(
IdExpLaboral int identity(1,1) primary key,
IdPersona_ExpLaboral int not null foreign key references Personas(IdPersona),
Empresa_ExpLaborales varchar(50) not null,
PuestoOcupado_ExpLaborales varchar(50) not null,
FechaDesde_ExpLaborales datetime not null,
FechaHasta_ExpLaborales datetime not null,
Salario_ExpLaborales decimal(10,2) not null
);

create table Empleados(
IdEmpleado int identity(1,1) primary key,
IdPersona_Empleados int not null foreign key references Personas(IdPersona),
FechaIngreso_Empleados datetime not null,
IdPuesto_Empleados int foreign key references Puestos(IdPuesto) not null,
Salario_Empleados decimal(10,2) not null,
Estado_Empleados bit default 1
);

--Possible normalizarion of tables

create table REL_Competencias_Candidatos(
IdRel_Competencias_Candidatos int identity(1,1) not null,
IdCandidato_Rel_Competencias_Candidatos int not null foreign key references Candidatos(IdCandidato),
IdCompetencia_Rel_Competencias_Candidatos int not null foreign key references Competencias(IdCompetencia),
primary key(IdCandidato_Rel_Competencias_Candidatos, IdCompetencia_Rel_Competencias_Candidatos, IdRel_Competencias_Candidatos )
);

create table REL_Capacitaciones_Candidatos(
IdRel_Capacitaciones_Candidatos int identity(1,1) not null,
IdCandidato_Rel_Capacitaciones_Candidatos int not null foreign key references Candidatos(IdCandidato),
IdCapacitacion_Rel_Capacitaciones_Candidatos int not null foreign key references Capacitaciones(IdCapacitacion),
primary key(IdCandidato_Rel_Capacitaciones_Candidatos, IdCapacitacion_Rel_Capacitaciones_Candidatos, IdRel_Capacitaciones_Candidatos)
);

create table REL_Idioma_Candidatos(
IdRel_Idiomas_Candidatos int identity(1,1) not null,
IdCandidato_Rel_Idioma_Candidatos int not null foreign key references Candidatos(IdCandidato),
IdIdioma_Rel_Idioma_Candidatos int not null foreign key references Idiomas(IdIdioma)
primary key(IdCandidato_Rel_Idioma_Candidatos, IdIdioma_Rel_Idioma_Candidatos, IdRel_Idiomas_Candidatos )
);

create table Usuarios(
IdUsuario int identity(1,1) primary key,
Email_Usuarios varchar(100) unique not null,
Contrasena_Usuarios varchar(250) not null,
NombreUsuario_Usuarios varchar(20) not null,
IdPersona_Usuarios int not null foreign key references Personas(IdPersona),
Roles_Usuarios varchar(10) not null check (Roles_Usuarios in('Admin', 'RRHH', 'Candidato')) default 'Candidato'
);
