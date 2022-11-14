<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reponer_Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reponer_Stock))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.informe_stock = New System.Windows.Forms.Button()
        Me.elimina4 = New System.Windows.Forms.Button()
        Me.Historial_In = New System.Windows.Forms.Button()
        Me.Can = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.N_D = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_D = New System.Windows.Forms.ComboBox()
        Me.Marc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Grilla_Stock = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Cod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buscar_Articulo_Nom = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1001, 33)
        Me.Panel2.TabIndex = 6
        Me.Mensajes.SetToolTip(Me.Panel2, "En esta Sección Puedes Mover la Pantalla a Donde tu Quieras")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(4, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Municipalidad de Peralillo"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DimGray
        Me.Button5.Location = New System.Drawing.Point(937, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 27)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "---"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DimGray
        Me.Button6.Location = New System.Drawing.Point(970, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.informe_stock)
        Me.GroupBox1.Controls.Add(Me.elimina4)
        Me.GroupBox1.Controls.Add(Me.Historial_In)
        Me.GroupBox1.Controls.Add(Me.Can)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.N_D)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.T_D)
        Me.GroupBox1.Controls.Add(Me.Marc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Grilla_Stock)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.Cod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Buscar_Articulo_Nom)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(988, 395)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compra de Stock"
        '
        'informe_stock
        '
        Me.informe_stock.BackColor = System.Drawing.SystemColors.Control
        Me.informe_stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.informe_stock.Location = New System.Drawing.Point(14, 290)
        Me.informe_stock.Name = "informe_stock"
        Me.informe_stock.Size = New System.Drawing.Size(141, 41)
        Me.informe_stock.TabIndex = 28
        Me.informe_stock.Text = "Imprimir Reporte"
        Me.Mensajes.SetToolTip(Me.informe_stock, "Imprime un reporte de todos los productos agregados en stock")
        Me.informe_stock.UseVisualStyleBackColor = False
        '
        'elimina4
        '
        Me.elimina4.BackColor = System.Drawing.SystemColors.Control
        Me.elimina4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.elimina4.Location = New System.Drawing.Point(775, 88)
        Me.elimina4.Name = "elimina4"
        Me.elimina4.Size = New System.Drawing.Size(82, 37)
        Me.elimina4.TabIndex = 27
        Me.elimina4.Text = "Eliminar"
        Me.Mensajes.SetToolTip(Me.elimina4, "Para eliminar un articulo, es necesario seleccionarlo en la grilla presente y lue" &
        "go clickear este boton")
        Me.elimina4.UseVisualStyleBackColor = False
        '
        'Historial_In
        '
        Me.Historial_In.BackColor = System.Drawing.SystemColors.Control
        Me.Historial_In.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Historial_In.Location = New System.Drawing.Point(14, 237)
        Me.Historial_In.Name = "Historial_In"
        Me.Historial_In.Size = New System.Drawing.Size(141, 41)
        Me.Historial_In.TabIndex = 26
        Me.Historial_In.Text = "Historial Ingresos"
        Me.Mensajes.SetToolTip(Me.Historial_In, "Muestra un historial de los ingresos antiguos y recientes, puedes ayudarte con un" &
        " filtro de fecha")
        Me.Historial_In.UseVisualStyleBackColor = False
        '
        'Can
        '
        Me.Can.Enabled = False
        Me.Can.Location = New System.Drawing.Point(670, 94)
        Me.Can.MaxLength = 5
        Me.Can.Name = "Can"
        Me.Can.ReadOnly = True
        Me.Can.Size = New System.Drawing.Size(99, 26)
        Me.Can.TabIndex = 25
        Me.Can.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.Can, "Digita una cantidad acorde al inventario de ingreso")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(594, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 22)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Cantidad:"
        '
        'N_D
        '
        Me.N_D.Enabled = False
        Me.N_D.Location = New System.Drawing.Point(718, 58)
        Me.N_D.MaxLength = 16
        Me.N_D.Name = "N_D"
        Me.N_D.ReadOnly = True
        Me.N_D.Size = New System.Drawing.Size(258, 26)
        Me.N_D.TabIndex = 23
        Me.N_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.N_D, "Digita el numero de documento asociado a la factura o boleta del ingreso de los a" &
        "rticulos")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(594, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 22)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "N° Documento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(594, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 22)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Tipo Documento:"
        '
        'T_D
        '
        Me.T_D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.T_D.Enabled = False
        Me.T_D.FormattingEnabled = True
        Me.T_D.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.T_D.Location = New System.Drawing.Point(718, 21)
        Me.T_D.Name = "T_D"
        Me.T_D.Size = New System.Drawing.Size(258, 28)
        Me.T_D.TabIndex = 20
        Me.Mensajes.SetToolTip(Me.T_D, "Selecciona segun el tipo de documento entre factura y/o boleta, de ingreso de los" &
        " articulos ")
        '
        'Marc
        '
        Me.Marc.Enabled = False
        Me.Marc.Location = New System.Drawing.Point(249, 93)
        Me.Marc.MaxLength = 10
        Me.Marc.Name = "Marc"
        Me.Marc.ReadOnly = True
        Me.Marc.Size = New System.Drawing.Size(339, 26)
        Me.Marc.TabIndex = 18
        Me.Mensajes.SetToolTip(Me.Marc, "Digita aqui el stock del articulo")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(167, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Marca:"
        '
        'Grilla_Stock
        '
        Me.Grilla_Stock.AllowUserToAddRows = False
        Me.Grilla_Stock.AllowUserToDeleteRows = False
        Me.Grilla_Stock.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Stock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Stock.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Stock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Stock.Location = New System.Drawing.Point(167, 129)
        Me.Grilla_Stock.MultiSelect = False
        Me.Grilla_Stock.Name = "Grilla_Stock"
        Me.Grilla_Stock.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Stock.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Stock.RowHeadersVisible = False
        Me.Grilla_Stock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grilla_Stock.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Stock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Stock.ShowCellToolTips = False
        Me.Grilla_Stock.ShowEditingIcon = False
        Me.Grilla_Stock.Size = New System.Drawing.Size(809, 256)
        Me.Grilla_Stock.TabIndex = 17
        Me.Grilla_Stock.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_Stock, "Se muestra los articulos ya registrados, con su cantidad, codigo, fecha, tipo de " &
        "documento, etc, para seguir comprando stock, solo das doble click sobre el produ" &
        "cto")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(14, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.Button1, "Vuelva a la pantalla anterior")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.SystemColors.Control
        Me.Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar.Location = New System.Drawing.Point(863, 88)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(113, 37)
        Me.Guardar.TabIndex = 3
        Me.Guardar.Text = "Guardar Stock"
        Me.Mensajes.SetToolTip(Me.Guardar, "Guarda tu stock ya creado")
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'Cod
        '
        Me.Cod.Enabled = False
        Me.Cod.Location = New System.Drawing.Point(249, 21)
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Size = New System.Drawing.Size(339, 26)
        Me.Cod.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.Cod, "Se mostrara el codigo del articulo")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(167, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Codigo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(167, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Buscar Nombre:"
        '
        'Buscar_Articulo_Nom
        '
        Me.Buscar_Articulo_Nom.Location = New System.Drawing.Point(288, 57)
        Me.Buscar_Articulo_Nom.MaxLength = 45
        Me.Buscar_Articulo_Nom.Name = "Buscar_Articulo_Nom"
        Me.Buscar_Articulo_Nom.Size = New System.Drawing.Size(300, 26)
        Me.Buscar_Articulo_Nom.TabIndex = 1
        Me.Mensajes.SetToolTip(Me.Buscar_Articulo_Nom, "Busca el articulo ya creado de la ventana anterior, digitando su nombre ")
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
        'Mensajes
        '
        Me.Mensajes.AutoPopDelay = 5000
        Me.Mensajes.InitialDelay = 100
        Me.Mensajes.ReshowDelay = 100
        Me.Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes.ToolTipTitle = "Mensaje"
        '
        'Reponer_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1001, 436)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reponer_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reponer_Stock"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Buscar_Articulo_Nom As TextBox
    Friend WithEvents Cod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Grilla_Stock As DataGridView
    Friend WithEvents Mensajes As ToolTip
    Friend WithEvents Marc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents N_D As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents T_D As ComboBox
    Friend WithEvents Can As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Historial_In As Button
    Friend WithEvents elimina4 As Button
    Friend WithEvents informe_stock As Button
End Class
