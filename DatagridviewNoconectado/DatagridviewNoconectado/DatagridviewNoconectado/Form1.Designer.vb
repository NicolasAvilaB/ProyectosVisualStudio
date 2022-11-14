<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'grid
		'
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle5.NullValue = Nothing
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.grid.DefaultCellStyle = DataGridViewCellStyle5
		Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.grid.Location = New System.Drawing.Point(0, 148)
		Me.grid.Name = "grid"
		Me.grid.Size = New System.Drawing.Size(663, 229)
		Me.grid.TabIndex = 0
		'
		'Column1
		'
		Me.Column1.HeaderText = "n"
		Me.Column1.Name = "Column1"
		Me.Column1.Width = 30
		'
		'Column2
		'
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
		Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
		Me.Column2.HeaderText = "Descripcion"
		Me.Column2.Name = "Column2"
		Me.Column2.Width = 300
		'
		'Column3
		'
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green
		DataGridViewCellStyle2.Format = "N2"
		DataGridViewCellStyle2.NullValue = Nothing
		Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
		Me.Column3.HeaderText = "Valor Unitario"
		Me.Column3.Name = "Column3"
		Me.Column3.Width = 80
		'
		'Column4
		'
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle3.NullValue = "0"
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue
		Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
		Me.Column4.HeaderText = "Cantidad"
		Me.Column4.Name = "Column4"
		Me.Column4.Width = 80
		'
		'Column5
		'
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle4.Format = "N2"
		DataGridViewCellStyle4.NullValue = Nothing
		Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
		Me.Column5.HeaderText = "Subtotal"
		Me.Column5.Name = "Column5"
		Me.Column5.Width = 80
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 377)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(663, 22)
		Me.StatusStrip1.TabIndex = 1
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.GroupBox1.Controls.Add(Me.PictureBox1)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
		Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(663, 148)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.DatagridviewNoconectado.My.Resources.Resources.credit_card_icon
		Me.PictureBox1.Location = New System.Drawing.Point(495, 19)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(116, 104)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 3
		Me.PictureBox1.TabStop = False
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(155, 18)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(142, 91)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Reporte"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(32, 18)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(117, 91)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Ingresar"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.SteelBlue
		Me.ClientSize = New System.Drawing.Size(663, 399)
		Me.Controls.Add(Me.grid)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "Form1"
		Me.Text = "ReportViewer con Datagridview no conectado "
		CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents grid As DataGridView
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents Column4 As DataGridViewTextBoxColumn
	Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
