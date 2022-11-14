<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ficha_Atencion
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
        Me.Volv = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MotivodeConsulta = New System.Windows.Forms.TextBox()
        Me.Tratamiento = New System.Windows.Forms.TextBox()
        Me.Antecedentes = New System.Windows.Forms.TextBox()
        Me.Medicamentos = New System.Windows.Forms.TextBox()
        Me.Enfermedad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Horar = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Rutes = New System.Windows.Forms.ComboBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Ciudad = New System.Windows.Forms.TextBox()
        Me.N_Hijos = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Edad = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Volv)
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 651)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ficha"
        '
        'Volv
        '
        Me.Volv.Location = New System.Drawing.Point(305, 599)
        Me.Volv.Name = "Volv"
        Me.Volv.Size = New System.Drawing.Size(116, 37)
        Me.Volv.TabIndex = 26
        Me.Volv.Text = "Volver"
        Me.Volv.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(15, 599)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(122, 37)
        Me.Guardar.TabIndex = 24
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MotivodeConsulta)
        Me.GroupBox3.Controls.Add(Me.Tratamiento)
        Me.GroupBox3.Controls.Add(Me.Antecedentes)
        Me.GroupBox3.Controls.Add(Me.Medicamentos)
        Me.GroupBox3.Controls.Add(Me.Enfermedad)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 366)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(406, 201)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Generales"
        '
        'MotivodeConsulta
        '
        Me.MotivodeConsulta.Location = New System.Drawing.Point(146, 160)
        Me.MotivodeConsulta.Name = "MotivodeConsulta"
        Me.MotivodeConsulta.Size = New System.Drawing.Size(244, 26)
        Me.MotivodeConsulta.TabIndex = 37
        '
        'Tratamiento
        '
        Me.Tratamiento.Location = New System.Drawing.Point(146, 128)
        Me.Tratamiento.Name = "Tratamiento"
        Me.Tratamiento.Size = New System.Drawing.Size(244, 26)
        Me.Tratamiento.TabIndex = 36
        '
        'Antecedentes
        '
        Me.Antecedentes.Location = New System.Drawing.Point(198, 94)
        Me.Antecedentes.Name = "Antecedentes"
        Me.Antecedentes.Size = New System.Drawing.Size(192, 26)
        Me.Antecedentes.TabIndex = 35
        '
        'Medicamentos
        '
        Me.Medicamentos.Location = New System.Drawing.Point(146, 61)
        Me.Medicamentos.Name = "Medicamentos"
        Me.Medicamentos.Size = New System.Drawing.Size(244, 26)
        Me.Medicamentos.TabIndex = 34
        '
        'Enfermedad
        '
        Me.Enfermedad.Location = New System.Drawing.Point(146, 29)
        Me.Enfermedad.Name = "Enfermedad"
        Me.Enfermedad.Size = New System.Drawing.Size(244, 26)
        Me.Enfermedad.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Medicamentos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Enfermedad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Motivo de Consulta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tratamiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Antecedentes Quirurjicos:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Horar)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Rutes)
        Me.GroupBox2.Controls.Add(Me.Email)
        Me.GroupBox2.Controls.Add(Me.Ciudad)
        Me.GroupBox2.Controls.Add(Me.N_Hijos)
        Me.GroupBox2.Controls.Add(Me.Fecha)
        Me.GroupBox2.Controls.Add(Me.Telefono)
        Me.GroupBox2.Controls.Add(Me.Edad)
        Me.GroupBox2.Controls.Add(Me.Nombre)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 335)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Personales"
        '
        'Horar
        '
        Me.Horar.Enabled = False
        Me.Horar.Location = New System.Drawing.Point(146, 185)
        Me.Horar.Name = "Horar"
        Me.Horar.ReadOnly = True
        Me.Horar.Size = New System.Drawing.Size(244, 26)
        Me.Horar.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 188)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 19)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Hora de Atencion:"
        '
        'Rutes
        '
        Me.Rutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Rutes.FormattingEnabled = True
        Me.Rutes.Location = New System.Drawing.Point(146, 25)
        Me.Rutes.Name = "Rutes"
        Me.Rutes.Size = New System.Drawing.Size(244, 27)
        Me.Rutes.TabIndex = 33
        '
        'Email
        '
        Me.Email.Enabled = False
        Me.Email.Location = New System.Drawing.Point(146, 281)
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Size = New System.Drawing.Size(244, 26)
        Me.Email.TabIndex = 32
        '
        'Ciudad
        '
        Me.Ciudad.Enabled = False
        Me.Ciudad.Location = New System.Drawing.Point(146, 249)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.ReadOnly = True
        Me.Ciudad.Size = New System.Drawing.Size(244, 26)
        Me.Ciudad.TabIndex = 31
        '
        'N_Hijos
        '
        Me.N_Hijos.Enabled = False
        Me.N_Hijos.Location = New System.Drawing.Point(146, 217)
        Me.N_Hijos.Name = "N_Hijos"
        Me.N_Hijos.ReadOnly = True
        Me.N_Hijos.Size = New System.Drawing.Size(244, 26)
        Me.N_Hijos.TabIndex = 30
        '
        'Fecha
        '
        Me.Fecha.Enabled = False
        Me.Fecha.Location = New System.Drawing.Point(146, 153)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Size = New System.Drawing.Size(244, 26)
        Me.Fecha.TabIndex = 29
        '
        'Telefono
        '
        Me.Telefono.Enabled = False
        Me.Telefono.Location = New System.Drawing.Point(146, 122)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Size = New System.Drawing.Size(244, 26)
        Me.Telefono.TabIndex = 28
        '
        'Edad
        '
        Me.Edad.Enabled = False
        Me.Edad.Location = New System.Drawing.Point(146, 90)
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        Me.Edad.Size = New System.Drawing.Size(244, 26)
        Me.Edad.TabIndex = 27
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(146, 58)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Size = New System.Drawing.Size(244, 26)
        Me.Nombre.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 19)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Ciudad:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 19)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Telefono:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 281)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 19)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Rut:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 19)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "N° Hijos:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 19)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre Paciente:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Edad:"
        '
        'Ficha_Atencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 672)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Ficha_Atencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha Atencion al Paciente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents N_Hijos As System.Windows.Forms.TextBox
    Friend WithEvents Fecha As System.Windows.Forms.TextBox
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Edad As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents MotivodeConsulta As System.Windows.Forms.TextBox
    Friend WithEvents Tratamiento As System.Windows.Forms.TextBox
    Friend WithEvents Antecedentes As System.Windows.Forms.TextBox
    Friend WithEvents Medicamentos As System.Windows.Forms.TextBox
    Friend WithEvents Enfermedad As System.Windows.Forms.TextBox
    Friend WithEvents Rutes As System.Windows.Forms.ComboBox
    Friend WithEvents Volv As System.Windows.Forms.Button
    Friend WithEvents Horar As TextBox
    Friend WithEvents Label15 As Label
End Class
