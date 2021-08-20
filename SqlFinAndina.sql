create database FinAndina 

use  FinAndina;



create table Cliente (
Id int primary key  IDENTITY(1,1),
Numero_Identificacion int ,
Nombre  varchar(150) not null ,
Cuidad varchar(100) not null ,
Telefono  varchar(10) not null ,
)

create table Cuenta(
Id  int primary key  IDENTITY(1,1),
Nombre  varchar(150) not null ,
Id_Cliente int , 
FOREIGN KEY (Id_Cliente) REFERENCES Cliente(Id),
)

create  table TipoTransacciones(
Id int primary key  IDENTITY(1,1),
Nombre  varchar(150) not null ,
)


create table Transacciones (
Id  int primary key  IDENTITY(1,1),
Fecha Date , 
Tipo_Transacciones int ,
Monto  float ,
Total  float,
Id_Origen int,
Id_Destino int , 
Saldo_inicial int ,
Saldo_Total int ,
FOREIGN KEY (Id_Origen) REFERENCES Cuenta(Id),
FOREIGN KEY (Id_Destino) REFERENCES Cuenta(Id),
FOREIGN KEY (Tipo_Transacciones) REFERENCES TipoTransacciones(Id),
)





