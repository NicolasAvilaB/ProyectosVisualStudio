<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada
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
        Me.Secciones = New System.Windows.Forms.GroupBox()
        Me.Ventas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Administracion = New System.Windows.Forms.Button()
        Me.ProInformes = New System.Windows.Forms.Button()
        Me.Usuarios = New System.Windows.Forms.GroupBox()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.TxtUsuarios = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Secciones.SuspendLayout()
        Me.Usuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'Secciones
        '
        Me.Secciones.BackColor = System.Drawing.SystemColors.Control
        Me.Secciones.Controls.Add(Me.Ventas)
        Me.Secciones.Controls.Add(Me.Panel1)
        Me.Secciones.Controls.Add(Me.Salir)
        Me.Secciones.Controls.Add(Me.Administracion)
        Me.Secciones.Controls.Add(Me.ProInformes)
        Me.Secciones.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Secciones.Location = New System.Drawing.Point(13, 13)
        Me.Secciones.Name = "Secciones"
        Me.Secciones.Size = New System.Drawing.Size(805, 294)
        Me.Secciones.TabIndex = 0
        Me.Secciones.TabStop = False
        Me.Secciones.Text = "Bienvenido"
        '
        'Ventas
        '
        Me.Ventas.Location = New System.Drawing.Point(598, 21)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(192, 58)
        Me.Ventas.TabIndex = 0
        Me.Ventas.Text = "Ventas"
        Me.Ventas.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = Global.ExamenSuper9.My.Resources.Resources.DSC_0634a
        Me.Panel1.Location = New System.Drawing.Point(10, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 262)
        Me.Panel1.TabIndex = 4
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(598, 225)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(192, 58)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Administracion
        '
        Me.Administracion.Location = New System.Drawing.Point(598, 155)
        Me.Administracion.Name = "Administracion"
        Me.Administracion.Size = New System.Drawing.Size(192, 58)
        Me.Administracion.TabIndex = 2
        Me.Administracion.Text = "Administracion"
        Me.Administracion.UseVisualStyleBackColor = True
        '
        'ProInformes
        '
        Me.ProInformes.Location = New System.Drawing.Point(598, 88)
        Me.ProInformes.Name = "ProInformes"
        Me.ProInformes.Size = New System.Drawing.Size(192, 58)
        Me.ProInformes.TabIndex = 1
        Me.ProInformes.Text = "Procesos Informes"
        Me.ProInformes.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.Usuarios.BackColor = System.Drawing.SystemColors.Control
        Me.Usuarios.Controls.Add(Me.TxtClave)
        Me.Usuarios.Controls.Add(Me.TxtUsuarios)
        Me.Usuarios.Controls.Add(Me.Label2)
        Me.Usuarios.Controls.Add(Me.Label1)
        Me.Usuarios.Controls.Add(Me.Cancelar)
        Me.Usuarios.Controls.Add(Me.Aceptar)
        Me.Usuarios.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuarios.Location = New System.Drawing.Point(13, 313)
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(805, 182)
        Me.Usuarios.TabIndex = 1
        Me.Usuarios.TabStop = False
        Me.Usuarios.Text = "Ingreso a Usuarios"
        '
        'TxtClave
        '
        Me.TxtClave.Enabled = False
        Me.TxtClave.Location = New System.Drawing.Point(71, 80)
        Me.TxtClave.MaxLength = 9
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(719, 28)
        Me.TxtClave.TabIndex = 5
        '
        'TxtUsuarios
        '
        Me.TxtUsuarios.Enabled = False
        Me.TxtUsuarios.Location = New System.Drawing.Point(84, 38)
        Me.TxtUsuarios.Name = "TxtUsuarios"
        Me.TxtUsuarios.Size = New System.Drawing.Size(706, 28)
        Me.TxtUsuarios.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clave :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario :"
        '
        'Cancelar
        '
        Me.Cancelar.Enabled = False
        Me.Cancelar.Location = New System.Drawing.Point(619, 122)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(180, 54)
        Me.Cancelar.TabIndex = 1
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Enabled = False
        Me.Aceptar.Location = New System.Drawing.Point(7, 122)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(201, 54)
        Me.Aceptar.TabIndex = 0
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(277, 498)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(830, 521)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Usuarios)
        Me.Controls.Add(Me.Secciones)
        Me.MaximizeBox = False
        Me.Name = "Entrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido a Supermercados el 9"
        Me.Secciones.ResumeLayout(False)
        Me.Usuarios.ResumeLayout(False)
        Me.Usuarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Secciones As System.Windows.Forms.GroupBox
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Administracion As System.Windows.Forms.Button
    Friend WithEvents ProInformes As System.Windows.Forms.Button
    Friend WithEvents Ventas As System.Windows.Forms.Button
    Friend WithEvents Usuarios As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuarios As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
