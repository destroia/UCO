use UCODB
alter procedure CreateArtistaSP(
@Id int,
@Nombre varchar(50),
@Pais varchar(50),
@CasaDisquera varchar(50)
)
As
begin
	Insert into  Artistas (Nombre,Pais,CasaDisquera) values(@Nombre,@Pais,@CasaDisquera)
	return 1;
end

exec CreateArtistaSP 0,'David','colombia','dd'


create procedure UpdateArtistaSP(
@Id int,
@Nombre varchar(50),
@Pais varchar(50),
@CasaDisquera varchar(50)
)
As
begin
	If exists (Select *  from Artistas where Id = @Id)
	BEGIN
		
			update Artistas set Nombre = @Nombre, Pais = @Pais, CasaDisquera = @CasaDisquera where id = @Id 
					return 1

				END

else

 return 0

END



exec UpdateArtistaSP 4,'paula','ecuador','ddsdsd'



create procedure FiltrarArtistaPS(

@Nombre varchar(50)
)
as
Begin

	Select * from Artistas where nombre LIKE '%' + @Nombre +'%'

END

exec FiltrarArtistaPS  ''



alter procedure DeleteArtistaSP(
@Id int)
As
begin 
	Delete Artistas where id = @Id
	return 1
End

exec DeleteArtistaSP 1


create procedure BuscarById(

@Id int
)
as
Begin

	Select * from Artistas where id = @Id
END

exec BuscarById 3
-------Cancion ---------------------
create procedure BuscarByArtistaId(

@Id int
)
as
Begin

	Select * from Cancions where ArtistaId = @Id
END

exec BuscarByArtistaId 3
create procedure CreateCancionSP(
@Id int,
@ArtistaId int,
@Nombre varchar(50),
@Duracion varchar(30))
as
begin
	insert into Cancions (ArtistaId, Nombre , Duracion) values( @ArtistaId,@Nombre,@Duracion)
	return 1;
End
Exec CreateCancionSP 0,4,'melodia 123','00:30:12'


create procedure DeleteCancionSP(
@Id int)
As
Begin
	Delete Cancions where Id = @Id
	return 1;
End

Exec DeleteCancionSP 4


create procedure UpdateCancionSP(
@Id int,
@ArtistaId int,
@Nombre varchar(50),
@Duracion varchar(30))
As
begin
	If exists (Select *  from Cancions where Id = @Id)
	BEGIN
		
			update Cancions set Nombre = @Nombre, ArtistaId = @ArtistaId, Duracion = @Duracion where id = @Id 
					return 1

				END

else

 return 0

END



exec UpdateCancionSP 4,'paula','ecuador','ddsdsd'



alter procedure FiltrarCancionPS(
@Id int,
@Nombre varchar(50)
)
as
Begin

	Select * from Cancions where nombre LIKE '%' + @Nombre +'%' and ArtistaId = @Id

END

exec FiltrarCancionPS  4 ,''

-----------Views-----------

Create View ArtietaCancionView
as
select A.Id as IdArtista,C.id as IdCancion,A.Pais,CasaDisquera, A.Nombre as NombreArtista,
C.Nombre as NombreCancion, Duracion from Artistas as A 
inner join Cancions As C
on C.ArtistaId = A.Id



select * from ArtietaCancionView



Select * from Cancions where id = 4
