<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinChat
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
        Me.lstPanelMensajes = New System.Windows.Forms.ListView()
        Me.clmEvento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.btnMsg = New System.Windows.Forms.Button()
        Me.btnSendFile = New System.Windows.Forms.Button()
        Me.dtgClientes = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.chbAll = New System.Windows.Forms.CheckBox()
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.lblLoadFile = New System.Windows.Forms.Label()
        Me.pgbLoadFile = New System.Windows.Forms.ProgressBar()
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstPanelMensajes
        '
        Me.lstPanelMensajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPanelMensajes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmEvento})
        Me.lstPanelMensajes.Location = New System.Drawing.Point(12, 31)
        Me.lstPanelMensajes.Name = "lstPanelMensajes"
        Me.lstPanelMensajes.Size = New System.Drawing.Size(481, 230)
        Me.lstPanelMensajes.TabIndex = 17
        Me.lstPanelMensajes.UseCompatibleStateImageBehavior = False
        Me.lstPanelMensajes.View = System.Windows.Forms.View.Details
        '
        'clmEvento
        '
        Me.clmEvento.Text = "Eventos"
        Me.clmEvento.Width = 469
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(12, 267)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(401, 46)
        Me.txtMensaje.TabIndex = 16
        '
        'btnMsg
        '
        Me.btnMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMsg.Location = New System.Drawing.Point(418, 267)
        Me.btnMsg.Name = "btnMsg"
        Me.btnMsg.Size = New System.Drawing.Size(75, 46)
        Me.btnMsg.TabIndex = 15
        Me.btnMsg.Text = "Enviar"
        Me.btnMsg.UseVisualStyleBackColor = True
        '
        'btnSendFile
        '
        Me.btnSendFile.Location = New System.Drawing.Point(12, 6)
        Me.btnSendFile.Name = "btnSendFile"
        Me.btnSendFile.Size = New System.Drawing.Size(99, 23)
        Me.btnSendFile.TabIndex = 18
        Me.btnSendFile.Text = "Enviar Archivo"
        Me.btnSendFile.UseVisualStyleBackColor = True
        '
        'dtgClientes
        '
        Me.dtgClientes.AllowUserToAddRows = False
        Me.dtgClientes.AllowUserToResizeRows = False
        Me.dtgClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgClientes.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dtgClientes.Location = New System.Drawing.Point(496, 31)
        Me.dtgClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.dtgClientes.MultiSelect = False
        Me.dtgClientes.Name = "dtgClientes"
        Me.dtgClientes.ReadOnly = True
        Me.dtgClientes.RowHeadersVisible = False
        Me.dtgClientes.RowHeadersWidth = 4
        Me.dtgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgClientes.Size = New System.Drawing.Size(332, 282)
        Me.dtgClientes.TabIndex = 19
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(729, 6)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(99, 23)
        Me.btnActualizar.TabIndex = 20
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'chbAll
        '
        Me.chbAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbAll.AutoSize = True
        Me.chbAll.Location = New System.Drawing.Point(496, 11)
        Me.chbAll.Name = "chbAll"
        Me.chbAll.Size = New System.Drawing.Size(153, 17)
        Me.chbAll.TabIndex = 21
        Me.chbAll.Text = "Afectar a todos los clientes"
        Me.chbAll.UseVisualStyleBackColor = True
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.Location = New System.Drawing.Point(117, 11)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(16, 13)
        Me.lblArchivo.TabIndex = 22
        Me.lblArchivo.Text = "..."
        '
        'lblLoadFile
        '
        Me.lblLoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoadFile.AutoSize = True
        Me.lblLoadFile.Location = New System.Drawing.Point(256, 11)
        Me.lblLoadFile.Name = "lblLoadFile"
        Me.lblLoadFile.Size = New System.Drawing.Size(16, 13)
        Me.lblLoadFile.TabIndex = 32
        Me.lblLoadFile.Text = "..."
        Me.lblLoadFile.Visible = False
        '
        'pgbLoadFile
        '
        Me.pgbLoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgbLoadFile.Location = New System.Drawing.Point(321, 5)
        Me.pgbLoadFile.Name = "pgbLoadFile"
        Me.pgbLoadFile.Size = New System.Drawing.Size(172, 23)
        Me.pgbLoadFile.TabIndex = 31
        Me.pgbLoadFile.Visible = False
        '
        'WinChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 319)
        Me.Controls.Add(Me.lblLoadFile)
        Me.Controls.Add(Me.pgbLoadFile)
        Me.Controls.Add(Me.lblArchivo)
        Me.Controls.Add(Me.chbAll)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.dtgClientes)
        Me.Controls.Add(Me.btnSendFile)
        Me.Controls.Add(Me.lstPanelMensajes)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.btnMsg)
        Me.Name = "WinChat"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction data"
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPanelMensajes As System.Windows.Forms.ListView
    Friend WithEvents clmEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents btnMsg As System.Windows.Forms.Button
    Friend WithEvents btnSendFile As System.Windows.Forms.Button
    Friend WithEvents dtgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents chbAll As System.Windows.Forms.CheckBox
    Friend WithEvents lblArchivo As System.Windows.Forms.Label
    Friend WithEvents lblLoadFile As System.Windows.Forms.Label
    Friend WithEvents pgbLoadFile As System.Windows.Forms.ProgressBar
End Class
