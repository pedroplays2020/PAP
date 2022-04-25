Imports System.Data.SqlClient
Public Class dias_da_seamana
    Dim botao As Integer
    Public Sub desbloqueardiasemmana(ByVal estadodiasemana As Boolean)
        txtnundiadasemana.Enabled = estadodiasemana
        txtdiadasemana.Enabled = estadodiasemana

    End Sub

    Public Sub ativar_diasdasemana(ByVal estadodiasemana As Boolean)

        lblobrobrigatoriodiasdasemana.Enabled = estadodiasemana

    End Sub

    Public Sub consdiadasemana()
        Call conectar()
        Dim sql As String = "select * from DiasSemana"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        Datagriddiasdasemana.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        Dim k As Integer
        'Dim campo As String
        For k = 0 To n - 1
            'campo = dr.GetName(k)
            Datagriddiasdasemana.Columns.Add("Código", "Descrição")
        Next
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            Datagriddiasdasemana.Rows.Add(linha)
            Datagriddiasdasemana.Rows(i).Cells(0).Value = dr.Item(0)
            Datagriddiasdasemana.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        Datagriddiasdasemana.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btnovodiadasemana_Click(sender As Object, e As EventArgs) Handles btnovodiadasemana.Click
        Me.Text = "Novo dia da semana"
        limpar()

        desbloqueardiasemmana(True)
        txtnundiadasemana.Enabled = False
        txtdiadasemana.Enabled = True
        btncancelardiasadasemana.Enabled = True
        btnovodiadasemana.Enabled = False
        btneditardiadasemanana.Enabled = False
        btnelimanardiadasemana.Enabled = False
        btnconsultardiasdasemana.Enabled = False
        btnsairdiasdasemana.Enabled = False
        btnguardardiasdasemana.Enabled = True

    End Sub

    Private Sub dias_da_seamana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desbloqueardiasemmana(False)
        ativar_diasdasemana(False)
        lblibrigatorionundiadasemana.Visible = False
        lblobrobrigatoriodiasdasemana.Visible = False
        btncancelardiasadasemana.Enabled = False
        btnguardardiasdasemana.Enabled = False
        txtdiaddsemana.Visible = False

        consdiadasemana()
        limpar()


    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardardiasdasemana.Click
        If botao = 1 Then

            ativar_diasdasemana(False)

            If txtdiadasemana.Text = "" Then
                lblobrobrigatoriodiasdasemana.Visible = True
            Else
                lblobrobrigatoriodiasdasemana.Visible = False
                Call conectar()
                Dim sql1 As String = "insert into DiasSemana values ('" & RTrim(txtdiadasemana.Text) & "')"
                Dim sqlcom1 As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcom1.ExecuteReader
                Call desconectar()
                consdiadasemana()
                btnsairdiasdasemana.Enabled = True
                limpar()

                If botao = 2 Then

                End If

            End If
        End If

    End Sub

    Public Sub limpar()
        txtnundiadasemana.Clear()
        txtnundiadasemana.Enabled = False
        txtdiadasemana.Clear()
        txtdiadasemana.Focus()

    End Sub

    Private Sub txtdiaddsemana_TextChanged(sender As Object, e As EventArgs) Handles txtdiaddsemana.TextChanged
        Call conectar()
        Dim sql As String = "select * from DiasSemana " & " where diaSemana like '" & txtdiaddsemana.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        Datagriddiasdasemana.Columns.Clear()
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            Datagriddiasdasemana.Columns.Add(campo, campo)
        Next
        While dr.Read
            Dim linha As New DataGridViewRow
            Datagriddiasdasemana.Rows.Add(linha)
            Datagriddiasdasemana.Rows(i).Cells(0).Value = dr.Item(0)
            Datagriddiasdasemana.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        Datagriddiasdasemana.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btnconsultardiasdasemana_Click(sender As Object, e As EventArgs) Handles btnconsultardiasdasemana.Click
        btnovodiadasemana.Enabled = False
        btncancelardiasadasemana.Enabled = True
        txtdiaddsemana.Visible = True
        diadadesemana1.Visible = True



    End Sub

    Private Sub btncancelardiasadasemana_Click(sender As Object, e As EventArgs) Handles btncancelardiasadasemana.Click
        Me.Text = "Cancelar dia da semana"
        diadadesemana1.Visible = False
        desbloqueardiasemmana(False)
        ativar_diasdasemana(False)
        txtnundiadasemana.Clear()
        txtdiadasemana.Clear()
        btnovodiadasemana.Enabled = True
        btneditardiadasemanana.Enabled = True
        btnelimanardiadasemana.Enabled = True
        btnguardardiasdasemana.Enabled = False
        btnconsultardiasdasemana.Enabled = True
        btnsairdiasdasemana.Enabled = True
        txtdiaddsemana.Visible = False
        limpar()


    End Sub

    Private Sub btnsairdiasdasemana_Click(sender As Object, e As EventArgs) Handles btnsairdiasdasemana.Click
        Me.Close()
    End Sub

    Private Sub btneditardiadasemanana_Click(sender As Object, e As EventArgs) Handles btneditardiadasemanana.Click
        txtdiaddsemana.Visible = False

    End Sub

    Private Sub btnelimanardiadasemana_Click(sender As Object, e As EventArgs) Handles btnelimanardiadasemana.Click

    End Sub
End Class