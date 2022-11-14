<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busca_Productos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Vissual = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.F_Bus_Pro = New System.Windows.Forms.TextBox()
        Me.B_Pro = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Vissual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Vissual)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.F_Bus_Pro)
        Me.GroupBox1.Controls.Add(Me.B_Pro)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 368)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(593, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filtro De Busqueda"
        '
        'Vissual
        '
        Me.Vissual.AllowUserToAddRows = False
        Me.Vissual.AllowUserToDeleteRows = False
        Me.Vissual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Vissual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vissual.Location = New System.Drawing.Point(6, 111)
        Me.Vissual.Name = "Vissual"
        Me.Vissual.ReadOnly = True
        Me.Vissual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Vissual.Size = New System.Drawing.Size(817, 251)
        Me.Vissual.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar Por Producto:"
        '
        'F_Bus_Pro
        '
        Me.F_Bus_Pro.Location = New System.Drawing.Point(597, 57)
        Me.F_Bus_Pro.Name = "F_Bus_Pro"
        Me.F_Bus_Pro.Size = New System.Drawing.Size(217, 26)
        Me.F_Bus_Pro.TabIndex = 2
        '
        'B_Pro
        '
        Me.B_Pro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.B_Pro.FormattingEnabled = True
        Me.B_Pro.Items.AddRange(New Object() {"cod_producto", "nombre", "marca", "descripcion", "precio", "cantidad", "cod_categoria", "precio_compra"})
        Me.B_Pro.Location = New System.Drawing.Point(15, 57)
        Me.B_Pro.Name = "B_Pro"
        Me.B_Pro.Size = New System.Drawing.Size(215, 27)
        Me.B_Pro.TabIndex = 1
        '
        'Busca_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 395)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Busca_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Vissual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents F_Bus_Pro As System.Windows.Forms.TextBox
    Friend WithEvents B_Pro As System.Windows.Forms.ComboBox
    Friend WithEvents Vissual As System.Windows.Forms.DataGridView
End Class
