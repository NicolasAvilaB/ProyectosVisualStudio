<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrador))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.busque_admin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.acces = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grilla_Administrador = New System.Windows.Forms.DataGridView()
        Me.atras = New System.Windows.Forms.Button()
        Me.cla = New System.Windows.Forms.TextBox()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.nombr = New System.Windows.Forms.TextBox()
        Me.modificar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.agregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Administrador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.busque_admin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.acces)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Grilla_Administrador)
        Me.GroupBox1.Controls.Add(Me.atras)
        Me.GroupBox1.Controls.Add(Me.cla)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.nombr)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.agregar)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 450)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modo Administrador"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(247, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 19)
        Me.Label6.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(162, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "ID:"
        '
        'busque_admin
        '
        Me.busque_admin.Location = New System.Drawing.Point(167, 414)
        Me.busque_admin.Name = "busque_admin"
        Me.busque_admin.Size = New System.Drawing.Size(304, 26)
        Me.busque_admin.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 417)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Buscar Administrador:"
        '
        'acces
        '
        Me.acces.BackColor = System.Drawing.SystemColors.Control
        Me.acces.Cursor = System.Windows.Forms.Cursors.Hand
        Me.acces.Location = New System.Drawing.Point(169, 252)
        Me.acces.Name = "acces"
        Me.acces.Size = New System.Drawing.Size(302, 41)
        Me.acces.TabIndex = 5
        Me.acces.Text = "Clave Acceso"
        Me.acces.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Clave:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre:"
        '
        'Grilla_Administrador
        '
        Me.Grilla_Administrador.AllowUserToAddRows = False
        Me.Grilla_Administrador.AllowUserToDeleteRows = False
        Me.Grilla_Administrador.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Administrador.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Administrador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Administrador.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Administrador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Administrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Administrador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Administrador.EnableHeadersVisualStyles = False
        Me.Grilla_Administrador.Location = New System.Drawing.Point(15, 306)
        Me.Grilla_Administrador.MultiSelect = False
        Me.Grilla_Administrador.Name = "Grilla_Administrador"
        Me.Grilla_Administrador.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Administrador.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Administrador.RowHeadersVisible = False
        Me.Grilla_Administrador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grilla_Administrador.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Administrador.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Grilla_Administrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Administrador.ShowCellToolTips = False
        Me.Grilla_Administrador.ShowEditingIcon = False
        Me.Grilla_Administrador.Size = New System.Drawing.Size(456, 102)
        Me.Grilla_Administrador.TabIndex = 15
        Me.Grilla_Administrador.TabStop = False
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.SystemColors.Control
        Me.atras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.atras.Location = New System.Drawing.Point(14, 252)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(141, 41)
        Me.atras.TabIndex = 4
        Me.atras.Text = " <- Regresar"
        Me.atras.UseVisualStyleBackColor = False
        '
        'cla
        '
        Me.cla.Enabled = False
        Me.cla.Location = New System.Drawing.Point(251, 79)
        Me.cla.MaxLength = 12
        Me.cla.Name = "cla"
        Me.cla.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cla.ReadOnly = True
        Me.cla.Size = New System.Drawing.Size(219, 26)
        Me.cla.TabIndex = 1
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Enabled = False
        Me.cancelar.Location = New System.Drawing.Point(333, 158)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(137, 41)
        Me.cancelar.TabIndex = 6
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'nombr
        '
        Me.nombr.Enabled = False
        Me.nombr.Location = New System.Drawing.Point(251, 48)
        Me.nombr.MaxLength = 10
        Me.nombr.Name = "nombr"
        Me.nombr.ReadOnly = True
        Me.nombr.Size = New System.Drawing.Size(220, 26)
        Me.nombr.TabIndex = 0
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.SystemColors.Control
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Location = New System.Drawing.Point(333, 111)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(137, 41)
        Me.modificar.TabIndex = 8
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.Location = New System.Drawing.Point(167, 205)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(137, 41)
        Me.eliminar.TabIndex = 9
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.SystemColors.Control
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Location = New System.Drawing.Point(167, 158)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(136, 41)
        Me.guardar.TabIndex = 3
        Me.guardar.Text = "Guardar"
        Me.guardar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Location = New System.Drawing.Point(166, 111)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(137, 41)
        Me.nuevo.TabIndex = 2
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'agregar
        '
        Me.agregar.BackColor = System.Drawing.SystemColors.Control
        Me.agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregar.Location = New System.Drawing.Point(333, 205)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(136, 41)
        Me.agregar.TabIndex = 7
        Me.agregar.Text = "Productos"
        Me.agregar.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(492, 33)
        Me.Panel2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(4, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Municipalidad de Peralillo"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(428, 3)
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
        Me.Button1.Location = New System.Drawing.Point(461, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 488)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipalidad de Peralillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Administrador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents agregar As Button
    Friend WithEvents atras As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents modificar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents cla As TextBox
    Friend WithEvents nombr As TextBox
    Friend WithEvents Grilla_Administrador As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents acces As Button
    Friend WithEvents busque_admin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
