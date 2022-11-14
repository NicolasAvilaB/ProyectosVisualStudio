<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carpeta_clinica
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_no_der = New System.Windows.Forms.Button()
        Me.btn_si_der = New System.Windows.Forms.Button()
        Me.txt_derivacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_no_ex = New System.Windows.Forms.Button()
        Me.btn_si_ex = New System.Windows.Forms.Button()
        Me.txt_obs_examenes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_diagnostico = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_ultimo = New System.Windows.Forms.Button()
        Me.btn_primero = New System.Windows.Forms.Button()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.btn_anterior = New System.Windows.Forms.Button()
        Me.btn_nueva_hoja = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txt_diagnostico)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_observaciones)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 286)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(923, 249)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Carpeta Clinica"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_no_der)
        Me.GroupBox5.Controls.Add(Me.btn_si_der)
        Me.GroupBox5.Controls.Add(Me.txt_derivacion)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(478, 130)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(439, 117)
        Me.GroupBox5.TabIndex = 80
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "¿El paciente será derivado?"
        '
        'btn_no_der
        '
        Me.btn_no_der.Enabled = False
        Me.btn_no_der.Location = New System.Drawing.Point(372, -1)
        Me.btn_no_der.Name = "btn_no_der"
        Me.btn_no_der.Size = New System.Drawing.Size(39, 20)
        Me.btn_no_der.TabIndex = 95
        Me.btn_no_der.Text = "NO"
        Me.btn_no_der.UseVisualStyleBackColor = True
        '
        'btn_si_der
        '
        Me.btn_si_der.Enabled = False
        Me.btn_si_der.Location = New System.Drawing.Point(327, -1)
        Me.btn_si_der.Name = "btn_si_der"
        Me.btn_si_der.Size = New System.Drawing.Size(39, 20)
        Me.btn_si_der.TabIndex = 94
        Me.btn_si_der.Text = "SI"
        Me.btn_si_der.UseVisualStyleBackColor = True
        '
        'txt_derivacion
        '
        Me.txt_derivacion.Enabled = False
        Me.txt_derivacion.Location = New System.Drawing.Point(8, 26)
        Me.txt_derivacion.MaxLength = 100
        Me.txt_derivacion.Multiline = True
        Me.txt_derivacion.Name = "txt_derivacion"
        Me.txt_derivacion.Size = New System.Drawing.Size(422, 79)
        Me.txt_derivacion.TabIndex = 73
        Me.txt_derivacion.Tag = "Escriba Diagnostico de Examenes..."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 70
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_no_ex)
        Me.GroupBox4.Controls.Add(Me.btn_si_ex)
        Me.GroupBox4.Controls.Add(Me.txt_obs_examenes)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(478, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(439, 108)
        Me.GroupBox4.TabIndex = 79
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "¿Presenta Examenes u otro documento para la consulta?"
        '
        'btn_no_ex
        '
        Me.btn_no_ex.Enabled = False
        Me.btn_no_ex.Location = New System.Drawing.Point(372, 0)
        Me.btn_no_ex.Name = "btn_no_ex"
        Me.btn_no_ex.Size = New System.Drawing.Size(39, 20)
        Me.btn_no_ex.TabIndex = 93
        Me.btn_no_ex.Text = "NO"
        Me.btn_no_ex.UseVisualStyleBackColor = True
        '
        'btn_si_ex
        '
        Me.btn_si_ex.Enabled = False
        Me.btn_si_ex.Location = New System.Drawing.Point(327, 0)
        Me.btn_si_ex.Name = "btn_si_ex"
        Me.btn_si_ex.Size = New System.Drawing.Size(39, 20)
        Me.btn_si_ex.TabIndex = 92
        Me.btn_si_ex.Text = "SI"
        Me.btn_si_ex.UseVisualStyleBackColor = True
        '
        'txt_obs_examenes
        '
        Me.txt_obs_examenes.Enabled = False
        Me.txt_obs_examenes.Location = New System.Drawing.Point(8, 26)
        Me.txt_obs_examenes.MaxLength = 300
        Me.txt_obs_examenes.Multiline = True
        Me.txt_obs_examenes.Name = "txt_obs_examenes"
        Me.txt_obs_examenes.Size = New System.Drawing.Size(422, 73)
        Me.txt_obs_examenes.TabIndex = 73
        Me.txt_obs_examenes.Tag = "Escriba Diagnostico de Examenes..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 70
        '
        'txt_diagnostico
        '
        Me.txt_diagnostico.Enabled = False
        Me.txt_diagnostico.Location = New System.Drawing.Point(9, 156)
        Me.txt_diagnostico.MaxLength = 300
        Me.txt_diagnostico.Multiline = True
        Me.txt_diagnostico.Name = "txt_diagnostico"
        Me.txt_diagnostico.Size = New System.Drawing.Size(422, 78)
        Me.txt_diagnostico.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Observaciones generales"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Enabled = False
        Me.txt_observaciones.Location = New System.Drawing.Point(9, 43)
        Me.txt_observaciones.MaxLength = 300
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(422, 72)
        Me.txt_observaciones.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Diagnostico"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(923, 173)
        Me.DataGridView1.TabIndex = 81
        '
        'btn_ultimo
        '
        Me.btn_ultimo.Enabled = False
        Me.btn_ultimo.Location = New System.Drawing.Point(428, 200)
        Me.btn_ultimo.Name = "btn_ultimo"
        Me.btn_ultimo.Size = New System.Drawing.Size(39, 26)
        Me.btn_ultimo.TabIndex = 85
        Me.btn_ultimo.Text = ">|"
        Me.btn_ultimo.UseVisualStyleBackColor = True
        '
        'btn_primero
        '
        Me.btn_primero.Enabled = False
        Me.btn_primero.Location = New System.Drawing.Point(298, 200)
        Me.btn_primero.Name = "btn_primero"
        Me.btn_primero.Size = New System.Drawing.Size(39, 26)
        Me.btn_primero.TabIndex = 84
        Me.btn_primero.Text = "|<"
        Me.btn_primero.UseVisualStyleBackColor = True
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Enabled = False
        Me.btn_siguiente.Location = New System.Drawing.Point(383, 200)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(39, 26)
        Me.btn_siguiente.TabIndex = 83
        Me.btn_siguiente.Text = "->"
        Me.btn_siguiente.UseVisualStyleBackColor = True
        '
        'btn_anterior
        '
        Me.btn_anterior.Enabled = False
        Me.btn_anterior.Location = New System.Drawing.Point(340, 200)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(39, 26)
        Me.btn_anterior.TabIndex = 82
        Me.btn_anterior.Text = "<-"
        Me.btn_anterior.UseVisualStyleBackColor = True
        '
        'btn_nueva_hoja
        '
        Me.btn_nueva_hoja.Enabled = False
        Me.btn_nueva_hoja.Location = New System.Drawing.Point(473, 200)
        Me.btn_nueva_hoja.Name = "btn_nueva_hoja"
        Me.btn_nueva_hoja.Size = New System.Drawing.Size(120, 26)
        Me.btn_nueva_hoja.TabIndex = 86
        Me.btn_nueva_hoja.Text = "Nueva Hoja Clinica"
        Me.btn_nueva_hoja.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(599, 200)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(130, 26)
        Me.btn_guardar.TabIndex = 87
        Me.btn_guardar.Text = "Guardar Hoja Clinica"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Hora de Cita"
        '
        'txt_hora
        '
        Me.txt_hora.Enabled = False
        Me.txt_hora.Location = New System.Drawing.Point(575, 260)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(198, 20)
        Me.txt_hora.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Fecha de Cita"
        '
        'txt_fecha
        '
        Me.txt_fecha.Enabled = False
        Me.txt_fecha.Location = New System.Drawing.Point(271, 260)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(198, 20)
        Me.txt_fecha.TabIndex = 90
        '
        'Carpeta_clinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 545)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nueva_hoja)
        Me.Controls.Add(Me.btn_ultimo)
        Me.Controls.Add(Me.btn_primero)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.btn_anterior)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Carpeta_clinica"
        Me.Text = "Carpeta Clinica"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_derivacion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_obs_examenes As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_diagnostico As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_ultimo As System.Windows.Forms.Button
    Friend WithEvents btn_primero As System.Windows.Forms.Button
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents btn_anterior As System.Windows.Forms.Button
    Friend WithEvents btn_nueva_hoja As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents btn_no_der As System.Windows.Forms.Button
    Friend WithEvents btn_si_der As System.Windows.Forms.Button
    Friend WithEvents btn_no_ex As System.Windows.Forms.Button
    Friend WithEvents btn_si_ex As System.Windows.Forms.Button
End Class
