VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ClsFacturacion"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Public Function P_RellenarListaDetalle(ByRef MSH As MSHFlexGrid, _
                                       ByVal idventa As String, _
                                       ByVal cn As Object) As Double
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "SELECT DetalleVenta.idventa, DetalleVenta.nitem, DetalleVenta.idproducto, Categorias.descategoria+' '+ Marcas.desmarca+' '+ Productos.nombre, DetalleVenta.cantidad, DetalleVenta.precio, DetalleVenta.subtotal,DetalleVenta.saldo,DetalleVenta.inicial FROM Marcas INNER JOIN (Categorias INNER JOIN (Productos INNER JOIN DetalleVenta ON Productos.idproducto = DetalleVenta.idproducto) ON Categorias.idcategoria=Productos.idcategoria) ON Marcas.idmarca = Productos.idmarca where DetalleVenta.idventa='" + idventa + "' ORDER BY 2", cn, adOpenStatic, adLockReadOnly, adCmdText
  On Local Error Resume Next
  rs.MoveLast
  rs.MoveFirst
  On Local Error GoTo 0
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Function
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Id Venta|<Nº Item|<IdProducto|<Descripción|>Cantidad|>Precio|>Sub-Total|>Saldo|>Inicial"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 0 'Id Venta
  MSH.ColWidth(2) = 1000 'Nº Item
  MSH.ColWidth(3) = 0 'IdProducto
  MSH.ColWidth(4) = 3500 'Descripción
  MSH.ColWidth(5) = 1400 'Cantidad
  MSH.ColWidth(6) = 1400 'Precio
  MSH.ColWidth(7) = 1400 'SubTotal
  MSH.ColWidth(8) = 0 'Saldo
  MSH.ColWidth(9) = 0 'Inicial
  P_RellenarListaDetalle = 0
  For I = 1 To MSH.Rows - 1
    P_RellenarListaDetalle = P_RellenarListaDetalle + Val(MSH.TextMatrix(I, 7))
  Next
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function

Public Property Get XNomUsu(ByVal XIDUSU As String, ByVal cn As Object) As String
On Local Error GoTo L
  Dim T As Object
  Set T = CreateObject("ADODB.Recordset")
  T.Open "SELECT NOMUSU FROM USUARIOS WHERE IDUSUARIO='" + XIDUSU + "'", cn, 0, 1
  On Local Error Resume Next
  T.MoveLast
  T.MoveFirst
  On Local Error GoTo 0
  XNomUsu = T!nomusu
  Set T = Nothing
Exit Property
L:
MsgBox Err.Description, vbCritical
End Property

Public Sub P_VENTASBUSQUEDA(ByRef MSH As MSHFlexGrid, Optional ByVal CRITERIO As String = 1, Optional ByVal DATO As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIO = 1 Then 'TODOS
    rs.Open "SELECT Ventas.idventa, Ventas.coddueño, Dueño.NomDueño+' '+Dueño.ApeDueño AS Expr1, Usuarios.nomusu, Format(Ventas.fecha,'dd/mm/yyyy') AS Expr2, IIf(Ventas.tipo_venta=0,'Contado','Credito') AS Expr3, Documentos.desdocumento, Ventas.ndocumento, IIf(Ventas.cancelado=0,'Cancelado','Sin Cancelar') AS Expr4, Ventas.descuento, IIf(Ventas.anulado=0,'No','Si') AS Expr5, Ventas.monto, promotores.nombres,Ventas.moneda,Ventas.tipcam FROM (Usuarios INNER JOIN (Dueño INNER JOIN (Documentos INNER JOIN Ventas ON Documentos.iddocumento = Ventas.iddocumento) ON Dueño.coddueño = Ventas.coddueño) ON Usuarios.idusuario = Ventas.idusuario) INNER JOIN promotores ON Ventas.idpromotor = promotores.idpromotor order by Ventas.idventa", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 2 Then 'POR CLIENTE
    rs.Open "SELECT Ventas.idventa, Ventas.coddueño, Dueño.NomDueño+' '+Dueño.ApeDueño AS Expr1, Usuarios.nomusu, Format(Ventas.fecha,'dd/mm/yyyy') AS Expr2, IIf(Ventas.tipo_venta=0,'Contado','Credito') AS Expr3, Documentos.desdocumento, Ventas.ndocumento, IIf(Ventas.cancelado=0,'Cancelado','Sin Cancelar') AS Expr4, Ventas.descuento, IIf(Ventas.anulado=0,'No','Si') AS Expr5, Ventas.monto, promotores.nombres,Ventas.moneda,Ventas.tipcam FROM (Usuarios INNER JOIN (Dueño INNER JOIN (Documentos INNER JOIN Ventas ON Documentos.iddocumento = Ventas.iddocumento) ON Dueño.coddueño = Ventas.coddueño) ON Usuarios.idusuario = Ventas.idusuario) INNER JOIN promotores ON Ventas.idpromotor = promotores.idpromotor WHERE Dueño.NomDueño+' '+Dueño.ApeDueño LIKE '%" + Trim$(DATO) + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 3 Then 'POR FECHA
    rs.Open "SELECT Ventas.idventa, Ventas.coddueño, Dueño.NomDueño+' '+Dueño.ApeDueño AS Expr1, Usuarios.nomusu, Format(Ventas.fecha,'dd/mm/yyyy') AS Expr2, IIf(Ventas.tipo_venta=0,'Contado','Credito') AS Expr3, Documentos.desdocumento, Ventas.ndocumento, IIf(Ventas.cancelado=0,'Cancelado','Sin Cancelar') AS Expr4, Ventas.descuento, IIf(Ventas.anulado=0,'No','Si') AS Expr5, Ventas.monto, promotores.nombres,Ventas.moneda,Ventas.tipcam FROM (Usuarios INNER JOIN (Dueño INNER JOIN (Documentos INNER JOIN Ventas ON Documentos.iddocumento = Ventas.iddocumento) ON Dueño.coddueño = Ventas.coddueño) ON Usuarios.idusuario = Ventas.idusuario) INNER JOIN promotores ON Ventas.idpromotor = promotores.idpromotor where FORMAT(Ventas.fecha,'dd/mm/yyyy') like '%" + Trim$(DATO) + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 4 Then 'POR Nº DOCUMENTO
    rs.Open "SELECT Ventas.idventa, Ventas.coddueño, Dueño.NomDueño+' '+Dueño.ApeDueño AS Expr1, Usuarios.nomusu, Format(Ventas.fecha,'dd/mm/yyyy') AS Expr2, IIf(Ventas.tipo_venta=0,'Contado','Credito') AS Expr3, Documentos.desdocumento, Ventas.ndocumento, IIf(Ventas.cancelado=0,'Cancelado','Sin Cancelar') AS Expr4, Ventas.descuento, IIf(Ventas.anulado=0,'No','Si') AS Expr5, Ventas.monto, promotores.nombres,Ventas.moneda,Ventas.tipcam FROM (Usuarios INNER JOIN (Dueño INNER JOIN (Documentos INNER JOIN Ventas ON Documentos.iddocumento = Ventas.iddocumento) ON Dueño.coddueño = Ventas.coddueño) ON Usuarios.idusuario = Ventas.idusuario) INNER JOIN promotores ON Ventas.idpromotor = promotores.idpromotor where Ventas.ndocumento like '%" + Trim$(DATO) + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  End If
  On Local Error Resume Next
  rs.MoveLast
  rs.MoveFirst
  On Local Error GoTo 0
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<IdVenta|<IdCliente|<Cliente|<Usuario|<Fecha|<Tipo Venta|<Documento|<Nº Documento|<Estado|<Descuento|<Anulado|<Monto|<Promotor|<Moneda|<Tipo Cambio"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1200 'IdVenta
  MSH.ColWidth(2) = 0 'IdCliente
  MSH.ColWidth(3) = 3000 'Cliente
  MSH.ColWidth(4) = 2000 'Usuario
  MSH.ColWidth(5) = 1200 'Fecha
  MSH.ColWidth(6) = 1200 'Tipo Venta
  MSH.ColWidth(7) = 2000 'Documento
  MSH.ColWidth(8) = 1300 'Nº Documento
  MSH.ColWidth(9) = 1200 'Estado
  MSH.ColWidth(10) = 1000 'Descuento
  MSH.ColWidth(11) = 1000 'Anulado
  MSH.ColWidth(12) = 1000 'Monto
  MSH.ColWidth(13) = 2500 'Promotor
  MSH.ColWidth(14) = 0 'Moneda
  MSH.ColWidth(15) = 0 'Tipo Cambio
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Function DevuelveIdUsuario(nomusu As String) As String
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT idusuario FROM usuarios WHERE nomusu='" + nomusu + "'", cn, adOpenForwardOnly, adLockReadOnly
REFRESCAR T
If T.RecordCount = 0 Then
  Set T = Nothing
  Exit Function
End If
DevuelveIdUsuario = T!idusuario
Set T = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
