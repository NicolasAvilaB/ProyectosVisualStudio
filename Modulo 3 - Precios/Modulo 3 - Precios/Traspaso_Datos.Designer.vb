<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Traspaso_Datos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Traspaso_Datos))
        Me.fcc = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.agregar = New System.Windows.Forms.Button()
        Me.volver = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.n = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.alt = New System.Windows.Forms.TextBox()
        Me.col = New System.Windows.Forms.ComboBox()
        Me.anc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lm = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.n, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fcc
        '
        Me.fcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.fcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fcc.Enabled = False
        Me.fcc.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.fcc.FormattingEnabled = True
        Me.fcc.Items.AddRange(New Object() {"F", "C"})
        Me.fcc.Location = New System.Drawing.Point(64, 49)
        Me.fcc.Name = "fcc"
        Me.fcc.Size = New System.Drawing.Size(183, 31)
        Me.fcc.TabIndex = 199
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
        Me.Panel2.Size = New System.Drawing.Size(470, 33)
        Me.Panel2.TabIndex = 200
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
        Me.minimizar.Location = New System.Drawing.Point(405, 3)
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
        Me.cerrar.Location = New System.Drawing.Point(439, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(27, 27)
        Me.cerrar.TabIndex = 0
        Me.cerrar.Text = "X"
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(78, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 20)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "COPYRIGHT © 2019 PERSIANAS EXTERIORES PYM"
        '
        'agregar
        '
        Me.agregar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.agregar.BackColor = System.Drawing.Color.White
        Me.agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregar.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.agregar.FlatAppearance.BorderSize = 0
        Me.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.agregar.Location = New System.Drawing.Point(281, 46)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(172, 39)
        Me.agregar.TabIndex = 204
        Me.agregar.Text = "AGREGAR"
        Me.agregar.UseVisualStyleBackColor = False
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
        Me.volver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.volver.Location = New System.Drawing.Point(281, 262)
        Me.volver.Name = "volver"
        Me.volver.Size = New System.Drawing.Size(172, 39)
        Me.volver.TabIndex = 205
        Me.volver.Text = "VOLVER"
        Me.volver.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 25)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "F/C:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 25)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "N°:"
        '
        'n
        '
        Me.n.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n.Location = New System.Drawing.Point(64, 91)
        Me.n.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(183, 32)
        Me.n.TabIndex = 209
        Me.n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.n.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 25)
        Me.Label4.TabIndex = 210
        Me.Label4.Text = "Alto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 25)
        Me.Label6.TabIndex = 211
        Me.Label6.Text = "Ancho:"
        '
        'alt
        '
        Me.alt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alt.Location = New System.Drawing.Point(70, 181)
        Me.alt.MaxLength = 4
        Me.alt.Name = "alt"
        Me.alt.Size = New System.Drawing.Size(177, 32)
        Me.alt.TabIndex = 212
        Me.alt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'col
        '
        Me.col.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.col.Cursor = System.Windows.Forms.Cursors.Hand
        Me.col.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.col.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.col.FormattingEnabled = True
        Me.col.Items.AddRange(New Object() {"BLANCO", "BRONCE", "PLATA", "PIRITA", "NOGAL", "CASCARA DE HUEVO", "GOLDEN", "CAFE MORO", "GRIS ANTRAFITA"})
        Me.col.Location = New System.Drawing.Point(102, 270)
        Me.col.Name = "col"
        Me.col.Size = New System.Drawing.Size(145, 31)
        Me.col.TabIndex = 207
        '
        'anc
        '
        Me.anc.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anc.Location = New System.Drawing.Point(91, 135)
        Me.anc.MaxLength = 4
        Me.anc.Name = "anc"
        Me.anc.Size = New System.Drawing.Size(156, 32)
        Me.anc.TabIndex = 213
        Me.anc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 25)
        Me.Label7.TabIndex = 214
        Me.Label7.Text = "Lama:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 25)
        Me.Label8.TabIndex = 215
        Me.Label8.Text = "Colores:"
        '
        'lm
        '
        Me.lm.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lm.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lm.FormattingEnabled = True
        Me.lm.Items.AddRange(New Object() {"45 MM", "55 MM"})
        Me.lm.Location = New System.Drawing.Point(91, 226)
        Me.lm.Name = "lm"
        Me.lm.Size = New System.Drawing.Size(156, 31)
        Me.lm.TabIndex = 216
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 316)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 33)
        Me.Panel1.TabIndex = 217
        '
        'Traspaso_Datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 349)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.anc)
        Me.Controls.Add(Me.alt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.n)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.col)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.volver)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.fcc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Traspaso_Datos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traspaso_Datos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.n, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fcc As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents minimizar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents agregar As Button
    Friend WithEvents volver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents n As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents alt As TextBox
    Friend WithEvents col As ComboBox
    Friend WithEvents anc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lm As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
