<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonIZQUIERDA = New System.Windows.Forms.Button()
        Me.ButtonCENTRO = New System.Windows.Forms.Button()
        Me.ButtonDERECHA = New System.Windows.Forms.Button()
        Me.ButtonJUSTIFICAR = New System.Windows.Forms.Button()
        Me.AdvRichTextBox1 = New RTB_JUSTIFICAR.AdvRichTextBox()
        Me.SuspendLayout()
        '
        'ButtonIZQUIERDA
        '
        Me.ButtonIZQUIERDA.BackColor = System.Drawing.Color.Black
        Me.ButtonIZQUIERDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIZQUIERDA.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonIZQUIERDA.Location = New System.Drawing.Point(13, 602)
        Me.ButtonIZQUIERDA.Name = "ButtonIZQUIERDA"
        Me.ButtonIZQUIERDA.Size = New System.Drawing.Size(120, 43)
        Me.ButtonIZQUIERDA.TabIndex = 1
        Me.ButtonIZQUIERDA.Text = "IZQUIERDA"
        Me.ButtonIZQUIERDA.UseVisualStyleBackColor = False
        '
        'ButtonCENTRO
        '
        Me.ButtonCENTRO.BackColor = System.Drawing.Color.Black
        Me.ButtonCENTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCENTRO.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonCENTRO.Location = New System.Drawing.Point(183, 602)
        Me.ButtonCENTRO.Name = "ButtonCENTRO"
        Me.ButtonCENTRO.Size = New System.Drawing.Size(120, 43)
        Me.ButtonCENTRO.TabIndex = 2
        Me.ButtonCENTRO.Text = "CENTRO"
        Me.ButtonCENTRO.UseVisualStyleBackColor = False
        '
        'ButtonDERECHA
        '
        Me.ButtonDERECHA.BackColor = System.Drawing.Color.Black
        Me.ButtonDERECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDERECHA.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonDERECHA.Location = New System.Drawing.Point(352, 602)
        Me.ButtonDERECHA.Name = "ButtonDERECHA"
        Me.ButtonDERECHA.Size = New System.Drawing.Size(120, 43)
        Me.ButtonDERECHA.TabIndex = 3
        Me.ButtonDERECHA.Text = "DERECHA"
        Me.ButtonDERECHA.UseVisualStyleBackColor = False
        '
        'ButtonJUSTIFICAR
        '
        Me.ButtonJUSTIFICAR.BackColor = System.Drawing.Color.Black
        Me.ButtonJUSTIFICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJUSTIFICAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonJUSTIFICAR.Location = New System.Drawing.Point(521, 602)
        Me.ButtonJUSTIFICAR.Name = "ButtonJUSTIFICAR"
        Me.ButtonJUSTIFICAR.Size = New System.Drawing.Size(120, 43)
        Me.ButtonJUSTIFICAR.TabIndex = 4
        Me.ButtonJUSTIFICAR.Text = "JUSTIFICAR"
        Me.ButtonJUSTIFICAR.UseVisualStyleBackColor = False
        '
        'AdvRichTextBox1
        '
        Me.AdvRichTextBox1.BackColor = System.Drawing.Color.Navy
        Me.AdvRichTextBox1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdvRichTextBox1.ForeColor = System.Drawing.Color.Yellow
        Me.AdvRichTextBox1.Location = New System.Drawing.Point(13, 13)
        Me.AdvRichTextBox1.Name = "AdvRichTextBox1"
        Me.AdvRichTextBox1.SelectionAlignment = RTB_JUSTIFICAR.TextAlign.Left
        Me.AdvRichTextBox1.Size = New System.Drawing.Size(628, 583)
        Me.AdvRichTextBox1.TabIndex = 0
        Me.AdvRichTextBox1.Text = resources.GetString("AdvRichTextBox1.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(662, 673)
        Me.Controls.Add(Me.ButtonJUSTIFICAR)
        Me.Controls.Add(Me.ButtonDERECHA)
        Me.Controls.Add(Me.ButtonCENTRO)
        Me.Controls.Add(Me.ButtonIZQUIERDA)
        Me.Controls.Add(Me.AdvRichTextBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RTB JUSTIFICAR TEXTO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdvRichTextBox1 As RTB_JUSTIFICAR.AdvRichTextBox
    Friend WithEvents ButtonIZQUIERDA As System.Windows.Forms.Button
    Friend WithEvents ButtonCENTRO As System.Windows.Forms.Button
    Friend WithEvents ButtonDERECHA As System.Windows.Forms.Button
    Friend WithEvents ButtonJUSTIFICAR As System.Windows.Forms.Button

End Class
