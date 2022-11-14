<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAPTURA
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
        Me.PCAPTURA = New System.Windows.Forms.PictureBox()
        CType(Me.PCAPTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PCAPTURA
        '
        Me.PCAPTURA.Location = New System.Drawing.Point(0, 0)
        Me.PCAPTURA.Name = "PCAPTURA"
        Me.PCAPTURA.Size = New System.Drawing.Size(320, 240)
        Me.PCAPTURA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCAPTURA.TabIndex = 0
        Me.PCAPTURA.TabStop = False
        '
        'CAPTURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 241)
        Me.Controls.Add(Me.PCAPTURA)
        Me.Name = "CAPTURA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Captura"
        Me.TopMost = True
        CType(Me.PCAPTURA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PCAPTURA As System.Windows.Forms.PictureBox
End Class
