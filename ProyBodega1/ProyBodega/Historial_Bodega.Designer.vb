<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_Bodega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historial_Bodega))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.busqueda_prestados = New System.Windows.Forms.TextBox()
        Me.cant2 = New System.Windows.Forms.TextBox()
        Me.Grilla_History_Prestamos = New System.Windows.Forms.DataGridView()
        Me.Filtro1 = New System.Windows.Forms.Button()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.busqueda_history = New System.Windows.Forms.TextBox()
        Me.Grilla_History = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cant = New System.Windows.Forms.TextBox()
        Me.filtro = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.atras = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cantid = New System.Windows.Forms.Timer(Me.components)
        Me.Cantid1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Grilla_History_Prestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Grilla_History, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 424)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historial Bodega"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(842, 397)
        Me.TabControl1.TabIndex = 53
        Me.Mensajes.SetToolTip(Me.TabControl1, "Cambia los Historiales, Para tener una Amplia Visión de los Articulos")
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.busqueda_prestados)
        Me.TabPage1.Controls.Add(Me.cant2)
        Me.TabPage1.Controls.Add(Me.Grilla_History_Prestamos)
        Me.TabPage1.Controls.Add(Me.Filtro1)
        Me.TabPage1.Controls.Add(Me.DateTimePicker4)
        Me.TabPage1.Controls.Add(Me.DateTimePicker3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(834, 365)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Articulos Prestados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(562, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 21)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Fecha de Termino:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(152, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 21)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Fecha de Inicio:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(5, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(141, 207)
        Me.Panel3.TabIndex = 54
        Me.Mensajes.SetToolTip(Me.Panel3, "Municipalidad de Peralillo")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(152, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 41)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.Button1, "Vuelva a la Pantalla Anterior")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(5, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 21)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Buscar Codigo: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(489, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 21)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Cantidades Totales:"
        '
        'busqueda_prestados
        '
        Me.busqueda_prestados.Location = New System.Drawing.Point(122, 331)
        Me.busqueda_prestados.MaxLength = 15
        Me.busqueda_prestados.Name = "busqueda_prestados"
        Me.busqueda_prestados.Size = New System.Drawing.Size(361, 26)
        Me.busqueda_prestados.TabIndex = 46
        Me.Mensajes.SetToolTip(Me.busqueda_prestados, "Haslo Facil, Busca el Codigo del Articulo Aqui")
        '
        'cant2
        '
        Me.cant2.Enabled = False
        Me.cant2.ForeColor = System.Drawing.Color.White
        Me.cant2.Location = New System.Drawing.Point(632, 331)
        Me.cant2.Name = "cant2"
        Me.cant2.Size = New System.Drawing.Size(192, 26)
        Me.cant2.TabIndex = 49
        Me.cant2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.cant2, "Conteo de Cantidades Totales de Todos los Articulos")
        '
        'Grilla_History_Prestamos
        '
        Me.Grilla_History_Prestamos.AllowUserToAddRows = False
        Me.Grilla_History_Prestamos.AllowUserToDeleteRows = False
        Me.Grilla_History_Prestamos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_History_Prestamos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_History_Prestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_History_Prestamos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_History_Prestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_History_Prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_History_Prestamos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_History_Prestamos.Location = New System.Drawing.Point(5, 217)
        Me.Grilla_History_Prestamos.MultiSelect = False
        Me.Grilla_History_Prestamos.Name = "Grilla_History_Prestamos"
        Me.Grilla_History_Prestamos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_History_Prestamos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_History_Prestamos.RowHeadersVisible = False
        Me.Grilla_History_Prestamos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grilla_History_Prestamos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_History_Prestamos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_History_Prestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_History_Prestamos.ShowCellToolTips = False
        Me.Grilla_History_Prestamos.ShowEditingIcon = False
        Me.Grilla_History_Prestamos.Size = New System.Drawing.Size(819, 111)
        Me.Grilla_History_Prestamos.TabIndex = 47
        Me.Grilla_History_Prestamos.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_History_Prestamos, "Visualiza Todos los Articulos Prestados hasta la Fecha")
        '
        'Filtro1
        '
        Me.Filtro1.BackColor = System.Drawing.SystemColors.Control
        Me.Filtro1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Filtro1.Location = New System.Drawing.Point(562, 170)
        Me.Filtro1.Name = "Filtro1"
        Me.Filtro1.Size = New System.Drawing.Size(262, 41)
        Me.Filtro1.TabIndex = 44
        Me.Filtro1.Text = "Filtro"
        Me.Mensajes.SetToolTip(Me.Filtro1, "Filtra las Fechas Solicitadas")
        Me.Filtro1.UseVisualStyleBackColor = False
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker4.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker4.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker4.Location = New System.Drawing.Point(152, 65)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(277, 26)
        Me.DateTimePicker4.TabIndex = 43
        Me.Mensajes.SetToolTip(Me.DateTimePicker4, "Filtra desde una Fecha de Inicio el Historial de Prestamos")
        Me.DateTimePicker4.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker3.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker3.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(562, 65)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(262, 26)
        Me.DateTimePicker3.TabIndex = 45
        Me.Mensajes.SetToolTip(Me.DateTimePicker3, "Filtra Desde una Fecha de Termino el Historial de Prestamos")
        Me.DateTimePicker3.Value = New Date(2017, 12, 31, 0, 0, 0, 0)
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.busqueda_history)
        Me.TabPage2.Controls.Add(Me.Grilla_History)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cant)
        Me.TabPage2.Controls.Add(Me.filtro)
        Me.TabPage2.Controls.Add(Me.DateTimePicker1)
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Controls.Add(Me.atras)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(834, 365)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Articulos Devueltos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(563, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 21)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Fecha de Termino:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(152, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 21)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Fecha de Inicio:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 207)
        Me.Panel1.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(5, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Buscar Codigo: "
        '
        'busqueda_history
        '
        Me.busqueda_history.Location = New System.Drawing.Point(122, 332)
        Me.busqueda_history.MaxLength = 15
        Me.busqueda_history.Name = "busqueda_history"
        Me.busqueda_history.Size = New System.Drawing.Size(360, 26)
        Me.busqueda_history.TabIndex = 5
        Me.Mensajes.SetToolTip(Me.busqueda_history, "Haslo facil, Busca el Codigo del Articulo Aqui")
        '
        'Grilla_History
        '
        Me.Grilla_History.AllowUserToAddRows = False
        Me.Grilla_History.AllowUserToDeleteRows = False
        Me.Grilla_History.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Grilla_History.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Grilla_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_History.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_History.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_History.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_History.Location = New System.Drawing.Point(5, 217)
        Me.Grilla_History.MultiSelect = False
        Me.Grilla_History.Name = "Grilla_History"
        Me.Grilla_History.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_History.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Grilla_History.RowHeadersVisible = False
        Me.Grilla_History.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grilla_History.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Grilla_History.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_History.ShowCellToolTips = False
        Me.Grilla_History.ShowEditingIcon = False
        Me.Grilla_History.Size = New System.Drawing.Size(819, 112)
        Me.Grilla_History.TabIndex = 16
        Me.Grilla_History.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_History, "Visualiza Todas las Devoluciones Concretadas hasta la Fecha")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(488, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 21)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Cantidades Totales:"
        '
        'cant
        '
        Me.cant.Enabled = False
        Me.cant.ForeColor = System.Drawing.Color.White
        Me.cant.Location = New System.Drawing.Point(631, 332)
        Me.cant.Name = "cant"
        Me.cant.Size = New System.Drawing.Size(193, 26)
        Me.cant.TabIndex = 39
        Me.cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.cant, "Conteo de Cantidades Totales Devueltas")
        '
        'filtro
        '
        Me.filtro.BackColor = System.Drawing.SystemColors.Control
        Me.filtro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filtro.Location = New System.Drawing.Point(563, 170)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(261, 41)
        Me.filtro.TabIndex = 1
        Me.filtro.Text = "Filtro"
        Me.Mensajes.SetToolTip(Me.filtro, "Filtra las fechas solicitadas")
        Me.filtro.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(152, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(277, 26)
        Me.DateTimePicker1.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.DateTimePicker1, "Filtra desde una Fecha de Inicio el Historial de Devoluciones")
        Me.DateTimePicker1.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(563, 65)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(261, 26)
        Me.DateTimePicker2.TabIndex = 2
        Me.Mensajes.SetToolTip(Me.DateTimePicker2, "Filtra desde una Fecha de Termino el Historial de Devoluciones")
        Me.DateTimePicker2.Value = New Date(2017, 12, 31, 0, 0, 0, 0)
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.SystemColors.Control
        Me.atras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.atras.Location = New System.Drawing.Point(152, 170)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(141, 41)
        Me.atras.TabIndex = 4
        Me.atras.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.atras, "Vuelva a la Pantalla Anterior")
        Me.atras.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(870, 33)
        Me.Panel2.TabIndex = 5
        Me.Mensajes.SetToolTip(Me.Panel2, "En esta Sección Puedes Mover la Pantalla a Donde tu Quieras")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(4, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Municipalidad de Peralillo"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DimGray
        Me.Button5.Location = New System.Drawing.Point(808, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 27)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "---"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DimGray
        Me.Button6.Location = New System.Drawing.Point(841, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Mensajes
        '
        Me.Mensajes.AutoPopDelay = 5000
        Me.Mensajes.InitialDelay = 100
        Me.Mensajes.ReshowDelay = 100
        Me.Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes.ToolTipTitle = "Mensaje"
        '
        'Cantid
        '
        Me.Cantid.Interval = 50
        '
        'Cantid1
        '
        Me.Cantid1.Interval = 50
        '
        'Historial_Bodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 464)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Historial_Bodega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipalidad de Peralillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Grilla_History_Prestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Grilla_History, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents atras As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Mensajes As ToolTip
    Friend WithEvents Cantid As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents cant2 As TextBox
    Friend WithEvents busqueda_prestados As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Filtro1 As Button
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents Grilla_History_Prestamos As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents busqueda_history As TextBox
    Friend WithEvents Grilla_History As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cant As TextBox
    Friend WithEvents filtro As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Cantid1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
