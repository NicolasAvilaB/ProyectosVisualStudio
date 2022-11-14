CREATE PROCEDURE `SPValidaRut` (
In SRut Varchar(10),
In SNombre Varchar(45),
In SDireccion Varchar(45),
In STelefono Int)
BEGIN

If SRut = 195144443 Then 
Insert Into Clientes (Rut, Nombre, Direccion, Telefono)
Values (SRut, SNombre, SDireccion, STelefono);
else 
select 'El Rut Ingresado no es Valido';

end If;

END 
