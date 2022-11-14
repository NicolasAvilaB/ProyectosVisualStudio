VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmPromotores 
   BackColor       =   &H00B0726D&
   Caption         =   "Promotores"
   ClientHeight    =   7755
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9210
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
   Icon            =   "FrmPromotores.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   ScaleHeight     =   7755
   ScaleWidth      =   9210
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtbuscar 
      Height          =   375
      Left            =   1680
      MaxLength       =   50
      TabIndex        =   3
      Top             =   2520
      Width           =   3855
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   6120
      Picture         =   "FrmPromotores.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdModificar 
      BackColor       =   &H80000013&
      Caption         =   "&MODIFICAR"
      Height          =   855
      Left            =   6120
      Picture         =   "FrmPromotores.frx":074C
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   7680
      Picture         =   "FrmPromotores.frx":0B8E
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   7680
      Picture         =   "FrmPromotores.frx":1458
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   7680
      Picture         =   "FrmPromotores.frx":24EA
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   2040
      Width           =   1455
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Enabled         =   0   'False
      Height          =   2415
      Left            =   120
      TabIndex        =   5
      Top             =   0
      Width           =   5895
      Begin VB.ComboBox cmbcomision 
         Height          =   315
         Left            =   1080
         Sorted          =   -1  'True
         TabIndex        =   18
         Top             =   1920
         Width           =   1455
      End
      Begin VB.TextBox txttelefono 
         Height          =   375
         Left            =   1080
         MaxLength       =   25
         TabIndex        =   2
         Top             =   1485
         Width           =   1455
      End
      Begin VB.TextBox txtdireccion 
         Height          =   375
         Left            =   1080
         MaxLength       =   50
         TabIndex        =   1
         Top             =   1080
         Width           =   4335
      End
      Begin VB.TextBox txtnombres 
         Height          =   375
         Left            =   1080
         MaxLength       =   50
         TabIndex        =   0
         Top             =   680
         Width           =   3015
      End
      Begin VB.TextBox txtcod 
         BackColor       =   &H80000018&
         Height          =   375
         Left            =   1080
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   6
         Top             =   240
         Width           =   1455
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Comisión"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   19
         Top             =   1920
         Width           =   1215
      End
      Begin VB.Label Label7 
         BackStyle       =   0  'Transparent
         Caption         =   "Teléfono"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   17
         Top             =   1485
         Width           =   855
      End
      Begin VB.Label Label6 
         BackStyle       =   0  'Transparent
         Caption         =   "Domicilio"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   16
         Top             =   1080
         Width           =   855
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Nombres"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   8
         Top             =   680
         Width           =   855
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Código"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   300
         Width           =   855
      End
   End
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   6120
      Picture         =   "FrmPromotores.frx":27F4
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   2040
      Width           =   1455
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   4695
      Left            =   120
      TabIndex        =   14
      Top             =   3000
      Width           =   9015
      _ExtentX        =   15901
      _ExtentY        =   8281
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
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Buscar Promotor:"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   120
      TabIndex        =   15
      Top             =   2520
      Width           =   1815
   End
End
Attribute VB_Name = "FrmPromotores"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim NUEVO As Boolean
Friend Sub habilitar()
  MSHFlexGrid1.Enabled = Not MSHFlexGrid1.Enabled
  CmdAnular.Enabled = Not CmdAnular.Enabled
  CmdGuardar.Enabled = Not CmdGuardar.Enabled
  CmdModificar.Enabled = Not CmdModificar.Enabled
  CmdSalir.Enabled = Not CmdSalir.Enabled
  CmdNuevo.Enabled = Not CmdNuevo.Enabled
  Frame1.Enabled = Not Frame1.Enabled
  CMdELIMINAR.Enabled = Not CMdELIMINAR.Enabled
End Sub
Private Sub cmbcomision_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbcomision, KeyAscii
End Sub
Private Sub cmbcomision_LostFocus()
BuscarEnCombito cmbcomision
End Sub
Private Sub CmdAnular_Click()
  habilitar
  Set LIMPIAR = Me
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
  If EliminarTabla(txtcod, "promotores", "idpromotor") > 0 Then
    frmMensajeEliminado.Show 1
    Set LIMPIAR = Me
    P_RELLENALISTAPROMOTORES MSHFlexGrid1
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
If Trim(txtnombres) = "" Then
MsgBox "Ingrese Nombres...!", vbExclamation
Exit Sub
End If
If Val(cmbcomision) = 0 Then
MsgBox "Ingrese Comisión...!", vbExclamation
Exit Sub
End If
Dim T As New ADODB.Recordset
If NUEVO = True Then
  T.Open "PROMOTORES", cn, adOpenDynamic, adLockOptimistic, adCmdTable
  T.AddNew "IDpromotor", Trim(txtcod)
Else
  T.Open "SELECT * FROM promotores WHERE IDpromotor='" + txtcod + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
End If
  T!nombres = Trim$(txtnombres)
  T!domicilio = Trim$(txtdireccion)
  T!telefonos = Trim$(txttelefono)
  T!idcomision = Devuelve_IdComision(cmbcomision)
  T.Update
  Set T = Nothing
  If NUEVO = True Then
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  habilitar
  P_RELLENALISTAPROMOTORES MSHFlexGrid1
  Set LIMPIAR = Me
  Exit Sub
L:
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
End Sub
Private Sub CmdModificar_Click()
If txtcod = "" Then
  MsgBox "Buscar Promotor ...!", vbInformation
  Exit Sub
End If
NUEVO = False
habilitar
txtnombres.SetFocus
End Sub
Private Sub CmdNuevo_Click()
  NUEVO = True
  habilitar
  Set LIMPIAR = Me
  txtcod.Text = GenerarCodigo("Select max(idpromotor) from promotores", 5)
  On Error Resume Next
  txtnombres.SetFocus
  On Error GoTo 0
End Sub
Private Sub CmdSalir_Click()
Unload Me
End Sub
Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub
Private Sub Form_Load()
Screen.MousePointer = vbHourglass
P_RELLENALISTAPROMOTORES MSHFlexGrid1, 1
P_RellenaCombo "comision", cmbcomision
End Sub
Private Sub Form_Unload(Cancel As Integer)
 If V_FACTURACION = True Then
    x = FrmFacturacion.cmbpromotor
    P_RellenaCombo "promotor", FrmFacturacion.cmbpromotor
    FrmFacturacion.cmbpromotor = x
  End If
End Sub
Private Sub MSHFlexGrid1_DblClick()
  If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If V_FACTURACION = True Then
  P_RellenaCombo "promotor", FrmFacturacion.cmbpromotor
  FrmFacturacion.cmbpromotor = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  Unload Me
End If
End Sub
Private Sub txtbuscar_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
Private Sub txtdireccion_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
Private Sub txtnombres_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
Private Sub txttelefono_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, telefono
End Sub
Private Sub MSHFlexGrid1_Click()
  If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
  txtcod = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  txtnombres = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
   txtdireccion = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
   txttelefono = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
   cmbcomision = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
End Sub
Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub
Private Sub MSHFlexGrid1_KeyUp(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub
Private Sub txtbuscar_Change()
  P_RELLENALISTAPROMOTORES MSHFlexGrid1, 2, Trim$(txtbuscar)
End Sub
