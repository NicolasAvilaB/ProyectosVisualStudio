<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto1s
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Ultimo = New System.Windows.Forms.Button()
        Me.Siguiente = New System.Windows.Forms.Button()
        Me.Anterior = New System.Windows.Forms.Button()
        Me.Primero = New System.Windows.Forms.Button()
        Me.GrillaProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Categoria = New System.Windows.Forms.ComboBox()
        Me.Proveedores = New System.Windows.Forms.ComboBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Terminar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Precio = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Codigo = New System.Windows.Forms.TextBox()
        CType(Me.GrillaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ultimo
        '
        Me.Ultimo.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ultimo.Location = New System.Drawing.Point(778, 86)
        Me.Ultimo.Name = "Ultimo"
        Me.Ultimo.Size = New System.Drawing.Size(68, 45)
        Me.Ultimo.TabIndex = 23
        Me.Ultimo.Text = ">>"
        Me.Ultimo.UseVisualStyleBackColor = True
        '
        'Siguiente
        '
        Me.Siguiente.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Siguiente.Location = New System.Drawing.Point(679, 86)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(66, 45)
        Me.Siguiente.TabIndex = 22
        Me.Siguiente.Text = ">"
        Me.Siguiente.UseVisualStyleBackColor = True
        '
        'Anterior
        '
        Me.Anterior.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Anterior.Location = New System.Drawing.Point(778, 25)
        Me.Anterior.Name = "Anterior"
        Me.Anterior.Size = New System.Drawing.Size(68, 43)
        Me.Anterior.TabIndex = 21
        Me.Anterior.Text = "<"
        Me.Anterior.UseVisualStyleBackColor = True
        '
        'Primero
        '
        Me.Primero.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Primero.Location = New System.Drawing.Point(679, 25)
        Me.Primero.Name = "Primero"
        Me.Primero.Size = New System.Drawing.Size(66, 43)
        Me.Primero.TabIndex = 20
        Me.Primero.Text = "<<"
        Me.Primero.UseVisualStyleBackColor = True
        '
        'GrillaProductos
        '
        Me.GrillaProductos.AllowUserToAddRows = False
        Me.GrillaProductos.AllowUserToDeleteRows = False
        Me.GrillaProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.GrillaProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaProductos.Location = New System.Drawing.Point(6, 242)
        Me.GrillaProductos.Name = "GrillaProductos"
        Me.GrillaProductos.Size = New System.Drawing.Size(840, 198)
        Me.GrillaProductos.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GrillaProductos)
        Me.GroupBox1.Controls.Add(Me.Ultimo)
        Me.GroupBox1.Controls.Add(Me.Categoria)
        Me.GroupBox1.Controls.Add(Me.Siguiente)
        Me.GroupBox1.Controls.Add(Me.Proveedores)
        Me.GroupBox1.Controls.Add(Me.Anterior)
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.Primero)
        Me.GroupBox1.Controls.Add(Me.Terminar)
        Me.GroupBox1.Controls.Add(Me.Eliminar)
        Me.GroupBox1.Controls.Add(Me.Modificar)
        Me.GroupBox1.Controls.Add(Me.Nuevo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Precio)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Codigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(853, 458)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personas Exteriores"
        '
        'Cantidad
        '
        Me.Cantidad.Enabled = False
        Me.Cantidad.Location = New System.Drawing.Point(146, 200)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(291, 28)
        Me.Cantidad.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 21)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Cantidad Stock :"
        '
        'Categoria
        '
        Me.Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Categoria.Enabled = False
        Me.Categoria.FormattingEnabled = True
        Me.Categoria.Items.AddRange(New Object() {"Abarrotes", "Aseo", "Gaseosas y Otros", "Coctel", "Confites", "Carnes", "Conservas y Otros", "Higiene", "Lacteos", "Panaderia", "Rotiseria", "Tabaco"})
        Me.Categoria.Location = New System.Drawing.Point(110, 164)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(327, 29)
        Me.Categoria.TabIndex = 19
        '
        'Proveedores
        '
        Me.Proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Proveedores.Enabled = False
        Me.Proveedores.FormattingEnabled = True
        Me.Proveedores.Location = New System.Drawing.Point(113, 129)
        Me.Proveedores.Name = "Proveedores"
        Me.Proveedores.Size = New System.Drawing.Size(324, 29)
        Me.Proveedores.TabIndex = 18
        '
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(452, 87)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(89, 45)
        Me.Guardar.TabIndex = 17
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Terminar
        '
        Me.Terminar.Location = New System.Drawing.Point(453, 182)
        Me.Terminar.Name = "Terminar"
        Me.Terminar.Size = New System.Drawing.Size(394, 46)
        Me.Terminar.TabIndex = 16
        Me.Terminar.Text = "Terminar"
        Me.Terminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(568, 86)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(88, 45)
        Me.Eliminar.TabIndex = 15
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(568, 26)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(88, 43)
        Me.Modificar.TabIndex = 14
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.Nuevo.Location = New System.Drawing.Point(452, 26)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(89, 43)
        Me.Nuevo.TabIndex = 13
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Categorias :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Proveedores :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codigo :"
        '
        'Precio
        '
        Me.Precio.Enabled = False
        Me.Precio.Location = New System.Drawing.Point(80, 95)
        Me.Precio.MaxLength = 45
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(357, 28)
        Me.Precio.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(92, 61)
        Me.Nombre.MaxLength = 45
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(345, 28)
        Me.Nombre.TabIndex = 1
        '
        'Codigo
        '
        Me.Codigo.Enabled = False
        Me.Codigo.Location = New System.Drawing.Point(80, 27)
        Me.Codigo.MaxLength = 9
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(357, 28)
        Me.Codigo.TabIndex = 0
        '
        'Producto1s
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(875, 482)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Producto1s"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.GrillaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ultimo As System.Windows.Forms.Button
    Friend WithEvents Siguiente As System.Windows.Forms.Button
    Friend WithEvents Anterior As System.Windows.Forms.Button
    Friend WithEvents Primero As System.Windows.Forms.Button
    Friend WithEvents GrillaProductos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Proveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Terminar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Precio As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
