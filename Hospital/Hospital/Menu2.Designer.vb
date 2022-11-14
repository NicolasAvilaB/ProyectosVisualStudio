<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Horario = New System.Windows.Forms.Button()
        Me.Reservas = New System.Windows.Forms.Button()
        Me.Doctores = New System.Windows.Forms.Button()
        Me.Pacientes = New System.Windows.Forms.Button()
        Me.Doctor = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Doctor)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Horario)
        Me.GroupBox1.Controls.Add(Me.Reservas)
        Me.GroupBox1.Controls.Add(Me.Doctores)
        Me.GroupBox1.Controls.Add(Me.Pacientes)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 346)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acceso"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Seleccion de Fichas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Horario
        '
        Me.Horario.Location = New System.Drawing.Point(17, 292)
        Me.Horario.Name = "Horario"
        Me.Horario.Size = New System.Drawing.Size(195, 33)
        Me.Horario.TabIndex = 3
        Me.Horario.Text = "Vizualiza Fichas"
        Me.Horario.UseVisualStyleBackColor = True
        '
        'Reservas
        '
        Me.Reservas.Location = New System.Drawing.Point(17, 241)
        Me.Reservas.Name = "Reservas"
        Me.Reservas.Size = New System.Drawing.Size(195, 33)
        Me.Reservas.TabIndex = 2
        Me.Reservas.Text = "Reservas"
        Me.Reservas.UseVisualStyleBackColor = True
        '
        'Doctores
        '
        Me.Doctores.Location = New System.Drawing.Point(17, 76)
        Me.Doctores.Name = "Doctores"
        Me.Doctores.Size = New System.Drawing.Size(195, 33)
        Me.Doctores.TabIndex = 1
        Me.Doctores.Text = "Doctores o Usuarios"
        Me.Doctores.UseVisualStyleBackColor = True
        '
        'Pacientes
        '
        Me.Pacientes.Location = New System.Drawing.Point(17, 25)
        Me.Pacientes.Name = "Pacientes"
        Me.Pacientes.Size = New System.Drawing.Size(195, 33)
        Me.Pacientes.TabIndex = 0
        Me.Pacientes.Text = "Informacion Pacientes"
        Me.Pacientes.UseVisualStyleBackColor = True
        '
        'Doctor
        '
        Me.Doctor.Location = New System.Drawing.Point(17, 138)
        Me.Doctor.Name = "Doctor"
        Me.Doctor.Size = New System.Drawing.Size(195, 28)
        Me.Doctor.TabIndex = 5
        Me.Doctor.Text = "Reservas Doctor"
        Me.Doctor.UseVisualStyleBackColor = True
        '
        'Menu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(260, 371)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Menu2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Pacientes As System.Windows.Forms.Button
    Friend WithEvents Doctores As System.Windows.Forms.Button
    Friend WithEvents Reservas As System.Windows.Forms.Button
    Friend WithEvents Horario As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Doctor As Button
End Class
