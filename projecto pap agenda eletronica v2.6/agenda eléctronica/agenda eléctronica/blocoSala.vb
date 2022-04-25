Imports System.Data.SqlClient

Public Class blocoSala
    Dim botao, tab As Integer

    Public Sub limparbloco()
        txtbloconum.Clear()
        txtbloco.Clear()
    End Sub

    Public Sub gridbloco()
        Call conectar()
        Dim sql As String = "select * from Bloco"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        DataGridBloco.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            DataGridBloco.Columns.Add(campo, campo)
        Next
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            DataGridBloco.Rows.Add(linha)
            DataGridBloco.Rows(i).Cells(0).Value = dr.Item(0)
            DataGridBloco.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        DataGridBloco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btnnovofuncao_Click(sender As Object, e As EventArgs) Handles btnnovoblocosala.Click
        If tab = 1 Then
            gridbloco()
            gbBloco.Visible = True
            Me.Text = " Nova Categoria"
            limparbloco()
            ' desbloquearfunção(True)
            txtbloconum.Enabled = False
            txtbloco.Enabled = True
            lblobrigatoriobloco.Visible = False
            btncancelarblocosala.Enabled = True
            btnnovoblocosala.Enabled = False
            btneditarblocosala.Enabled = False
            btneliminarblocosala.Enabled = False
            btnconsultarblocosala.Enabled = False
            btnsairblocosala.Enabled = False
            btnguardarblocosala.Enabled = True

            botao = 1
        ElseIf tab = 2 Then
            MsgBox("teste!!!!")
        End If
    End Sub

    Private Sub blocoSala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tpBloco.Select()
        gbBloco.Visible = False

    End Sub

    Private Sub tpBloco_Layout(sender As Object, e As LayoutEventArgs) Handles tpBloco.Layout
        tab = 1
    End Sub


    Private Sub tpSala_Layout(sender As Object, e As LayoutEventArgs) Handles tpSala.Layout
        tab = 2
    End Sub

    Private Sub btnguardarblocosala_Click(sender As Object, e As EventArgs) Handles btnguardarblocosala.Click
        If tab = 1 Then
            If botao = 1 Then
                If txtbloco.Text = "" Then
                    lblobrigatoriobloco.Visible = True
                    txtbloco.Focus()
                Else
                    lblobrigatoriobloco.Visible = False

                End If


                If lblobrigatoriobloco.Visible = False Then

                    Call conectar()
                    Dim sql1 As String = "insert into bloco values ('" & RTrim(txtbloco.Text) & "')"
                    Dim sqlcom1 As New SqlCommand(sql1, con)
                    Dim dr1 As SqlDataReader = sqlcom1.ExecuteReader
                    Call desconectar()
                    gridbloco()
                    txtbloconum.ResetText()
                    txtbloco.ResetText()
                    btncancelarblocosala.Enabled = True
                    btnsairblocosala.Enabled = True
                End If
            ElseIf botao = 2 Then
            ElseIf botao = 3 Then
            End If
        ElseIf tab = 2 Then

        End If
    End Sub
End Class