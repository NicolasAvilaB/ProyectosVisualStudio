<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clave_Modificar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clave_Modificar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cambiar_clave = New System.Windows.Forms.Button()
        Me.status = New System.Windows.Forms.Panel()
        Me.agregar_nuevo_vend = New System.Windows.Forms.Button()
        Me.desabilitar_ayuda = New System.Windows.Forms.CheckBox()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Blabla3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cerrar = New System.Windows.Forms.Button()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(4, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 256)
        Me.Panel1.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cambiar_clave)
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.agregar_nuevo_vend)
        Me.GroupBox1.Controls.Add(Me.desabilitar_ayuda)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.aceptar)
        Me.GroupBox1.Controls.Add(Me.contraseña)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 245)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MODIFICAR DATOS "
        '
        'cambiar_clave
        '
        Me.cambiar_clave.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cambiar_clave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cambiar_clave.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.cambiar_clave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cambiar_clave.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cambiar_clave.ForeColor = System.Drawing.Color.White
        Me.cambiar_clave.Location = New System.Drawing.Point(15, 177)
        Me.cambiar_clave.Name = "cambiar_clave"
        Me.cambiar_clave.Size = New System.Drawing.Size(375, 38)
        Me.cambiar_clave.TabIndex = 5
        Me.cambiar_clave.Text = "CAMBIAR MI CLAVE UNICA"
        Me.Blabla3.SetToolTip(Me.cambiar_clave, "Verifique su contraseña")
        Me.cambiar_clave.UseVisualStyleBackColor = False
        '
        'status
        '
        Me.status.BackgroundImage = Global.Modulo_1___Ventas_PYM.My.Resources.Resources._6
        Me.status.Location = New System.Drawing.Point(45, 221)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(316, 18)
        Me.status.TabIndex = 115
        Me.status.Visible = False
        '
        'agregar_nuevo_vend
        '
        Me.agregar_nuevo_vend.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.agregar_nuevo_vend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.agregar_nuevo_vend.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.agregar_nuevo_vend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregar_nuevo_vend.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar_nuevo_vend.ForeColor = System.Drawing.Color.White
        Me.agregar_nuevo_vend.Location = New System.Drawing.Point(15, 136)
        Me.agregar_nuevo_vend.Name = "agregar_nuevo_vend"
        Me.agregar_nuevo_vend.Size = New System.Drawing.Size(375, 38)
        Me.agregar_nuevo_vend.TabIndex = 4
        Me.agregar_nuevo_vend.Text = "AGREGAR NUEVOS VENDEDORES"
        Me.Blabla3.SetToolTip(Me.agregar_nuevo_vend, "Verifique su contraseña")
        Me.agregar_nuevo_vend.UseVisualStyleBackColor = False
        '
        'desabilitar_ayuda
        '
        Me.desabilitar_ayuda.AutoSize = True
        Me.desabilitar_ayuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.desabilitar_ayuda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.desabilitar_ayuda.Location = New System.Drawing.Point(32, 109)
        Me.desabilitar_ayuda.Name = "desabilitar_ayuda"
        Me.desabilitar_ayuda.Size = New System.Drawing.Size(342, 24)
        Me.desabilitar_ayuda.TabIndex = 3
        Me.desabilitar_ayuda.Text = "DESABILITAR TODOS LOS MENSAJES DE AYUDA"
        Me.Blabla3.SetToolTip(Me.desabilitar_ayuda, "Desactive todo los mensajes emergentes en todas las ventanas")
        Me.desabilitar_ayuda.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.ForeColor = System.Drawing.Color.White
        Me.cancelar.Location = New System.Drawing.Point(13, 64)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(131, 38)
        Me.cancelar.TabIndex = 1
        Me.cancelar.Text = "CANCELAR"
        Me.Blabla3.SetToolTip(Me.cancelar, "Cancele la operacion")
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'aceptar
        '
        Me.aceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aceptar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptar.ForeColor = System.Drawing.Color.White
        Me.aceptar.Location = New System.Drawing.Point(259, 64)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(131, 38)
        Me.aceptar.TabIndex = 2
        Me.aceptar.Text = "ACEPTAR"
        Me.Blabla3.SetToolTip(Me.aceptar, "Verifique su contraseña")
        Me.aceptar.UseVisualStyleBackColor = False
        '
        'contraseña
        '
        Me.contraseña.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contraseña.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contraseña.Location = New System.Drawing.Point(142, 28)
        Me.contraseña.MaxLength = 45
        Me.contraseña.Name = "contraseña"
        Me.contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.contraseña.Size = New System.Drawing.Size(248, 29)
        Me.contraseña.TabIndex = 0
        Me.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla3.SetToolTip(Me.contraseña, "Digite la contraseña donde usted modificara los datos")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(11, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 20)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "INGRESE CLAVE:"
        '
        'Blabla3
        '
        Me.Blabla3.AutoPopDelay = 5000
        Me.Blabla3.InitialDelay = 100
        Me.Blabla3.ReshowDelay = 100
        Me.Blabla3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Blabla3.ToolTipTitle = "Mensajes de ayuda"
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.Color.White
        Me.cerrar.Location = New System.Drawing.Point(399, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(27, 27)
        Me.cerrar.TabIndex = 0
        Me.cerrar.Text = "X"
        Me.Blabla3.SetToolTip(Me.cerrar, "Cerrar la ventana")
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizar.ForeColor = System.Drawing.Color.White
        Me.minimizar.Location = New System.Drawing.Point(366, 3)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(27, 27)
        Me.minimizar.TabIndex = 1
        Me.minimizar.Text = "---"
        Me.Blabla3.SetToolTip(Me.minimizar, "Minimizar la ventana")
        Me.minimizar.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(54, 293)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(332, 20)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "COPYRIGHT © 2018 PERSIANAS EXTERIORES PYM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "MODULO 1 - VENTAS FYD"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.minimizar)
        Me.Panel2.Controls.Add(Me.cerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 33)
        Me.Panel2.TabIndex = 15
        '
        'Clave_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 316)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clave_Modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clave Modificar"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents contraseña As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cancelar As Button
    Friend WithEvents aceptar As Button
    Friend WithEvents Blabla3 As ToolTip
    Friend WithEvents desabilitar_ayuda As CheckBox
    Friend WithEvents agregar_nuevo_vend As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents status As Panel
    Friend WithEvents cerrar As Button
    Friend WithEvents minimizar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cambiar_clave As Button
End Class
