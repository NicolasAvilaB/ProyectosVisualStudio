<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionCliente
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Seleccionar = New System.Windows.Forms.Button()
        Me.GrillaBusca = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Valor_Busqueda = New System.Windows.Forms.TextBox()
        Me.Reserv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Modo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Seleccionar)
        Me.GroupBox1.Controls.Add(Me.GrillaBusca)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Valor_Busqueda)
        Me.GroupBox1.Controls.Add(Me.Reserv)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Modo)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 361)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Cliente"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(381, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 33)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Seleccionar
        '
        Me.Seleccionar.Location = New System.Drawing.Point(20, 312)
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Size = New System.Drawing.Size(187, 33)
        Me.Seleccionar.TabIndex = 6
        Me.Seleccionar.Text = "Seleccione"
        Me.Seleccionar.UseVisualStyleBackColor = True
        '
        'GrillaBusca
        '
        Me.GrillaBusca.AllowUserToAddRows = False
        Me.GrillaBusca.AllowUserToDeleteRows = False
        Me.GrillaBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaBusca.Location = New System.Drawing.Point(20, 155)
        Me.GrillaBusca.Name = "GrillaBusca"
        Me.GrillaBusca.ReadOnly = True
        Me.GrillaBusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaBusca.Size = New System.Drawing.Size(548, 150)
        Me.GrillaBusca.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Valor de Busqueda"
        '
        'Valor_Busqueda
        '
        Me.Valor_Busqueda.Location = New System.Drawing.Point(20, 123)
        Me.Valor_Busqueda.Name = "Valor_Busqueda"
        Me.Valor_Busqueda.Size = New System.Drawing.Size(239, 26)
        Me.Valor_Busqueda.TabIndex = 3
        '
        'Reserv
        '
        Me.Reserv.Enabled = False
        Me.Reserv.Location = New System.Drawing.Point(413, 37)
        Me.Reserv.Name = "Reserv"
        Me.Reserv.ReadOnly = True
        Me.Reserv.Size = New System.Drawing.Size(155, 26)
        Me.Reserv.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "N° Reserva"
        '
        'Modo
        '
        Me.Modo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Modo.FormattingEnabled = True
        Me.Modo.Items.AddRange(New Object() {"Rut", "Nombre", "Direccion", "Telefono"})
        Me.Modo.Location = New System.Drawing.Point(20, 36)
        Me.Modo.Name = "Modo"
        Me.Modo.Size = New System.Drawing.Size(239, 27)
        Me.Modo.TabIndex = 0
        '
        'SeleccionCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 382)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SeleccionCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrillaBusca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrillaBusca As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Valor_Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Reserv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Modo As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Seleccionar As System.Windows.Forms.Button
End Class
