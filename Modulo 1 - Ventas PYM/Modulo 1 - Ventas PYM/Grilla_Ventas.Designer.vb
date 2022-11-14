<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Grilla_Ventas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grilla_Ventas))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.maximizar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tabla_Ventas = New System.Windows.Forms.DataGridView()
        Me.vend_selec = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.vend = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.valor_obtenido = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.quintacomision = New System.Windows.Forms.Label()
        Me.cuartacomision = New System.Windows.Forms.Label()
        Me.terceracomision = New System.Windows.Forms.Label()
        Me.segundacomision = New System.Windows.Forms.Label()
        Me.primeracomision = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.desglose = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.totrepman = New System.Windows.Forms.Label()
        Me.totcostos = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.totganancia = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.totmotor2 = New System.Windows.Forms.Label()
        Me.totmanual2 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.totinst = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tottraslado = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.totmotor = New System.Windows.Forms.Label()
        Me.totmanual = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totventas = New System.Windows.Forms.Label()
        Me.boton_buscar = New System.Windows.Forms.Button()
        Me.filtro_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.filtro_buscar = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Blabla2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tabla_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.maximizar)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.minimizar)
        Me.Panel2.Controls.Add(Me.cerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1327, 33)
        Me.Panel2.TabIndex = 15
        Me.Blabla2.SetToolTip(Me.Panel2, "CLICK PRESIONADO: Arrastra la ventana" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DOBLE CLICK: Maximiza la ventana")
        '
        'maximizar
        '
        Me.maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maximizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maximizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maximizar.ForeColor = System.Drawing.Color.White
        Me.maximizar.Location = New System.Drawing.Point(1267, 5)
        Me.maximizar.Name = "maximizar"
        Me.maximizar.Size = New System.Drawing.Size(27, 27)
        Me.maximizar.TabIndex = 4
        Me.maximizar.Text = "■"
        Me.Blabla2.SetToolTip(Me.maximizar, "Maximizar la ventana")
        Me.maximizar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "MODULO 1 - VENTAS FYD"
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizar.ForeColor = System.Drawing.Color.White
        Me.minimizar.Location = New System.Drawing.Point(1232, 3)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(27, 27)
        Me.minimizar.TabIndex = 1
        Me.minimizar.Text = "---"
        Me.Blabla2.SetToolTip(Me.minimizar, "Minimizar la ventana")
        Me.minimizar.UseVisualStyleBackColor = False
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.Color.White
        Me.cerrar.Location = New System.Drawing.Point(1296, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(27, 27)
        Me.cerrar.TabIndex = 0
        Me.cerrar.Text = "X"
        Me.Blabla2.SetToolTip(Me.cerrar, "Cerrar la ventana")
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(4, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1319, 467)
        Me.Panel1.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Tabla_Ventas)
        Me.GroupBox1.Controls.Add(Me.vend_selec)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.vend)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.desglose)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.boton_buscar)
        Me.GroupBox1.Controls.Add(Me.filtro_fecha)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.filtro_buscar)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.buscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1303, 452)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TABLA VENTAS"
        '
        'Tabla_Ventas
        '
        Me.Tabla_Ventas.AllowUserToAddRows = False
        Me.Tabla_Ventas.AllowUserToDeleteRows = False
        Me.Tabla_Ventas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Tabla_Ventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tabla_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabla_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tabla_Ventas.BackgroundColor = System.Drawing.Color.LightGray
        Me.Tabla_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tabla_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tabla_Ventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tabla_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla_Ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tabla_Ventas.EnableHeadersVisualStyles = False
        Me.Tabla_Ventas.GridColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Tabla_Ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Tabla_Ventas.Location = New System.Drawing.Point(14, 25)
        Me.Tabla_Ventas.MultiSelect = False
        Me.Tabla_Ventas.Name = "Tabla_Ventas"
        Me.Tabla_Ventas.ReadOnly = True
        Me.Tabla_Ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tabla_Ventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Tabla_Ventas.RowHeadersVisible = False
        Me.Tabla_Ventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Tabla_Ventas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Tabla_Ventas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Tabla_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabla_Ventas.ShowCellToolTips = False
        Me.Tabla_Ventas.ShowEditingIcon = False
        Me.Tabla_Ventas.Size = New System.Drawing.Size(1280, 163)
        Me.Tabla_Ventas.TabIndex = 5
        Me.Tabla_Ventas.TabStop = False
        '
        'vend_selec
        '
        Me.vend_selec.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vend_selec.AutoSize = True
        Me.vend_selec.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.vend_selec.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vend_selec.ForeColor = System.Drawing.Color.White
        Me.vend_selec.Location = New System.Drawing.Point(938, 389)
        Me.vend_selec.Name = "vend_selec"
        Me.vend_selec.Size = New System.Drawing.Size(33, 22)
        Me.vend_selec.TabIndex = 125
        Me.vend_selec.Text = "- - -"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(846, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(2, 22)
        Me.Label14.TabIndex = 115
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(654, 389)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(283, 22)
        Me.Label26.TabIndex = 124
        Me.Label26.Text = "ULTIMO VENDEDOR/A SELECCIONADO:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(851, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 22)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "VEND. :"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(481, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(2, 22)
        Me.Label12.TabIndex = 113
        '
        'vend
        '
        Me.vend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vend.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.vend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vend.Enabled = False
        Me.vend.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vend.ForeColor = System.Drawing.Color.White
        Me.vend.FormattingEnabled = True
        Me.vend.Location = New System.Drawing.Point(915, 196)
        Me.vend.Name = "vend"
        Me.vend.Size = New System.Drawing.Size(205, 31)
        Me.vend.TabIndex = 3
        Me.Blabla2.SetToolTip(Me.vend, "Selecciona el vendedor/a para calcular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "su valor de comision total mensual o anua" &
        "lmente")
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.valor_obtenido)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.quintacomision)
        Me.GroupBox3.Controls.Add(Me.cuartacomision)
        Me.GroupBox3.Controls.Add(Me.terceracomision)
        Me.GroupBox3.Controls.Add(Me.segundacomision)
        Me.GroupBox3.Controls.Add(Me.primeracomision)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(658, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(636, 155)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "COMISION TOTAL DEL MES Y AÑO:"
        '
        'valor_obtenido
        '
        Me.valor_obtenido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valor_obtenido.AutoSize = True
        Me.valor_obtenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.valor_obtenido.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor_obtenido.ForeColor = System.Drawing.Color.White
        Me.valor_obtenido.Location = New System.Drawing.Point(433, 44)
        Me.valor_obtenido.Name = "valor_obtenido"
        Me.valor_obtenido.Size = New System.Drawing.Size(22, 25)
        Me.valor_obtenido.TabIndex = 123
        Me.valor_obtenido.Text = "0"
        Me.Blabla2.SetToolTip(Me.valor_obtenido, "Valor obtenido en la grilla segun vendedor/a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "obviamente esto es calculado solo p" &
        "ara v_comision")
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Location = New System.Drawing.Point(420, 123)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(2, 24)
        Me.Label25.TabIndex = 122
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Location = New System.Drawing.Point(420, 113)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(2, 24)
        Me.Label24.TabIndex = 121
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Location = New System.Drawing.Point(420, 93)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(2, 24)
        Me.Label23.TabIndex = 120
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Location = New System.Drawing.Point(420, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(2, 24)
        Me.Label22.TabIndex = 119
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Location = New System.Drawing.Point(420, 54)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(2, 24)
        Me.Label21.TabIndex = 118
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(420, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(2, 24)
        Me.Label17.TabIndex = 117
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(420, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(2, 24)
        Me.Label16.TabIndex = 116
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(436, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 22)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "VALOR TOTAL OBTENIDO"
        '
        'quintacomision
        '
        Me.quintacomision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quintacomision.AutoSize = True
        Me.quintacomision.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.quintacomision.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quintacomision.ForeColor = System.Drawing.Color.White
        Me.quintacomision.Location = New System.Drawing.Point(237, 127)
        Me.quintacomision.Name = "quintacomision"
        Me.quintacomision.Size = New System.Drawing.Size(22, 25)
        Me.quintacomision.TabIndex = 99
        Me.quintacomision.Text = "0"
        Me.Blabla2.SetToolTip(Me.quintacomision, "Valor calculado de por medio con 2,55%")
        '
        'cuartacomision
        '
        Me.cuartacomision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cuartacomision.AutoSize = True
        Me.cuartacomision.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cuartacomision.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuartacomision.ForeColor = System.Drawing.Color.White
        Me.cuartacomision.Location = New System.Drawing.Point(237, 100)
        Me.cuartacomision.Name = "cuartacomision"
        Me.cuartacomision.Size = New System.Drawing.Size(22, 25)
        Me.cuartacomision.TabIndex = 98
        Me.cuartacomision.Text = "0"
        Me.Blabla2.SetToolTip(Me.cuartacomision, "Valor calculado de por medio con 1,25%")
        '
        'terceracomision
        '
        Me.terceracomision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.terceracomision.AutoSize = True
        Me.terceracomision.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.terceracomision.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terceracomision.ForeColor = System.Drawing.Color.White
        Me.terceracomision.Location = New System.Drawing.Point(237, 74)
        Me.terceracomision.Name = "terceracomision"
        Me.terceracomision.Size = New System.Drawing.Size(22, 25)
        Me.terceracomision.TabIndex = 97
        Me.terceracomision.Text = "0"
        Me.Blabla2.SetToolTip(Me.terceracomision, "Valor calculado de por medio con 1,275%")
        '
        'segundacomision
        '
        Me.segundacomision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.segundacomision.AutoSize = True
        Me.segundacomision.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.segundacomision.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundacomision.ForeColor = System.Drawing.Color.White
        Me.segundacomision.Location = New System.Drawing.Point(237, 49)
        Me.segundacomision.Name = "segundacomision"
        Me.segundacomision.Size = New System.Drawing.Size(22, 25)
        Me.segundacomision.TabIndex = 96
        Me.segundacomision.Text = "0"
        Me.Blabla2.SetToolTip(Me.segundacomision, "Valor calculado de por medio con 1,7%")
        '
        'primeracomision
        '
        Me.primeracomision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.primeracomision.AutoSize = True
        Me.primeracomision.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.primeracomision.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.primeracomision.ForeColor = System.Drawing.Color.White
        Me.primeracomision.Location = New System.Drawing.Point(237, 24)
        Me.primeracomision.Name = "primeracomision"
        Me.primeracomision.Size = New System.Drawing.Size(22, 25)
        Me.primeracomision.TabIndex = 95
        Me.primeracomision.Text = "0"
        Me.Blabla2.SetToolTip(Me.primeracomision, "Valor calculado de por medio con 0,85%")
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 22)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "15.000.001 HASTA --- :"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 22)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "12.000.001 HASTA 15.000.000 :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 22)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "9.000.001 HASTA 12.000.000 :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 22)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "5.000.001 HASTA 9.000.000 :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 22)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "0 HASTA 5.000.000 :"
        '
        'desglose
        '
        Me.desglose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.desglose.AutoSize = True
        Me.desglose.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.desglose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.desglose.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desglose.ForeColor = System.Drawing.Color.White
        Me.desglose.Location = New System.Drawing.Point(5, 420)
        Me.desglose.Name = "desglose"
        Me.desglose.Size = New System.Drawing.Size(29, 27)
        Me.desglose.TabIndex = 110
        Me.desglose.Text = "..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.totrepman)
        Me.GroupBox2.Controls.Add(Me.totcostos)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.totganancia)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.totmotor2)
        Me.GroupBox2.Controls.Add(Me.totmanual2)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.totinst)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tottraslado)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.totmotor)
        Me.GroupBox2.Controls.Add(Me.totmanual)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.totventas)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 190)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CACULOS TOTALES DEL MES"
        '
        'totrepman
        '
        Me.totrepman.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totrepman.AutoSize = True
        Me.totrepman.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.totrepman.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totrepman.ForeColor = System.Drawing.Color.White
        Me.totrepman.Location = New System.Drawing.Point(182, 76)
        Me.totrepman.Name = "totrepman"
        Me.totrepman.Size = New System.Drawing.Size(22, 25)
        Me.totrepman.TabIndex = 106
        Me.totrepman.Text = "0"
        Me.Blabla2.SetToolTip(Me.totrepman, "Valor total de las reparaciones, mantenciones " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o instalaciones del mes y anualme" &
        "nte")
        '
        'totcostos
        '
        Me.totcostos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totcostos.AutoSize = True
        Me.totcostos.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.totcostos.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totcostos.ForeColor = System.Drawing.Color.White
        Me.totcostos.Location = New System.Drawing.Point(182, 159)
        Me.totcostos.Name = "totcostos"
        Me.totcostos.Size = New System.Drawing.Size(22, 25)
        Me.totcostos.TabIndex = 105
        Me.totcostos.Text = "0"
        Me.Blabla2.SetToolTip(Me.totcostos, "Valor total de los traslados del mes o anualmente")
        '
        'Label31
        '
        Me.Label31.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label31.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(15, 80)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(145, 22)
        Me.Label31.TabIndex = 104
        Me.Label31.Text = "TOTAL REP. MANT:"
        '
        'Label30
        '
        Me.Label30.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label30.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(15, 160)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(126, 22)
        Me.Label30.TabIndex = 103
        Me.Label30.Text = "TOTAL COSTOS:"
        '
        'totganancia
        '
        Me.totganancia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totganancia.AutoSize = True
        Me.totganancia.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.totganancia.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totganancia.ForeColor = System.Drawing.Color.White
        Me.totganancia.Location = New System.Drawing.Point(182, 131)
        Me.totganancia.Name = "totganancia"
        Me.totganancia.Size = New System.Drawing.Size(22, 25)
        Me.totganancia.TabIndex = 102
        Me.totganancia.Text = "0"
        Me.Blabla2.SetToolTip(Me.totganancia, "Valor total de los traslados del mes o anualmente")
        '
        'Label27
        '
        Me.Label27.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(15, 133)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(142, 22)
        Me.Label27.TabIndex = 101
        Me.Label27.Text = "TOTAL GANANCIA:"
        '
        'totmotor2
        '
        Me.totmotor2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totmotor2.AutoSize = True
        Me.totmotor2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.totmotor2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totmotor2.ForeColor = System.Drawing.Color.White
        Me.totmotor2.Location = New System.Drawing.Point(575, 85)
        Me.totmotor2.Name = "totmotor2"
        Me.totmotor2.Size = New System.Drawing.Size(22, 25)
        Me.totmotor2.TabIndex = 100
        Me.totmotor2.Text = "0"
        Me.Blabla2.SetToolTip(Me.totmotor2, "Valor total de persianas con motor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mensuales o anualmente vendidas")
        '
        'totmanual2
        '
        Me.totmanual2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totmanual2.AutoSize = True
        Me.totmanual2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.totmanual2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totmanual2.ForeColor = System.Drawing.Color.White
        Me.totmanual2.Location = New System.Drawing.Point(575, 117)
        Me.totmanual2.Name = "totmanual2"
        Me.totmanual2.Size = New System.Drawing.Size(22, 25)
        Me.totmanual2.TabIndex = 99
        Me.totmanual2.Text = "0"
        Me.Blabla2.SetToolTip(Me.totmanual2, "Valor total de persianas manuales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mensuales o anualmente vendidas")
        '
        'Label28
        '
        Me.Label28.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(370, 88)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(180, 22)
        Me.Label28.TabIndex = 98
        Me.Label28.Text = "TOTAL MOTOR SN INST:"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(370, 120)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(206, 22)
        Me.Label29.TabIndex = 97
        Me.Label29.Text = "TOTAL MANUALES SN INST:"
        '
        'totinst
        '
        Me.totinst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totinst.AutoSize = True
        Me.totinst.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.totinst.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totinst.ForeColor = System.Drawing.Color.White
        Me.totinst.Location = New System.Drawing.Point(182, 48)
        Me.totinst.Name = "totinst"
        Me.totinst.Size = New System.Drawing.Size(22, 25)
        Me.totinst.TabIndex = 96
        Me.totinst.Text = "0"
        Me.Blabla2.SetToolTip(Me.totinst, "Valor total de las reparaciones, mantenciones " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o instalaciones del mes y anualme" &
        "nte")
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(15, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 22)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "TOTAL INSTALACION:"
        '
        'tottraslado
        '
        Me.tottraslado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tottraslado.AutoSize = True
        Me.tottraslado.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.tottraslado.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tottraslado.ForeColor = System.Drawing.Color.White
        Me.tottraslado.Location = New System.Drawing.Point(182, 103)
        Me.tottraslado.Name = "tottraslado"
        Me.tottraslado.Size = New System.Drawing.Size(22, 25)
        Me.tottraslado.TabIndex = 94
        Me.tottraslado.Text = "0"
        Me.Blabla2.SetToolTip(Me.tottraslado, "Valor total de los traslados del mes o anualmente")
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(15, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 22)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "TOTAL TRASLADO:"
        '
        'totmotor
        '
        Me.totmotor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totmotor.AutoSize = True
        Me.totmotor.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.totmotor.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totmotor.ForeColor = System.Drawing.Color.White
        Me.totmotor.Location = New System.Drawing.Point(575, 18)
        Me.totmotor.Name = "totmotor"
        Me.totmotor.Size = New System.Drawing.Size(22, 25)
        Me.totmotor.TabIndex = 92
        Me.totmotor.Text = "0"
        Me.Blabla2.SetToolTip(Me.totmotor, "Valor total de persianas con motor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mensuales o anualmente vendidas")
        '
        'totmanual
        '
        Me.totmanual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totmanual.AutoSize = True
        Me.totmanual.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.totmanual.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totmanual.ForeColor = System.Drawing.Color.White
        Me.totmanual.Location = New System.Drawing.Point(575, 52)
        Me.totmanual.Name = "totmanual"
        Me.totmanual.Size = New System.Drawing.Size(22, 25)
        Me.totmanual.TabIndex = 91
        Me.totmanual.Text = "0"
        Me.Blabla2.SetToolTip(Me.totmanual, "Valor total de persianas manuales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mensuales o anualmente vendidas")
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(370, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 22)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "TOTAL MOTOR CN INST:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(370, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 22)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "TOTAL MANUALES CN INST:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 22)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "TOTAL VENTAS:"
        '
        'totventas
        '
        Me.totventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totventas.AutoSize = True
        Me.totventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.totventas.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totventas.ForeColor = System.Drawing.Color.White
        Me.totventas.Location = New System.Drawing.Point(182, 22)
        Me.totventas.Name = "totventas"
        Me.totventas.Size = New System.Drawing.Size(22, 25)
        Me.totventas.TabIndex = 88
        Me.totventas.Text = "0"
        Me.Blabla2.SetToolTip(Me.totventas, "Valor total de las ventas del mes o anualmente")
        '
        'boton_buscar
        '
        Me.boton_buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.boton_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.boton_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boton_buscar.Enabled = False
        Me.boton_buscar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_buscar.ForeColor = System.Drawing.Color.White
        Me.boton_buscar.Location = New System.Drawing.Point(356, 194)
        Me.boton_buscar.Name = "boton_buscar"
        Me.boton_buscar.Size = New System.Drawing.Size(121, 34)
        Me.boton_buscar.TabIndex = 1
        Me.boton_buscar.Text = "BUSCAR"
        Me.Blabla2.SetToolTip(Me.boton_buscar, "Busca tus datos por filtro")
        Me.boton_buscar.UseVisualStyleBackColor = False
        '
        'filtro_fecha
        '
        Me.filtro_fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filtro_fecha.CalendarFont = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtro_fecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filtro_fecha.CustomFormat = "MMMM yyyy"
        Me.filtro_fecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.filtro_fecha.Enabled = False
        Me.filtro_fecha.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtro_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.filtro_fecha.Location = New System.Drawing.Point(1126, 198)
        Me.filtro_fecha.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.filtro_fecha.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.filtro_fecha.Name = "filtro_fecha"
        Me.filtro_fecha.Size = New System.Drawing.Size(168, 29)
        Me.filtro_fecha.TabIndex = 4
        Me.Blabla2.SetToolTip(Me.filtro_fecha, "Para ayudarte con el filtro selecciona una fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o mes al cual quieres buscar l" &
        "os datos")
        Me.filtro_fecha.Value = New Date(2018, 1, 1, 0, 0, 0, 0)
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(484, 201)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(173, 22)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "FILTRO DE BUSQUEDA:"
        '
        'filtro_buscar
        '
        Me.filtro_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filtro_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.filtro_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filtro_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filtro_buscar.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtro_buscar.ForeColor = System.Drawing.Color.White
        Me.filtro_buscar.FormattingEnabled = True
        Me.filtro_buscar.Items.AddRange(New Object() {"CLIENTE", "VENDEDOR/A", "MES", "AÑO", "ORDEN DE VENTA", "CANCELAR FILTRO"})
        Me.filtro_buscar.Location = New System.Drawing.Point(661, 196)
        Me.filtro_buscar.Name = "filtro_buscar"
        Me.filtro_buscar.Size = New System.Drawing.Size(177, 31)
        Me.filtro_buscar.TabIndex = 2
        Me.Blabla2.SetToolTip(Me.filtro_buscar, "Selecciona el tipo de filtro, todos los" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "filtros se buscaran por mes y año selecc" &
        "ionado")
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(10, 200)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(137, 22)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "DIGITE Y BUSQUE:"
        '
        'buscar
        '
        Me.buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buscar.Enabled = False
        Me.buscar.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(147, 195)
        Me.buscar.MaxLength = 45
        Me.buscar.Name = "buscar"
        Me.buscar.ReadOnly = True
        Me.buscar.Size = New System.Drawing.Size(206, 32)
        Me.buscar.TabIndex = 0
        Me.buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla2.SetToolTip(Me.buscar, "Digita o escribe segun la opcion de filtro de busqueda")
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(484, 501)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(332, 20)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "COPYRIGHT © 2018 PERSIANAS EXTERIORES PYM"
        '
        'Blabla2
        '
        Me.Blabla2.AutoPopDelay = 5000
        Me.Blabla2.InitialDelay = 100
        Me.Blabla2.ReshowDelay = 100
        Me.Blabla2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Blabla2.ToolTipTitle = "Mensajes de ayuda"
        '
        'Grilla_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1327, 525)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Grilla_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de Datos"
        Me.Blabla2.SetToolTip(Me, "Redimensiona la ventana con solo mantener " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "clickeado la esquina inferior derecha" &
        " y moviendo el puntero")
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tabla_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents minimizar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents buscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents filtro_fecha As DateTimePicker
    Friend WithEvents maximizar As Button
    Friend WithEvents filtro_buscar As ComboBox
    Friend WithEvents boton_buscar As Button
    Friend WithEvents Blabla2 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tottraslado As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents totmotor As Label
    Friend WithEvents totmanual As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents totventas As Label
    Friend WithEvents totinst As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents desglose As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents quintacomision As Label
    Friend WithEvents cuartacomision As Label
    Friend WithEvents terceracomision As Label
    Friend WithEvents segundacomision As Label
    Friend WithEvents primeracomision As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents vend As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents valor_obtenido As Label
    Friend WithEvents totmotor2 As Label
    Friend WithEvents totmanual2 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents totrepman As Label
    Friend WithEvents totcostos As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents totganancia As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents vend_selec As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Tabla_Ventas As DataGridView
End Class
