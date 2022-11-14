<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personas_Exteriores
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Empresa = New System.Windows.Forms.ComboBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Terminar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Agre_Usuarios = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Rut = New System.Windows.Forms.TextBox()
        Me.Grilla_Empresarios = New System.Windows.Forms.DataGridView()
        Me.Ultimo = New System.Windows.Forms.Button()
        Me.Siguiente = New System.Windows.Forms.Button()
        Me.Anterior = New System.Windows.Forms.Button()
        Me.Primero = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Empresarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Empresa)
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.Terminar)
        Me.GroupBox1.Controls.Add(Me.Eliminar)
        Me.GroupBox1.Controls.Add(Me.Modificar)
        Me.GroupBox1.Controls.Add(Me.Agre_Usuarios)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Telefono)
        Me.GroupBox1.Controls.Add(Me.Direccion)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Rut)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 278)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personas Exteriores"
        '
        'Empresa
        '
        Me.Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Empresa.Enabled = False
        Me.Empresa.FormattingEnabled = True
        Me.Empresa.Items.AddRange(New Object() {"Empresa Coca-Cola ", "Empresa Daily", "Empresa Andina", "Empresa PF", "Empresa Callao", "Empresa JB", "Empresa Carozzi", "Empresa Aconcagua", "Empresa Nestle", "Empresa Romano", "Empresa Pepsodent", "Empresa Winter", "Empresa Marco Polo", "Empresa Lays", "Empresa Alerce", "Empresa McKay", "Empresa San Jorge", "Empresa Montina", "Empresa Ideal", "Empresa Colun", "Empresa Calo", "Empresa Soprole", "Empresa LoncoLeche", "Empresa Surlat", "Empresa Wats", "Empresa Yuz", "Empresa Vivo", "Empresa Livean", "Empresa Mistral", "Empresa La Serena", "Empresa Capel", "Empresa Campanario", "Empresa Gatorade", "Empresa Cristal", "Empresa White Horse", "Empresa Wattson", "Empresa Ballantine", "Empresa Corona", "Empresa Escudo", "Empresa Heineken", "Empresa Tucapel", "Empresa Miraflores", "Empresa Aruba", "Empresa Cachantun", "Empresa Vital", "Empresa Becker", "Empresa Baltica", "Empresa Lacky Strike", "Empresa Pall Mall", "Empresa Belmont", "Empresa Kent", "Empresa Maggi", "Empresa Acuenta", "Empresa Supremo", "Empresa Mildred Tea", "Empresa Lipton", "Empresa Nescafe", "Empresa Monterrey", "Empresa Cafe Gold", "Empresa Copihue Hogar", "Empresa Caricia", "Empresa Ambrosoli", "Empresa Cannes", "Empresa Master Dog", "Empresa Champion", "Empresa Sabro Kan", "Empresa Pedigree", "Empresa Whiskas", "Empresa Master Cat", "Empresa Chef", "Empresa Luchetti", "Empresa Pomarola", "Empresa Malloa", "Empresa Leverchile", "Empresa Quix", "Empresa Mont Blank"})
        Me.Empresa.Location = New System.Drawing.Point(158, 164)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Size = New System.Drawing.Size(183, 29)
        Me.Empresa.TabIndex = 18
        '
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(226, 203)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(115, 30)
        Me.Guardar.TabIndex = 17
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Terminar
        '
        Me.Terminar.Location = New System.Drawing.Point(158, 240)
        Me.Terminar.Name = "Terminar"
        Me.Terminar.Size = New System.Drawing.Size(183, 31)
        Me.Terminar.TabIndex = 16
        Me.Terminar.Text = "Terminar"
        Me.Terminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(9, 239)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(143, 33)
        Me.Eliminar.TabIndex = 15
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(113, 203)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(92, 30)
        Me.Modificar.TabIndex = 14
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Agre_Usuarios
        '
        Me.Agre_Usuarios.Location = New System.Drawing.Point(9, 203)
        Me.Agre_Usuarios.Name = "Agre_Usuarios"
        Me.Agre_Usuarios.Size = New System.Drawing.Size(80, 30)
        Me.Agre_Usuarios.TabIndex = 13
        Me.Agre_Usuarios.Text = "Nuevo"
        Me.Agre_Usuarios.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Empresa y/o Marca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telefono :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Direccion :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rut :"
        '
        'Telefono
        '
        Me.Telefono.Enabled = False
        Me.Telefono.Location = New System.Drawing.Point(98, 129)
        Me.Telefono.MaxLength = 9
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(243, 28)
        Me.Telefono.TabIndex = 3
        '
        'Direccion
        '
        Me.Direccion.Enabled = False
        Me.Direccion.Location = New System.Drawing.Point(102, 95)
        Me.Direccion.MaxLength = 45
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(239, 28)
        Me.Direccion.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(92, 61)
        Me.Nombre.MaxLength = 45
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(249, 28)
        Me.Nombre.TabIndex = 1
        '
        'Rut
        '
        Me.Rut.Enabled = False
        Me.Rut.Location = New System.Drawing.Point(61, 27)
        Me.Rut.MaxLength = 9
        Me.Rut.Name = "Rut"
        Me.Rut.Size = New System.Drawing.Size(280, 28)
        Me.Rut.TabIndex = 0
        '
        'Grilla_Empresarios
        '
        Me.Grilla_Empresarios.AllowUserToAddRows = False
        Me.Grilla_Empresarios.AllowUserToDeleteRows = False
        Me.Grilla_Empresarios.AllowUserToResizeColumns = False
        Me.Grilla_Empresarios.AllowUserToResizeRows = False
        Me.Grilla_Empresarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Empresarios.Location = New System.Drawing.Point(365, 20)
        Me.Grilla_Empresarios.Name = "Grilla_Empresarios"
        Me.Grilla_Empresarios.Size = New System.Drawing.Size(547, 266)
        Me.Grilla_Empresarios.TabIndex = 1
        '
        'Ultimo
        '
        Me.Ultimo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ultimo.Location = New System.Drawing.Point(727, 293)
        Me.Ultimo.Name = "Ultimo"
        Me.Ultimo.Size = New System.Drawing.Size(134, 34)
        Me.Ultimo.TabIndex = 17
        Me.Ultimo.Text = ">>"
        Me.Ultimo.UseVisualStyleBackColor = True
        '
        'Siguiente
        '
        Me.Siguiente.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Siguiente.Location = New System.Drawing.Point(528, 293)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(134, 34)
        Me.Siguiente.TabIndex = 16
        Me.Siguiente.Text = ">"
        Me.Siguiente.UseVisualStyleBackColor = True
        '
        'Anterior
        '
        Me.Anterior.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Anterior.Location = New System.Drawing.Point(251, 293)
        Me.Anterior.Name = "Anterior"
        Me.Anterior.Size = New System.Drawing.Size(134, 34)
        Me.Anterior.TabIndex = 15
        Me.Anterior.Text = "<"
        Me.Anterior.UseVisualStyleBackColor = True
        '
        'Primero
        '
        Me.Primero.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Primero.Location = New System.Drawing.Point(12, 293)
        Me.Primero.Name = "Primero"
        Me.Primero.Size = New System.Drawing.Size(134, 34)
        Me.Primero.TabIndex = 14
        Me.Primero.Text = "<<"
        Me.Primero.UseVisualStyleBackColor = True
        '
        'Personas_Exteriores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(927, 338)
        Me.Controls.Add(Me.Ultimo)
        Me.Controls.Add(Me.Siguiente)
        Me.Controls.Add(Me.Anterior)
        Me.Controls.Add(Me.Primero)
        Me.Controls.Add(Me.Grilla_Empresarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Personas_Exteriores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personas Exteriores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Empresarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Rut As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Terminar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Agre_Usuarios As System.Windows.Forms.Button
    Friend WithEvents Grilla_Empresarios As System.Windows.Forms.DataGridView
    Friend WithEvents Ultimo As System.Windows.Forms.Button
    Friend WithEvents Siguiente As System.Windows.Forms.Button
    Friend WithEvents Anterior As System.Windows.Forms.Button
    Friend WithEvents Primero As System.Windows.Forms.Button
    Friend WithEvents Empresa As System.Windows.Forms.ComboBox
End Class
