VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmProveedores 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "PROVEEDORES"
   ClientHeight    =   10380
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   15075
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   8.25
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H00B0726D&
   Icon            =   "FrmProveedores.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   10380
   ScaleWidth      =   15075
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00B0726D&
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2775
      Left            =   120
      ScaleHeight     =   2715
      ScaleWidth      =   9435
      TabIndex        =   22
      Top             =   120
      Width           =   9495
      Begin VB.TextBox txtwebsite 
         Height          =   315
         Left            =   1320
         MaxLength       =   255
         TabIndex        =   6
         Top             =   2280
         Width           =   5175
      End
      Begin VB.TextBox txtemail 
         Height          =   315
         Left            =   1320
         MaxLength       =   255
         TabIndex        =   5
         Top             =   1920
         Width           =   5175
      End
      Begin VB.TextBox txtdireccion 
         Height          =   315
         Left            =   1320
         MaxLength       =   60
         TabIndex        =   4
         Top             =   1560
         Width           =   5175
      End
      Begin VB.ComboBox cmbdistrito 
         Height          =   315
         Left            =   1320
         Sorted          =   -1  'True
         TabIndex        =   3
         Top             =   1200
         Width           =   5175
      End
      Begin VB.CommandButton cmddistrito 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6480
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmProveedores.frx":030A
         Style           =   1  'Graphical
         TabIndex        =   31
         ToolTipText     =   "BUSCAR DISTRITO"
         Top             =   1200
         Width           =   375
      End
      Begin VB.TextBox txtcelular 
         Height          =   315
         Left            =   7440
         MaxLength       =   20
         TabIndex        =   8
         Top             =   840
         Width           =   1935
      End
      Begin VB.TextBox txttelefono 
         Height          =   315
         Left            =   7440
         MaxLength       =   20
         TabIndex        =   7
         Top             =   480
         Width           =   1935
      End
      Begin VB.TextBox txtcontacto 
         Height          =   315
         Left            =   1320
         MaxLength       =   50
         TabIndex        =   2
         Top             =   840
         Width           =   5175
      End
      Begin VB.TextBox txtruc 
         Height          =   315
         Left            =   4320
         MaxLength       =   11
         TabIndex        =   0
         Top             =   120
         Width           =   2175
      End
      Begin VB.TextBox txtrazonsocial 
         Height          =   315
         Left            =   1320
         MaxLength       =   60
         TabIndex        =   1
         Top             =   480
         Width           =   5175
      End
      Begin VB.TextBox txtcod 
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   1320
         Locked          =   -1  'True
         TabIndex        =   23
         Top             =   120
         Width           =   1455
      End
      Begin VB.Label Label6 
         BackStyle       =   0  'Transparent
         Caption         =   "Web Site"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   34
         Top             =   2280
         Width           =   1215
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         Caption         =   "E-mail"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   33
         Top             =   1920
         Width           =   1215
      End
      Begin VB.Label Label12 
         BackStyle       =   0  'Transparent
         Caption         =   "Dirección"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   32
         Top             =   1560
         Width           =   1215
      End
      Begin VB.Label Label11 
         BackStyle       =   0  'Transparent
         Caption         =   "Celular"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   6600
         TabIndex        =   30
         Top             =   840
         Width           =   975
      End
      Begin VB.Label Label7 
         BackStyle       =   0  'Transparent
         Caption         =   "Teléfono"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   6600
         TabIndex        =   29
         Top             =   480
         Width           =   975
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Contacto"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   28
         Top             =   840
         Width           =   1215
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "R.U.C"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   3600
         TabIndex        =   27
         Top             =   120
         Width           =   735
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Razón Social"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   26
         Top             =   480
         Width           =   1215
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Código"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   25
         Top             =   180
         Width           =   855
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         Caption         =   "Distrito"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   24
         Top             =   1200
         Width           =   1215
      End
   End
   Begin VB.PictureBox Picture2 
      BackColor       =   &H00B0726D&
      Height          =   7335
      Left            =   120
      ScaleHeight     =   7275
      ScaleWidth      =   14835
      TabIndex        =   15
      Top             =   3000
      Width           =   14895
      Begin VB.OptionButton OPTRUC 
         BackColor       =   &H00B0726D&
         Caption         =   "R.U.C"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000014&
         Height          =   255
         Left            =   2520
         TabIndex        =   35
         Top             =   120
         Value           =   -1  'True
         Width           =   1095
      End
      Begin VB.OptionButton OPTRAZONSOCIAL 
         BackColor       =   &H00B0726D&
         Caption         =   "Razón Social"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000014&
         Height          =   255
         Left            =   3600
         TabIndex        =   19
         Top             =   120
         Width           =   1815
      End
      Begin VB.OptionButton OPTCONTACTO 
         BackColor       =   &H00B0726D&
         Caption         =   "Contacto"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000014&
         Height          =   255
         Left            =   5400
         TabIndex        =   18
         Top             =   120
         Width           =   1335
      End
      Begin VB.TextBox txtbuscar 
         DataField       =   "E-mail"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   315
         Left            =   8040
         TabIndex        =   17
         Top             =   90
         Width           =   4455
      End
      Begin VB.OptionButton OPTDISTRITO 
         BackColor       =   &H00B0726D&
         Caption         =   "Distrito"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000014&
         Height          =   255
         Left            =   6720
         TabIndex        =   16
         Top             =   120
         Width           =   1215
      End
      Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
         Height          =   6735
         Left            =   120
         TabIndex        =   20
         Top             =   480
         Width           =   14655
         _ExtentX        =   25850
         _ExtentY        =   11880
         _Version        =   393216
         BackColor       =   -2147483629
         ForeColor       =   -2147483647
         BackColorFixed  =   11563629
         ForeColorFixed  =   -2147483628
         BackColorSel    =   11563629
         ForeColorSel    =   65535
         BackColorBkg    =   -2147483629
         BackColorUnpopulated=   -2147483629
         GridColor       =   11563629
         FocusRect       =   0
         FillStyle       =   1
         SelectionMode   =   1
         AllowUserResizing=   3
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         BeginProperty FontFixed {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         _NumberOfBands  =   1
         _Band(0).Cols   =   2
      End
      Begin VB.Label Label13 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Buscar Poveedor Por:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   240
         Left            =   120
         TabIndex        =   21
         Top             =   120
         Width           =   2295
      End
   End
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   11280
      Picture         =   "FrmProveedores.frx":083C
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   11280
      Picture         =   "FrmProveedores.frx":0B46
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   11280
      Picture         =   "FrmProveedores.frx":0E50
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   9720
      Picture         =   "FrmProveedores.frx":1EE2
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdModificar 
      BackColor       =   &H80000013&
      Caption         =   "&MODIFICAR"
      Height          =   855
      Left            =   9720
      Picture         =   "FrmProveedores.frx":27AC
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   9720
      Picture         =   "FrmProveedores.frx":2BEE
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   120
      Width           =   1455
   End
End
Attribute VB_Name = "FrmProveedores"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private NUEVO As Boolean
Friend Sub habilitar()
  CmdAnular.Enabled = Not CmdAnular.Enabled
  CmdGuardar.Enabled = Not CmdGuardar.Enabled
  CmdModificar.Enabled = Not CmdModificar.Enabled
  CmdSalir.Enabled = Not CmdSalir.Enabled
  CmdNuevo.Enabled = Not CmdNuevo.Enabled
  Picture1.Enabled = Not Picture1.Enabled
  Picture2.Enabled = Not Picture2.Enabled
  CMdELIMINAR.Enabled = Not CMdELIMINAR.Enabled
End Sub
Private Sub cmbdistrito_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbdistrito, KeyAscii
End Sub
Private Sub cmbdistrito_LostFocus()
BuscarEnCombito cmbdistrito
End Sub
Private Sub CmdAnular_Click()
habilitar
Set LIMPIAR = Me
End Sub
Private Sub cmddistrito_Click()
frmdistrito.Show 1
End Sub
Private Sub CMdELIMINAR_Click()
On Local Error GoTo Errlinea
  If Trim$(txtcod) = "" Then
    MsgBox "Para Eliminar Seleccione Un Registro de la Lista..!", 48
    Exit Sub
  End If
  If MsgBox("Desea Eliminar El Registro Seleccionado...!", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
  cn.Execute "delete from proveedores where idproveedor='" + txtcod + "'", XEliminar
  If XEliminar > 0 Then
    frmMensajeEliminado.Show 1
    Set LIMPIAR = Me
    Call P_RELLENALISTAPROVEEDORES(MSHFlexGrid1)
  End If
Exit Sub
Errlinea:
    If Err.Number = -2147467259 Then
      MsgBox "No Se Puede Eliminar El Registro Porque Esta Relacionado Con Una o Más Tablas...!", vbInformation
      Exit Sub
    End If
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
End Sub
Private Sub CmdGuardar_Click()
On Local Error GoTo L
If Trim(txtruc) = "" Then
MsgBox "Ingrese R.U.C...!", vbExclamation
Exit Sub
End If
If Trim(txtrazonsocial) = "" Then
MsgBox "Ingrese Razón Social...!", vbExclamation
Exit Sub
End If
If Trim(cmbdistrito) = "" Then
MsgBox "Ingrese Distrito...!", vbExclamation
Exit Sub
End If
Dim T As New ADODB.Recordset
If NUEVO = True Then
  If YaExisteProveedorN(txtrazonsocial) = True Then
    MsgBox "Ya Esta Registrado La Empresa " + Trim$(txtrazonsocial) + "'"
    Exit Sub
  End If
  T.Open "SELECT * FROM proveedores", cn, adOpenDynamic, adLockOptimistic, adCmdText
  T.AddNew
  T!idproveedor = Trim(txtcod)
Else
  If YaExisteProveedorM(txtrazonsocial, txtcod) = True Then
    MsgBox "Ya Esta Registrado La Empresa " + Trim$(txtrazonsocial) + "'"
    Exit Sub
  End If
  T.Open "SELECT * FROM proveedores WHERE idproveedor='" + txtcod + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
End If
  T!razonsocial = Trim(txtrazonsocial)
  T!ruc = txtruc
  T!nombrecontacto = Trim$(txtcontacto)
  T!NomDistrito = cmbdistrito
  T!direccion = Trim$(txtdireccion)
  T!telefono = Trim$(txttelefono)
  T!celular = Trim$(txtcelular)
  T!email = Trim$(txtemail)
  T!website = Trim$(txtwebsite)
  T.Update
  Set T = Nothing
  If NUEVO = True Then
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  habilitar
  P_RELLENALISTAPROVEEDORES MSHFlexGrid1
  Set LIMPIAR = Me
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
Private Sub CmdModificar_Click()
If txtcod = "" Then
  MsgBox "Buscar Proveedor ...!", vbInformation
  Exit Sub
End If
NUEVO = False
habilitar
txtruc.SetFocus
End Sub
Private Sub CmdNuevo_Click()
NUEVO = True
habilitar
Set LIMPIAR = Me
txtcod.Text = GenerarCodigo(s_IDPROVEEDOR, 6)
txtruc.SetFocus
End Sub
Private Sub CmdSalir_Click()
Unload Me
End Sub
Private Sub Form_Activate()
Screen.MousePointer = ccDefault
End Sub
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub
Private Sub Form_Load()
Screen.MousePointer = ccHourglass
Centrar_Objeto Me
P_RELLENALISTAPROVEEDORES MSHFlexGrid1
V_PROVEEDOR = True
P_RellenaCombo "DIS", cmbdistrito
End Sub
Private Sub Form_Unload(Cancel As Integer)
V_PROVEEDOR = False
If V_NOTAINGR = True Then
  x = FrmNotaIngreso.cmbproveedor
  P_RellenaCombo "PROV", FrmNotaIngreso.cmbproveedor
   FrmNotaIngreso.cmbproveedor = x
End If
If V_PROVEEDORXPRODUCTO = True Then
  x = FrmProductoPorProveedor.cmbproveedor
  P_RellenaCombo "PROV", FrmProductoPorProveedor.cmbproveedor
   FrmProductoPorProveedor.cmbproveedor = x
End If
End Sub
Private Sub MSHFlexGrid1_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
txtruc = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
txtcod = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
txtrazonsocial = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
txtcontacto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
cmbdistrito = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
txtdireccion = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6)
txttelefono = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 7)
txtcelular = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 8)
txtemail = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 9)
txtwebsite = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 10)
End Sub
Private Sub MSHFlexGrid1_DblClick()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If V_NOTAINGR = True Then
   FrmNotaIngreso.cmbproveedor = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  Unload Me
End If
If V_PROVEEDORXPRODUCTO = True Then
  FrmProductoPorProveedor.cmbproveedor = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  FrmProductoPorProveedor.cmbproveedor_LostFocus
  FrmProductoPorProveedor.cmbproveedor_Click
  Unload Me
End If
If V_FrmCatalogodeProductos = True Then
  FrmCatalogodeProductos.txtproveedor = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  Unload Me
End If
End Sub
Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = 13 Then
  MSHFlexGrid1_DblClick
  Exit Sub
End If
MSHFlexGrid1_Click
End Sub
Private Sub MSHFlexGrid1_KeyUp(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub
Private Sub OPTCONTACTO_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub
Private Sub OPTDISTRITO_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub
Private Sub OPTRAZONSOCIAL_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub
Private Sub OPTRUC_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub
Private Sub txtbuscar_Change()
If OPTRUC.Value = True Then
  P_RELLENALISTAPROVEEDORES MSHFlexGrid1, 1, Trim$(txtbuscar)
  Exit Sub
End If
If OPTRAZONSOCIAL.Value = True Then
  P_RELLENALISTAPROVEEDORES MSHFlexGrid1, 2, Trim$(txtbuscar)
  Exit Sub
End If
If OPTCONTACTO.Value = True Then
  P_RELLENALISTAPROVEEDORES MSHFlexGrid1, 3, Trim$(txtbuscar)
  Exit Sub
End If
If OPTDISTRITO.Value = True Then
  P_RELLENALISTAPROVEEDORES MSHFlexGrid1, 4, Trim$(txtbuscar)
  Exit Sub
End If
End Sub
Private Sub txtbuscar_GotFocus()
txtbuscar.SelStart = 0
txtbuscar.SelLength = Len(txtbuscar)
End Sub
Private Sub txtbuscar_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
Private Sub txtcelular_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, telefono
End Sub
Private Sub txtcontacto_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
Private Sub txtdireccion_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
Private Sub txtemail_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
Private Sub txtrazonsocial_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
Private Sub txtruc_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, SoloNumero
End Sub
Private Sub txttelefono_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, telefono
End Sub
Private Sub txtwebsite_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
