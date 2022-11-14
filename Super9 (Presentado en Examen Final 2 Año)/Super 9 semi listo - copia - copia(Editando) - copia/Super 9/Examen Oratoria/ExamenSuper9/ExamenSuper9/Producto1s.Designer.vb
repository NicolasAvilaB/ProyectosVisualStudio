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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto1s))
        Me.GrillaProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Busqueda = New System.Windows.Forms.TextBox()
        Me.AgregaStock = New System.Windows.Forms.Button()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.GrillaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaProductos
        '
        Me.GrillaProductos.AllowUserToAddRows = False
        Me.GrillaProductos.AllowUserToDeleteRows = False
        Me.GrillaProductos.AllowUserToOrderColumns = True
        Me.GrillaProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.GrillaProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GrillaProductos.Location = New System.Drawing.Point(6, 238)
        Me.GrillaProductos.Name = "GrillaProductos"
        Me.GrillaProductos.ReadOnly = True
        Me.GrillaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaProductos.ShowCellToolTips = False
        Me.GrillaProductos.Size = New System.Drawing.Size(840, 305)
        Me.GrillaProductos.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Busqueda)
        Me.GroupBox1.Controls.Add(Me.AgregaStock)
        Me.GroupBox1.Controls.Add(Me.GrillaProductos)
        Me.GroupBox1.Controls.Add(Me.Categoria)
        Me.GroupBox1.Controls.Add(Me.Proveedores)
        Me.GroupBox1.Controls.Add(Me.Guardar)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(853, 549)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personas Exteriores"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Buscar Producto:"
        '
        'Busqueda
        '
        Me.Busqueda.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.Location = New System.Drawing.Point(142, 200)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(295, 26)
        Me.Busqueda.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Busqueda, "Busqueda de Producto que desea Visualizar en la Grilla")
        '
        'AgregaStock
        '
        Me.AgregaStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AgregaStock.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregaStock.Location = New System.Drawing.Point(452, 129)
        Me.AgregaStock.Name = "AgregaStock"
        Me.AgregaStock.Size = New System.Drawing.Size(394, 50)
        Me.AgregaStock.TabIndex = 10
        Me.AgregaStock.Text = "Modificacion o Compra de Stock"
        Me.ToolTip1.SetToolTip(Me.AgregaStock, "Puedes Agregar Nuevo Stock a los Productos Una Vez Que Te Hayas Abastecido")
        Me.AgregaStock.UseVisualStyleBackColor = True
        '
        'Categoria
        '
        Me.Categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Categoria.Enabled = False
        Me.Categoria.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categoria.FormattingEnabled = True
        Me.Categoria.Items.AddRange(New Object() {"Abarrotes", "Aseo", "Gaseosas y Otros", "Coctel", "Confites", "Carnes", "Conservas y Otros", "Higiene", "Lacteos", "Panaderia", "Rotiseria", "Tabaco", "Otros"})
        Me.Categoria.Location = New System.Drawing.Point(110, 164)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(327, 27)
        Me.Categoria.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Categoria, "Seleccione la Categoria Donde Sera Almacenado el Producto")
        '
        'Proveedores
        '
        Me.Proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Proveedores.Enabled = False
        Me.Proveedores.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proveedores.FormattingEnabled = True
        Me.Proveedores.Location = New System.Drawing.Point(113, 129)
        Me.Proveedores.Name = "Proveedores"
        Me.Proveedores.Size = New System.Drawing.Size(324, 27)
        Me.Proveedores.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Proveedores, "Seleccione el Proveedor Que Suministra el Producto")
        '
        'Guardar
        '
        Me.Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar.Enabled = False
        Me.Guardar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(452, 78)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(173, 45)
        Me.Guardar.TabIndex = 8
        Me.Guardar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.Guardar, "Guarde el Producto Nuevo")
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Terminar
        '
        Me.Terminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Terminar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Terminar.Location = New System.Drawing.Point(452, 185)
        Me.Terminar.Name = "Terminar"
        Me.Terminar.Size = New System.Drawing.Size(394, 45)
        Me.Terminar.TabIndex = 11
        Me.Terminar.Text = "Terminar"
        Me.ToolTip1.SetToolTip(Me.Terminar, "Vuelva a la Pantalla Anterior")
        Me.Terminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.Location = New System.Drawing.Point(669, 78)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(178, 45)
        Me.Eliminar.TabIndex = 9
        Me.Eliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.Eliminar, "Elimine un Producto Antiguo")
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modificar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar.Location = New System.Drawing.Point(668, 27)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(178, 43)
        Me.Modificar.TabIndex = 7
        Me.Modificar.Text = "Modificar"
        Me.ToolTip1.SetToolTip(Me.Modificar, "Modifique Producto Existente")
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Nuevo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevo.Location = New System.Drawing.Point(452, 26)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(173, 43)
        Me.Nuevo.TabIndex = 6
        Me.Nuevo.Text = "Nuevo"
        Me.ToolTip1.SetToolTip(Me.Nuevo, "Ingrese Nuevo Producto")
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Categorias :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Proveedores :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codigo :"
        '
        'Precio
        '
        Me.Precio.Enabled = False
        Me.Precio.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.Location = New System.Drawing.Point(80, 95)
        Me.Precio.MaxLength = 9
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(357, 26)
        Me.Precio.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Precio, "Escribe el Precio del Producto")
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(92, 61)
        Me.Nombre.MaxLength = 45
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(345, 26)
        Me.Nombre.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Nombre, "Escribe el Nombre del Producto")
        '
        'Codigo
        '
        Me.Codigo.Enabled = False
        Me.Codigo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.Location = New System.Drawing.Point(80, 27)
        Me.Codigo.MaxLength = 13
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(357, 26)
        Me.Codigo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Codigo, "Escribe un Nuevo Codigo de Producto Aqui")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 564)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(272, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'Producto1s
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(875, 592)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Producto1s"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.GrillaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AgregaStock As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Busqueda As TextBox
End Class
