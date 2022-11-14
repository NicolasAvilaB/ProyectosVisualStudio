<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrador
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_editar_usuario = New System.Windows.Forms.Button()
        Me.txt_apellidos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.cbx_privilegio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_busqueda_usuario = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_buscar_x_rut = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btn_crear_usuario = New System.Windows.Forms.Button()
        Me.btn_buscar_usuario = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.calendario = New System.Windows.Forms.DateTimePicker()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_minutos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.Hora = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_buscar_profesional = New System.Windows.Forms.Button()
        Me.txt_busqueda_profesional = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id_pro = New System.Windows.Forms.TextBox()
        Me.txt_agenda_a_cargo__profesional = New System.Windows.Forms.TextBox()
        Me.txt_apellidos_profesional = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_nombres_profesional = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_rut_profesional = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CERRARSESIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DACIONToolStripMenuItem, Me.PACIENTESToolStripMenuItem, Me.AdministraToolStripMenuItem, Me.CERRARSESIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(720, 24)
        Me.MenuStrip1.TabIndex = 93
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
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.txt_clave)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_editar_usuario)
        Me.GroupBox1.Controls.Add(Me.txt_apellidos)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.cbx_privilegio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_rut)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 232)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos usuario"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Location = New System.Drawing.Point(115, 183)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(71, 26)
        Me.btn_cancelar.TabIndex = 111
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_clave
        '
        Me.txt_clave.Enabled = False
        Me.txt_clave.Location = New System.Drawing.Point(110, 139)
        Me.txt_clave.MaxLength = 10
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(172, 20)
        Me.txt_clave.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Clave"
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(19, 183)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(90, 26)
        Me.btn_guardar.TabIndex = 39
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_editar_usuario
        '
        Me.btn_editar_usuario.Enabled = False
        Me.btn_editar_usuario.Location = New System.Drawing.Point(192, 183)
        Me.btn_editar_usuario.Name = "btn_editar_usuario"
        Me.btn_editar_usuario.Size = New System.Drawing.Size(90, 26)
        Me.btn_editar_usuario.TabIndex = 37
        Me.btn_editar_usuario.Text = "Editar usuario"
        Me.btn_editar_usuario.UseVisualStyleBackColor = True
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Enabled = False
        Me.txt_apellidos.Location = New System.Drawing.Point(110, 83)
        Me.txt_apellidos.MaxLength = 50
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(172, 20)
        Me.txt_apellidos.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Apellidos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Nombres"
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(110, 57)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(172, 20)
        Me.txt_nombre.TabIndex = 27
        '
        'cbx_privilegio
        '
        Me.cbx_privilegio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_privilegio.Enabled = False
        Me.cbx_privilegio.FormattingEnabled = True
        Me.cbx_privilegio.Items.AddRange(New Object() {"Administrador", "Profesional"})
        Me.cbx_privilegio.Location = New System.Drawing.Point(110, 112)
        Me.cbx_privilegio.Name = "cbx_privilegio"
        Me.cbx_privilegio.Size = New System.Drawing.Size(172, 21)
        Me.cbx_privilegio.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Grado"
        '
        'txt_rut
        '
        Me.txt_rut.Enabled = False
        Me.txt_rut.Location = New System.Drawing.Point(110, 31)
        Me.txt_rut.MaxLength = 10
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(172, 20)
        Me.txt_rut.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Rut"
        '
        'txt_busqueda_usuario
        '
        Me.txt_busqueda_usuario.Enabled = False
        Me.txt_busqueda_usuario.Location = New System.Drawing.Point(110, 13)
        Me.txt_busqueda_usuario.MaxLength = 10
        Me.txt_busqueda_usuario.Name = "txt_busqueda_usuario"
        Me.txt_busqueda_usuario.Size = New System.Drawing.Size(112, 20)
        Me.txt_busqueda_usuario.TabIndex = 103
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btn_buscar_x_rut)
        Me.GroupBox3.Controls.Add(Me.txt_busqueda_usuario)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 40)
        Me.GroupBox3.TabIndex = 110
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Rut"
        '
        'btn_buscar_x_rut
        '
        Me.btn_buscar_x_rut.Enabled = False
        Me.btn_buscar_x_rut.Location = New System.Drawing.Point(228, 13)
        Me.btn_buscar_x_rut.Name = "btn_buscar_x_rut"
        Me.btn_buscar_x_rut.Size = New System.Drawing.Size(68, 20)
        Me.btn_buscar_x_rut.TabIndex = 109
        Me.btn_buscar_x_rut.Text = "Buscar"
        Me.btn_buscar_x_rut.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btn_crear_usuario)
        Me.GroupBox7.Controls.Add(Me.btn_buscar_usuario)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Controls.Add(Me.GroupBox1)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(334, 354)
        Me.GroupBox7.TabIndex = 114
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Usuarios"
        '
        'btn_crear_usuario
        '
        Me.btn_crear_usuario.Enabled = False
        Me.btn_crear_usuario.Location = New System.Drawing.Point(228, 25)
        Me.btn_crear_usuario.Name = "btn_crear_usuario"
        Me.btn_crear_usuario.Size = New System.Drawing.Size(89, 20)
        Me.btn_crear_usuario.TabIndex = 113
        Me.btn_crear_usuario.Text = "Crear Usuario"
        Me.btn_crear_usuario.UseVisualStyleBackColor = True
        '
        'btn_buscar_usuario
        '
        Me.btn_buscar_usuario.Enabled = False
        Me.btn_buscar_usuario.Location = New System.Drawing.Point(125, 25)
        Me.btn_buscar_usuario.Name = "btn_buscar_usuario"
        Me.btn_buscar_usuario.Size = New System.Drawing.Size(89, 20)
        Me.btn_buscar_usuario.TabIndex = 112
        Me.btn_buscar_usuario.Text = "Buscar Usuario"
        Me.btn_buscar_usuario.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "¿Que desea hacer?"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(370, 39)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(334, 354)
        Me.GroupBox4.TabIndex = 115
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ASIGNAR HORAS A PROFESIONAL"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.calendario)
        Me.GroupBox8.Controls.Add(Me.btn_agregar)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.txt_minutos)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.txt_hora)
        Me.GroupBox8.Controls.Add(Me.Hora)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Location = New System.Drawing.Point(15, 225)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(302, 119)
        Me.GroupBox8.TabIndex = 103
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Colocar Horas de atencion"
        '
        'calendario
        '
        Me.calendario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calendario.Location = New System.Drawing.Point(110, 25)
        Me.calendario.Name = "calendario"
        Me.calendario.Size = New System.Drawing.Size(92, 20)
        Me.calendario.TabIndex = 117
        Me.calendario.Value = New Date(2015, 12, 2, 17, 43, 16, 0)
        '
        'btn_agregar
        '
        Me.btn_agregar.Enabled = False
        Me.btn_agregar.Location = New System.Drawing.Point(116, 83)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(68, 26)
        Me.btn_agregar.TabIndex = 110
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Hrs"
        '
        'txt_minutos
        '
        Me.txt_minutos.Enabled = False
        Me.txt_minutos.Location = New System.Drawing.Point(161, 54)
        Me.txt_minutos.MaxLength = 2
        Me.txt_minutos.Name = "txt_minutos"
        Me.txt_minutos.Size = New System.Drawing.Size(29, 20)
        Me.txt_minutos.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = ":"
        '
        'txt_hora
        '
        Me.txt_hora.Enabled = False
        Me.txt_hora.Location = New System.Drawing.Point(110, 54)
        Me.txt_hora.MaxLength = 2
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(29, 20)
        Me.txt_hora.TabIndex = 107
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.Location = New System.Drawing.Point(17, 57)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(30, 13)
        Me.Hora.TabIndex = 28
        Me.Hora.Text = "Hora"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Fecha"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.btn_buscar_profesional)
        Me.GroupBox5.Controls.Add(Me.txt_busqueda_profesional)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 28)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(302, 40)
        Me.GroupBox5.TabIndex = 110
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Buscar profesional"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Rut"
        '
        'btn_buscar_profesional
        '
        Me.btn_buscar_profesional.Enabled = False
        Me.btn_buscar_profesional.Location = New System.Drawing.Point(228, 13)
        Me.btn_buscar_profesional.Name = "btn_buscar_profesional"
        Me.btn_buscar_profesional.Size = New System.Drawing.Size(68, 20)
        Me.btn_buscar_profesional.TabIndex = 109
        Me.btn_buscar_profesional.Text = "Buscar"
        Me.btn_buscar_profesional.UseVisualStyleBackColor = True
        '
        'txt_busqueda_profesional
        '
        Me.txt_busqueda_profesional.Enabled = False
        Me.txt_busqueda_profesional.Location = New System.Drawing.Point(110, 13)
        Me.txt_busqueda_profesional.MaxLength = 10
        Me.txt_busqueda_profesional.Name = "txt_busqueda_profesional"
        Me.txt_busqueda_profesional.Size = New System.Drawing.Size(112, 20)
        Me.txt_busqueda_profesional.TabIndex = 103
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txt_id_pro)
        Me.GroupBox6.Controls.Add(Me.txt_agenda_a_cargo__profesional)
        Me.GroupBox6.Controls.Add(Me.txt_apellidos_profesional)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.txt_nombres_profesional)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.txt_rut_profesional)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 74)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(302, 145)
        Me.GroupBox6.TabIndex = 91
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos profesional"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Id"
        '
        'txt_id_pro
        '
        Me.txt_id_pro.Enabled = False
        Me.txt_id_pro.Location = New System.Drawing.Point(253, 28)
        Me.txt_id_pro.MaxLength = 2
        Me.txt_id_pro.Name = "txt_id_pro"
        Me.txt_id_pro.Size = New System.Drawing.Size(29, 20)
        Me.txt_id_pro.TabIndex = 108
        '
        'txt_agenda_a_cargo__profesional
        '
        Me.txt_agenda_a_cargo__profesional.Enabled = False
        Me.txt_agenda_a_cargo__profesional.Location = New System.Drawing.Point(110, 110)
        Me.txt_agenda_a_cargo__profesional.MaxLength = 50
        Me.txt_agenda_a_cargo__profesional.Name = "txt_agenda_a_cargo__profesional"
        Me.txt_agenda_a_cargo__profesional.Size = New System.Drawing.Size(172, 20)
        Me.txt_agenda_a_cargo__profesional.TabIndex = 102
        '
        'txt_apellidos_profesional
        '
        Me.txt_apellidos_profesional.Enabled = False
        Me.txt_apellidos_profesional.Location = New System.Drawing.Point(110, 80)
        Me.txt_apellidos_profesional.MaxLength = 50
        Me.txt_apellidos_profesional.Name = "txt_apellidos_profesional"
        Me.txt_apellidos_profesional.Size = New System.Drawing.Size(172, 20)
        Me.txt_apellidos_profesional.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Apellidos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Nombres"
        '
        'txt_nombres_profesional
        '
        Me.txt_nombres_profesional.Enabled = False
        Me.txt_nombres_profesional.Location = New System.Drawing.Point(110, 54)
        Me.txt_nombres_profesional.MaxLength = 50
        Me.txt_nombres_profesional.Name = "txt_nombres_profesional"
        Me.txt_nombres_profesional.Size = New System.Drawing.Size(172, 20)
        Me.txt_nombres_profesional.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Agenda a cargo"
        '
        'txt_rut_profesional
        '
        Me.txt_rut_profesional.Enabled = False
        Me.txt_rut_profesional.Location = New System.Drawing.Point(110, 28)
        Me.txt_rut_profesional.MaxLength = 10
        Me.txt_rut_profesional.Name = "txt_rut_profesional"
        Me.txt_rut_profesional.Size = New System.Drawing.Size(112, 20)
        Me.txt_rut_profesional.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Rut"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(370, 407)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(334, 184)
        Me.DataGridView1.TabIndex = 116
        '
        'CERRARSESIONToolStripMenuItem
        '
        Me.CERRARSESIONToolStripMenuItem.Name = "CERRARSESIONToolStripMenuItem"
        Me.CERRARSESIONToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.CERRARSESIONToolStripMenuItem.Text = "CERRAR SESION"
        '
        'administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 605)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "administrador"
        Me.Text = "Administrador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CitacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PACIENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_editar_usuario As System.Windows.Forms.Button
    Friend WithEvents txt_apellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbx_privilegio As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_busqueda_usuario As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_buscar_x_rut As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar_profesional As System.Windows.Forms.Button
    Friend WithEvents txt_busqueda_profesional As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_apellidos_profesional As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_nombres_profesional As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_rut_profesional As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_agenda_a_cargo__profesional As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_minutos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents Hora As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_crear_usuario As System.Windows.Forms.Button
    Friend WithEvents btn_buscar_usuario As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents calendario As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_id_pro As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CERRARSESIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
