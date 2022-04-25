Imports System.Data.SqlClient
Public Class dias
    Dim botao As Integer


    Public Sub desbloqueardiasemana(ByVal estado As Boolean)
        chkListDiasSemana.Enabled = estado
        listboxDias.Enabled = estado

    End Sub

    Private Sub btnsairdiasdasemana_Click(sender As Object, e As EventArgs) Handles btnsairdiasdasemana.Click
        Me.Close()
    End Sub

    Private Sub btnovodiadasemana_Click(sender As Object, e As EventArgs) Handles btnovodiadasemana.Click
        Dim i As Integer

        desbloqueardiasemana(True)
        'chkListDiasSemana.ClearSelected()
        btnovodiadasemana.Enabled = False 
        btnsairdiasdasemana.Enabled = False
        btnguardardiasdasemana.Enabled = True
        btnsairdiasdasemana.Enabled = True
        btncancelardiasadasemana.Enabled = True
        chkListDiasSemana.Enabled = True
        btnsairdiasdasemana.Enabled = False
        'listboxDias.Items.Clear()
        For i = 0 To 6
            chkListDiasSemana.SetItemChecked(i, False)
        Next

        botao = 1
    End Sub

    Private Sub btnguardardiasdasemana_Click(sender As Object, e As EventArgs) Handles btnguardardiasdasemana.Click
        Dim total As Integer
        total = chkListDiasSemana.CheckedItems.Count

        If total <> 0 Then
            Dim x As Integer
            Dim s As String = ""

            'listboxDias.Items.Clear()
            For x = 0 To total - 1
                s = s & "Itens selecionados " & (x + 1).ToString & " = " & chkListDiasSemana.CheckedItems(x).ToString & ControlChars.CrLf
                listboxDias.Items.Add(chkListDiasSemana.CheckedItems(x))
                Call conectar()
                Dim sql1 As String = "insert into DiasSemana values ('" & RTrim(chkListDiasSemana.SelectedItem) & "')  "
                Dim sqlcom1 As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcom1.ExecuteReader
                Call desconectar()

            Next x
            MessageBox.Show(s)
            'lblobrobrigatoriodiasdasemana.ForeColor = Color.Red

            btnsairdiasdasemana.Enabled = True
            btncancelardiasadasemana.Enabled = False
            btnovodiadasemana.Enabled = True

            btnsairdiasdasemana.Enabled = True
            btnguardardiasdasemana.Enabled = False
            chkListDiasSemana.Enabled = False
        Else
            lblobrobrigatoriodiasdasemana.Visible = True
        End If
        ' ElseIf botao = 2 Then

        'Call conectar()
        'Dim sql1 As String = "update DiasSemana  set DiaSemana  = '" & txtdiaddsemana.Text & "' where idDiaSemana = '" &  & "'"
        'Dim sqlcon As New SqlCommand(sql1, con)
        'Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
        'dr1.Close()
        'Call desconectar()
        'lblobrobrigatoriodiasdasemana.ForeColor = Color.Red
        'lblobrobrigatoriodiasdasemana.Visible = True
        'btnsairdiasdasemana.Enabled = True
        'btncancelardiasadasemana.Enabled = True
        'End If

    End Sub

    Private Sub dias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desbloqueardiasemana(False)
        btnguardardiasdasemana.Enabled = False
        btncancelardiasadasemana.Enabled = False
        lblobrobrigatoriodiasdasemana.Visible = False
        desbloqueardiasemana(False)
    End Sub

    Private Sub btncancelardiasadasemana_Click(sender As Object, e As EventArgs) Handles btncancelardiasadasemana.Click
        btnovodiadasemana.Enabled = True
        btnguardardiasdasemana.Enabled = False
        btnsairdiasdasemana.Enabled = True
        btncancelardiasadasemana.Enabled = True
        listboxDias.Items.Clear()
        chkListDiasSemana.ClearSelected()
        chkListDiasSemana.Enabled = False

    End Sub

    Private Sub btneditardiadasemanana_Click(sender As Object, e As EventArgs)
        desbloqueardiasemana(True)
        btnovodiadasemana.Enabled = False
        btnsairdiasdasemana.Enabled = False
        btnguardardiasdasemana.Enabled = True
        btnsairdiasdasemana.Enabled = False
        btncancelardiasadasemana.Enabled = True
        chkListDiasSemana.Enabled = True
        botao = 2
    End Sub
End Class