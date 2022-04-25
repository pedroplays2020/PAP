<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.txtutlizador = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblLoginIncorreto = New System.Windows.Forms.Label()
        Me.lblUserObrigatorio = New System.Windows.Forms.Label()
        Me.lblPassObrigatorio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtutlizador
        '
        Me.txtutlizador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtutlizador.Location = New System.Drawing.Point(680, 143)
        Me.txtutlizador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtutlizador.Name = "txtutlizador"
        Me.txtutlizador.Size = New System.Drawing.Size(199, 15)
        Me.txtutlizador.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Location = New System.Drawing.Point(680, 185)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(199, 15)
        Me.txtpassword.TabIndex = 2
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(676, 228)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 28)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(781, 228)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblLoginIncorreto
        '
        Me.lblLoginIncorreto.AutoSize = True
        Me.lblLoginIncorreto.ForeColor = System.Drawing.Color.Red
        Me.lblLoginIncorreto.Location = New System.Drawing.Point(645, 277)
        Me.lblLoginIncorreto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoginIncorreto.Name = "lblLoginIncorreto"
        Me.lblLoginIncorreto.Size = New System.Drawing.Size(272, 17)
        Me.lblLoginIncorreto.TabIndex = 6
        Me.lblLoginIncorreto.Text = "O utilizador ou a password estão errados."
        Me.lblLoginIncorreto.Visible = False
        '
        'lblUserObrigatorio
        '
        Me.lblUserObrigatorio.AutoSize = True
        Me.lblUserObrigatorio.ForeColor = System.Drawing.Color.Red
        Me.lblUserObrigatorio.Location = New System.Drawing.Point(836, 117)
        Me.lblUserObrigatorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserObrigatorio.Name = "lblUserObrigatorio"
        Me.lblUserObrigatorio.Size = New System.Drawing.Size(88, 17)
        Me.lblUserObrigatorio.TabIndex = 8
        Me.lblUserObrigatorio.Text = "* Obrigatório"
        Me.lblUserObrigatorio.Visible = False
        '
        'lblPassObrigatorio
        '
        Me.lblPassObrigatorio.AutoSize = True
        Me.lblPassObrigatorio.ForeColor = System.Drawing.Color.Red
        Me.lblPassObrigatorio.Location = New System.Drawing.Point(835, 166)
        Me.lblPassObrigatorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassObrigatorio.Name = "lblPassObrigatorio"
        Me.lblPassObrigatorio.Size = New System.Drawing.Size(88, 17)
        Me.lblPassObrigatorio.TabIndex = 9
        Me.lblPassObrigatorio.Text = "* Obrigatório"
        Me.lblPassObrigatorio.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.agenda_eléctronica.My.Resources.Resources.LOGIN_PEDRO1
        Me.ClientSize = New System.Drawing.Size(929, 368)
        Me.Controls.Add(Me.lblPassObrigatorio)
        Me.Controls.Add(Me.lblUserObrigatorio)
        Me.Controls.Add(Me.lblLoginIncorreto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtutlizador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtutlizador As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblLoginIncorreto As System.Windows.Forms.Label
    Friend WithEvents lblUserObrigatorio As System.Windows.Forms.Label
    Friend WithEvents lblPassObrigatorio As System.Windows.Forms.Label
End Class
