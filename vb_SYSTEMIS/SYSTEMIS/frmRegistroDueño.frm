VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form frmRegistroDueño 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "REGISTRO DE CLIENTES"
   ClientHeight    =   10305
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   15195
   ForeColor       =   &H00B0726D&
   Icon            =   "frmRegistroDueño.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   10305
   ScaleWidth      =   15195
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00B0726D&
      Height          =   5950
      Left            =   120
      ScaleHeight     =   5895
      ScaleWidth      =   14955
      TabIndex        =   37
      Top             =   4320
      Width           =   15015
      Begin VB.TextBox txtbuscar 
         DataField       =   "E-mail"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   7440
         TabIndex        =   44
         Top             =   90
         Width           =   5295
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
         TabIndex        =   43
         Top             =   120
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
         TabIndex        =   42
         Top             =   120
         Value           =   -1  'True
         Width           =   1695
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
         TabIndex        =   41
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
         Left            =   3960
         TabIndex        =   40
         Top             =   120
         Width           =   1215
      End
      Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
         Height          =   5160
         Left            =   120
         TabIndex        =   38
         Top             =   460
         Width           =   14775
         _ExtentX        =   26061
         _ExtentY        =   9102
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
      Begin VB.Label Label14 
         BackStyle       =   0  'Transparent
         Caption         =   "TOTAL:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   12720
         TabIndex        =   49
         Top             =   5640
         Width           =   855
      End
      Begin VB.Label LBLTOTAL 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000012&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   13560
         TabIndex        =   48
         Top             =   5640
         Width           =   1335
      End
      Begin VB.Label Label13 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Buscar Dueño Por:"
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
         TabIndex        =   39
         Top             =   120
         Width           =   1950
      End
   End
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   11520
      Picture         =   "frmRegistroDueño.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   30
      Top             =   2160
      Width           =   1455
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   9120
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Caption         =   "DATOS:"
      Enabled         =   0   'False
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
      Height          =   4215
      Left            =   120
      TabIndex        =   16
      Top             =   0
      Width           =   9735
      Begin VB.Frame Frame2 
         BackColor       =   &H00B0726D&
         Caption         =   "Tipo de Cliente"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   495
         Left            =   3720
         TabIndex        =   45
         Top             =   1320
         Visible         =   0   'False
         Width           =   2655
         Begin VB.OptionButton optconsulta 
            BackColor       =   &H00B0726D&
            Caption         =   "Consulta"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H8000000E&
            Height          =   195
            Left            =   120
            TabIndex        =   47
            Top             =   240
            Value           =   -1  'True
            Width           =   1095
         End
         Begin VB.OptionButton optpetshop 
            BackColor       =   &H00B0726D&
            Caption         =   "PetShop"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H8000000E&
            Height          =   195
            Left            =   1320
            TabIndex        =   46
            Top             =   240
            Width           =   1095
         End
      End
      Begin VB.CheckBox chkactivo 
         BackColor       =   &H00B0726D&
         Caption         =   "Inactivo"
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
         Left            =   3000
         TabIndex        =   36
         Top             =   240
         Width           =   1335
      End
      Begin VB.TextBox txtobservaaciones 
         DataField       =   "E-mail"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   1320
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   34
         Top             =   3470
         Width           =   5055
      End
      Begin VB.CommandButton Command1 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6120
         MaskColor       =   &H00FFFFFF&
         Picture         =   "frmRegistroDueño.frx":0614
         Style           =   1  'Graphical
         TabIndex        =   33
         ToolTipText     =   "BUSCAR DISTRITO"
         Top             =   2390
         Width           =   375
      End
      Begin VB.CommandButton CMD1 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6120
         MaskColor       =   &H00FFFFFF&
         Picture         =   "frmRegistroDueño.frx":0B46
         Style           =   1  'Graphical
         TabIndex        =   32
         ToolTipText     =   "BUSCAR PROFESION"
         Top             =   2025
         Width           =   375
      End
      Begin VB.VScrollBar VScroll1 
         Height          =   315
         Left            =   6120
         Max             =   0
         Min             =   -100
         TabIndex        =   31
         Top             =   240
         Width           =   255
      End
      Begin VB.ComboBox cmbdistrito 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1320
         Sorted          =   -1  'True
         TabIndex        =   6
         Top             =   2390
         Width           =   4815
      End
      Begin VB.ComboBox cmbprofesion 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1320
         Sorted          =   -1  'True
         TabIndex        =   5
         Top             =   2025
         Width           =   4815
      End
      Begin VB.TextBox txtcodigo 
         BackColor       =   &H80000018&
         DataField       =   "CodDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1320
         Locked          =   -1  'True
         TabIndex        =   18
         Top             =   240
         Width           =   1455
      End
      Begin VB.TextBox txtnombres 
         DataField       =   "NomDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1320
         MaxLength       =   50
         TabIndex        =   0
         Top             =   585
         Width           =   5055
      End
      Begin VB.TextBox txtapellidos 
         DataField       =   "ApeDueño"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1320
         MaxLength       =   50
         TabIndex        =   1
         Top             =   940
         Width           =   5055
      End
      Begin VB.TextBox txttelefono 
         DataField       =   "Telefono"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1320
         TabIndex        =   2
         Top             =   1290
         Width           =   2295
      End
      Begin VB.TextBox txtDIRECCION 
         DataField       =   "Direccion"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1320
         MaxLength       =   50
         TabIndex        =   7
         Top             =   2740
         Width           =   5055
      End
      Begin VB.TextBox txtemail 
         DataField       =   "E-mail"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1320
         TabIndex        =   8
         Top             =   3110
         Width           =   5055
      End
      Begin VB.CommandButton CmdExaminarFoto 
         BackColor       =   &H80000013&
         Caption         =   "EXAMINAR FOTO"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   735
         Left            =   7200
         Picture         =   "frmRegistroDueño.frx":1078
         Style           =   1  'Graphical
         TabIndex        =   17
         Top             =   3360
         Width           =   2055
      End
      Begin VB.TextBox txtdni 
         DataField       =   "DNI"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1320
         MaxLength       =   11
         TabIndex        =   4
         Top             =   1670
         Width           =   2295
      End
      Begin VB.TextBox txtedad 
         DataField       =   "Edad"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   5400
         MaxLength       =   2
         TabIndex        =   3
         Top             =   240
         Width           =   735
      End
      Begin VB.Label Label12 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Observac:"
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
         Left            =   240
         TabIndex        =   35
         Top             =   3480
         Width           =   1080
      End
      Begin VB.Image Image1 
         BorderStyle     =   1  'Fixed Single
         Height          =   2775
         Left            =   6720
         Stretch         =   -1  'True
         Top             =   480
         Width           =   2775
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
         Left            =   240
         TabIndex        =   29
         Top             =   250
         Width           =   825
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Nombre:"
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
         Left            =   240
         TabIndex        =   28
         Top             =   585
         Width           =   900
      End
      Begin VB.Label Label3 
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
         Left            =   240
         TabIndex        =   27
         Top             =   940
         Width           =   1065
      End
      Begin VB.Label Label4 
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
         Left            =   240
         TabIndex        =   26
         Top             =   1290
         Width           =   1005
      End
      Begin VB.Label Label5 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Edad:"
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
         Left            =   4800
         TabIndex        =   25
         Top             =   240
         Width           =   630
      End
      Begin VB.Label Label6 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Profesión:"
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
         Left            =   240
         TabIndex        =   24
         Top             =   2025
         Width           =   1065
      End
      Begin VB.Label Label7 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Dirección:"
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
         Left            =   240
         TabIndex        =   23
         Top             =   2740
         Width           =   1065
      End
      Begin VB.Label Label8 
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
         Left            =   240
         TabIndex        =   22
         Top             =   2400
         Width           =   810
      End
      Begin VB.Label Label9 
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
         Left            =   240
         TabIndex        =   21
         Top             =   3110
         Width           =   735
      End
      Begin VB.Label Label10 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "FOTO:"
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
         Left            =   6720
         TabIndex        =   20
         Top             =   240
         Width           =   690
      End
      Begin VB.Label Label11 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "DNI/RUC:"
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
         Left            =   240
         TabIndex        =   19
         Top             =   1680
         Width           =   1020
      End
   End
   Begin VB.CommandButton CmdRegistrarMascota 
      BackColor       =   &H80000013&
      Caption         =   "MASCOTAS"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   9960
      Picture         =   "frmRegistroDueño.frx":1382
      Style           =   1  'Graphical
      TabIndex        =   15
      Top             =   3120
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   11520
      Picture         =   "frmRegistroDueño.frx":168C
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   3120
      Width           =   1455
   End
   Begin VB.CommandButton CmdBuscar 
      BackColor       =   &H80000013&
      Caption         =   "&BUSCAR"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   9960
      Picture         =   "frmRegistroDueño.frx":1996
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   2160
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   11520
      Picture         =   "frmRegistroDueño.frx":1CA0
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   1200
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   9960
      Picture         =   "frmRegistroDueño.frx":2D32
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   1200
      Width           =   1455
   End
   Begin VB.CommandButton CmdModificar 
      BackColor       =   &H80000013&
      Caption         =   "&MODIFICAR"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   11520
      Picture         =   "frmRegistroDueño.frx":35FC
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   240
      Width           =   1455
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   9960
      Picture         =   "frmRegistroDueño.frx":3A3E
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   240
      Width           =   1455
   End
End
Attribute VB_Name = "frmRegistroDueño"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text
Dim ELIM As Integer
Public NUEVO As Boolean

Friend Sub habilitar()
  CmdAnular.Enabled = Not CmdAnular.Enabled
  CmdBuscar.Enabled = Not CmdBuscar.Enabled
  CmdGuardar.Enabled = Not CmdGuardar.Enabled
  CmdModificar.Enabled = Not CmdModificar.Enabled
  CmdSalir.Enabled = Not CmdSalir.Enabled
  CmdNuevo.Enabled = Not CmdNuevo.Enabled
  Frame1.Enabled = Not Frame1.Enabled
  CMdELIMINAR.Enabled = Not CMdELIMINAR.Enabled
End Sub
Friend Sub COPIARFOTO()
On Local Error GoTo L
  Dim imsg As String, sRuta As String
  'AQUI DEVUELVE EL DIRECTORIO DE LA CARPETA IMAGENES, DONDE ESTAN FOTOS DE LOS DUEÑOS
  sRuta = ReadIni("IMAGENES", "DUEÑOS", App.Path + "\DIRECTORIOS.ini") + "\IMAGENESDUEÑOS\"
  imsg = Right(Image1.Tag, 3)
  If imsg = "gif" Then 'CONVIERTE GIF A JPG
    x = CopyFile(Image1.Tag, sRuta + txtcodigo + ".jpg", 1)
    Image1.Tag = sRuta + txtcodigo + ".jpg"
    Image1.Picture = LoadPicture(Image1.Tag)
    Exit Sub
  End If
  If imsg = "jpg" Then 'CONVIERTE JPG A JPG
    x = CopyFile(Image1.Tag, sRuta + txtcodigo + ".jpg", 1)
    Image1.Tag = sRuta + txtcodigo + ".jpg"
    Image1.Picture = LoadPicture(Image1.Tag)
    Exit Sub
  End If
  If imsg = "bmp" Then 'CONVIERTE BMP A JPG
    x = CopyFile(Image1.Tag, sRuta + txtcodigo + ".jpg", 1)
    Image1.Tag = sRuta + txtcodigo + ".jpg"
    Image1.Picture = LoadPicture(Image1.Tag)
    Exit Sub
  End If
  If imsg = "peg" Then 'CONVIERTE JPEG A JPG
    x = CopyFile(Image1.Tag, sRuta + txtcodigo + ".jpg", 1)
    Image1.Tag = sRuta + txtcodigo + ".jpg"
    Image1.Picture = LoadPicture(Image1.Tag)
    Exit Sub
  End If
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub

Private Sub Check1_Click()

End Sub

Private Sub cmbdistrito_KeyDown(KeyCode As Integer, Shift As Integer)

If KeyCode = vbKeyF1 Then frmdistrito.Show 1
End Sub

Private Sub cmbdistrito_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbdistrito, KeyAscii
End Sub

Private Sub cmbdistrito_LostFocus()
  BuscarEnCombito cmbdistrito
End Sub

Private Sub cmbprofesion_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyF1 Then frmprofesion.Show 1
End Sub

Private Sub cmbprofesion_KeyPress(KeyAscii As Integer)
  ValidarIngreso1 cmbprofesion, KeyAscii
End Sub

Private Sub cmbprofesion_LostFocus()
  BuscarEnCombito cmbprofesion
End Sub

Private Sub CMD1_Click()
frmprofesion.Show 1
End Sub

Private Sub CmdAnular_Click()
  NUEVO = False
  habilitar
  Set LIMPIAR = Me
  ELIM = 0
  optdniruc.Value = True
End Sub

Private Sub CmdBuscar_Click()
  frmBuscarDueño.Show 1
End Sub

Private Sub CMdELIMINAR_Click()
On Local Error GoTo Errlinea
  If Trim$(txtcodigo.Text) = "" Then
    MsgBox "Para Eliminar Debe Buscar Registro..!", 48
    Exit Sub
  End If
  If MsgBox("Desea Eliminar El Registro Seleccionado...!", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
  cn.Execute "delete from dueño where coddueño='" + txtcodigo + "'", XEliminar
  If XEliminar > 0 Then
    frmMensajeEliminado.Show 1
     LBLTOTAL = P_RELLENALISTADUEÑO(MSHFlexGrid1, 1, Empty)
    ELIM = 0
    Set LIMPIAR = Me
    NUEVO = False
  End If
Exit Sub
Errlinea:
    If Err.Number = -2147467259 Then
      MsgBox "No Se Puede Eliminar El Registro Porque Esta Relacionado Con Una o Más Tablas...!", vbInformation
      Exit Sub
    End If
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
End Sub

Private Sub CmdExaminarFoto_Click()
On Local Error GoTo P
    CommonDialog1.DialogTitle = "Insertar Imagén...!"
    CommonDialog1.CancelError = True
    ' Establecer los indicadores
    CommonDialog1.Flags = cdlOFNHideReadOnly
    ' Establecer los filtros
    CommonDialog1.Filter = "Archivos de Imagén GIF|*.gif|Archivos de Imagén JPG|*.jpg|Archivos de Imagén de Mapa de Bits BMP|*.bmp|Archivos de Imagén JPEG|*.jpeg"
    ' Especificar el filtro predeterminado
    CommonDialog1.FilterIndex = 2
    ' Presentar el cuadro de diálogo Abrir
    CommonDialog1.ShowOpen
    ' Presentar el nombre del archivo seleccionado
    Image1.Picture = LoadPicture(CommonDialog1.FileName)
    Image1.Tag = CommonDialog1.FileName
    If CommonDialog1.FileName <> "" Then
      ELIM = 1
    End If
Exit Sub
P:
End Sub

Private Sub CmdGuardar_Click()
On Local Error GoTo L
If Trim(txtnombres) = "" Then
  MsgBox "Ingrese Nombres...!", vbExclamation
  Exit Sub
End If
If Trim(txtapellidos) = "" Then
  MsgBox "Ingrese Apellidos...!", vbExclamation
  Exit Sub
End If
If Trim(txtdni) = "" Then
  MsgBox "Ingrese DNI...!", vbExclamation
  Exit Sub
End If
If Trim(cmbprofesion) = "" Then
  MsgBox "Ingrese Profesión...!", vbExclamation
  Exit Sub
End If
If Trim(cmbdistrito) = "" Then
  MsgBox "Ingrese Distrito...!", vbExclamation
  Exit Sub
End If
If optconsulta.Value = False And optpetshop.Value = False Then
  MsgBox "Seleccione Tipo de Cliente ...!", vbExclamation
  Exit Sub
End If
Dim T As New ADODB.Recordset

If NUEVO = True Then
  T.Open "SELECT COUNT(*) FROM DUEÑO WHERE [CODDUEÑO]='" + txtcodigo + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount > 0 Then
    txtcodigo = Left(txtcodigo, 3) + Format(Val(Right(txtcodigo, 3)) + 1, "000")
  End If
  If T.State = adStateOpen Then T.Close
  T.Open "SELECT * FROM DUEÑO", cn, adOpenDynamic, adLockOptimistic, adCmdText
  T.AddNew
  T!CodDueño = txtcodigo
Else
  T.Open "SELECT * FROM DUEÑO WHERE CodDueño='" + txtcodigo + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
End If
  If ELIM = 1 Then
    peliminafotoD txtcodigo
  End If
  COPIARFOTO
  T!NomDueño = txtnombres
  T!ApeDueño = txtapellidos
  T!telefono = txttelefono
  T!Edad = Val(txtedad)
  T!DNI = Trim(txtdni)
  T!NomProfesion = cmbprofesion
  T!direccion = txtdireccion
  T!NomDistrito = cmbdistrito
  T("E-mail") = txtemail
  T!estado = IIf(chkactivo.Value = True, 1, 0)
  T!TIPO = IIf(optconsulta.Value = True, 0, 1)
  T!observaciones = Trim(txtobservaaciones)
  If Image1.Tag <> "" Then
    T("FotoDueño") = ReadIni("IMAGENES", "DUEÑOS", App.Path + "\DIRECTORIOS.ini") + "\IMAGENESDUEÑOS" + "\" + txtcodigo + ".jpg"
  End If
  T.Update
  Set T = Nothing
  If NUEVO = True Then
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  habilitar
  LBLTOTAL = P_RELLENALISTADUEÑO(MSHFlexGrid1, 1, Empty)
  NUEVO = False
  ELIM = 0
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
Private Sub CmdModificar_Click()
If Trim(txtcodigo) = "" Then
MsgBox "BUSCAR REGISTRO...!", vbExclamation
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
txtnombres.SetFocus
ELIM = 0
Image1.Picture = LoadPicture("")
Image1.Tag = ""
optdniruc.Value = True
optconsulta.Value = True
End Sub

Private Sub CmdRegistrarMascota_Click()
If txtcodigo = Empty Then
  MsgBox "BUSCAR REGISTRO...!", vbInformation
  Exit Sub
End If
  frmRegistroMascota.Show 1
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Command1_Click()
frmdistrito.Show 1
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
  P_RellenaCombo "PRO", cmbprofesion
  P_RellenaCombo "DIS", cmbdistrito
  V_DUEÑO = True
  Centrar_Objeto Me
 LBLTOTAL = P_RELLENALISTADUEÑO(MSHFlexGrid1, 1, Empty)
optdniruc.Value = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_DUEÑO = False
If V_NOTASALI = True Then
  x = FrmNotaSalida.cmbcliente
  P_RellenaCombo "CLI", FrmNotaSalida.cmbcliente
  FrmNotaSalida.cmbcliente = x
End If
Set frmRegistroDueño = Nothing
End Sub

Private Sub MSHFlexGrid1_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If NUEVO = True Then Exit Sub
  txtcodigo = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  txtnombres = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  txtapellidos = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  txttelefono = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
  txtedad = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
  txtdni = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6)
  cmbprofesion = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 7)
  txtdireccion = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 8)
  cmbdistrito = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 9)
  txtemail = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 10)
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 14) = "Consulta" Then optconsulta.Value = True
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 14) = "Petshop" Then optpetshop.Value = True
  txtobservaaciones = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 13)
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12) = "Activo" Then chkactivo.Value = False
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12) = "Inactivo" Then chkactivo.Value = True
    NUEVO = False
  On Error GoTo P
  Image1.Picture = LoadPicture(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 11))
  Image1.Tag = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 11)
Exit Sub
P:
  frmRegistroDueño.Image1.Picture = LoadPicture("")
End Sub

Private Sub MSHFlexGrid1_DblClick()
If V_NOTASALI = True Then
  P_RellenaCombo "CLI", FrmNotaSalida.cmbcliente
  FrmNotaSalida.cmbcliente = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  Unload Me
End If
If V_FACTURACION = True Then
  P_RellenaCombo "CLI", FrmFacturacion.cmbcliente
  FrmFacturacion.cmbcliente = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
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


Private Sub txtapellidos_Change()
  If NUEVO = True Then
    txtcodigo = CodigoDueño(txtapellidos, txtnombres)
  End If
End Sub

Private Sub txtapellidos_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
Private Sub txtdistrito_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtbuscar_Change()
  If optnombre.Value = True Then
    LBLTOTAL = P_RELLENALISTADUEÑO(MSHFlexGrid1, 1, Trim(txtbuscar))
    Exit Sub
  End If
  If optapellido.Value = True Then
    LBLTOTAL = P_RELLENALISTADUEÑO(MSHFlexGrid1, 2, Trim(txtbuscar))
    Exit Sub
  End If
  If optdniruc.Value = True Then
    LBLTOTAL = P_RELLENALISTADUEÑO(MSHFlexGrid1, 3, Trim(txtbuscar))
    Exit Sub
  End If
  If OPTDISTRITO.Value = True Then
    LBLTOTAL = P_RELLENALISTADUEÑO(MSHFlexGrid1, 4, Trim(txtbuscar))
    Exit Sub
  End If
End Sub

Private Sub txtbuscar_KeyPress(KeyAscii As Integer)
If KeyAscii = Asc("'") Then KeyAscii = 0
End Sub

Private Sub txtDIRECCION_KeyPress(KeyAscii As Integer)
If KeyAscii = Asc("'") Then KeyAscii = 0
End Sub

Private Sub txtdni_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 4
End Sub
Private Sub txtedad_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 4
End Sub


Private Sub txtemail_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtnombres_Change()
If NUEVO = True Then
  txtcodigo = CodigoDueño(txtapellidos, txtnombres)
End If
End Sub
Private Sub txtnombres_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
Private Sub txttelefono_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 7
End Sub

Private Sub VScroll1_Change()
txtedad = Val(VScroll1.Value) * -1
End Sub

