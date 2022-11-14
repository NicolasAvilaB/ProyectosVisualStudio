<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bodega_User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bodega_User))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cantidaDESSSS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.estad = New System.Windows.Forms.TextBox()
        Me.precc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.hc = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.devolucion_articulos = New System.Windows.Forms.Button()
        Me.rutees = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.busqueda_rut = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Grilla_Bodega = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.cantied = New System.Windows.Forms.TextBox()
        Me.code = New System.Windows.Forms.TextBox()
        Me.depart = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.Preciocompra = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Bodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.cantidaDESSSS)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.estad)
        Me.GroupBox1.Controls.Add(Me.precc)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.hc)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.devolucion_articulos)
        Me.GroupBox1.Controls.Add(Me.rutees)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.busqueda_rut)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Grilla_Bodega)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.cantied)
        Me.GroupBox1.Controls.Add(Me.code)
        Me.GroupBox1.Controls.Add(Me.depart)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1030, 427)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bodega y Usuarios"
        '
        'cantidaDESSSS
        '
        Me.cantidaDESSSS.Enabled = False
        Me.cantidaDESSSS.Location = New System.Drawing.Point(144, 392)
        Me.cantidaDESSSS.Name = "cantidaDESSSS"
        Me.cantidaDESSSS.ReadOnly = True
        Me.cantidaDESSSS.Size = New System.Drawing.Size(228, 26)
        Me.cantidaDESSSS.TabIndex = 43
        Me.cantidaDESSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 19)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Total Cantidades:"
        '
        'estad
        '
        Me.estad.Enabled = False
        Me.estad.Location = New System.Drawing.Point(393, 190)
        Me.estad.Name = "estad"
        Me.estad.Size = New System.Drawing.Size(139, 26)
        Me.estad.TabIndex = 41
        '
        'precc
        '
        Me.precc.Enabled = False
        Me.precc.Location = New System.Drawing.Point(787, 392)
        Me.precc.Name = "precc"
        Me.precc.ReadOnly = True
        Me.precc.Size = New System.Drawing.Size(228, 26)
        Me.precc.TabIndex = 40
        Me.precc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(661, 395)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 19)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Total Comprados:"
        '
        'hc
        '
        Me.hc.BackColor = System.Drawing.SystemColors.Control
        Me.hc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.hc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hc.Location = New System.Drawing.Point(551, 237)
        Me.hc.Name = "hc"
        Me.hc.Size = New System.Drawing.Size(233, 41)
        Me.hc.TabIndex = 11
        Me.hc.Text = "Historial Compra"
        Me.Mensajes.SetToolTip(Me.hc, "Visualize el historial de compras efectuadas hasta la fecha")
        Me.hc.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 19)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Precio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(218, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 19)
        Me.Label9.TabIndex = 37
        '
        'devolucion_articulos
        '
        Me.devolucion_articulos.BackColor = System.Drawing.SystemColors.Control
        Me.devolucion_articulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.devolucion_articulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.devolucion_articulos.Location = New System.Drawing.Point(790, 237)
        Me.devolucion_articulos.Name = "devolucion_articulos"
        Me.devolucion_articulos.Size = New System.Drawing.Size(228, 41)
        Me.devolucion_articulos.TabIndex = 10
        Me.devolucion_articulos.Text = "Devolver Articulo"
        Me.Mensajes.SetToolTip(Me.devolucion_articulos, "Devuelva algun Articulo que ya haya sido prestado")
        Me.devolucion_articulos.UseVisualStyleBackColor = False
        '
        'rutees
        '
        Me.rutees.Enabled = False
        Me.rutees.Location = New System.Drawing.Point(268, 21)
        Me.rutees.MaxLength = 12
        Me.rutees.Name = "rutees"
        Me.rutees.ReadOnly = True
        Me.rutees.Size = New System.Drawing.Size(218, 26)
        Me.rutees.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.rutees, "Escrive el Rut del Usuario Registrado en el Programa")
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(492, 24)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(0, 19)
        Me.nombre.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(542, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 19)
        Me.Label7.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Estado:"
        '
        'busqueda_rut
        '
        Me.busqueda_rut.Location = New System.Drawing.Point(268, 245)
        Me.busqueda_rut.MaxLength = 12
        Me.busqueda_rut.Name = "busqueda_rut"
        Me.busqueda_rut.Size = New System.Drawing.Size(264, 26)
        Me.busqueda_rut.TabIndex = 13
        Me.Mensajes.SetToolTip(Me.busqueda_rut, "Busque algun Rut enlazado con algun Articulo ")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Buscar Rut:"
        '
        'Grilla_Bodega
        '
        Me.Grilla_Bodega.AllowUserToAddRows = False
        Me.Grilla_Bodega.AllowUserToDeleteRows = False
        Me.Grilla_Bodega.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Bodega.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Bodega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Bodega.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Bodega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Bodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Bodega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Bodega.EnableHeadersVisualStyles = False
        Me.Grilla_Bodega.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Grilla_Bodega.Location = New System.Drawing.Point(14, 284)
        Me.Grilla_Bodega.MultiSelect = False
        Me.Grilla_Bodega.Name = "Grilla_Bodega"
        Me.Grilla_Bodega.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Bodega.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Bodega.RowHeadersVisible = False
        Me.Grilla_Bodega.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Grilla_Bodega.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Bodega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_Bodega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Bodega.ShowCellToolTips = False
        Me.Grilla_Bodega.ShowEditingIcon = False
        Me.Grilla_Bodega.Size = New System.Drawing.Size(1004, 102)
        Me.Grilla_Bodega.TabIndex = 26
        Me.Grilla_Bodega.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_Bodega, "Visualiza los Rut ya Enlazados con Articulos y con un Estado Especifico")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(14, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 41)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.Button1, "Vuelve a la Pantalla Anterior")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Enabled = False
        Me.cancelar.Location = New System.Drawing.Point(551, 182)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(233, 41)
        Me.cancelar.TabIndex = 9
        Me.cancelar.Text = "Cancelar"
        Me.Mensajes.SetToolTip(Me.cancelar, "Cancele las Operaciones")
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.SystemColors.Control
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Location = New System.Drawing.Point(790, 75)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(228, 41)
        Me.modificar.TabIndex = 8
        Me.modificar.Text = "Modificar"
        Me.Mensajes.SetToolTip(Me.modificar, "Modifique algun dato existente mal digitado")
        Me.modificar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.Location = New System.Drawing.Point(790, 128)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(228, 41)
        Me.eliminar.TabIndex = 7
        Me.eliminar.Text = "Eliminar"
        Me.Mensajes.SetToolTip(Me.eliminar, "Elimine el Usuario que ya no desea efectuar el Servicio")
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.SystemColors.Control
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Location = New System.Drawing.Point(790, 182)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(228, 41)
        Me.guardar.TabIndex = 6
        Me.guardar.Text = "Guardar"
        Me.Mensajes.SetToolTip(Me.guardar, "Guarde los Cambios Realizados")
        Me.guardar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Location = New System.Drawing.Point(790, 21)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(228, 41)
        Me.nuevo.TabIndex = 5
        Me.nuevo.Text = "Nuevo"
        Me.Mensajes.SetToolTip(Me.nuevo, "Enlaze un Nuevo Usuario con un Articulo")
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'cantied
        '
        Me.cantied.Enabled = False
        Me.cantied.Location = New System.Drawing.Point(268, 146)
        Me.cantied.MaxLength = 5
        Me.cantied.Name = "cantied"
        Me.cantied.ReadOnly = True
        Me.cantied.Size = New System.Drawing.Size(119, 26)
        Me.cantied.TabIndex = 3
        Me.Mensajes.SetToolTip(Me.cantied, "Escribe la Cantidad de Articulos")
        '
        'code
        '
        Me.code.Enabled = False
        Me.code.Location = New System.Drawing.Point(268, 103)
        Me.code.MaxLength = 16
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        Me.code.Size = New System.Drawing.Size(264, 26)
        Me.code.TabIndex = 2
        Me.Mensajes.SetToolTip(Me.code, "Escribe el Codigo del Articulo que Desea usted Enlazar con el Usuario ")
        '
        'depart
        '
        Me.depart.Enabled = False
        Me.depart.Location = New System.Drawing.Point(268, 62)
        Me.depart.Name = "depart"
        Me.depart.ReadOnly = True
        Me.depart.Size = New System.Drawing.Size(425, 26)
        Me.depart.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(159, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Departamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(14, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 207)
        Me.Panel1.TabIndex = 4
        Me.Mensajes.SetToolTip(Me.Panel1, "Municipalidad de Peralillo")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rut Usuario:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(496, 360)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(10, 26)
        Me.TextBox1.TabIndex = 44
        Me.TextBox1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1045, 33)
        Me.Panel2.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(4, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Municipalidad de Peralillo"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(982, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "---"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DimGray
        Me.Button3.Location = New System.Drawing.Point(1015, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 27)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Mensajes
        '
        Me.Mensajes.AutoPopDelay = 5000
        Me.Mensajes.InitialDelay = 100
        Me.Mensajes.ReshowDelay = 100
        Me.Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes.ToolTipTitle = "Mensaje"
        '
        'Preciocompra
        '
        Me.Preciocompra.Interval = 50
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Bodega_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 466)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Bodega_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipalidad de Peralillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Bodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cantied As TextBox
    Friend WithEvents code As TextBox
    Friend WithEvents depart As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents modificar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents busqueda_rut As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nombre As Label
    Friend WithEvents rutees As TextBox
    Friend WithEvents devolucion_articulos As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Mensajes As ToolTip
    Friend WithEvents Label9 As Label
    Friend WithEvents Grilla_Bodega As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents hc As Button
    Friend WithEvents precc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Preciocompra As Timer
    Friend WithEvents estad As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cantidaDESSSS As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
