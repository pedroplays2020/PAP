Imports System.Data.SqlClient
Public Class tempo

    Private Sub btnnovotempo_Click(sender As Object, e As EventArgs) Handles btnnovotempo.Click
        txttempo.Enabled = False
        txtintervalodetempo.Enabled = True
        btncancelartempo.Visible = True


    End Sub

    Private Sub btnguardartempo_Click(sender As Object, e As EventArgs) Handles btnguardartempo.Click
        Call conectar()
        Dim sql As String = "insert into Tempo values ( '" & RTrim(txtintervalodetempo.Text) & "')"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        Call desconectar()
        txttempo.Enabled = True
        If txttempo.Text = "" Then
            txttempo.Enabled = False
            txttempo.Focus()

        Else


        End If
        If txtintervalodetempo.Text = "" Then
            txtintervalodetempo.Focus()
        Else
            lblobrigatoriointervalodetempo.Visible = False






        End If
    End Sub

    Private Sub tempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblobrigatoriointervalodetempo.Visible = True
        btncancelartempo.Visible = False




    End Sub

    Private Sub btnsairtempo_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles btncancelartempo.Click
        txttempo.Clear()
        txtintervalodetempo.Clear()
        txtintervalodetempo.Enabled = False
    End Sub
End Class