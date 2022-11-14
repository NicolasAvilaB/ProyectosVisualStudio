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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Acept = New System.Windows.Forms.Button()
        Me.CD_DEVO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Size = New System.Drawing.Size(486, 295)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Devolver Articulo Prestado"
        '
        'history
        '
        Me.history.BackColor = System.Drawing.SystemColors.Control
        Me.history.Cursor = System.Windows.Forms.Cursors.Hand
        Me.history.Location = New System.Drawing.Point(165, 190)
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(127, 41)
        Me.history.TabIndex = 4
        Me.history.Text = "Historial Bodega"
        Me.Mensajes.SetToolTip(Me.history, "Revisa todas las transacciones que se hicieron en una fecha determinada")
        Me.history.UseVisualStyleBackColor = False
        '
        'despliegue
        '
        Me.despliegue.BackColor = System.Drawing.SystemColors.Control
        Me.despliegue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.despliegue.Location = New System.Drawing.Point(298, 190)
        Me.despliegue.Name = "despliegue"
        Me.despliegue.Size = New System.Drawing.Size(175, 41)
        Me.despliegue.TabIndex = 5
        Me.despliegue.Text = "Ver Grilla ->"
        Me.Mensajes.SetToolTip(Me.despliegue, "Visualiza la grilla para efectuar devoluciones")
        Me.despliegue.UseVisualStyleBackColor = False
        '
        'devuelta
        '
        Me.devuelta.BackColor = System.Drawing.SystemColors.Control
        Me.devuelta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.devuelta.Location = New System.Drawing.Point(14, 244)
        Me.devuelta.Name = "devuelta"
        Me.devuelta.Size = New System.Drawing.Size(141, 41)
        Me.devuelta.TabIndex = 6
        Me.devuelta.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.devuelta, "Vuelve a la pantalla anterior")
        Me.devuelta.UseVisualStyleBackColor = False
        '
        'cantided
        '
        Me.cantided.Enabled = False
        Me.cantided.Location = New System.Drawing.Point(279, 142)
        Me.cantided.MaxLength = 10
        Me.cantided.Name = "cantided"
        Me.cantided.ReadOnly = True
        Me.cantided.Size = New System.Drawing.Size(194, 26)
        Me.cantided.TabIndex = 3
        Me.Mensajes.SetToolTip(Me.cantided, "Se mostrara la cantidad a cuanto se le presto al usuario")
        '
        'departamen
        '
        Me.departamen.Enabled = False
        Me.departamen.Location = New System.Drawing.Point(280, 103)
        Me.departamen.MaxLength = 10
        Me.departamen.Name = "departamen"
        Me.departamen.ReadOnly = True
        Me.departamen.Size = New System.Drawing.Size(193, 26)
        Me.departamen.TabIndex = 2
        Me.Mensajes.SetToolTip(Me.departamen, "Se mostrara el departamento al cual el usuario pertenece")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Departamento:"
        '
        'busque_code_arti
        '
        Me.busque_code_arti.Enabled = False
        Me.busque_code_arti.Location = New System.Drawing.Point(268, 252)
        Me.busque_code_arti.Name = "busque_code_arti"
        Me.busque_code_arti.ReadOnly = True
        Me.busque_code_arti.Size = New System.Drawing.Size(205, 26)
        Me.busque_code_arti.TabIndex = 7
        Me.Mensajes.SetToolTip(Me.busque_code_arti, "Haslo facil, busca el codigo del articulo al cual realizaras la transaccion")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Buscar Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Rut:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Código Artículo:"
        '
        'ruut
        '
        Me.ruut.Enabled = False
        Me.ruut.Location = New System.Drawing.Point(280, 62)
        Me.ruut.MaxLength = 10
        Me.ruut.Name = "ruut"
        Me.ruut.ReadOnly = True
        Me.ruut.Size = New System.Drawing.Size(193, 26)
        Me.ruut.TabIndex = 1
        Me.Mensajes.SetToolTip(Me.ruut, "Se mostrara el rut del usuario ligado al articulo una vez seleccionando el codigo" &
        " del articulo")
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
        Me.Mensajes.SetToolTip(Me.articode, "Se mostrara el codigo del articulo una vez seleccionado en la grilla")
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
        Me.devolver.Location = New System.Drawing.Point(6, 252)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(195, 37)
        Me.devolver.TabIndex = 0
        Me.devolver.Text = "Devolución"
        Me.Mensajes.SetToolTip(Me.devolver, "Efectua la devolucion de stock una vez seleccionado el articulo")
        Me.devolver.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Location = New System.Drawing.Point(397, 252)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(196, 37)
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
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Devolucion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Grilla_Devolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Devolucion.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Devolucion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Devolucion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Devolucion.EnableHeadersVisualStyles = False
        Me.Grilla_Devolucion.Location = New System.Drawing.Point(6, 14)
        Me.Grilla_Devolucion.MultiSelect = False
        Me.Grilla_Devolucion.Name = "Grilla_Devolucion"
        Me.Grilla_Devolucion.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Devolucion.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Grilla_Devolucion.RowHeadersVisible = False
        Me.Grilla_Devolucion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grilla_Devolucion.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Grilla_Devolucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_Devolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Devolucion.ShowCellToolTips = False
        Me.Grilla_Devolucion.ShowEditingIcon = False
        Me.Grilla_Devolucion.Size = New System.Drawing.Size(587, 201)
        Me.Grilla_Devolucion.TabIndex = 15
        Me.Grilla_Devolucion.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_Devolucion, "Visualiza y selecciona el articulo a devolver")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.Acept)
        Me.GroupBox2.Controls.Add(Me.CD_DEVO)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.devolver)
        Me.GroupBox2.Controls.Add(Me.Grilla_Devolucion)
        Me.GroupBox2.Controls.Add(Me.cancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(492, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(598, 295)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'Acept
        '
        Me.Acept.BackColor = System.Drawing.SystemColors.Control
        Me.Acept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Acept.Enabled = False
        Me.Acept.Location = New System.Drawing.Point(207, 252)
        Me.Acept.Name = "Acept"
        Me.Acept.Size = New System.Drawing.Size(184, 37)
        Me.Acept.TabIndex = 24
        Me.Acept.Text = "Aceptar"
        Me.Mensajes.SetToolTip(Me.Acept, "Efectua la devolucion de stock una vez seleccionado el articulo")
        Me.Acept.UseVisualStyleBackColor = False
        Me.Acept.Visible = False
        '
        'CD_DEVO
        '
        Me.CD_DEVO.Enabled = False
        Me.CD_DEVO.Location = New System.Drawing.Point(140, 221)
        Me.CD_DEVO.MaxLength = 40
        Me.CD_DEVO.Name = "CD_DEVO"
        Me.CD_DEVO.ReadOnly = True
        Me.CD_DEVO.Size = New System.Drawing.Size(452, 26)
        Me.CD_DEVO.TabIndex = 23
        Me.CD_DEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensajes.SetToolTip(Me.CD_DEVO, "Digita el Codigo enlazado con la Devolcuion Especifica")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Codigo Devolucion:"
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
        Me.Panel2.Size = New System.Drawing.Size(1097, 33)
        Me.Panel2.TabIndex = 29
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
        Me.Button5.Location = New System.Drawing.Point(1034, 3)
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
        Me.Button6.Location = New System.Drawing.Point(1067, 3)
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
        Me.ClientSize = New System.Drawing.Size(1097, 335)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Devolver_Articulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipalidad de Peralillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Devolucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents CD_DEVO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Acept As Button
End Class
