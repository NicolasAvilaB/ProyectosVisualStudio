<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adm_citas
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_cambiar_filtro = New System.Windows.Forms.Button()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.rb_anteriores = New System.Windows.Forms.RadioButton()
        Me.rb_pendientes = New System.Windows.Forms.RadioButton()
        Me.cbx_busqueda = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id_medico = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_sexo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.btn_ultimo = New System.Windows.Forms.Button()
        Me.btn_primero = New System.Windows.Forms.Button()
        Me.txt_apellido_mat = New System.Windows.Forms.TextBox()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.label18 = New System.Windows.Forms.Label()
        Me.txt_fono = New System.Windows.Forms.TextBox()
        Me.btn_anterior = New System.Windows.Forms.Button()
        Me.txt_prevision = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_apellido_pat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_abrir_ficha = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.cbx_busqueda)
        Me.GroupBox2.Controls.Add(Me.btn_buscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 77)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda de citas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_cambiar_filtro)
        Me.GroupBox3.Controls.Add(Me.BTN_OK)
        Me.GroupBox3.Controls.Add(Me.rb_anteriores)
        Me.GroupBox3.Controls.Add(Me.rb_pendientes)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 59)
        Me.GroupBox3.TabIndex = 74
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "¿Que desea filtrar?"
        '
        'btn_cambiar_filtro
        '
        Me.btn_cambiar_filtro.Enabled = False
        Me.btn_cambiar_filtro.Location = New System.Drawing.Point(180, 20)
        Me.btn_cambiar_filtro.Name = "btn_cambiar_filtro"
        Me.btn_cambiar_filtro.Size = New System.Drawing.Size(90, 26)
        Me.btn_cambiar_filtro.TabIndex = 76
        Me.btn_cambiar_filtro.Text = "Cambiar Filtro"
        Me.btn_cambiar_filtro.UseVisualStyleBackColor = True
        '
        'BTN_OK
        '
        Me.BTN_OK.Enabled = False
        Me.BTN_OK.Location = New System.Drawing.Point(126, 20)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(48, 26)
        Me.BTN_OK.TabIndex = 75
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = True
        '
        'rb_anteriores
        '
        Me.rb_anteriores.AutoSize = True
        Me.rb_anteriores.Location = New System.Drawing.Point(25, 36)
        Me.rb_anteriores.Name = "rb_anteriores"
        Me.rb_anteriores.Size = New System.Drawing.Size(72, 17)
        Me.rb_anteriores.TabIndex = 73
        Me.rb_anteriores.TabStop = True
        Me.rb_anteriores.Text = "Anteriores"
        Me.rb_anteriores.UseVisualStyleBackColor = True
        '
        'rb_pendientes
        '
        Me.rb_pendientes.AutoSize = True
        Me.rb_pendientes.Location = New System.Drawing.Point(25, 18)
        Me.rb_pendientes.Name = "rb_pendientes"
        Me.rb_pendientes.Size = New System.Drawing.Size(78, 17)
        Me.rb_pendientes.TabIndex = 72
        Me.rb_pendientes.TabStop = True
        Me.rb_pendientes.Text = "Pendientes"
        Me.rb_pendientes.UseVisualStyleBackColor = True
        '
        'cbx_busqueda
        '
        Me.cbx_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_busqueda.Enabled = False
        Me.cbx_busqueda.FormattingEnabled = True
        Me.cbx_busqueda.Location = New System.Drawing.Point(357, 41)
        Me.cbx_busqueda.Name = "cbx_busqueda"
        Me.cbx_busqueda.Size = New System.Drawing.Size(149, 21)
        Me.cbx_busqueda.TabIndex = 59
        '
        'btn_buscar
        '
        Me.btn_buscar.Enabled = False
        Me.btn_buscar.Location = New System.Drawing.Point(512, 38)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(60, 26)
        Me.btn_buscar.TabIndex = 40
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(413, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(746, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "ID PROFESIONAL"
        '
        'txt_id_medico
        '
        Me.txt_id_medico.Enabled = False
        Me.txt_id_medico.Location = New System.Drawing.Point(848, 27)
        Me.txt_id_medico.Name = "txt_id_medico"
        Me.txt_id_medico.Size = New System.Drawing.Size(72, 20)
        Me.txt_id_medico.TabIndex = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_sexo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_hora)
        Me.GroupBox1.Controls.Add(Me.btn_ultimo)
        Me.GroupBox1.Controls.Add(Me.btn_primero)
        Me.GroupBox1.Controls.Add(Me.txt_apellido_mat)
        Me.GroupBox1.Controls.Add(Me.btn_siguiente)
        Me.GroupBox1.Controls.Add(Me.label18)
        Me.GroupBox1.Controls.Add(Me.txt_fono)
        Me.GroupBox1.Controls.Add(Me.btn_anterior)
        Me.GroupBox1.Controls.Add(Me.txt_prevision)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_apellido_pat)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_domicilio)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_rut)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btn_abrir_ficha)
        Me.GroupBox1.Location = New System.Drawing.Point(623, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 362)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paciente"
        '
        'txt_sexo
        '
        Me.txt_sexo.Enabled = False
        Me.txt_sexo.Location = New System.Drawing.Point(99, 165)
        Me.txt_sexo.Name = "txt_sexo"
        Me.txt_sexo.Size = New System.Drawing.Size(198, 20)
        Me.txt_sexo.TabIndex = 67
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 168)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Hora de Cita"
        '
        'txt_hora
        '
        Me.txt_hora.Enabled = False
        Me.txt_hora.Location = New System.Drawing.Point(99, 57)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(198, 20)
        Me.txt_hora.TabIndex = 60
        '
        'btn_ultimo
        '
        Me.btn_ultimo.Enabled = False
        Me.btn_ultimo.Location = New System.Drawing.Point(148, 312)
        Me.btn_ultimo.Name = "btn_ultimo"
        Me.btn_ultimo.Size = New System.Drawing.Size(39, 26)
        Me.btn_ultimo.TabIndex = 64
        Me.btn_ultimo.Text = ">|"
        Me.btn_ultimo.UseVisualStyleBackColor = True
        '
        'btn_primero
        '
        Me.btn_primero.Enabled = False
        Me.btn_primero.Location = New System.Drawing.Point(18, 312)
        Me.btn_primero.Name = "btn_primero"
        Me.btn_primero.Size = New System.Drawing.Size(39, 26)
        Me.btn_primero.TabIndex = 63
        Me.btn_primero.Text = "|<"
        Me.btn_primero.UseVisualStyleBackColor = True
        '
        'txt_apellido_mat
        '
        Me.txt_apellido_mat.Enabled = False
        Me.txt_apellido_mat.Location = New System.Drawing.Point(99, 135)
        Me.txt_apellido_mat.Name = "txt_apellido_mat"
        Me.txt_apellido_mat.Size = New System.Drawing.Size(198, 20)
        Me.txt_apellido_mat.TabIndex = 57
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Enabled = False
        Me.btn_siguiente.Location = New System.Drawing.Point(103, 312)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(39, 26)
        Me.btn_siguiente.TabIndex = 62
        Me.btn_siguiente.Text = "->"
        Me.btn_siguiente.UseVisualStyleBackColor = True
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(12, 138)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(86, 13)
        Me.label18.TabIndex = 56
        Me.label18.Text = "Apellido Materno"
        '
        'txt_fono
        '
        Me.txt_fono.Enabled = False
        Me.txt_fono.Location = New System.Drawing.Point(99, 217)
        Me.txt_fono.Name = "txt_fono"
        Me.txt_fono.Size = New System.Drawing.Size(198, 20)
        Me.txt_fono.TabIndex = 55
        '
        'btn_anterior
        '
        Me.btn_anterior.Enabled = False
        Me.btn_anterior.Location = New System.Drawing.Point(60, 312)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(39, 26)
        Me.btn_anterior.TabIndex = 61
        Me.btn_anterior.Text = "<-"
        Me.btn_anterior.UseVisualStyleBackColor = True
        '
        'txt_prevision
        '
        Me.txt_prevision.Enabled = False
        Me.txt_prevision.Location = New System.Drawing.Point(99, 243)
        Me.txt_prevision.Name = "txt_prevision"
        Me.txt_prevision.Size = New System.Drawing.Size(198, 20)
        Me.txt_prevision.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Fono"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 246)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Prevision"
        '
        'txt_apellido_pat
        '
        Me.txt_apellido_pat.Enabled = False
        Me.txt_apellido_pat.Location = New System.Drawing.Point(99, 109)
        Me.txt_apellido_pat.Name = "txt_apellido_pat"
        Me.txt_apellido_pat.Size = New System.Drawing.Size(198, 20)
        Me.txt_apellido_pat.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Apellido Paterno"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Nombres"
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(99, 83)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(198, 20)
        Me.txt_nombre.TabIndex = 46
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Enabled = False
        Me.txt_domicilio.Location = New System.Drawing.Point(99, 191)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(198, 20)
        Me.txt_domicilio.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Domicilio"
        '
        'txt_rut
        '
        Me.txt_rut.Enabled = False
        Me.txt_rut.Location = New System.Drawing.Point(99, 31)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(198, 20)
        Me.txt_rut.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Rut"
        '
        'btn_abrir_ficha
        '
        Me.btn_abrir_ficha.Enabled = False
        Me.btn_abrir_ficha.Location = New System.Drawing.Point(193, 305)
        Me.btn_abrir_ficha.Name = "btn_abrir_ficha"
        Me.btn_abrir_ficha.Size = New System.Drawing.Size(106, 38)
        Me.btn_abrir_ficha.TabIndex = 37
        Me.btn_abrir_ficha.Text = "Abrir Carpeta Clinica"
        Me.btn_abrir_ficha.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(592, 279)
        Me.DataGridView1.TabIndex = 70
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CerrarSesionToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(944, 24)
        Me.MenuStrip2.TabIndex = 71
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(45, 20)
        Me.ToolStripMenuItem1.Text = "Citas"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'Adm_citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 421)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_id_medico)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Adm_citas"
        Me.Text = "Administrar Citas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbx_busqueda As System.Windows.Forms.ComboBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_apellido_mat As System.Windows.Forms.TextBox
    Friend WithEvents label18 As System.Windows.Forms.Label
    Friend WithEvents txt_fono As System.Windows.Forms.TextBox
    Friend WithEvents txt_prevision As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_pat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_abrir_ficha As System.Windows.Forms.Button
    Friend WithEvents btn_ultimo As System.Windows.Forms.Button
    Friend WithEvents btn_primero As System.Windows.Forms.Button
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents btn_anterior As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_id_medico As System.Windows.Forms.TextBox
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_sexo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rb_pendientes As System.Windows.Forms.RadioButton
    Friend WithEvents rb_anteriores As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_OK As System.Windows.Forms.Button
    Friend WithEvents btn_cambiar_filtro As System.Windows.Forms.Button
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
