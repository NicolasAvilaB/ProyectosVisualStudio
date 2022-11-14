<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.btn_acceder = New System.Windows.Forms.Button()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.txtprivilegio = New System.Windows.Forms.TextBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.CERRARSESIONToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(97, 48)
        Me.txt_usuario.MaxLength = 10
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(153, 20)
        Me.txt_usuario.TabIndex = 40
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(32, 51)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_usuario.TabIndex = 41
        Me.lbl_usuario.Text = "Usuario"
        '
        'btn_acceder
        '
        Me.btn_acceder.Location = New System.Drawing.Point(275, 64)
        Me.btn_acceder.Name = "btn_acceder"
        Me.btn_acceder.Size = New System.Drawing.Size(70, 20)
        Me.btn_acceder.TabIndex = 42
        Me.btn_acceder.Text = "Acceder"
        Me.btn_acceder.UseVisualStyleBackColor = True
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Location = New System.Drawing.Point(32, 81)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_clave.TabIndex = 44
        Me.lbl_clave.Text = "Clave"
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(97, 78)
        Me.txt_clave.MaxLength = 10
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(153, 20)
        Me.txt_clave.TabIndex = 45
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DACIONToolStripMenuItem, Me.PACIENTESToolStripMenuItem, Me.AdministraToolStripMenuItem, Me.CERRARSESIONToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(370, 24)
        Me.MenuStrip1.TabIndex = 56
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
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
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Location = New System.Drawing.Point(57, 71)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(278, 13)
        Me.lbl_info.TabIndex = 57
        Me.lbl_info.Text = "Despliegue las cintas de opciones para iniciar una accion"
        Me.lbl_info.Visible = False
        '
        'txtprivilegio
        '
        Me.txtprivilegio.Enabled = False
        Me.txtprivilegio.Location = New System.Drawing.Point(216, 114)
        Me.txtprivilegio.Name = "txtprivilegio"
        Me.txtprivilegio.Size = New System.Drawing.Size(153, 20)
        Me.txtprivilegio.TabIndex = 58
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CerrarSesionToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(370, 24)
        Me.MenuStrip2.TabIndex = 59
        Me.MenuStrip2.Text = "MenuStrip2"
        Me.MenuStrip2.Visible = False
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
        'txt_rut
        '
        Me.txt_rut.Enabled = False
        Me.txt_rut.Location = New System.Drawing.Point(216, 140)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(153, 20)
        Me.txt_rut.TabIndex = 61
        '
        'CERRARSESIONToolStripMenuItem1
        '
        Me.CERRARSESIONToolStripMenuItem1.Name = "CERRARSESIONToolStripMenuItem1"
        Me.CERRARSESIONToolStripMenuItem1.Size = New System.Drawing.Size(104, 20)
        Me.CERRARSESIONToolStripMenuItem1.Text = "CERRAR SESION"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 161)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.txtprivilegio)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.btn_acceder)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_usuario)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents btn_acceder As System.Windows.Forms.Button
    Friend WithEvents lbl_clave As System.Windows.Forms.Label
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CitacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PACIENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_info As System.Windows.Forms.Label
    Friend WithEvents txtprivilegio As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CERRARSESIONToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
