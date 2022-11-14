CREATE DEFINER=`root`@`localhost` PROCEDURE `SpEliminarProductos`(
In MCodigo int)
BEGIN

Delete from productos 
where codigo = MCodigo;

END