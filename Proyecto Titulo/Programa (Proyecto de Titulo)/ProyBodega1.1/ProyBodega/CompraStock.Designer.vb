<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompraStock))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.n_can = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cn_a = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nm_ar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.id_ar = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.vuo = New System.Windows.Forms.Button()
        Me.gr = New System.Windows.Forms.Button()
        Me.cd_ar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 33)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Municipalidad de Peralillo"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(613, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "---"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(646, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.n_can)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cn_a)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.nm_ar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.id_ar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.vuo)
        Me.GroupBox1.Controls.Add(Me.gr)
        Me.GroupBox1.Controls.Add(Me.cd_ar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 244)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compra Stock de Articulos"
        '
        'n_can
        '
        Me.n_can.Location = New System.Drawing.Point(544, 148)
        Me.n_can.MaxLength = 5
        Me.n_can.Name = "n_can"
        Me.n_can.Size = New System.Drawing.Size(100, 26)
        Me.n_can.TabIndex = 32
        Me.n_can.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.n_can, "Digita o escribe la nueva cantidad a modificar o de ingreso de stock en producto")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(426, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 22)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nueva Cantidad:"
        '
        'cn_a
        '
        Me.cn_a.Enabled = False
        Me.cn_a.Location = New System.Drawing.Point(289, 148)
        Me.cn_a.MaxLength = 5
        Me.cn_a.Name = "cn_a"
        Me.cn_a.ReadOnly = True
        Me.cn_a.Size = New System.Drawing.Size(84, 26)
        Me.cn_a.TabIndex = 2
        Me.cn_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(161, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 22)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Cantidad Antigua:"
        '
        'nm_ar
        '
        Me.nm_ar.Enabled = False
        Me.nm_ar.Location = New System.Drawing.Point(284, 103)
        Me.nm_ar.MaxLength = 350
        Me.nm_ar.Name = "nm_ar"
        Me.nm_ar.ReadOnly = True
        Me.nm_ar.Size = New System.Drawing.Size(359, 26)
        Me.nm_ar.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(161, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 22)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Nombre Articulo:"
        '
        'id_ar
        '
        Me.id_ar.AutoSize = True
        Me.id_ar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.id_ar.Location = New System.Drawing.Point(238, 25)
        Me.id_ar.Name = "id_ar"
        Me.id_ar.Size = New System.Drawing.Size(2, 22)
        Me.id_ar.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(161, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 22)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "ID:"
        '
        'vuo
        '
        Me.vuo.BackColor = System.Drawing.SystemColors.Control
        Me.vuo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vuo.Location = New System.Drawing.Point(161, 190)
        Me.vuo.Name = "vuo"
        Me.vuo.Size = New System.Drawing.Size(145, 41)
        Me.vuo.TabIndex = 12
        Me.vuo.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.vuo, "Vuelve la pantalla anterior")
        Me.vuo.UseVisualStyleBackColor = False
        '
        'gr
        '
        Me.gr.BackColor = System.Drawing.SystemColors.Control
        Me.gr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gr.Enabled = False
        Me.gr.Location = New System.Drawing.Point(501, 190)
        Me.gr.Name = "gr"
        Me.gr.Size = New System.Drawing.Size(143, 41)
        Me.gr.TabIndex = 7
        Me.gr.Text = "Guardar"
        Me.Mensajes.SetToolTip(Me.gr, "Confirma los datos ingresados")
        Me.gr.UseVisualStyleBackColor = False
        '
        'cd_ar
        '
        Me.cd_ar.Enabled = False
        Me.cd_ar.Location = New System.Drawing.Point(280, 60)
        Me.cd_ar.MaxLength = 350
        Me.cd_ar.Name = "cd_ar"
        Me.cd_ar.ReadOnly = True
        Me.cd_ar.Size = New System.Drawing.Size(364, 26)
        Me.cd_ar.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(161, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo Articulo:"
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
        Me.Panel1.TabIndex = 3
        '
        'Mensajes
        '
        Me.Mensajes.AutoPopDelay = 5000
        Me.Mensajes.InitialDelay = 100
        Me.Mensajes.ReshowDelay = 100
        Me.Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes.ToolTipTitle = "Mensaje"
        '
        'CompraStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 285)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CompraStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CompraStock"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cn_a As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents nm_ar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents id_ar As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents vuo As Button
    Friend WithEvents gr As Button
    Friend WithEvents cd_ar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents n_can As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Mensajes As ToolTip
End Class
