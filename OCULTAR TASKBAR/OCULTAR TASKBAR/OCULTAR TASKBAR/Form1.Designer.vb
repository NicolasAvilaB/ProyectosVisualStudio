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
        Me.ButtonOCULTA = New System.Windows.Forms.Button()
        Me.ButtonMUESTRA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonOCULTA
        '
        Me.ButtonOCULTA.BackColor = System.Drawing.Color.Black
        Me.ButtonOCULTA.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonOCULTA.Location = New System.Drawing.Point(12, 12)
        Me.ButtonOCULTA.Name = "ButtonOCULTA"
        Me.ButtonOCULTA.Size = New System.Drawing.Size(140, 40)
        Me.ButtonOCULTA.TabIndex = 0
        Me.ButtonOCULTA.Text = "OCULTA"
        Me.ButtonOCULTA.UseVisualStyleBackColor = False
        '
        'ButtonMUESTRA
        '
        Me.ButtonMUESTRA.BackColor = System.Drawing.Color.Black
        Me.ButtonMUESTRA.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonMUESTRA.Location = New System.Drawing.Point(12, 58)
        Me.ButtonMUESTRA.Name = "ButtonMUESTRA"
        Me.ButtonMUESTRA.Size = New System.Drawing.Size(140, 40)
        Me.ButtonMUESTRA.TabIndex = 1
        Me.ButtonMUESTRA.Text = "MUESTRA"
        Me.ButtonMUESTRA.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(163, 112)
        Me.Controls.Add(Me.ButtonMUESTRA)
        Me.Controls.Add(Me.ButtonOCULTA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BARRA TAREAS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonOCULTA As System.Windows.Forms.Button
    Friend WithEvents ButtonMUESTRA As System.Windows.Forms.Button

End Class
