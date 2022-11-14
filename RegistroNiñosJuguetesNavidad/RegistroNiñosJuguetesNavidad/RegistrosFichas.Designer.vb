<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrosFichas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrosFichas))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.filtrojuntas = New System.Windows.Forms.ComboBox()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.listaestado = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.sexo = New System.Windows.Forms.ComboBox()
        Me.edad = New System.Windows.Forms.NumericUpDown()
        Me.rut = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.familia = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.sector = New System.Windows.Forms.TextBox()
        Me.juntas = New System.Windows.Forms.TextBox()
        Me.unidad = New System.Windows.Forms.TextBox()
        Me.numeroficha = New System.Windows.Forms.TextBox()
        Me.busqueda = New System.Windows.Forms.TextBox()
        Me.numero = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.historial_transaccion = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Grilla_Fichas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SumaRegistros = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.edad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grilla_Fichas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1210, 33)
        Me.Panel2.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "MUNICIPALIDAD DE PERALILLO"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.DarkGreen
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1146, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 27)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "---"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.DarkGreen
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1179, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.filtrojuntas)
        Me.GroupBox1.Controls.Add(Me.imprimir)
        Me.GroupBox1.Controls.Add(Me.listaestado)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.sexo)
        Me.GroupBox1.Controls.Add(Me.edad)
        Me.GroupBox1.Controls.Add(Me.rut)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.familia)
        Me.GroupBox1.Controls.Add(Me.direccion)
        Me.GroupBox1.Controls.Add(Me.sector)
        Me.GroupBox1.Controls.Add(Me.juntas)
        Me.GroupBox1.Controls.Add(Me.unidad)
        Me.GroupBox1.Controls.Add(Me.numeroficha)
        Me.GroupBox1.Controls.Add(Me.busqueda)
        Me.GroupBox1.Controls.Add(Me.numero)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.historial_transaccion)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Grilla_Fichas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1202, 528)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros Fichas"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(1062, 452)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 42)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "VACIAR FILTRO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(574, 464)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(185, 22)
        Me.Label19.TabIndex = 66
        Me.Label19.Text = "Filtro de Juntas de Vecinos:"
        '
        'filtrojuntas
        '
        Me.filtrojuntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filtrojuntas.FormattingEnabled = True
        Me.filtrojuntas.Location = New System.Drawing.Point(765, 461)
        Me.filtrojuntas.MaxLength = 45
        Me.filtrojuntas.Name = "filtrojuntas"
        Me.filtrojuntas.Size = New System.Drawing.Size(291, 28)
        Me.filtrojuntas.TabIndex = 65
        '
        'imprimir
        '
        Me.imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imprimir.Location = New System.Drawing.Point(6, 453)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(562, 42)
        Me.imprimir.TabIndex = 64
        Me.imprimir.Text = "Imprimir Reporte"
        Me.imprimir.UseVisualStyleBackColor = False
        '
        'listaestado
        '
        Me.listaestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listaestado.Enabled = False
        Me.listaestado.FormattingEnabled = True
        Me.listaestado.Items.AddRange(New Object() {"---Vacio---", "Embarazada", "Capacidad Diferente"})
        Me.listaestado.Location = New System.Drawing.Point(971, 174)
        Me.listaestado.MaxLength = 45
        Me.listaestado.Name = "listaestado"
        Me.listaestado.Size = New System.Drawing.Size(223, 28)
        Me.listaestado.TabIndex = 63
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(907, 177)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 22)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Estado:"
        '
        'sexo
        '
        Me.sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexo.Enabled = False
        Me.sexo.FormattingEnabled = True
        Me.sexo.Items.AddRange(New Object() {"♂ Masculino", "♀ Femenino"})
        Me.sexo.Location = New System.Drawing.Point(762, 213)
        Me.sexo.MaxLength = 45
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(432, 28)
        Me.sexo.TabIndex = 61
        '
        'edad
        '
        Me.edad.Enabled = False
        Me.edad.Location = New System.Drawing.Point(762, 175)
        Me.edad.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        Me.edad.Size = New System.Drawing.Size(139, 26)
        Me.edad.TabIndex = 60
        Me.edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rut
        '
        Me.rut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rut.Enabled = False
        Me.rut.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rut.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rut.Location = New System.Drawing.Point(751, 135)
        Me.rut.MaxLength = 13
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        Me.rut.Size = New System.Drawing.Size(443, 25)
        Me.rut.TabIndex = 57
        '
        'nombre
        '
        Me.nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nombre.Enabled = False
        Me.nombre.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nombre.Location = New System.Drawing.Point(823, 96)
        Me.nombre.MaxLength = 100
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(371, 25)
        Me.nombre.TabIndex = 56
        '
        'familia
        '
        Me.familia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.familia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.familia.Enabled = False
        Me.familia.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.familia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.familia.Location = New System.Drawing.Point(773, 57)
        Me.familia.MaxLength = 100
        Me.familia.Name = "familia"
        Me.familia.ReadOnly = True
        Me.familia.Size = New System.Drawing.Size(421, 25)
        Me.familia.TabIndex = 55
        '
        'direccion
        '
        Me.direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.direccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.direccion.Enabled = False
        Me.direccion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.direccion.Location = New System.Drawing.Point(789, 19)
        Me.direccion.MaxLength = 300
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Size = New System.Drawing.Size(405, 25)
        Me.direccion.TabIndex = 54
        '
        'sector
        '
        Me.sector.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sector.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sector.Enabled = False
        Me.sector.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sector.ForeColor = System.Drawing.SystemColors.WindowText
        Me.sector.Location = New System.Drawing.Point(238, 213)
        Me.sector.MaxLength = 45
        Me.sector.Name = "sector"
        Me.sector.ReadOnly = True
        Me.sector.Size = New System.Drawing.Size(446, 25)
        Me.sector.TabIndex = 53
        '
        'juntas
        '
        Me.juntas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.juntas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.juntas.Enabled = False
        Me.juntas.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.juntas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.juntas.Location = New System.Drawing.Point(407, 174)
        Me.juntas.MaxLength = 300
        Me.juntas.Name = "juntas"
        Me.juntas.ReadOnly = True
        Me.juntas.Size = New System.Drawing.Size(277, 25)
        Me.juntas.TabIndex = 52
        '
        'unidad
        '
        Me.unidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.unidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.unidad.Enabled = False
        Me.unidad.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unidad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.unidad.Location = New System.Drawing.Point(292, 135)
        Me.unidad.MaxLength = 300
        Me.unidad.Name = "unidad"
        Me.unidad.ReadOnly = True
        Me.unidad.Size = New System.Drawing.Size(392, 25)
        Me.unidad.TabIndex = 51
        '
        'numeroficha
        '
        Me.numeroficha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numeroficha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numeroficha.Enabled = False
        Me.numeroficha.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeroficha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.numeroficha.Location = New System.Drawing.Point(283, 96)
        Me.numeroficha.MaxLength = 18
        Me.numeroficha.Name = "numeroficha"
        Me.numeroficha.ReadOnly = True
        Me.numeroficha.Size = New System.Drawing.Size(401, 25)
        Me.numeroficha.TabIndex = 50
        '
        'busqueda
        '
        Me.busqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.busqueda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.busqueda.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busqueda.ForeColor = System.Drawing.SystemColors.WindowText
        Me.busqueda.Location = New System.Drawing.Point(348, 497)
        Me.busqueda.MaxLength = 45
        Me.busqueda.Name = "busqueda"
        Me.busqueda.Size = New System.Drawing.Size(419, 25)
        Me.busqueda.TabIndex = 49
        '
        'numero
        '
        Me.numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numero.Enabled = False
        Me.numero.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.numero.Location = New System.Drawing.Point(1017, 497)
        Me.numero.MaxLength = 45
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Size = New System.Drawing.Size(179, 25)
        Me.numero.TabIndex = 48
        Me.numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(773, 499)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(239, 22)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Total Niños/as Registrados en Grilla:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 499)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(336, 22)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Buscar Nombre Niño/a, Familia o Juntas de Vecino :"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.id.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(211, 60)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(2, 22)
        Me.id.TabIndex = 45
        '
        'historial_transaccion
        '
        Me.historial_transaccion.BackColor = System.Drawing.SystemColors.Control
        Me.historial_transaccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.historial_transaccion.Location = New System.Drawing.Point(1032, 244)
        Me.historial_transaccion.Name = "historial_transaccion"
        Me.historial_transaccion.Size = New System.Drawing.Size(165, 42)
        Me.historial_transaccion.TabIndex = 44
        Me.historial_transaccion.Text = "Historial Transacciones"
        Me.historial_transaccion.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Enabled = False
        Me.cancelar.Location = New System.Drawing.Point(861, 244)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(165, 42)
        Me.cancelar.TabIndex = 43
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.SystemColors.Control
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Location = New System.Drawing.Point(690, 244)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(165, 42)
        Me.guardar.TabIndex = 42
        Me.guardar.Text = "Guardar"
        Me.guardar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.Location = New System.Drawing.Point(519, 244)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(165, 42)
        Me.eliminar.TabIndex = 41
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.SystemColors.Control
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Location = New System.Drawing.Point(348, 244)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(165, 42)
        Me.modificar.TabIndex = 40
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Location = New System.Drawing.Point(177, 244)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(165, 42)
        Me.nuevo.TabIndex = 39
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(709, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 22)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Sexo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(709, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 22)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Edad:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(709, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 22)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Rut:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(709, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 22)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Nombre Niño/a:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(709, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 22)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Familia:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(709, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 22)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Direccion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(177, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 22)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Sector:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(177, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 22)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Juntas de Vecinos u Org. Comun.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(177, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 22)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Unidad Vecinal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(177, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 22)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Numero Ficha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 22)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "ID:"
        '
        'Grilla_Fichas
        '
        Me.Grilla_Fichas.AllowUserToAddRows = False
        Me.Grilla_Fichas.AllowUserToDeleteRows = False
        Me.Grilla_Fichas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Fichas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Fichas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grilla_Fichas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Fichas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Fichas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Fichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Fichas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Fichas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Grilla_Fichas.Location = New System.Drawing.Point(6, 292)
        Me.Grilla_Fichas.MultiSelect = False
        Me.Grilla_Fichas.Name = "Grilla_Fichas"
        Me.Grilla_Fichas.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Fichas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Fichas.RowHeadersVisible = False
        Me.Grilla_Fichas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Grilla_Fichas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Fichas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_Fichas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Fichas.ShowCellToolTips = False
        Me.Grilla_Fichas.ShowEditingIcon = False
        Me.Grilla_Fichas.Size = New System.Drawing.Size(1190, 156)
        Me.Grilla_Fichas.TabIndex = 27
        Me.Grilla_Fichas.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 22)
        Me.Label2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(6, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 42)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "<- Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(6, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 216)
        Me.Panel1.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(403, 564)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(398, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "COPYRIGHT © 2017 ILUSTRE MUNICIPALIDAD DE PERALILLO"
        '
        'SumaRegistros
        '
        '
        'RegistrosFichas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(1210, 588)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrosFichas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrosFichas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.edad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grilla_Fichas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Grilla_Fichas As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents historial_transaccion As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents modificar As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents id As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents SumaRegistros As Timer
    Friend WithEvents numero As TextBox
    Friend WithEvents busqueda As TextBox
    Friend WithEvents sector As TextBox
    Friend WithEvents juntas As TextBox
    Friend WithEvents unidad As TextBox
    Friend WithEvents numeroficha As TextBox
    Friend WithEvents edad As NumericUpDown
    Friend WithEvents rut As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents familia As TextBox
    Friend WithEvents direccion As TextBox
    Friend WithEvents sexo As ComboBox
    Friend WithEvents listaestado As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents filtrojuntas As ComboBox
    Friend WithEvents imprimir As Button
    Friend WithEvents Button2 As Button
End Class
