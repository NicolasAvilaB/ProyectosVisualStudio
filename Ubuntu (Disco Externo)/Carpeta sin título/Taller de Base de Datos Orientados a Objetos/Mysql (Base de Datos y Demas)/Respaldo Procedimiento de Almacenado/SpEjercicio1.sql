CREATE DEFINER=`root`@`localhost` PROCEDURE `SPEjercicio1`(
In NCodigo int,
In NNombre varchar(30),
In NEstado varchar(30))
BEGIN
If NEstado = 'Nuevo' then 
Insert into ProductoNuevo (Codigo, Nombre, Estado)
values (NCodigo, NNombre, NEstado);
end if;
if NEstado = 'Usado' then
Insert into ProductoUsado (Codigo, Nombre, Estado)
values (NCodigo, NNombre, NEstado);
end if;
if NEstado = 'Descontinuado' then
Insert into ProductoDescontinuado (Codigo, Nombre, Estado)
values (NCodigo, NNombre, NEstado);
end if;
END