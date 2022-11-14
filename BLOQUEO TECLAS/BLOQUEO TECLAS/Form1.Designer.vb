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
        Me.ButtonALTTAB = New System.Windows.Forms.Button()
        Me.ButtonALTESC = New System.Windows.Forms.Button()
        Me.ButtonCTRLESC = New System.Windows.Forms.Button()
        Me.ButtonWIN = New System.Windows.Forms.Button()
        Me.ButtonTODAS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonALTTAB
        '
        Me.ButtonALTTAB.BackColor = System.Drawing.Color.Black
        Me.ButtonALTTAB.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonALTTAB.Location = New System.Drawing.Point(12, 12)
        Me.ButtonALTTAB.Name = "ButtonALTTAB"
        Me.ButtonALTTAB.Size = New System.Drawing.Size(140, 40)
        Me.ButtonALTTAB.TabIndex = 0
        Me.ButtonALTTAB.Text = "ALT+TAB"
        Me.ButtonALTTAB.UseVisualStyleBackColor = False
        '
        'ButtonALTESC
        '
        Me.ButtonALTESC.BackColor = System.Drawing.Color.Black
        Me.ButtonALTESC.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonALTESC.Location = New System.Drawing.Point(12, 73)
        Me.ButtonALTESC.Name = "ButtonALTESC"
        Me.ButtonALTESC.Size = New System.Drawing.Size(140, 40)
        Me.ButtonALTESC.TabIndex = 1
        Me.ButtonALTESC.Text = "ALT+ESC"
        Me.ButtonALTESC.UseVisualStyleBackColor = False
        '
        'ButtonCTRLESC
        '
        Me.ButtonCTRLESC.BackColor = System.Drawing.Color.Black
        Me.ButtonCTRLESC.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonCTRLESC.Location = New System.Drawing.Point(12, 134)
        Me.ButtonCTRLESC.Name = "ButtonCTRLESC"
        Me.ButtonCTRLESC.Size = New System.Drawing.Size(140, 40)
        Me.ButtonCTRLESC.TabIndex = 2
        Me.ButtonCTRLESC.Text = "CTRL+ESC"
        Me.ButtonCTRLESC.UseVisualStyleBackColor = False
        '
        'ButtonWIN
        '
        Me.ButtonWIN.BackColor = System.Drawing.Color.Black
        Me.ButtonWIN.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonWIN.Location = New System.Drawing.Point(12, 195)
        Me.ButtonWIN.Name = "ButtonWIN"
        Me.ButtonWIN.Size = New System.Drawing.Size(140, 40)
        Me.ButtonWIN.TabIndex = 3
        Me.ButtonWIN.Text = "WIN"
        Me.ButtonWIN.UseVisualStyleBackColor = False
        '
        'ButtonTODAS
        '
        Me.ButtonTODAS.BackColor = System.Drawing.Color.Black
        Me.ButtonTODAS.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonTODAS.Location = New System.Drawing.Point(12, 253)
        Me.ButtonTODAS.Name = "ButtonTODAS"
        Me.ButtonTODAS.Size = New System.Drawing.Size(140, 40)
        Me.ButtonTODAS.TabIndex = 4
        Me.ButtonTODAS.Text = "TODAS"
        Me.ButtonTODAS.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(168, 316)
        Me.Controls.Add(Me.ButtonTODAS)
        Me.Controls.Add(Me.ButtonWIN)
        Me.Controls.Add(Me.ButtonCTRLESC)
        Me.Controls.Add(Me.ButtonALTESC)
        Me.Controls.Add(Me.ButtonALTTAB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BLOQUEO TECLAS"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonALTTAB As System.Windows.Forms.Button
    Friend WithEvents ButtonALTESC As System.Windows.Forms.Button
    Friend WithEvents ButtonCTRLESC As System.Windows.Forms.Button
    Friend WithEvents ButtonWIN As System.Windows.Forms.Button
    Friend WithEvents ButtonTODAS As System.Windows.Forms.Button

End Class
