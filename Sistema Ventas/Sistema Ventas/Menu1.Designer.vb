<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Productos = New System.Windows.Forms.Button()
        Me.Proveedores = New System.Windows.Forms.Button()
        Me.Clientes = New System.Windows.Forms.Button()
        Me.Usuarios = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Buscar_Compras = New System.Windows.Forms.Button()
        Me.Buscar_Ventas = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Compras = New System.Windows.Forms.Button()
        Me.Ventas = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Productos)
        Me.GroupBox1.Controls.Add(Me.Proveedores)
        Me.GroupBox1.Controls.Add(Me.Clientes)
        Me.GroupBox1.Controls.Add(Me.Usuarios)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros Datos"
        '
        'Productos
        '
        Me.Productos.Location = New System.Drawing.Point(83, 146)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(128, 31)
        Me.Productos.TabIndex = 4
        Me.Productos.Text = "Productos"
        Me.Productos.UseVisualStyleBackColor = True
        '
        'Proveedores
        '
        Me.Proveedores.Location = New System.Drawing.Point(24, 109)
        Me.Proveedores.Name = "Proveedores"
        Me.Proveedores.Size = New System.Drawing.Size(128, 31)
        Me.Proveedores.TabIndex = 2
        Me.Proveedores.Text = "Proveedores"
        Me.Proveedores.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.Clientes.Location = New System.Drawing.Point(83, 72)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Size = New System.Drawing.Size(128, 31)
        Me.Clientes.TabIndex = 1
        Me.Clientes.Text = "Clientes"
        Me.Clientes.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.Usuarios.Location = New System.Drawing.Point(24, 35)
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(128, 31)
        Me.Usuarios.TabIndex = 0
        Me.Usuarios.Text = "Usuarios"
        Me.Usuarios.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Buscar_Compras)
        Me.GroupBox2.Controls.Add(Me.Buscar_Ventas)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(304, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 203)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda"
        '
        'Buscar_Compras
        '
        Me.Buscar_Compras.Location = New System.Drawing.Point(42, 109)
        Me.Buscar_Compras.Name = "Buscar_Compras"
        Me.Buscar_Compras.Size = New System.Drawing.Size(128, 31)
        Me.Buscar_Compras.TabIndex = 2
        Me.Buscar_Compras.Text = "Buscar Compras"
        Me.Buscar_Compras.UseVisualStyleBackColor = True
        '
        'Buscar_Ventas
        '
        Me.Buscar_Ventas.Location = New System.Drawing.Point(42, 35)
        Me.Buscar_Ventas.Name = "Buscar_Ventas"
        Me.Buscar_Ventas.Size = New System.Drawing.Size(128, 31)
        Me.Buscar_Ventas.TabIndex = 1
        Me.Buscar_Ventas.Text = "Buscar Ventas"
        Me.Buscar_Ventas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Compras)
        Me.GroupBox3.Controls.Add(Me.Ventas)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(534, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 203)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transacciones"
        '
        'Compras
        '
        Me.Compras.Location = New System.Drawing.Point(43, 109)
        Me.Compras.Name = "Compras"
        Me.Compras.Size = New System.Drawing.Size(128, 31)
        Me.Compras.TabIndex = 4
        Me.Compras.Text = "Compras"
        Me.Compras.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.Ventas.Location = New System.Drawing.Point(43, 35)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(128, 31)
        Me.Ventas.TabIndex = 3
        Me.Ventas.Text = "Ventas"
        Me.Ventas.UseVisualStyleBackColor = True
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 229)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Menu1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Productos As System.Windows.Forms.Button
    Friend WithEvents Proveedores As System.Windows.Forms.Button
    Friend WithEvents Clientes As System.Windows.Forms.Button
    Friend WithEvents Usuarios As System.Windows.Forms.Button
    Friend WithEvents Buscar_Compras As System.Windows.Forms.Button
    Friend WithEvents Buscar_Ventas As System.Windows.Forms.Button
    Friend WithEvents Compras As System.Windows.Forms.Button
    Friend WithEvents Ventas As System.Windows.Forms.Button
End Class
