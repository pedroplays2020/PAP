Imports System.Data.SqlClient
Imports agenda_eléctronica

Public Class login

    Shared ConnectionString As String = "Data Source=.\;Initial Catalog=Agenda;Integrated Security=True"
    Public Shared Function verificarutilizador_pass(username As String, password As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                'Call ligacaoBD.conectar()
                con.ConnectionString = ConnectionString
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM utilizador WHERE utilizador = '" & username & "' and chave = '" & password & "'"
                    con.Open()
                    Dim countreg As Integer = Integer.Parse(cmd.ExecuteScalar())
                    If countreg = 0 Then
                        Return False
                    End If
                End Using
            End Using
        Catch ex As SqlException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
        Return True

        'Call desconectar()
    End Function




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
            'formulario_principal.Show()
            'apenas na validação do login
            If verificarutilizador_pass(txtutlizador.Text, txtpassword.Text) = False Then
                MsgBox("Utilizador inexistente")
                txtpassword.Text = ""
                txtpassword.Focus()
                Exit Sub
            Else
                'lblLoginIncorreto.Visible = True
                Me.Hide()
                formulario_principal.Show()
            End If

        End If

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoginIncorreto.Visible = False
        lblPassObrigatorio.Visible = False
        lblUserObrigatorio.Visible = False

    End Sub
End Class
