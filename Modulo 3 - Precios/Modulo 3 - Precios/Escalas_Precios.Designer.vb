<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Escalas_Precios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Escalas_Precios))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.p = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.modificar = New System.Windows.Forms.Button()
        Me.volver = New System.Windows.Forms.Button()
        Me.desglose = New System.Windows.Forms.Label()
        Me.Tabla_DD = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.acc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tipo_prod = New System.Windows.Forms.ComboBox()
        Me.porc = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Tabla_DD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.minimizar)
        Me.Panel2.Controls.Add(Me.cerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 33)
        Me.Panel2.TabIndex = 121
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "MODULO 3 - COTIZADOR"
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizar.ForeColor = System.Drawing.Color.White
        Me.minimizar.Location = New System.Drawing.Point(724, 3)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(27, 27)
        Me.minimizar.TabIndex = 1
        Me.minimizar.Text = "---"
        Me.minimizar.UseVisualStyleBackColor = False
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.Color.White
        Me.cerrar.Location = New System.Drawing.Point(758, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(27, 27)
        Me.cerrar.TabIndex = 0
        Me.cerrar.Text = "X"
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Panel1.Controls.Add(Me.p)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.modificar)
        Me.Panel1.Controls.Add(Me.volver)
        Me.Panel1.Controls.Add(Me.desglose)
        Me.Panel1.Controls.Add(Me.Tabla_DD)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.acc)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tipo_prod)
        Me.Panel1.Controls.Add(Me.porc)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.aceptar)
        Me.Panel1.Location = New System.Drawing.Point(4, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 495)
        Me.Panel1.TabIndex = 123
        '
        'p
        '
        Me.p.AutoSize = True
        Me.p.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.p.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p.ForeColor = System.Drawing.Color.White
        Me.p.Location = New System.Drawing.Point(454, 98)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(42, 29)
        Me.p.TabIndex = 205
        Me.p.Text = "0%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(371, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 29)
        Me.Label3.TabIndex = 204
        Me.Label3.Text = "PORC.:"
        '
        'modificar
        '
        Me.modificar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.modificar.BackColor = System.Drawing.Color.White
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.modificar.FlatAppearance.BorderSize = 0
        Me.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modificar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.modificar.Location = New System.Drawing.Point(186, 94)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(172, 39)
        Me.modificar.TabIndex = 203
        Me.modificar.Text = "Modificar Admin"
        Me.modificar.UseVisualStyleBackColor = False
        '
        'volver
        '
        Me.volver.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.volver.BackColor = System.Drawing.Color.White
        Me.volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.volver.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.volver.FlatAppearance.BorderSize = 0
        Me.volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.volver.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.volver.Location = New System.Drawing.Point(8, 94)
        Me.volver.Name = "volver"
        Me.volver.Size = New System.Drawing.Size(172, 39)
        Me.volver.TabIndex = 202
        Me.volver.Text = "Volver"
        Me.volver.UseVisualStyleBackColor = False
        '
        'desglose
        '
        Me.desglose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.desglose.AutoSize = True
        Me.desglose.BackColor = System.Drawing.Color.Teal
        Me.desglose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.desglose.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desglose.ForeColor = System.Drawing.Color.White
        Me.desglose.Location = New System.Drawing.Point(8, 458)
        Me.desglose.Name = "desglose"
        Me.desglose.Size = New System.Drawing.Size(29, 27)
        Me.desglose.TabIndex = 201
        Me.desglose.Text = "..."
        '
        'Tabla_DD
        '
        Me.Tabla_DD.AllowUserToAddRows = False
        Me.Tabla_DD.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Tabla_DD.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tabla_DD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabla_DD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tabla_DD.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tabla_DD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tabla_DD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tabla_DD.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tabla_DD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla_DD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tabla_DD.EnableHeadersVisualStyles = False
        Me.Tabla_DD.GridColor = System.Drawing.Color.Silver
        Me.Tabla_DD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Tabla_DD.Location = New System.Drawing.Point(8, 139)
        Me.Tabla_DD.MultiSelect = False
        Me.Tabla_DD.Name = "Tabla_DD"
        Me.Tabla_DD.ReadOnly = True
        Me.Tabla_DD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tabla_DD.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Tabla_DD.RowHeadersVisible = False
        Me.Tabla_DD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Tabla_DD.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Tabla_DD.RowTemplate.Height = 30
        Me.Tabla_DD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Tabla_DD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabla_DD.ShowCellToolTips = False
        Me.Tabla_DD.ShowEditingIcon = False
        Me.Tabla_DD.Size = New System.Drawing.Size(765, 314)
        Me.Tabla_DD.TabIndex = 200
        Me.Tabla_DD.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(14, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 22)
        Me.Label8.TabIndex = 199
        Me.Label8.Text = "ACCION ARITMETICA:"
        '
        'acc
        '
        Me.acc.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.acc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.acc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.acc.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.acc.FormattingEnabled = True
        Me.acc.Items.AddRange(New Object() {"SUMA", "RESTA"})
        Me.acc.Location = New System.Drawing.Point(182, 46)
        Me.acc.Name = "acc"
        Me.acc.Size = New System.Drawing.Size(145, 31)
        Me.acc.TabIndex = 198
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 22)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "TIPO PRODUCTOS:"
        '
        'tipo_prod
        '
        Me.tipo_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tipo_prod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipo_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo_prod.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo_prod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tipo_prod.FormattingEnabled = True
        Me.tipo_prod.Items.AddRange(New Object() {"LAMA 45, BLANCO, BRONCE, PLATA", "LAMA 45, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA", "LAMA 55, BLANCO, BRONCE, PLATA", "LAMA 55, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA"})
        Me.tipo_prod.Location = New System.Drawing.Point(161, 9)
        Me.tipo_prod.Name = "tipo_prod"
        Me.tipo_prod.Size = New System.Drawing.Size(612, 31)
        Me.tipo_prod.TabIndex = 196
        '
        'porc
        '
        Me.porc.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.porc.Location = New System.Drawing.Point(601, 46)
        Me.porc.MaxLength = 3
        Me.porc.Name = "porc"
        Me.porc.Size = New System.Drawing.Size(172, 32)
        Me.porc.TabIndex = 195
        Me.porc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(485, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 22)
        Me.Label13.TabIndex = 194
        Me.Label13.Text = "PORCENTAJE:"
        '
        'aceptar
        '
        Me.aceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.aceptar.BackColor = System.Drawing.Color.White
        Me.aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aceptar.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.aceptar.FlatAppearance.BorderSize = 0
        Me.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.aceptar.Location = New System.Drawing.Point(601, 94)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(172, 39)
        Me.aceptar.TabIndex = 192
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(227, 532)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 20)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "COPYRIGHT © 2019 PERSIANAS EXTERIORES PYM"
        '
        'Escalas_Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(789, 559)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Escalas_Precios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escalas_Precios"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tabla_DD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents minimizar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents acc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tipo_prod As ComboBox
    Friend WithEvents porc As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents aceptar As Button
    Friend WithEvents Tabla_DD As DataGridView
    Friend WithEvents desglose As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents volver As Button
    Friend WithEvents modificar As Button
    Friend WithEvents p As Label
    Friend WithEvents Label3 As Label
End Class
