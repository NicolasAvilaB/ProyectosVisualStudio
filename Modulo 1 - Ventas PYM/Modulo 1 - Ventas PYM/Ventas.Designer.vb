<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.status = New System.Windows.Forms.Panel()
        Me.desglose = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.manual2 = New System.Windows.Forms.NumericUpDown()
        Me.motor2 = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.boton_buscar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.vende_a = New System.Windows.Forms.ComboBox()
        Me.saldo = New System.Windows.Forms.Label()
        Me.costos = New System.Windows.Forms.Label()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.man_rep = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.valor_fact3 = New System.Windows.Forms.TextBox()
        Me.valor_fact2 = New System.Windows.Forms.TextBox()
        Me.valor_fact1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.n_factura3 = New System.Windows.Forms.TextBox()
        Me.n_factura2 = New System.Windows.Forms.TextBox()
        Me.total_instalacion = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.mostrar_grilla = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.traslado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.n_factura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.motor = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.manual = New System.Windows.Forms.NumericUpDown()
        Me.venta_total = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.orden_venta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SumaTotal = New System.Windows.Forms.Timer(Me.components)
        Me.Blabla = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.manual2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.motor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.motor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.manual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.minimizar)
        Me.Panel2.Controls.Add(Me.cerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(910, 33)
        Me.Panel2.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "MODULO 1 - VENTAS PYM"
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizar.ForeColor = System.Drawing.Color.White
        Me.minimizar.Location = New System.Drawing.Point(846, 3)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(27, 27)
        Me.minimizar.TabIndex = 1
        Me.minimizar.Text = "---"
        Me.Blabla.SetToolTip(Me.minimizar, "Minimizar la ventana")
        Me.minimizar.UseVisualStyleBackColor = False
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.Color.White
        Me.cerrar.Location = New System.Drawing.Point(879, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(27, 27)
        Me.cerrar.TabIndex = 0
        Me.cerrar.Text = "X"
        Me.Blabla.SetToolTip(Me.cerrar, "Cerrar la ventana")
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel1.Controls.Add(Me.status)
        Me.Panel1.Controls.Add(Me.desglose)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(4, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 501)
        Me.Panel1.TabIndex = 15
        '
        'status
        '
        Me.status.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.status.BackgroundImage = Global.Modulo_1___Ventas_PYM.My.Resources.Resources._7
        Me.status.Location = New System.Drawing.Point(283, 475)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(316, 21)
        Me.status.TabIndex = 112
        '
        'desglose
        '
        Me.desglose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.desglose.AutoSize = True
        Me.desglose.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.desglose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.desglose.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desglose.ForeColor = System.Drawing.Color.White
        Me.desglose.Location = New System.Drawing.Point(4, 469)
        Me.desglose.Name = "desglose"
        Me.desglose.Size = New System.Drawing.Size(29, 27)
        Me.desglose.TabIndex = 109
        Me.desglose.Text = "..."
        Me.Blabla.SetToolTip(Me.desglose, "Permite un desglose de palabras sobre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "las cantidades en pesos mil o millones de " &
        "pesos")
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.manual2)
        Me.GroupBox1.Controls.Add(Me.motor2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.boton_buscar)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.vende_a)
        Me.GroupBox1.Controls.Add(Me.saldo)
        Me.GroupBox1.Controls.Add(Me.costos)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.man_rep)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.valor_fact3)
        Me.GroupBox1.Controls.Add(Me.valor_fact2)
        Me.GroupBox1.Controls.Add(Me.valor_fact1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.n_factura3)
        Me.GroupBox1.Controls.Add(Me.n_factura2)
        Me.GroupBox1.Controls.Add(Me.total_instalacion)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.mostrar_grilla)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Controls.Add(Me.fecha)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.traslado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.n_factura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.motor)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.manual)
        Me.GroupBox1.Controls.Add(Me.venta_total)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cliente)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.orden_venta)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 427)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NOTA VENTAS"
        '
        'eliminar
        '
        Me.eliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.ForeColor = System.Drawing.Color.White
        Me.eliminar.Location = New System.Drawing.Point(394, 230)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(124, 37)
        Me.eliminar.TabIndex = 3
        Me.eliminar.Text = "ELIMINAR"
        Me.Blabla.SetToolTip(Me.eliminar, "Guarda tu actal venta")
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'manual2
        '
        Me.manual2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manual2.Enabled = False
        Me.manual2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manual2.Location = New System.Drawing.Point(217, 316)
        Me.manual2.Name = "manual2"
        Me.manual2.ReadOnly = True
        Me.manual2.Size = New System.Drawing.Size(159, 29)
        Me.manual2.TabIndex = 13
        Me.manual2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.manual2, "Incremente o disminuya la cantidad de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "persiana manuales al cual se venderan")
        '
        'motor2
        '
        Me.motor2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.motor2.Enabled = False
        Me.motor2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motor2.Location = New System.Drawing.Point(217, 281)
        Me.motor2.Name = "motor2"
        Me.motor2.ReadOnly = True
        Me.motor2.Size = New System.Drawing.Size(159, 29)
        Me.motor2.TabIndex = 12
        Me.motor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.motor2, "Incremente o disminuya la cantidad de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "persiana con motor al cual se venderan")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(11, 318)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(204, 22)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "MANUAL SN INSTALACION.:"
        '
        'boton_buscar
        '
        Me.boton_buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.boton_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.boton_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boton_buscar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_buscar.ForeColor = System.Drawing.Color.White
        Me.boton_buscar.Location = New System.Drawing.Point(394, 163)
        Me.boton_buscar.Name = "boton_buscar"
        Me.boton_buscar.Size = New System.Drawing.Size(124, 38)
        Me.boton_buscar.TabIndex = 2
        Me.boton_buscar.Text = "BUSCAR"
        Me.Blabla.SetToolTip(Me.boton_buscar, "Busque datos por la orden de venta")
        Me.boton_buscar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(11, 284)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(196, 22)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "MOTOR SN INSTALACION.:"
        '
        'vende_a
        '
        Me.vende_a.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vende_a.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.vende_a.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vende_a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vende_a.Enabled = False
        Me.vende_a.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vende_a.ForeColor = System.Drawing.Color.White
        Me.vende_a.FormattingEnabled = True
        Me.vende_a.Location = New System.Drawing.Point(649, 215)
        Me.vende_a.Name = "vende_a"
        Me.vende_a.Size = New System.Drawing.Size(223, 31)
        Me.vende_a.TabIndex = 18
        Me.Blabla.SetToolTip(Me.vende_a, "Seleccione al vendedor para la venta")
        '
        'saldo
        '
        Me.saldo.AutoSize = True
        Me.saldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.saldo.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo.ForeColor = System.Drawing.Color.White
        Me.saldo.Location = New System.Drawing.Point(737, 179)
        Me.saldo.Name = "saldo"
        Me.saldo.Size = New System.Drawing.Size(22, 25)
        Me.saldo.TabIndex = 110
        Me.saldo.Text = "0"
        Me.Blabla.SetToolTip(Me.saldo, "Desglose en palabras la cifra numerica de la ganancia")
        '
        'costos
        '
        Me.costos.AutoSize = True
        Me.costos.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.costos.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costos.ForeColor = System.Drawing.Color.White
        Me.costos.Location = New System.Drawing.Point(737, 144)
        Me.costos.Name = "costos"
        Me.costos.Size = New System.Drawing.Size(22, 25)
        Me.costos.TabIndex = 109
        Me.costos.Text = "0"
        Me.Blabla.SetToolTip(Me.costos, "Desglose en palabras la cifra numerica de costos")
        '
        'nuevo
        '
        Me.nuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.ForeColor = System.Drawing.Color.White
        Me.nuevo.Location = New System.Drawing.Point(394, 32)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(124, 38)
        Me.nuevo.TabIndex = 0
        Me.nuevo.Text = "NUEVO"
        Me.Blabla.SetToolTip(Me.nuevo, "NUEVO: Crea una nueva venta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CANCELAR: Borra o cancela tu transaccion en curso")
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.id.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.White
        Me.id.Location = New System.Drawing.Point(71, 35)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(19, 24)
        Me.id.TabIndex = 106
        Me.id.Text = "0"
        Me.Blabla.SetToolTip(Me.id, "Identificador de la actual venta")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 22)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "ID:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(537, 108)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(89, 22)
        Me.Label29.TabIndex = 102
        Me.Label29.Text = "REP - MAN:"
        '
        'man_rep
        '
        Me.man_rep.Enabled = False
        Me.man_rep.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.man_rep.Location = New System.Drawing.Point(634, 104)
        Me.man_rep.MaxLength = 8
        Me.man_rep.Name = "man_rep"
        Me.man_rep.ReadOnly = True
        Me.man_rep.Size = New System.Drawing.Size(238, 29)
        Me.man_rep.TabIndex = 17
        Me.man_rep.Text = "0"
        Me.man_rep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.man_rep, "Si existe una reparacion o mantenimiento, digite su valor")
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(537, 220)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(107, 22)
        Me.Label28.TabIndex = 100
        Me.Label28.Text = "VENDEDOR/A:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(538, 369)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(93, 22)
        Me.Label27.TabIndex = 99
        Me.Label27.Text = "VALOR N°3:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(538, 293)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 22)
        Me.Label23.TabIndex = 98
        Me.Label23.Text = "VALOR N°2:"
        '
        'valor_fact3
        '
        Me.valor_fact3.Enabled = False
        Me.valor_fact3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor_fact3.Location = New System.Drawing.Point(634, 364)
        Me.valor_fact3.MaxLength = 9
        Me.valor_fact3.Name = "valor_fact3"
        Me.valor_fact3.ReadOnly = True
        Me.valor_fact3.Size = New System.Drawing.Size(238, 29)
        Me.valor_fact3.TabIndex = 22
        Me.valor_fact3.Text = "0"
        Me.valor_fact3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.valor_fact3, "Digite el valor de la tercera factura")
        '
        'valor_fact2
        '
        Me.valor_fact2.Enabled = False
        Me.valor_fact2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor_fact2.Location = New System.Drawing.Point(634, 290)
        Me.valor_fact2.MaxLength = 9
        Me.valor_fact2.Name = "valor_fact2"
        Me.valor_fact2.ReadOnly = True
        Me.valor_fact2.Size = New System.Drawing.Size(238, 29)
        Me.valor_fact2.TabIndex = 20
        Me.valor_fact2.Text = "0"
        Me.valor_fact2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.valor_fact2, "Digite el valor de la segunda factura")
        '
        'valor_fact1
        '
        Me.valor_fact1.Enabled = False
        Me.valor_fact1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor_fact1.Location = New System.Drawing.Point(110, 386)
        Me.valor_fact1.MaxLength = 9
        Me.valor_fact1.Name = "valor_fact1"
        Me.valor_fact1.ReadOnly = True
        Me.valor_fact1.Size = New System.Drawing.Size(266, 29)
        Me.valor_fact1.TabIndex = 15
        Me.valor_fact1.Text = "0"
        Me.valor_fact1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.valor_fact1, "Digite el valor de la primera factura")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 22)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "VALOR N°1:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(538, 333)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 22)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "FACT. N°3:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(538, 259)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 22)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "FACT. N°2:"
        '
        'n_factura3
        '
        Me.n_factura3.Enabled = False
        Me.n_factura3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n_factura3.Location = New System.Drawing.Point(634, 327)
        Me.n_factura3.MaxLength = 8
        Me.n_factura3.Name = "n_factura3"
        Me.n_factura3.ReadOnly = True
        Me.n_factura3.Size = New System.Drawing.Size(238, 29)
        Me.n_factura3.TabIndex = 21
        Me.n_factura3.Text = "0"
        Me.n_factura3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.n_factura3, "Digite el identificador de la tercera factura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'n_factura2
        '
        Me.n_factura2.Enabled = False
        Me.n_factura2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n_factura2.Location = New System.Drawing.Point(634, 254)
        Me.n_factura2.MaxLength = 8
        Me.n_factura2.Name = "n_factura2"
        Me.n_factura2.ReadOnly = True
        Me.n_factura2.Size = New System.Drawing.Size(238, 29)
        Me.n_factura2.TabIndex = 19
        Me.n_factura2.Text = "0"
        Me.n_factura2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.n_factura2, "Digite el identificador de la segunda factura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'total_instalacion
        '
        Me.total_instalacion.AutoSize = True
        Me.total_instalacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.total_instalacion.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_instalacion.ForeColor = System.Drawing.Color.White
        Me.total_instalacion.Location = New System.Drawing.Point(737, 69)
        Me.total_instalacion.Name = "total_instalacion"
        Me.total_instalacion.Size = New System.Drawing.Size(22, 25)
        Me.total_instalacion.TabIndex = 86
        Me.total_instalacion.Text = "0"
        Me.Blabla.SetToolTip(Me.total_instalacion, "El total de instalacion se calculara automaticamente")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(537, 71)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(163, 22)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "TOTAL INSTALACION:"
        '
        'mostrar_grilla
        '
        Me.mostrar_grilla.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.mostrar_grilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.mostrar_grilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mostrar_grilla.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar_grilla.ForeColor = System.Drawing.Color.White
        Me.mostrar_grilla.Location = New System.Drawing.Point(383, 363)
        Me.mostrar_grilla.Name = "mostrar_grilla"
        Me.mostrar_grilla.Size = New System.Drawing.Size(149, 38)
        Me.mostrar_grilla.TabIndex = 5
        Me.mostrar_grilla.Text = "MOSTRAR GRILLA"
        Me.Blabla.SetToolTip(Me.mostrar_grilla, "Muestra en una tabla todas tus ventas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "incluyendo un set de opciones con filtros")
        Me.mostrar_grilla.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.ForeColor = System.Drawing.Color.White
        Me.guardar.Location = New System.Drawing.Point(394, 294)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(124, 37)
        Me.guardar.TabIndex = 4
        Me.guardar.Text = "GUARDAR"
        Me.Blabla.SetToolTip(Me.guardar, "Guarda tu actal venta")
        Me.guardar.UseVisualStyleBackColor = False
        '
        'modificar
        '
        Me.modificar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.ForeColor = System.Drawing.Color.White
        Me.modificar.Location = New System.Drawing.Point(394, 97)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(124, 38)
        Me.modificar.TabIndex = 1
        Me.modificar.Text = "MODIFICAR"
        Me.Blabla.SetToolTip(Me.modificar, "Modifica tus registros de la base de datos")
        Me.modificar.UseVisualStyleBackColor = False
        '
        'fecha
        '
        Me.fecha.CalendarFont = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.fecha.Enabled = False
        Me.fecha.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Bold)
        Me.fecha.Location = New System.Drawing.Point(75, 69)
        Me.fecha.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.fecha.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(301, 27)
        Me.fecha.TabIndex = 6
        Me.fecha.Value = New Date(2018, 1, 1, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(537, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 22)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "GANANCIA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "FECHA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(537, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 22)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "TRASLADO:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(537, 144)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 22)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "COSTOS:"
        '
        'traslado
        '
        Me.traslado.Enabled = False
        Me.traslado.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.traslado.Location = New System.Drawing.Point(634, 32)
        Me.traslado.MaxLength = 8
        Me.traslado.Name = "traslado"
        Me.traslado.ReadOnly = True
        Me.traslado.Size = New System.Drawing.Size(238, 29)
        Me.traslado.TabIndex = 16
        Me.traslado.Text = "0"
        Me.traslado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.traslado, "Digite el valor del traslado")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 22)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "MANUAL CN INSTALACION:"
        '
        'n_factura
        '
        Me.n_factura.Enabled = False
        Me.n_factura.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n_factura.Location = New System.Drawing.Point(110, 351)
        Me.n_factura.MaxLength = 8
        Me.n_factura.Name = "n_factura"
        Me.n_factura.ReadOnly = True
        Me.n_factura.Size = New System.Drawing.Size(266, 29)
        Me.n_factura.TabIndex = 14
        Me.n_factura.Text = "0"
        Me.n_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.n_factura, "Digite el identificador de la primera factura")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 22)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "MOTOR CN INSTALACION:"
        '
        'motor
        '
        Me.motor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.motor.Enabled = False
        Me.motor.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motor.Location = New System.Drawing.Point(217, 211)
        Me.motor.Name = "motor"
        Me.motor.ReadOnly = True
        Me.motor.Size = New System.Drawing.Size(159, 29)
        Me.motor.TabIndex = 10
        Me.motor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.motor, "Incremente o disminuya la cantidad de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "persiana con motor al cual se venderan")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 22)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "FACT. N°1:"
        '
        'manual
        '
        Me.manual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manual.Enabled = False
        Me.manual.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manual.Location = New System.Drawing.Point(217, 246)
        Me.manual.Name = "manual"
        Me.manual.ReadOnly = True
        Me.manual.Size = New System.Drawing.Size(159, 29)
        Me.manual.TabIndex = 11
        Me.manual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.manual, "Incremente o disminuya la cantidad de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "persiana manuales al cual se venderan")
        '
        'venta_total
        '
        Me.venta_total.Enabled = False
        Me.venta_total.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.venta_total.Location = New System.Drawing.Point(132, 175)
        Me.venta_total.MaxLength = 9
        Me.venta_total.Name = "venta_total"
        Me.venta_total.ReadOnly = True
        Me.venta_total.Size = New System.Drawing.Size(244, 29)
        Me.venta_total.TabIndex = 9
        Me.venta_total.Text = "0"
        Me.venta_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.venta_total, "Digite el valor del total de la venta")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 22)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "VENTA TOTAL:"
        '
        'cliente
        '
        Me.cliente.Enabled = False
        Me.cliente.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(96, 103)
        Me.cliente.MaxLength = 45
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Size = New System.Drawing.Size(280, 29)
        Me.cliente.TabIndex = 7
        Me.cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.cliente, "Escriba el cliente")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 22)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "CLIENTE:"
        '
        'orden_venta
        '
        Me.orden_venta.Enabled = False
        Me.orden_venta.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orden_venta.Location = New System.Drawing.Point(135, 139)
        Me.orden_venta.MaxLength = 9
        Me.orden_venta.Name = "orden_venta"
        Me.orden_venta.ReadOnly = True
        Me.orden_venta.Size = New System.Drawing.Size(241, 29)
        Me.orden_venta.TabIndex = 8
        Me.orden_venta.Text = "0"
        Me.orden_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Blabla.SetToolTip(Me.orden_venta, "Digite la orden de la venta actual")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 22)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "ORDEN VENTA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(366, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 29)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "COMERCIAL P Y M"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(281, 537)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(380, 20)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Copyright © 2018 | Diseñado por N.A.B para Comercial PYM"
        '
        'SumaTotal
        '
        '
        'Blabla
        '
        Me.Blabla.AutoPopDelay = 5000
        Me.Blabla.InitialDelay = 100
        Me.Blabla.ReshowDelay = 100
        Me.Blabla.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Blabla.ToolTipTitle = "Mensajes de ayuda"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 561)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.manual2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.motor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.motor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.manual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents minimizar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents traslado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents n_factura As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents motor As NumericUpDown
    Friend WithEvents orden_venta As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents manual As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cliente As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents venta_total As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents guardar As Button
    Friend WithEvents modificar As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents mostrar_grilla As Button
    Friend WithEvents total_instalacion As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents SumaTotal As Timer
    Friend WithEvents n_factura2 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents valor_fact3 As TextBox
    Friend WithEvents valor_fact2 As TextBox
    Friend WithEvents valor_fact1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents n_factura3 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents man_rep As TextBox
    Friend WithEvents id As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nuevo As Button
    Friend WithEvents Blabla As ToolTip
    Friend WithEvents desglose As Label
    Friend WithEvents saldo As Label
    Friend WithEvents costos As Label
    Friend WithEvents status As Panel
    Friend WithEvents vende_a As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents boton_buscar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents manual2 As NumericUpDown
    Friend WithEvents motor2 As NumericUpDown
    Friend WithEvents eliminar As Button
End Class
