<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdSumar = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.rdDividir = New System.Windows.Forms.RadioButton()
        Me.rdMultiplicar = New System.Windows.Forms.RadioButton()
        Me.rdResta = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 2"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(87, 6)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 2
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(86, 39)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 3
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(86, 78)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado"
        '
        'rdSumar
        '
        Me.rdSumar.AutoSize = True
        Me.rdSumar.Location = New System.Drawing.Point(6, 19)
        Me.rdSumar.Name = "rdSumar"
        Me.rdSumar.Size = New System.Drawing.Size(55, 17)
        Me.rdSumar.TabIndex = 6
        Me.rdSumar.TabStop = True
        Me.rdSumar.Text = "Sumar"
        Me.rdSumar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalcular)
        Me.GroupBox1.Controls.Add(Me.rdDividir)
        Me.GroupBox1.Controls.Add(Me.rdMultiplicar)
        Me.GroupBox1.Controls.Add(Me.rdResta)
        Me.GroupBox1.Controls.Add(Me.rdSumar)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(71, 42)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'rdDividir
        '
        Me.rdDividir.AutoSize = True
        Me.rdDividir.Location = New System.Drawing.Point(146, 65)
        Me.rdDividir.Name = "rdDividir"
        Me.rdDividir.Size = New System.Drawing.Size(54, 17)
        Me.rdDividir.TabIndex = 9
        Me.rdDividir.TabStop = True
        Me.rdDividir.Text = "Dividir"
        Me.rdDividir.UseVisualStyleBackColor = True
        '
        'rdMultiplicar
        '
        Me.rdMultiplicar.AutoSize = True
        Me.rdMultiplicar.Location = New System.Drawing.Point(6, 65)
        Me.rdMultiplicar.Name = "rdMultiplicar"
        Me.rdMultiplicar.Size = New System.Drawing.Size(72, 17)
        Me.rdMultiplicar.TabIndex = 8
        Me.rdMultiplicar.TabStop = True
        Me.rdMultiplicar.Text = "Multiplicar"
        Me.rdMultiplicar.UseVisualStyleBackColor = True
        '
        'rdResta
        '
        Me.rdResta.AutoSize = True
        Me.rdResta.Location = New System.Drawing.Point(146, 19)
        Me.rdResta.Name = "rdResta"
        Me.rdResta.Size = New System.Drawing.Size(53, 17)
        Me.rdResta.TabIndex = 7
        Me.rdResta.TabStop = True
        Me.rdResta.Text = "Resta"
        Me.rdResta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 232)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdSumar As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdDividir As System.Windows.Forms.RadioButton
    Friend WithEvents rdMultiplicar As System.Windows.Forms.RadioButton
    Friend WithEvents rdResta As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalcular As System.Windows.Forms.Button

End Class
