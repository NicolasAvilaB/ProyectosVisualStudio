<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinUpdateClient
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
        Me.btnClient = New System.Windows.Forms.Button()
        Me.btnMsg = New System.Windows.Forms.Button()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.lstPanelMensajes = New System.Windows.Forms.ListView()
        Me.clmEvento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.btnSendFile = New System.Windows.Forms.Button()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pgbLoadFile = New System.Windows.Forms.ProgressBar()
        Me.lblLoadFile = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClient
        '
        Me.btnClient.Location = New System.Drawing.Point(12, 12)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(99, 47)
        Me.btnClient.TabIndex = 0
        Me.btnClient.Text = "Conectar"
        Me.btnClient.UseVisualStyleBackColor = True
        '
        'btnMsg
        '
        Me.btnMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMsg.Location = New System.Drawing.Point(484, 323)
        Me.btnMsg.Name = "btnMsg"
        Me.btnMsg.Size = New System.Drawing.Size(75, 55)
        Me.btnMsg.TabIndex = 3
        Me.btnMsg.Text = "Enviar"
        Me.btnMsg.UseVisualStyleBackColor = True
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.Location = New System.Drawing.Point(12, 323)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(466, 55)
        Me.txtMensaje.TabIndex = 4
        '
        'lstPanelMensajes
        '
        Me.lstPanelMensajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPanelMensajes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmEvento})
        Me.lstPanelMensajes.Location = New System.Drawing.Point(12, 110)
        Me.lstPanelMensajes.Name = "lstPanelMensajes"
        Me.lstPanelMensajes.Size = New System.Drawing.Size(547, 207)
        Me.lstPanelMensajes.TabIndex = 14
        Me.lstPanelMensajes.UseCompatibleStateImageBehavior = False
        Me.lstPanelMensajes.View = System.Windows.Forms.View.Details
        '
        'clmEvento
        '
        Me.clmEvento.Text = "Eventos"
        Me.clmEvento.Width = 535
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.Location = New System.Drawing.Point(117, 86)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(16, 13)
        Me.lblArchivo.TabIndex = 24
        Me.lblArchivo.Text = "..."
        '
        'btnSendFile
        '
        Me.btnSendFile.Location = New System.Drawing.Point(12, 81)
        Me.btnSendFile.Name = "btnSendFile"
        Me.btnSendFile.Size = New System.Drawing.Size(99, 23)
        Me.btnSendFile.TabIndex = 23
        Me.btnSendFile.Text = "Enviar Archivo"
        Me.btnSendFile.UseVisualStyleBackColor = True
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(196, 16)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(100, 20)
        Me.txtIP.TabIndex = 27
        Me.txtIP.Text = "192.168.1.50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "IP Publica:"
        '
        'pgbLoadFile
        '
        Me.pgbLoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgbLoadFile.Location = New System.Drawing.Point(387, 81)
        Me.pgbLoadFile.Name = "pgbLoadFile"
        Me.pgbLoadFile.Size = New System.Drawing.Size(172, 23)
        Me.pgbLoadFile.TabIndex = 29
        Me.pgbLoadFile.Visible = False
        '
        'lblLoadFile
        '
        Me.lblLoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoadFile.AutoSize = True
        Me.lblLoadFile.Location = New System.Drawing.Point(384, 65)
        Me.lblLoadFile.Name = "lblLoadFile"
        Me.lblLoadFile.Size = New System.Drawing.Size(16, 13)
        Me.lblLoadFile.TabIndex = 30
        Me.lblLoadFile.Text = "..."
        Me.lblLoadFile.Visible = False
        '
        'WinUpdateClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 390)
        Me.Controls.Add(Me.lblLoadFile)
        Me.Controls.Add(Me.pgbLoadFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.lblArchivo)
        Me.Controls.Add(Me.btnSendFile)
        Me.Controls.Add(Me.lstPanelMensajes)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.btnMsg)
        Me.Controls.Add(Me.btnClient)
        Me.Name = "WinUpdateClient"
        Me.Text = "Update client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClient As System.Windows.Forms.Button
    Friend WithEvents btnMsg As System.Windows.Forms.Button
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents lstPanelMensajes As System.Windows.Forms.ListView
    Friend WithEvents clmEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblArchivo As System.Windows.Forms.Label
    Friend WithEvents btnSendFile As System.Windows.Forms.Button
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pgbLoadFile As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLoadFile As System.Windows.Forms.Label

End Class
