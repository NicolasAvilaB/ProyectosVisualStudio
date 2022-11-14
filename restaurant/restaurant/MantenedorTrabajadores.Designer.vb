<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MantenedorTrabajadores
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cargo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grilla_Trabajadores = New System.Windows.Forms.DataGridView()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.clave = New System.Windows.Forms.TextBox()
        Me.guardar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rut = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.regresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Trabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cargo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Grilla_Trabajadores)
        Me.GroupBox1.Controls.Add(Me.buscar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.clave)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rut)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.regresar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 490)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTROS TRABAJADORES"
        '
        'cargo
        '
        Me.cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cargo.Enabled = False
        Me.cargo.FormattingEnabled = True
        Me.cargo.Items.AddRange(New Object() {"Administrador", "Jefe de la Cocina", "Garzon", "Cajero/a", "Limpiador de Cocina", "Cocinero/a", "Proveedor"})
        Me.cargo.Location = New System.Drawing.Point(262, 155)
        Me.cargo.Name = "cargo"
        Me.cargo.Size = New System.Drawing.Size(301, 28)
        Me.cargo.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(185, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 22)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "CARGO:"
        '
        'Grilla_Trabajadores
        '
        Me.Grilla_Trabajadores.AllowUserToAddRows = False
        Me.Grilla_Trabajadores.AllowUserToDeleteRows = False
        Me.Grilla_Trabajadores.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Trabajadores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Trabajadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Trabajadores.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Trabajadores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Trabajadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Grilla_Trabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Trabajadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Trabajadores.Location = New System.Drawing.Point(8, 278)
        Me.Grilla_Trabajadores.Name = "Grilla_Trabajadores"
        Me.Grilla_Trabajadores.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Trabajadores.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Trabajadores.RowHeadersVisible = False
        Me.Grilla_Trabajadores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Trabajadores.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Trabajadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Trabajadores.ShowCellToolTips = False
        Me.Grilla_Trabajadores.ShowEditingIcon = False
        Me.Grilla_Trabajadores.Size = New System.Drawing.Size(555, 172)
        Me.Grilla_Trabajadores.TabIndex = 51
        Me.Grilla_Trabajadores.TabStop = False
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(144, 456)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(419, 26)
        Me.buscar.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(8, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 22)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "BUSCAR NOMBRE:"
        '
        'clave
        '
        Me.clave.Enabled = False
        Me.clave.Location = New System.Drawing.Point(262, 121)
        Me.clave.Name = "clave"
        Me.clave.ReadOnly = True
        Me.clave.Size = New System.Drawing.Size(301, 26)
        Me.clave.TabIndex = 48
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.Color.White
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.Location = New System.Drawing.Point(246, 235)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(122, 37)
        Me.guardar.TabIndex = 47
        Me.guardar.Text = "GUARDAR"
        Me.guardar.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.Color.White
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Enabled = False
        Me.cancelar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Location = New System.Drawing.Point(374, 235)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(122, 37)
        Me.cancelar.TabIndex = 46
        Me.cancelar.Text = "CANCELAR"
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.Color.White
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.Location = New System.Drawing.Point(441, 192)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(122, 37)
        Me.eliminar.TabIndex = 45
        Me.eliminar.Text = "ELIMINAR"
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.Color.White
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(313, 192)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(122, 37)
        Me.modificar.TabIndex = 44
        Me.modificar.Text = "MODIFICAR"
        Me.modificar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(185, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 22)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "CLAVE:"
        '
        'rut
        '
        Me.rut.BackColor = System.Drawing.SystemColors.Control
        Me.rut.Enabled = False
        Me.rut.Location = New System.Drawing.Point(232, 55)
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        Me.rut.Size = New System.Drawing.Size(331, 26)
        Me.rut.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(185, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 22)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "RUT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(185, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 22)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "NOMBRE:"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(215, 25)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(2, 22)
        Me.id.TabIndex = 39
        '
        'nombre
        '
        Me.nombre.Enabled = False
        Me.nombre.Location = New System.Drawing.Point(262, 88)
        Me.nombre.MaxLength = 44
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(301, 26)
        Me.nombre.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(185, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 22)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "ID:"
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.Color.White
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.Location = New System.Drawing.Point(185, 192)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(122, 37)
        Me.nuevo.TabIndex = 36
        Me.nuevo.Text = "NUEVO"
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'regresar
        '
        Me.regresar.BackColor = System.Drawing.Color.White
        Me.regresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.regresar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresar.Location = New System.Drawing.Point(8, 215)
        Me.regresar.Name = "regresar"
        Me.regresar.Size = New System.Drawing.Size(171, 37)
        Me.regresar.TabIndex = 14
        Me.regresar.Text = "<- REGRESAR"
        Me.regresar.UseVisualStyleBackColor = False
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 33)
        Me.Panel2.TabIndex = 17
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
        Me.Button5.Location = New System.Drawing.Point(516, 3)
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
        Me.Button6.Location = New System.Drawing.Point(549, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'MantenedorTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(580, 527)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MantenedorTrabajadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MantenedorTrabajadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Trabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents regresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents clave As TextBox
    Friend WithEvents guardar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents modificar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents rut As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents id As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nuevo As Button
    Friend WithEvents Grilla_Trabajadores As DataGridView
    Friend WithEvents buscar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cargo As ComboBox
End Class
