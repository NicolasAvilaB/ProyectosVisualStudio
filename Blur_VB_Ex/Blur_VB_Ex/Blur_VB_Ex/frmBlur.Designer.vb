<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlur))
        Me.picBlurDest = New System.Windows.Forms.PictureBox()
        Me.prgBlurProgress = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.btnBlur = New System.Windows.Forms.Button()
        Me.picBlurSource = New System.Windows.Forms.PictureBox()
        Me.chkAlphaEdges = New System.Windows.Forms.CheckBox()
        CType(Me.picBlurDest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlurSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBlurDest
        '
        Me.picBlurDest.Image = CType(resources.GetObject("picBlurDest.Image"), System.Drawing.Image)
        Me.picBlurDest.Location = New System.Drawing.Point(180, 12)
        Me.picBlurDest.Name = "picBlurDest"
        Me.picBlurDest.Size = New System.Drawing.Size(160, 160)
        Me.picBlurDest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlurDest.TabIndex = 9
        Me.picBlurDest.TabStop = False
        '
        'prgBlurProgress
        '
        Me.prgBlurProgress.Location = New System.Drawing.Point(12, 228)
        Me.prgBlurProgress.Name = "prgBlurProgress"
        Me.prgBlurProgress.Size = New System.Drawing.Size(328, 23)
        Me.prgBlurProgress.TabIndex = 7
        '
        'lblProgress
        '
        Me.lblProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProgress.Location = New System.Drawing.Point(12, 212)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(264, 23)
        Me.lblProgress.TabIndex = 8
        '
        'btnBlur
        '
        Me.btnBlur.Location = New System.Drawing.Point(12, 180)
        Me.btnBlur.Name = "btnBlur"
        Me.btnBlur.Size = New System.Drawing.Size(171, 23)
        Me.btnBlur.TabIndex = 6
        Me.btnBlur.Text = "Blur"
        '
        'picBlurSource
        '
        Me.picBlurSource.Image = CType(resources.GetObject("picBlurSource.Image"), System.Drawing.Image)
        Me.picBlurSource.Location = New System.Drawing.Point(12, 12)
        Me.picBlurSource.Name = "picBlurSource"
        Me.picBlurSource.Size = New System.Drawing.Size(160, 160)
        Me.picBlurSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlurSource.TabIndex = 5
        Me.picBlurSource.TabStop = False
        '
        'chkAlphaEdges
        '
        Me.chkAlphaEdges.AutoSize = True
        Me.chkAlphaEdges.Location = New System.Drawing.Point(189, 180)
        Me.chkAlphaEdges.Name = "chkAlphaEdges"
        Me.chkAlphaEdges.Size = New System.Drawing.Size(89, 17)
        Me.chkAlphaEdges.TabIndex = 10
        Me.chkAlphaEdges.Text = "AlphaEdges?"
        Me.chkAlphaEdges.UseVisualStyleBackColor = True
        '
        'frmBlur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 262)
        Me.Controls.Add(Me.chkAlphaEdges)
        Me.Controls.Add(Me.picBlurDest)
        Me.Controls.Add(Me.prgBlurProgress)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.btnBlur)
        Me.Controls.Add(Me.picBlurSource)
        Me.Name = "frmBlur"
        Me.Text = "Gaussian Blur VB.NET Example"
        CType(Me.picBlurDest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlurSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBlurDest As System.Windows.Forms.PictureBox
    Friend WithEvents prgBlurProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents btnBlur As System.Windows.Forms.Button
    Friend WithEvents picBlurSource As System.Windows.Forms.PictureBox
    Friend WithEvents chkAlphaEdges As System.Windows.Forms.CheckBox

End Class
