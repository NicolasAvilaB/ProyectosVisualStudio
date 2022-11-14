<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bodega_User
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bodega_User))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.modcode = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.num1 = New System.Windows.Forms.NumericUpDown()
        Me.gur = New System.Windows.Forms.Button()
        Me.estad = New System.Windows.Forms.TextBox()
        Me.cantidaDESSSS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.itemss = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.hc = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.devolucion_articulos = New System.Windows.Forms.Button()
        Me.rutees = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.busqueda_rut = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Grilla_Bodega = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.cantied = New System.Windows.Forms.TextBox()
        Me.code = New System.Windows.Forms.TextBox()
        Me.depart = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cantied2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cantidades = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Items = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.num1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grilla_Bodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.modcode)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.num1)
        Me.GroupBox1.Controls.Add(Me.gur)
        Me.GroupBox1.Controls.Add(Me.estad)
        Me.GroupBox1.Controls.Add(Me.cantidaDESSSS)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.itemss)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.hc)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.devolucion_articulos)
        Me.GroupBox1.Controls.Add(Me.rutees)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.busqueda_rut)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Grilla_Bodega)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.cantied)
        Me.GroupBox1.Controls.Add(Me.code)
        Me.GroupBox1.Controls.Add(Me.depart)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cantied2)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(887, 418)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bodega y Usuarios"
        '
        'modcode
        '
        Me.modcode.BackColor = System.Drawing.SystemColors.Control
        Me.modcode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modcode.Enabled = False
        Me.modcode.Location = New System.Drawing.Point(437, 107)
        Me.modcode.Name = "modcode"
        Me.modcode.Size = New System.Drawing.Size(116, 28)
        Me.modcode.TabIndex = 50
        Me.modcode.Text = "Mod. Codigo"
        Me.Mensajes.SetToolTip(Me.modcode, "Modifique el Codigo, ¡Advertencia!: La Cantidad Actual Sera Repuesta  ")
        Me.modcode.UseVisualStyleBackColor = False
        Me.modcode.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(437, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 21)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Cantidad Nueva:"
        Me.Label13.Visible = False
        '
        'num1
        '
        Me.num1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.num1.Location = New System.Drawing.Point(427, 168)
        Me.num1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(96, 26)
        Me.num1.TabIndex = 46
        Me.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.num1, "Indica la Cantidad Al Cual Se Sumara a la Cantidad del Articulo ya Enlazado")
        Me.num1.Visible = False
        '
        'gur
        '
        Me.gur.BackColor = System.Drawing.SystemColors.Control
        Me.gur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gur.Location = New System.Drawing.Point(740, 56)
        Me.gur.Name = "gur"
        Me.gur.Size = New System.Drawing.Size(133, 36)
        Me.gur.TabIndex = 45
        Me.gur.Text = "Guardar"
        Me.gur.UseVisualStyleBackColor = False
        Me.gur.Visible = False
        '
        'estad
        '
        Me.estad.Enabled = False
        Me.estad.Location = New System.Drawing.Point(427, 207)
        Me.estad.MaxLength = 8
        Me.estad.Name = "estad"
        Me.estad.Size = New System.Drawing.Size(139, 26)
        Me.estad.TabIndex = 44
        '
        'cantidaDESSSS
        '
        Me.cantidaDESSSS.Enabled = False
        Me.cantidaDESSSS.Location = New System.Drawing.Point(704, 386)
        Me.cantidaDESSSS.Name = "cantidaDESSSS"
        Me.cantidaDESSSS.ReadOnly = True
        Me.cantidaDESSSS.Size = New System.Drawing.Size(169, 26)
        Me.cantidaDESSSS.TabIndex = 43
        Me.cantidaDESSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.cantidaDESSSS, "Suma Automatica de Total de Cantidades Prestadas Hasta el Momento")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(571, 389)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 21)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Total Cantidades:"
        '
        'itemss
        '
        Me.itemss.Enabled = False
        Me.itemss.Location = New System.Drawing.Point(112, 386)
        Me.itemss.Name = "itemss"
        Me.itemss.ReadOnly = True
        Me.itemss.Size = New System.Drawing.Size(169, 26)
        Me.itemss.TabIndex = 40
        Me.itemss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.itemss, "Suma Automatica de Compras Totales que se han Hecho hasta el Momento")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(14, 389)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 21)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Total Items:"
        '
        'hc
        '
        Me.hc.BackColor = System.Drawing.SystemColors.Control
        Me.hc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.hc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hc.Location = New System.Drawing.Point(577, 162)
        Me.hc.Name = "hc"
        Me.hc.Size = New System.Drawing.Size(134, 36)
        Me.hc.TabIndex = 11
        Me.hc.Text = "Historial Compra"
        Me.Mensajes.SetToolTip(Me.hc, "Visualize el Historial de Compras Efectuadas Hasta la Fecha")
        Me.hc.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(160, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 21)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Precio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 19)
        Me.Label9.TabIndex = 37
        '
        'devolucion_articulos
        '
        Me.devolucion_articulos.BackColor = System.Drawing.SystemColors.Control
        Me.devolucion_articulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.devolucion_articulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.devolucion_articulos.Location = New System.Drawing.Point(740, 197)
        Me.devolucion_articulos.Name = "devolucion_articulos"
        Me.devolucion_articulos.Size = New System.Drawing.Size(134, 36)
        Me.devolucion_articulos.TabIndex = 10
        Me.devolucion_articulos.Text = "Devolver Articulo"
        Me.Mensajes.SetToolTip(Me.devolucion_articulos, "Devuelva algun Articulo que ya haya sido prestado")
        Me.devolucion_articulos.UseVisualStyleBackColor = False
        '
        'rutees
        '
        Me.rutees.Enabled = False
        Me.rutees.Location = New System.Drawing.Point(270, 18)
        Me.rutees.MaxLength = 12
        Me.rutees.Name = "rutees"
        Me.rutees.ReadOnly = True
        Me.rutees.Size = New System.Drawing.Size(161, 26)
        Me.rutees.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.rutees, "Ingrese el Rut de algun Usuario Registrado")
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nombre.Location = New System.Drawing.Point(270, 48)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(2, 21)
        Me.nombre.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(269, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(2, 21)
        Me.Label7.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(362, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 21)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Estado:"
        '
        'busqueda_rut
        '
        Me.busqueda_rut.Location = New System.Drawing.Point(270, 245)
        Me.busqueda_rut.MaxLength = 12
        Me.busqueda_rut.Name = "busqueda_rut"
        Me.busqueda_rut.Size = New System.Drawing.Size(296, 26)
        Me.busqueda_rut.TabIndex = 13
        Me.Mensajes.SetToolTip(Me.busqueda_rut, "Busque algun Rut enlazado con algun Articulo ")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(160, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Buscar Rut:"
        '
        'Grilla_Bodega
        '
        Me.Grilla_Bodega.AllowUserToAddRows = False
        Me.Grilla_Bodega.AllowUserToDeleteRows = False
        Me.Grilla_Bodega.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Bodega.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Bodega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Bodega.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Bodega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Bodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Bodega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Bodega.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Grilla_Bodega.Location = New System.Drawing.Point(14, 284)
        Me.Grilla_Bodega.MultiSelect = False
        Me.Grilla_Bodega.Name = "Grilla_Bodega"
        Me.Grilla_Bodega.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Bodega.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Bodega.RowHeadersVisible = False
        Me.Grilla_Bodega.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Grilla_Bodega.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Bodega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_Bodega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Bodega.ShowCellToolTips = False
        Me.Grilla_Bodega.ShowEditingIcon = False
        Me.Grilla_Bodega.Size = New System.Drawing.Size(860, 96)
        Me.Grilla_Bodega.TabIndex = 26
        Me.Grilla_Bodega.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_Bodega, "Visualiza los Rut ya Enlazados con Articulos y con un Estado Especifico")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(13, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 41)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.Button1, "Vuelve a la Pantalla Anterior")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Enabled = False
        Me.cancelar.Location = New System.Drawing.Point(577, 223)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(134, 36)
        Me.cancelar.TabIndex = 9
        Me.cancelar.Text = "Cancelar"
        Me.Mensajes.SetToolTip(Me.cancelar, "Cancele las Operaciones")
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.SystemColors.Control
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Location = New System.Drawing.Point(577, 97)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(134, 36)
        Me.modificar.TabIndex = 8
        Me.modificar.Text = "Modificar"
        Me.Mensajes.SetToolTip(Me.modificar, "Modifique Algun Dato Existente Mal Digitado")
        Me.modificar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.Location = New System.Drawing.Point(740, 127)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(134, 35)
        Me.eliminar.TabIndex = 7
        Me.eliminar.Text = "Eliminar"
        Me.Mensajes.SetToolTip(Me.eliminar, "Elimine algun Articulo Comprado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Advertencia: No Se Podran Eliminar Los Articulo" &
        "s Prestados)")
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.SystemColors.Control
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Location = New System.Drawing.Point(740, 56)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(134, 36)
        Me.guardar.TabIndex = 6
        Me.guardar.Text = "Guardar"
        Me.Mensajes.SetToolTip(Me.guardar, "Guarde los Cambios Realizados")
        Me.guardar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Location = New System.Drawing.Point(577, 33)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(134, 36)
        Me.nuevo.TabIndex = 5
        Me.nuevo.Text = "Nuevo"
        Me.Mensajes.SetToolTip(Me.nuevo, "Enlaze un Nuevo Usuario con un Articulo")
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'cantied
        '
        Me.cantied.Enabled = False
        Me.cantied.Location = New System.Drawing.Point(269, 168)
        Me.cantied.MaxLength = 5
        Me.cantied.Name = "cantied"
        Me.cantied.ReadOnly = True
        Me.cantied.Size = New System.Drawing.Size(119, 26)
        Me.cantied.TabIndex = 3
        Me.cantied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.cantied, "Ingrese la Cantidad de Articulos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Advertencia: No se Sobrepase de la Cantidad Al" &
        "macenada en Stock)")
        '
        'code
        '
        Me.code.Enabled = False
        Me.code.Location = New System.Drawing.Point(269, 108)
        Me.code.MaxLength = 15
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        Me.code.Size = New System.Drawing.Size(162, 26)
        Me.code.TabIndex = 2
        Me.Mensajes.SetToolTip(Me.code, "Ingrese el Codigo del Articulo que Desea usted Enlazar con el Usuario ")
        '
        'depart
        '
        Me.depart.Enabled = False
        Me.depart.Location = New System.Drawing.Point(270, 72)
        Me.depart.MaxLength = 45
        Me.depart.Name = "depart"
        Me.depart.ReadOnly = True
        Me.depart.Size = New System.Drawing.Size(264, 26)
        Me.depart.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(160, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Departamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(160, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(160, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(14, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 207)
        Me.Panel1.TabIndex = 4
        Me.Mensajes.SetToolTip(Me.Panel1, "Municipalidad de Peralillo")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(160, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rut Usuario:"
        '
        'cantied2
        '
        Me.cantied2.Enabled = False
        Me.cantied2.Location = New System.Drawing.Point(427, 168)
        Me.cantied2.Name = "cantied2"
        Me.cantied2.ReadOnly = True
        Me.cantied2.Size = New System.Drawing.Size(139, 26)
        Me.cantied2.TabIndex = 47
        Me.cantied2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.cantied2, "En Caso de Modificar el Codigo Indique la Cantidad Nueva")
        Me.cantied2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(900, 33)
        Me.Panel2.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(4, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Municipalidad de Peralillo"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(837, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "---"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DimGray
        Me.Button3.Location = New System.Drawing.Point(870, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 27)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Mensajes
        '
        Me.Mensajes.AutoPopDelay = 5000
        Me.Mensajes.InitialDelay = 100
        Me.Mensajes.ReshowDelay = 100
        Me.Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes.ToolTipTitle = "Mensaje"
        '
        'Cantidades
        '
        Me.Cantidades.Interval = 50
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Items
        '
        '
        'Bodega_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 459)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Bodega_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipalidad de Peralillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.num1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grilla_Bodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cantied As TextBox
    Friend WithEvents code As TextBox
    Friend WithEvents depart As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents modificar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents busqueda_rut As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nombre As Label
    Friend WithEvents rutees As TextBox
    Friend WithEvents devolucion_articulos As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Mensajes As ToolTip
    Friend WithEvents Label9 As Label
    Friend WithEvents Grilla_Bodega As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents hc As Button
    Friend WithEvents itemss As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Cantidades As Timer
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cantidaDESSSS As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Items As Timer
    Friend WithEvents estad As TextBox
    Friend WithEvents gur As Button
    Friend WithEvents num1 As NumericUpDown
    Friend WithEvents cantied2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents modcode As Button
End Class
