<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Esca_Med
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.producto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.filtros = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.desglose = New System.Windows.Forms.Label()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.filtrar = New System.Windows.Forms.Button()
        Me.tipo_colores = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tipo_lama = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.alto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ancho = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.minimizar)
        Me.Panel2.Controls.Add(Me.cerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(868, 33)
        Me.Panel2.TabIndex = 119
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "MODULO 3 - MEDIDAS Y ESCALAS"
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizar.ForeColor = System.Drawing.Color.White
        Me.minimizar.Location = New System.Drawing.Point(803, 3)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(27, 27)
        Me.minimizar.TabIndex = 1
        Me.minimizar.Text = "---"
        Me.minimizar.UseVisualStyleBackColor = False
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.Color.White
        Me.cerrar.Location = New System.Drawing.Point(837, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(27, 27)
        Me.cerrar.TabIndex = 0
        Me.cerrar.Text = "X"
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Panel1.Controls.Add(Me.producto)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.filtros)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.desglose)
        Me.Panel1.Controls.Add(Me.Tabla)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(4, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 513)
        Me.Panel1.TabIndex = 120
        '
        'producto
        '
        Me.producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.producto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.producto.Enabled = False
        Me.producto.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.producto.FormattingEnabled = True
        Me.producto.Items.AddRange(New Object() {"Manual", "Motor", "Motor Auto-BL", "Motor Manivela", "M. Chapa y Muelle 4K", "M. Chapa y Muelle 10K", "M. Chapa y Muelle 24K", "Motor Remoto", "Motor /Auto-BL/ Crto", "Central Control", "Puls. Conmutador", "TODOS LOS PRODUCTOS"})
        Me.producto.Location = New System.Drawing.Point(116, 66)
        Me.producto.Name = "producto"
        Me.producto.Size = New System.Drawing.Size(221, 31)
        Me.producto.TabIndex = 199
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 22)
        Me.Label8.TabIndex = 198
        Me.Label8.Text = "PRODUCTOS:"
        '
        'filtros
        '
        Me.filtros.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.filtros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filtros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filtros.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.filtros.FormattingEnabled = True
        Me.filtros.Items.AddRange(New Object() {"Escala Definida (ANCHO, ALTO)", "Escala Completa", "Solo Productos/Accionamientos"})
        Me.filtros.Location = New System.Drawing.Point(517, 66)
        Me.filtros.Name = "filtros"
        Me.filtros.Size = New System.Drawing.Size(334, 31)
        Me.filtros.TabIndex = 197
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(407, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 22)
        Me.Label7.TabIndex = 196
        Me.Label7.Text = "TIPO FILTRO:"
        '
        'desglose
        '
        Me.desglose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.desglose.AutoSize = True
        Me.desglose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.desglose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.desglose.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desglose.ForeColor = System.Drawing.Color.White
        Me.desglose.Location = New System.Drawing.Point(9, 478)
        Me.desglose.Name = "desglose"
        Me.desglose.Size = New System.Drawing.Size(29, 27)
        Me.desglose.TabIndex = 195
        Me.desglose.Text = "..."
        '
        'Tabla
        '
        Me.Tabla.AllowUserToAddRows = False
        Me.Tabla.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Tabla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tabla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tabla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.Tabla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tabla.EnableHeadersVisualStyles = False
        Me.Tabla.GridColor = System.Drawing.Color.Silver
        Me.Tabla.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Tabla.Location = New System.Drawing.Point(10, 229)
        Me.Tabla.MultiSelect = False
        Me.Tabla.Name = "Tabla"
        Me.Tabla.ReadOnly = True
        Me.Tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tabla.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Tabla.RowHeadersVisible = False
        Me.Tabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Tabla.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Tabla.RowTemplate.Height = 30
        Me.Tabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabla.ShowCellToolTips = False
        Me.Tabla.ShowEditingIcon = False
        Me.Tabla.Size = New System.Drawing.Size(841, 246)
        Me.Tabla.TabIndex = 187
        Me.Tabla.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Resultados de Busqueda..."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.filtrar)
        Me.GroupBox1.Controls.Add(Me.tipo_colores)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tipo_lama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.alto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ancho)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(841, 109)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'filtrar
        '
        Me.filtrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filtrar.BackColor = System.Drawing.Color.White
        Me.filtrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filtrar.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.filtrar.FlatAppearance.BorderSize = 0
        Me.filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filtrar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.filtrar.Location = New System.Drawing.Point(622, 26)
        Me.filtrar.Name = "filtrar"
        Me.filtrar.Size = New System.Drawing.Size(213, 39)
        Me.filtrar.TabIndex = 191
        Me.filtrar.Text = "BUSCAR"
        Me.filtrar.UseVisualStyleBackColor = False
        '
        'tipo_colores
        '
        Me.tipo_colores.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tipo_colores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipo_colores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo_colores.Enabled = False
        Me.tipo_colores.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo_colores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tipo_colores.FormattingEnabled = True
        Me.tipo_colores.Items.AddRange(New Object() {"BLANCO, BRONCE, PLATA", "PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA"})
        Me.tipo_colores.Location = New System.Drawing.Point(320, 71)
        Me.tipo_colores.Name = "tipo_colores"
        Me.tipo_colores.Size = New System.Drawing.Size(515, 31)
        Me.tipo_colores.TabIndex = 190
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(230, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 22)
        Me.Label6.TabIndex = 189
        Me.Label6.Text = "COLORES:"
        '
        'tipo_lama
        '
        Me.tipo_lama.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tipo_lama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipo_lama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo_lama.Enabled = False
        Me.tipo_lama.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo_lama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tipo_lama.FormattingEnabled = True
        Me.tipo_lama.Items.AddRange(New Object() {"LAMA 45", "LAMA 55"})
        Me.tipo_lama.Location = New System.Drawing.Point(320, 32)
        Me.tipo_lama.Name = "tipo_lama"
        Me.tipo_lama.Size = New System.Drawing.Size(115, 31)
        Me.tipo_lama.TabIndex = 188
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(230, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 22)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "LAMA:"
        '
        'alto
        '
        Me.alto.Enabled = False
        Me.alto.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alto.Location = New System.Drawing.Point(78, 70)
        Me.alto.MaxLength = 4
        Me.alto.Name = "alto"
        Me.alto.ReadOnly = True
        Me.alto.Size = New System.Drawing.Size(95, 32)
        Me.alto.TabIndex = 150
        Me.alto.Text = "0001"
        Me.alto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 22)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "ALTO:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(6, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 22)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "ANCHO:"
        '
        'ancho
        '
        Me.ancho.Enabled = False
        Me.ancho.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancho.Location = New System.Drawing.Point(78, 32)
        Me.ancho.MaxLength = 4
        Me.ancho.Name = "ancho"
        Me.ancho.ReadOnly = True
        Me.ancho.Size = New System.Drawing.Size(95, 32)
        Me.ancho.TabIndex = 146
        Me.ancho.Text = "0001"
        Me.ancho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(241, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(381, 29)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "SOCIEDAD COMERCIAL PYM LIMITADA"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(263, 549)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 20)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "COPYRIGHT © 2019 PERSIANAS EXTERIORES PYM"
        '
        'Esca_Med
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(868, 574)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Esca_Med"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents minimizar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tipo_colores As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tipo_lama As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents alto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ancho As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents desglose As Label
    Friend WithEvents filtrar As Button
    Friend WithEvents filtros As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents producto As ComboBox
    Friend WithEvents Label8 As Label
End Class
