Imports System.Data.SqlClient
Imports agenda_eléctronica

Public Class login

    Public Shared Function verificarutilizador_pass(username As String, password As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                'Call ligacaoBD.conectar()
                con.ConnectionString = ConnectionString_new
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM Utilizador WHERE utilizador = '" & username & "' and chave = '" & password & "'"
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

    Public Shared Function verificar_estado_utilizador(username As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                'Call ligacaoBD.conectar()
                con.ConnectionString = ConnectionString_new
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM utilizador WHERE utilizador = '" & username & "' and estado = 'desativo'"
                    con.Open()
                    Dim countreg As Integer = Integer.Parse(cmd.ExecuteScalar())
                    If countreg = 1 Then
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

    Public Shared Function verificar_tipo_utilizador(username As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                'Call ligacaoBD.conectar()
                con.ConnectionString = ConnectionString_new
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM utilizador WHERE utilizador = '" & username & "' and tipodeutilizador = 'Administrador'"
                    con.Open()
                    Dim countreg As Integer = Integer.Parse(cmd.ExecuteScalar())
                    If countreg = 1 Then
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
        lblLoginIncorreto.Visible = False

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
                'MsgBox("Utilizador inexistente")
                lblLoginIncorreto.Text = "O utilizador ou a password estão errados."
                lblLoginIncorreto.Visible = True
                txtpassword.Text = ""
                txtpassword.Focus()
                Exit Sub
            ElseIf verificar_estado_utilizador(txtutlizador.Text) = False Then
                'MsgBox("Utilizador encontra-se desativo.")
                lblLoginIncorreto.Text = "O utilizador encontra-se desativo."
                lblLoginIncorreto.Visible = True
                txtpassword.Text = ""
                txtpassword.Focus()
                Exit Sub
            Else
                If verificar_tipo_utilizador(txtutlizador.Text) = False Then
                    tipouser = "1"
                Else
                    tipouser = "0"
                End If
                'MsgBox(tipouser)
                user = txtutlizador.Text
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

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If AscW(e.KeyChar) = 13 Then
            lblUserObrigatorio.Visible = False
            lblPassObrigatorio.Visible = False
            lblLoginIncorreto.Visible = False

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
                    'MsgBox("Utilizador inexistente")
                    lblLoginIncorreto.Text = "O utilizador ou a password estão errados."
                    lblLoginIncorreto.Visible = True
                    txtpassword.Text = ""
                    txtpassword.Focus()
                    Exit Sub
                ElseIf verificar_estado_utilizador(txtutlizador.Text) = False Then
                    'MsgBox("Utilizador encontra-se desativo.")
                    lblLoginIncorreto.Text = "O utilizador encontra-se desativo."
                    lblLoginIncorreto.Visible = True
                    txtpassword.Text = ""
                    txtpassword.Focus()
                    Exit Sub
                Else
                    If verificar_tipo_utilizador(txtutlizador.Text) = False Then
                        tipouser = "1"
                    Else
                        tipouser = "0"
                    End If
                    'MsgBox(tipouser)
                    user = txtutlizador.Text
                    Me.Hide()
                    formulario_principal.Show()
                End If
            End If
        End If
    End Sub

End Class
