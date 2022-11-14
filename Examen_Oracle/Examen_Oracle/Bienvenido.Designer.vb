<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenido
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
        Me.Productos = New System.Windows.Forms.Button()
        Me.Venta = New System.Windows.Forms.Button()
        Me.Detalles_Venta = New System.Windows.Forms.Button()
        Me.Clientes = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Productos)
        Me.GroupBox1.Controls.Add(Me.Venta)
        Me.GroupBox1.Controls.Add(Me.Detalles_Venta)
        Me.GroupBox1.Controls.Add(Me.Clientes)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bienvenido"
        '
        'Productos
        '
        Me.Productos.Location = New System.Drawing.Point(216, 112)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(159, 47)
        Me.Productos.TabIndex = 3
        Me.Productos.Text = "Productos"
        Me.Productos.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.Venta.Location = New System.Drawing.Point(7, 112)
        Me.Venta.Name = "Venta"
        Me.Venta.Size = New System.Drawing.Size(159, 47)
        Me.Venta.TabIndex = 2
        Me.Venta.Text = "Ventas"
        Me.Venta.UseVisualStyleBackColor = True
        '
        'Detalles_Venta
        '
        Me.Detalles_Venta.Location = New System.Drawing.Point(215, 26)
        Me.Detalles_Venta.Name = "Detalles_Venta"
        Me.Detalles_Venta.Size = New System.Drawing.Size(159, 47)
        Me.Detalles_Venta.TabIndex = 1
        Me.Detalles_Venta.Text = "Detalles Ventas"
        Me.Detalles_Venta.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.Clientes.Location = New System.Drawing.Point(7, 26)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Size = New System.Drawing.Size(159, 47)
        Me.Clientes.TabIndex = 0
        Me.Clientes.Text = "Clientes"
        Me.Clientes.UseVisualStyleBackColor = True
        '
        'Bienvenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 198)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Bienvenido"
        Me.Text = "Examen Oracle"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Productos As System.Windows.Forms.Button
    Friend WithEvents Venta As System.Windows.Forms.Button
    Friend WithEvents Detalles_Venta As System.Windows.Forms.Button
    Friend WithEvents Clientes As System.Windows.Forms.Button

End Class
