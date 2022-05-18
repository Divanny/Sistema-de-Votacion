create database Votacion;
use Votacion;

/* Creación de tabla de Usuario */
drop table if exists Usuario;
create table Usuario (
    Matricula int primary key,
    Nombre varchar(30),
    Apellido varchar(40),
    Genero char,
    Edad int not null,
    Correo varchar(100) not null,
    Foto text default("D:/Descargas/Proyecto/User-Profile-PNG.png"));
    
/* Creación de tabla de Candidatos */
drop table if exists Candidatos;
create table Candidatos (
    Matricula int primary key,
    Nombre varchar(30),
    Apellido varchar(40),
    Area varchar(100),
    Genero char,
    Foto longtext,
    Edad int not null,
    Correo varchar(100) not null);

/* Creación de tabla de Votos */
drop table if exists Votos;
create table Votos (
	Matricula int primary key,
    Voto_Ingenieria int, 
    Voto_Ciencias_Basicas_Ambientales int, 
    Voto_Ciencias_Salud int, 
    Voto_Ciencias_Sociales_Humanidades int, 
    Voto_Economia int);

select * from Usuario;
select * from Candidatos;	
select * from Votos;

select distinct(Nombre), Apellido, (select count(Voto_Ingenieria) from Votos where Voto_Ingenieria = Candidatos.Matricula) from Candidatos join Votos where Candidatos.Matricula = Votos.Voto_Ingenieria;
select distinct(Nombre), Apellido, (select count(Voto_Ciencias_Basicas_Ambientales) from Votos where Voto_Ciencias_Basicas_Ambientales = Candidatos.Matricula) from Candidatos join Votos where Candidatos.Matricula = Votos.Voto_Ciencias_Basicas_Ambientales;
select distinct(Nombre), Apellido, (select count(Voto_Ciencias_Salud) from Votos where Voto_Ciencias_Salud = Candidatos.Matricula) from Candidatos join Votos where Candidatos.Matricula = Votos.Voto_Ciencias_Salud;
select distinct(Nombre), Apellido, (select count(Voto_Ciencias_Sociales_Humanidades) from Votos where Voto_Ciencias_Sociales_Humanidades = Candidatos.Matricula) from Candidatos join Votos where Candidatos.Matricula = Votos.Voto_Ciencias_Sociales_Humanidades;
select distinct(Nombre), Apellido, (select count(Voto_Economia) from Votos where Voto_Economia = Candidatos.Matricula) from Candidatos join Votos where Candidatos.Matricula = Votos.Voto_Economia;

select distinct(Candidatos.Nombre), Candidatos.Apellido, (select count(Voto_Ingenieria) from Votos where Voto_Ingenieria = Candidatos.Matricula) from Candidatos join Votos on Candidatos.Matricula = Votos.Voto_Ingenieria join Usuario on Votos.Matricula = Usuario.Matricula where Usuario.Genero = 'M';
select distinct(Candidatos.Nombre), Candidatos.Apellido, (select count(Voto_Ciencias_Basicas_Ambientales) from Votos where Voto_Ciencias_Basicas_Ambientales = Candidatos.Matricula) from Candidatos join Votos on Candidatos.Matricula = Votos.Voto_Ciencias_Basicas_Ambientales join Usuario on Votos.Matricula = Usuario.Matricula where Usuario.Genero = 'M';

/* Almacenamiento de valores en las tablas */
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo,  Foto) 
    values (1106045, "Ronnie", "Difo", 'M', 18, "1106045@est.intec.edu.do",  "D:/Descargas/Proyecto/profile_user.jpg");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo,  Foto) 
    values (1109034, "Pedro", "Ureña", 'M', 19, "1109034@est.intec.edu.do",  "D:/Descargas/Proyecto/photo-1570295999919-56ceb5ecca61.jpg");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo,  Foto) 
    values (1102343, "Manuel", "Gautier", 'M', 23, "1102343@est.intec.edu.do",  "D:/Descargas/Proyecto/as.png");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo,  Foto) 
    values (1105434, "Sara", "Mateo", 'F', 25, "1105434@est.intec.edu.do",  "D:/Descargas/Proyecto/as2.png");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo,  Foto) 
    values (1113432, "Juan", "De la Cruz", 'M', 19, "1113432@est.intec.edu.do",  "D:/Descargas/Proyecto/unknown.png");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo) 
    values (1104312, "Alexa", "Vasques", 'F', 20, "1104312@est.intec.edu.do");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo) 
    values (1100943, "Maria", "Cruz", 'F', 21, "1100943@est.intec.edu.do");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo) 
    values (1109083, "Enny", "Reynoso", 'F', 18, "1109083@est.intec.edu.do");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo) 
    values (1101122, "Samuel", "De Leon", 'M', 19, "1101122@est.intec.edu.do");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo) 
    values (1112120, "Rosa", "Gutierrez", 'F', 21, "1112120@est.intec.edu.do");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo) 
    values (1107556, "Alice", "Pedroya", 'F', 23, "1107556@est.intec.edu.do");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo) 
    values (1108781, "Antonio", "Ortiz", 'M', 24, "1108781@est.intec.edu.do");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo) 
    values (1134323, "Diego", "Lajara", 'M', 18, "1134323@est.intec.edu.do");
insert into Usuario (Matricula, Nombre, Apellido, Genero, Edad, Correo) 
    values (1101223, "Jafhue", "Morant", 'M', 26, "1101223@est.intec.edu.do");
    
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1106045, "Ronnie Ismael", "Difo De leon", "Ingenieria", 'M', 36, "1107556@est.intec.edu.do");
 insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1101231, "Liam Gumersindo", "Sousa Gomez", "Ingenieria", 'M', 36, "1101231@est.intec.edu.do");
 insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1102324, "Valentina Maria ", "Carro Alarcon", "Ingenieria", 'F', 37, "1102324@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1102534, "Sebastian Luis", "Pujol Agudo", "Ingenieria", 'M', 35, "1102534@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1103534, "Victoria Gema", "Luque Guevara", "Ingenieria", 'F', 34, "1103534@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1105435, "Thiago Pedro", "Castro Diaz", "Ciencias Basicas y Ambientales", 'M', 46, "1105435@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1103463, "Emma Teodora", "Mejia Olivera", "Ciencias Basicas y Ambientales", 'F', 47, "1103463@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1106464, "Dylan Dario", "Planas Tejada", "Ciencias Basicas y Ambientales", 'M', 43, "1106464@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo)
values (1107456, "Mia Anna ", "Linares Nogales", "Ciencias Basicas y Ambientales", 'F', 46, "1107456@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1103634, "Mateo", "Rodrguez Salcedo", "Ciencias Basicas y Ambientales", 'M', 34, "1103634@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1107567, "Amaia Roger ", "Cañete Cobo", "Ciencias de la Salud", 'F', 46, "1107567@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1107432, "Ian Andres ", "Mañas Vivas", "Ciencias de la Salud", 'M', 64, "1107432@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1102363, "Isabella Esperanza", "Ledesma Centeno", "Ciencias de la Salud", 'F', 63, "1102363@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1107345, "Lucas Agustin ", "Fuertes Ramos", "Ciencias de la Salud", 'M', 64, "1107345@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1106234, "Mikaela Ascension", "Martorell Barrero", "Ciencias de la Salud", 'F', 36, "1106234@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1108344, "Noah Manuel ", "Vilches Canto", "Ciencias Sociales y Humanidades", 'M', 34, "1108344@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1101223, "Ainhoa Robert ", "Puerto Matos", "Ciencias Sociales y Humanidades", 'F', 56, "1101223@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1104653, "Matias Eusebio ", "Feijoo Espinosa", "Ciencias Sociales y Humanidades", 'M', 53, "1104653@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1107421, "Luna Maria ", "Amado Yuste", "Economía y Negocios", 'F', 53, "1107421@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1106345, "Anastasia Candida ", "Ceballos Leal", "Economía y Negocios", 'F', 65, "1106345@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1108343, "Haizea Aina ", "Blasco Trillo", "Economía y Negocios", 'M', 54, "1108343@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1101234, "Fernando Evaristo ", "Bonilla Orellana", "Economía y Negocios", 'M', 43, "1101234@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1105724, "Jone Marc ", "Pico Cazorla", "Economía y Negocios", 'M', 41, "1105724@est.intec.edu.do");
insert into Candidatos (Matricula, Nombre, Apellido, Area, Genero, Edad, Correo) 
    values (1104345, "Karima Maria ", "Zamora Romo", "Economía y Negocios", 'F', 67, "1106345@est.intec.edu.do");