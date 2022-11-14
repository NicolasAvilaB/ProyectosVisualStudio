<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Busqueda_Clientes = New System.Windows.Forms.Button()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Rut = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Precio = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.Cod_Producto = New System.Windows.Forms.TextBox()
        Me.Cod_Categoria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Nombre_Producto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Busqueda_Productos = New System.Windows.Forms.Button()
        Me.Marca = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.TextBox()
        Me.Categoria = New System.Windows.Forms.ComboBox()
        Me.Agregar_Lista = New System.Windows.Forms.Button()
        Me.Quitar_Lista = New System.Windows.Forms.Button()
        Me.DProd = New System.Windows.Forms.DataGridView()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.can = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Desglose = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Condicion = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Modi = New System.Windows.Forms.Button()
        Me.N_Factura = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Iva = New System.Windows.Forms.TextBox()
        Me.Neto = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.Grabar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Can2 = New System.Windows.Forms.TextBox()
        Me.ca = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Busqueda_Clientes)
        Me.GroupBox1.Controls.Add(Me.Telefono)
        Me.GroupBox1.Controls.Add(Me.Direccion)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Rut)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(648, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(439, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rut"
        '
        'Busqueda_Clientes
        '
        Me.Busqueda_Clientes.Enabled = False
        Me.Busqueda_Clientes.Location = New System.Drawing.Point(14, 84)
        Me.Busqueda_Clientes.Name = "Busqueda_Clientes"
        Me.Busqueda_Clientes.Size = New System.Drawing.Size(816, 27)
        Me.Busqueda_Clientes.TabIndex = 4
        Me.Busqueda_Clientes.Text = "Busqueda Clientes"
        Me.Busqueda_Clientes.UseVisualStyleBackColor = True
        '
        'Telefono
        '
        Me.Telefono.Enabled = False
        Me.Telefono.Location = New System.Drawing.Point(652, 52)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Size = New System.Drawing.Size(178, 26)
        Me.Telefono.TabIndex = 3
        '
        'Direccion
        '
        Me.Direccion.Enabled = False
        Me.Direccion.Location = New System.Drawing.Point(443, 52)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Size = New System.Drawing.Size(203, 26)
        Me.Direccion.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(262, 52)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Size = New System.Drawing.Size(175, 26)
        Me.Nombre.TabIndex = 1
        '
        'Rut
        '
        Me.Rut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Rut.Enabled = False
        Me.Rut.FormattingEnabled = True
        Me.Rut.Location = New System.Drawing.Point(15, 52)
        Me.Rut.Name = "Rut"
        Me.Rut.Size = New System.Drawing.Size(197, 27)
        Me.Rut.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Precio)
        Me.GroupBox2.Controls.Add(Me.Descripcion)
        Me.GroupBox2.Controls.Add(Me.Cod_Producto)
        Me.GroupBox2.Controls.Add(Me.Cod_Categoria)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Nombre_Producto)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Busqueda_Productos)
        Me.GroupBox2.Controls.Add(Me.Marca)
        Me.GroupBox2.Controls.Add(Me.Cantidad)
        Me.GroupBox2.Controls.Add(Me.Categoria)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(850, 201)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Productos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(652, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 19)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Precio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(440, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 19)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Descripcion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(215, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 19)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Codigo Producto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 19)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Codigo Categoria"
        '
        'Precio
        '
        Me.Precio.Enabled = False
        Me.Precio.Location = New System.Drawing.Point(656, 116)
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Size = New System.Drawing.Size(175, 26)
        Me.Precio.TabIndex = 14
        '
        'Descripcion
        '
        Me.Descripcion.Enabled = False
        Me.Descripcion.Location = New System.Drawing.Point(444, 116)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Size = New System.Drawing.Size(203, 26)
        Me.Descripcion.TabIndex = 13
        '
        'Cod_Producto
        '
        Me.Cod_Producto.Enabled = False
        Me.Cod_Producto.Location = New System.Drawing.Point(219, 116)
        Me.Cod_Producto.Name = "Cod_Producto"
        Me.Cod_Producto.ReadOnly = True
        Me.Cod_Producto.Size = New System.Drawing.Size(175, 26)
        Me.Cod_Producto.TabIndex = 12
        '
        'Cod_Categoria
        '
        Me.Cod_Categoria.Enabled = False
        Me.Cod_Categoria.Location = New System.Drawing.Point(15, 116)
        Me.Cod_Categoria.Name = "Cod_Categoria"
        Me.Cod_Categoria.ReadOnly = True
        Me.Cod_Categoria.Size = New System.Drawing.Size(197, 26)
        Me.Cod_Categoria.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(215, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Nombre Producto"
        '
        'Nombre_Producto
        '
        Me.Nombre_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nombre_Producto.Enabled = False
        Me.Nombre_Producto.FormattingEnabled = True
        Me.Nombre_Producto.Location = New System.Drawing.Point(219, 52)
        Me.Nombre_Producto.Name = "Nombre_Producto"
        Me.Nombre_Producto.Size = New System.Drawing.Size(175, 27)
        Me.Nombre_Producto.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(440, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Marca"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(518, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 19)
        Me.Label6.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(652, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 19)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Categoria"
        '
        'Busqueda_Productos
        '
        Me.Busqueda_Productos.Enabled = False
        Me.Busqueda_Productos.Location = New System.Drawing.Point(15, 161)
        Me.Busqueda_Productos.Name = "Busqueda_Productos"
        Me.Busqueda_Productos.Size = New System.Drawing.Size(816, 27)
        Me.Busqueda_Productos.TabIndex = 4
        Me.Busqueda_Productos.Text = "Busqueda Productos"
        Me.Busqueda_Productos.UseVisualStyleBackColor = True
        '
        'Marca
        '
        Me.Marca.Enabled = False
        Me.Marca.Location = New System.Drawing.Point(444, 52)
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Size = New System.Drawing.Size(203, 26)
        Me.Marca.TabIndex = 2
        '
        'Cantidad
        '
        Me.Cantidad.Enabled = False
        Me.Cantidad.Location = New System.Drawing.Point(656, 52)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Size = New System.Drawing.Size(175, 26)
        Me.Cantidad.TabIndex = 1
        '
        'Categoria
        '
        Me.Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Categoria.Enabled = False
        Me.Categoria.FormattingEnabled = True
        Me.Categoria.Location = New System.Drawing.Point(15, 52)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(197, 27)
        Me.Categoria.TabIndex = 0
        '
        'Agregar_Lista
        '
        Me.Agregar_Lista.Enabled = False
        Me.Agregar_Lista.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_Lista.Location = New System.Drawing.Point(384, 339)
        Me.Agregar_Lista.Name = "Agregar_Lista"
        Me.Agregar_Lista.Size = New System.Drawing.Size(148, 26)
        Me.Agregar_Lista.TabIndex = 4
        Me.Agregar_Lista.Text = "Agregar a la Lista"
        Me.Agregar_Lista.UseVisualStyleBackColor = True
        '
        'Quitar_Lista
        '
        Me.Quitar_Lista.Enabled = False
        Me.Quitar_Lista.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitar_Lista.Location = New System.Drawing.Point(665, 339)
        Me.Quitar_Lista.Name = "Quitar_Lista"
        Me.Quitar_Lista.Size = New System.Drawing.Size(197, 26)
        Me.Quitar_Lista.TabIndex = 5
        Me.Quitar_Lista.Text = "Quitar Elemento de la Lista"
        Me.Quitar_Lista.UseVisualStyleBackColor = True
        '
        'DProd
        '
        Me.DProd.AllowUserToAddRows = False
        Me.DProd.AllowUserToDeleteRows = False
        Me.DProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DProd.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod, Me.nom, Me.Column3, Me.can, Me.Column5, Me.Column6, Me.Column7})
        Me.DProd.Enabled = False
        Me.DProd.Location = New System.Drawing.Point(16, 25)
        Me.DProd.Name = "DProd"
        Me.DProd.ReadOnly = True
        Me.DProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DProd.Size = New System.Drawing.Size(815, 116)
        Me.DProd.TabIndex = 6
        '
        'cod
        '
        Me.cod.HeaderText = "Codigo"
        Me.cod.Name = "cod"
        Me.cod.ReadOnly = True
        '
        'nom
        '
        Me.nom.HeaderText = "Nombre"
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'can
        '
        Me.can.HeaderText = "Cantidad"
        Me.can.Name = "can"
        Me.can.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Neto"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Iva"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DProd)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 366)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(850, 160)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Productos"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Desglose)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Condicion)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Modi)
        Me.GroupBox4.Controls.Add(Me.N_Factura)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 534)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(553, 158)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(219, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 33)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(141, 19)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Desglose de Palabras"
        '
        'Desglose
        '
        Me.Desglose.Enabled = False
        Me.Desglose.Location = New System.Drawing.Point(6, 112)
        Me.Desglose.Multiline = True
        Me.Desglose.Name = "Desglose"
        Me.Desglose.ReadOnly = True
        Me.Desglose.Size = New System.Drawing.Size(537, 40)
        Me.Desglose.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(277, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 19)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "--/--/----"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(219, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 19)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Fecha:"
        '
        'Condicion
        '
        Me.Condicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Condicion.Enabled = False
        Me.Condicion.FormattingEnabled = True
        Me.Condicion.Items.AddRange(New Object() {"Aceptacion de Boleta"})
        Me.Condicion.Location = New System.Drawing.Point(375, 48)
        Me.Condicion.Name = "Condicion"
        Me.Condicion.Size = New System.Drawing.Size(168, 27)
        Me.Condicion.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(219, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(156, 19)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Condiciones de Ventas:"
        '
        'Modi
        '
        Me.Modi.Enabled = False
        Me.Modi.Location = New System.Drawing.Point(113, 51)
        Me.Modi.Name = "Modi"
        Me.Modi.Size = New System.Drawing.Size(100, 32)
        Me.Modi.TabIndex = 2
        Me.Modi.Text = "Modificar"
        Me.Modi.UseVisualStyleBackColor = True
        '
        'N_Factura
        '
        Me.N_Factura.Enabled = False
        Me.N_Factura.Location = New System.Drawing.Point(112, 19)
        Me.N_Factura.Name = "N_Factura"
        Me.N_Factura.ReadOnly = True
        Me.N_Factura.Size = New System.Drawing.Size(100, 26)
        Me.N_Factura.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 19)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "N° Factura:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Total)
        Me.GroupBox5.Controls.Add(Me.Iva)
        Me.GroupBox5.Controls.Add(Me.Neto)
        Me.GroupBox5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(571, 534)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(172, 158)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Totales"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 115)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 19)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Total:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 19)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Iva:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 19)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Neto:"
        '
        'Total
        '
        Me.Total.Enabled = False
        Me.Total.Location = New System.Drawing.Point(57, 112)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Size = New System.Drawing.Size(100, 26)
        Me.Total.TabIndex = 2
        '
        'Iva
        '
        Me.Iva.Enabled = False
        Me.Iva.Location = New System.Drawing.Point(58, 65)
        Me.Iva.Name = "Iva"
        Me.Iva.ReadOnly = True
        Me.Iva.Size = New System.Drawing.Size(100, 26)
        Me.Iva.TabIndex = 1
        '
        'Neto
        '
        Me.Neto.Enabled = False
        Me.Neto.Location = New System.Drawing.Point(58, 19)
        Me.Neto.Name = "Neto"
        Me.Neto.ReadOnly = True
        Me.Neto.Size = New System.Drawing.Size(100, 26)
        Me.Neto.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Salir)
        Me.GroupBox6.Controls.Add(Me.Limpiar)
        Me.GroupBox6.Controls.Add(Me.Imprimir)
        Me.GroupBox6.Controls.Add(Me.Grabar)
        Me.GroupBox6.Controls.Add(Me.Cancelar)
        Me.GroupBox6.Controls.Add(Me.Nuevo)
        Me.GroupBox6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(749, 526)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(113, 166)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(6, 141)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(101, 26)
        Me.Salir.TabIndex = 11
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Enabled = False
        Me.Limpiar.Location = New System.Drawing.Point(6, 116)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(101, 26)
        Me.Limpiar.TabIndex = 10
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Imprimir
        '
        Me.Imprimir.Enabled = False
        Me.Imprimir.Location = New System.Drawing.Point(6, 90)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(101, 26)
        Me.Imprimir.TabIndex = 9
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.UseVisualStyleBackColor = True
        '
        'Grabar
        '
        Me.Grabar.Enabled = False
        Me.Grabar.Location = New System.Drawing.Point(6, 64)
        Me.Grabar.Name = "Grabar"
        Me.Grabar.Size = New System.Drawing.Size(101, 26)
        Me.Grabar.TabIndex = 8
        Me.Grabar.Text = "Grabar"
        Me.Grabar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Enabled = False
        Me.Cancelar.Location = New System.Drawing.Point(6, 38)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(101, 26)
        Me.Cancelar.TabIndex = 7
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.Nuevo.Location = New System.Drawing.Point(6, 12)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(101, 26)
        Me.Nuevo.TabIndex = 6
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 343)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(232, 21)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Indicar Cantidad de Productos"
        '
        'Can2
        '
        Me.Can2.Enabled = False
        Me.Can2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Can2.Location = New System.Drawing.Point(251, 342)
        Me.Can2.Name = "Can2"
        Me.Can2.ReadOnly = True
        Me.Can2.Size = New System.Drawing.Size(93, 26)
        Me.Can2.TabIndex = 12
        Me.Can2.Text = "1"
        '
        'ca
        '
        Me.ca.Enabled = False
        Me.ca.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ca.Location = New System.Drawing.Point(548, 341)
        Me.ca.Name = "ca"
        Me.ca.Size = New System.Drawing.Size(92, 27)
        Me.ca.TabIndex = 13
        Me.ca.Text = "Cantidad"
        Me.ca.UseVisualStyleBackColor = True
        '
        'Ventas1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 699)
        Me.Controls.Add(Me.ca)
        Me.Controls.Add(Me.Can2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Quitar_Lista)
        Me.Controls.Add(Me.Agregar_Lista)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ventas1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Busqueda_Clientes As System.Windows.Forms.Button
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Rut As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Busqueda_Productos As System.Windows.Forms.Button
    Friend WithEvents Marca As System.Windows.Forms.TextBox
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Nombre_Producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Precio As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Cod_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Cod_Categoria As System.Windows.Forms.TextBox
    Friend WithEvents Agregar_Lista As System.Windows.Forms.Button
    Friend WithEvents Quitar_Lista As System.Windows.Forms.Button
    Friend WithEvents DProd As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents N_Factura As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Modi As System.Windows.Forms.Button
    Friend WithEvents Condicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Desglose As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Iva As System.Windows.Forms.TextBox
    Friend WithEvents Neto As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Limpiar As System.Windows.Forms.Button
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    Friend WithEvents Grabar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Can2 As System.Windows.Forms.TextBox
    Friend WithEvents cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents can As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ca As System.Windows.Forms.Button
End Class
