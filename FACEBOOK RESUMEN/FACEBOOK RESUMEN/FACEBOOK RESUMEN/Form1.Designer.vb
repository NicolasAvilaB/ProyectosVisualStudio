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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TextBoxUSER = New System.Windows.Forms.TextBox()
        Me.TextBoxPASS = New System.Windows.Forms.TextBox()
        Me.ButtonINICIAR = New System.Windows.Forms.Button()
        Me.ButtonVER = New System.Windows.Forms.Button()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.TextBoxNOMBRE = New System.Windows.Forms.TextBox()
        Me.TextBoxSEXO = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxAPELLIDOS = New System.Windows.Forms.TextBox()
        Me.TextBoxUSUARIO = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(13, 240)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(270, 22)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowser1.Visible = False
        '
        'TextBoxUSER
        '
        Me.TextBoxUSER.BackColor = System.Drawing.Color.Black
        Me.TextBoxUSER.ForeColor = System.Drawing.Color.Cyan
        Me.TextBoxUSER.Location = New System.Drawing.Point(13, 12)
        Me.TextBoxUSER.Name = "TextBoxUSER"
        Me.TextBoxUSER.Size = New System.Drawing.Size(270, 22)
        Me.TextBoxUSER.TabIndex = 3
        Me.TextBoxUSER.Text = "CORREO ELECTRONICO"
        Me.TextBoxUSER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxPASS
        '
        Me.TextBoxPASS.BackColor = System.Drawing.Color.Black
        Me.TextBoxPASS.ForeColor = System.Drawing.Color.Cyan
        Me.TextBoxPASS.Location = New System.Drawing.Point(12, 40)
        Me.TextBoxPASS.Name = "TextBoxPASS"
        Me.TextBoxPASS.Size = New System.Drawing.Size(271, 22)
        Me.TextBoxPASS.TabIndex = 4
        Me.TextBoxPASS.Text = "CONTRASEÑA"
        Me.TextBoxPASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxPASS.UseSystemPasswordChar = True
        '
        'ButtonINICIAR
        '
        Me.ButtonINICIAR.BackColor = System.Drawing.Color.Black
        Me.ButtonINICIAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonINICIAR.Location = New System.Drawing.Point(73, 68)
        Me.ButtonINICIAR.Name = "ButtonINICIAR"
        Me.ButtonINICIAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonINICIAR.TabIndex = 5
        Me.ButtonINICIAR.Text = "INICIAR SESION"
        Me.ButtonINICIAR.UseVisualStyleBackColor = False
        '
        'ButtonVER
        '
        Me.ButtonVER.BackColor = System.Drawing.Color.Black
        Me.ButtonVER.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonVER.Location = New System.Drawing.Point(73, 167)
        Me.ButtonVER.Name = "ButtonVER"
        Me.ButtonVER.Size = New System.Drawing.Size(140, 40)
        Me.ButtonVER.TabIndex = 7
        Me.ButtonVER.Text = "VER"
        Me.ButtonVER.UseVisualStyleBackColor = False
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(322, 12)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(200, 200)
        Me.WebBrowser2.TabIndex = 8
        '
        'TextBoxNOMBRE
        '
        Me.TextBoxNOMBRE.BackColor = System.Drawing.Color.Black
        Me.TextBoxNOMBRE.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxNOMBRE.Location = New System.Drawing.Point(322, 268)
        Me.TextBoxNOMBRE.Name = "TextBoxNOMBRE"
        Me.TextBoxNOMBRE.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxNOMBRE.TabIndex = 10
        Me.TextBoxNOMBRE.Text = "NOMBRE"
        Me.TextBoxNOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxSEXO
        '
        Me.TextBoxSEXO.BackColor = System.Drawing.Color.Black
        Me.TextBoxSEXO.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxSEXO.Location = New System.Drawing.Point(322, 324)
        Me.TextBoxSEXO.Name = "TextBoxSEXO"
        Me.TextBoxSEXO.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxSEXO.TabIndex = 11
        Me.TextBoxSEXO.Text = "SEXO"
        Me.TextBoxSEXO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxID
        '
        Me.TextBoxID.BackColor = System.Drawing.Color.Black
        Me.TextBoxID.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxID.Location = New System.Drawing.Point(322, 240)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxID.TabIndex = 15
        Me.TextBoxID.Text = "ID"
        Me.TextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxAPELLIDOS
        '
        Me.TextBoxAPELLIDOS.BackColor = System.Drawing.Color.Black
        Me.TextBoxAPELLIDOS.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxAPELLIDOS.Location = New System.Drawing.Point(322, 296)
        Me.TextBoxAPELLIDOS.Name = "TextBoxAPELLIDOS"
        Me.TextBoxAPELLIDOS.Size = New System.Drawing.Size(250, 22)
        Me.TextBoxAPELLIDOS.TabIndex = 18
        Me.TextBoxAPELLIDOS.Text = "APELLIDOS"
        Me.TextBoxAPELLIDOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxUSUARIO
        '
        Me.TextBoxUSUARIO.BackColor = System.Drawing.Color.Black
        Me.TextBoxUSUARIO.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxUSUARIO.Location = New System.Drawing.Point(13, 139)
        Me.TextBoxUSUARIO.Name = "TextBoxUSUARIO"
        Me.TextBoxUSUARIO.Size = New System.Drawing.Size(270, 22)
        Me.TextBoxUSUARIO.TabIndex = 19
        Me.TextBoxUSUARIO.Text = "USUARIO"
        Me.TextBoxUSUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(598, 360)
        Me.Controls.Add(Me.TextBoxUSUARIO)
        Me.Controls.Add(Me.TextBoxAPELLIDOS)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.TextBoxSEXO)
        Me.Controls.Add(Me.TextBoxNOMBRE)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.ButtonVER)
        Me.Controls.Add(Me.ButtonINICIAR)
        Me.Controls.Add(Me.TextBoxPASS)
        Me.Controls.Add(Me.TextBoxUSER)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "FACEBOOK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TextBoxUSER As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPASS As System.Windows.Forms.TextBox
    Friend WithEvents ButtonINICIAR As System.Windows.Forms.Button
    Friend WithEvents ButtonVER As System.Windows.Forms.Button
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents TextBoxNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSEXO As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
