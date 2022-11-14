Attribute VB_Name = "Mod_Prodims"
Option Private Module
Option Compare Text
Public Const ConTraData = "programita"
Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Private Declare Function ReleaseCapture Lib "user32" () As Long
Private Declare Function SQLConfigDataSource Lib "ODBCCP32.DLL" (ByVal hwndParent As Long, ByVal fRequest As Long, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Long
Public Declare Function CopyFile Lib "kernel32" Alias "CopyFileA" (ByVal lpExistingFileName As String, ByVal lpNewFileName As String, ByVal bFailIfExists As Long) As Long
Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal IpApplicationName As String, ByVal IpKeyName As Any, ByVal IpDefault As String, ByVal IpReturnedString As String, ByVal nSize As Long, ByVal IpFileName As String) As Long
Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, ByVal lpFileName As String) As Long
Global Const s_IDSERVICIO As String * 37 = "select max(idservicio) from servicios"
Global Const s_IDCARGO As String * 31 = "select max(idcargo) from cargos"
Global Const s_IDMARCAS As String * 31 = "select max(idmarca) from marcas"
Global Const S_IDVENTAS As String * 31 = "SELECT max(IDVENTA) From VENTAS"
Global Const s_IDPRODUCTO As String * 37 = "SELECT MAX(IDPRODUCTO) FROM PRODUCTOS"
Global Const s_IDMOTIVO As String * 32 = "select max(idmotivo) from motivo"
Global Const s_IDUSUARIOS As String * 35 = "SELECT MAX(IDUSUARIO) FROM USUARIOS"
Global Const s_IDPROVEEDOR As String * 40 = "select max(idproveedor) from proveedores"
Global Const s_IDCATEGORIA As String * 39 = "select max(idcategoria) from categorias"
Global Const s_IDDOCUMENTOS As String * 39 = "select max(iddocumento) from documentos"
Global Const s_IDSUBCATEGORIA As String * 45 = "select max(idsubcategoria) from SubCategorias"
Global Const Proveedor As String = "Microsoft.Jet.OleDB.4.0;Persist Security Info=False;User ID=ADMIN;Jet OLEDB:Database Password=" + ConTraData

Public Enum RJTM
  Fecha = 1
  Letras = 2
  Moneda = 3
  SoloNumero = 4
  Apostrofe = 5
  michi = 6
  telefono = 7
  ndocumento = 8
End Enum

Global cn As New ADODB.Connection

Global TIPO As String
Global IdUsu As String
Global V_KA As Boolean
Global V_PAGO As Boolean
Global V_DUEÑO As Boolean
Global V_MOROS As Integer
Global V_ANULAR As Boolean
Global V_KARDEX As Boolean
Global V_EXAMEN As Boolean
Global V_CLIENE As Boolean
Global V_REGUSU As Boolean
Global V_DEUDASS As Boolean
Global V_MASCOTA As Boolean
Global V_GRAFICO As Integer
Global V_HISTCLIN As Boolean
Global V_INGRESOS As Boolean
Global V_NOTAINGR As Boolean
Global V_NOTASALI As Boolean
Global V_SERVICIOS As Boolean
Global EXAMENCOMPL As Boolean
Global V_PRODUCTOS As Boolean
Global V_PROVEEDOR As Boolean
Global V_PROMOTORVENTAS As Boolean
Global DETALLEEXACOM As Boolean
Global V_INFORMCITAS As Boolean
Global V_CANCELACION As Boolean
Global V_FACTURACION As Boolean
Global V_BUSCARBOLETA As Integer
Global V_GRAFICOINGRESS As Integer
Global V_HOJAACTUALIZADA As Boolean
Global V_INFORMDEMASCOTAS As Boolean
Global V_REGISTRODEVENTAS As Boolean
Global V_REGISTRODECOMPRAS As Boolean
Global V_PROVEEDORXPRODUCTO As Boolean
Global V_PAGOCREDITOSVENTAS As Boolean
Global V_CUENTACORRIENTESSSS As Boolean
Global V_INFORMDEENFERMEDEDAS As Boolean
Global V_CUOTASRESTRUCTURACION As Boolean
Global V_FrmCatalogodeProductos As Boolean
Global V_CUENTASPORCOBRARCLIENTES As Boolean

Static Sub Main()
On Local Error GoTo P
  If App.PrevInstance = True Then
    MsgBox "La Aplicación Ya Esta En Uso", vbInformation
  End If
  Call CrearCarpeta
  cn.CursorLocation = adUseClient
  cn.CommandTimeout = 0
  cn.Provider = Proveedor
  If cn.State = adStateOpen Then cn.Close
  cn.Open App.Path + "\mela.mdb"
  WriteINI App.Path + "\Config.ini", "FONDO", "IMAGEN", App.Path + "\logo1.JPG"
  WriteINI App.Path + "\DIRECTORIOS.ini", "IMAGENES", "DUEÑOS", App.Path
  ReemplazarFotosDueños ReadIni("IMAGENES", "DUEÑOS", App.Path + "\DIRECTORIOS.ini") + "\IMAGENESDUEÑOS"
  Load FrmClave
  FrmClave.Show
  DSN_DE_USUARIO App.Path + "\mela.mdb"
  Exit Sub
P:
  MsgBox Err.Description, vbCritical
End Sub

Public Property Get Devuelve_IdCategoria(ByVal x As String) As String
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT IDCATEGORIA FROM CATEGORIAS WHERE DESCATEGORIA='" + x + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Property
  End If
  Devuelve_IdCategoria = T(0)
  Set T = Nothing
  Exit Property
L:
  MsgBox Err.Description, vbCritical
End Property
Public Property Get Devuelve_IdSubCategoria(ByVal x As String) As String
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT IDsubCATEGORIA FROM subCATEGORIAS WHERE DESsubCATEGORIA='" + x + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Property
  End If
  Devuelve_IdSubCategoria = T(0)
  Set T = Nothing
  Exit Property
L:
  MsgBox Err.Description, vbCritical
End Property
Public Property Get Devuelve_IdMarca(ByVal x As String) As String
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT idmarca FROM marcas WHERE desmarca='" + x + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Property
  End If
  Devuelve_IdMarca = T(0)
  Set T = Nothing
  Exit Property
L:
  MsgBox Err.Description, vbCritical
End Property

Public Property Get Devuelve_IdProveedor(ByVal x As String) As String
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT idproveedor FROM proveedores WHERE razonsocial='" + x + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Property
  End If
  Devuelve_IdProveedor = T(0)
  Set T = Nothing
  Exit Property
L:
  MsgBox Err.Description, vbCritical
End Property

Public Sub WriteINI(FileName As String, Section As String, Key As String, Text As String)
On Local Error GoTo L
WritePrivateProfileString Section, Key, Text, FileName
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub

Public Sub MoverVentana(ByVal Frm As Object)
  Call ReleaseCapture
  Call SendMessage(Frm.hwnd, &HA1, 2, 0)
End Sub
Public Sub ReemplazarFotosDueños(x As String)
On Error Resume Next
      Dim T As New ADODB.Recordset
        T.Open "dueño", cn, adOpenDynamic, adLockOptimistic, adCmdTable
        Do While T.EOF = False
          If T("fotodueño") <> "" Then
            T("fotodueño") = x + Right(T("fotodueño"), 11)
          End If
          T.MoveNext
        Loop
      Set T = Nothing
On Error GoTo 0
End Sub
Public Sub ReemplazarFotosMascotas(x As String)
On Error Resume Next
      Dim T As New ADODB.Recordset
        T.Open "mascotas", cn, adOpenDynamic, adLockOptimistic, adCmdTable
        Do While T.EOF = False
          If T("fotomascota") <> "" Then
            T("fotomascota") = x + Right(T("fotomascota"), 11)
          End If
          T.MoveNext
        Loop
      Set T = Nothing
On Error GoTo 0
End Sub

Public Sub CrearCarpeta()
On Error Resume Next
  MkDir ReadIni("IMAGENES", "DUEÑOS", App.Path + "\DIRECTORIOS.ini") + "\IMAGENESDUEÑOS"
  MkDir ReadIni("IMAGENES", "MASCOTAS", App.Path + "\DIRECTORIOS.ini") + "\IMAGENESMASCOTAS"
On Error GoTo 0
End Sub

Public Sub P_RellenaCombo(ByVal CRITERIO As String, ByRef XCOMBO As Object, Optional DATO As String, Optional ByVal NOLIMPIAR As Integer = 0)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIO = "PRO" Then
    rs.Open "select nomproFesion from Profesion", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "DIS" Then
    rs.Open "select nomdistrito from Distrito", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "CLI" Then
    rs.Open "select nomdueño+' '+ApeDueño from DUEÑO", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "NOM" Then
    rs.Open "select nomdistrito from Distrito", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "EXA" Then
    rs.Open "select descripcion from  [Examen Complementario]", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "CAR" Then
    rs.Open "SELECT DESCARGO FROM CARGOS", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "TIP" Then
    rs.Open "SELECT DESTIPO FROM TIPOUSUA", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "PROV" Then
    rs.Open "Select razonsocial from proveedores", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "MAR" Then
    rs.Open "Select desmarca from marcas", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "CAT" Then
    rs.Open "Select DESCATEGORIA from categorias", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "MOT" Then
    rs.Open "Select DESMOTIVO from MOTIVO", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "DOC" Then
    rs.Open "Select DESDOCUMENTO from DOCUMENTOS", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "PROD" Then
    rs.Open "SELECT Categorias.descategoria+' '+ Marcas.desmarca+' '+ Productos.nombre,Idproducto FROM Marcas INNER JOIN (Categorias INNER JOIN Productos ON Categorias.idcategoria = Productos.idcategoria) ON Marcas.idmarca = Productos.idmarca", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "SUBC" Then
    rs.Open "SELECT DESSUBCATEGORIA FROM SUBCATEGORIAS", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "promotor" Then
    rs.Open "SELECT nombres FROM promotores", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf CRITERIO = "comision" Then
    rs.Open "SELECT comision FROM comisiones", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  End If
  REFRESCAR rs
  If NOLIMPIAR = 0 Then
    XCOMBO.Clear
  End If
  If rs.RecordCount = 0 Then
    Set rs = Nothing
    Exit Sub
  End If
  Do While rs.EOF = False
    XCOMBO.AddItem rs(0)
    If CRITERIO = "PROD" Then
      XCOMBO.ItemData(XCOMBO.NewIndex) = Val(rs(1))
    End If
    rs.MoveNext
  Loop
  Set rs = Nothing
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub xRestringir(ByRef xKey As Integer, ByVal TIPO As RJTM)
   If xKey <> 8 Then
      Select Case TIPO
         Case 1 'Fecha
            If InStr(1, "0123456789 /-", Chr(xKey)) = 0 Then xKey = 0
         Case 2 'Letras
            If InStr(1, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ ", Chr(xKey)) = 0 Then xKey = 0
         Case 3 'Moneda
            If InStr(1, "0123456789.,", Chr(xKey)) = 0 Then xKey = 0
         Case 4 'SoloNumero
            If Chr(xKey) Like "[!0-9]" Then xKey = 0
         Case 5 'apostrofe
            If Chr(xKey) = "'" Then xKey = 0
        Case 6 'michi
          If Chr(xKey) = "#" Then xKey = 0
        Case 7 'telefono
         If InStr(1, "0123456789()* #/-", Chr(xKey)) = 0 Then xKey = 0
        Case 8 'Nº Documento
         If InStr(1, "0123456789-", Chr(xKey)) = 0 Then xKey = 0
      End Select
      If xKey = 0 Then Beep
   End If
End Sub
Function ReadIni(Cabezera As String, Variable As String, FileName As String) As String
    Dim WSInicad As String
    WSInicad = String(255, "0")
    ReadIni = Left(WSInicad, GetPrivateProfileString(Cabezera, ByVal Variable, Empty, WSInicad, Len(WSInicad), FileName))
End Function
Public Function CodigoDueño(ByVal ape, ByVal nom) As String
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "select max(cod) from CodigoDueño WHERE nom='" + Left(nom, 2) + "' and ape='" + Left(ape, 1) + "'", cn, adLockReadOnly, adCmdText
    REFRESCAR rs
  If rs.RecordCount = 0 Then
  CodigoDueño = UCase(Left(ape, 1) + Left(nom, 2) + "001")
  Set rs = Nothing
  Exit Function
  End If
  CodigoDueño = UCase(Left(ape, 1) + Left(nom, 2) + Format$(Val(IIf(IsNull(rs(0)), 1, rs(0))) + 1, "000"))
  Set rs = Nothing
  Exit Function
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Function P_RELLENALISTADUEÑO(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, CADENA$) As Double
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then 'PARA VENTANA DUEÑOS
    rs.Open "SELECT CodDueño, NomDueño, ApeDueño, Telefono, Edad, DNI, NomProfesion, Direccion, NomDistrito, [E-mail], FotoDueño, iif(Dueño.estado=0,'Activo','Inactivo') as Essta, observaciones,iif(dueño.tipo=0,'Consulta','Petshop') FROM Dueño WHERE NomDueño like '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 2 Then 'PARA VENTANA DUEÑOS
    rs.Open "SELECT CodDueño, NomDueño, ApeDueño, Telefono, Edad, DNI, NomProfesion, Direccion, NomDistrito, [E-mail], FotoDueño, iif(Dueño.estado=0,'Activo','Inactivo') as Essta, observaciones,iif(dueño.tipo=0,'Consulta','Petshop') FROM Dueño  WHERE ApeDueño LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 3 Then 'PARA VENTANA DUEÑOS
    rs.Open "SELECT CodDueño, NomDueño, ApeDueño, Telefono, Edad, DNI, NomProfesion, Direccion, NomDistrito, [E-mail], FotoDueño, iif(Dueño.estado=0,'Activo','Inactivo') as Essta, observaciones,iif(dueño.tipo=0,'Consulta','Petshop') FROM Dueño WHERE DNI LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 4 Then 'PARA VENTANA DUEÑOS
    rs.Open "SELECT CodDueño, NomDueño, ApeDueño, Telefono, Edad, DNI, NomProfesion, Direccion, NomDistrito, [E-mail], FotoDueño, iif(Dueño.estado=0,'Activo','Inactivo') as Essta, observaciones,iif(dueño.tipo=0,'Consulta','Petshop') FROM Dueño  WHERE NomDistrito LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 5 Then 'PARA DEUDORES
    rs.Open "SELECT Dueño.CodDueño, Dueño.NomDueño, Dueño.ApeDueño, Dueño.Telefono, Dueño.Edad, Dueño.DNI, Dueño.NomProfesion, Dueño.Direccion, Dueño.NomDistrito, Dueño.[E-mail], Dueño.FotoDueño, iif(Dueño.estado=0,'Activo','Inactivo') as Essta, Dueño.observaciones,iif(dueño.tipo=0,'Consulta','Petshop') FROM Dueño INNER JOIN Pago ON Dueño.CodDueño = Pago.CodDueño Where Pago.Cancelado=0 AND NomDueño LIKE '%" + CADENA + "%'", cn, adOpenForwardOnly, adLockReadOnly
  ElseIf CRITERIOS = 6 Then 'PARA DEUDORES
    rs.Open "SELECT Dueño.CodDueño, Dueño.NomDueño, Dueño.ApeDueño, Dueño.Telefono, Dueño.Edad, Dueño.DNI, Dueño.NomProfesion, Dueño.Direccion, Dueño.NomDistrito, Dueño.[E-mail], Dueño.FotoDueño, iif(Dueño.estado=0,'Activo','Inactivo') as Essta, Dueño.observaciones,iif(dueño.tipo=0,'Consulta','Petshop')   FROM Dueño INNER JOIN Pago ON Dueño.CodDueño = Pago.CodDueño Where Pago.Cancelado=0 AND ApeDueño LIKE '%" + CADENA + "%'", cn, adOpenForwardOnly, adLockReadOnly
  ElseIf CRITERIOS = 7 Then 'PARA DEUDORES
    rs.Open "SELECT Dueño.CodDueño, Dueño.NomDueño, Dueño.ApeDueño, Dueño.Telefono, Dueño.Edad, Dueño.DNI, Dueño.NomProfesion, Dueño.Direccion, Dueño.NomDistrito, Dueño.[E-mail], Dueño.FotoDueño, iif(Dueño.estado=0,'Activo','Inactivo') as Essta, Dueño.observaciones,iif(dueño.tipo=0,'Consulta','Petshop')   FROM Dueño INNER JOIN Pago ON Dueño.CodDueño = Pago.CodDueño Where Pago.Cancelado=0 AND DNI LIKE '%" + CADENA + "%'", cn, adOpenForwardOnly, adLockReadOnly
  ElseIf CRITERIOS = 8 Then 'PARA DEUDORES
    rs.Open "SELECT Dueño.CodDueño, Dueño.NomDueño, Dueño.ApeDueño, Dueño.Telefono, Dueño.Edad, Dueño.DNI, Dueño.NomProfesion, Dueño.Direccion, Dueño.NomDistrito, Dueño.[E-mail], Dueño.FotoDueño, iif(Dueño.estado=0,'Activo','Inactivo') as Essta, Dueño.observaciones,iif(dueño.tipo=0,'Consulta','Petshop')   FROM Dueño INNER JOIN Pago ON Dueño.CodDueño = Pago.CodDueño Where Pago.Cancelado=0 AND NOMDISTRITO LIKE '%" + CADENA + "%'", cn, adOpenForwardOnly, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Function
  End If
  P_RELLENALISTADUEÑO = rs.RecordCount
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Nombres|<Apellidos|<Télefono|<Edad|<D.N.I|<Profesión|<Dirección|<Distrito|<E-Mail|<Foto|<Estado|<Observaciones|<Tipo"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 900 'Código
  MSH.ColWidth(2) = 2000 'Nombres
  MSH.ColWidth(3) = 2000 'Apellidos
  MSH.ColWidth(4) = 1000 'Apellidos
  MSH.ColWidth(5) = 700 'Edad
  MSH.ColWidth(6) = 1300 'D.N.I
  MSH.ColWidth(7) = 1500 'Profesión
  MSH.ColWidth(8) = 2500 'Dirección
  MSH.ColWidth(9) = 2000 'Distrito
  MSH.ColWidth(10) = 6500 'E-Mail
  MSH.ColWidth(11) = 0 'Foto
  MSH.ColWidth(12) = 1300 'Estado
  MSH.ColWidth(13) = 5000 'Observaciones
  MSH.ColWidth(14) = 1200 'Tipo
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Sub BuscarEnCombito(ByRef CMB As Object)
On Local Error Resume Next
  Dim j As Byte
  Dim I As Long
  For I = 0 To CMB.ListCount - 1
    If CMB = CMB.List(I) Then
        j = 1
        CMB.ListIndex = I
        Exit Sub
      Else
        j = 2
    End If
  Next I
  If j = 2 Then
    On Error Resume Next
    CMB = ""
    CMB.ListIndex = 0
  End If
On Local Error GoTo 0
End Sub
Public Property Set LIMPIAR(ByRef Frm As Object)
On Error Resume Next
  Dim obj As Object
  For Each obj In Frm
    If TypeOf obj Is TextBox Then
      obj = Empty
    End If
    If TypeOf obj Is OptionButton And Val(obj.Tag) <> 1 Then
      obj.Value = False
    End If
    If TypeOf obj Is CheckBox Then
      obj.Value = 0
    End If
    If TypeOf obj Is ComboBox Then
      obj = ""
    End If
     If TypeOf obj Is Image Then
      obj.Picture = LoadPicture("")
    End If
  Next obj
  Set obj = Nothing
  On Error GoTo 0
End Property
Public Sub P_RELLENALISTADISTRITOS(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, Optional ByVal CADENA$)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT * FROM DISTRITO", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT * FROM DISTRITO WHERE NOMDISTRITO LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Distrito"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1400
  MSH.ColWidth(2) = 3500
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub P_RELLENALISTAPROFESION(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, Optional ByVal CADENA$)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT * FROM PROFESION", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT * FROM PROFESION WHERE NOMPROfESION LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Profesión"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1400
  MSH.ColWidth(2) = 3500
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub ValidarIngreso1(ByRef cbCombo As ComboBox, ByRef iKey As Integer, Optional ByRef cControl As Control)
On Error GoTo ERROR
Dim cbE As Long, FindString$
Const Cb_FinsdString = &H14C
    iKey = Asc(UCase(Chr(iKey)))
    If iKey = 8 Then 'SI TECLEA BACKSPACE********************************************************************************
        If Len(Trim(cbCombo.Text)) = 1 Or cbCombo.SelLength = Len(Trim(cbCombo.Text)) Then
            cbCombo.ListIndex = 0: Exit Sub
        End If
    End If
    If cbCombo.SelLength = 0 Then 'SE ASIGNA VALORES A LA CADENA A BUSCAR(FINDSTRING)************************************
        FindString = cbCombo.Text & Chr$(iKey)
    Else
        FindString = Left$(cbCombo.Text, cbCombo.SelStart) & Chr$(iKey)
    End If
    cbE = SendMessage(cbCombo.hwnd, Cb_FinsdString, -1, ByVal FindString)
    If iKey = 13 Then 'SI TECLEA ENTER***********************************************************************************
        DoEvents
        cControl.SetFocus
        If cbE = -1 Then cbE = cbCombo.ListIndex
        If cbCombo.ListIndex = -1 Then Exit Sub
        If cbCombo.ListIndex > -1 Then cbE = cbCombo.ListIndex
    End If
    'If iKey < 32 Or iKey > 127 Then Exit Sub
    If cbE <> -1 Then
        cbCombo.ListIndex = cbE 'SUELE LLAMAR AL EVENTO CLICK O CHANGE
        cbCombo.SelStart = Len(FindString)
        cbCombo.SelLength = Len(cbCombo.Text) - cbCombo.SelStart
    End If
    If iKey = 13 Then cbCombo.SelLength = 0 'EN OBSERVACION***************************************************************************
    iKey = 0: Exit Sub
ERROR:
     Exit Sub
End Sub
Public Sub P_RELLENALISTAMASCOTA(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, CADENA As String, Optional CADENA2 As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT * FROM ListaMascotas WHERE NomMascota='" + CADENA + "'", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT * FROM ListaMascotas WHERE NomMascota LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 3 Then
    rs.Open "SELECT * FROM ListaMascotas WHERE NomMascota='" + CADENA + "' AND [CODDUEÑO]='" + CADENA2 + "'", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 4 Then
    rs.Open "SELECT * FROM ListaMascotas WHERE NomMascota LIKE '%" + CADENA + "%' AND [CODDUEÑO]='" + CADENA2 + "'", cn, adOpenStatic, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<CodMascota|<NomMascota|<Años|<Meses|<Sexo|<Fec-Nac|<Peso|<Pelaje|<Alergia|<Raza|<Especie|<Foto|<CodDueño|<Dueño|<Dirección|<Teléfono"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 900 'CodMascota
  MSH.ColWidth(2) = 3200 'NomMascota
  MSH.ColWidth(3) = 1000 'Años
  MSH.ColWidth(4) = 1000 'Meses
  MSH.ColWidth(5) = 800 'Sexo
  MSH.ColWidth(6) = 1200 'Fec-Nac
  MSH.ColWidth(7) = 750 'Peso
  MSH.ColWidth(8) = 750 'Pelaje
  MSH.ColWidth(9) = 800 'Alergia
  MSH.ColWidth(10) = 2200 'Raza
  MSH.ColWidth(11) = 2000 'Especie
  MSH.ColWidth(12) = 4000 'Foto
  MSH.ColWidth(13) = 1000 'CodDueño
  MSH.ColWidth(14) = 3000 'Dueño
  MSH.ColWidth(15) = 3000 'Direccion
  MSH.ColWidth(16) = 1300 'Teléfono
  Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Function codigoMascota(ByVal raz, ByVal nom) As String
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "select max(cod) from CodigoMascota WHERE nom='" + Left(nom, 1) + "' and raz='" + Left(ape, 2) + "'", cn, adLockReadOnly, adCmdText
    REFRESCAR rs
  If rs.RecordCount = 0 Then
  codigoMascota = Left(nom, 1) + UCase(Left(raz, 2) + "001")
  Set rs = Nothing
  Exit Function
  End If
  codigoMascota = Left(nom, 1) + UCase(Left(raz, 2) + Format$(Val(IIf(IsNull(rs(0)), 1, rs(0))) + 1, "000"))
  Set rs = Nothing
  Exit Function
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Sub P_RELLENALISTARAZA(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, Optional ByVal CADENA$)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT * FROM RAZA", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT * FROM RAZA WHERE NomRaza LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Raza|<Especie"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1200
  MSH.ColWidth(2) = 3200
  MSH.ColWidth(3) = 2500
Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
Public Function N_BOLETA() As String
On Local Error GoTo L
    Dim texto As String
    Open App.Path + "\Serie.txt" For Input As #1
    Input #1, texto
    Close #1
    Dim T As New ADODB.Recordset
    T.Open "SELECT IIF(ISNULL( PAGO.[Nº Boleta]),'0000', PAGO.[Nº Boleta]) FROM PAGO", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
    REFRESCAR T
    If T.RecordCount = 0 Then
    
      N_BOLETA = texto
      Set T = Nothing
      Exit Function
    End If
    If T(0) = "0000" Then
    N_BOLETA = texto
    Else
    N_BOLETA = Strings.Left(texto, 3) + "-" + Format(Val(Right(T(0), 4)) + 1, "0000")
    End If
    Set T = Nothing
Exit Function
L:
If Err.Number = 94 Then
      N_BOLETA = texto + "-0001"
      Set T = Nothing
      Exit Function
End If
  MsgBox Err.Description, vbCritical
End Function
Public Sub P_RELLENALISTADETALLEPAGO(ByRef MSH As MSHFlexGrid, Optional ByVal N_BOL As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "SELECT * FROM DETALLEPAGOS WHERE [Nº Boleta]='" + N_BOL + "'", cn, adOpenStatic, adLockReadOnly
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Nº|<Nº Boleta|<Descripción|>Cantidad|>Precio|>Total"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 800
  MSH.ColWidth(2) = 0
  MSH.ColWidth(3) = 5600
  MSH.ColWidth(4) = 1000
  MSH.ColWidth(5) = 1000
  MSH.ColWidth(6) = 1000
Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
Sub REFRESCAR(rs As Object)
  On Local Error Resume Next
  rs.MoveLast
  rs.MoveFirst
  On Local Error GoTo 0
End Sub
Public Sub BuscarBoleta(MSH As MSHFlexGrid, tip As Integer, Optional ByVal DATO As String)
On Local Error GoTo L
Dim T As New ADODB.Recordset
If tip = 1 Then
T.Open "select * from ListaCancelacion where [Nº Boleta]='" + DATO + "'", cn, adOpenForwardOnly, adLockReadOnly
ElseIf tip = 2 Then
T.Open "select * from ListaCancelacion where Emision='" + DATO + "'", cn, adOpenForwardOnly, adLockReadOnly
ElseIf tip = 3 Then
T.Open "select * from ListaCancelacion where anulado=1", cn, adOpenForwardOnly, adLockReadOnly
ElseIf tip = 4 Then
T.Open "select * from ListaCancelacion where [coddueño]='" + DATO + "'", cn, adOpenForwardOnly, adLockReadOnly
ElseIf tip = 5 Then
T.Open "select * from ListaCancelacion where cc='no' and [Nº Boleta]='" + DATO + "'", cn, adOpenForwardOnly, adLockReadOnly
ElseIf tip = 6 Then
T.Open "select * from ListaCancelacion where cc='no' and Emision=#" + DATO + "#", cn, adOpenForwardOnly, adLockReadOnly
ElseIf tip = 7 Then
T.Open "select * from ListaCancelacion where cc='no' and anulado=1", cn, adOpenForwardOnly, adLockReadOnly
ElseIf tip = 8 Then
T.Open "select * from ListaCancelacion where cc='no' and [coddueño]='" + DATO + "'", cn, adOpenForwardOnly, adLockReadOnly
End If
REFRESCAR T
If T.RecordCount = 0 Then
  Set T = Nothing
  MSH.Rows = 2
  MSH.Cols = 2
  MSH.Clear
  Exit Sub
End If
  Set MSH.Recordset = T
  Set T = Nothing
  MSH.FormatString = "|<Nº Boleta|<Dueño|<Mascota|<Fec-Emisión|<Tipo Pago|<Anulado|<Fecha Inicio|<Fecha Pago|<Fecha Término|<A Cuenta|<Saldo|<Nº Cuotas|<Monto X Cuota|<Cancelado"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1200 'Nº Boleta
  MSH.ColWidth(2) = 1300 'Dueño
  MSH.ColWidth(3) = 1300 'Mascota
  MSH.ColWidth(4) = 1300 'Fec-Emisión
  MSH.ColWidth(5) = 1300 'Tipo Pago
  MSH.ColWidth(6) = 1300 'Anulado
  MSH.ColWidth(7) = 1300 'Fecha Inicio
  MSH.ColWidth(8) = 1300 'Fecha Pago
  MSH.ColWidth(9) = 1300 'Fecha Término
  MSH.ColWidth(10) = 1300 'A Cuenta
  MSH.ColWidth(11) = 1300 'Saldo
  MSH.ColWidth(12) = 1300 'Nº Cuotas
  MSH.ColWidth(13) = 1300 'Monto X Cuota
  MSH.ColWidth(14) = 1000 'Cancelado
Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
Function SERIES(DATO As String) As String
On Local Error GoTo L
Dim rs As New ADODB.Recordset
rs.Open "SELECT MAX(NSERIE) FROM DETALLEPAGO WHERE [Nº Boleta]='" + DATO + "'", cn, adOpenForwardOnly, adLockReadOnly
REFRESCAR rs
If rs.RecordCount = 0 Then
    SERIES = "01"
    Set rs = Nothing
    Exit Function
End If
SERIES = Format$(Val(rs(0)) + 1, "00")
rs.Close
Set rs = Nothing
Exit Function
L:
If Err.Number = 94 Then
    SERIES = "01"
    Set rs = Nothing
    Exit Function
End If
MsgBox Err.Description, vbCritical
End Function
Public Sub DSN_DE_USUARIO(RUTADB As String, Optional ByVal T As String)
On Local Error GoTo LineaError
    T = "SERVER=(local)" & Chr$(0)
    T = T & "DESCRIPTION=Sistema" & Chr$(0)
    T = T & "DSN=META" & Chr$(0)
    T = T & "DBQ=" & RUTADB & Chr$(0)
    T = T & "UID=Admin" & Chr$(0)
    T = T & "PWD=" & ConTraData & Chr$(0)
    If SQLConfigDataSource(0&, 1, "Microsoft Access Driver (*.mdb)", T) <> 1 Then
      MsgBox "Descripción=> " + "No se ha podido crear el DSN de usuario especificado..." + Trim$(Err.Number) + Chr(13) + "Procedimiento=> " + "DSN_DE_USUARIO", vbCritical, "Error En Modulo.bas"
    End If
 Exit Sub
LineaError:
    MsgBox Err.Description, vbCritical
End Sub
Public Function peliminafotoD(txtcodigo As String) As Long
On Local Error GoTo L
  xd = ReadIni("IMAGENES", "DUEÑOS", App.Path + "\DIRECTORIOS.ini") + "\IMAGENESDUEÑOS\" + txtcodigo + ".jpg"
  If FileLen(xd) > 0 Then
    Kill xd
  End If
  Exit Function
L:
  If Err.Number = 53 Then
    Exit Function
  End If
End Function
Public Function peliminafotoM(txtcodigo As String) As Long
On Local Error GoTo L
  xd = ReadIni("IMAGENES", "MASCOTAS", App.Path + "\DIRECTORIOS.ini") + "\IMAGENESMASCOTAS\" + txtcodigo + ".jpg"
  If FileLen(xd) > 0 Then
    Kill xd
  End If
  Exit Function
L:
  If Err.Number = 53 Then
    Exit Function
  End If
End Function
Public Sub P_RELLENALISTAHC(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, CADENA As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT * FROM ListaHC WHERE [Nº Historia]='" + CADENA + "'", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT * FROM ListaHC WHERE [CodMascota] ='" + CADENA + "'", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 3 Then
    rs.Open "SELECT * FROM ListaHC WHERE [NomMascota] LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Nº Historia|<CódigoMascota|<Mascota|<CódigoDueño|<Dueño|<Fec-Nac|<Años|<Meses|<Teléfono|<Dirección|<Especie|<Sexo|<Raza"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 900 'Nº Historia
  MSH.ColWidth(2) = 1300 'CódigoMascota
  MSH.ColWidth(3) = 3200 'Mascota
  MSH.ColWidth(4) = 1300 'CódigoDueño
  MSH.ColWidth(5) = 2300 'Dueño
  MSH.ColWidth(6) = 1200 'Fec-Nac
  MSH.ColWidth(7) = 900 'Años
  MSH.ColWidth(8) = 900 'Meses
  MSH.ColWidth(9) = 1200 'Teléfono
  MSH.ColWidth(10) = 3200 'Dirección
  MSH.ColWidth(11) = 3000 'Especie
  MSH.ColWidth(12) = 800 'Sexo
  MSH.ColWidth(13) = 3000 'Raza
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub P_RELLENALISTAEXAMENCOMPLEMENTARIO(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, CADENA As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT * FROM [EXAMEN COMPLEMENTARIO] WHERE DESCRIPCION LIKE '%" + Trim(CADENA) + "%'", cn, adOpenStatic, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Descripción|>Costo|<Propio"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 900 'Código
  MSH.ColWidth(2) = 5000 'Descripción
  MSH.ColWidth(3) = 1400 'Costo
  MSH.ColWidth(4) = 1000 'Propio
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Function codigoEXAcomplem() As String
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "select max(CodExamCompl) from [EXAMEN COMPLEMENTARIO]", cn, adLockReadOnly, adCmdText
  REFRESCAR rs
  If rs.RecordCount = 0 Then
  codigoEXAcomplem = "000001"
  Set rs = Nothing
  Exit Function
  End If
  codigoEXAcomplem = Format$(Val(IIf(IsNull(rs(0)), 1, rs(0))) + 1, "000000")
  Set rs = Nothing
  Exit Function
Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function NHISTORIA() As String
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "select max([Nº HISTORIA]) from [HISTORIA CLINICA]", cn, adLockReadOnly, adCmdText
  REFRESCAR rs
  If rs.RecordCount = 0 Then
  NHISTORIA = "00001"
  Set rs = Nothing
  Exit Function
  End If
  NHISTORIA = Format$(Val(IIf(IsNull(rs(0)), 1, rs(0))) + 1, "00000")
  Set rs = Nothing
  Exit Function
Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Sub P_RELLENALISTADETALLE_HC(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, CADENA As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT [Detalle H/C].[Nº Historia], [Detalle H/C].FechaAtencion, [Detalle H/C].Peso, [Detalle H/C].Temperatura, [Detalle H/C].Sintomas, [Detalle H/C].Diagnostico, [Detalle H/C].Tratamiento, Citas.FechaCita, Citas.HoraCita, [Detalle H/C].Item, [Detalle H/C].id FROM Citas INNER JOIN [Detalle H/C] ON Citas.Id = [Detalle H/C].id WHERE [Detalle H/C].[Nº HISTORIA]='" + Trim(CADENA) + "' ORDER BY ITEM", cn, adOpenStatic, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Nº Historia|<Fecha Atención|<Peso|<Temperatura|<Sintomas|<Diagnóstico|<Tratamiento|<Fecha Cita|<Hora Cita|<Item|<Id"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1100 'Nº Historia
  MSH.ColWidth(2) = 1400 'Fecha Atención
  MSH.ColWidth(3) = 2000 'Peso
  MSH.ColWidth(4) = 2000 'Temperatura
  MSH.ColWidth(5) = 2000 'Sintomas
  MSH.ColWidth(6) = 2000 'Diagnostico
  MSH.ColWidth(7) = 2000 'Tratamiento
  MSH.ColWidth(8) = 1200 'Fecha Cita
  MSH.ColWidth(9) = 1200 'Hora Cita
  MSH.ColWidth(10) = 0  'Item
  MSH.ColWidth(11) = 0  'ID
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Function codigodetalleHISTO(NHIS As String) As String
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "select max(ITEM) from [Detalle H/C] WHERE [Nº HISTORIA]='" + NHIS + "'", cn, adLockReadOnly, adCmdText
  REFRESCAR rs
  If rs.RecordCount = 0 Then
  codigodetalleHISTO = Format(1, String(10, "0"))
  Set rs = Nothing
  Exit Function
  End If
  codigodetalleHISTO = Format$(Val(IIf(IsNull(rs(0)), 1, rs(0))) + 1, String(10, "0"))
  Set rs = Nothing
  Exit Function
Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function codigodetalleEXACOM(NHIS As String) As String
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "select max(FILA) from DETALLEEXAMENCOMPLEMENTARIO WHERE [Nº HISTORIA]='" + NHIS + "'", cn, adLockReadOnly, adCmdText
  REFRESCAR rs
  If rs.RecordCount = 0 Then
  codigodetalleEXACOM = Format(1, String(10, "0"))
  Set rs = Nothing
  Exit Function
  End If
  codigodetalleEXACOM = Format$(Val(IIf(IsNull(rs(0)), 1, rs(0))) + 1, String(10, "0"))
  Set rs = Nothing
  Exit Function
Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Sub P_RELLENALISTADETALLE_EXAMCOM(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, CADENA As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT * FROM DETALLEexamenComplemENtario WHERE [Nº HISTORIA]='" + Trim(CADENA) + "' ORDER BY FILA", cn, adOpenStatic, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Fecha Exámen|<Resultado|<Costo|<Nº Historia|<Fila"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1000 'Código
  MSH.ColWidth(2) = 1400 'Fecha Exámen
  MSH.ColWidth(3) = 4500 'Resultado
  MSH.ColWidth(4) = 1200 'Costo
  MSH.ColWidth(5) = 1200 'Nº Historia
  MSH.ColWidth(6) = 0 'Fila
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub P_RELLENALISTADETALLE_CITAS(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, CADENA As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT * FROM CITAS WHERE [Nº HISTORIA]='" + Trim(CADENA) + "' ORDER BY ID", cn, adOpenStatic, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Nº Historia|<Fecha|<Hora|<Motivo|<Id"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1200 'Nº Historia
  MSH.ColWidth(2) = 1000 'Fecha
  MSH.ColWidth(3) = 1300 'Hora
  MSH.ColWidth(4) = 5000 'Motivo
  MSH.ColWidth(5) = 0 'Id
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Function codigodetalleCITA(NHIS As String) As String
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "select max(ID) from CITAS", cn, adLockReadOnly, adCmdText
  REFRESCAR rs
  If rs.RecordCount = 0 Then
  codigodetalleCITA = Format(1, String(10, "0"))
  Set rs = Nothing
  Exit Function
  End If
  codigodetalleCITA = Format$(Val(IIf(IsNull(rs(0)), 1, rs(0))) + 1, String(10, "0"))
  Set rs = Nothing
  Exit Function
Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Sub P_RELLENALISTASERVICIOS(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, Optional ByVal CADENA$)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT * FROM SERVICIOS", cn, adOpenStatic, adLockReadOnly
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT * FROM SERVICIOS WHERE DESSERVICIO LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly
  End If
    REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Servicio|>Costo"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1100
  MSH.ColWidth(2) = 4400
  MSH.ColWidth(3) = 1200
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub Centrar_Objeto(f As Object)
    f.Move (Screen.Width - f.Width) \ 2, 0
End Sub
Public Function GenerarCodigo(Consulta As String, ByVal Numero As Double) As String
On Local Error GoTo TT
    Dim rs As New ADODB.Recordset
    rs.Open Consulta, cn, adOpenForwardOnly, adLockReadOnly, adCmdText
    GenerarCodigo = Format$(Val(IIf(IsNull(rs(0)) = True, "0", rs(0))) + 1, String(Numero, "0"))
    Set rs = Nothing
    Exit Function
TT:
    MsgBox "Descripción=> " + Err.Description + Chr(13) + "Error Nº " + Trim$(Err.Number) + Chr(13) + "Procedimiento=> " + "GenerarCodigo", vbCritical, "Cristiania"
End Function
Public Sub prellenacargos(ByRef MSH As Object, Optional ByVal I As Integer = 0, Optional ByVal x As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If I = 0 Then
    rs.Open "Cargos", cn, adOpenForwardOnly, adLockReadOnly, adCmdTable
  ElseIf I = 1 Then
    rs.Open "select * from Cargos where descargo like '%" + Trim$(x) + "%'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  End If
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Cargo"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 900 'Código
  MSH.ColWidth(2) = 5000 'Cargo
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub prellenaUsuarios(ByRef MSH As Object, Optional ByVal I As Integer = 0, Optional ByVal x As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If I = 0 Then 'POR TODOS
    rs.Open "SELECT Usuarios.idusuario, Usuarios.nomusu,  Usuarios.idcargo, Cargos.descargo, Usuarios.idtipo, TipoUsua.Destipo, Usuarios.Nombres, Usuarios.Apellidos, Usuarios.DNI, Usuarios.Telefono, Usuarios.Email, format(Usuarios.Fecnac,'dd/mm/yyyy'), Usuarios.NomDistrito,Usuarios.passwo FROM Cargos INNER JOIN (TipoUsua INNER JOIN Usuarios ON TipoUsua.idtipo = Usuarios.idtipo) ON Cargos.idcargo = Usuarios.idcargo", cn, adOpenForwardOnly, adLockReadOnly
  ElseIf I = 1 Then 'POR DNI
    rs.Open "SELECT Usuarios.idusuario, Usuarios.nomusu,  Usuarios.idcargo, Cargos.descargo, Usuarios.idtipo, TipoUsua.Destipo, Usuarios.Nombres, Usuarios.Apellidos,  Usuarios.DNI, Usuarios.Telefono, Usuarios.Email, format(Usuarios.Fecnac,'dd/mm/yyyy'), Usuarios.NomDistrito,Usuarios.passwo FROM Cargos INNER JOIN (TipoUsua INNER JOIN Usuarios ON TipoUsua.idtipo = Usuarios.idtipo) ON Cargos.idcargo = Usuarios.idcargo where dni like '%" + Trim$(x) + "%'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf I = 2 Then 'POR NOMBRE
    rs.Open "SELECT Usuarios.idusuario, Usuarios.nomusu,  Usuarios.idcargo, Cargos.descargo, Usuarios.idtipo, TipoUsua.Destipo, Usuarios.Nombres, Usuarios.Apellidos,  Usuarios.DNI, Usuarios.Telefono, Usuarios.Email, format(Usuarios.Fecnac,'dd/mm/yyyy'), Usuarios.NomDistrito,Usuarios.passwo FROM Cargos INNER JOIN (TipoUsua INNER JOIN Usuarios ON TipoUsua.idtipo = Usuarios.idtipo) ON Cargos.idcargo = Usuarios.idcargo where Nombres like '%" + Trim$(x) + "%'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf I = 3 Then 'POR APELLIDO
    rs.Open "SELECT Usuarios.idusuario, Usuarios.nomusu,  Usuarios.idcargo, Cargos.descargo, Usuarios.idtipo, TipoUsua.Destipo, Usuarios.Nombres, Usuarios.Apellidos,  Usuarios.DNI, Usuarios.Telefono, Usuarios.Email, format(Usuarios.Fecnac,'dd/mm/yyyy'), Usuarios.NomDistrito,Usuarios.passwo FROM Cargos INNER JOIN (TipoUsua INNER JOIN Usuarios ON TipoUsua.idtipo = Usuarios.idtipo) ON Cargos.idcargo = Usuarios.idcargo where Apellidos like '%" + Trim$(x) + "%'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf I = 4 Then 'POR DISTRITO
    rs.Open "SELECT Usuarios.idusuario, Usuarios.nomusu,  Usuarios.idcargo, Cargos.descargo, Usuarios.idtipo, TipoUsua.Destipo, Usuarios.Nombres, Usuarios.Apellidos,  Usuarios.DNI, Usuarios.Telefono, Usuarios.Email, format(Usuarios.Fecnac,'dd/mm/yyyy'), Usuarios.NomDistrito,Usuarios.passwo FROM Cargos INNER JOIN (TipoUsua INNER JOIN Usuarios ON TipoUsua.idtipo = Usuarios.idtipo) ON Cargos.idcargo = Usuarios.idcargo where NomDistrito like '%" + Trim$(x) + "%'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf I = 5 Then 'POR USUARIO
    rs.Open "SELECT Usuarios.idusuario, Usuarios.nomusu,  Usuarios.idcargo, Cargos.descargo, Usuarios.idtipo, TipoUsua.Destipo, Usuarios.Nombres, Usuarios.Apellidos,  Usuarios.DNI, Usuarios.Telefono, Usuarios.Email,format(Usuarios.Fecnac,'dd/mm/yyyy'), Usuarios.NomDistrito,Usuarios.passwo FROM Cargos INNER JOIN (TipoUsua INNER JOIN Usuarios ON TipoUsua.idtipo = Usuarios.idtipo) ON Cargos.idcargo = Usuarios.idcargo where nomusu like '%" + Trim$(x) + "%'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  End If
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Usuario|<IdCargo|<Cargo|<IdTipo|<Tipo|<Nombres|<Apellidos|<D.N.I|<Teléfono|<E-mail|<Fec-Nac|<Distrito|<Clave"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 900 'Código
  MSH.ColWidth(2) = 1300 'Usuario
  MSH.ColWidth(3) = 0 'IdCargo
  MSH.ColWidth(4) = 2300 'Cargo
  MSH.ColWidth(5) = 0 'IdTipo
  MSH.ColWidth(6) = 1700 'Tipo
  MSH.ColWidth(7) = 2500 'Nombres
  MSH.ColWidth(8) = 2500 'Apellidos
  MSH.ColWidth(9) = 1200 'D.N.I
  MSH.ColWidth(10) = 1200 'Teléfono
  MSH.ColWidth(11) = 3500 'E-mail
  MSH.ColWidth(12) = 1300 'Fec-Nac
  MSH.ColWidth(13) = 3500 'Distrito
  MSH.ColWidth(14) = 0 'Clave
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Property Get prellenaProdutos(ByRef MSH As Object, Optional ByVal I As Integer = 0, Optional ByVal x As String) As Double
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If I = 0 Then 'POR TODOS
    rs.Open "SELECT Productos.idproducto, Productos.nombre, Categorias.idcategoria, Categorias.descategoria, SubCategorias.idsubcategoria, SubCategorias.dessubcategoria, Marcas.idmarca, Marcas.desmarca, Productos.stockminimo, Productos.stockmaximo, Productos.cantidad, Productos.precio, Productos.subtotal, Productos.observacion FROM SubCategorias INNER JOIN (Marcas INNER JOIN (Categorias INNER JOIN Productos ON Categorias.idcategoria = Productos.idcategoria) ON Marcas.idmarca = Productos.idmarca) ON SubCategorias.idsubcategoria = Productos.idsubcategoria ORDER BY Productos.idproducto, Productos.nombre, Categorias.descategoria, Marcas.desmarca", cn, adOpenForwardOnly, adLockReadOnly
  ElseIf I = 1 Then 'POR CATEGORIA
    rs.Open "SELECT Productos.idproducto, Productos.nombre, Categorias.idcategoria, Categorias.descategoria, SubCategorias.idsubcategoria, SubCategorias.dessubcategoria, Marcas.idmarca, Marcas.desmarca, Productos.stockminimo, Productos.stockmaximo, Productos.cantidad, Productos.precio, Productos.subtotal, Productos.observacion FROM SubCategorias INNER JOIN (Marcas INNER JOIN (Categorias INNER JOIN Productos ON Categorias.idcategoria = Productos.idcategoria) ON Marcas.idmarca = Productos.idmarca) ON SubCategorias.idsubcategoria = Productos.idsubcategoria where DESCATEGORIA like '%" + Trim$(x) + "%' ORDER BY Productos.idproducto,Productos.nombre,Categorias.descategoria, Marcas.desmarca", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf I = 2 Then 'POR MARCA
    rs.Open "SELECT Productos.idproducto, Productos.nombre, Categorias.idcategoria, Categorias.descategoria, SubCategorias.idsubcategoria, SubCategorias.dessubcategoria, Marcas.idmarca, Marcas.desmarca, Productos.stockminimo, Productos.stockmaximo, Productos.cantidad, Productos.precio, Productos.subtotal, Productos.observacion FROM SubCategorias INNER JOIN (Marcas INNER JOIN (Categorias INNER JOIN Productos ON Categorias.idcategoria = Productos.idcategoria) ON Marcas.idmarca = Productos.idmarca) ON SubCategorias.idsubcategoria = Productos.idsubcategoria where DESMARCA like '%" + Trim$(x) + "%' ORDER BY Productos.idproducto,Productos.nombre,Categorias.descategoria, Marcas.desmarca", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  ElseIf I = 3 Then 'POR DESCRIPCION
    rs.Open "SELECT Productos.idproducto, Productos.nombre, Categorias.idcategoria, Categorias.descategoria, SubCategorias.idsubcategoria, SubCategorias.dessubcategoria, Marcas.idmarca, Marcas.desmarca, Productos.stockminimo, Productos.stockmaximo, Productos.cantidad, Productos.precio, Productos.subtotal, Productos.observacion FROM SubCategorias INNER JOIN (Marcas INNER JOIN (Categorias INNER JOIN Productos ON Categorias.idcategoria = Productos.idcategoria) ON Marcas.idmarca = Productos.idmarca) ON SubCategorias.idsubcategoria = Productos.idsubcategoria where NOMBRE like '%" + Trim$(x) + "%' ORDER BY Productos.idproducto,Productos.nombre,Categorias.descategoria, Marcas.desmarca", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  End If
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Property
  End If
  prellenaProdutos = rs.RecordCount
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Descripión|<IdCategoría|<Categoría|<IdSubCategoría|<SubCategoría|<IdMarca|<Editorial|<Stok Mín.|<Stock Máx.|<Stock|<Precio|<SubTotal|<Observación"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1000 'Código
  MSH.ColWidth(2) = 3500 'Descripión
  MSH.ColWidth(3) = 0 'IdCategoría
  MSH.ColWidth(4) = 1800 'Categoría
  MSH.ColWidth(5) = 0 'IdSubCategoría
  MSH.ColWidth(6) = 1800 'SubCategoría
  MSH.ColWidth(7) = 0 'IdMarca
  MSH.ColWidth(8) = 1800 'Editorial
  MSH.ColWidth(9) = 1100 'Stok Mín.
  MSH.ColWidth(10) = 1100 'Stock Máx.
  MSH.ColWidth(11) = 1000 'Cantidad
  MSH.ColWidth(12) = 1200 'Precio
  MSH.ColWidth(13) = 0 'SubTotal
  MSH.ColWidth(14) = 3500 'Observación
Exit Property
L:
MsgBox Err.Description, vbCritical
End Property
Public Sub P_RELLENALISTAMARCAS(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, Optional ByVal CADENA$)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "MARCAS", cn, adOpenStatic, adLockReadOnly, adCmdTable
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT * FROM MARCAS WHERE DESMARCA LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  End If
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Editorial"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1100
  MSH.ColWidth(2) = 4400
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Function YaExisteCargoN(ByVal des As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select descargo from cargos where descargo='" + Trim$(des) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteCargoN = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteCargoN = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function YaExisteCargoM(ByVal des As String, ByVal IDC As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select descargo from cargos where descargo='" + Trim$(des) + "' AND idcargo<>'" + Trim$(IDC) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteCargoM = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteCargoM = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function YaExisteMarcaN(ByVal des As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select desmarca from marcas where desmarca='" + Trim$(des) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteMarcaN = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteMarcaN = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function YaExisteMarcaM(ByVal des As String, ByVal IDC As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select desmarca from marcas where desmarca='" + Trim$(des) + "' AND idmarca<>'" + Trim$(IDC) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteMarcaM = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteMarcaM = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Sub P_RELLENALISTACategorias(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, Optional ByVal CADENA$)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "Categorias", cn, adOpenStatic, adLockReadOnly, adCmdTable
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT * FROM Categorias WHERE descategoria LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  End If
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Categoría"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1100
  MSH.ColWidth(2) = 4400
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Function YaExisteCategoriaN(ByVal des As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select descategoria from categorias where descategoria='" + Trim$(des) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteCategoriaN = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteCategoriaN = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function YaExisteCategoriaM(ByVal des As String, ByVal IDC As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select descategoria from categorias where descategoria='" + Trim$(des) + "' AND idcategoria<>'" + Trim$(IDC) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteCategoriaM = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteCategoriaM = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Sub P_RELLENALISTAPROVEEDORES(ByRef MSH As MSHFlexGrid, Optional CRITERIOS As Integer = 0, Optional ByVal CADENA$)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 0 Then 'TODOS
    rs.Open "PROVEEDORES", cn, adOpenStatic, adLockReadOnly, adCmdTable
  ElseIf CRITERIOS = 1 Then 'POR RUC
    rs.Open "SELECT * FROM PROVEEDORES WHERE RUC LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIOS = 2 Then 'POR RAZON SOCIAL
    rs.Open "SELECT * FROM PROVEEDORES WHERE razonsocial LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIOS = 3 Then 'POR CONTACTO
    rs.Open "SELECT * FROM PROVEEDORES WHERE nombrecontacto LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIOS = 4 Then 'POR DISTRITO
    rs.Open "SELECT * FROM PROVEEDORES WHERE NomDistrito LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  End If
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Razón Social|<R.U.C|<Contacto|<Distrito|<Dirección|<Teléfono|<Celular|<E-mail|<Web-Site"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1100 'Código
  MSH.ColWidth(2) = 4000 'Razón Social
  MSH.ColWidth(3) = 1300 'R.U.C
  MSH.ColWidth(4) = 3200 'Contacto
  MSH.ColWidth(5) = 3200 'Distrito
  MSH.ColWidth(6) = 3200 'Dirección
  MSH.ColWidth(7) = 2200 'Teléfono
  MSH.ColWidth(8) = 2200 'Celular
  MSH.ColWidth(9) = 3500 'E-mail
  MSH.ColWidth(10) = 3500 'Web-Site
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Function YaExisteProveedorN(ByVal des As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select razonsocial from proveedores where razonsocial='" + Trim$(des) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteProveedorN = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteProveedorN = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function YaExisteProveedorM(ByVal des As String, ByVal IDC As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select razonsocial from proveedores where razonsocial='" + Trim$(des) + "' AND idproveedor<>'" + Trim$(IDC) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteProveedorM = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteProveedorM = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Sub P_RELLENALISTAMotivo(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, Optional ByVal CADENA$)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "motivo", cn, adOpenStatic, adLockReadOnly, adCmdTable
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT * FROM motivo WHERE desmotivo LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  End If
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Motivo"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1100
  MSH.ColWidth(2) = 4400
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Function YaExisteMotivoN(ByVal des As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select desmotivo from motivo where desmotivo='" + Trim$(des) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteMotivoN = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteMotivoN = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function YaExisteMotivoM(ByVal des As String, ByVal IDC As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select desmotivo from motivo where desmotivo='" + Trim$(des) + "' AND idmarca<>'" + Trim$(IDC) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteMotivoM = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteMotivoM = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function DevuelveIGV() As Double
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT IGV FROM TABIGV", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
REFRESCAR T
If T.RecordCount = 0 Then
  DevuelveIGV = 19
  Set T = Nothing
End If
DevuelveIGV = T!igv
Set T = Nothing
Exit Function
L:
MsgBox Err.Description
End Function
Public Function GuardaIGV(igv As String) As Double
On Local Error GoTo L
cn.Execute "update TABIGV SET IGV=" + igv, GuardaIGV
GuardaIGV = 1
Exit Function
L:
MsgBox Err.Description
End Function
Public Function DevuelveSerie(Optional ByVal DATO As String = "I") As String
If DATO = "I" Then
x = "SELECT serie FROM TABSERIES WHERE Documento='Nota de Ingreso'"
ElseIf DATO = "S" Then
x = "SELECT serie FROM TABSERIES WHERE Documento='Nota de Salida'"
ElseIf DATO = "F" Then
x = "SELECT serie FROM TABSERIES WHERE Documento='Factura'"
ElseIf DATO = "B" Then
x = "SELECT serie FROM TABSERIES WHERE Documento='Boleta'"
End If
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open x, cn, adOpenForwardOnly, adLockReadOnly, adCmdText
Call REFRESCAR(T)
If T.RecordCount = 0 Then
DevuelveSerie = "001"
Set T = Nothing
End If
DevuelveSerie = T(0)
Set T = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Function DevuelveIdMotivo(motivo As String) As String
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT IDMOTIVO FROM MOTIVO WHERE DESMOTIVO='" + motivo + "'", cn, adOpenForwardOnly, adLockReadOnly
REFRESCAR T
If T.RecordCount = 0 Then
  Set T = Nothing
  Exit Function
End If
DevuelveIdMotivo = T(0)
Set T = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Function DevuelveIdDocumento(doc As String) As String
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT iddocumento FROM documentos WHERE desdocumento='" + doc + "'", cn, adOpenForwardOnly, adLockReadOnly
REFRESCAR T
If T.RecordCount = 0 Then
  Set T = Nothing
  Exit Function
End If
DevuelveIdDocumento = T(0)
Set T = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Function P_RELLENADETALLEKARDEX(ByRef MSH As MSHFlexGrid, ByVal NKard As String) As Double
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "SELECT DetalleKardex.nkardex, DetalleKardex.nitem, DetalleKardex.idproducto,  Categorias.descategoria+' '+ Marcas.desmarca+' '+Productos.nombre, DetalleKardex.cantidad, DetalleKardex.precio, DetalleKardex.subtotal FROM Categorias INNER JOIN (Marcas INNER JOIN (Productos INNER JOIN DetalleKardex ON Productos.idproducto = DetalleKardex.idproducto) ON Marcas.idmarca = Productos.idmarca) ON Categorias.idcategoria = Productos.idcategoria WHERE DetalleKardex.nkardex='" + NKard + "' ORDER BY 2", cn, adOpenStatic, adLockReadOnly, adCmdText
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Function
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Id|<Nº Item|<IdProducto|<Descripción|>Cantidad|>Precio|>SubTotal"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 0 'Id
  MSH.ColWidth(2) = 1000 'Nº Item
  MSH.ColWidth(3) = 0 'IdProducto
  MSH.ColWidth(4) = 3500 'Descripción
  MSH.ColWidth(5) = 1400 'Cantidad
  MSH.ColWidth(6) = 1400 'Precio
  MSH.ColWidth(7) = 1400 'SubTotal
  P_RELLENADETALLEKARDEX = 0
  For I = 1 To MSH.Rows - 1
    P_RELLENADETALLEKARDEX = P_RELLENADETALLEKARDEX + Val(MSH.TextMatrix(I, 7))
  Next
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Function precioPRO(codprod As String) As Double
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT precio FROM productos WHERE idproducto='" + codprod + "'", cn, adOpenForwardOnly, adLockReadOnly
REFRESCAR T
If T.RecordCount = 0 Then
  Set T = Nothing
  precioPRO = 0
  Exit Function
End If
precioPRO = T(0)
Set T = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Sub P_KARDEXBUSQUEDANOTAINGR(ByRef MSH As MSHFlexGrid, ByVal CRITERIO As String, Optional ByVal DATO As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIO = 1 Then 'TODOS
    rs.Open "SELECT RIGHT(Kardex.nkardex,11), Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Proveedores.razonsocial,Kardex.descuento FROM (Motivo INNER JOIN (Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN Proveedores ON Kardex.idproveedor = Proveedores.idproveedor WHERE Kardex.tipo_mov='I' order by Kardex.nkardex", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 2 Then 'POR Nº Ingreso
    rs.Open "SELECT RIGHT(Kardex.nkardex,11), Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Proveedores.razonsocial,Kardex.descuento FROM (Motivo INNER JOIN (Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN Proveedores ON Kardex.idproveedor = Proveedores.idproveedor WHERE Kardex.tipo_mov='I' AND RIGHT(Kardex.nkardex,11) LIKE '%" + DATO + "%' order by Kardex.nkardex", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 3 Then 'POR MOTIVO
    rs.Open "SELECT RIGHT(Kardex.nkardex,11), Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Proveedores.razonsocial,Kardex.descuento FROM (Motivo INNER JOIN (Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN Proveedores ON Kardex.idproveedor = Proveedores.idproveedor WHERE Kardex.tipo_mov='I' AND  Motivo.desmotivo LIKE '%" + DATO + "%' order by Kardex.nkardex", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 4 Then 'POR Nº DOCUMENTO
    rs.Open "SELECT RIGHT(Kardex.nkardex,11), Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Proveedores.razonsocial,Kardex.descuento FROM (Motivo INNER JOIN (Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN Proveedores ON Kardex.idproveedor = Proveedores.idproveedor WHERE Kardex.tipo_mov='I' AND Kardex.ndocumento LIKE '%" + DATO + "%' order by Kardex.nkardex", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 5 Then 'POR Nº FECHA
    rs.Open "SELECT RIGHT(Kardex.nkardex,11), Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Proveedores.razonsocial,Kardex.descuento FROM (Motivo INNER JOIN (Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN Proveedores ON Kardex.idproveedor = Proveedores.idproveedor WHERE Kardex.tipo_mov='I' AND FORMAT(Kardex.fechamovin,'dd/mm/yyyy') LIKE '%" + DATO + "%' order by Kardex.nkardex", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 6 Then 'POR PROVEEDOR
    rs.Open "SELECT RIGHT(Kardex.nkardex,11), Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Proveedores.razonsocial,Kardex.descuento FROM (Motivo INNER JOIN (Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN Proveedores ON Kardex.idproveedor = Proveedores.idproveedor WHERE Kardex.tipo_mov='I' AND Proveedores.razonsocial LIKE '%" + DATO + "%' order by Kardex.nkardex", cn, adOpenStatic, adLockReadOnly, adCmdText
  End If
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Nº Ingreso|<Motivo|<TipoMovimiento|<Documento|<Nº Documento|<Fecha|<Guía|<Proveedor|<Descuento"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1200 'Nº Ingreso
  MSH.ColWidth(2) = 3000 'Motivo
  MSH.ColWidth(3) = 0 'TipoMovimiento
  MSH.ColWidth(4) = 2000 'Documento
  MSH.ColWidth(5) = 1400 'Nº Documento
  MSH.ColWidth(6) = 1200 'Fecha
  MSH.ColWidth(7) = 2000 'Guía
  MSH.ColWidth(8) = 4000 'Proveedor
  MSH.ColWidth(9) = 1000 'Descuento
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub P_KARDEXBUSQUEDANOTASALI(ByRef MSH As MSHFlexGrid, ByVal CRITERIO As String, Optional ByVal DATO As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIO = 1 Then 'TODOS
    rs.Open "SELECT Right(Kardex.nkardex,11) AS Codigo, Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Dueño.NomDueño+' '+Dueño.ApeDueño AS Cliente, promotores.nombres,Kardex.moneda,Kardex.tipcam FROM (Motivo INNER JOIN ((Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) INNER JOIN Dueño ON Kardex.CodDueño = Dueño.coddueño) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN promotores ON Kardex.idpromotor = promotores.idpromotor WHERE (((Kardex.tipo_mov)='S')) order by RIGHT(Kardex.nkardex,11)", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 2 Then 'POR Nº Ingreso
    rs.Open "SELECT Right(Kardex.nkardex,11) AS Codigo, Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Dueño.NomDueño+' '+Dueño.ApeDueño AS Cliente, promotores.nombres,Kardex.moneda,Kardex.tipcam FROM (Motivo INNER JOIN ((Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) INNER JOIN Dueño ON Kardex.CodDueño = Dueño.coddueño) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN promotores ON Kardex.idpromotor = promotores.idpromotor WHERE (((Kardex.tipo_mov)='S')) AND RIGHT(Kardex.nkardex,11) LIKE '%" + DATO + "%' order by RIGHT(Kardex.nkardex,11)", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 3 Then 'POR MOTIVO
    rs.Open "SELECT Right(Kardex.nkardex,11) AS Codigo, Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Dueño.NomDueño+' '+Dueño.ApeDueño AS Cliente, promotores.nombres,Kardex.moneda,Kardex.tipcam FROM (Motivo INNER JOIN ((Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) INNER JOIN Dueño ON Kardex.CodDueño = Dueño.coddueño) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN promotores ON Kardex.idpromotor = promotores.idpromotor WHERE Kardex.tipo_mov='S' AND  Motivo.desmotivo LIKE '%" + DATO + "%' order by RIGHT(Kardex.nkardex,11)", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 4 Then 'POR Nº DOCUMENTO
    rs.Open "SELECT Right(Kardex.nkardex,11) AS Codigo, Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Dueño.NomDueño+' '+Dueño.ApeDueño AS Cliente, promotores.nombres,Kardex.moneda,Kardex.tipcam FROM (Motivo INNER JOIN ((Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) INNER JOIN Dueño ON Kardex.CodDueño = Dueño.coddueño) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN promotores ON Kardex.idpromotor = promotores.idpromotor WHERE Kardex.tipo_mov='S' AND Kardex.ndocumento LIKE '%" + DATO + "%' order by RIGHT(Kardex.nkardex,11)", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 5 Then 'POR Nº FECHA
    rs.Open "SELECT Right(Kardex.nkardex,11) AS Codigo, Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Dueño.NomDueño+' '+Dueño.ApeDueño AS Cliente, promotores.nombres,Kardex.moneda,Kardex.tipcam FROM (Motivo INNER JOIN ((Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) INNER JOIN Dueño ON Kardex.CodDueño = Dueño.coddueño) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN promotores ON Kardex.idpromotor = promotores.idpromotor WHERE Kardex.tipo_mov='S' AND FORMAT(Kardex.fechamovin,'dd/mm/yyyy') LIKE '%" + DATO + "%' order by RIGHT(Kardex.nkardex,11)", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIO = 6 Then 'POR CLIENTE
    rs.Open "SELECT Right(Kardex.nkardex,11) AS Codigo, Motivo.desmotivo, Kardex.tipo_mov, Documentos.desdocumento, Kardex.ndocumento, Format(Kardex.fechamovin,'dd/mm/yyyy') AS Expr1, Kardex.guia, Dueño.NomDueño+' '+Dueño.ApeDueño AS Cliente, promotores.nombres,Kardex.moneda,Kardex.tipcam FROM (Motivo INNER JOIN ((Documentos INNER JOIN Kardex ON Documentos.iddocumento = Kardex.iddocumento) INNER JOIN Dueño ON Kardex.CodDueño = Dueño.coddueño) ON Motivo.idmotivo = Kardex.idmotivo) INNER JOIN promotores ON Kardex.idpromotor = promotores.idpromotor WHERE Kardex.tipo_mov='S' AND Dueño.NomDueño+' '+Dueño.ApeDueño LIKE '%" + DATO + "%' order by RIGHT(Kardex.nkardex,11)", cn, adOpenStatic, adLockReadOnly, adCmdText
  End If
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Nº Ingreso|<Motivo|<TipoMovimiento|<Documento|<Nº Documento|<Fecha|<Guía|<Promotor|<Moneda|<Tipo Cambio"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1200 'Nº Ingreso
  MSH.ColWidth(2) = 3000 'Motivo
  MSH.ColWidth(3) = 0 'TipoMovimiento
  MSH.ColWidth(4) = 2000 'Documento
  MSH.ColWidth(5) = 1400 'Nº Documento
  MSH.ColWidth(6) = 1200 'Fecha
  MSH.ColWidth(7) = 2000 'Guía
  MSH.ColWidth(8) = 4000 'Cliente
  MSH.ColWidth(9) = 2500 'Promotor
  MSH.ColWidth(10) = 0  'Moneda
  MSH.ColWidth(11) = 0  'Tipo Cambio
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Property Get Devuelve_IdCliente(ByVal x As String) As String
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT CodDueño FROM Dueño WHERE NomDueño+' '+ApeDueño='" + x + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Property
  End If
  Devuelve_IdCliente = T(0)
  Set T = Nothing
  Exit Property
L:
  MsgBox Err.Description, vbCritical
End Property
Public Property Get Devuelve_NomApeCliente(ByVal x As String) As String
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT NomDueño+' '+ApeDueño FROM Dueño WHERE CodDueño='" + x + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Property
  End If
  Devuelve_NomApeCliente = T(0)
  Set T = Nothing
  Exit Property
L:
  MsgBox Err.Description, vbCritical
End Property
Public Sub Devuelve_NomUsuas(ByVal x As String, nomusu As String, NOMBRESAPELLIDOS As String)
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT nomusu,nombres+' '+apellidos FROM usuarios WHERE idusuario='" + x + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Sub
  End If
  nomusu = T(0)
  NOMBRESAPELLIDOS = T(1)
  Set T = Nothing
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
Public Function STOCK_INGRESAR(ByVal IDPRO As String, ByVal CANTIDAD As Double, ByRef stockmax As Double, ByRef stock As Double) As Double
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT stockmaximo,cantidad FROM PRODUCTOS WHERE idproducto='" + IDPRO + "'", cn, adOpenForwardOnly, adLockOptimistic, adCmdText
REFRESCAR T
If T.RecordCount = 0 Then
  Set T = Nothing
  STOCK_INGRESAR = -1
  Exit Function
End If
  stock = T!CANTIDAD
If T!CANTIDAD + CANTIDAD > T!stockmaximo Then
  stockmax = T!stockmaximo
  stock = T!CANTIDAD
  STOCK_INGRESAR = T!stockmaximo - T!CANTIDAD
  Else
  STOCK_INGRESAR = -1
End If
Set T = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function

Public Function STOCK_SALIR(ByVal IDPRO As String, ByVal CANTIDAD As Double, ByRef stockmin As Double, ByRef stock As Double) As Double
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT stockminimo,cantidad FROM PRODUCTOS WHERE idproducto='" + IDPRO + "'", cn, adOpenForwardOnly, adLockOptimistic, adCmdText
REFRESCAR T
If T.RecordCount = 0 Then
  Set T = Nothing
  STOCK_SALIR = -1
  Exit Function
End If
  stock = T!CANTIDAD
If CANTIDAD > T!CANTIDAD Then
  stockmin = T!stockminimo
  stock = T!CANTIDAD
  STOCK_SALIR = T!CANTIDAD
  Else
  STOCK_SALIR = -1
End If
Set T = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Function NOMBREM(CODMAS As String) As String
On Local Error GoTo L
Dim rs As New ADODB.Recordset
rs.Open "SELECT [NOMMASCOTA] AS Expr1 FROM MASCOTAS where CODMASCOTA='" + CODMAS + "'", cn, adOpenForwardOnlyM, adLockReadOnly
REFRESCAR rs
If rs.RecordCount = 0 Then
Set rs = Nothing
Exit Function
End If
NOMBREM = rs(0)
Set rs = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Function NOMBREC(coddue As String) As String
On Local Error GoTo L
Dim rs As New ADODB.Recordset
rs.Open "SELECT [NomDueño]+' '+[APEDUEÑO] AS Expr1 FROM Dueño where coddueño='" + coddue + "'", cn, adOpenForwardOnly, adLockReadOnly
REFRESCAR rs
If rs.RecordCount = 0 Then
Set rs = Nothing
Exit Function
End If
NOMBREC = rs(0)
Set rs = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Function pGuardarSeries(ByVal bs1 As String, ByVal bs2 As String, ByVal fs1 As String, ByVal fs2 As String, ByRef txtrecibo) As Double
On Local Error GoTo L
  cn.Execute "UPDATE TABSERIES SET serie='" + bs1 + "',serie2='" + bs2 + "' WHERE Documento='Boleta'", pGuardarSeries
  cn.Execute "UPDATE TABSERIES SET serie='" + fs1 + "',serie2='" + fs2 + "' WHERE Documento='Factura'", pGuardarSeries
  cn.Execute "UPDATE TABSERIES SET serie2='" + txtrecibo + "' WHERE Documento='Recibo'", pGuardarSeries
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Sub MuestraSeries(ByRef txts As Object, ByRef txts2 As Object, ByRef txtserie As Object, ByRef txtserie2 As Object, ByRef txtrecibo As Object)
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT serie,serie2 FROM TABSERIES WHERE Documento='Boleta'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
txts = T!serie
txts2 = T!serie2
If T.State = adStateOpen Then T.Close
T.Open "SELECT serie,serie2 FROM TABSERIES WHERE Documento='Factura'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
txtserie = T!serie
txtserie2 = T!serie2
If T.State = adStateOpen Then T.Close
T.Open "SELECT serie2 FROM TABSERIES WHERE Documento='Recibo'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
txtrecibo = T!serie2
Set T = Nothing
Exit Sub
L:
MsgBox Err.Description, vbCritical
If T.State = adStateOpen Then Set T = Nothing
End Sub
Public Function GenerarNDocumento(ByVal FB As String) As String
On Local Error GoTo TT
    Dim rs As New ADODB.Recordset
    rs.Open "select serie,serie2 from tabseries where Documento='" + FB + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
    GenerarNDocumento = rs!serie + "-" + Format$(Val(rs!serie2) + 1, String(Len(rs!serie2), "0"))
    Set rs = Nothing
    Exit Function
TT:
    MsgBox "Descripción=> " + Err.Description + Chr(13) + "Error Nº " + Trim$(Err.Number) + Chr(13) + "Procedimiento=> " + "GenerarCodigo", vbCritical, "Cristiania"
End Function
Public Sub RelleNAlISTAproveedorporprdocuto(ByVal idprov As String, ByRef MSH As MSHFlexGrid)
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT ProveedorXProducto.idproducto, Productos.nombre, Categorias.descategoria,  SubCategorias.dessubcategoria,Marcas.desmarca, ProveedorXProducto.idproveedor FROM Proveedores INNER JOIN ((SubCategorias INNER JOIN (Marcas INNER JOIN (Categorias INNER JOIN Productos ON Categorias.idcategoria = Productos.idcategoria) ON Marcas.idmarca = Productos.idmarca) ON SubCategorias.idsubcategoria = Productos.idsubcategoria) INNER JOIN ProveedorXProducto ON Productos.idproducto = ProveedorXProducto.idproducto) ON Proveedores.idproveedor = ProveedorXProducto.idproveedor WHERE ProveedorXProducto.idproveedor='" + idprov + "'", cn, adOpenForwardOnly, adLockOptimistic, adCmdText
REFRESCAR T
If T.RecordCount = 0 Then
  Set T = Nothing
  MSH.Rows = 2
  MSH.Cols = 2
  MSH.Clear
  Exit Sub
End If
  Set MSH.Recordset = T
  Set T = Nothing
  MSH.FormatString = "|<Código|<Descripción|<Categoría|<SubCategoría|<Marca|<IdProveedor"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1200 'Código
  MSH.ColWidth(2) = 3000 'Descripción
  MSH.ColWidth(3) = 3000 'Categoría
  MSH.ColWidth(4) = 3000 'SubCategoría
  MSH.ColWidth(5) = 3000 'Marca
  MSH.ColWidth(6) = 0 'IdProveedor
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub GuardarProductoXProveedor(ByVal idproducto As String, ByVal idproveedor As String)
On Local Error GoTo L
cn.Execute "DELETE * FROM ProveedorXProducto WHERE idproveedor='" + idproveedor + "' AND idproducto='" + idproducto + "'"
cn.Execute "INSERT INTO ProveedorXProducto(idproveedor,idproducto) VALUES('" + idproveedor + "','" + idproducto + "')"
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub P_RELLENALISTASUBCategorias(ByRef MSH As MSHFlexGrid, CRITERIOS As Integer, Optional ByVal CADENA$)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SubCategorias", cn, adOpenStatic, adLockReadOnly, adCmdTable
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT * FROM SubCategorias WHERE dessubcategoria LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  End If
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Sub-Categoría"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1100
  MSH.ColWidth(2) = 4400
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub


Public Function YaExisteSubCategoriaN(ByVal des As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select dessubcategoria from SubCategorias where dessubcategoria='" + Trim$(des) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteSubCategoriaN = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteSubCategoriaN = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function YaExisteSubCategoriaM(ByVal des As String, ByVal IDC As String) As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "Select dessubcategoria from SubCategorias where dessubcategoria='" + Trim$(des) + "' AND idsubcategoria<>'" + Trim$(IDC) + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    YaExisteSubCategoriaM = False
    Set T = Nothing
    Exit Function
  End If
  YaExisteSubCategoriaM = True
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function DevuelveInteres() As Double
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT Interes FROM TabInteres", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
REFRESCAR T
If T.RecordCount = 0 Then
  DevuelveInteres = 0
  Set T = Nothing
End If
DevuelveInteres = T!interes
Set T = Nothing
Exit Function
L:
MsgBox Err.Description
End Function
Public Function GuardaInteres(xInteres As String) As Double
On Local Error GoTo L
cn.Execute "update TabInteres SET Interes=" + xInteres, GuardaInteres
GuardaInteres = 1
Exit Function
L:
MsgBox Err.Description
End Function
Public Function GuardaMora(xmora As String) As Double
On Local Error GoTo L
cn.Execute "update TabMora SET Mora=" + xmora, GuardaMora
GuardaMora = 1
Exit Function
L:
MsgBox Err.Description
End Function
Public Function DevuelveMora() As Double
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT Mora FROM TabMora", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
REFRESCAR T
If T.RecordCount = 0 Then
  DevuelveMora = 0
  Set T = Nothing
End If
DevuelveMora = T!MORA
Set T = Nothing
Exit Function
L:
MsgBox Err.Description
End Function
Public Property Get EliminarTabla(ByVal codigo As String, _
                                  ByVal NomTabla As String, _
                                  ByVal NomCampo As String) As Long
On Local Error GoTo VerError
cn.Execute "Delete FROM " + NomTabla + " WHERE " + NomCampo + "='" + codigo + "'", EliminarTabla
Exit Property
VerError:
    MsgBox Err.Description, vbCritical
End Property
Public Function DevuelveIdProducto(prods As String) As String
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT Productos.idproducto FROM Marcas INNER JOIN (Categorias INNER JOIN Productos ON Categorias.idcategoria = Productos.idcategoria) ON Marcas.idmarca = Productos.idmarca where  categorias.descategoria+' '+ Marcas.desmarca+' '+ Productos.nombre='" + prods + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
REFRESCAR T
If T.RecordCount = 0 Then
  DevuelveIdProducto = ""
  Set T = Nothing
End If
DevuelveIdProducto = T!idproducto
Set T = Nothing
Exit Function
L:
MsgBox Err.Description
End Function
Public Sub p_RellenoDeta(ByRef MSH As MSHFlexGrid, ByVal txtidpago As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "SELECT FechaxCuotas.idpago, FechaxCuotas.cuota,format(FechaxCuotas.fechaapagar,'dd/mm/yyyy'), FechaxCuotas.valorxcuota, FechaxCuotas.estado, FechaxCuotas.restructuracion FROM FechaxCuotas where idpago='" + txtidpago + "'", cn, adOpenStatic, adLockReadOnly, adCmdText
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<IdPago|<Cuotas|<Fecha a Pagar|>Monto|<Estado|<Restructuración"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 0 'IdPago
  MSH.ColWidth(2) = 1000 'Cuotas
  MSH.ColWidth(3) = 1500 'Fecha a Pagar
  MSH.ColWidth(4) = 1500 'Monto
  MSH.ColWidth(5) = 1500 'Estado
  MSH.ColWidth(6) = 1500 'Restructuración
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Function DEVUELVEIDPAGO(NRE As String, idpago As String, CUOTA As String)
Dim T As New ADODB.Recordset
T.Open "SELECT IDPAGO,CUOTA FROM TB_PAGOS WHERE NRECIBO='" + NRE + "'", cn, adOpenForwardOnly, adLockReadOnly
REFRESCAR T
If T.RecordCount = 0 Then
  MsgBox "No Esta Registrado Nº Recibo :" + NRE, vbInformation
  Exit Function
End If
idpago = T!idpago
CUOTA = T!CUOTA
Set T = Nothing
End Function
Public Function ClienteDebe(ByVal NOMCLI As String) As String
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT distinct(FechaxCuotas.idpago) FROM Dueño INNER JOIN (TB_Deuda INNER JOIN FechaxCuotas ON TB_Deuda.idpago = FechaxCuotas.idpago) ON Dueño.CodDueño = TB_Deuda.CodDueño WHERE  Dueño.NomDueño+' '+ Dueño.ApeDueño='" + NOMCLI + "' AND  FechaxCuotas.estado='Sin Cancelar'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Function
  End If
  ClienteDebe = T(0)
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function GenerarNRECIBO() As String
On Local Error GoTo TT
    Dim rs As New ADODB.Recordset
    rs.Open "select serie2 from tabseries where Documento='Recibo'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
    GenerarNRECIBO = Format$(Val(rs!serie2) + 1, String(Len(rs!serie2), "0"))
    Set rs = Nothing
    Exit Function
TT:
    MsgBox "Descripción=> " + Err.Description + Chr(13) + "Error Nº " + Trim$(Err.Number) + Chr(13) + "Procedimiento=> " + "GenerarCodigo", vbCritical, "Cristiania"
End Function
Public Function DevuelveMorass(idpago As String, FECHACUOTA As String) As Double
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT MORAXC FROM TB_PAGOS WHERE IDPAGO='" + idpago + "' AND FECHACUOTA=#" + FECHACUOTA + "#", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    DevuelveMorass = 0#
    Set T = Nothing
    Exit Function
  End If
  DevuelveMorass = T(0)
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Function DevuelveNombresusuario(usu As String) As String
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT nombres +' '+apellidos FROM usuarios WHERE nomusu='" + usu + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    DevuelveNombresusuario = ""
    Set T = Nothing
    Exit Function
  End If
  DevuelveNombresusuario = T(0)
  Set T = Nothing
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Public Sub p_RellenoCUENTACORRIENTESSS(ByRef MSH As MSHFlexGrid, ByVal DOCUMENTO As String, ByVal NDOC As String, IDCLIENTE As String, credito As Object, deuda As Object, totalpagado As Object)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "SELECT * FROM CUENTACORRIENTE where ndocumento='" + NDOC + "' AND desdocumento='" + DOCUMENTO + "' AND CodDueño='" + IDCLIENTE + "'", cn, adOpenStatic, adLockReadOnly, adCmdText
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Cuota|<Fecha x Cuota|<Fecha a Pagar|>Nº Recibo|>Valor Cuota|>Mora|>Total Cuota|<Documento|<Nº Doc.|<Nombres Cliente|<Apellidos Cliente|<Anulado|<IdCliente|<Total a Pagar|<Nº Cuotas|<IdPago"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1000 'Cuota
  MSH.ColWidth(2) = 1200 'Fecha x
  MSH.ColWidth(3) = 1500 'Fecha a Pagar
  MSH.ColWidth(4) = 1500 'Nº Recibo
  MSH.ColWidth(5) = 1500 'Valor Cuota
  MSH.ColWidth(6) = 1500 'Mora
  MSH.ColWidth(7) = 1500 'Total Cuota
  MSH.ColWidth(8) = 0 'Documento
  MSH.ColWidth(9) = 0 'Nº Doc.
  MSH.ColWidth(10) = 0 'Nombres Cliente
  MSH.ColWidth(11) = 0 'Apellidos Cliente
  MSH.ColWidth(12) = 0 'Anulado
  MSH.ColWidth(13) = 0 'IdCliente
  MSH.ColWidth(14) = 0 'Total A Pagar
  MSH.ColWidth(15) = 0 'Nº Cuotas
  MSH.ColWidth(16) = 0 'IdPago
  MSH.ColWidth(17) = 0 '
  credito = CStr(Val(MSH.TextMatrix(1, 14)) * Val(MSH.TextMatrix(1, 15)))
  totalpagado = "0"
  For I = 1 To MSH.Rows - 1
     totalpagado = CStr(Val(totalpagado) + Val(MSH.TextMatrix(I, 7)))
  Next I
  deuda = CStr(Val(credito) - Val(totalpagado))
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Function p_devuelvevcresditos(ByVal DOCUMENTO As String, ByVal NDOC As String, IDCLIENTE As String, credito As Object, deuda As Object, totalpagado As Object) As String
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "SELECT tb_deuda.totalapagar, tb_deuda.ncuota, tb_deuda.coddueño FROM tb_deuda INNER JOIN documentos ON tb_deuda.iddocumento = documentos.iddocumento WHERE documentos.desdocumento='" + DOCUMENTO + "' AND tb_deuda.ndocumento='" + NDOC + "' AND tb_deuda.coddueño='" + IDCLIENTE + "'", cn, adOpenStatic, adLockReadOnly, adCmdText
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Function
  End If
  credito = CStr(Val(rs!totalapagar) * Val(rs!ncuota))
  p_devuelvevcresditos = CStr(rs!ncuota)
  totalpagado = "0"
  deuda = credito
  Set rs = Nothing
  Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Public Sub P_RELLENALISTAPROMOTORES(ByRef MSH As MSHFlexGrid, Optional CRITERIOS As Integer = 1, Optional ByVal CADENA$)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If CRITERIOS = 1 Then
    rs.Open "SELECT promotores.idpromotor, promotores.nombres, promotores.domicilio,  promotores.telefonos, comisiones.comision FROM comisiones INNER JOIN promotores ON comisiones.idcomision = promotores.idcomision", cn, adOpenStatic, adLockReadOnly, adCmdText
  ElseIf CRITERIOS = 2 Then
    rs.Open "SELECT promotores.idpromotor, promotores.nombres, promotores.domicilio,  promotores.telefonos, comisiones.comision FROM comisiones INNER JOIN promotores ON comisiones.idcomision = promotores.idcomision WHERE nombres LIKE '%" + CADENA + "%'", cn, adOpenStatic, adLockReadOnly, adCmdText
  End If
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Nombres|<Dirección|<Teléfono|<Comisión"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1100
  MSH.ColWidth(2) = 3000
  MSH.ColWidth(3) = 3000
  MSH.ColWidth(4) = 1400
  MSH.ColWidth(5) = 1400
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Sub P_RELLENALISTAcomisiones(ByRef MSH As MSHFlexGrid)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "comisiones", cn, adOpenStatic, adLockReadOnly, adCmdTable
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSH.Clear
    MSH.Cols = 2
    MSH.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSH.Recordset = rs
  Set rs = Nothing
  MSH.FormatString = "|<Código|<Desde|<Hasta|<Comisión %"
  MSH.ColWidth(0) = 0
  MSH.ColWidth(1) = 1100
  MSH.ColWidth(2) = 1000
  MSH.ColWidth(3) = 1000
  MSH.ColWidth(4) = 1000
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Public Property Get Devuelve_IdPromotor(ByVal x As String) As String
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT idpromotor FROM promotores WHERE nombres='" + x + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Property
  End If
  Devuelve_IdPromotor = T(0)
  Set T = Nothing
  Exit Property
L:
  MsgBox Err.Description, vbCritical
End Property
Public Property Get Devuelve_TipoCambio() As Double
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT cambio FROM tipocambio", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Property
  End If
  Devuelve_TipoCambio = T(0)
  Set T = Nothing
  Exit Property
L:
  MsgBox Err.Description, vbCritical
End Property
Public Property Get Devuelve_simbolo_de_TB_DEUDA(idpago As String) As Double
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT moneda FROM tb_deuda where idpago='" + idpago + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Property
  End If
  If T(0) = "1" Then Devuelve_simbolo_de_TB_DEUDA = "S/."
  If T(0) = "2" Then Devuelve_simbolo_de_TB_DEUDA = "$/."
  Set T = Nothing
  Exit Property
L:
  MsgBox Err.Description, vbCritical
End Property
Public Property Get Devuelve_IdComision(comision As String) As String
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT idcomision FROM comisiones where comision=" + comision, cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Property
  End If
  Devuelve_IdComision = T(0)
  Set T = Nothing
  Exit Property
L:
  MsgBox Err.Description, vbCritical
End Property
