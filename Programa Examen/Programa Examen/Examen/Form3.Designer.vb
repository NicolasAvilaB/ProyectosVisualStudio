<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adm_pacientes
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_editar_paciente = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_apellido_pat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_prevision = New System.Windows.Forms.TextBox()
        Me.txt_fono = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.txt_apellido_mat = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_anterior = New System.Windows.Forms.Button()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.btn_primero = New System.Windows.Forms.Button()
        Me.btn_ultimo = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbMujer = New System.Windows.Forms.RadioButton()
        Me.rbHombre = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.txt_busqueda = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbx_campos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_busqueda = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CERRARSESIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 435)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(592, 165)
        Me.DataGridView1.TabIndex = 63
        '
        'btn_editar_paciente
        '
        Me.btn_editar_paciente.Enabled = False
        Me.btn_editar_paciente.Location = New System.Drawing.Point(393, 186)
        Me.btn_editar_paciente.Name = "btn_editar_paciente"
        Me.btn_editar_paciente.Size = New System.Drawing.Size(90, 26)
        Me.btn_editar_paciente.TabIndex = 37
        Me.btn_editar_paciente.Text = "Editar paciente"
        Me.btn_editar_paciente.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(489, 186)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(90, 26)
        Me.btn_guardar.TabIndex = 39
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
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
        'txt_rut
        '
        Me.txt_rut.Enabled = False
        Me.txt_rut.Location = New System.Drawing.Point(99, 31)
        Me.txt_rut.MaxLength = 10
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(172, 20)
        Me.txt_rut.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(320, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Domicilio"
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Enabled = False
        Me.txt_domicilio.Location = New System.Drawing.Point(407, 57)
        Me.txt_domicilio.MaxLength = 50
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(172, 20)
        Me.txt_domicilio.TabIndex = 51
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(99, 57)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(172, 20)
        Me.txt_nombre.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Nombres"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Apellido Paterno"
        '
        'txt_apellido_pat
        '
        Me.txt_apellido_pat.Enabled = False
        Me.txt_apellido_pat.Location = New System.Drawing.Point(99, 83)
        Me.txt_apellido_pat.MaxLength = 50
        Me.txt_apellido_pat.Name = "txt_apellido_pat"
        Me.txt_apellido_pat.Size = New System.Drawing.Size(172, 20)
        Me.txt_apellido_pat.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(320, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Prevision"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(320, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Fono"
        '
        'txt_prevision
        '
        Me.txt_prevision.Enabled = False
        Me.txt_prevision.Location = New System.Drawing.Point(407, 109)
        Me.txt_prevision.MaxLength = 20
        Me.txt_prevision.Name = "txt_prevision"
        Me.txt_prevision.Size = New System.Drawing.Size(172, 20)
        Me.txt_prevision.TabIndex = 53
        '
        'txt_fono
        '
        Me.txt_fono.Enabled = False
        Me.txt_fono.Location = New System.Drawing.Point(407, 83)
        Me.txt_fono.MaxLength = 8
        Me.txt_fono.Name = "txt_fono"
        Me.txt_fono.Size = New System.Drawing.Size(172, 20)
        Me.txt_fono.TabIndex = 55
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(12, 112)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(86, 13)
        Me.label18.TabIndex = 56
        Me.label18.Text = "Apellido Materno"
        '
        'txt_apellido_mat
        '
        Me.txt_apellido_mat.Enabled = False
        Me.txt_apellido_mat.Location = New System.Drawing.Point(99, 109)
        Me.txt_apellido_mat.MaxLength = 50
        Me.txt_apellido_mat.Name = "txt_apellido_mat"
        Me.txt_apellido_mat.Size = New System.Drawing.Size(172, 20)
        Me.txt_apellido_mat.TabIndex = 57
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Location = New System.Drawing.Point(297, 186)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(90, 26)
        Me.btn_cancelar.TabIndex = 60
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_anterior
        '
        Me.btn_anterior.Enabled = False
        Me.btn_anterior.Location = New System.Drawing.Point(65, 186)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(39, 26)
        Me.btn_anterior.TabIndex = 61
        Me.btn_anterior.Text = "<-"
        Me.btn_anterior.UseVisualStyleBackColor = True
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Enabled = False
        Me.btn_siguiente.Location = New System.Drawing.Point(108, 186)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(39, 26)
        Me.btn_siguiente.TabIndex = 62
        Me.btn_siguiente.Text = "->"
        Me.btn_siguiente.UseVisualStyleBackColor = True
        '
        'btn_primero
        '
        Me.btn_primero.Enabled = False
        Me.btn_primero.Location = New System.Drawing.Point(23, 186)
        Me.btn_primero.Name = "btn_primero"
        Me.btn_primero.Size = New System.Drawing.Size(39, 26)
        Me.btn_primero.TabIndex = 63
        Me.btn_primero.Text = "|<"
        Me.btn_primero.UseVisualStyleBackColor = True
        '
        'btn_ultimo
        '
        Me.btn_ultimo.Enabled = False
        Me.btn_ultimo.Location = New System.Drawing.Point(153, 186)
        Me.btn_ultimo.Name = "btn_ultimo"
        Me.btn_ultimo.Size = New System.Drawing.Size(39, 26)
        Me.btn_ultimo.TabIndex = 64
        Me.btn_ultimo.Text = ">|"
        Me.btn_ultimo.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbMujer)
        Me.GroupBox4.Controls.Add(Me.rbHombre)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 135)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(255, 40)
        Me.GroupBox4.TabIndex = 65
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.btn_ultimo)
        Me.GroupBox1.Controls.Add(Me.btn_primero)
        Me.GroupBox1.Controls.Add(Me.btn_siguiente)
        Me.GroupBox1.Controls.Add(Me.btn_anterior)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.txt_apellido_mat)
        Me.GroupBox1.Controls.Add(Me.label18)
        Me.GroupBox1.Controls.Add(Me.txt_fono)
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
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_editar_paciente)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 228)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paciente"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DACIONToolStripMenuItem, Me.PACIENTESToolStripMenuItem, Me.AdministraToolStripMenuItem, Me.CERRARSESIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 54
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'txt_busqueda
        '
        Me.txt_busqueda.Location = New System.Drawing.Point(241, 35)
        Me.txt_busqueda.Name = "txt_busqueda"
        Me.txt_busqueda.Size = New System.Drawing.Size(153, 20)
        Me.txt_busqueda.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(85, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Campos"
        '
        'cbx_campos
        '
        Me.cbx_campos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_campos.Enabled = False
        Me.cbx_campos.FormattingEnabled = True
        Me.cbx_campos.Items.AddRange(New Object() {"Rut_Paciente", "Nombres", "Apellido_Paterno", "Apellido_Materno", "Fono"})
        Me.cbx_campos.Location = New System.Drawing.Point(20, 35)
        Me.cbx_campos.Name = "cbx_campos"
        Me.cbx_campos.Size = New System.Drawing.Size(179, 21)
        Me.cbx_campos.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Busqueda"
        '
        'btn_buscar
        '
        Me.btn_buscar.Enabled = False
        Me.btn_buscar.Location = New System.Drawing.Point(455, 29)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(90, 26)
        Me.btn_buscar.TabIndex = 40
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_buscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbx_campos)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_busqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(42, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 62)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda paciente"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(42, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 26)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Editar paciente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_busqueda
        '
        Me.btn_busqueda.Location = New System.Drawing.Point(161, 19)
        Me.btn_busqueda.Name = "btn_busqueda"
        Me.btn_busqueda.Size = New System.Drawing.Size(136, 26)
        Me.btn_busqueda.TabIndex = 40
        Me.btn_busqueda.Text = "Realizar una busqueda"
        Me.btn_busqueda.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(303, 19)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(136, 26)
        Me.btn_nuevo.TabIndex = 41
        Me.btn_nuevo.Text = "Ingresar nuevo paciente"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_nuevo)
        Me.GroupBox3.Controls.Add(Me.btn_busqueda)
        Me.GroupBox3.Location = New System.Drawing.Point(41, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(592, 52)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "¿Que desea hacer?"
        '
        'CERRARSESIONToolStripMenuItem
        '
        Me.CERRARSESIONToolStripMenuItem.Name = "CERRARSESIONToolStripMenuItem"
        Me.CERRARSESIONToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.CERRARSESIONToolStripMenuItem.Text = "CERRAR SESION"
        '
        'Adm_pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 612)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Adm_pacientes"
        Me.Text = "Administrador de pacientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_editar_paciente As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_pat As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_prevision As System.Windows.Forms.TextBox
    Friend WithEvents txt_fono As System.Windows.Forms.TextBox
    Friend WithEvents label18 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_mat As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_anterior As System.Windows.Forms.Button
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents btn_primero As System.Windows.Forms.Button
    Friend WithEvents btn_ultimo As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbMujer As System.Windows.Forms.RadioButton
    Friend WithEvents rbHombre As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CitacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PACIENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents txt_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbx_campos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_busqueda As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CERRARSESIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
