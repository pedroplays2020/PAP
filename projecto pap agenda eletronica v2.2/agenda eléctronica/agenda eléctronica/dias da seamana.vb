Imports System.Data.SqlClient
Public Class dias_da_seamana
    Private Sub btnovodiadasemana_Click(sender As Object, e As EventArgs) Handles btnovodiadasemana.Click
        txtnundiadasemana.Enabled = True
        txtdiadasemana.Enabled = True

    End Sub

    Private Sub dias_da_seamana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblibrigatorionundiadasemana.Visible = True
        lblobrobrigatoriodiasdasemana.Visible = True


    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Call conectar()
        Dim sql As String = "insert into DiasSemana values ( '" & RTrim(txtdiadasemana.Text) & "')"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        Call desconectar()
        txtnundiadasemana.Enabled = True
        If txtnundiadasemana.Text = "" Then
            txtnundiadasemana.Focus()
        Else
            lblibrigatorionundiadasemana.Visible = False
        End If
        If txtnundiadasemana.Text = "" Then
        Else
            lblobrobrigatoriodiasdasemana.Visible = False
        End If
    End Sub
End Class