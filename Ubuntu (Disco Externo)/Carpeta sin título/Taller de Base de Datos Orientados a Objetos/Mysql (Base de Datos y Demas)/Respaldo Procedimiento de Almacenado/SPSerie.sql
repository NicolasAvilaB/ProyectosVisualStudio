CREATE DEFINER=`root`@`localhost` PROCEDURE `SpSerie1`(
In minum int)
BEGIN

declare i int;
declare vSerie varchar(200);

set i = 1;
set vSerie = '';

while i <= minum do 
set vSerie= Concat(vSerie, '', i);
set i = i + 1;
end while;
insert into series1(numero, serie) 
values(minum, vSerie);

END