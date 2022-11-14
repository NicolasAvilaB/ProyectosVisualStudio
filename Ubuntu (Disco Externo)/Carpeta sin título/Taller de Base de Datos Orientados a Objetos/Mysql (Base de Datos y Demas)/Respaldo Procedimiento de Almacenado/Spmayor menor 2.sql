CREATE DEFINER=`root`@`localhost` PROCEDURE `new_procedure`(
In min1 int,
In min2 int,
In min3 int)
BEGIN

declare resultado text;
declare mayor text;
declare menor text;

if (num1 < num2 ) and (num1 < num3) then
set menor = num1;
end if;
if (num2 < num1 ) and (num2 < num3) then
set menor = num2;
end if;
if (num3 < num1 ) and (num3 < num2) then
set menor = num3;
elseif (numero1 > numero2 < numero3) then

set resultado = 'numero 1 es mayor';

elseif (numero1 = numero2 = numero3) then

set resultado = 'todos los numeros iguales';

insert into Mayor_Menor (num1, num2, num3)
values (min1, min2, min3);

end if;

end