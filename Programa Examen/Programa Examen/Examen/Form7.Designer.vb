<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anular_cita
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
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_rut_busqueda = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_ultimo = New System.Windows.Forms.Button()
        Me.btn_primero = New System.Windows.Forms.Button()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.btn_anterior = New System.Windows.Forms.Button()
        Me.btn_anular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.txt_profesional = New System.Windows.Forms.TextBox()
        Me.txt_agenda = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CERRARSESIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(384, 40)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(137, 20)
        Me.btn_buscar.TabIndex = 45
        Me.btn_buscar.Text = "Buscar Citas Pendientes"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(146, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "R.U.T."
        '
        'txt_rut_busqueda
        '
        Me.txt_rut_busqueda.Location = New System.Drawing.Point(211, 41)
        Me.txt_rut_busqueda.MaxLength = 10
        Me.txt_rut_busqueda.Name = "txt_rut_busqueda"
        Me.txt_rut_busqueda.Size = New System.Drawing.Size(153, 20)
        Me.txt_rut_busqueda.TabIndex = 43
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(625, 160)
        Me.DataGridView1.TabIndex = 71
        '
        'btn_ultimo
        '
        Me.btn_ultimo.Enabled = False
        Me.btn_ultimo.Location = New System.Drawing.Point(321, 342)
        Me.btn_ultimo.Name = "btn_ultimo"
        Me.btn_ultimo.Size = New System.Drawing.Size(39, 26)
        Me.btn_ultimo.TabIndex = 76
        Me.btn_ultimo.Text = ">|"
        Me.btn_ultimo.UseVisualStyleBackColor = True
        '
        'btn_primero
        '
        Me.btn_primero.Enabled = False
        Me.btn_primero.Location = New System.Drawing.Point(191, 342)
        Me.btn_primero.Name = "btn_primero"
        Me.btn_primero.Size = New System.Drawing.Size(39, 26)
        Me.btn_primero.TabIndex = 75
        Me.btn_primero.Text = "|<"
        Me.btn_primero.UseVisualStyleBackColor = True
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Enabled = False
        Me.btn_siguiente.Location = New System.Drawing.Point(276, 342)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(39, 26)
        Me.btn_siguiente.TabIndex = 74
        Me.btn_siguiente.Text = "->"
        Me.btn_siguiente.UseVisualStyleBackColor = True
        '
        'btn_anterior
        '
        Me.btn_anterior.Enabled = False
        Me.btn_anterior.Location = New System.Drawing.Point(233, 342)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(39, 26)
        Me.btn_anterior.TabIndex = 73
        Me.btn_anterior.Text = "<-"
        Me.btn_anterior.UseVisualStyleBackColor = True
        '
        'btn_anular
        '
        Me.btn_anular.Enabled = False
        Me.btn_anular.Location = New System.Drawing.Point(366, 336)
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(106, 38)
        Me.btn_anular.TabIndex = 72
        Me.btn_anular.Text = "Anular esta citacion"
        Me.btn_anular.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(390, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(390, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Hora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Profesional"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Agenda"
        '
        'txt_hora
        '
        Me.txt_hora.Enabled = False
        Me.txt_hora.Location = New System.Drawing.Point(465, 303)
        Me.txt_hora.MaxLength = 50
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(172, 20)
        Me.txt_hora.TabIndex = 85
        '
        'txt_fecha
        '
        Me.txt_fecha.Enabled = False
        Me.txt_fecha.Location = New System.Drawing.Point(465, 277)
        Me.txt_fecha.MaxLength = 50
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(172, 20)
        Me.txt_fecha.TabIndex = 84
        '
        'txt_profesional
        '
        Me.txt_profesional.Enabled = False
        Me.txt_profesional.Location = New System.Drawing.Point(87, 303)
        Me.txt_profesional.MaxLength = 50
        Me.txt_profesional.Name = "txt_profesional"
        Me.txt_profesional.Size = New System.Drawing.Size(172, 20)
        Me.txt_profesional.TabIndex = 83
        '
        'txt_agenda
        '
        Me.txt_agenda.Enabled = False
        Me.txt_agenda.Location = New System.Drawing.Point(87, 277)
        Me.txt_agenda.MaxLength = 10
        Me.txt_agenda.Name = "txt_agenda"
        Me.txt_agenda.Size = New System.Drawing.Size(172, 20)
        Me.txt_agenda.TabIndex = 82
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DACIONToolStripMenuItem, Me.PACIENTESToolStripMenuItem, Me.AdministraToolStripMenuItem, Me.CERRARSESIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 24)
        Me.MenuStrip1.TabIndex = 86
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
        'txt_rut
        '
        Me.txt_rut.Enabled = False
        Me.txt_rut.Location = New System.Drawing.Point(87, 251)
        Me.txt_rut.MaxLength = 10
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(172, 20)
        Me.txt_rut.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Rut Paciente"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(465, 251)
        Me.txt_id.MaxLength = 10
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(39, 20)
        Me.txt_id.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(390, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Id Medico"
        '
        'CERRARSESIONToolStripMenuItem
        '
        Me.CERRARSESIONToolStripMenuItem.Name = "CERRARSESIONToolStripMenuItem"
        Me.CERRARSESIONToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.CERRARSESIONToolStripMenuItem.Text = "CERRAR SESION"
        '
        'Anular_cita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 390)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_profesional)
        Me.Controls.Add(Me.txt_agenda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_ultimo)
        Me.Controls.Add(Me.btn_primero)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.btn_anterior)
        Me.Controls.Add(Me.btn_anular)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_rut_busqueda)
        Me.Name = "Anular_cita"
        Me.Text = "Anular Cita"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_rut_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_ultimo As System.Windows.Forms.Button
    Friend WithEvents btn_primero As System.Windows.Forms.Button
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents btn_anterior As System.Windows.Forms.Button
    Friend WithEvents btn_anular As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents txt_profesional As System.Windows.Forms.TextBox
    Friend WithEvents txt_agenda As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CitacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PACIENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CERRARSESIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
