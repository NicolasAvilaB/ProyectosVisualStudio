<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entrada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrada))
        Me.Secciones = New System.Windows.Forms.GroupBox()
        Me.Ventas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Administracion = New System.Windows.Forms.Button()
        Me.Usuarios = New System.Windows.Forms.GroupBox()
        Me.Ver = New System.Windows.Forms.Button()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.TxtUsuarios = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.Ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ventas.Location = New System.Drawing.Point(598, 21)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(192, 58)
        Me.Ventas.TabIndex = 0
        Me.Ventas.Text = "Ventas"
        Me.ToolTip1.SetToolTip(Me.Ventas, "Puedes Ingresar Pinchando Aqui")
        Me.Ventas.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = Global.ExamenSuper9.My.Resources.Resources.DSC_063454a__copia_0
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(10, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(582, 248)
        Me.Panel1.TabIndex = 4
        '
        'Salir
        '
        Me.Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir.Location = New System.Drawing.Point(598, 211)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(192, 58)
        Me.Salir.TabIndex = 2
        Me.Salir.Text = "Salir"
        Me.ToolTip1.SetToolTip(Me.Salir, "Puedes Salir del Programa")
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Administracion
        '
        Me.Administracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Administracion.Location = New System.Drawing.Point(598, 118)
        Me.Administracion.Name = "Administracion"
        Me.Administracion.Size = New System.Drawing.Size(192, 58)
        Me.Administracion.TabIndex = 1
        Me.Administracion.Text = "Administracion"
        Me.ToolTip1.SetToolTip(Me.Administracion, "Si Eres Administrador Podras Realizar Ajustes Aqui" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Directamente, Sobre los Produ" &
        "ctos o Cajeros Nuevos Entre otros")
        Me.Administracion.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.Usuarios.BackColor = System.Drawing.SystemColors.Control
        Me.Usuarios.Controls.Add(Me.Ver)
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
        'Ver
        '
        Me.Ver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ver.Enabled = False
        Me.Ver.Location = New System.Drawing.Point(702, 79)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(88, 29)
        Me.Ver.TabIndex = 2
        Me.Ver.Text = "Ver"
        Me.ToolTip1.SetToolTip(Me.Ver, "Puedes Vizualizar la Clave en Caso de Que te Hayas Equivocado")
        Me.Ver.UseVisualStyleBackColor = True
        '
        'TxtClave
        '
        Me.TxtClave.Enabled = False
        Me.TxtClave.Location = New System.Drawing.Point(71, 80)
        Me.TxtClave.MaxLength = 9
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(625, 28)
        Me.TxtClave.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TxtClave, "Escribe Tu Clave Registrada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Y Pincha Aceptar o Solo Presiona Enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'TxtUsuarios
        '
        Me.TxtUsuarios.Enabled = False
        Me.TxtUsuarios.Location = New System.Drawing.Point(84, 38)
        Me.TxtUsuarios.Name = "TxtUsuarios"
        Me.TxtUsuarios.Size = New System.Drawing.Size(706, 28)
        Me.TxtUsuarios.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TxtUsuarios, "Escribe Tu Nombre Registrado")
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
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.Enabled = False
        Me.Cancelar.Location = New System.Drawing.Point(619, 122)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(180, 54)
        Me.Cancelar.TabIndex = 4
        Me.Cancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.Cancelar, "Puedes Cancelar Para Salir De Este Modo")
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Aceptar.Enabled = False
        Me.Aceptar.Location = New System.Drawing.Point(7, 122)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(201, 54)
        Me.Aceptar.TabIndex = 3
        Me.Aceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.Aceptar, "Ingresa Una Vez Completado Los Campos")
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
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje"
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents Ver As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
