CREATE DEFINER=`root`@`localhost` PROCEDURE `SPNombreEdad`(
IN INombre Varchar(45),
In IEdad Int)
BEGIN

If IEdad >= 18 then
 Insert into Mayores_edad (Nombre,Edad)
 Values (INombre,IEdad);
else 
Insert into Menores_edad (Nombre,Edad)
 Values (INombre,IEdad);

end if;

END