<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnLimpiar1 = New System.Windows.Forms.Button()
        Me.BtnLimpiar2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.BtnDerecha = New System.Windows.Forms.Button()
        Me.BtnDerechaTodos = New System.Windows.Forms.Button()
        Me.BtnIzquierda = New System.Windows.Forms.Button()
        Me.BtnIzquierdaTodos = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidad1 = New System.Windows.Forms.TextBox()
        Me.txtCantidad2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(6, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(156, 20)
        Me.txtNombre.TabIndex = 0
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(176, 25)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(135, 23)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "AGREGAR A LA LISTA"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar1
        '
        Me.BtnLimpiar1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar1.Location = New System.Drawing.Point(9, 76)
        Me.BtnLimpiar1.Name = "BtnLimpiar1"
        Me.BtnLimpiar1.Size = New System.Drawing.Size(108, 23)
        Me.BtnLimpiar1.TabIndex = 3
        Me.BtnLimpiar1.Text = "LIMPIAR LISTA 1"
        Me.BtnLimpiar1.UseVisualStyleBackColor = True
        '
        'BtnLimpiar2
        '
        Me.BtnLimpiar2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar2.Location = New System.Drawing.Point(211, 76)
        Me.BtnLimpiar2.Name = "BtnLimpiar2"
        Me.BtnLimpiar2.Size = New System.Drawing.Size(108, 23)
        Me.BtnLimpiar2.TabIndex = 4
        Me.BtnLimpiar2.Text = "LIMPIAR LISTA 2"
        Me.BtnLimpiar2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(5, 105)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 121)
        Me.ListBox1.TabIndex = 5
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(206, 105)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 121)
        Me.ListBox2.TabIndex = 6
        '
        'BtnDerecha
        '
        Me.BtnDerecha.Location = New System.Drawing.Point(144, 96)
        Me.BtnDerecha.Name = "BtnDerecha"
        Me.BtnDerecha.Size = New System.Drawing.Size(38, 30)
        Me.BtnDerecha.TabIndex = 7
        Me.BtnDerecha.Text = ">>"
        Me.BtnDerecha.UseVisualStyleBackColor = True
        '
        'BtnDerechaTodos
        '
        Me.BtnDerechaTodos.Location = New System.Drawing.Point(144, 132)
        Me.BtnDerechaTodos.Name = "BtnDerechaTodos"
        Me.BtnDerechaTodos.Size = New System.Drawing.Size(38, 30)
        Me.BtnDerechaTodos.TabIndex = 8
        Me.BtnDerechaTodos.Text = ">>l"
        Me.BtnDerechaTodos.UseVisualStyleBackColor = True
        '
        'BtnIzquierda
        '
        Me.BtnIzquierda.Location = New System.Drawing.Point(144, 168)
        Me.BtnIzquierda.Name = "BtnIzquierda"
        Me.BtnIzquierda.Size = New System.Drawing.Size(38, 30)
        Me.BtnIzquierda.TabIndex = 9
        Me.BtnIzquierda.Text = "<<"
        Me.BtnIzquierda.UseVisualStyleBackColor = True
        '
        'BtnIzquierdaTodos
        '
        Me.BtnIzquierdaTodos.Location = New System.Drawing.Point(144, 204)
        Me.BtnIzquierdaTodos.Name = "BtnIzquierdaTodos"
        Me.BtnIzquierdaTodos.Size = New System.Drawing.Size(38, 30)
        Me.BtnIzquierdaTodos.TabIndex = 10
        Me.BtnIzquierdaTodos.Text = "l<<"
        Me.BtnIzquierdaTodos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cantidad de Items"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cantidad de Items"
        '
        'txtCantidad1
        '
        Me.txtCantidad1.Location = New System.Drawing.Point(34, 272)
        Me.txtCantidad1.Name = "txtCantidad1"
        Me.txtCantidad1.Size = New System.Drawing.Size(36, 20)
        Me.txtCantidad1.TabIndex = 13
        '
        'txtCantidad2
        '
        Me.txtCantidad2.Location = New System.Drawing.Point(252, 272)
        Me.txtCantidad2.Name = "txtCantidad2"
        Me.txtCantidad2.Size = New System.Drawing.Size(36, 20)
        Me.txtCantidad2.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 58)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escriba el Nombre"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 304)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCantidad2)
        Me.Controls.Add(Me.txtCantidad1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnIzquierdaTodos)
        Me.Controls.Add(Me.BtnIzquierda)
        Me.Controls.Add(Me.BtnDerechaTodos)
        Me.Controls.Add(Me.BtnDerecha)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtnLimpiar2)
        Me.Controls.Add(Me.BtnLimpiar1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar1 As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar2 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents BtnDerecha As System.Windows.Forms.Button
    Friend WithEvents BtnDerechaTodos As System.Windows.Forms.Button
    Friend WithEvents BtnIzquierda As System.Windows.Forms.Button
    Friend WithEvents BtnIzquierdaTodos As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
