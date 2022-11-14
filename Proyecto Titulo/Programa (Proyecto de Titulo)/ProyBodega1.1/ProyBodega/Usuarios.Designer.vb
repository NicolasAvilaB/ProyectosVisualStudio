<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cargo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.departamento = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Grilla_Usuarios = New System.Windows.Forms.DataGridView()
        Me.modificar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.rut = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mensajes1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.imp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.imp)
        Me.GroupBox1.Controls.Add(Me.cargo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.departamento)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.atras)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.buscar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Grilla_Usuarios)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.rut)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 462)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'cargo
        '
        Me.cargo.Enabled = False
        Me.cargo.Location = New System.Drawing.Point(264, 116)
        Me.cargo.MaxLength = 45
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        Me.cargo.Size = New System.Drawing.Size(233, 26)
        Me.cargo.TabIndex = 16
        Me.Mensajes1.SetToolTip(Me.cargo, "Ingreso del Cargo Asociado al Usuario")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(161, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Cargo:"
        '
        'departamento
        '
        Me.departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.departamento.Enabled = False
        Me.departamento.FormattingEnabled = True
        Me.departamento.Items.AddRange(New Object() {"Informatica", "Administracion y Finanzas", "Social", "Administracion Municipal", "Deportes", "Dideco", "Transito", "Obras Municipales", "Rentas", "Planificacion Comunal", "Policia Local"})
        Me.departamento.Location = New System.Drawing.Point(264, 149)
        Me.departamento.Name = "departamento"
        Me.departamento.Size = New System.Drawing.Size(233, 28)
        Me.departamento.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(264, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(2, 22)
        Me.Label7.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(162, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ID:"
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.SystemColors.Control
        Me.atras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.atras.Location = New System.Drawing.Point(14, 254)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(141, 41)
        Me.atras.TabIndex = 6
        Me.atras.Text = " <- Regresar"
        Me.Mensajes1.SetToolTip(Me.atras, "Vuelve a la Pantalla Anterior")
        Me.atras.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Enabled = False
        Me.cancelar.Location = New System.Drawing.Point(331, 229)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(136, 41)
        Me.cancelar.TabIndex = 7
        Me.cancelar.Text = "Cancelar"
        Me.Mensajes1.SetToolTip(Me.cancelar, "Cancela la Operación")
        Me.cancelar.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 13
        Me.Mensajes1.SetToolTip(Me.Panel1, "Municipalidad de Peralillo")
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(126, 429)
        Me.buscar.MaxLength = 45
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(371, 26)
        Me.buscar.TabIndex = 9
        Me.Mensajes1.SetToolTip(Me.buscar, "Busca Usuario Registrado por su Nombre")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(11, 432)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Buscar Usuario:"
        '
        'Grilla_Usuarios
        '
        Me.Grilla_Usuarios.AllowUserToAddRows = False
        Me.Grilla_Usuarios.AllowUserToDeleteRows = False
        Me.Grilla_Usuarios.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Usuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Grilla_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Usuarios.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Grilla_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Usuarios.Location = New System.Drawing.Point(15, 322)
        Me.Grilla_Usuarios.MultiSelect = False
        Me.Grilla_Usuarios.Name = "Grilla_Usuarios"
        Me.Grilla_Usuarios.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Usuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Grilla_Usuarios.RowHeadersVisible = False
        Me.Grilla_Usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Usuarios.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Grilla_Usuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Usuarios.ShowCellToolTips = False
        Me.Grilla_Usuarios.ShowEditingIcon = False
        Me.Grilla_Usuarios.Size = New System.Drawing.Size(482, 101)
        Me.Grilla_Usuarios.TabIndex = 10
        Me.Grilla_Usuarios.TabStop = False
        Me.Mensajes1.SetToolTip(Me.Grilla_Usuarios, "Grilla de Usuarios Registrados")
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.SystemColors.Control
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Location = New System.Drawing.Point(361, 275)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(137, 41)
        Me.modificar.TabIndex = 4
        Me.modificar.Text = "Modificar"
        Me.Mensajes1.SetToolTip(Me.modificar, "Modifica un Usuario Existente ")
        Me.modificar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.Location = New System.Drawing.Point(162, 275)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(137, 41)
        Me.eliminar.TabIndex = 5
        Me.eliminar.Text = "Eliminar"
        Me.Mensajes1.SetToolTip(Me.eliminar, "Eliminar Usuario")
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.SystemColors.Control
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Location = New System.Drawing.Point(360, 183)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(137, 41)
        Me.guardar.TabIndex = 8
        Me.guardar.Text = "Guardar"
        Me.Mensajes1.SetToolTip(Me.guardar, "Guardar El Usuario Creado")
        Me.guardar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Location = New System.Drawing.Point(161, 183)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(138, 41)
        Me.nuevo.TabIndex = 3
        Me.nuevo.Text = "Nuevo"
        Me.Mensajes1.SetToolTip(Me.nuevo, "Agrega un Nuevo Usuario")
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'nombre
        '
        Me.nombre.Enabled = False
        Me.nombre.Location = New System.Drawing.Point(264, 84)
        Me.nombre.MaxLength = 45
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(233, 26)
        Me.nombre.TabIndex = 1
        Me.Mensajes1.SetToolTip(Me.nombre, "Ingreso de Nombre de Usuario")
        '
        'rut
        '
        Me.rut.Enabled = False
        Me.rut.Location = New System.Drawing.Point(264, 52)
        Me.rut.MaxLength = 12
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        Me.rut.Size = New System.Drawing.Size(233, 26)
        Me.rut.TabIndex = 0
        Me.Mensajes1.SetToolTip(Me.rut, "Ingreso de Rut del Usuario")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(161, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Departamento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(161, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(161, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rut:"
        '
        'Mensajes1
        '
        Me.Mensajes1.AutoPopDelay = 5000
        Me.Mensajes1.InitialDelay = 100
        Me.Mensajes1.ReshowDelay = 100
        Me.Mensajes1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes1.ToolTipTitle = "Información"
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
        Me.Panel2.Size = New System.Drawing.Size(523, 33)
        Me.Panel2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(4, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
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
        Me.Button5.Location = New System.Drawing.Point(459, 3)
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
        Me.Button6.Location = New System.Drawing.Point(492, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'imp
        '
        Me.imp.BackColor = System.Drawing.SystemColors.Control
        Me.imp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imp.Location = New System.Drawing.Point(187, 229)
        Me.imp.Name = "imp"
        Me.imp.Size = New System.Drawing.Size(138, 41)
        Me.imp.TabIndex = 18
        Me.imp.Text = "Imprimir Reporte"
        Me.Mensajes1.SetToolTip(Me.imp, "Imprima un Reporte de Todos los Usuarios Registrados")
        Me.imp.UseVisualStyleBackColor = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 500)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipalidad de Peralillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents rut As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Grilla_Usuarios As DataGridView
    Friend WithEvents modificar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents buscar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents atras As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents Mensajes1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents departamento As ComboBox
    Friend WithEvents cargo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents imp As Button
End Class
