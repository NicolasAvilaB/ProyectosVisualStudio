VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form frmBuscarDueño 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "BUSCAR CLIENTES"
   ClientHeight    =   10095
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   15270
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
   Icon            =   "frmBuscarDueño.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   ScaleHeight     =   10095
   ScaleWidth      =   15270
   Begin VB.OptionButton optnombre 
      BackColor       =   &H00B0726D&
      Caption         =   "Nombre"
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
      Left            =   3960
      TabIndex        =   6
      Top             =   270
      Width           =   1215
   End
   Begin VB.OptionButton optapellido 
      BackColor       =   &H00B0726D&
      Caption         =   "Apellido"
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
      Left            =   5160
      TabIndex        =   5
      Top             =   270
      Width           =   1215
   End
   Begin VB.OptionButton optdniruc 
      BackColor       =   &H00B0726D&
      Caption         =   "D.N.I / R.U.C"
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
      Left            =   2160
      TabIndex        =   4
      Top             =   270
      Value           =   -1  'True
      Width           =   1695
   End
   Begin VB.OptionButton optdistrito 
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
      Left            =   6360
      TabIndex        =   3
      Top             =   270
      Width           =   1215
   End
   Begin VB.TextBox txtbuscar 
      DataField       =   "E-mail"
      DataMember      =   "RegistroDueño"
      DataSource      =   "DataEnvironment1"
      Height          =   375
      Left            =   2160
      TabIndex        =   2
      Top             =   600
      Width           =   5295
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   13680
      Picture         =   "frmBuscarDueño.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   120
      Width           =   1455
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   8895
      Left            =   120
      TabIndex        =   1
      Top             =   1080
      Width           =   15015
      _ExtentX        =   26485
      _ExtentY        =   15690
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
      Caption         =   "Buscar Cliente Por:"
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
      TabIndex        =   7
      Top             =   270
      Width           =   1995
   End
End
Attribute VB_Name = "frmBuscarDueño"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text
Private Sub CmdSalir_Click()
Unload Me
End Sub
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub
Private Sub Form_Load()
Centrar_Objeto Me
If V_CANCELACION = True Then
  P_RELLENALISTADUEÑO MSHFlexGrid1, 5, ""
  Exit Sub
End If
P_RELLENALISTADUEÑO MSHFlexGrid1, 1, ""
End Sub
Private Sub Form_Unload(Cancel As Integer)
Set frmBuscarDueño = Nothing
End Sub

Private Sub MSHFlexGrid1_DblClick()
  If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If V_DUEÑO = True And V_MASCOTA = False Then
  With frmRegistroDueño
  .txtcodigo = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  .txtnombres = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  .txtapellidos = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  .txttelefono = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
  .txtedad = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
  .txtdni = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6)
  .cmbprofesion = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 7)
  .txtdireccion = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 8)
  .cmbdistrito = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 9)
  .txtemail = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 10)
  .NUEVO = False
  On Error GoTo P
  .txtobservaaciones = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 13)
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12) = "Activo" Then .chkactivo.Value = False
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12) = "InActivo" Then .chkactivo.Value = True
  .Image1.Picture = LoadPicture(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 11))
  .Image1.Tag = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 11)
    If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 14) = "Consulta" Then .optconsulta.Value = True
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 14) = "Petshop" Then .optpetshop.Value = True

  End With
  Unload Me
  Exit Sub
End If
If V_MASCOTA = True Then
  With frmRegistroMascota
  .txtcoddueño = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  End With
  Unload Me
  Exit Sub
End If
If V_BUSCARBOLETA = 1 Then
  frmbuscarboleta.txtnboleta = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  Unload Me
  Exit Sub
End If

If V_PAGO = True Then
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12) = "Inactivo" Then
    MsgBox "Cliente Inactivo...!", vbInformation
    Exit Sub
  End If
  FrmRegistrarPago.txtcoddueño = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  FrmRegistrarPago.LBLCLIENTE = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  Unload Me
  Exit Sub
End If
If V_HOJAACTUALIZADA = True Then
  FrmHojaActualizada.txtcoddueño.Text = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  Unload Me
  Exit Sub
End If
If V_CANCELACION = True Then
  With Frmcancelacion
  .txtcoddueño = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  .Label2.Caption = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  .relle .txtcoddueño
  End With
  Unload Me
  Exit Sub
End If
If V_DEUDASS = True Then
  FrmDeudas.Text1 = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  FrmDeudas.Text2 = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  Unload Me
End If
If V_PAGOCREDITOSVENTAS = True Then
  FrmPagos.txtcliente = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  idpago = ClienteDebe(FrmPagos.txtcliente)
  If idpago = "" Then
    MsgBox "El Cliente No Tiene Deudas a Cancelar ...!", vbInformation
    Exit Sub
  End If
  Call p_RellenoDeta(FrmPagos.MSHFlexGrid1, idpago)
  FrmPagos.txtidpago = idpago
  Call p_RellenoDeta(FrmPagos.MSHFlexGrid1, FrmPagos.txtidpago)
  Unload Me
End If
If V_CUENTACORRIENTESSSS = True Then
  FrmCuentaCorriente.TxtCLIEWNTE = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  p_RellenoCUENTACORRIENTESSS FrmCuentaCorriente.MSHFlexGrid1, FrmCuentaCorriente.cmbdocumento, FrmCuentaCorriente.cmbndocumento, Devuelve_IdCliente(FrmCuentaCorriente.TxtCLIEWNTE), FrmCuentaCorriente.txtcredito, FrmCuentaCorriente.txtdeuda, FrmCuentaCorriente.txtpagado
  Unload Me
End If
  Exit Sub
P:
  frmRegistroDueño.Image1.Picture = LoadPicture("")
  Unload Me
End Sub

Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = 13 Then
  MSHFlexGrid1_DblClick
    Exit Sub
End If
End Sub

Private Sub MSHFlexGrid1_KeyPress(KeyAscii As Integer)
MSHFlexGrid1_DblClick
End Sub

Private Sub TxtApeDueño_GotFocus()
TxtApeDueño.SelStart = 0
TxtApeDueño.SelLength = Len(TxtApeDueño)
End Sub

Private Sub TxtApeDueño_KeyPress(KeyAscii As Integer)
Mod_Prodims.xRestringir KeyAscii, Apostrofe
End Sub

Private Sub optapellido_Click()
txtbuscar = Empty
txtbuscar.SetFocus
End Sub

Private Sub OPTDISTRITO_Click()
txtbuscar = Empty
txtbuscar.SetFocus
End Sub

Private Sub optdniruc_Click()
txtbuscar = Empty
txtbuscar.SetFocus
End Sub

Private Sub optnombre_Click()
txtbuscar = Empty
txtbuscar.SetFocus
End Sub

Private Sub txtbuscar_Change()
If V_CANCELACION = True Then
  If optnombre.Value = True Then
    P_RELLENALISTADUEÑO MSHFlexGrid1, 5, Trim(txtbuscar)
    Exit Sub
  End If
  If optapellido.Value = True Then
    P_RELLENALISTADUEÑO MSHFlexGrid1, 6, Trim(txtbuscar)
    Exit Sub
  End If
  If optdniruc.Value = True Then
    P_RELLENALISTADUEÑO MSHFlexGrid1, 7, Trim(txtbuscar)
    Exit Sub
  End If
  If OPTDISTRITO.Value = True Then
    P_RELLENALISTADUEÑO MSHFlexGrid1, 8, Trim(txtbuscar)
    Exit Sub
  End If
End If
  If optnombre.Value = True Then
    P_RELLENALISTADUEÑO MSHFlexGrid1, 1, Trim(txtbuscar)
    Exit Sub
  End If
  If optapellido.Value = True Then
    P_RELLENALISTADUEÑO MSHFlexGrid1, 2, Trim(txtbuscar)
    Exit Sub
  End If
  If optdniruc.Value = True Then
    P_RELLENALISTADUEÑO MSHFlexGrid1, 3, Trim(txtbuscar)
    Exit Sub
  End If
  If OPTDISTRITO.Value = True Then
    P_RELLENALISTADUEÑO MSHFlexGrid1, 4, Trim(txtbuscar)
    Exit Sub
  End If
End Sub

Private Sub txtbuscar_GotFocus()
txtbuscar.SelStart = 0
txtbuscar.SelLength = Len(txtbuscar)
End Sub

Private Sub txtbuscar_KeyPress(KeyAscii As Integer)
If Chr(KeyAscii) = "'" Then KeyAscii = 0
End Sub
