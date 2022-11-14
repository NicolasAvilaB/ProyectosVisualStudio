<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinServidor
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
        Me.btnServerUpdate = New System.Windows.Forms.Button()
        Me.lblState = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Selec = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lstPanelMensajes = New System.Windows.Forms.ListView()
        Me.clmEvento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCountClientes = New System.Windows.Forms.Label()
        Me.btnTransData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnServerUpdate
        '
        Me.btnServerUpdate.Location = New System.Drawing.Point(12, 12)
        Me.btnServerUpdate.Name = "btnServerUpdate"
        Me.btnServerUpdate.Size = New System.Drawing.Size(126, 40)
        Me.btnServerUpdate.TabIndex = 0
        Me.btnServerUpdate.Text = "Iniciar Servidor"
        Me.btnServerUpdate.UseVisualStyleBackColor = True
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(219, 17)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(16, 13)
        Me.lblState.TabIndex = 1
        Me.lblState.Text = "..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Estado:"
        '
        'Selec
        '
        Me.Selec.HeaderText = "-"
        Me.Selec.Name = "Selec"
        Me.Selec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Selec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Selec.Width = 23
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "cod_P"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Codigo.Width = 90
        '
        'Descrip
        '
        Me.Descrip.DataPropertyName = "Descripcion"
        Me.Descrip.HeaderText = "Descripcion"
        Me.Descrip.Name = "Descrip"
        Me.Descrip.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descrip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Descrip.Width = 215
        '
        'lstPanelMensajes
        '
        Me.lstPanelMensajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPanelMensajes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmEvento})
        Me.lstPanelMensajes.Location = New System.Drawing.Point(12, 74)
        Me.lstPanelMensajes.Name = "lstPanelMensajes"
        Me.lstPanelMensajes.Size = New System.Drawing.Size(644, 414)
        Me.lstPanelMensajes.TabIndex = 13
        Me.lstPanelMensajes.UseCompatibleStateImageBehavior = False
        Me.lstPanelMensajes.View = System.Windows.Forms.View.Details
        '
        'clmEvento
        '
        Me.clmEvento.Text = "Eventos"
        Me.clmEvento.Width = 600
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Clientes:"
        '
        'lblCountClientes
        '
        Me.lblCountClientes.AutoSize = True
        Me.lblCountClientes.Location = New System.Drawing.Point(219, 39)
        Me.lblCountClientes.Name = "lblCountClientes"
        Me.lblCountClientes.Size = New System.Drawing.Size(13, 13)
        Me.lblCountClientes.TabIndex = 14
        Me.lblCountClientes.Text = "0"
        '
        'btnTransData
        '
        Me.btnTransData.Location = New System.Drawing.Point(530, 12)
        Me.btnTransData.Name = "btnTransData"
        Me.btnTransData.Size = New System.Drawing.Size(126, 40)
        Me.btnTransData.TabIndex = 16
        Me.btnTransData.Text = "Chat"
        Me.btnTransData.UseVisualStyleBackColor = True
        '
        'WinServidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 500)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnTransData)
        Me.Controls.Add(Me.lblCountClientes)
        Me.Controls.Add(Me.lstPanelMensajes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnServerUpdate)
        Me.Controls.Add(Me.lblState)
        Me.Name = "WinServidor"
        Me.Text = "Update system"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnServerUpdate As System.Windows.Forms.Button
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Selec As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lstPanelMensajes As System.Windows.Forms.ListView
    Friend WithEvents clmEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCountClientes As System.Windows.Forms.Label
    Friend WithEvents btnTransData As System.Windows.Forms.Button

End Class
