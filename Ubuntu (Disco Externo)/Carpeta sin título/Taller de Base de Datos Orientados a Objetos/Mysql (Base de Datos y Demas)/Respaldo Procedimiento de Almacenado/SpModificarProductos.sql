CREATE DEFINER=`root`@`localhost` PROCEDURE `SPModificarProductos`(
In MNombre varchar(55),
In MPrecio int,
In MCantidad int,
In MC_Categoria int,
In MCodigo int)
BEGIN

Update productos 
set nombre = MNombre,
precio = MPrecio,
cantidad = MCantidad,
codigo_categoria = MC_Categoria

where codigo = MCodigo;

END