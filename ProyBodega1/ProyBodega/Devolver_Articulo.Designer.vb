<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Devolver_Articulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Devolver_Articulo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.history = New System.Windows.Forms.Button()
        Me.despliegue = New System.Windows.Forms.Button()
        Me.devuelta = New System.Windows.Forms.Button()
        Me.cantided = New System.Windows.Forms.TextBox()
        Me.departamen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.busque_code_arti = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ruut = New System.Windows.Forms.TextBox()
        Me.articode = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.devolver = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Grilla_Devolucion = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Devolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.history)
        Me.GroupBox1.Controls.Add(Me.despliegue)
        Me.GroupBox1.Controls.Add(Me.devuelta)
        Me.GroupBox1.Controls.Add(Me.cantided)
        Me.GroupBox1.Controls.Add(Me.departamen)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.busque_code_arti)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ruut)
        Me.GroupBox1.Controls.Add(Me.articode)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 272)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Devolver Articulo Prestado"
        '
        'history
        '
        Me.history.BackColor = System.Drawing.SystemColors.Control
        Me.history.Cursor = System.Windows.Forms.Cursors.Hand
        Me.history.Location = New System.Drawing.Point(161, 152)
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(141, 41)
        Me.history.TabIndex = 4
        Me.history.Text = "Historial Bodega"
        Me.Mensajes.SetToolTip(Me.history, "Revisa Todos los Prestamos y Devoluciones Realizados Hasta la Fecha")
        Me.history.UseVisualStyleBackColor = False
        '
        'despliegue
        '
        Me.despliegue.BackColor = System.Drawing.SystemColors.Control
        Me.despliegue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.despliegue.Location = New System.Drawing.Point(311, 152)
        Me.despliegue.Name = "despliegue"
        Me.despliegue.Size = New System.Drawing.Size(161, 41)
        Me.despliegue.TabIndex = 5
        Me.despliegue.Text = "Ver Grilla ->"
        Me.Mensajes.SetToolTip(Me.despliegue, "Desglose la Grilla Para Efectuar las Devoluciones")
        Me.despliegue.UseVisualStyleBackColor = False
        '
        'devuelta
        '
        Me.devuelta.BackColor = System.Drawing.SystemColors.Control
        Me.devuelta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.devuelta.Location = New System.Drawing.Point(15, 235)
        Me.devuelta.Name = "devuelta"
        Me.devuelta.Size = New System.Drawing.Size(458, 32)
        Me.devuelta.TabIndex = 6
        Me.devuelta.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.devuelta, "Vuelve a la Pantalla Anterior")
        Me.devuelta.UseVisualStyleBackColor = False
        '
        'cantided
        '
        Me.cantided.Enabled = False
        Me.cantided.Location = New System.Drawing.Point(278, 120)
        Me.cantided.MaxLength = 10
        Me.cantided.Name = "cantided"
        Me.cantided.ReadOnly = True
        Me.cantided.Size = New System.Drawing.Size(194, 26)
        Me.cantided.TabIndex = 3
        '
        'departamen
        '
        Me.departamen.Enabled = False
        Me.departamen.Location = New System.Drawing.Point(279, 88)
        Me.departamen.MaxLength = 10
        Me.departamen.Name = "departamen"
        Me.departamen.ReadOnly = True
        Me.departamen.Size = New System.Drawing.Size(193, 26)
        Me.departamen.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(161, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(161, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 21)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Departamento:"
        '
        'busque_code_arti
        '
        Me.busque_code_arti.Enabled = False
        Me.busque_code_arti.Location = New System.Drawing.Point(268, 199)
        Me.busque_code_arti.MaxLength = 15
        Me.busque_code_arti.Name = "busque_code_arti"
        Me.busque_code_arti.ReadOnly = True
        Me.busque_code_arti.Size = New System.Drawing.Size(204, 26)
        Me.busque_code_arti.TabIndex = 7
        Me.Mensajes.SetToolTip(Me.busque_code_arti, "Haslo Facil, Busca el Codigo del Articulo al cual Realizaras la Transaccion")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(161, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Buscar Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(161, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Rut:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(161, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Código Artículo:"
        '
        'ruut
        '
        Me.ruut.Enabled = False
        Me.ruut.Location = New System.Drawing.Point(280, 56)
        Me.ruut.MaxLength = 10
        Me.ruut.Name = "ruut"
        Me.ruut.ReadOnly = True
        Me.ruut.Size = New System.Drawing.Size(193, 26)
        Me.ruut.TabIndex = 1
        '
        'articode
        '
        Me.articode.Enabled = False
        Me.articode.Location = New System.Drawing.Point(280, 24)
        Me.articode.MaxLength = 45
        Me.articode.Name = "articode"
        Me.articode.ReadOnly = True
        Me.articode.Size = New System.Drawing.Size(193, 26)
        Me.articode.TabIndex = 0
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
        Me.Panel1.TabIndex = 5
        Me.Mensajes.SetToolTip(Me.Panel1, "Municipalidad de Peralillo")
        '
        'devolver
        '
        Me.devolver.BackColor = System.Drawing.SystemColors.Control
        Me.devolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.devolver.Location = New System.Drawing.Point(6, 235)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(195, 32)
        Me.devolver.TabIndex = 0
        Me.devolver.Text = "Devolución"
        Me.Mensajes.SetToolTip(Me.devolver, "Efectua la Devolucion de Stock una vez Seleccionado el Articulo")
        Me.devolver.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Location = New System.Drawing.Point(320, 235)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(196, 32)
        Me.cancelar.TabIndex = 1
        Me.cancelar.Text = "Cancelar"
        Me.Mensajes.SetToolTip(Me.cancelar, "Cancela las operaciones")
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'Grilla_Devolucion
        '
        Me.Grilla_Devolucion.AllowUserToAddRows = False
        Me.Grilla_Devolucion.AllowUserToDeleteRows = False
        Me.Grilla_Devolucion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Devolucion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Devolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Devolucion.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Devolucion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Devolucion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Devolucion.Location = New System.Drawing.Point(6, 14)
        Me.Grilla_Devolucion.MultiSelect = False
        Me.Grilla_Devolucion.Name = "Grilla_Devolucion"
        Me.Grilla_Devolucion.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Devolucion.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Devolucion.RowHeadersVisible = False
        Me.Grilla_Devolucion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grilla_Devolucion.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Devolucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_Devolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Devolucion.ShowCellToolTips = False
        Me.Grilla_Devolucion.ShowEditingIcon = False
        Me.Grilla_Devolucion.Size = New System.Drawing.Size(509, 217)
        Me.Grilla_Devolucion.TabIndex = 15
        Me.Grilla_Devolucion.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_Devolucion, "Visualiza y Selecciona el Codigo a Devolver")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.devolver)
        Me.GroupBox2.Controls.Add(Me.Grilla_Devolucion)
        Me.GroupBox2.Controls.Add(Me.cancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(492, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 272)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1002, 33)
        Me.Panel2.TabIndex = 29
        Me.Mensajes.SetToolTip(Me.Panel2, "En esta Sección Puedes Mover la Pantalla a Donde tu Quieras")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(4, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Municipalidad de Peralillo"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DimGray
        Me.Button5.Location = New System.Drawing.Point(939, 3)
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
        Me.Button6.Location = New System.Drawing.Point(972, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Mensajes
        '
        Me.Mensajes.AutoPopDelay = 5000
        Me.Mensajes.InitialDelay = 100
        Me.Mensajes.ReshowDelay = 100
        Me.Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes.ToolTipTitle = "Mensaje"
        '
        'Devolver_Articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 312)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Devolver_Articulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipalidad de Peralillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Devolucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents busque_code_arti As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Grilla_Devolucion As DataGridView
    Friend WithEvents ruut As TextBox
    Friend WithEvents cancelar As Button
    Friend WithEvents articode As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cantided As TextBox
    Friend WithEvents departamen As TextBox
    Friend WithEvents devuelta As Button
    Friend WithEvents despliegue As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents devolver As Button
    Friend WithEvents history As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Mensajes As ToolTip
End Class
