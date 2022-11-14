<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpresorasWindows
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
        Me.lblImpresoraPredeterminada = New System.Windows.Forms.Label()
        Me.lstImpresorasInstaladas = New System.Windows.Forms.ListBox()
        Me.txtImpresoraPredeterminada = New System.Windows.Forms.TextBox()
        Me.lblImpresorasInstaladas = New System.Windows.Forms.Label()
        Me.btnObtenerImpresorasInstaladas = New System.Windows.Forms.Button()
        Me.btnPredeterminarImpresora = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblImpresoraPredeterminada
        '
        Me.lblImpresoraPredeterminada.AutoSize = True
        Me.lblImpresoraPredeterminada.Location = New System.Drawing.Point(12, 163)
        Me.lblImpresoraPredeterminada.Name = "lblImpresoraPredeterminada"
        Me.lblImpresoraPredeterminada.Size = New System.Drawing.Size(129, 13)
        Me.lblImpresoraPredeterminada.TabIndex = 0
        Me.lblImpresoraPredeterminada.Text = "Impresora predeterminada"
        '
        'lstImpresorasInstaladas
        '
        Me.lstImpresorasInstaladas.FormattingEnabled = True
        Me.lstImpresorasInstaladas.Location = New System.Drawing.Point(12, 33)
        Me.lstImpresorasInstaladas.Name = "lstImpresorasInstaladas"
        Me.lstImpresorasInstaladas.Size = New System.Drawing.Size(202, 108)
        Me.lstImpresorasInstaladas.TabIndex = 1
        '
        'txtImpresoraPredeterminada
        '
        Me.txtImpresoraPredeterminada.Location = New System.Drawing.Point(15, 179)
        Me.txtImpresoraPredeterminada.Name = "txtImpresoraPredeterminada"
        Me.txtImpresoraPredeterminada.Size = New System.Drawing.Size(351, 20)
        Me.txtImpresoraPredeterminada.TabIndex = 2
        '
        'lblImpresorasInstaladas
        '
        Me.lblImpresorasInstaladas.AutoSize = True
        Me.lblImpresorasInstaladas.Location = New System.Drawing.Point(12, 17)
        Me.lblImpresorasInstaladas.Name = "lblImpresorasInstaladas"
        Me.lblImpresorasInstaladas.Size = New System.Drawing.Size(108, 13)
        Me.lblImpresorasInstaladas.TabIndex = 3
        Me.lblImpresorasInstaladas.Text = "Impresoras instaladas"
        '
        'btnObtenerImpresorasInstaladas
        '
        Me.btnObtenerImpresorasInstaladas.Location = New System.Drawing.Point(220, 33)
        Me.btnObtenerImpresorasInstaladas.Name = "btnObtenerImpresorasInstaladas"
        Me.btnObtenerImpresorasInstaladas.Size = New System.Drawing.Size(146, 42)
        Me.btnObtenerImpresorasInstaladas.TabIndex = 4
        Me.btnObtenerImpresorasInstaladas.Text = "Obtener impresoras instaladas"
        Me.btnObtenerImpresorasInstaladas.UseVisualStyleBackColor = True
        '
        'btnPredeterminarImpresora
        '
        Me.btnPredeterminarImpresora.Location = New System.Drawing.Point(220, 81)
        Me.btnPredeterminarImpresora.Name = "btnPredeterminarImpresora"
        Me.btnPredeterminarImpresora.Size = New System.Drawing.Size(146, 28)
        Me.btnPredeterminarImpresora.TabIndex = 5
        Me.btnPredeterminarImpresora.Text = "Predeterminar impresora"
        Me.btnPredeterminarImpresora.UseVisualStyleBackColor = True
        '
        'frmImpresorasWindows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 214)
        Me.Controls.Add(Me.btnPredeterminarImpresora)
        Me.Controls.Add(Me.btnObtenerImpresorasInstaladas)
        Me.Controls.Add(Me.lblImpresorasInstaladas)
        Me.Controls.Add(Me.txtImpresoraPredeterminada)
        Me.Controls.Add(Me.lstImpresorasInstaladas)
        Me.Controls.Add(Me.lblImpresoraPredeterminada)
        Me.Name = "frmImpresorasWindows"
        Me.Text = "Impresoras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblImpresoraPredeterminada As System.Windows.Forms.Label
    Friend WithEvents lstImpresorasInstaladas As System.Windows.Forms.ListBox
    Friend WithEvents txtImpresoraPredeterminada As System.Windows.Forms.TextBox
    Friend WithEvents lblImpresorasInstaladas As System.Windows.Forms.Label
    Friend WithEvents btnObtenerImpresorasInstaladas As System.Windows.Forms.Button
    Friend WithEvents btnPredeterminarImpresora As System.Windows.Forms.Button

End Class
