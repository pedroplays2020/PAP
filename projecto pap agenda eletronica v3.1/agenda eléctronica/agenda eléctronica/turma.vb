Imports System.Data.SqlClient
Public Class turma
    Dim botao As Integer
    Public Sub leranoletivo()
        Call conectar()
        Dim sql As String = "select * from anolectivo order by idanolectivo"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        comboanoletivoturma.ValueMember = "idanolectivo"
        comboanoletivoturma.DisplayMember = "anolectivo"
        comboanoletivoturma.DataSource = dt

        Call desconectar()
    End Sub
    Public Sub desbloquearturma(ByVal estado As Boolean)
        txtnumturma.Enabled = estado
        txtnometurma.Enabled = estado
        combanoturma.Enabled = estado
        combotipocursoturma.Enabled = estado
        comboanoletivoturma.Enabled = estado
    End Sub
    Public Sub consturma()
        Call conectar()
        Dim sql As String = "select * from turma"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridturma.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datagridturma.Columns.Add(0, "Código")
        datagridturma.Columns.Add(1, "Descrição")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridturma.Rows.Add(linha)
            datagridturma.Rows(i).Cells(0).Value = dr.Item(0)
            datagridturma.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datagridturma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()


    End Sub
    Public Sub ativarturma(ByVal estado As Boolean)
        lblobrigatorionometurma.Visible = estado
        lblobrigatorioanoturma.Visible = estado
        lblobrigatoriotipocursoturma.Visible = estado
        lblobrigatorioanoletivoturma.Visible = estado
    End Sub
    Public Sub limparturma()
        txtnumturma.Clear()
        txtnumturma.Enabled = False
        txtnometurma.Clear()
        combanoturma.SelectedItem = -1
        combotipocursoturma.SelectedItem = -1
        comboanoletivoturma.SelectedItem = -1
    End Sub
    Private Sub btnovoturma_Click(sender As Object, e As EventArgs) Handles btnovoturma.Click
        Me.Text = "Novo turma"
        desbloquearturma(True)
        txtnumturma.Enabled = False
        txtnometurma.Enabled = True
        btncancelarturma.Enabled = True
        btnovoturma.Enabled = False
        btneditarturma.Enabled = False
        btneliminarturma.Enabled = False
        btnguardarturma.Enabled = True
        btnconsultarturma.Enabled = False
        btnsairturma.Enabled = False
        botao = 1
    End Sub

    Private Sub turma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desbloquearturma(False)
        ativarturma(False)
        lblobrigatorionometurma.Visible = False
        btncancelarturma.Enabled = False
        btnguardarturma.Enabled = False
        consturma()
        leranoletivo()
        limparturma()
    End Sub

    Private Sub btnguardarturma_Click(sender As Object, e As EventArgs) Handles btnguardarturma.Click
        If botao = 1 Then
            If txtnometurma.Text = "" Then
                lblobrigatorionometurma.Visible = True
            Else
                lblobrigatorionometurma.Visible = False
                Call conectar()
                Dim sql As String = "insert into turma values ('" & txtnometurma.Text & _
                                                                "', '" & combanoturma.SelectedText & _
                                                                "', '" & combotipocursoturma.SelectedText & _
                                                                "', '" & comboanoletivoturma.SelectedValue & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                consturma()
                btnsairturma.Enabled = True
                btnovoturma.Enabled = True
                btneditarturma.Enabled = True
                btneliminarturma.Enabled = True
                btnguardarturma.Enabled = False
                btnconsultarturma.Enabled = True
                btncancelarturma.Enabled = False
                limparturma()
            End If
        ElseIf botao = 2 Then
            Call conectar()
            Dim sql1 As String = "update  turma set turma = '" & txtnometurma.Text & "' where idTurma = '" & txtnumturma.Text & "'"
            Dim sqlcon As New SqlCommand(sql1, con)
            Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
            dr1.Close()
            Call desconectar()
            consturma()
            txtnometurma.Enabled = False
            limparturma()
            btnovoturma.Enabled = True
            btneditarturma.Enabled = True
            btneliminarturma.Enabled = True
            btnguardarturma.Enabled = False
            btnconsultarturma.Enabled = True
            btncancelarturma.Enabled = False

        End If

    End Sub

    Private Sub btncancelarturma_Click(sender As Object, e As EventArgs) Handles btncancelarturma.Click
        Me.Text = " Cancelar turma"
        desbloquearturma(False)
        ativarturma(True)
        txtnumturma.Clear()
        txtnometurma.Clear()
        btnovoturma.Enabled = True
        btneditarturma.Enabled = True
        btneliminarturma.Enabled = True
        btnguardarturma.Enabled = False
        btnconsultarturma.Enabled = True
        btncancelarturma.Enabled = False
        btnsairturma.Enabled = True
        limparturma()
    End Sub

    Private Sub btnconsultarturma_Click(sender As Object, e As EventArgs) Handles btnconsultarturma.Click
        btnovoturma.Enabled = False
        btncancelarturma.Enabled = True
        txtnometurma.Visible = True
        txtnometurma.Enabled = True
    End Sub

    Private Sub btnsairturma_Click(sender As Object, e As EventArgs) Handles btnsairturma.Click
        Me.Close()
    End Sub

    Private Sub txtnometurma_TextChanged(sender As Object, e As EventArgs) Handles txtnometurma.TextChanged
        Call conectar()

        Dim sql As String = "select * from turma " & " where descricao  like '" & txtnometurma.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datagridturma.Columns.Clear()
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridturma.Columns.Add(campo, campo)
        Next
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridturma.Rows.Add(linha)
            datagridturma.Rows(i).Cells(0).Value = dr.Item(0)
            datagridturma.Rows(i).Cells(1).Value = dr.Item(1)

            i = i + 1
        End While
        datagridturma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btneliminarturma_Click(sender As Object, e As EventArgs) Handles btneliminarturma.Click
        Try
            txtnometurma.Visible = False
            btncancelarturma.Enabled = True
            txtnumturma.Text = datagridturma.CurrentRow.Cells(0).Value
            txtnometurma.Text = datagridturma.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar turma")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from turma where idTurma= '" & txtnumturma.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar turma")
                consturma()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar turma")
        End Try
    End Sub

    Private Sub btneditarturma_Click(sender As Object, e As EventArgs) Handles btneditarturma.Click
        txtnometurma.Visible = False
        botao = 2
        btnovoturma.Enabled = False
        btneliminarturma.Enabled = False
        btnconsultarturma.Enabled = False
        btnguardarturma.Enabled = True
        btncancelarturma.Enabled = True
        txtnumturma.Text = datagridturma.CurrentRow.Cells(0).Value
        txtnometurma.Text = datagridturma.CurrentRow.Cells(1).Value
        txtnometurma.Enabled = True
        txtnometurma.Visible = True
    End Sub

    Private Sub combotipocursoturma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotipocursoturma.SelectedIndexChanged
        Dim texto As String
        texto = combotipocursoturma.SelectedItem.ToString
        If texto = "Curso Profissional" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("1º")
            combanoturma.Items.Add("2º")
            combanoturma.Items.Add("3º")
        ElseIf texto = "Curso Cientifico" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("10º")
            combanoturma.Items.Add("11º")
            combanoturma.Items.Add("12º")
        ElseIf texto = "Curso Línguas e Humanidades" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("10º")
            combanoturma.Items.Add("11º")
            combanoturma.Items.Add("12º")
        ElseIf texto = "Curso SocioEconomico" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("10º")
            combanoturma.Items.Add("11º")
            combanoturma.Items.Add("12º")
        ElseIf texto = "Curso Artes Visuais" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("10º")
            combanoturma.Items.Add("11º")
            combanoturma.Items.Add("12º")
        ElseIf texto = "Primeiro Ciclo" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("1º")
            combanoturma.Items.Add("2º")
            combanoturma.Items.Add("3º")
            combanoturma.Items.Add("4º")
        elseIf texto = "Segundo Ciclo" Then
        combanoturma.Items.Clear()
            combanoturma.Items.Add("5º")
            combanoturma.Items.Add("6º")
        ElseIf texto = "Terceiro Ciclo" Then
        combanoturma.Items.Clear()
            combanoturma.Items.Add("7º")
            combanoturma.Items.Add("8º")
            combanoturma.Items.Add("9º")
        End If
    End Sub
End Class