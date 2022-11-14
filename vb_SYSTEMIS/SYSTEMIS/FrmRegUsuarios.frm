VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmRegUsuarios 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "REGISTRO DE USUARIOS"
   ClientHeight    =   8265
   ClientLeft      =   45
   ClientTop       =   540
   ClientWidth     =   14415
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
   Icon            =   "FrmRegUsuarios.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   8265
   ScaleWidth      =   14415
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture2 
      BackColor       =   &H00B0726D&
      Height          =   5295
      Left            =   120
      ScaleHeight     =   5235
      ScaleWidth      =   12555
      TabIndex        =   31
      Top             =   2880
      Width           =   12615
      Begin VB.OptionButton optusuario 
         BackColor       =   &H00B0726D&
         Caption         =   "Usuario"
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
         TabIndex        =   43
         Top             =   120
         Width           =   1215
      End
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
         Left            =   3240
         TabIndex        =   36
         Top             =   120
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
         Left            =   4440
         TabIndex        =   35
         Top             =   120
         Width           =   1215
      End
      Begin VB.OptionButton optdni 
         BackColor       =   &H00B0726D&
         Caption         =   "D.N.I"
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
         Left            =   2280
         TabIndex        =   34
         Top             =   120
         Value           =   -1  'True
         Width           =   1095
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
         Left            =   5640
         TabIndex        =   33
         Top             =   120
         Width           =   1215
      End
      Begin VB.TextBox txtbuscar 
         DataField       =   "E-mail"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   375
         Left            =   8040
         TabIndex        =   32
         Top             =   90
         Width           =   4455
      End
      Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
         Height          =   4575
         Left            =   120
         TabIndex        =   37
         Top             =   600
         Width           =   12375
         _ExtentX        =   21828
         _ExtentY        =   8070
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
         Caption         =   "Buscar Usuario Por:"
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
         TabIndex        =   38
         Top             =   120
         Width           =   2085
      End
   End
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   12840
      Picture         =   "FrmRegUsuarios.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   30
      Top             =   3960
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   12840
      Picture         =   "FrmRegUsuarios.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   4920
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   12840
      Picture         =   "FrmRegUsuarios.frx":091E
      Style           =   1  'Graphical
      TabIndex        =   28
      Top             =   3000
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   12840
      Picture         =   "FrmRegUsuarios.frx":19B0
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdModificar 
      BackColor       =   &H80000013&
      Caption         =   "&MODIFICAR"
      Height          =   855
      Left            =   12840
      Picture         =   "FrmRegUsuarios.frx":227A
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   12840
      Picture         =   "FrmRegUsuarios.frx":26BC
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   120
      Width           =   1455
   End
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
      Height          =   2655
      Left            =   120
      ScaleHeight     =   2595
      ScaleWidth      =   12555
      TabIndex        =   0
      Top             =   120
      Width           =   12615
      Begin VB.CommandButton cmd2 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   5520
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmRegUsuarios.frx":2AFE
         Style           =   1  'Graphical
         TabIndex        =   42
         ToolTipText     =   "BUSCAR DISTRITO"
         Top             =   2160
         Width           =   375
      End
      Begin VB.CommandButton CMD1 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   5520
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmRegUsuarios.frx":3030
         Style           =   1  'Graphical
         TabIndex        =   41
         ToolTipText     =   "BUSCAR CARGO"
         Top             =   1440
         Width           =   375
      End
      Begin VB.ComboBox cmbdistrito 
         Height          =   315
         Left            =   960
         Sorted          =   -1  'True
         TabIndex        =   39
         Text            =   "cmbdistrito"
         Top             =   2160
         Width           =   4575
      End
      Begin VB.TextBox txtfecnac 
         DataField       =   "NomDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   375
         Left            =   4080
         MaxLength       =   10
         TabIndex        =   23
         Top             =   120
         Width           =   1815
      End
      Begin VB.TextBox txtemail 
         DataField       =   "NomDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   375
         Left            =   7080
         MaxLength       =   255
         TabIndex        =   21
         Top             =   1560
         Width           =   3975
      End
      Begin VB.TextBox txtdni 
         DataField       =   "NomDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   375
         Left            =   9600
         MaxLength       =   11
         TabIndex        =   19
         Top             =   1080
         Width           =   1455
      End
      Begin VB.TextBox txttelefono 
         DataField       =   "NomDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   375
         Left            =   7080
         MaxLength       =   20
         TabIndex        =   17
         Top             =   1080
         Width           =   1575
      End
      Begin VB.TextBox txtapellidos 
         DataField       =   "NomDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   375
         Left            =   7080
         MaxLength       =   50
         TabIndex        =   15
         Top             =   600
         Width           =   3975
      End
      Begin VB.TextBox txtnombres 
         DataField       =   "NomDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   375
         Left            =   7080
         MaxLength       =   50
         TabIndex        =   13
         Top             =   120
         Width           =   3975
      End
      Begin VB.ComboBox cmbtipo 
         Height          =   315
         Left            =   960
         Sorted          =   -1  'True
         TabIndex        =   11
         Text            =   "cmbtipo"
         Top             =   1800
         Width           =   4575
      End
      Begin VB.ComboBox cmbCargo 
         Height          =   315
         Left            =   960
         Sorted          =   -1  'True
         TabIndex        =   9
         Text            =   "cmbCargo"
         Top             =   1440
         Width           =   4575
      End
      Begin VB.TextBox txtconfirmar 
         DataField       =   "NomDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         IMEMode         =   3  'DISABLE
         Left            =   4200
         MaxLength       =   50
         PasswordChar    =   "*"
         TabIndex        =   7
         Top             =   1005
         Width           =   1695
      End
      Begin VB.TextBox txtclave 
         DataField       =   "NomDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         IMEMode         =   3  'DISABLE
         Left            =   960
         MaxLength       =   50
         PasswordChar    =   "*"
         TabIndex        =   5
         Top             =   1005
         Width           =   1695
      End
      Begin VB.TextBox txtusuario 
         DataField       =   "NomDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   375
         Left            =   960
         MaxLength       =   50
         TabIndex        =   2
         Top             =   570
         Width           =   4935
      End
      Begin VB.TextBox txtcodigo 
         BackColor       =   &H80000018&
         DataField       =   "CodDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   375
         Left            =   960
         Locked          =   -1  'True
         TabIndex        =   1
         Top             =   120
         Width           =   1455
      End
      Begin VB.Label Label14 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Distrito:"
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
         TabIndex        =   40
         Top             =   2160
         Width           =   810
      End
      Begin VB.Label Label12 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha Nac.:"
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
         Left            =   2760
         TabIndex        =   24
         Top             =   120
         Width           =   1260
      End
      Begin VB.Label Label11 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "E-mail:"
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
         Left            =   6000
         TabIndex        =   22
         Top             =   1560
         Width           =   855
      End
      Begin VB.Label Label10 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "D.N.I:"
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
         Left            =   8880
         TabIndex        =   20
         Top             =   1080
         Width           =   585
      End
      Begin VB.Label Label9 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Teléfono:"
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
         Left            =   6000
         TabIndex        =   18
         Top             =   1080
         Width           =   1005
      End
      Begin VB.Label Label8 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Apellidos:"
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
         Left            =   6000
         TabIndex        =   16
         Top             =   600
         Width           =   1065
      End
      Begin VB.Label Label7 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Nombres:"
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
         Left            =   6000
         TabIndex        =   14
         Top             =   120
         Width           =   1020
      End
      Begin VB.Label Label6 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Tipo:"
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
         TabIndex        =   12
         Top             =   1800
         Width           =   555
      End
      Begin VB.Label Label5 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Cargo:"
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
         TabIndex        =   10
         Top             =   1440
         Width           =   705
      End
      Begin VB.Label Label4 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Confirmar:"
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
         Left            =   2880
         TabIndex        =   8
         Top             =   1005
         Width           =   1065
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Clave:"
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
         TabIndex        =   6
         Top             =   1005
         Width           =   675
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Usuario:"
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
         TabIndex        =   4
         Top             =   570
         Width           =   885
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Código:"
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
         TabIndex        =   3
         Top             =   120
         Width           =   825
      End
   End
End
Attribute VB_Name = "FrmRegUsuarios"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text
Dim NUEVO As Boolean
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
Private Sub cmbCargo_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbCargo, KeyAscii
End Sub

Private Sub cmbCargo_LostFocus()
BuscarEnCombito cmbCargo
End Sub

Private Sub cmbdistrito_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbdistrito, KeyAscii
End Sub

Private Sub cmbdistrito_LostFocus()
BuscarEnCombito cmbdistrito
End Sub

Private Sub cmbtipo_KeyPress(KeyAscii As Integer)
  ValidarIngreso1 cmbtipo, KeyAscii

End Sub

Private Sub cmbtipo_LostFocus()
BuscarEnCombito cmbtipo

End Sub

Private Sub CMD1_Click()
FrmCargos.Show 1
End Sub

Private Sub CMD2_Click()
frmdistrito.Show 1
End Sub

Private Sub CmdAnular_Click()
  habilitar
  Set LIMPIAR = Me
End Sub

Private Sub CMdELIMINAR_Click()
On Local Error GoTo Errlinea
  If Trim$(txtcodigo) = "" Then
    MsgBox "Para Eliminar Seleccione Un Registro de la Lista..!", 48
    Exit Sub
  End If
  If MsgBox("Desea Eliminar El Registro Seleccionado...!", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
  cn.Execute "delete from Usuarios where idusuario='" + txtcodigo + "' and idtipo<>'00001' and idusuario<>'" + txtcodigo + "'", XEliminar
  If XEliminar > 0 Then
    frmMensajeEliminado.Show 1
    ELIM = 0
    Set LIMPIAR = Me
    Call prellenaUsuarios(MSHFlexGrid1)
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
If Trim(txtfecnac) = "" Then
  MsgBox "Ingrese El Campo Fecha Nacimiento ...!", vbExclamation
  txtfecnac.SetFocus
  Exit Sub
End If
If Trim(txtusuario) = "" Then
  MsgBox "Ingrese El Campo Usuario ...!", vbExclamation
  txtusuario.SetFocus
  Exit Sub
End If
If Trim(txtclave) = "" Then
  MsgBox "Ingrese El Campo Clave ...!", vbExclamation
  txtclave.SetFocus
  Exit Sub
End If
If Trim(txtconfirmar) = "" Then
  MsgBox "Ingrese El Campo Confirmar ...!", vbExclamation
  txtconfirmar.SetFocus
  Exit Sub
End If
If Trim(txtclave) <> Trim(txtconfirmar) Then
  MsgBox "Los Campos Clave y Confirmar No Coinciden...!", vbExclamation
  txtclave = Empty
  txtconfirmar.Text = Empty
  txtclave.SetFocus
  Exit Sub
End If
If Trim(cmbCargo) = "" Then
  MsgBox "Ingrese El Campo Cargo ...!", vbExclamation
  cmbCargo.SetFocus
  Exit Sub
End If
If Trim(cmbtipo) = "" Then
  MsgBox "Ingrese El Campo Tipo ...!", vbExclamation
  cmbtipo.SetFocus
  Exit Sub
End If
If Trim(cmbdistrito) = "" Then
  MsgBox "Ingrese El Campo Distrito ...!", vbExclamation
  cmbdistrito.SetFocus
  Exit Sub
End If
On Local Error GoTo L
Dim T As New ADODB.Recordset
If NUEVO = True Then
  T.Open "USUARIOS", cn, adOpenDynamic, adLockOptimistic, adCmdTable
  T.AddNew
  T!idusuario = txtcodigo
Else
  T.Open "SELECT * FROM USUARIOS WHERE IDUSUARIO='" + txtcodigo + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
End If
  T!nomusu = Trim$(txtusuario)
  T!passwo = Trim$(txtclave)
  T!idcargo = xidcargo(cmbCargo)
  T!IDTIPO = IIf(cmbtipo = "ADMINISTRADOR", "00001", "00002")
  T!NOMBRES = Trim$(txtnombres)
  T!APELLIDOS = Trim$(txtapellidos)
  T!telefono = Trim$(txttelefono)
  T!DNI = Trim$(txtdni)
  T!email = Trim$(txtemail)
  T!FECNAC = CDate(txtfecnac)
  TNOMDISTITO = cmbdistrito
  T.Update
  Set T = Nothing
  If NUEVO = True Then
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  habilitar
  prellenaUsuarios MSHFlexGrid1
  Set LIMPIAR = Me
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
Function xidcargo(des As String) As String
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "select idcargo from cargos where descargo='" + des + "'", cn, adOpenForwardOnly, adLockReadOnly
REFRESCAR T
If T.RecordCount = 0 Then
  Set T = Nothing
  Exit Function
End If
xidcargo = T!idcargo
Set T = Nothing
Exit Function
L:
MsgBox Err.Description, vbInformation
End Function
Private Sub CmdModificar_Click()
If Trim(txtcodigo) = "" Then
MsgBox "Buscar Usuario ...!", vbInformation
Exit Sub
End If
NUEVO = False
habilitar
txtfecnac.SetFocus
End Sub

Private Sub CmdNuevo_Click()
NUEVO = True
habilitar
txtcodigo = GenerarCodigo(s_IDUSUARIOS, 5)
txtfecnac.SetFocus
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
  V_REGUSU = True
  P_RellenaCombo "DIS", cmbdistrito
   P_RellenaCombo "TIP", cmbtipo
   P_RellenaCombo "CAR", cmbCargo
    prellenaUsuarios MSHFlexGrid1
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_REGUSU = False
End Sub

Private Sub MSHFlexGrid1_Click()
With MSHFlexGrid1
If .TextMatrix(1, 1) = "" Then Exit Sub
txtcodigo = .TextMatrix(.RowSel, 1)
txtusuario = .TextMatrix(.RowSel, 2)
cmbCargo = .TextMatrix(.RowSel, 4)
cmbtipo = .TextMatrix(.RowSel, 6)
txtnombres = .TextMatrix(.RowSel, 7)
txtapellidos = .TextMatrix(.RowSel, 8)
txtdni = .TextMatrix(.RowSel, 9)
txttelefono = .TextMatrix(.RowSel, 10)
txtemail = .TextMatrix(.RowSel, 11)
txtfecnac = .TextMatrix(.RowSel, 12)
cmbdistrito = .TextMatrix(.RowSel, 13)
txtclave = .TextMatrix(.RowSel, 14)
txtconfirmar = .TextMatrix(.RowSel, 14)
End With
End Sub

Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub MSHFlexGrid1_KeyUp(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub optapellido_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub

Private Sub OPTDISTRITO_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub

Private Sub optdni_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub

Private Sub optnombre_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub

Private Sub optusuario_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub

Private Sub txtapellidos_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtbuscar_Change()
  If optdni.Value = True Then
    prellenaUsuarios MSHFlexGrid1, 1, txtbuscar
  ElseIf optnombre.Value = True Then
    prellenaUsuarios MSHFlexGrid1, 2, txtbuscar
  ElseIf optapellido.Value = True Then
    prellenaUsuarios MSHFlexGrid1, 3, txtbuscar
  ElseIf OPTDISTRITO.Value = True Then
    prellenaUsuarios MSHFlexGrid1, 4, txtbuscar
  ElseIf optusuario.Value = True Then
    prellenaUsuarios MSHFlexGrid1, 5, txtbuscar
  End If
End Sub

Private Sub txtbuscar_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtclave_GotFocus()
txtclave.SelStart = 0
txtclave.SelLength = Len(txtclave)
End Sub

Private Sub txtclave_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtconfirmar_GotFocus()
txtconfirmar.SelStart = 0
txtconfirmar.SelLength = Len(txtconfirmar)
End Sub

Private Sub txtconfirmar_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtdni_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, SoloNumero
End Sub

Private Sub txtemail_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtfecnac_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub txtnombres_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txttelefono_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, telefono
End Sub

Private Sub txtusuario_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
