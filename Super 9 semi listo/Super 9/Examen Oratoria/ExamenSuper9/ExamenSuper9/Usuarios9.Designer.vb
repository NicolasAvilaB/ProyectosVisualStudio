<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios9))
        Me.P_Exteriores = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cajeros = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Ver3 = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Terminar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.TxtCajero = New System.Windows.Forms.TextBox()
        Me.Agre_Usuarios = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cierres = New System.Windows.Forms.Button()
        Me.Ver2 = New System.Windows.Forms.Button()
        Me.Ventas = New System.Windows.Forms.Button()
        Me.Admin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.C_SA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Volver = New System.Windows.Forms.Button()
        Me.MSupervisor = New System.Windows.Forms.Button()
        Me.GrillaUsuarios = New System.Windows.Forms.DataGridView()
        Me.Nuevos_Administradores = New System.Windows.Forms.Button()
        Me.Productos = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_Exteriores
        '
        Me.P_Exteriores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.P_Exteriores.Enabled = False
        Me.P_Exteriores.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_Exteriores.Location = New System.Drawing.Point(348, 294)
        Me.P_Exteriores.Name = "P_Exteriores"
        Me.P_Exteriores.Size = New System.Drawing.Size(254, 48)
        Me.P_Exteriores.TabIndex = 2
        Me.P_Exteriores.Text = "Personas Exteriores"
        Me.ToolTip1.SetToolTip(Me.P_Exteriores, "Esta Opcion Permite, Ingresar, Modificar o Eliminar Personas en " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cual Te Suminis" & _
        "tra el Local con Los Productos")
        Me.P_Exteriores.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.Enabled = False
        Me.Cancelar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Location = New System.Drawing.Point(348, 404)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(254, 48)
        Me.Cancelar.TabIndex = 7
        Me.Cancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.Cancelar, "Si Quieres Salir de Este Modo Solo Debes Cancear la Operacion")
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(726, 567)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(272, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'Cajeros
        '
        Me.Cajeros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cajeros.Enabled = False
        Me.Cajeros.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cajeros.Location = New System.Drawing.Point(348, 187)
        Me.Cajeros.Name = "Cajeros"
        Me.Cajeros.Size = New System.Drawing.Size(254, 47)
        Me.Cajeros.TabIndex = 14
        Me.Cajeros.Text = "Cajeros/as"
        Me.ToolTip1.SetToolTip(Me.Cajeros, "Esta Opcion Permite, Ingresar, Modificar o Eliminar Cajeros")
        Me.Cajeros.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Ver3)
        Me.GroupBox2.Controls.Add(Me.Guardar)
        Me.GroupBox2.Controls.Add(Me.Terminar)
        Me.GroupBox2.Controls.Add(Me.Eliminar)
        Me.GroupBox2.Controls.Add(Me.Modificar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtClave)
        Me.GroupBox2.Controls.Add(Me.TxtCajero)
        Me.GroupBox2.Controls.Add(Me.Agre_Usuarios)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(348, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 171)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cajeros /as"
        '
        'Ver3
        '
        Me.Ver3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ver3.Enabled = False
        Me.Ver3.Location = New System.Drawing.Point(174, 97)
        Me.Ver3.Name = "Ver3"
        Me.Ver3.Size = New System.Drawing.Size(72, 30)
        Me.Ver3.TabIndex = 22
        Me.Ver3.Text = "Ver"
        Me.ToolTip1.SetToolTip(Me.Ver3, "Vizualiza Tu Constraseña en Caso De Que Este Incorrecta")
        Me.Ver3.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(174, 132)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(72, 30)
        Me.Guardar.TabIndex = 12
        Me.Guardar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.Guardar, "Guardar y Registra Tus Cajeros Nuevos")
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Terminar
        '
        Me.Terminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Terminar.Enabled = False
        Me.Terminar.Location = New System.Drawing.Point(91, 132)
        Me.Terminar.Name = "Terminar"
        Me.Terminar.Size = New System.Drawing.Size(79, 31)
        Me.Terminar.TabIndex = 11
        Me.Terminar.Text = "Terminar"
        Me.ToolTip1.SetToolTip(Me.Terminar, "Puedes Salir de Este Modo")
        Me.Terminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar.Enabled = False
        Me.Eliminar.Location = New System.Drawing.Point(6, 131)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(79, 33)
        Me.Eliminar.TabIndex = 10
        Me.Eliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.Eliminar, "Eliminar Algun Cajero Existente")
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modificar.Enabled = False
        Me.Modificar.Location = New System.Drawing.Point(91, 97)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(79, 30)
        Me.Modificar.TabIndex = 9
        Me.Modificar.Text = "Modificar"
        Me.ToolTip1.SetToolTip(Me.Modificar, "Modifica Un Cajero Existente")
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Clave:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cajero/a:"
        '
        'TxtClave
        '
        Me.TxtClave.Enabled = False
        Me.TxtClave.Location = New System.Drawing.Point(56, 58)
        Me.TxtClave.MaxLength = 9
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(190, 26)
        Me.TxtClave.TabIndex = 6
        '
        'TxtCajero
        '
        Me.TxtCajero.Enabled = False
        Me.TxtCajero.Location = New System.Drawing.Point(75, 23)
        Me.TxtCajero.Name = "TxtCajero"
        Me.TxtCajero.Size = New System.Drawing.Size(171, 26)
        Me.TxtCajero.TabIndex = 5
        '
        'Agre_Usuarios
        '
        Me.Agre_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agre_Usuarios.Enabled = False
        Me.Agre_Usuarios.Location = New System.Drawing.Point(6, 97)
        Me.Agre_Usuarios.Name = "Agre_Usuarios"
        Me.Agre_Usuarios.Size = New System.Drawing.Size(80, 30)
        Me.Agre_Usuarios.TabIndex = 4
        Me.Agre_Usuarios.Text = "Nuevo"
        Me.ToolTip1.SetToolTip(Me.Agre_Usuarios, "Ingresa Nuevo Cajero")
        Me.Agre_Usuarios.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cierres)
        Me.GroupBox1.Controls.Add(Me.Ver2)
        Me.GroupBox1.Controls.Add(Me.Ventas)
        Me.GroupBox1.Controls.Add(Me.Admin)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.C_SA)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Volver)
        Me.GroupBox1.Controls.Add(Me.MSupervisor)
        Me.GroupBox1.Controls.Add(Me.GrillaUsuarios)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 442)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros"
        '
        'Cierres
        '
        Me.Cierres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cierres.Enabled = False
        Me.Cierres.Location = New System.Drawing.Point(6, 311)
        Me.Cierres.Name = "Cierres"
        Me.Cierres.Size = New System.Drawing.Size(314, 34)
        Me.Cierres.TabIndex = 22
        Me.Cierres.Text = "Cierres Cajas"
        Me.ToolTip1.SetToolTip(Me.Cierres, "Revisa Los Cierres de Cajas")
        Me.Cierres.UseVisualStyleBackColor = True
        '
        'Ver2
        '
        Me.Ver2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ver2.Enabled = False
        Me.Ver2.Location = New System.Drawing.Point(183, 86)
        Me.Ver2.Name = "Ver2"
        Me.Ver2.Size = New System.Drawing.Size(137, 50)
        Me.Ver2.TabIndex = 20
        Me.Ver2.Text = "Ver"
        Me.ToolTip1.SetToolTip(Me.Ver2, "Vizualiza Tu Constraseña en Caso De Que Este Incorrecta")
        Me.Ver2.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.Ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ventas.Enabled = False
        Me.Ventas.Location = New System.Drawing.Point(6, 349)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(314, 34)
        Me.Ventas.TabIndex = 14
        Me.Ventas.Text = "Ventas"
        Me.ToolTip1.SetToolTip(Me.Ventas, "Vizualiza Las Ventas Realizadas, Puedes Filtrar la Fecha ")
        Me.Ventas.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.Admin.Location = New System.Drawing.Point(110, 23)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(210, 26)
        Me.Admin.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Admin, "Ingresa Tu Nombre de Administrador Registrado")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Administrador:"
        '
        'C_SA
        '
        Me.C_SA.Enabled = False
        Me.C_SA.Location = New System.Drawing.Point(145, 52)
        Me.C_SA.MaxLength = 9
        Me.C_SA.Name = "C_SA"
        Me.C_SA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.C_SA.Size = New System.Drawing.Size(175, 26)
        Me.C_SA.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.C_SA, "Ingresa Tu Clave de Administrador Registrada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Y Podras Entrar al Modo Admin Con S" & _
        "olo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pinchar la Tecla Enter o El Boton " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Modo Administrador""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Clave Administrador:"
        '
        'Volver
        '
        Me.Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Volver.Location = New System.Drawing.Point(6, 388)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(314, 48)
        Me.Volver.TabIndex = 5
        Me.Volver.Text = "Volver"
        Me.ToolTip1.SetToolTip(Me.Volver, "Vuelves a la Ventana Anterior")
        Me.Volver.UseVisualStyleBackColor = True
        '
        'MSupervisor
        '
        Me.MSupervisor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSupervisor.Enabled = False
        Me.MSupervisor.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSupervisor.Location = New System.Drawing.Point(6, 86)
        Me.MSupervisor.Name = "MSupervisor"
        Me.MSupervisor.Size = New System.Drawing.Size(171, 50)
        Me.MSupervisor.TabIndex = 2
        Me.MSupervisor.Text = "Modo Administrador"
        Me.ToolTip1.SetToolTip(Me.MSupervisor, "Inicia El Modo Admin")
        Me.MSupervisor.UseVisualStyleBackColor = True
        '
        'GrillaUsuarios
        '
        Me.GrillaUsuarios.AllowUserToAddRows = False
        Me.GrillaUsuarios.AllowUserToDeleteRows = False
        Me.GrillaUsuarios.AllowUserToResizeRows = False
        Me.GrillaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrillaUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.GrillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GrillaUsuarios.Location = New System.Drawing.Point(6, 148)
        Me.GrillaUsuarios.Name = "GrillaUsuarios"
        Me.GrillaUsuarios.ReadOnly = True
        Me.GrillaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaUsuarios.ShowCellToolTips = False
        Me.GrillaUsuarios.Size = New System.Drawing.Size(314, 157)
        Me.GrillaUsuarios.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.GrillaUsuarios, "Vizualiza Los Cajeros Registrados y Selecciona uno de Ellos para Vizualizarlos en" & _
        " las Cajitas de Texto")
        '
        'Nuevos_Administradores
        '
        Me.Nuevos_Administradores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Nuevos_Administradores.Enabled = False
        Me.Nuevos_Administradores.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevos_Administradores.Location = New System.Drawing.Point(348, 240)
        Me.Nuevos_Administradores.Name = "Nuevos_Administradores"
        Me.Nuevos_Administradores.Size = New System.Drawing.Size(254, 48)
        Me.Nuevos_Administradores.TabIndex = 14
        Me.Nuevos_Administradores.Text = "Nuevos Administradores"
        Me.ToolTip1.SetToolTip(Me.Nuevos_Administradores, "Puedes Ingresar Nuevos Administradores del Local")
        Me.Nuevos_Administradores.UseVisualStyleBackColor = True
        '
        'Productos
        '
        Me.Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Productos.Enabled = False
        Me.Productos.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Productos.Location = New System.Drawing.Point(348, 349)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(254, 48)
        Me.Productos.TabIndex = 19
        Me.Productos.Text = "Productos"
        Me.ToolTip1.SetToolTip(Me.Productos, "Esta Opcion Permite, Ingresar, Modificar o Eliminar Productos")
        Me.Productos.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 457)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'Usuarios9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(610, 482)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Productos)
        Me.Controls.Add(Me.Nuevos_Administradores)
        Me.Controls.Add(Me.P_Exteriores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Cajeros)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Usuarios9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios, Productos y Mas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrillaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cajeros As System.Windows.Forms.Button
    Friend WithEvents P_Exteriores As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Terminar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents TxtCajero As System.Windows.Forms.TextBox
    Friend WithEvents Agre_Usuarios As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Admin As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents C_SA As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents MSupervisor As System.Windows.Forms.Button
    Friend WithEvents GrillaUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Nuevos_Administradores As System.Windows.Forms.Button
    Friend WithEvents Productos As System.Windows.Forms.Button
    Friend WithEvents Ventas As System.Windows.Forms.Button
    Friend WithEvents Ver2 As System.Windows.Forms.Button
    Friend WithEvents Ver3 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Cierres As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
