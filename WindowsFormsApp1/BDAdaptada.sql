Create database CarrerasBD
GO

Use CarrerasBD
GO

create table Carreras (
id_carrera int identity(1,1),
nombre varchar(100) not null,
constraint pk_Carreras primary key (id_carrera)
)

create table Asignaturas (
id_asignatura int identity(1,1),
nombre varchar(100) not null,
constraint pk_Asignaturas primary key (id_asignatura)
)

create table DetalleCarreras(
id_detalleCarrera int identity(1,1),
anio_cursado int not null,
cuatrimestre int not null,
id_carrera int not null,
id_asignatura int not null,
constraint pk_DetalleCarreras primary key (id_detalleCarrera),
constraint fk_Carreras foreign key (id_carrera) references Carreras (id_carrera),
constraint fk_Asignaturas foreign key (id_asignatura) references Asignaturas(id_asignatura)
)



/* INSERTAR ASIGNATURAS  ----------------------------------------------------------------------*/


insert into asignaturas values ('Algebra 1')
insert into asignaturas values ('Algebra 2')
insert into asignaturas values ('Estad�sticas')
insert into asignaturas values ('Fisica')
insert into asignaturas values ('Ingl�s 1')
insert into asignaturas values ('Ingl�s 2')
insert into asignaturas values ('Laboratorio 1')
insert into asignaturas values ('Laboratorio 2')
insert into asignaturas values ('Matem�tica')
insert into asignaturas values ('Programaci�n 1')
insert into asignaturas values ('Programaci�n 2')
insert into asignaturas values ('Qu�mica')
insert into asignaturas values ('Sistemas Operativos 1')
insert into asignaturas values ('Sistemas Operativos 2')

select * from asignaturas



/* PROCEDIMIENTOS ALMACENADOS  ---------------------------------------------------------------*/



create proc sp_consultar_asignaturas
as
begin
	select id_asignatura, nombre from asignaturas
	order by nombre
end

create proc sp_insertar_carrera
@nombre varchar(100),
@new_id_carrera int output
as
begin
	insert into carreras(nombre) values(@nombre);
	set @new_id_carrera = SCOPE_IDENTITY();
end

create proc sp_insertar_detalleCarreras
@anioCursado int,
@cuatrimestre int,
@id_carrera int,
@id_asignatura int

as
begin
	insert into DetalleCarreras(anio_cursado, cuatrimestre, id_carrera, id_asignatura)
	values(@anioCursado, @cuatrimestre, @id_carrera, @id_asignatura)
end

create proc sp_consultar_carreras
as
begin
	select id_carrera, nombre from carreras
	order by id_carrera
end

 ALTER procedure  sp_consultar_detalleCarreras
as
begin
	select c.id_carrera 'codigo',c.nombre as 'Carrera',c.titulo 'titulo',
	a.id_asignatura 'codigo asignatura',
	a.nombre  'Nombre Asignatura',
	dc.anio_cursado as 'A�o Cursado', 
	dc.cuatrimestre as 'Cuatrimestre'
	from detalleCarreras as dc 
	inner join asignaturas as a on dc.id_asignatura = a.id_asignatura
	inner join carreras as c on dc.id_carrera = c.id_carrera
	WHERE c.eliminado=1
	order by c.id_carrera
end

Alter table Carreras
ADD eliminado bit null

CREATE PROCEDURE sp_registrar_baja_carrera
 @id_carrera int
 As
 begin
 Update Carreras 
 SET eliminado=1
 Where id_Carrera= @id_carrera
 end

 select*from Carreras

Alter table Carreras
ADD  eliminado int

 UPDATE Carreras
 SET eliminado= 0

 alter procedure SP_MostrarCarrera
 
 As
 begin select *from Carrera 
 where eliminado=1
 end

 execute sp_consultar_detalleCarreras


 Select anio_cursado 'A�o' , cuatrimestre 'cuatrimestre',c.id_carrera 'codigo carrera',c.nombre 'nombre de Carrera',a.id_asignatura 'codigo de materia', a.nombre 'nombre asignatura'
from DetalleCarreras dc join Asignaturas as a on dc.id_asignatura=a.id_asignatura 
join Carreras as c on c.id_carrera=dc.id_carrera

group by anio_cursado,cuatrimestre, c.id_carrera,c.nombre,a.id_asignatura,a.nombre 
