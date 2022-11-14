<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pacientes1
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
        Me.Volver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ciudad = New System.Windows.Forms.TextBox()
        Me.genero = New System.Windows.Forms.ComboBox()
        Me.SistSaliud = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Edades = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumeroHiji = New System.Windows.Forms.TextBox()
        Me.Pac_1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rut = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Medico = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Pac_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(182, 515)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(243, 33)
        Me.Volver.TabIndex = 0
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Medico)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Ciudad)
        Me.GroupBox1.Controls.Add(Me.genero)
        Me.GroupBox1.Controls.Add(Me.SistSaliud)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.Modificar)
        Me.GroupBox1.Controls.Add(Me.Eliminar)
        Me.GroupBox1.Controls.Add(Me.Nuevo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Edades)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.NumeroHiji)
        Me.GroupBox1.Controls.Add(Me.Pac_1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.telefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.direccion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rut)
        Me.GroupBox1.Controls.Add(Me.Volver)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1271, 554)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion Pacientes"
        '
        'Ciudad
        '
        Me.Ciudad.Enabled = False
        Me.Ciudad.Location = New System.Drawing.Point(90, 153)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.ReadOnly = True
        Me.Ciudad.Size = New System.Drawing.Size(335, 26)
        Me.Ciudad.TabIndex = 30
        '
        'genero
        '
        Me.genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.genero.Enabled = False
        Me.genero.FormattingEnabled = True
        Me.genero.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.genero.Location = New System.Drawing.Point(90, 185)
        Me.genero.Name = "genero"
        Me.genero.Size = New System.Drawing.Size(335, 27)
        Me.genero.TabIndex = 29
        '
        'SistSaliud
        '
        Me.SistSaliud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SistSaliud.Enabled = False
        Me.SistSaliud.FormattingEnabled = True
        Me.SistSaliud.Items.AddRange(New Object() {"FONASA", "ISAPRE", "SESMA", "SNSS", "CONAMA", "CENABAST"})
        Me.SistSaliud.Location = New System.Drawing.Point(127, 312)
        Me.SistSaliud.Name = "SistSaliud"
        Me.SistSaliud.Size = New System.Drawing.Size(299, 27)
        Me.SistSaliud.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 315)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 19)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Sistema Salud:"
        '
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(17, 438)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(407, 34)
        Me.Guardar.TabIndex = 25
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(17, 515)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(162, 33)
        Me.Modificar.TabIndex = 24
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(17, 477)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(406, 34)
        Me.Eliminar.TabIndex = 23
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.Nuevo.Location = New System.Drawing.Point(17, 399)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(408, 34)
        Me.Nuevo.TabIndex = 22
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Edad:"
        '
        'Edades
        '
        Me.Edades.Enabled = False
        Me.Edades.Location = New System.Drawing.Point(90, 280)
        Me.Edades.Name = "Edades"
        Me.Edades.ReadOnly = True
        Me.Edades.Size = New System.Drawing.Size(335, 26)
        Me.Edades.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "N° Hijos:"
        '
        'NumeroHiji
        '
        Me.NumeroHiji.Enabled = False
        Me.NumeroHiji.Location = New System.Drawing.Point(91, 217)
        Me.NumeroHiji.Name = "NumeroHiji"
        Me.NumeroHiji.ReadOnly = True
        Me.NumeroHiji.Size = New System.Drawing.Size(335, 26)
        Me.NumeroHiji.TabIndex = 18
        '
        'Pac_1
        '
        Me.Pac_1.AllowUserToAddRows = False
        Me.Pac_1.AllowUserToDeleteRows = False
        Me.Pac_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Pac_1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Pac_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Pac_1.Location = New System.Drawing.Point(432, 26)
        Me.Pac_1.MultiSelect = False
        Me.Pac_1.Name = "Pac_1"
        Me.Pac_1.ReadOnly = True
        Me.Pac_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Pac_1.Size = New System.Drawing.Size(833, 522)
        Me.Pac_1.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Email:"
        '
        'Email
        '
        Me.Email.Enabled = False
        Me.Email.Location = New System.Drawing.Point(91, 248)
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Size = New System.Drawing.Size(335, 26)
        Me.Email.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Genero:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ciudad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telefono:"
        '
        'telefono
        '
        Me.telefono.Enabled = False
        Me.telefono.Location = New System.Drawing.Point(90, 120)
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Size = New System.Drawing.Size(335, 26)
        Me.telefono.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Direccion:"
        '
        'direccion
        '
        Me.direccion.Enabled = False
        Me.direccion.Location = New System.Drawing.Point(90, 88)
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Size = New System.Drawing.Size(335, 26)
        Me.direccion.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'nombre
        '
        Me.nombre.Enabled = False
        Me.nombre.Location = New System.Drawing.Point(90, 56)
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(335, 26)
        Me.nombre.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rut:"
        '
        'rut
        '
        Me.rut.Enabled = False
        Me.rut.Location = New System.Drawing.Point(90, 25)
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        Me.rut.Size = New System.Drawing.Size(335, 26)
        Me.rut.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 349)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 19)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Medico:"
        '
        'Medico
        '
        Me.Medico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Medico.Enabled = False
        Me.Medico.FormattingEnabled = True
        Me.Medico.Items.AddRange(New Object() {""})
        Me.Medico.Location = New System.Drawing.Point(81, 346)
        Me.Medico.Name = "Medico"
        Me.Medico.Size = New System.Drawing.Size(229, 27)
        Me.Medico.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(316, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 19)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "-------------"
        '
        'Pacientes1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 576)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Pacientes1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Pac_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rut As System.Windows.Forms.TextBox
    Friend WithEvents Pac_1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NumeroHiji As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Edades As System.Windows.Forms.TextBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SistSaliud As System.Windows.Forms.ComboBox
    Friend WithEvents genero As System.Windows.Forms.ComboBox
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Medico As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
