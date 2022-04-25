Public Class login

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        lblUserObrigatorio.Visible = False
        lblPassObrigatorio.Visible = False

        If txtpassword.Text = "" Then
            lblPassObrigatorio.Visible = True
            txtpassword.Focus()
        End If

        If txtutlizador.Text = "" Then
            lblUserObrigatorio.Visible = True
            txtutlizador.Focus()
            Exit Sub
        End If

        If lblUserObrigatorio.Visible = False And lblPassObrigatorio.Visible = False Then
            formulario_principal.Show()
            'apenas na validação do login
            'lblLoginIncorreto.Visible = True
            Me.Hide()
        End If

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoginIncorreto.Visible = False
        lblPassObrigatorio.Visible = False
        lblUserObrigatorio.Visible = False

    End Sub
End Class
