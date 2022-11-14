CREATE PROCEDURE `SpPar_Impar` (
In Numero Int)
BEGIN

If Numero MOD 2 = 0 then 
insert into Par_Impar(Numero, Estado)
values (Numero, 'Par');
else 
insert into Par_Impar(Numero, Estado)
values (Numero, 'Impar');

end if;
END
