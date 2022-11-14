<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seccion_Acceso
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seccion_Acceso))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Grilla_Acceso = New System.Windows.Forms.DataGridView()
        Me.busque_alias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nomali = New System.Windows.Forms.TextBox()
        Me.clav = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Acceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Grilla_Acceso)
        Me.GroupBox1.Controls.Add(Me.busque_alias)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.atras)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.nomali)
        Me.GroupBox1.Controls.Add(Me.clav)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(556, 363)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Acceso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(281, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(2, 21)
        Me.Label6.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(173, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 21)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "ID:"
        '
        'Grilla_Acceso
        '
        Me.Grilla_Acceso.AllowUserToAddRows = False
        Me.Grilla_Acceso.AllowUserToDeleteRows = False
        Me.Grilla_Acceso.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Acceso.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Acceso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Acceso.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Acceso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Acceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Acceso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Acceso.Location = New System.Drawing.Point(14, 237)
        Me.Grilla_Acceso.MultiSelect = False
        Me.Grilla_Acceso.Name = "Grilla_Acceso"
        Me.Grilla_Acceso.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Acceso.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Acceso.RowHeadersVisible = False
        Me.Grilla_Acceso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grilla_Acceso.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Acceso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_Acceso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Acceso.ShowCellToolTips = False
        Me.Grilla_Acceso.ShowEditingIcon = False
        Me.Grilla_Acceso.Size = New System.Drawing.Size(533, 84)
        Me.Grilla_Acceso.TabIndex = 49
        Me.Grilla_Acceso.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_Acceso, "Visualiza Todos los Alias Registrados")
        '
        'busque_alias
        '
        Me.busque_alias.Location = New System.Drawing.Point(164, 327)
        Me.busque_alias.MaxLength = 30
        Me.busque_alias.Name = "busque_alias"
        Me.busque_alias.Size = New System.Drawing.Size(383, 26)
        Me.busque_alias.TabIndex = 8
        Me.Mensajes.SetToolTip(Me.busque_alias, "Haslo Facil, Busque algun Alias")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(10, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Buscar Nombre/Alias:"
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.SystemColors.Control
        Me.atras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.atras.Location = New System.Drawing.Point(164, 194)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(137, 37)
        Me.atras.TabIndex = 5
        Me.atras.Text = " <- Regresar"
        Me.Mensajes.SetToolTip(Me.atras, "Vuelva a la Pantalla Anterior")
        Me.atras.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Enabled = False
        Me.cancelar.Location = New System.Drawing.Point(413, 122)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(136, 37)
        Me.cancelar.TabIndex = 4
        Me.cancelar.Text = "Cancelar"
        Me.Mensajes.SetToolTip(Me.cancelar, "Cancele las Operaciones")
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.Location = New System.Drawing.Point(290, 158)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(136, 37)
        Me.eliminar.TabIndex = 6
        Me.eliminar.Text = "Eliminar"
        Me.Mensajes.SetToolTip(Me.eliminar, "Elimine algun Alias")
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.SystemColors.Control
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Location = New System.Drawing.Point(413, 194)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(136, 37)
        Me.guardar.TabIndex = 3
        Me.guardar.Text = "Guardar"
        Me.Mensajes.SetToolTip(Me.guardar, "Guarde los Cambios Realizados")
        Me.guardar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Location = New System.Drawing.Point(164, 122)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(137, 37)
        Me.nuevo.TabIndex = 2
        Me.nuevo.Text = "Nuevo"
        Me.Mensajes.SetToolTip(Me.nuevo, "Agrega Nuevos Alias Ingresandolos en las Cajas de Texto")
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(173, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Clave:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(173, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nombre/Alias:"
        '
        'nomali
        '
        Me.nomali.Enabled = False
        Me.nomali.Location = New System.Drawing.Point(281, 55)
        Me.nomali.MaxLength = 30
        Me.nomali.Name = "nomali"
        Me.nomali.ReadOnly = True
        Me.nomali.Size = New System.Drawing.Size(266, 26)
        Me.nomali.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.nomali, "Ingrese Nombre y/o Alias")
        '
        'clav
        '
        Me.clav.Enabled = False
        Me.clav.Location = New System.Drawing.Point(281, 90)
        Me.clav.MaxLength = 45
        Me.clav.Name = "clav"
        Me.clav.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.clav.ReadOnly = True
        Me.clav.Size = New System.Drawing.Size(266, 26)
        Me.clav.TabIndex = 1
        Me.Mensajes.SetToolTip(Me.clav, "Ingrese Contraseña o Clave")
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
        Me.Panel1.TabIndex = 6
        Me.Mensajes.SetToolTip(Me.Panel1, "Municipalidad de Peralillo")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(572, 33)
        Me.Panel2.TabIndex = 4
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
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(509, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "---"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(542, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Mensajes
        '
        Me.Mensajes.AutoPopDelay = 5000
        Me.Mensajes.InitialDelay = 100
        Me.Mensajes.ReshowDelay = 100
        Me.Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes.ToolTipTitle = "Mensaje"
        '
        'Seccion_Acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(572, 403)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Seccion_Acceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipalidad de Peralillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Acceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nomali As TextBox
    Friend WithEvents clav As TextBox
    Friend WithEvents atras As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents busque_alias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Grilla_Acceso As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Mensajes As ToolTip
End Class
