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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ch_Motocicleta = New System.Windows.Forms.CheckBox()
        Me.Ch_Camion = New System.Windows.Forms.CheckBox()
        Me.Ch_Camioneta = New System.Windows.Forms.CheckBox()
        Me.Ch_Auto = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ch_Motocicleta)
        Me.GroupBox1.Controls.Add(Me.Ch_Camion)
        Me.GroupBox1.Controls.Add(Me.Ch_Camioneta)
        Me.GroupBox1.Controls.Add(Me.Ch_Auto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'Ch_Motocicleta
        '
        Me.Ch_Motocicleta.AutoSize = True
        Me.Ch_Motocicleta.Location = New System.Drawing.Point(141, 65)
        Me.Ch_Motocicleta.Name = "Ch_Motocicleta"
        Me.Ch_Motocicleta.Size = New System.Drawing.Size(87, 18)
        Me.Ch_Motocicleta.TabIndex = 3
        Me.Ch_Motocicleta.Text = "Motocicleta"
        Me.Ch_Motocicleta.UseVisualStyleBackColor = True
        '
        'Ch_Camion
        '
        Me.Ch_Camion.AutoSize = True
        Me.Ch_Camion.Location = New System.Drawing.Point(7, 65)
        Me.Ch_Camion.Name = "Ch_Camion"
        Me.Ch_Camion.Size = New System.Drawing.Size(66, 18)
        Me.Ch_Camion.TabIndex = 2
        Me.Ch_Camion.Text = "Camion"
        Me.Ch_Camion.UseVisualStyleBackColor = True
        '
        'Ch_Camioneta
        '
        Me.Ch_Camioneta.AutoSize = True
        Me.Ch_Camioneta.Location = New System.Drawing.Point(141, 20)
        Me.Ch_Camioneta.Name = "Ch_Camioneta"
        Me.Ch_Camioneta.Size = New System.Drawing.Size(82, 18)
        Me.Ch_Camioneta.TabIndex = 1
        Me.Ch_Camioneta.Text = "Camioneta"
        Me.Ch_Camioneta.UseVisualStyleBackColor = True
        '
        'Ch_Auto
        '
        Me.Ch_Auto.AutoSize = True
        Me.Ch_Auto.Location = New System.Drawing.Point(7, 20)
        Me.Ch_Auto.Name = "Ch_Auto"
        Me.Ch_Auto.Size = New System.Drawing.Size(81, 18)
        Me.Ch_Auto.TabIndex = 0
        Me.Ch_Auto.Text = "Automovil"
        Me.Ch_Auto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Items Seleccionados"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 203)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(228, 95)
        Me.ListBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ejercicio 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 309)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Ch_Motocicleta As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_Camion As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_Camioneta As System.Windows.Forms.CheckBox
    Friend WithEvents Ch_Auto As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
