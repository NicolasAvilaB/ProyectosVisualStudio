VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form FrmRegistrarPago 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "REGISTRAR PAGO"
   ClientHeight    =   8685
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9840
   ForeColor       =   &H00B0726D&
   Icon            =   "frmRegistroPago.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   8685
   ScaleWidth      =   9840
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Imprimir 
      BackColor       =   &H80000013&
      Caption         =   "Imprimir"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3480
      Style           =   1  'Graphical
      TabIndex        =   47
      Top             =   8160
      Width           =   1335
   End
   Begin VB.ComboBox Combo1 
      Height          =   315
      Left            =   9240
      Sorted          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   46
      Top             =   3480
      Visible         =   0   'False
      Width           =   390
   End
   Begin VB.ComboBox cmbdescripcion 
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
      Left            =   5040
      Sorted          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   45
      Top             =   3000
      Width           =   4575
   End
   Begin VB.TextBox txtsubtotal 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   285
      Left            =   8040
      TabIndex        =   43
      Top             =   6840
      Width           =   1575
   End
   Begin VB.CommandButton cmdbuscar 
      BackColor       =   &H80000013&
      Caption         =   "Buscar"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7080
      Style           =   1  'Graphical
      TabIndex        =   41
      Top             =   7440
      Width           =   1215
   End
   Begin MSComCtl2.DTPicker dtinicio 
      Height          =   375
      Left            =   3120
      TabIndex        =   40
      Top             =   2400
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   661
      _Version        =   393216
      Format          =   47972353
      CurrentDate     =   39258
   End
   Begin VB.TextBox txtechatermino 
      BackColor       =   &H80000018&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1800
      Locked          =   -1  'True
      TabIndex        =   39
      Top             =   3360
      Width           =   1335
   End
   Begin VB.TextBox Text3 
      Height          =   375
      Left            =   10560
      TabIndex        =   37
      Top             =   3600
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.TextBox txtfechapago 
      BackColor       =   &H80000018&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1800
      Locked          =   -1  'True
      TabIndex        =   36
      Top             =   2880
      Width           =   1335
   End
   Begin VB.TextBox txtechainicio 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1800
      TabIndex        =   33
      Top             =   2400
      Width           =   1335
   End
   Begin VB.TextBox txtNSerie 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5040
      TabIndex        =   32
      Top             =   2520
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.TextBox txtsaldoporcuota 
      BackColor       =   &H80000018&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8160
      Locked          =   -1  'True
      TabIndex        =   30
      Top             =   2040
      Width           =   1455
   End
   Begin VB.TextBox txtcuotas 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8160
      TabIndex        =   5
      Top             =   1560
      Width           =   1455
   End
   Begin VB.TextBox txtsaldo 
      BackColor       =   &H80000018&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5040
      Locked          =   -1  'True
      TabIndex        =   27
      Top             =   2040
      Width           =   1455
   End
   Begin VB.TextBox txtprecio 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7680
      TabIndex        =   3
      Top             =   3480
      Width           =   1455
   End
   Begin VB.CommandButton cmdnuevo 
      BackColor       =   &H80000013&
      Caption         =   "Nuevo"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1800
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   7440
      Width           =   1215
   End
   Begin VB.CommandButton cmdmascoa 
      BackColor       =   &H80000017&
      Height          =   350
      Left            =   2640
      MaskColor       =   &H00FFFFFF&
      Picture         =   "frmRegistroPago.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   23
      ToolTipText     =   "BUSCAR MASCOTA"
      Top             =   720
      Width           =   375
   End
   Begin VB.CommandButton cmdDUEÑO 
      BackColor       =   &H80000017&
      Height          =   350
      Left            =   2640
      MaskColor       =   &H00FFFFFF&
      Picture         =   "frmRegistroPago.frx":083C
      Style           =   1  'Graphical
      TabIndex        =   22
      ToolTipText     =   "BUSCAR DUEÑO"
      Top             =   240
      Width           =   375
   End
   Begin VB.CommandButton CmdHIstCli 
      BackColor       =   &H80000013&
      Caption         =   "H/C"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4920
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   8160
      Width           =   1215
   End
   Begin VB.CommandButton CmdBoleta 
      BackColor       =   &H80000013&
      Caption         =   "Boleta"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   8160
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "Anular"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5760
      Style           =   1  'Graphical
      TabIndex        =   17
      Top             =   7440
      Width           =   1215
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "Salir"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8400
      Style           =   1  'Graphical
      TabIndex        =   16
      Top             =   8160
      Width           =   1215
   End
   Begin VB.CommandButton CmdCancelar 
      BackColor       =   &H80000013&
      Caption         =   "Cancelar"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4440
      Style           =   1  'Graphical
      TabIndex        =   15
      Top             =   7440
      Width           =   1215
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "Guardar"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3120
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   7440
      Width           =   1215
   End
   Begin VB.TextBox txtcantidad 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5040
      TabIndex        =   2
      Top             =   3480
      Width           =   1455
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Caption         =   "Tipo de Pago"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   975
      Left            =   120
      TabIndex        =   11
      Top             =   1320
      Width           =   3255
      Begin VB.OptionButton optcredito 
         BackColor       =   &H00B0726D&
         Caption         =   "Credito"
         BeginProperty Font 
            Name            =   "Monotype Corsiva"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   1680
         TabIndex        =   21
         Top             =   480
         Width           =   1455
      End
      Begin VB.OptionButton optcontado 
         BackColor       =   &H00B0726D&
         Caption         =   "Contado"
         BeginProperty Font 
            Name            =   "Monotype Corsiva"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   20
         Top             =   480
         Width           =   1575
      End
   End
   Begin VB.TextBox txtacuenta 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5040
      TabIndex        =   4
      Top             =   1560
      Width           =   1455
   End
   Begin VB.TextBox txtcodmasota 
      BackColor       =   &H80000018&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1440
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   720
      Width           =   1215
   End
   Begin VB.TextBox txtnboleta 
      Alignment       =   2  'Center
      BackColor       =   &H80000018&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7920
      TabIndex        =   8
      Top             =   480
      Width           =   1695
   End
   Begin VB.TextBox txtcoddueño 
      BackColor       =   &H80000018&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1440
      Locked          =   -1  'True
      TabIndex        =   0
      Top             =   240
      Width           =   1215
   End
   Begin VB.CommandButton CmdAgregarItem 
      BackColor       =   &H80000013&
      Caption         =   "Agregar Item"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8040
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   4080
      Width           =   1575
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   2055
      Left            =   120
      TabIndex        =   42
      Top             =   4680
      Width           =   9495
      _ExtentX        =   16748
      _ExtentY        =   3625
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
   Begin VB.Label LBLMASCOTA 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   3000
      TabIndex        =   49
      Top             =   720
      Width           =   4815
   End
   Begin VB.Label LBLCLIENTE 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   3000
      TabIndex        =   48
      Top             =   240
      Width           =   4815
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Sub-Total:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   6600
      TabIndex        =   44
      Top             =   6840
      Width           =   1335
   End
   Begin VB.Label lblfechatermino 
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha Término:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   615
      Left            =   240
      TabIndex        =   38
      Top             =   3300
      Width           =   1575
   End
   Begin VB.Label lblfechapago 
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha Pago:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   35
      Top             =   2880
      Width           =   1575
   End
   Begin VB.Label lblfechainicio 
      BackStyle       =   0  'Transparent
      Caption         =   "FechaInicio:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   34
      Top             =   2400
      Width           =   1455
   End
   Begin VB.Label lblsaldoxcuota 
      BackStyle       =   0  'Transparent
      Caption         =   "Pago x Cuota:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   615
      Left            =   6720
      TabIndex        =   31
      Top             =   1995
      Width           =   1335
   End
   Begin VB.Label lblncuota 
      BackStyle       =   0  'Transparent
      Caption         =   "Nº Cuotas:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   6720
      TabIndex        =   29
      Top             =   1560
      Width           =   1335
   End
   Begin VB.Label lblsaldo 
      BackStyle       =   0  'Transparent
      Caption         =   "Saldo Total:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   615
      Left            =   3600
      TabIndex        =   28
      Top             =   1980
      Width           =   1335
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "Precio"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0080FFFF&
      Height          =   375
      Left            =   6720
      TabIndex        =   26
      Top             =   3480
      Width           =   1215
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Descripción"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0080FFFF&
      Height          =   375
      Left            =   3600
      TabIndex        =   24
      Top             =   3000
      Width           =   1455
   End
   Begin VB.Line Line5 
      BorderColor     =   &H80000009&
      BorderWidth     =   3
      X1              =   0
      X2              =   9840
      Y1              =   8640
      Y2              =   8640
   End
   Begin VB.Line Line4 
      BorderColor     =   &H80000009&
      BorderWidth     =   3
      X1              =   0
      X2              =   9840
      Y1              =   7920
      Y2              =   7920
   End
   Begin VB.Line Line3 
      BorderColor     =   &H80000009&
      BorderWidth     =   3
      X1              =   0
      X2              =   9840
      Y1              =   7200
      Y2              =   7200
   End
   Begin VB.Line Line2 
      BorderColor     =   &H80000009&
      BorderWidth     =   3
      X1              =   0
      X2              =   9840
      Y1              =   4560
      Y2              =   4560
   End
   Begin VB.Line Line1 
      BorderColor     =   &H8000000E&
      BorderWidth     =   3
      X1              =   0
      X2              =   9840
      Y1              =   1200
      Y2              =   1200
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "Cantidad"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0080FFFF&
      Height          =   375
      Left            =   3600
      TabIndex        =   12
      Top             =   3480
      Width           =   1215
   End
   Begin VB.Label lblacuenta 
      BackStyle       =   0  'Transparent
      Caption         =   "A Cuenta:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   3600
      TabIndex        =   10
      Top             =   1560
      Width           =   1215
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Mascota:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   9
      Top             =   720
      Width           =   1215
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Nº Boleta:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   8040
      TabIndex        =   7
      Top             =   120
      Width           =   1335
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Dueño:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Top             =   240
      Width           =   1215
   End
End
Attribute VB_Name = "FrmRegistrarPago"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public FecEmi As Date
Public NUEVO As Boolean
Dim pNuevoA As Boolean
Public Sub subtotales()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then
txtsubtotal = 0
Exit Sub
End If
txtsubtotal = "0"
For I = 1 To MSHFlexGrid1.Rows - 1
  txtsubtotal = txtsubtotal + Val(MSHFlexGrid1.TextMatrix(I, 6))
Next
End Sub
Sub LIMPIARDETALLES()
On Error Resume Next
cmbdescripcion.ListIndex = 0
txtcantidad = Empty
TXTprecio = Empty
On Error GoTo 0
End Sub
Sub LIMPIAR_TEXTOS()
On Error Resume Next
If optcontado.Value = True Then
    cmbdescripcion.ListIndex = 0
    txtcantidad = ""
    TXTprecio = Empty
End If
If optcredito.Value = True Then
    cmbdescripcion.ListIndex = 0
    txtcantidad = ""
    TXTprecio = Empty
    txtacuenta = Empty
    txtsaldo = ""
    txtsaldoporcuota = ""
    If optcredito.Value = False Then
      txtfechapago = ""
      txtechatermino = ""
      txtechainicio = Empty
    End If
    txtNSerie = ""
End If
On Error GoTo 0
End Sub
Function PGuardarTodo() As Integer
On Local Error GoTo L

Dim T As New ADODB.Recordset
Dim XNSERIE As String
    If txtcoddueño = "" Then
        MsgBox "BUSCAR DUEÑO...!", vbExclamation
        Exit Function
    End If
    If txtcodmasota = "" Then
        MsgBox "BUSCAR MASCOTA...!", vbExclamation
        Exit Function
    End If
If optcontado.Value = True Then
    If NUEVO = True Then
            T.Open "SELECT * FROM PAGO", cn, adOpenDynamic, adLockOptimistic
            T.AddNew
            T("Nº Boleta") = txtnboleta
            T!CodDueño = txtcoddueño
            T!CodMascota = txtcodmasota
            T!FechaEmision = CDate(Format(Date, "dd/mm/yyyy"))
            T!TipoPago = IIf(optcontado.Value = True, "Contado", "Credito")
            T!cancelado = 1
            T!anulado = 0
            T.Update
            Set T = Nothing
            PGuardarTodo = 1
            subtotales
            Exit Function
        Else
            T.Open "SELECT * FROM PAGO WHERE [Nº Boleta]='" + txtnboleta + "'", cn, adOpenDynamic, adLockOptimistic
            T!CodDueño = txtcoddueño
            T!CodMascota = txtcodmasota
            T!FechaEmision = CDate(Format$(FecEmi, "dd/mm/yyyy"))
            T!TipoPago = IIf(optcontado.Value = True, "Contado", "Credito")
            T!anulado = 0
            T!cancelado = 1
            T.Update
            Set T = Nothing
            PGuardarTodo = 2
            subtotales
            Exit Function
    End If
End If
If optcredito.Value = True Then
    If NUEVO = True Then
            T.Open "SELECT * FROM PAGO", cn, adOpenDynamic, adLockOptimistic
            T.AddNew
            T("Nº Boleta") = txtnboleta
            T!CodDueño = txtcoddueño
            T!CodMascota = txtcodmasota
            T!FechaEmision = CDate(Format(Date, "dd/mm/yyyy"))
            T!TipoPago = IIf(optcontado.Value = True, "Contado", "Credito")
            T!cancelado = 0
            T!fechainicio = CDate(IIf(txtechainicio = "", CStr(Date), txtechainicio))
            T!fechapago = CDate(IIf(txtfechapago = "", CStr(Date), txtfechapago))
            T!fechatermino = CDate(IIf(txtechatermino = "", CStr(Date), txtechatermino))
            T!acuenta = Val(txtacuenta)
            T!saldo = Val(txtsaldo)
            T!ncuotas = Val(txtcuotas)
            T!montocuotas = Val(txtsaldoporcuota)
            T!anulado = 0
            T.Update
            Set T = Nothing
            PGuardarTodo = 1
            subtotales
            Call GuardarDeudas
            txtacuenta_Change
            Exit Function
        Else
            T.Open "SELECT * FROM PAGO WHERE [Nº Boleta]='" + txtnboleta + "'", cn, adOpenDynamic, adLockOptimistic
            T!CodDueño = txtcoddueño
            T!CodMascota = txtcodmasota
            T!FechaEmision = CDate(Format$(FecEmi, "dd/mm/yyyy"))
            T!TipoPago = IIf(optcontado.Value = True, "Contado", "Credito")
            T!anulado = 0
            T!cancelado = 0
            T!fechainicio = CDate(IIf(txtechainicio = "", CStr(Date), txtechainicio))
            T!fechapago = CDate(IIf(txtfechapago = "", CStr(Date), txtfechapago))
            T!fechatermino = CDate(IIf(txtechatermino = "", CStr(Date), txtechatermino))
            T!acuenta = Val(txtacuenta)
            T!saldo = Val(txtsaldo)
            T!ncuotas = Val(txtcuotas)
            T!montocuotas = Val(txtsaldoporcuota)
            T.Update
            Set T = Nothing
            PGuardarTodo = 2
            subtotales
            Call GuardarDeudas
            txtacuenta_Change
            Exit Function
    End If
End If
Exit Function
L:
If Err.Number = -2147467259 Then
NUEVO = False
Exit Function
End If
MsgBox Err.Description, vbCritical
End Function

Private Sub cmbdescripcion_Click()
Combo1.ListIndex = cmbdescripcion.ListIndex
End Sub

Private Sub CmdAgregarItem_Click()
On Local Error GoTo L
If txtcoddueño = "" Then
MsgBox "Buscar Dueño....!", vbExclamation
Exit Sub
End If
If txtcodmasota = "" Then
MsgBox "Buscar Mascota....!", vbExclamation
Exit Sub
End If
If cmbdescripcion = "" Then
MsgBox "Falta el Campo Descripción...!", vbExclamation
Exit Sub
End If
If Val(txtcantidad) <= 0 Then
MsgBox Err.Description, vbExclamation
Exit Sub
End If
If Val(TXTprecio) <= 0 Then
MsgBox Err.Description, vbExclamation
Exit Sub
End If
If FecEmi < Date Then
  MsgBox "No Se Puede Agregar ó Modificar El Registro...!" + Chr(13) + "Ha Sido Registrado el :" + CStr(FecEmi), vbInformation
  Exit Sub
End If
If pNuevoA = True Then
  If MsgBox("¿Desea Agregar Nuevo Detalle A La Lista....?", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
Else
  If MsgBox("¿Desea Actualizar El Item de La Fila Seleccionada En El Detalle De La Lista....?", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
End If

If pNuevoA = True Then
    If MSHFlexGrid1.TextMatrix(1, 1) = "" Then
            MSHFlexGrid1.Cols = 7
            MSHFlexGrid1.FormatString = "|<Nº|<Nº Boleta|<Descripción|>Cantidad|>Precio|>Total"
            MSHFlexGrid1.ColWidth(0) = 0
            MSHFlexGrid1.ColWidth(1) = 800
            MSHFlexGrid1.ColWidth(2) = 0
            MSHFlexGrid1.ColWidth(3) = 5600
            MSHFlexGrid1.ColWidth(4) = 1000
            MSHFlexGrid1.ColWidth(5) = 1000
            MSHFlexGrid1.ColWidth(6) = 1000
            MSHFlexGrid1.TextMatrix(1, 1) = SERIES(txtnboleta)
            MSHFlexGrid1.TextMatrix(1, 2) = txtnboleta
            MSHFlexGrid1.TextMatrix(1, 3) = cmbdescripcion
            MSHFlexGrid1.TextMatrix(1, 4) = txtcantidad
            MSHFlexGrid1.TextMatrix(1, 5) = TXTprecio
            MSHFlexGrid1.TextMatrix(1, 6) = Format$(Val(txtcantidad) * Val(TXTprecio), "###.00")
            pNuevoA = True
            PGuardarTodo
            
    Else
            MSHFlexGrid1.Rows = MSHFlexGrid1.Rows + 1
            MSHFlexGrid1.TextMatrix(MSHFlexGrid1.Rows - 1, 1) = SERIES(txtnboleta)
            MSHFlexGrid1.TextMatrix(MSHFlexGrid1.Rows - 1, 2) = txtnboleta
            MSHFlexGrid1.TextMatrix(MSHFlexGrid1.Rows - 1, 3) = cmbdescripcion
            MSHFlexGrid1.TextMatrix(MSHFlexGrid1.Rows - 1, 4) = txtcantidad
            MSHFlexGrid1.TextMatrix(MSHFlexGrid1.Rows - 1, 5) = TXTprecio
            MSHFlexGrid1.TextMatrix(MSHFlexGrid1.Rows - 1, 6) = Format$(Val(txtcantidad) * Val(TXTprecio), "###.00")
            pNuevoA = True
            subtotales
    End If
Else
    MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3) = cmbdescripcion
    MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4) = txtcantidad
    MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5) = TXTprecio
    MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6) = Format$(Val(txtcantidad) * Val(TXTprecio), "###.00")
    pNuevoA = True
    subtotales
End If
    subtotales
    Dim T As New ADODB.Recordset
    cn.Execute "DELETE FROM DETALLEPAGO WHERE [Nº Boleta]='" + txtnboleta + "'"
    T.Open "SELECT * FROM DETALLEPAGO", cn, adOpenDynamic, adLockOptimistic
    For I = 1 To MSHFlexGrid1.Rows - 1
        T.AddNew
        T!nserie = MSHFlexGrid1.TextMatrix(I, 1)
        T("Nº Boleta") = MSHFlexGrid1.TextMatrix(I, 2)
        T!descripcion = MSHFlexGrid1.TextMatrix(I, 3)
        T!CANTIDAD = MSHFlexGrid1.TextMatrix(I, 4)
        T!precio = MSHFlexGrid1.TextMatrix(I, 5)
        T!TOTAL = MSHFlexGrid1.TextMatrix(I, 6)
        T.Update
    Next
    Set T = Nothing
    txtacuenta_Change
    Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Private Sub CmdAnular_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
On Local Error GoTo L
If FecEmi < Date Then
  MsgBox "No Se Puede Anular ó Modificar El Registro...!" + Chr(13) + "Ha Sido Registrado el :" + CStr(FecEmi), vbInformation
  Exit Sub
End If
x = MsgBox("¿Desea Anular El Registro Activo?", vbQuestion + vbYesNo + vbDefaultButton2)
If x = vbYes Then
  cn.Execute "UPDATE PAGO SET ANULADO=1 WHERE  [Nº Boleta]='" + txtnboleta + "'", I
  If I > 0 Then
    MsgBox "REGISTRO ANULADO...!", vbInformation
    CmdNuevo_Click
  End If
End If
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub

Private Sub CmdBoleta_Click()
If txtcoddueño = "" Then Exit Sub
If txtcodmasota = "" Then Exit Sub
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
FrmReportes.Show 1
End Sub

Friend Sub ImprimeBOLETA()
On Local Error GoTo L
  Dim Capa1 As New ClsMonedaALetras
  MousePointer = vbHourglass
  DoEvents
  Printer.CurrentY = 2600
  Printer.CurrentX = 1000
  Printer.Print CStr(Day(Date)) + Space(24) + CStr(MonthName(Month(Date))) + Space(30) + Right(CStr(Year(Date)), 1)
  Printer.CurrentY = 3000
  Printer.CurrentX = 1400
  Printer.Print LBLCLIENTE
  Printer.CurrentY = 3000
  Printer.CurrentX = 9400
  Printer.Print DNICLI(txtcoddueño)
  Printer.CurrentY = 3500
  Printer.CurrentX = 1600
  Printer.Print Capa1.olpol(Val(txtsubtotal)) + " Nuevos Soles"
  Printer.CurrentY = 4250
  Printer.CurrentX = 1000
  For I = 1 To MSHFlexGrid1.Rows - 1
    Printer.CurrentY = Printer.CurrentY + 100
    Printer.CurrentX = 1000
    Printer.Print MSHFlexGrid1.TextMatrix(I, 3)
    Printer.CurrentX = 9400
    Printer.Print MSHFlexGrid1.TextMatrix(I, 6)
  Next
  Printer.CurrentY = 6950
  Printer.CurrentX = 9400
  Printer.Print txtsubtotal
  Printer.CurrentY = 8150
  Printer.CurrentX = 9400
  Printer.Print txtsubtotal
  MousePointer = vbDefault
  Printer.EndDoc
  Exit Sub
L:
    MsgBox Err.Description, vbCritical
End Sub
Function DNICLI(CODSS As String) As String
On Error GoTo L
  Dim DD As New ADODB.Recordset
  DD.Open "SELECT DNI FROM Dueño WHERE CODDUEÑO='" + CODSS + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR DD
  If DD.RecordCount = 0 Then
    Set DD = Nothing
    Exit Function
  End If
  DNICLI = DD(0)
  Set DD = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function
Private Sub CmdBuscar_Click()
frmbuscarboleta.Show 1
End Sub

Private Sub Cmdcancelar_Click()
Set LIMPIAR = Me
With MSHFlexGrid1
.Cols = 2
.Rows = 2
.Clear
End With
optcontado.Value = True
NUEVO = False
FecEmi = Date

End Sub

Private Sub cmdDUEÑO_Click()
If NUEVO = False Then Exit Sub
frmBuscarDueño.Show 1
End Sub


Private Sub CmdGuardar_Click()
If optcredito.Value = True Then
  If Val(txtacuenta) <= 0 And Val(txtcuotas) <= 0 And MSHFlexGrid1.TextMatrix(1, 1) <> "" Then
    MsgBox "Ingresar A Cuenta,  Nº Cuotas...!", vbExclamation
    Exit Sub
  End If
End If
If FecEmi < Date Then
  MsgBox "No Se Puede Agregar ó Modificar El Registro...!" + Chr(13) + "Ha Sido Registrado el :" + CStr(FecEmi), vbInformation
  Exit Sub
End If
x = PGuardarTodo
If x = 1 Then
  frmMensajeNuevo.Show 1
ElseIf x = 2 Then
    MsgBox "SE AÑADIÓ...!", vbInformation
End If
End Sub

Friend Sub GuardarDeudas()
On Error GoTo L
If optcredito.Value = True Then
  Dim rs As New ADODB.Recordset
  rs.Open "SELECT * FROM PAGO WHERE [Nº BOLETA]='" + txtnboleta + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    Set rs = Nothing
    Exit Sub
  End If
  If rs!cancelado = 1 Then
    Set rs = Nothing
    Exit Sub
  End If
  Dim Nto As Double
  Nto = Val(txtcuotas)
  cn.Execute "DELETE * FROM DEUDAS WHERE [Nº BOLETA]='" + txtnboleta + "'"
  If rs.State = adStateOpen Then rs.Close
  rs.Open "select * from deudas", cn, adOpenDynamic, adLockOptimistic
  For I = 1 To Nto
    rs.AddNew
    rs("Nº BOLETA") = txtnboleta
    rs!cancelado = 0
    If I = 1 Then
      rs!FECPAGO = txtechainicio
    Else 'AGREGA UN MES POR PAGOS
      rs!FECPAGO = DateAdd("M", I - 1, CDate(txtechainicio))
      DD = CStr(DateAdd("M", I - 1, CDate(txtechainicio)))
    End If
    rs!MONTO = Val(txtsaldoporcuota)
    rs.Update
    rs.MoveNext
  Next
  txtfechapago = txtechainicio
  If Val(txtcuotas) > 1 Then
  txtechatermino = DD
  Else
  txtechatermino = txtechainicio
  End If
  
  Set rs = Nothing
End If
Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub

Private Sub CmdHIstCli_Click()
If txtcoddueño = "" Then Exit Sub
If txtcodmasota = "" Then Exit Sub
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
frmEmisionHC.Show 1
End Sub

Private Sub cmdmascoa_Click()
If NUEVO = False Then Exit Sub
frmBuscarMascota.Show 1
End Sub

Private Sub CmdNuevo_Click()
  Set LIMPIAR = Me
  With MSHFlexGrid1
    .Cols = 2
    .Rows = 2
    .Clear
  End With
  txtnboleta = N_BOLETA
  optcontado.Value = True
  NUEVO = True
  FecEmi = Date
  txtNSerie = SERIES(txtnboleta)
  pNuevoA = True
  LIMPIARDETALLES
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Combo1_Click()
TXTprecio = Combo1
End Sub

Private Sub dtinicio_Change()
txtechainicio = Format(CDate(dtinicio), "dd/mm/yyyy")
End Sub

Private Sub dtpago_Change()
txtfechapago = Format(CDate(dtpago), "dd/mm/yyyy")
End Sub

Private Sub dttermino_Change()
txtechatermino = Format(CDate(dttermino), "dd/mm/yyyy")
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me

End Sub

Private Sub Form_Load()
 V_PAGO = True
CmdNuevo_Click
dtinicio.Value = DateSerial(Year(Date), Month(Date), 1)
Call rekke
End Sub
Friend Function rekke()
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "select descripcion,costo from [examen complementario] where propio='si'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  cmbdescripcion.AddItem Empty
  cmbdescripcion.ItemData(cmbdescripcion.NewIndex) = 0
  Combo1.AddItem Empty
  Combo1.ItemData(Combo1.NewIndex) = 0
  I = 1
  Do While rs.EOF = False
    cmbdescripcion.AddItem rs(0)
    cmbdescripcion.ItemData(cmbdescripcion.NewIndex) = I
    Combo1.AddItem rs(1)
    Combo1.ItemData(Combo1.NewIndex) = I
    rs.MoveNext
    I = I + 1
  Loop
  If rs.State = adStateOpen Then rs.Close
  rs.Open "select desservicio,costo from servicios", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  Do While rs.EOF = False
    cmbdescripcion.AddItem rs(0)
    cmbdescripcion.ItemData(cmbdescripcion.NewIndex) = I
    Combo1.AddItem rs(1)
    Combo1.ItemData(Combo1.NewIndex) = I
    rs.MoveNext
    I = I + 1
  Loop
  If rs.State = adStateOpen Then
    Set rs = Nothing
  End If
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Private Sub Form_Unload(Cancel As Integer)
V_PAGO = False
End Sub

Private Sub Imprimir_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If MsgBox("¿Desea Imprimir Comprobante...?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
  Call ImprimeBOLETA
End If
End Sub

Private Sub MSHFlexGrid1_DblClick()
    If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
    txtNSerie = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
    cmbdescripcion = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
    txtcantidad = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
    TXTprecio = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
    NUEVO = False
    pNuevoA = False
End Sub

Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyDelete Then
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If Button = 2 Then
  If FecEmi < Date Then
    MsgBox "No Se Puede Agregar ó Modificar El Registro...!" + Chr(13) + "Ha Sido Registrado el :" + CStr(FecEmi), vbInformation
    Exit Sub
  End If
    If MsgBox("¿Desea Eliminar El Registro Seleccionado...?", vbYesNo + vbDefaultButton2 + vbQuestion) = vbYes Then
        cn.Execute "DELETE * FROM DETALLEPAGO WHERE [Nº Boleta]='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + "' AND NSERIE='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1) + "'"
        P_RELLENALISTADETALLEPAGO MSHFlexGrid1, txtnboleta
    End If
End If
End If
End Sub

Private Sub MSHFlexGrid1_MouseDown(Button As Integer, Shift As Integer, x As Single, Y As Single)
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If Button = 2 Then
    If MsgBox("¿Desea Eliminar El Registro Seleccionado...?", vbYesNo + vbDefaultButton2 + vbQuestion) = vbYes Then
        cn.Execute "DELETE * FROM DETALLEPAGO WHERE [Nº Boleta]='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + "' AND NSERIE='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1) + "'"
        P_RELLENALISTADETALLEPAGO MSHFlexGrid1, txtnboleta
    End If
End If
End Sub

Private Sub MSHFlexGrid1_MouseMove(Button As Integer, Shift As Integer, x As Single, Y As Single)
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then
MSHFlexGrid1.ToolTipText = ""
End If
MSHFlexGrid1.ToolTipText = "PARA ELIMINAR SELECCIONE REGISTRO Y HACER CLICK DERECHO...!"

End Sub

Private Sub optcontado_Click()
  habi False
End Sub
Private Sub optcredito_Click()
  habi True
  txtechainicio = Format$(Date, "dd/mm/yyyy")
  txtfechapago = Format$(Date, "dd/mm/yyyy")
  txtechatermino = Format$(Date, "dd/mm/yyyy")
End Sub

Private Sub Text2_Change()

End Sub

Private Sub Text4_Change()

End Sub

Public Sub txtacuenta_Change()
On Error Resume Next
    txtsaldo = Format$(Val(txtsubtotal) - Val(txtacuenta))
    txtsaldoporcuota = Format$(Val(txtsaldo) / Val(txtcuotas), "###.00")
On Local Error GoTo 0
End Sub

Private Sub txtacuenta_KeyPress(KeyAscii As Integer)
Mod_Prodims.xRestringir KeyAscii, 3
End Sub
Sub habi(dass As Boolean)
lblacuenta.Visible = dass
txtacuenta.Visible = dass
lblsaldo.Visible = dass
txtsaldo.Visible = dass
lblsaldoxcuota.Visible = dass
txtsaldoporcuota.Visible = dass
lblncuota.Visible = dass
txtcuotas.Visible = dass
lblfechainicio.Visible = dass
lblfechapago.Visible = dass
lblfechatermino.Visible = dass
txtfechapago.Visible = dass
txtechatermino.Visible = dass
txtechainicio.Visible = dass
dtinicio.Visible = dass
  txtcuotas = 1
End Sub



Private Sub txtcantidad_Change()
txtacuenta_Change
End Sub

Private Sub txtcantidad_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 4
End Sub

Private Sub txtcuotas_Change()
txtacuenta_Change
End Sub

Private Sub txtcuotas_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 4
End Sub



Private Sub txtechainicio_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 1
End Sub

Private Sub txtechainicio_LostFocus()
If IsDate(txtechainicio) = False Then
  txtechainicio = ""
  Else
  txtechainicio = Format$(CDate(txtechainicio), "dd/mm/yyyy")
End If
End Sub

Private Sub txtechatermino_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 1
End Sub

Private Sub txtechatermino_LostFocus()
If IsDate(txtechatermino) = False Then
  txtechatermino = ""
  Else
  txtechatermino = Format$(CDate(txtechatermino), "dd/mm/yyyy")
End If
End Sub

Private Sub txtfechapago_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 1
End Sub

Private Sub txtfechapago_LostFocus()
If IsDate(txtfechapago) = False Then
  txtfechapago = ""
  Else
  txtfechapago = Format$(CDate(txtfechapago), "dd/mm/yyyy")
End If
End Sub

Private Sub txtprecio_Change()
txtacuenta_Change
End Sub

Private Sub txtprecio_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 3
End Sub



