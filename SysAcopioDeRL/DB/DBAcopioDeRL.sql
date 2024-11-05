CREATE TABLE Rol(
  id_rol bigint not null identity(1,1) primary key,
  nombre_rol varchar(50) not null
);

create table Usuario(
  id_usuario bigint not null identity(1,1) primary key,
  alias_usuario varchar(25) not null unique,--Usar para el login
  nombre_usuario varchar(150) not null,
  contrasenia nvarchar(150) not null,
  id_rol bigint not null,
  estado bit not null,
  constraint fk_usuario_rol foreign key (id_rol) references Rol(id_rol)
);

create table Tipo_Recurso(
  id_tipo_recurso bigint not null identity(1,1) primary key,
  nombre_tipo varchar(50) not null
);

create table Recurso(
  id_recurso bigint identity(1,1) not null primary key,
  nombre_recurso varchar(50)not null,
  cantidad int not null,
  id_tipo_recurso bigint not null,
  constraint fk_recurso_tipo_recurso foreign key (id_tipo_recurso) references Tipo_Recurso(id_tipo_recurso)
);

create table Proveedor(
  id_proveedor bigint identity(1,1) not null primary key,
  nombre_proveedor varchar(150),
  estado bit not null,
);

create table Donacion(
  id_donacion bigint identity(1,1) not null primary key,
  id_proveedor bigint not null,
  ubicacion varchar(150),
  fecha datetime not null,
  constraint fk_donacion_proveedor foreign key (id_proveedor) references Proveedor(id_proveedor)
);

create table Recurso_Donacion(
  id_recurso_donacion bigint identity(1,1) primary key,
  id_donacion bigint not null,
  id_recurso bigint not null,
  cantidad int not null
  constraint fk_recurso_donacion_donacion foreign key (id_donacion) references Donacion(id_donacion),
  constraint fk_recurso_donacion_recurso foreign key (id_recurso) references Recurso(id_recurso),
);

create table Solicitud(
  id_solicitud bigint identity(1,1) primary key,
  ubicacion varchar(150) not null,
  fecha datetime not null,
  activo bit not null, --Activo inactivo
  nombre_solicitante varchar(150) not null,
  urgencia tinyint not null,
  motivo varchar(300) not null
);

create table Recurso_Solicitud(
  id_recurso_solicitud bigint identity(1,1) primary key,
  id_recurso bigint not null,
  id_solicitud bigint not null,
  cantidad int not null,
  constraint fk_recurso_solicitud_recurso foreign key (id_recurso) references Recurso(id_recurso),
  constraint fk_recurso_solicitud_solicitud foreign key (id_solicitud) references Solicitud(id_solicitud)
);