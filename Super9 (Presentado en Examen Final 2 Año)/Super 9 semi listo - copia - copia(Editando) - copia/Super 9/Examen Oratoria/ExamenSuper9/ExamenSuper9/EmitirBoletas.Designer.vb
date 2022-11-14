<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmitirBoletas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmitirBoletas))
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
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Abortar_Tarea = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.Button()
        Me.Efectivo = New System.Windows.Forms.Button()
        Me.Descuento = New System.Windows.Forms.Button()
        Me.Volver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Items = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Agregue_Productos = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.F_Productos = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Devuelta = New System.Windows.Forms.Button()
        Me.Otros = New System.Windows.Forms.Button()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NUm = New System.Windows.Forms.TextBox()
        Me.Desc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Total_Pagar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Anular = New System.Windows.Forms.Button()
        Me.Eliminar_Transaccion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Productos_Pasados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Aceptar.Location = New System.Drawing.Point(305, 590)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(139, 36)
        Me.Aceptar.TabIndex = 1
        Me.Aceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.Aceptar, "Pincha Acepta Una Vez Escrito El Codigo Para Comenzar")
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
        Me.N_Boleta.ReadOnly = True
        Me.N_Boleta.Size = New System.Drawing.Size(133, 26)
        Me.N_Boleta.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.N_Boleta, "El Numero de Boleta Cambia Una Vez Hecha La Venta")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'Fecha
        '
        Me.Fecha.Enabled = False
        Me.Fecha.Location = New System.Drawing.Point(450, 22)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Size = New System.Drawing.Size(130, 26)
        Me.Fecha.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Fecha, "Fecha Actual")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Subtotal:"
        '
        'Subtotal
        '
        Me.Subtotal.Enabled = False
        Me.Subtotal.Location = New System.Drawing.Point(80, 18)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Size = New System.Drawing.Size(212, 26)
        Me.Subtotal.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Subtotal, "Te Muestra El Subtotal De Toda la Compra Hecha Hasta el Momento")
        '
        'Productos_Pasados
        '
        Me.Productos_Pasados.AllowUserToAddRows = False
        Me.Productos_Pasados.AllowUserToDeleteRows = False
        Me.Productos_Pasados.AllowUserToResizeRows = False
        Me.Productos_Pasados.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Productos_Pasados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Productos_Pasados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Productos_Pasados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Productos_Pasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Productos_Pasados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.Productos_Pasados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Productos_Pasados.DefaultCellStyle = DataGridViewCellStyle2
        Me.Productos_Pasados.Location = New System.Drawing.Point(7, 54)
        Me.Productos_Pasados.Name = "Productos_Pasados"
        Me.Productos_Pasados.ReadOnly = True
        Me.Productos_Pasados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Productos_Pasados.ShowCellToolTips = False
        Me.Productos_Pasados.Size = New System.Drawing.Size(575, 531)
        Me.Productos_Pasados.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Productos_Pasados, "Vizualizas Las Ventas Realizadas Al Momento")
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 127
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 165
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.MaxInputLength = 100000000
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 110
        '
        'Abortar_Tarea
        '
        Me.Abortar_Tarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Abortar_Tarea.Enabled = False
        Me.Abortar_Tarea.Location = New System.Drawing.Point(12, 378)
        Me.Abortar_Tarea.Name = "Abortar_Tarea"
        Me.Abortar_Tarea.Size = New System.Drawing.Size(110, 31)
        Me.Abortar_Tarea.TabIndex = 4
        Me.Abortar_Tarea.Text = "Abortar Tarea"
        Me.ToolTip1.SetToolTip(Me.Abortar_Tarea, "Puedes Abortar Si Es Que Te Equivocaste o " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si El Cliente Exije Otro Producto a L" &
        "levar")
        Me.Abortar_Tarea.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Total.Location = New System.Drawing.Point(12, 278)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(110, 31)
        Me.Total.TabIndex = 3
        Me.Total.Text = "Total"
        Me.ToolTip1.SetToolTip(Me.Total, "Pulsa Total Una Vez que Estes Seguro de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " La Cantidad de Producto Escaneados o Di" &
        "gitados")
        Me.Total.UseVisualStyleBackColor = True
        '
        'Efectivo
        '
        Me.Efectivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Efectivo.Enabled = False
        Me.Efectivo.Location = New System.Drawing.Point(12, 193)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Size = New System.Drawing.Size(110, 31)
        Me.Efectivo.TabIndex = 2
        Me.Efectivo.Text = "Efectivo"
        Me.ToolTip1.SetToolTip(Me.Efectivo, "Concreta La Venta Pinchando El Siguiente Boton")
        Me.Efectivo.UseVisualStyleBackColor = True
        '
        'Descuento
        '
        Me.Descuento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Descuento.Enabled = False
        Me.Descuento.Location = New System.Drawing.Point(12, 119)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(110, 31)
        Me.Descuento.TabIndex = 1
        Me.Descuento.Text = "Descuento"
        Me.ToolTip1.SetToolTip(Me.Descuento, "Si El Cliente Exije El Descuento, Lo Puedes Realizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Pinchando el Siguiente Bot" &
        "on y Especificando " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "En El Cuadro Para Agregar los Productos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "El Numero de Desc" &
        "uento a Realizar ")
        Me.Descuento.UseVisualStyleBackColor = True
        '
        'Volver
        '
        Me.Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Volver.Location = New System.Drawing.Point(12, 589)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(110, 31)
        Me.Volver.TabIndex = 6
        Me.Volver.Text = "Volver"
        Me.ToolTip1.SetToolTip(Me.Volver, "Puedes Regresar A La Ventana Anterior")
        Me.Volver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Items)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Aceptar)
        Me.GroupBox1.Controls.Add(Me.Cantidad)
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
        Me.GroupBox1.Size = New System.Drawing.Size(592, 664)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'Items
        '
        Me.Items.Enabled = False
        Me.Items.Location = New System.Drawing.Point(336, 22)
        Me.Items.Name = "Items"
        Me.Items.ReadOnly = True
        Me.Items.Size = New System.Drawing.Size(52, 26)
        Me.Items.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(227, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 19)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Cant. de Items:"
        '
        'Cantidad
        '
        Me.Cantidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cantidad.Location = New System.Drawing.Point(450, 590)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(133, 36)
        Me.Cantidad.TabIndex = 2
        Me.Cantidad.Text = "Cantidad"
        Me.ToolTip1.SetToolTip(Me.Cantidad, "Puedes Escribir La Cantidad de Cuantos Productos Venderas")
        Me.Cantidad.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(7, 630)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(575, 26)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.Text = "Ingreso de Productos y/o Cantidad"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Agregue_Productos
        '
        Me.Agregue_Productos.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregue_Productos.Location = New System.Drawing.Point(7, 591)
        Me.Agregue_Productos.MaxLength = 13
        Me.Agregue_Productos.Name = "Agregue_Productos"
        Me.Agregue_Productos.Size = New System.Drawing.Size(292, 34)
        Me.Agregue_Productos.TabIndex = 0
        Me.Agregue_Productos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Agregue_Productos, "Puedes Agregar El Codigo De Algun " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producto Para Comenzar Alguna Venta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O Simple" &
        "mente Digitarlo y Pulsar Enter")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.F_Productos)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(619, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(479, 664)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pagare"
        '
        'F_Productos
        '
        Me.F_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.F_Productos.Location = New System.Drawing.Point(156, 231)
        Me.F_Productos.Name = "F_Productos"
        Me.F_Productos.Size = New System.Drawing.Size(160, 52)
        Me.F_Productos.TabIndex = 0
        Me.F_Productos.Text = "Filtros Productos"
        Me.F_Productos.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Devuelta)
        Me.GroupBox6.Controls.Add(Me.Otros)
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
        Me.GroupBox6.Location = New System.Drawing.Point(7, 284)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(309, 373)
        Me.GroupBox6.TabIndex = 40
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Consulta Precio"
        '
        'Devuelta
        '
        Me.Devuelta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Devuelta.Location = New System.Drawing.Point(10, 321)
        Me.Devuelta.Name = "Devuelta"
        Me.Devuelta.Size = New System.Drawing.Size(292, 48)
        Me.Devuelta.TabIndex = 7
        Me.Devuelta.Text = "Devolver a Stock"
        Me.Devuelta.UseVisualStyleBackColor = True
        '
        'Otros
        '
        Me.Otros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Otros.Location = New System.Drawing.Point(9, 272)
        Me.Otros.Name = "Otros"
        Me.Otros.Size = New System.Drawing.Size(293, 43)
        Me.Otros.TabIndex = 6
        Me.Otros.Text = "Otros Productos"
        Me.Otros.UseVisualStyleBackColor = True
        '
        'Precio
        '
        Me.Precio.Enabled = False
        Me.Precio.Location = New System.Drawing.Point(68, 193)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(234, 26)
        Me.Precio.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Precio, "Especifica El Precio del Producto Consultado")
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
        Me.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cerrar.Enabled = False
        Me.Cerrar.Location = New System.Drawing.Point(9, 225)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(293, 41)
        Me.Cerrar.TabIndex = 5
        Me.Cerrar.Text = "Limpiar"
        Me.ToolTip1.SetToolTip(Me.Cerrar, "Puedes Hacer una Limpieza, Para Realizar una Nueva Consulta")
        Me.Cerrar.UseVisualStyleBackColor = True
        '
        'Consulta1
        '
        Me.Consulta1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consulta1.Location = New System.Drawing.Point(9, 25)
        Me.Consulta1.MaxLength = 13
        Me.Consulta1.Multiline = True
        Me.Consulta1.Name = "Consulta1"
        Me.Consulta1.Size = New System.Drawing.Size(293, 46)
        Me.Consulta1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Consulta1, "Puedes Realizar una Consulta de Precio " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Digitando, Escaneando el Codigo de Barra" &
        " de Algun Producto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o Tambien Presionar la Tecla Enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
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
        Me.Categoria.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Categoria, "Especifica En Que Categoria Corresponde el Producto")
        '
        'Codigo
        '
        Me.Codigo.Enabled = False
        Me.Codigo.Location = New System.Drawing.Point(68, 119)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(234, 26)
        Me.Codigo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Codigo, "Especifica El Codigo Del Producto")
        '
        'Producto
        '
        Me.Producto.Enabled = False
        Me.Producto.Location = New System.Drawing.Point(148, 81)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(154, 26)
        Me.Producto.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Producto, "Especifica el Nombre del Producto Al Cual Consultaste")
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.NUm)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Subtotal)
        Me.GroupBox5.Controls.Add(Me.Desc)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Total_Pagar)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 18)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(299, 138)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Calculos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 19)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Resto:"
        '
        'NUm
        '
        Me.NUm.Enabled = False
        Me.NUm.Location = New System.Drawing.Point(80, 76)
        Me.NUm.Name = "NUm"
        Me.NUm.ReadOnly = True
        Me.NUm.Size = New System.Drawing.Size(212, 26)
        Me.NUm.TabIndex = 34
        Me.NUm.Text = "0"
        '
        'Desc
        '
        Me.Desc.Enabled = False
        Me.Desc.Location = New System.Drawing.Point(80, 47)
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        Me.Desc.Size = New System.Drawing.Size(212, 26)
        Me.Desc.TabIndex = 28
        Me.Desc.Text = "5%"
        Me.Desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Descuento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Total:"
        '
        'Total_Pagar
        '
        Me.Total_Pagar.Enabled = False
        Me.Total_Pagar.Location = New System.Drawing.Point(60, 105)
        Me.Total_Pagar.Name = "Total_Pagar"
        Me.Total_Pagar.ReadOnly = True
        Me.Total_Pagar.Size = New System.Drawing.Size(232, 26)
        Me.Total_Pagar.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.Total_Pagar, "En Caso de Hacer Descuento El Total se Rellenara Con El Calculo Correspondiente")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ExamenSuper9.My.Resources.Resources.índice
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(17, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(134, 121)
        Me.Panel1.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Anular)
        Me.GroupBox3.Controls.Add(Me.Eliminar_Transaccion)
        Me.GroupBox3.Controls.Add(Me.Efectivo)
        Me.GroupBox3.Controls.Add(Me.Volver)
        Me.GroupBox3.Controls.Add(Me.Abortar_Tarea)
        Me.GroupBox3.Controls.Add(Me.Descuento)
        Me.GroupBox3.Controls.Add(Me.Total)
        Me.GroupBox3.Location = New System.Drawing.Point(322, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(138, 635)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Medios de Pago"
        '
        'Anular
        '
        Me.Anular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Anular.Location = New System.Drawing.Point(12, 32)
        Me.Anular.Name = "Anular"
        Me.Anular.Size = New System.Drawing.Size(111, 30)
        Me.Anular.TabIndex = 0
        Me.Anular.Text = "Anular Venta"
        Me.ToolTip1.SetToolTip(Me.Anular, "Puedes Anular Una Venta Selecionando " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "El Producto a Eliminar En La Lista Del Lad" &
        "o Izquierdo")
        Me.Anular.UseVisualStyleBackColor = True
        '
        'Eliminar_Transaccion
        '
        Me.Eliminar_Transaccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar_Transaccion.Location = New System.Drawing.Point(12, 462)
        Me.Eliminar_Transaccion.Name = "Eliminar_Transaccion"
        Me.Eliminar_Transaccion.Size = New System.Drawing.Size(110, 54)
        Me.Eliminar_Transaccion.TabIndex = 5
        Me.Eliminar_Transaccion.Text = "Eliminar Transaccion"
        Me.ToolTip1.SetToolTip(Me.Eliminar_Transaccion, "Elimina o Vacia la Lista Donde " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pasaste Todos Los Productos")
        Me.Eliminar_Transaccion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(497, 669)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'Timer1
        '
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje"
        '
        'Timer2
        '
        '
        'EmitirBoletas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1110, 697)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents Abortar_Tarea As System.Windows.Forms.Button
    Friend WithEvents Total As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Efectivo As System.Windows.Forms.Button
    Friend WithEvents Descuento As System.Windows.Forms.Button
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Total_Pagar As System.Windows.Forms.TextBox
    Friend WithEvents Desc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Eliminar_Transaccion As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Agregue_Productos As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Anular As System.Windows.Forms.Button
    Friend WithEvents Otros As System.Windows.Forms.Button
    Friend WithEvents Cantidad As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Items As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Devuelta As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NUm As System.Windows.Forms.TextBox
    Friend WithEvents F_Productos As Button
End Class
