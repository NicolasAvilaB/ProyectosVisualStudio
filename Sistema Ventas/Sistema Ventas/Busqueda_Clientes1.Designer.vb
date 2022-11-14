<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Clientes1
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
        Me.Visual = New System.Windows.Forms.DataGridView()
        Me.B_Clientes = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.F_Busc = New System.Windows.Forms.TextBox()
        CType(Me.Visual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Visual
        '
        Me.Visual.AllowUserToAddRows = False
        Me.Visual.AllowUserToDeleteRows = False
        Me.Visual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Visual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Visual.Location = New System.Drawing.Point(12, 108)
        Me.Visual.Name = "Visual"
        Me.Visual.ReadOnly = True
        Me.Visual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Visual.Size = New System.Drawing.Size(776, 213)
        Me.Visual.TabIndex = 0
        '
        'B_Clientes
        '
        Me.B_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.B_Clientes.FormattingEnabled = True
        Me.B_Clientes.Items.AddRange(New Object() {"rut", "nombre", "direccion", "telefono"})
        Me.B_Clientes.Location = New System.Drawing.Point(12, 56)
        Me.B_Clientes.Name = "B_Clientes"
        Me.B_Clientes.Size = New System.Drawing.Size(215, 27)
        Me.B_Clientes.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Visual)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.F_Busc)
        Me.GroupBox1.Controls.Add(Me.B_Clientes)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 338)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(519, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filtro De Busqueda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar Por Cliente:"
        '
        'F_Busc
        '
        Me.F_Busc.Location = New System.Drawing.Point(523, 56)
        Me.F_Busc.Name = "F_Busc"
        Me.F_Busc.Size = New System.Drawing.Size(265, 26)
        Me.F_Busc.TabIndex = 2
        '
        'Busqueda_Clientes1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 362)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Busqueda_Clientes1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Clientes"
        CType(Me.Visual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Visual As System.Windows.Forms.DataGridView
    Friend WithEvents B_Clientes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents F_Busc As System.Windows.Forms.TextBox
End Class
