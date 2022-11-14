<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citar_paciente
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
        Me.btn_citar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_rut_busqueda = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbMujer = New System.Windows.Forms.RadioButton()
        Me.rbHombre = New System.Windows.Forms.RadioButton()
        Me.txt_apellido_mat = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_fono = New System.Windows.Forms.TextBox()
        Me.btn_editar_paciente = New System.Windows.Forms.Button()
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
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.cbx_profesional = New System.Windows.Forms.ComboBox()
        Me.cbx_agenda = New System.Windows.Forms.ComboBox()
        Me.cbx_hora = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ok_agenda = New System.Windows.Forms.Button()
        Me.btn_ok_hora = New System.Windows.Forms.Button()
        Me.btn_ok_profesional = New System.Windows.Forms.Button()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_rut_prof = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_ok_fecha = New System.Windows.Forms.Button()
        Me.cbxfecha = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.CERRARSESIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_citar
        '
        Me.btn_citar.Location = New System.Drawing.Point(417, 52)
        Me.btn_citar.Name = "btn_citar"
        Me.btn_citar.Size = New System.Drawing.Size(70, 20)
        Me.btn_citar.TabIndex = 42
        Me.btn_citar.Text = "Citar"
        Me.btn_citar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(179, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "R.U.T."
        '
        'txt_rut_busqueda
        '
        Me.txt_rut_busqueda.Location = New System.Drawing.Point(244, 53)
        Me.txt_rut_busqueda.MaxLength = 10
        Me.txt_rut_busqueda.Name = "txt_rut_busqueda"
        Me.txt_rut_busqueda.Size = New System.Drawing.Size(153, 20)
        Me.txt_rut_busqueda.TabIndex = 40
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DACIONToolStripMenuItem, Me.PACIENTESToolStripMenuItem, Me.AdministraToolStripMenuItem, Me.CERRARSESIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(664, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DACIONToolStripMenuItem
        '
        Me.DACIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CitacionToolStripMenuItem, Me.AnularCitaToolStripMenuItem})
        Me.DACIONToolStripMenuItem.Name = "DACIONToolStripMenuItem"
        Me.DACIONToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.DACIONToolStripMenuItem.Text = "CITAS"
        '
        'CitacionToolStripMenuItem
        '
        Me.CitacionToolStripMenuItem.Name = "CitacionToolStripMenuItem"
        Me.CitacionToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.CitacionToolStripMenuItem.Text = "Citacion"
        '
        'AnularCitaToolStripMenuItem
        '
        Me.AnularCitaToolStripMenuItem.Name = "AnularCitaToolStripMenuItem"
        Me.AnularCitaToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AnularCitaToolStripMenuItem.Text = "Consultar o Anular Citas"
        '
        'PACIENTESToolStripMenuItem
        '
        Me.PACIENTESToolStripMenuItem.Name = "PACIENTESToolStripMenuItem"
        Me.PACIENTESToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.PACIENTESToolStripMenuItem.Text = "PACIENTES"
        '
        'AdministraToolStripMenuItem
        '
        Me.AdministraToolStripMenuItem.Name = "AdministraToolStripMenuItem"
        Me.AdministraToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.AdministraToolStripMenuItem.Text = "ADMINISTRADOR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txt_apellido_mat)
        Me.GroupBox1.Controls.Add(Me.label18)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.txt_fono)
        Me.GroupBox1.Controls.Add(Me.btn_editar_paciente)
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
        Me.GroupBox1.Location = New System.Drawing.Point(41, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 181)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos paciente"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbMujer)
        Me.GroupBox4.Controls.Add(Me.rbHombre)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 132)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(255, 40)
        Me.GroupBox4.TabIndex = 66
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sexo"
        '
        'rbMujer
        '
        Me.rbMujer.AutoSize = True
        Me.rbMujer.Enabled = False
        Me.rbMujer.Location = New System.Drawing.Point(188, 14)
        Me.rbMujer.Name = "rbMujer"
        Me.rbMujer.Size = New System.Drawing.Size(51, 17)
        Me.rbMujer.TabIndex = 1
        Me.rbMujer.TabStop = True
        Me.rbMujer.Text = "Mujer"
        Me.rbMujer.UseVisualStyleBackColor = True
        '
        'rbHombre
        '
        Me.rbHombre.AutoSize = True
        Me.rbHombre.Enabled = False
        Me.rbHombre.Location = New System.Drawing.Point(97, 14)
        Me.rbHombre.Name = "rbHombre"
        Me.rbHombre.Size = New System.Drawing.Size(62, 17)
        Me.rbHombre.TabIndex = 0
        Me.rbHombre.TabStop = True
        Me.rbHombre.Text = "Hombre"
        Me.rbHombre.UseVisualStyleBackColor = True
        '
        'txt_apellido_mat
        '
        Me.txt_apellido_mat.Enabled = False
        Me.txt_apellido_mat.Location = New System.Drawing.Point(93, 106)
        Me.txt_apellido_mat.MaxLength = 50
        Me.txt_apellido_mat.Name = "txt_apellido_mat"
        Me.txt_apellido_mat.Size = New System.Drawing.Size(172, 20)
        Me.txt_apellido_mat.TabIndex = 41
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(6, 109)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(86, 13)
        Me.label18.TabIndex = 40
        Me.label18.Text = "Apellido Materno"
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(483, 141)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(90, 26)
        Me.btn_guardar.TabIndex = 39
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_fono
        '
        Me.txt_fono.Enabled = False
        Me.txt_fono.Location = New System.Drawing.Point(401, 80)
        Me.txt_fono.MaxLength = 8
        Me.txt_fono.Name = "txt_fono"
        Me.txt_fono.Size = New System.Drawing.Size(172, 20)
        Me.txt_fono.TabIndex = 36
        '
        'btn_editar_paciente
        '
        Me.btn_editar_paciente.Enabled = False
        Me.btn_editar_paciente.Location = New System.Drawing.Point(387, 141)
        Me.btn_editar_paciente.Name = "btn_editar_paciente"
        Me.btn_editar_paciente.Size = New System.Drawing.Size(90, 26)
        Me.btn_editar_paciente.TabIndex = 37
        Me.btn_editar_paciente.Text = "Editar paciente"
        Me.btn_editar_paciente.UseVisualStyleBackColor = True
        '
        'txt_prevision
        '
        Me.txt_prevision.Enabled = False
        Me.txt_prevision.Location = New System.Drawing.Point(401, 106)
        Me.txt_prevision.MaxLength = 20
        Me.txt_prevision.Name = "txt_prevision"
        Me.txt_prevision.Size = New System.Drawing.Size(172, 20)
        Me.txt_prevision.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(314, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Fono"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(314, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Prevision"
        '
        'txt_apellido_pat
        '
        Me.txt_apellido_pat.Enabled = False
        Me.txt_apellido_pat.Location = New System.Drawing.Point(93, 80)
        Me.txt_apellido_pat.MaxLength = 50
        Me.txt_apellido_pat.Name = "txt_apellido_pat"
        Me.txt_apellido_pat.Size = New System.Drawing.Size(172, 20)
        Me.txt_apellido_pat.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Apellido Paterno"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Nombres"
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(93, 54)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(172, 20)
        Me.txt_nombre.TabIndex = 27
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Enabled = False
        Me.txt_domicilio.Location = New System.Drawing.Point(401, 54)
        Me.txt_domicilio.MaxLength = 50
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(172, 20)
        Me.txt_domicilio.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(314, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Domicilio"
        '
        'txt_rut
        '
        Me.txt_rut.Enabled = False
        Me.txt_rut.Location = New System.Drawing.Point(93, 28)
        Me.txt_rut.MaxLength = 10
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(172, 20)
        Me.txt_rut.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Rut"
        '
        'btn_grabar
        '
        Me.btn_grabar.Enabled = False
        Me.btn_grabar.Location = New System.Drawing.Point(213, 201)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(90, 20)
        Me.btn_grabar.TabIndex = 38
        Me.btn_grabar.Text = "Grabar citacion"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'cbx_profesional
        '
        Me.cbx_profesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_profesional.Enabled = False
        Me.cbx_profesional.FormattingEnabled = True
        Me.cbx_profesional.Location = New System.Drawing.Point(119, 120)
        Me.cbx_profesional.Name = "cbx_profesional"
        Me.cbx_profesional.Size = New System.Drawing.Size(144, 21)
        Me.cbx_profesional.TabIndex = 37
        '
        'cbx_agenda
        '
        Me.cbx_agenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_agenda.Enabled = False
        Me.cbx_agenda.FormattingEnabled = True
        Me.cbx_agenda.Location = New System.Drawing.Point(119, 92)
        Me.cbx_agenda.Name = "cbx_agenda"
        Me.cbx_agenda.Size = New System.Drawing.Size(144, 21)
        Me.cbx_agenda.TabIndex = 36
        '
        'cbx_hora
        '
        Me.cbx_hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_hora.Enabled = False
        Me.cbx_hora.FormattingEnabled = True
        Me.cbx_hora.Location = New System.Drawing.Point(119, 174)
        Me.cbx_hora.Name = "cbx_hora"
        Me.cbx_hora.Size = New System.Drawing.Size(144, 21)
        Me.cbx_hora.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Hora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Profesional"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Agenda"
        '
        'btn_ok_agenda
        '
        Me.btn_ok_agenda.Enabled = False
        Me.btn_ok_agenda.Location = New System.Drawing.Point(269, 93)
        Me.btn_ok_agenda.Name = "btn_ok_agenda"
        Me.btn_ok_agenda.Size = New System.Drawing.Size(34, 20)
        Me.btn_ok_agenda.TabIndex = 44
        Me.btn_ok_agenda.Text = "OK"
        Me.btn_ok_agenda.UseVisualStyleBackColor = True
        '
        'btn_ok_hora
        '
        Me.btn_ok_hora.Enabled = False
        Me.btn_ok_hora.Location = New System.Drawing.Point(269, 175)
        Me.btn_ok_hora.Name = "btn_ok_hora"
        Me.btn_ok_hora.Size = New System.Drawing.Size(34, 20)
        Me.btn_ok_hora.TabIndex = 47
        Me.btn_ok_hora.Text = "OK"
        Me.btn_ok_hora.UseVisualStyleBackColor = True
        '
        'btn_ok_profesional
        '
        Me.btn_ok_profesional.Enabled = False
        Me.btn_ok_profesional.Location = New System.Drawing.Point(269, 121)
        Me.btn_ok_profesional.Name = "btn_ok_profesional"
        Me.btn_ok_profesional.Size = New System.Drawing.Size(34, 20)
        Me.btn_ok_profesional.TabIndex = 46
        Me.btn_ok_profesional.Text = "OK"
        Me.btn_ok_profesional.UseVisualStyleBackColor = True
        '
        'txt_folio
        '
        Me.txt_folio.Enabled = False
        Me.txt_folio.Location = New System.Drawing.Point(439, 120)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(179, 20)
        Me.txt_folio.TabIndex = 49
        Me.txt_folio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(358, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Folio"
        '
        'txt_rut_prof
        '
        Me.txt_rut_prof.Enabled = False
        Me.txt_rut_prof.Location = New System.Drawing.Point(439, 146)
        Me.txt_rut_prof.MaxLength = 10
        Me.txt_rut_prof.Name = "txt_rut_prof"
        Me.txt_rut_prof.Size = New System.Drawing.Size(125, 20)
        Me.txt_rut_prof.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(358, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Rut Profesional"
        '
        'btn_ok_fecha
        '
        Me.btn_ok_fecha.Enabled = False
        Me.btn_ok_fecha.Location = New System.Drawing.Point(269, 148)
        Me.btn_ok_fecha.Name = "btn_ok_fecha"
        Me.btn_ok_fecha.Size = New System.Drawing.Size(34, 20)
        Me.btn_ok_fecha.TabIndex = 54
        Me.btn_ok_fecha.Text = "OK"
        Me.btn_ok_fecha.UseVisualStyleBackColor = True
        '
        'cbxfecha
        '
        Me.cbxfecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxfecha.Enabled = False
        Me.cbxfecha.FormattingEnabled = True
        Me.cbxfecha.Location = New System.Drawing.Point(119, 147)
        Me.cbxfecha.Name = "cbxfecha"
        Me.cbxfecha.Size = New System.Drawing.Size(144, 21)
        Me.cbxfecha.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Fecha"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(565, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 13)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "ID"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(584, 146)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(34, 20)
        Me.txt_id.TabIndex = 56
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Enabled = False
        Me.btn_limpiar.Location = New System.Drawing.Point(119, 201)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(91, 20)
        Me.btn_limpiar.TabIndex = 59
        Me.btn_limpiar.Text = "Cancelar cita"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'CERRARSESIONToolStripMenuItem
        '
        Me.CERRARSESIONToolStripMenuItem.Name = "CERRARSESIONToolStripMenuItem"
        Me.CERRARSESIONToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.CERRARSESIONToolStripMenuItem.Text = "CERRAR SESION"
        '
        'Citar_paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 434)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btn_ok_fecha)
        Me.Controls.Add(Me.cbxfecha)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_rut_prof)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_ok_hora)
        Me.Controls.Add(Me.btn_ok_profesional)
        Me.Controls.Add(Me.btn_ok_agenda)
        Me.Controls.Add(Me.btn_citar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_rut_busqueda)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbx_profesional)
        Me.Controls.Add(Me.cbx_agenda)
        Me.Controls.Add(Me.cbx_hora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Citar_paciente"
        Me.Text = "Citar Paciente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_citar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_rut_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CitacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PACIENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_editar_paciente As System.Windows.Forms.Button
    Friend WithEvents txt_fono As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_prevision As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_pat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbx_profesional As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_agenda As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_hora As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_mat As System.Windows.Forms.TextBox
    Friend WithEvents label18 As System.Windows.Forms.Label
    Friend WithEvents btn_ok_agenda As System.Windows.Forms.Button
    Friend WithEvents btn_ok_hora As System.Windows.Forms.Button
    Friend WithEvents btn_ok_profesional As System.Windows.Forms.Button
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_rut_prof As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_ok_fecha As System.Windows.Forms.Button
    Friend WithEvents cbxfecha As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbMujer As System.Windows.Forms.RadioButton
    Friend WithEvents rbHombre As System.Windows.Forms.RadioButton
    Friend WithEvents CERRARSESIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
