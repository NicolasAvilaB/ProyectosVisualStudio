<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_Stock
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historial_Stock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cant = New System.Windows.Forms.TextBox()
        Me.busqueda_history = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Grilla_History = New System.Windows.Forms.DataGridView()
        Me.atras = New System.Windows.Forms.Button()
        Me.filtro = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Precio = New System.Windows.Forms.Timer(Me.components)
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.cntt = New System.Windows.Forms.TextBox()
        Me.bscn = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.grll = New System.Windows.Forms.DataGridView()
        Me.vl = New System.Windows.Forms.Button()
        Me.fl = New System.Windows.Forms.Button()
        Me.dt11 = New System.Windows.Forms.DateTimePicker()
        Me.dt22 = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_History, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(876, 33)
        Me.Panel2.TabIndex = 7
        Me.Mensajes.SetToolTip(Me.Panel2, "En esta Sección Puedes Mover la Pantalla a Donde tu Quieras")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(4, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 20)
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
        Me.Button2.Location = New System.Drawing.Point(813, 3)
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
        Me.Button3.Location = New System.Drawing.Point(846, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 27)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cant)
        Me.GroupBox1.Controls.Add(Me.busqueda_history)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Grilla_History)
        Me.GroupBox1.Controls.Add(Me.atras)
        Me.GroupBox1.Controls.Add(Me.filtro)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(853, 416)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historial de Ingreso de Articulos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(576, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 22)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Fecha de Termino:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(162, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 22)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Fecha de Inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(457, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 22)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cantidades Totales:"
        '
        'cant
        '
        Me.cant.Enabled = False
        Me.cant.ForeColor = System.Drawing.Color.White
        Me.cant.Location = New System.Drawing.Point(596, 371)
        Me.cant.Name = "cant"
        Me.cant.Size = New System.Drawing.Size(237, 26)
        Me.cant.TabIndex = 37
        Me.cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.cant, "Conteo de Cantidades Totales ya Compradas")
        '
        'busqueda_history
        '
        Me.busqueda_history.Location = New System.Drawing.Point(188, 371)
        Me.busqueda_history.MaxLength = 45
        Me.busqueda_history.Name = "busqueda_history"
        Me.busqueda_history.Size = New System.Drawing.Size(252, 26)
        Me.busqueda_history.TabIndex = 4
        Me.Mensajes.SetToolTip(Me.busqueda_history, "Haslo facil, Busca el nombre del articulo del ingreso")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(14, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 22)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Buscar Nombre Articulo: "
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
        'Grilla_History
        '
        Me.Grilla_History.AllowUserToAddRows = False
        Me.Grilla_History.AllowUserToDeleteRows = False
        Me.Grilla_History.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_History.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_History.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_History.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_History.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_History.Location = New System.Drawing.Point(14, 237)
        Me.Grilla_History.MultiSelect = False
        Me.Grilla_History.Name = "Grilla_History"
        Me.Grilla_History.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_History.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_History.RowHeadersVisible = False
        Me.Grilla_History.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grilla_History.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_History.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_History.ShowCellToolTips = False
        Me.Grilla_History.ShowEditingIcon = False
        Me.Grilla_History.Size = New System.Drawing.Size(819, 128)
        Me.Grilla_History.TabIndex = 25
        Me.Grilla_History.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_History, "Visualiza todos los ingresos de productos o articulos hechos hasta la fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.SystemColors.Control
        Me.atras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.atras.Location = New System.Drawing.Point(162, 190)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(258, 41)
        Me.atras.TabIndex = 2
        Me.atras.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.atras, "Vuelve a la Pantalla Anterior")
        Me.atras.UseVisualStyleBackColor = False
        '
        'filtro
        '
        Me.filtro.BackColor = System.Drawing.SystemColors.Control
        Me.filtro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filtro.Location = New System.Drawing.Point(575, 190)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(258, 41)
        Me.filtro.TabIndex = 3
        Me.filtro.Text = "Filtro"
        Me.Mensajes.SetToolTip(Me.filtro, "Filtra las Fechas Solicitadas")
        Me.filtro.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 92)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(278, 26)
        Me.DateTimePicker1.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.DateTimePicker1, "Filtra desde una Fecha de Inicio el Historial de Compras")
        Me.DateTimePicker1.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(576, 92)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(258, 26)
        Me.DateTimePicker2.TabIndex = 1
        Me.Mensajes.SetToolTip(Me.DateTimePicker2, "Filtra desde una Fecha de Termino el Historial de Compras")
        Me.DateTimePicker2.Value = New Date(2017, 12, 31, 0, 0, 0, 0)
        '
        'Precio
        '
        Me.Precio.Interval = 50
        '
        'Mensajes
        '
        Me.Mensajes.AutoPopDelay = 5000
        Me.Mensajes.InitialDelay = 100
        Me.Mensajes.ReshowDelay = 100
        Me.Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes.ToolTipTitle = "Mensaje"
        '
        'cntt
        '
        Me.cntt.Enabled = False
        Me.cntt.ForeColor = System.Drawing.Color.White
        Me.cntt.Location = New System.Drawing.Point(597, 371)
        Me.cntt.Name = "cntt"
        Me.cntt.Size = New System.Drawing.Size(237, 26)
        Me.cntt.TabIndex = 37
        Me.cntt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.cntt, "Conteo de Cantidades Totales ya Compradas")
        '
        'bscn
        '
        Me.bscn.Location = New System.Drawing.Point(180, 371)
        Me.bscn.MaxLength = 10
        Me.bscn.Name = "bscn"
        Me.bscn.Size = New System.Drawing.Size(260, 26)
        Me.bscn.TabIndex = 4
        Me.Mensajes.SetToolTip(Me.bscn, "Haslo facil, Busca el Administrador quien realizo modificaciones o compras stock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(14, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(141, 207)
        Me.Panel3.TabIndex = 4
        Me.Mensajes.SetToolTip(Me.Panel3, "Municipalidad de Peralillo")
        '
        'grll
        '
        Me.grll.AllowUserToAddRows = False
        Me.grll.AllowUserToDeleteRows = False
        Me.grll.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.grll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grll.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grll.Location = New System.Drawing.Point(14, 237)
        Me.grll.MultiSelect = False
        Me.grll.Name = "grll"
        Me.grll.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grll.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grll.RowHeadersVisible = False
        Me.grll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.grll.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grll.ShowCellToolTips = False
        Me.grll.ShowEditingIcon = False
        Me.grll.Size = New System.Drawing.Size(820, 128)
        Me.grll.TabIndex = 25
        Me.grll.TabStop = False
        Me.Mensajes.SetToolTip(Me.grll, "Visualiza todas las compras stock y/o modificaciones por parte el administrador d" &
        "esde esta grilla")
        '
        'vl
        '
        Me.vl.BackColor = System.Drawing.SystemColors.Control
        Me.vl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vl.Location = New System.Drawing.Point(161, 190)
        Me.vl.Name = "vl"
        Me.vl.Size = New System.Drawing.Size(259, 41)
        Me.vl.TabIndex = 2
        Me.vl.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.vl, "Vuelve a la Pantalla Anterior")
        Me.vl.UseVisualStyleBackColor = False
        '
        'fl
        '
        Me.fl.BackColor = System.Drawing.SystemColors.Control
        Me.fl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fl.Location = New System.Drawing.Point(576, 190)
        Me.fl.Name = "fl"
        Me.fl.Size = New System.Drawing.Size(258, 41)
        Me.fl.TabIndex = 3
        Me.fl.Text = "Filtro"
        Me.Mensajes.SetToolTip(Me.fl, "Filtra las Fechas Solicitadas")
        Me.fl.UseVisualStyleBackColor = False
        '
        'dt11
        '
        Me.dt11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dt11.CustomFormat = "dd-MM-yyyy"
        Me.dt11.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dt11.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt11.Location = New System.Drawing.Point(162, 92)
        Me.dt11.Name = "dt11"
        Me.dt11.Size = New System.Drawing.Size(278, 26)
        Me.dt11.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.dt11, "Filtra desde una Fecha de Inicio el Historial de Compras")
        Me.dt11.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'dt22
        '
        Me.dt22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dt22.CustomFormat = "dd-MM-yyyy"
        Me.dt22.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dt22.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt22.Location = New System.Drawing.Point(576, 92)
        Me.dt22.Name = "dt22"
        Me.dt22.Size = New System.Drawing.Size(258, 26)
        Me.dt22.TabIndex = 1
        Me.Mensajes.SetToolTip(Me.dt22, "Filtra desde una Fecha de Termino el Historial de Compras")
        Me.dt22.Value = New Date(2017, 12, 31, 0, 0, 0, 0)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(861, 446)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(853, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Historial Ingreso Articulos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(853, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historial Modificacion Compra Stock"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cntt)
        Me.GroupBox2.Controls.Add(Me.bscn)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.grll)
        Me.GroupBox2.Controls.Add(Me.vl)
        Me.GroupBox2.Controls.Add(Me.fl)
        Me.GroupBox2.Controls.Add(Me.dt11)
        Me.GroupBox2.Controls.Add(Me.dt22)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(852, 412)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial de Ingreso de Articulos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(576, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 22)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Fecha de Termino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(162, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 22)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Fecha de Inicio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(457, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 22)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Cantidades Totales:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(14, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 22)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Buscar Nombre Admin: "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(369, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 41)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Imprimir Reporte"
        Me.Mensajes.SetToolTip(Me.Button1, "Filtra las Fechas Solicitadas")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(369, 143)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(258, 41)
        Me.Button4.TabIndex = 60
        Me.Button4.Text = "Imprimir Reporte"
        Me.Mensajes.SetToolTip(Me.Button4, "Filtra las Fechas Solicitadas")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Historial_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 485)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Historial_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History_Compr"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_History, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Grilla_History As DataGridView
    Friend WithEvents atras As Button
    Friend WithEvents filtro As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents busqueda_history As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Precio As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents cant As TextBox
    Friend WithEvents Mensajes As ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cntt As TextBox
    Friend WithEvents bscn As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents grll As DataGridView
    Friend WithEvents vl As Button
    Friend WithEvents fl As Button
    Friend WithEvents dt11 As DateTimePicker
    Friend WithEvents dt22 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
End Class
