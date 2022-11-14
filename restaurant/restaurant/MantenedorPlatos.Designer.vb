<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantenedorPlatos
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.Grilla_Platos = New System.Windows.Forms.DataGridView()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.guardar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.materia = New System.Windows.Forms.TextBox()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Platos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(711, 33)
        Me.Panel2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(302, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "BIENVENIDO RESTAURANTE ""MARIO E LUIGI"""
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.DarkGreen
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(647, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 27)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "---"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.DarkGreen
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(680, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.tipo)
        Me.GroupBox1.Controls.Add(Me.Grilla_Platos)
        Me.GroupBox1.Controls.Add(Me.buscar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.precio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.materia)
        Me.GroupBox1.Controls.Add(Me.codigo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Aceptar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 552)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO PLATOS"
        '
        'tipo
        '
        Me.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo.Enabled = False
        Me.tipo.FormattingEnabled = True
        Me.tipo.Items.AddRange(New Object() {"Frios", "Calientes", "Entradas", "Agregados", "Postre"})
        Me.tipo.Location = New System.Drawing.Point(311, 167)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(258, 28)
        Me.tipo.TabIndex = 53
        '
        'Grilla_Platos
        '
        Me.Grilla_Platos.AllowUserToAddRows = False
        Me.Grilla_Platos.AllowUserToDeleteRows = False
        Me.Grilla_Platos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Platos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Platos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Platos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Platos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Platos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Grilla_Platos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Platos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Platos.Location = New System.Drawing.Point(8, 247)
        Me.Grilla_Platos.Name = "Grilla_Platos"
        Me.Grilla_Platos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Platos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Platos.RowHeadersVisible = False
        Me.Grilla_Platos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Platos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Platos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Platos.ShowCellToolTips = False
        Me.Grilla_Platos.ShowEditingIcon = False
        Me.Grilla_Platos.Size = New System.Drawing.Size(689, 265)
        Me.Grilla_Platos.TabIndex = 52
        Me.Grilla_Platos.TabStop = False
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(144, 518)
        Me.buscar.MaxLength = 45
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(553, 26)
        Me.buscar.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(8, 521)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 22)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "BUSCAR NOMBRE:"
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.Color.White
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.Location = New System.Drawing.Point(575, 114)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(122, 37)
        Me.guardar.TabIndex = 49
        Me.guardar.Text = "GUARDAR"
        Me.guardar.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.Color.White
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Enabled = False
        Me.cancelar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Location = New System.Drawing.Point(575, 203)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(122, 37)
        Me.cancelar.TabIndex = 48
        Me.cancelar.Text = "CANCELAR"
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.Color.White
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.Location = New System.Drawing.Point(575, 158)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(122, 37)
        Me.eliminar.TabIndex = 47
        Me.eliminar.Text = "ELIMINAR"
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.Color.White
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(575, 69)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(122, 37)
        Me.modificar.TabIndex = 46
        Me.modificar.Text = "MODIFICAR"
        Me.modificar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.Color.White
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.Location = New System.Drawing.Point(575, 25)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(122, 37)
        Me.nuevo.TabIndex = 45
        Me.nuevo.Text = "NUEVO"
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(185, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 22)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "PRECIO:"
        '
        'precio
        '
        Me.precio.Enabled = False
        Me.precio.Location = New System.Drawing.Point(311, 208)
        Me.precio.MaxLength = 5
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Size = New System.Drawing.Size(258, 26)
        Me.precio.TabIndex = 43
        Me.precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(185, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 22)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "TIPO DE PLATO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(185, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 22)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "MATERIA PRIMA:"
        '
        'materia
        '
        Me.materia.Enabled = False
        Me.materia.Location = New System.Drawing.Point(311, 129)
        Me.materia.MaxLength = 45
        Me.materia.Name = "materia"
        Me.materia.ReadOnly = True
        Me.materia.Size = New System.Drawing.Size(258, 26)
        Me.materia.TabIndex = 30
        '
        'codigo
        '
        Me.codigo.BackColor = System.Drawing.SystemColors.Control
        Me.codigo.Enabled = False
        Me.codigo.Location = New System.Drawing.Point(262, 54)
        Me.codigo.MaxLength = 13
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Size = New System.Drawing.Size(307, 26)
        Me.codigo.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(185, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 22)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "CODIGO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(185, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 22)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "NOMBRE DEL PLATO:"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(215, 25)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(2, 22)
        Me.id.TabIndex = 26
        '
        'nombre
        '
        Me.nombre.Enabled = False
        Me.nombre.Location = New System.Drawing.Point(341, 94)
        Me.nombre.MaxLength = 45
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(228, 26)
        Me.nombre.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(185, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 22)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "ID:"
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.Color.White
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Aceptar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.Location = New System.Drawing.Point(8, 197)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(171, 37)
        Me.Aceptar.TabIndex = 14
        Me.Aceptar.Text = "<- REGRESAR"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.restaurant.My.Resources.Resources._1
        Me.PictureBox1.Location = New System.Drawing.Point(8, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MantenedorPlatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(711, 589)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MantenedorPlatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MantenedorPlatos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Platos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents materia As TextBox
    Friend WithEvents codigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents id As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents precio As TextBox
    Friend WithEvents guardar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents modificar As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents Grilla_Platos As DataGridView
    Friend WithEvents buscar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tipo As ComboBox
End Class
