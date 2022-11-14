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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ButtonCONECTAR = New System.Windows.Forms.Button()
        Me.TextBoxNUMERO = New System.Windows.Forms.TextBox()
        Me.ButtonENVIAR = New System.Windows.Forms.Button()
        Me.TextBoxTEXTO = New System.Windows.Forms.TextBox()
        Me.TextBoxPUERTO = New System.Windows.Forms.TextBox()
        Me.LabelRESTO = New System.Windows.Forms.Label()
        Me.TextBoxMODEM = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'ButtonCONECTAR
        '
        Me.ButtonCONECTAR.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonCONECTAR.ForeColor = System.Drawing.Color.Black
        Me.ButtonCONECTAR.Location = New System.Drawing.Point(101, 40)
        Me.ButtonCONECTAR.Name = "ButtonCONECTAR"
        Me.ButtonCONECTAR.Size = New System.Drawing.Size(100, 40)
        Me.ButtonCONECTAR.TabIndex = 1
        Me.ButtonCONECTAR.Text = "CONECTAR"
        Me.ButtonCONECTAR.UseVisualStyleBackColor = False
        '
        'TextBoxNUMERO
        '
        Me.TextBoxNUMERO.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxNUMERO.ForeColor = System.Drawing.Color.Black
        Me.TextBoxNUMERO.Location = New System.Drawing.Point(12, 96)
        Me.TextBoxNUMERO.Name = "TextBoxNUMERO"
        Me.TextBoxNUMERO.Size = New System.Drawing.Size(281, 22)
        Me.TextBoxNUMERO.TabIndex = 2
        Me.TextBoxNUMERO.Text = "NUMERO TELEFONO SIN PREFIJO"
        Me.TextBoxNUMERO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonENVIAR
        '
        Me.ButtonENVIAR.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonENVIAR.ForeColor = System.Drawing.Color.Black
        Me.ButtonENVIAR.Location = New System.Drawing.Point(101, 228)
        Me.ButtonENVIAR.Name = "ButtonENVIAR"
        Me.ButtonENVIAR.Size = New System.Drawing.Size(100, 40)
        Me.ButtonENVIAR.TabIndex = 3
        Me.ButtonENVIAR.Text = "ENVIAR"
        Me.ButtonENVIAR.UseVisualStyleBackColor = False
        '
        'TextBoxTEXTO
        '
        Me.TextBoxTEXTO.BackColor = System.Drawing.Color.White
        Me.TextBoxTEXTO.ForeColor = System.Drawing.Color.Black
        Me.TextBoxTEXTO.Location = New System.Drawing.Point(12, 124)
        Me.TextBoxTEXTO.Multiline = True
        Me.TextBoxTEXTO.Name = "TextBoxTEXTO"
        Me.TextBoxTEXTO.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxTEXTO.Size = New System.Drawing.Size(281, 98)
        Me.TextBoxTEXTO.TabIndex = 4
        '
        'TextBoxPUERTO
        '
        Me.TextBoxPUERTO.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxPUERTO.ForeColor = System.Drawing.Color.Black
        Me.TextBoxPUERTO.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxPUERTO.Name = "TextBoxPUERTO"
        Me.TextBoxPUERTO.Size = New System.Drawing.Size(281, 22)
        Me.TextBoxPUERTO.TabIndex = 5
        Me.TextBoxPUERTO.Text = "COM3"
        Me.TextBoxPUERTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelRESTO
        '
        Me.LabelRESTO.AutoSize = True
        Me.LabelRESTO.ForeColor = System.Drawing.Color.Yellow
        Me.LabelRESTO.Location = New System.Drawing.Point(261, 228)
        Me.LabelRESTO.Name = "LabelRESTO"
        Me.LabelRESTO.Size = New System.Drawing.Size(32, 16)
        Me.LabelRESTO.TabIndex = 6
        Me.LabelRESTO.Text = "140"
        '
        'TextBoxMODEM
        '
        Me.TextBoxMODEM.BackColor = System.Drawing.Color.White
        Me.TextBoxMODEM.ForeColor = System.Drawing.Color.Black
        Me.TextBoxMODEM.Location = New System.Drawing.Point(341, 12)
        Me.TextBoxMODEM.Multiline = True
        Me.TextBoxMODEM.Name = "TextBoxMODEM"
        Me.TextBoxMODEM.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxMODEM.Size = New System.Drawing.Size(276, 256)
        Me.TextBoxMODEM.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(635, 278)
        Me.Controls.Add(Me.TextBoxMODEM)
        Me.Controls.Add(Me.LabelRESTO)
        Me.Controls.Add(Me.TextBoxPUERTO)
        Me.Controls.Add(Me.TextBoxTEXTO)
        Me.Controls.Add(Me.ButtonENVIAR)
        Me.Controls.Add(Me.TextBoxNUMERO)
        Me.Controls.Add(Me.ButtonCONECTAR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENVIA SMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ButtonCONECTAR As System.Windows.Forms.Button
    Friend WithEvents TextBoxNUMERO As System.Windows.Forms.TextBox
    Friend WithEvents ButtonENVIAR As System.Windows.Forms.Button
    Friend WithEvents TextBoxTEXTO As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPUERTO As System.Windows.Forms.TextBox
    Friend WithEvents LabelRESTO As System.Windows.Forms.Label
    Friend WithEvents TextBoxMODEM As System.Windows.Forms.TextBox

End Class
