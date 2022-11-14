CREATE PROCEDURE `Sp3Para.` (
In Bnombre varchar(45),
in Bprecio int,
in bcantidad int)
BEGIN

declare vneto int;
set vneto = Bprecio / 0.19);

declare viva int;
set viva = vneto * 0.19;

declare total int;
set total = vneto + viva;


insert into Venta (nombre_producto, precio, cantidad, neto, iva, total)
values (Bnombre, Bprecio, Bcantidad, vneto, viva, total); 


END
