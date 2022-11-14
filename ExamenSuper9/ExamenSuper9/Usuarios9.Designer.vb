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
        Me.P_Exteriores = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cajeros = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.Ultimo = New System.Windows.Forms.Button()
        Me.Siguiente = New System.Windows.Forms.Button()
        Me.Anterior = New System.Windows.Forms.Button()
        Me.Primero = New System.Windows.Forms.Button()
        Me.Admin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.C_SA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Volver = New System.Windows.Forms.Button()
        Me.MSupervisor = New System.Windows.Forms.Button()
        Me.GrillaUsuarios = New System.Windows.Forms.DataGridView()
        Me.Nuevos_Administradores = New System.Windows.Forms.Button()
        Me.Productos = New System.Windows.Forms.Button()
        Me.Ventas = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_Exteriores
        '
        Me.P_Exteriores.Enabled = False
        Me.P_Exteriores.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_Exteriores.Location = New System.Drawing.Point(348, 294)
        Me.P_Exteriores.Name = "P_Exteriores"
        Me.P_Exteriores.Size = New System.Drawing.Size(254, 48)
        Me.P_Exteriores.TabIndex = 2
        Me.P_Exteriores.Text = "Personas Exteriores"
        Me.P_Exteriores.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Enabled = False
        Me.Cancelar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Location = New System.Drawing.Point(348, 404)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(254, 48)
        Me.Cancelar.TabIndex = 7
        Me.Cancelar.Text = "Cancelar"
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
        Me.Cajeros.Enabled = False
        Me.Cajeros.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cajeros.Location = New System.Drawing.Point(348, 187)
        Me.Cajeros.Name = "Cajeros"
        Me.Cajeros.Size = New System.Drawing.Size(254, 47)
        Me.Cajeros.TabIndex = 14
        Me.Cajeros.Text = "Cajeros/as"
        Me.Cajeros.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
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
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(176, 97)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(72, 30)
        Me.Guardar.TabIndex = 12
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Terminar
        '
        Me.Terminar.Enabled = False
        Me.Terminar.Location = New System.Drawing.Point(144, 133)
        Me.Terminar.Name = "Terminar"
        Me.Terminar.Size = New System.Drawing.Size(79, 31)
        Me.Terminar.TabIndex = 11
        Me.Terminar.Text = "Terminar"
        Me.Terminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Enabled = False
        Me.Eliminar.Location = New System.Drawing.Point(43, 131)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(79, 33)
        Me.Eliminar.TabIndex = 10
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Enabled = False
        Me.Modificar.Location = New System.Drawing.Point(91, 97)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(79, 30)
        Me.Modificar.TabIndex = 9
        Me.Modificar.Text = "Modificar"
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
        Me.Agre_Usuarios.Enabled = False
        Me.Agre_Usuarios.Location = New System.Drawing.Point(6, 97)
        Me.Agre_Usuarios.Name = "Agre_Usuarios"
        Me.Agre_Usuarios.Size = New System.Drawing.Size(80, 30)
        Me.Agre_Usuarios.TabIndex = 4
        Me.Agre_Usuarios.Text = "Nuevo"
        Me.Agre_Usuarios.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ventas)
        Me.GroupBox1.Controls.Add(Me.Ultimo)
        Me.GroupBox1.Controls.Add(Me.Siguiente)
        Me.GroupBox1.Controls.Add(Me.Anterior)
        Me.GroupBox1.Controls.Add(Me.Primero)
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
        'Ultimo
        '
        Me.Ultimo.Enabled = False
        Me.Ultimo.Location = New System.Drawing.Point(183, 345)
        Me.Ultimo.Name = "Ultimo"
        Me.Ultimo.Size = New System.Drawing.Size(53, 34)
        Me.Ultimo.TabIndex = 13
        Me.Ultimo.Text = ">>"
        Me.Ultimo.UseVisualStyleBackColor = True
        '
        'Siguiente
        '
        Me.Siguiente.Enabled = False
        Me.Siguiente.Location = New System.Drawing.Point(124, 345)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(53, 34)
        Me.Siguiente.TabIndex = 12
        Me.Siguiente.Text = ">"
        Me.Siguiente.UseVisualStyleBackColor = True
        '
        'Anterior
        '
        Me.Anterior.Enabled = False
        Me.Anterior.Location = New System.Drawing.Point(65, 345)
        Me.Anterior.Name = "Anterior"
        Me.Anterior.Size = New System.Drawing.Size(53, 34)
        Me.Anterior.TabIndex = 11
        Me.Anterior.Text = "<"
        Me.Anterior.UseVisualStyleBackColor = True
        '
        'Primero
        '
        Me.Primero.Enabled = False
        Me.Primero.Location = New System.Drawing.Point(6, 345)
        Me.Primero.Name = "Primero"
        Me.Primero.Size = New System.Drawing.Size(53, 34)
        Me.Primero.TabIndex = 10
        Me.Primero.Text = "<<"
        Me.Primero.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.Admin.Location = New System.Drawing.Point(110, 23)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(210, 26)
        Me.Admin.TabIndex = 9
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
        Me.C_SA.Location = New System.Drawing.Point(145, 52)
        Me.C_SA.MaxLength = 9
        Me.C_SA.Name = "C_SA"
        Me.C_SA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.C_SA.Size = New System.Drawing.Size(175, 26)
        Me.C_SA.TabIndex = 7
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
        Me.Volver.Location = New System.Drawing.Point(6, 388)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(314, 48)
        Me.Volver.TabIndex = 5
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'MSupervisor
        '
        Me.MSupervisor.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSupervisor.Location = New System.Drawing.Point(6, 80)
        Me.MSupervisor.Name = "MSupervisor"
        Me.MSupervisor.Size = New System.Drawing.Size(314, 50)
        Me.MSupervisor.TabIndex = 2
        Me.MSupervisor.Text = "Modo Administrador"
        Me.MSupervisor.UseVisualStyleBackColor = True
        '
        'GrillaUsuarios
        '
        Me.GrillaUsuarios.AllowUserToAddRows = False
        Me.GrillaUsuarios.AllowUserToDeleteRows = False
        Me.GrillaUsuarios.AllowUserToResizeColumns = False
        Me.GrillaUsuarios.AllowUserToResizeRows = False
        Me.GrillaUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.GrillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaUsuarios.Location = New System.Drawing.Point(6, 133)
        Me.GrillaUsuarios.Name = "GrillaUsuarios"
        Me.GrillaUsuarios.Size = New System.Drawing.Size(314, 206)
        Me.GrillaUsuarios.TabIndex = 1
        '
        'Nuevos_Administradores
        '
        Me.Nuevos_Administradores.Enabled = False
        Me.Nuevos_Administradores.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevos_Administradores.Location = New System.Drawing.Point(348, 240)
        Me.Nuevos_Administradores.Name = "Nuevos_Administradores"
        Me.Nuevos_Administradores.Size = New System.Drawing.Size(254, 48)
        Me.Nuevos_Administradores.TabIndex = 14
        Me.Nuevos_Administradores.Text = "Nuevos Administradores"
        Me.Nuevos_Administradores.UseVisualStyleBackColor = True
        '
        'Productos
        '
        Me.Productos.Enabled = False
        Me.Productos.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Productos.Location = New System.Drawing.Point(348, 349)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(254, 48)
        Me.Productos.TabIndex = 19
        Me.Productos.Text = "Productos"
        Me.Productos.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.Ventas.Enabled = False
        Me.Ventas.Location = New System.Drawing.Point(242, 345)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(75, 34)
        Me.Ventas.TabIndex = 14
        Me.Ventas.Text = "Ventas"
        Me.Ventas.UseVisualStyleBackColor = True
        '
        'Usuarios9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(610, 463)
        Me.Controls.Add(Me.Productos)
        Me.Controls.Add(Me.Nuevos_Administradores)
        Me.Controls.Add(Me.P_Exteriores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Cajeros)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Cancelar)
        Me.MaximizeBox = False
        Me.Name = "Usuarios9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios y Productos"
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
    Friend WithEvents Ultimo As System.Windows.Forms.Button
    Friend WithEvents Siguiente As System.Windows.Forms.Button
    Friend WithEvents Anterior As System.Windows.Forms.Button
    Friend WithEvents Primero As System.Windows.Forms.Button
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
End Class
