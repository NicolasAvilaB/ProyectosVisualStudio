<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History_Compr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History_Compr))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cant = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totales = New System.Windows.Forms.TextBox()
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
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_History, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Size = New System.Drawing.Size(852, 33)
        Me.Panel2.TabIndex = 7
        Me.Mensajes.SetToolTip(Me.Panel2, "En esta Sección Puedes Mover la Pantalla a Donde tu Quieras")
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
        Me.Button2.Location = New System.Drawing.Point(789, 3)
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
        Me.Button3.Location = New System.Drawing.Point(822, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 27)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cant)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.totales)
        Me.GroupBox1.Controls.Add(Me.busqueda_history)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Grilla_History)
        Me.GroupBox1.Controls.Add(Me.atras)
        Me.GroupBox1.Controls.Add(Me.filtro)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(839, 363)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historial Compra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(576, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 21)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Fecha de Termino:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(162, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 21)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Fecha de Inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(284, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 21)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cantidades Totales:"
        '
        'cant
        '
        Me.cant.Enabled = False
        Me.cant.ForeColor = System.Drawing.Color.White
        Me.cant.Location = New System.Drawing.Point(427, 331)
        Me.cant.Name = "cant"
        Me.cant.Size = New System.Drawing.Size(175, 26)
        Me.cant.TabIndex = 37
        Me.cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.cant, "Conteo de Cantidades Totales ya Compradas")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(608, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Total:"
        '
        'totales
        '
        Me.totales.Enabled = False
        Me.totales.ForeColor = System.Drawing.Color.White
        Me.totales.Location = New System.Drawing.Point(664, 331)
        Me.totales.Name = "totales"
        Me.totales.Size = New System.Drawing.Size(169, 26)
        Me.totales.TabIndex = 35
        Me.totales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.totales, "Conteo Total del Precio de Cada Codigo")
        '
        'busqueda_history
        '
        Me.busqueda_history.Location = New System.Drawing.Point(131, 331)
        Me.busqueda_history.MaxLength = 15
        Me.busqueda_history.Name = "busqueda_history"
        Me.busqueda_history.Size = New System.Drawing.Size(147, 26)
        Me.busqueda_history.TabIndex = 33
        Me.Mensajes.SetToolTip(Me.busqueda_history, "Haslo facil, Busca el Codigo del Articulo Aqui")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(14, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Buscar Codigo: "
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Grilla_History.Size = New System.Drawing.Size(819, 88)
        Me.Grilla_History.TabIndex = 25
        Me.Grilla_History.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_History, "Visualiza Todas las Compras que se Realizaron hasta la Fecha")
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.SystemColors.Control
        Me.atras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.atras.Location = New System.Drawing.Point(161, 190)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(141, 41)
        Me.atras.TabIndex = 4
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
        Me.filtro.TabIndex = 1
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
        Me.DateTimePicker2.TabIndex = 2
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
        'History_Compr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 402)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "History_Compr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History_Compr"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_History, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents totales As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Precio As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents cant As TextBox
    Friend WithEvents Mensajes As ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
