<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_Pedidos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cant = New System.Windows.Forms.TextBox()
        Me.busqueda_history = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Grilla_Historial = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.filtro = New System.Windows.Forms.Button()
        Me.Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Termino = New System.Windows.Forms.DateTimePicker()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Historial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cant)
        Me.GroupBox1.Controls.Add(Me.busqueda_history)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Grilla_Historial)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.filtro)
        Me.GroupBox1.Controls.Add(Me.Inicio)
        Me.GroupBox1.Controls.Add(Me.Termino)
        Me.GroupBox1.Controls.Add(Me.Aceptar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1265, 406)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HISTORIAL PEDIDOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(763, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 22)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Cantidades Totales:"
        '
        'cant
        '
        Me.cant.Enabled = False
        Me.cant.ForeColor = System.Drawing.Color.White
        Me.cant.Location = New System.Drawing.Point(902, 372)
        Me.cant.Name = "cant"
        Me.cant.Size = New System.Drawing.Size(355, 26)
        Me.cant.TabIndex = 67
        Me.cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'busqueda_history
        '
        Me.busqueda_history.Location = New System.Drawing.Point(182, 370)
        Me.busqueda_history.MaxLength = 45
        Me.busqueda_history.Name = "busqueda_history"
        Me.busqueda_history.Size = New System.Drawing.Size(575, 26)
        Me.busqueda_history.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(8, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 22)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Buscar Nombre Articulo: "
        '
        'Grilla_Historial
        '
        Me.Grilla_Historial.AllowUserToAddRows = False
        Me.Grilla_Historial.AllowUserToDeleteRows = False
        Me.Grilla_Historial.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Historial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Historial.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Historial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Historial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Grilla_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Historial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Historial.Location = New System.Drawing.Point(8, 240)
        Me.Grilla_Historial.Name = "Grilla_Historial"
        Me.Grilla_Historial.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Historial.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Historial.RowHeadersVisible = False
        Me.Grilla_Historial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Historial.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Historial.ShowCellToolTips = False
        Me.Grilla_Historial.ShowEditingIcon = False
        Me.Grilla_Historial.Size = New System.Drawing.Size(1249, 126)
        Me.Grilla_Historial.TabIndex = 64
        Me.Grilla_Historial.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(845, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 22)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "FECHA DE TERMINO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(185, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 22)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "FECHA DE INICIO:"
        '
        'filtro
        '
        Me.filtro.BackColor = System.Drawing.SystemColors.Control
        Me.filtro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filtro.Location = New System.Drawing.Point(546, 162)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(331, 41)
        Me.filtro.TabIndex = 61
        Me.filtro.Text = "FILTRO"
        Me.filtro.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.Inicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Inicio.CustomFormat = "dd-MM-yyyy"
        Me.Inicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Inicio.Location = New System.Drawing.Point(185, 50)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(450, 26)
        Me.Inicio.TabIndex = 59
        Me.Inicio.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'Termino
        '
        Me.Termino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Termino.CustomFormat = "dd-MM-yyyy"
        Me.Termino.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.Termino.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Termino.Location = New System.Drawing.Point(845, 50)
        Me.Termino.Name = "Termino"
        Me.Termino.Size = New System.Drawing.Size(397, 26)
        Me.Termino.TabIndex = 60
        Me.Termino.Value = New Date(2017, 12, 31, 0, 0, 0, 0)
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.Color.White
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Aceptar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.Location = New System.Drawing.Point(8, 197)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(171, 37)
        Me.Aceptar.TabIndex = 14
        Me.Aceptar.Text = "<- REGRESAR"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.restaurant.My.Resources.Resources._1
        Me.PictureBox1.Location = New System.Drawing.Point(8, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.Panel2.Size = New System.Drawing.Size(1273, 33)
        Me.Panel2.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(302, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "BIENVENIDO RESTAURANTE ""MARIO E LUIGI"""
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.DarkGreen
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1209, 3)
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
        Me.Button6.Location = New System.Drawing.Point(1242, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Historial_Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(1273, 443)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Historial_Pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial_Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Historial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents filtro As Button
    Friend WithEvents Inicio As DateTimePicker
    Friend WithEvents Termino As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cant As TextBox
    Friend WithEvents busqueda_history As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Grilla_Historial As DataGridView
End Class
