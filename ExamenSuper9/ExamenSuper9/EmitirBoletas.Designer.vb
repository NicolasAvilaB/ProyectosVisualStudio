<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmitirBoletas
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
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.N_Boleta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Subtotal = New System.Windows.Forms.TextBox()
        Me.Productos_Pasados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anular = New System.Windows.Forms.Button()
        Me.Abortar_Tarea = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Efectivo = New System.Windows.Forms.Button()
        Me.Descuento = New System.Windows.Forms.Button()
        Me.Volver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Agregue_Productos = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Consulte = New System.Windows.Forms.Button()
        Me.Precio = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.Consulta1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Categoria = New System.Windows.Forms.TextBox()
        Me.Codigo = New System.Windows.Forms.TextBox()
        Me.Producto = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Saldo_Faltante = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Desc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Total_Pagado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Total_Pagar = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Tabaco = New System.Windows.Forms.ComboBox()
        Me.Higiene = New System.Windows.Forms.ComboBox()
        Me.Coctel = New System.Windows.Forms.ComboBox()
        Me.Conservas = New System.Windows.Forms.ComboBox()
        Me.Panaderia = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Confites = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Rotiseria = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Aseo = New System.Windows.Forms.ComboBox()
        Me.Be_otros = New System.Windows.Forms.ComboBox()
        Me.Abarrotes = New System.Windows.Forms.ComboBox()
        Me.Carnes = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Lacteos = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Eliminar_Transaccion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.hora = New System.Windows.Forms.TextBox()
        CType(Me.Productos_Pasados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(12, 43)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(110, 30)
        Me.Aceptar.TabIndex = 0
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "N° Boleta:"
        '
        'N_Boleta
        '
        Me.N_Boleta.Enabled = False
        Me.N_Boleta.Location = New System.Drawing.Point(88, 22)
        Me.N_Boleta.Name = "N_Boleta"
        Me.N_Boleta.Size = New System.Drawing.Size(133, 26)
        Me.N_Boleta.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'Fecha
        '
        Me.Fecha.Enabled = False
        Me.Fecha.Location = New System.Drawing.Point(325, 22)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(135, 26)
        Me.Fecha.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Subtotal:"
        '
        'Subtotal
        '
        Me.Subtotal.Enabled = False
        Me.Subtotal.Location = New System.Drawing.Point(80, 19)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Size = New System.Drawing.Size(215, 26)
        Me.Subtotal.TabIndex = 6
        '
        'Productos_Pasados
        '
        Me.Productos_Pasados.AllowUserToAddRows = False
        Me.Productos_Pasados.AllowUserToDeleteRows = False
        Me.Productos_Pasados.AllowUserToResizeColumns = False
        Me.Productos_Pasados.AllowUserToResizeRows = False
        Me.Productos_Pasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Productos_Pasados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Productos_Pasados.Location = New System.Drawing.Point(7, 54)
        Me.Productos_Pasados.Name = "Productos_Pasados"
        Me.Productos_Pasados.Size = New System.Drawing.Size(453, 431)
        Me.Productos_Pasados.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 160
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 130
        '
        'Anular
        '
        Me.Anular.Location = New System.Drawing.Point(12, 97)
        Me.Anular.Name = "Anular"
        Me.Anular.Size = New System.Drawing.Size(110, 30)
        Me.Anular.TabIndex = 10
        Me.Anular.Text = "Anular Venta"
        Me.Anular.UseVisualStyleBackColor = True
        '
        'Abortar_Tarea
        '
        Me.Abortar_Tarea.Enabled = False
        Me.Abortar_Tarea.Location = New System.Drawing.Point(12, 366)
        Me.Abortar_Tarea.Name = "Abortar_Tarea"
        Me.Abortar_Tarea.Size = New System.Drawing.Size(110, 31)
        Me.Abortar_Tarea.TabIndex = 11
        Me.Abortar_Tarea.Text = "Abortar Tarea"
        Me.Abortar_Tarea.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(12, 311)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(110, 31)
        Me.Total.TabIndex = 14
        Me.Total.Text = "Total"
        Me.Total.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(10, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 92)
        Me.Panel1.TabIndex = 15
        '
        'Efectivo
        '
        Me.Efectivo.Enabled = False
        Me.Efectivo.Location = New System.Drawing.Point(12, 254)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Size = New System.Drawing.Size(110, 31)
        Me.Efectivo.TabIndex = 24
        Me.Efectivo.Text = "Efectivo"
        Me.Efectivo.UseVisualStyleBackColor = True
        '
        'Descuento
        '
        Me.Descuento.Enabled = False
        Me.Descuento.Location = New System.Drawing.Point(12, 189)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(110, 31)
        Me.Descuento.TabIndex = 28
        Me.Descuento.Text = "Descuento"
        Me.Descuento.UseVisualStyleBackColor = True
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(13, 485)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(110, 31)
        Me.Volver.TabIndex = 29
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Agregue_Productos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.N_Boleta)
        Me.GroupBox1.Controls.Add(Me.Fecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Productos_Pasados)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 563)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(7, 529)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(453, 26)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.Text = "Ingreso de Productos"
        '
        'Agregue_Productos
        '
        Me.Agregue_Productos.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregue_Productos.Location = New System.Drawing.Point(7, 492)
        Me.Agregue_Productos.MaxLength = 9
        Me.Agregue_Productos.Name = "Agregue_Productos"
        Me.Agregue_Productos.Size = New System.Drawing.Size(453, 34)
        Me.Agregue_Productos.TabIndex = 31
        Me.Agregue_Productos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(484, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(791, 563)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pagare"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Consulte)
        Me.GroupBox6.Controls.Add(Me.Precio)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.Cerrar)
        Me.GroupBox6.Controls.Add(Me.Consulta1)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Categoria)
        Me.GroupBox6.Controls.Add(Me.Codigo)
        Me.GroupBox6.Controls.Add(Me.Producto)
        Me.GroupBox6.Location = New System.Drawing.Point(333, 25)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(308, 280)
        Me.GroupBox6.TabIndex = 40
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Consulta Precio"
        '
        'Consulte
        '
        Me.Consulte.Location = New System.Drawing.Point(9, 236)
        Me.Consulte.Name = "Consulte"
        Me.Consulte.Size = New System.Drawing.Size(103, 34)
        Me.Consulte.TabIndex = 19
        Me.Consulte.Text = "Consulte"
        Me.Consulte.UseVisualStyleBackColor = True
        '
        'Precio
        '
        Me.Precio.Enabled = False
        Me.Precio.Location = New System.Drawing.Point(68, 193)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(234, 26)
        Me.Precio.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(9, 197)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 19)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Precio"
        '
        'Cerrar
        '
        Me.Cerrar.Location = New System.Drawing.Point(118, 236)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(184, 34)
        Me.Cerrar.TabIndex = 16
        Me.Cerrar.Text = "Limpiar"
        Me.Cerrar.UseVisualStyleBackColor = True
        '
        'Consulta1
        '
        Me.Consulta1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consulta1.Location = New System.Drawing.Point(9, 25)
        Me.Consulta1.Multiline = True
        Me.Consulta1.Name = "Consulta1"
        Me.Consulta1.Size = New System.Drawing.Size(293, 46)
        Me.Consulta1.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 160)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 19)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Categoria"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 19)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Codigo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 82)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 19)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Nombre Producto"
        '
        'Categoria
        '
        Me.Categoria.Enabled = False
        Me.Categoria.Location = New System.Drawing.Point(89, 156)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(213, 26)
        Me.Categoria.TabIndex = 10
        '
        'Codigo
        '
        Me.Codigo.Enabled = False
        Me.Codigo.Location = New System.Drawing.Point(68, 119)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(234, 26)
        Me.Codigo.TabIndex = 9
        '
        'Producto
        '
        Me.Producto.Enabled = False
        Me.Producto.Location = New System.Drawing.Point(148, 81)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(154, 26)
        Me.Producto.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Subtotal)
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Controls.Add(Me.Saldo_Faltante)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Desc)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Total_Pagado)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Total_Pagar)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 22)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(301, 273)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Calculos"
        '
        'Saldo_Faltante
        '
        Me.Saldo_Faltante.Enabled = False
        Me.Saldo_Faltante.Location = New System.Drawing.Point(112, 241)
        Me.Saldo_Faltante.Name = "Saldo_Faltante"
        Me.Saldo_Faltante.Size = New System.Drawing.Size(183, 26)
        Me.Saldo_Faltante.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 19)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Saldo Faltante"
        '
        'Desc
        '
        Me.Desc.Enabled = False
        Me.Desc.Location = New System.Drawing.Point(109, 148)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(186, 26)
        Me.Desc.TabIndex = 28
        Me.Desc.Text = "                          5% "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Total Pagado"
        '
        'Total_Pagado
        '
        Me.Total_Pagado.Enabled = False
        Me.Total_Pagado.Location = New System.Drawing.Point(103, 209)
        Me.Total_Pagado.Name = "Total_Pagado"
        Me.Total_Pagado.Size = New System.Drawing.Size(192, 26)
        Me.Total_Pagado.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Descuento "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Total a Pagar"
        '
        'Total_Pagar
        '
        Me.Total_Pagar.Enabled = False
        Me.Total_Pagar.Location = New System.Drawing.Point(103, 180)
        Me.Total_Pagar.Name = "Total_Pagar"
        Me.Total_Pagar.Size = New System.Drawing.Size(192, 26)
        Me.Total_Pagar.TabIndex = 29
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.hora)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Tabaco)
        Me.GroupBox4.Controls.Add(Me.Higiene)
        Me.GroupBox4.Controls.Add(Me.Coctel)
        Me.GroupBox4.Controls.Add(Me.Conservas)
        Me.GroupBox4.Controls.Add(Me.Panaderia)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Confites)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Rotiseria)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Aseo)
        Me.GroupBox4.Controls.Add(Me.Be_otros)
        Me.GroupBox4.Controls.Add(Me.Abarrotes)
        Me.GroupBox4.Controls.Add(Me.Carnes)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Lacteos)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 301)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(628, 254)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtro"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(360, 160)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(54, 19)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "Tabaco"
        '
        'Tabaco
        '
        Me.Tabaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tabaco.FormattingEnabled = True
        Me.Tabaco.Location = New System.Drawing.Point(424, 157)
        Me.Tabaco.Name = "Tabaco"
        Me.Tabaco.Size = New System.Drawing.Size(198, 27)
        Me.Tabaco.TabIndex = 57
        '
        'Higiene
        '
        Me.Higiene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Higiene.FormattingEnabled = True
        Me.Higiene.Location = New System.Drawing.Point(424, 124)
        Me.Higiene.Name = "Higiene"
        Me.Higiene.Size = New System.Drawing.Size(198, 27)
        Me.Higiene.TabIndex = 56
        '
        'Coctel
        '
        Me.Coctel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Coctel.FormattingEnabled = True
        Me.Coctel.Location = New System.Drawing.Point(417, 91)
        Me.Coctel.Name = "Coctel"
        Me.Coctel.Size = New System.Drawing.Size(205, 27)
        Me.Coctel.TabIndex = 55
        '
        'Conservas
        '
        Me.Conservas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Conservas.FormattingEnabled = True
        Me.Conservas.Location = New System.Drawing.Point(468, 58)
        Me.Conservas.Name = "Conservas"
        Me.Conservas.Size = New System.Drawing.Size(154, 27)
        Me.Conservas.TabIndex = 54
        '
        'Panaderia
        '
        Me.Panaderia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Panaderia.FormattingEnabled = True
        Me.Panaderia.Location = New System.Drawing.Point(438, 25)
        Me.Panaderia.Name = "Panaderia"
        Me.Panaderia.Size = New System.Drawing.Size(184, 27)
        Me.Panaderia.TabIndex = 53
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(363, 127)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 19)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "Higiene"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(363, 94)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 19)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "Coctel"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(363, 61)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 19)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "Conservas, Etc"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(363, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 19)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Panaderia"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 226)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 19)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Confites"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 225)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 19)
        Me.Label17.TabIndex = 47
        '
        'Confites
        '
        Me.Confites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Confites.FormattingEnabled = True
        Me.Confites.Location = New System.Drawing.Point(76, 222)
        Me.Confites.Name = "Confites"
        Me.Confites.Size = New System.Drawing.Size(206, 27)
        Me.Confites.TabIndex = 46
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 193)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 19)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Rotiseria"
        '
        'Rotiseria
        '
        Me.Rotiseria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Rotiseria.FormattingEnabled = True
        Me.Rotiseria.Location = New System.Drawing.Point(76, 190)
        Me.Rotiseria.Name = "Rotiseria"
        Me.Rotiseria.Size = New System.Drawing.Size(206, 27)
        Me.Rotiseria.TabIndex = 44
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 19)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Aseo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 19)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Bebidas y Otros"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 19)
        Me.Label13.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 19)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Abarrotes"
        '
        'Aseo
        '
        Me.Aseo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Aseo.FormattingEnabled = True
        Me.Aseo.Location = New System.Drawing.Point(51, 157)
        Me.Aseo.Name = "Aseo"
        Me.Aseo.Size = New System.Drawing.Size(206, 27)
        Me.Aseo.TabIndex = 39
        '
        'Be_otros
        '
        Me.Be_otros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Be_otros.FormattingEnabled = True
        Me.Be_otros.Location = New System.Drawing.Point(123, 124)
        Me.Be_otros.Name = "Be_otros"
        Me.Be_otros.Size = New System.Drawing.Size(206, 27)
        Me.Be_otros.TabIndex = 39
        '
        'Abarrotes
        '
        Me.Abarrotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Abarrotes.FormattingEnabled = True
        Me.Abarrotes.Location = New System.Drawing.Point(84, 91)
        Me.Abarrotes.Name = "Abarrotes"
        Me.Abarrotes.Size = New System.Drawing.Size(206, 27)
        Me.Abarrotes.TabIndex = 5
        '
        'Carnes
        '
        Me.Carnes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Carnes.FormattingEnabled = True
        Me.Carnes.Location = New System.Drawing.Point(68, 58)
        Me.Carnes.Name = "Carnes"
        Me.Carnes.Size = New System.Drawing.Size(206, 27)
        Me.Carnes.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 19)
        Me.Label11.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Carnes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Lacteos"
        '
        'Lacteos
        '
        Me.Lacteos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Lacteos.FormattingEnabled = True
        Me.Lacteos.Location = New System.Drawing.Point(68, 25)
        Me.Lacteos.Name = "Lacteos"
        Me.Lacteos.Size = New System.Drawing.Size(206, 27)
        Me.Lacteos.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Eliminar_Transaccion)
        Me.GroupBox3.Controls.Add(Me.Anular)
        Me.GroupBox3.Controls.Add(Me.Aceptar)
        Me.GroupBox3.Controls.Add(Me.Efectivo)
        Me.GroupBox3.Controls.Add(Me.Volver)
        Me.GroupBox3.Controls.Add(Me.Abortar_Tarea)
        Me.GroupBox3.Controls.Add(Me.Descuento)
        Me.GroupBox3.Controls.Add(Me.Total)
        Me.GroupBox3.Location = New System.Drawing.Point(647, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(138, 545)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Medios de Pago"
        '
        'Eliminar_Transaccion
        '
        Me.Eliminar_Transaccion.Location = New System.Drawing.Point(14, 414)
        Me.Eliminar_Transaccion.Name = "Eliminar_Transaccion"
        Me.Eliminar_Transaccion.Size = New System.Drawing.Size(109, 54)
        Me.Eliminar_Transaccion.TabIndex = 36
        Me.Eliminar_Transaccion.Text = "Eliminar Transaccion"
        Me.Eliminar_Transaccion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(480, 574)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'Timer1
        '
        '
        'hora
        '
        Me.hora.Enabled = False
        Me.hora.Location = New System.Drawing.Point(476, 222)
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(146, 26)
        Me.hora.TabIndex = 34
        Me.hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmitirBoletas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1285, 597)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "EmitirBoletas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas Supermercado El 9"
        CType(Me.Productos_Pasados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents N_Boleta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Subtotal As System.Windows.Forms.TextBox
    Friend WithEvents Productos_Pasados As System.Windows.Forms.DataGridView
    Friend WithEvents Anular As System.Windows.Forms.Button
    Friend WithEvents Abortar_Tarea As System.Windows.Forms.Button
    Friend WithEvents Total As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Efectivo As System.Windows.Forms.Button
    Friend WithEvents Descuento As System.Windows.Forms.Button
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Saldo_Faltante As System.Windows.Forms.TextBox
    Friend WithEvents Total_Pagado As System.Windows.Forms.TextBox
    Friend WithEvents Total_Pagar As System.Windows.Forms.TextBox
    Friend WithEvents Desc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Eliminar_Transaccion As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Aseo As System.Windows.Forms.ComboBox
    Friend WithEvents Be_otros As System.Windows.Forms.ComboBox
    Friend WithEvents Abarrotes As System.Windows.Forms.ComboBox
    Friend WithEvents Carnes As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Lacteos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Confites As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Rotiseria As System.Windows.Forms.ComboBox
    Friend WithEvents Categoria As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Consulta1 As System.Windows.Forms.TextBox
    Friend WithEvents Cerrar As System.Windows.Forms.Button
    Friend WithEvents Precio As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Higiene As System.Windows.Forms.ComboBox
    Friend WithEvents Coctel As System.Windows.Forms.ComboBox
    Friend WithEvents Conservas As System.Windows.Forms.ComboBox
    Friend WithEvents Panaderia As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Consulte As System.Windows.Forms.Button
    Friend WithEvents Agregue_Productos As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Tabaco As System.Windows.Forms.ComboBox
    Friend WithEvents hora As System.Windows.Forms.TextBox
End Class
