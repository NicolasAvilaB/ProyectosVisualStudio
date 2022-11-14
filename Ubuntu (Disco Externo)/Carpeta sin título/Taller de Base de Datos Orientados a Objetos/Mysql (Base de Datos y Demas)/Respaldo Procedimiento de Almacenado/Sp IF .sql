CREATE PROCEDURE `SPOperacion` (
In ONumero1 int,
In ONumero2 int,
In OOPeracion Varchar(45))

BEGIN

declare ope int;
set ope =0;
if OOperacion = 'Suma' then 
     set ope = ONumero1 + ONumero2;
else if OOperacion = 'Resta' then
     set ope = ONumero1 - ONumero2;
else if OOperacion = 'Mult' then
     set ope = ONumero1 * ONumero2;
else if OOperacion = 'Divi' then
     set ope = ONumero1 / ONumero2;

end if;

insert into Operaciones (Numero1, Numero2, Operacion, Resultado)
Values (ONumero1, ONumero2, OOPeracion, ope);

END
