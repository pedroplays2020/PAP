Imports System.Data.SqlClient
Public Class turma
    Dim botao As Integer
    Public Sub leranoletivo()
        Call conectar()
        Dim sql As String = "select * from anolectivo where estado = 'ativo' order by idanolectivo"
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
    Public Sub consturma(sql As String)
        Call conectar()
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridturma.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datagridturma.Columns.Add(0, "Código")
        datagridturma.Columns.Add(1, "Turma")
        datagridturma.Columns.Add(2, "Ano letivo")
        datagridturma.Columns.Add(3, "Ano Escolaridade")
        datagridturma.Columns.Add(4, "Tipo Curso")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridturma.Rows.Add(linha)
            datagridturma.Rows(i).Cells(0).Value = dr.Item(0)
            datagridturma.Rows(i).Cells(1).Value = dr.Item(1)
            datagridturma.Rows(i).Cells(2).Value = dr.Item(2)
            datagridturma.Rows(i).Cells(3).Value = dr.Item(3)
            datagridturma.Rows(i).Cells(4).Value = dr.Item(4)
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
        combanoturma.SelectedIndex = -1
        combotipocursoturma.SelectedIndex = -1
        comboanoletivoturma.SelectedIndex = -1
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
        datagridturma.AllowUserToAddRows = False
        desbloquearturma(False)
        ativarturma(False)
        lblobrigatorionometurma.Visible = False
        btncancelarturma.Enabled = False
        btnguardarturma.Enabled = False
        Dim sql As String = "select T.idTurma, T.descricao, A.anolectivo, T.ano, T.tipocurso from turma T, Anolectivo A where  T.idAnolectivo = A.idAnolectivo"
        consturma(Sql)
        leranoletivo()
        limparturma()
    End Sub

    Private Sub btnguardarturma_Click(sender As Object, e As EventArgs) Handles btnguardarturma.Click
        ativarturma(False)

        If combanoturma.SelectedIndex = -1 Then
            lblobrigatorioanoturma.Visible = True
            combanoturma.Focus()
        End If

        If combotipocursoturma.SelectedIndex = -1 Then
            lblobrigatoriotipocursoturma.Visible = True
            combotipocursoturma.Focus()
        End If

        If txtnometurma.Text = "" Then
            lblobrigatorionometurma.Visible = True
            txtnometurma.Focus()
        End If

        If comboanoletivoturma.SelectedIndex = -1 Then
            lblobrigatorioanoletivoturma.Visible = True
            comboanoletivoturma.Focus()
        End If

        If lblobrigatorioanoletivoturma.Visible = False And lblobrigatorioanoturma.Visible = False And lblobrigatorionometurma.Visible = False And lblobrigatoriotipocursoturma.Visible = False Then
            If botao = 1 Then
                Call conectar()
                Dim sql As String = "insert into turma values ('" & txtnometurma.Text & _
                                                                "', '" & combanoturma.SelectedValue & _
                                                                "', '" & combotipocursoturma.SelectedValue & _
                                                                "', '" & comboanoletivoturma.SelectedValue & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
            ElseIf botao = 2 Then
                Call conectar()
                Dim sql1 As String = "update  turma set descricao = '" & txtnometurma.Text & "' where idTurma = '" & txtnumturma.Text & "'"
                Dim sqlcon As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
                dr1.Close()
                Call desconectar()
            End If
            txtnometurma.Enabled = False
            Dim sql2 As String = "select T.idTurma, T.descricao, A.anolectivo, T.ano, T.tipocurso from turma T, Anolectivo A where  T.idAnolectivo = A.idAnolectivo"
            consturma(sql2)
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
        ativarturma(False)
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
        If tipouser = 0 Then
            Bloquear_menu(False)
            formulario_principal.TurmaToolStripMenuItem.Enabled = True
        Else
            Bloquear_menu(True)
        End If
    End Sub

    Private Sub txtnometurma_TextChanged(sender As Object, e As EventArgs) Handles txtnometurma.TextChanged
        'Dim sql As String = "select  select T.idTurma, T.descricao, A.anolectivo, T.ano, T.tipocurso from turma T, Anolectivo A " & " where T.descricao  like '" & txtnometurma.Text & "%' and T.idAnolectivo = A.idAnolectivo"
        'consturma(sql)
    End Sub

    Private Sub btneliminarturma_Click(sender As Object, e As EventArgs) Handles btneliminarturma.Click
        Try
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
                Dim sql1 As String = "select T.idTurma, T.descricao, A.anolectivo, T.ano, T.tipocurso from turma T, Anolectivo A where  T.idAnolectivo = A.idAnolectivo"
                consturma(sql1)
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
        comboanoletivoturma.Text = datagridturma.CurrentRow.Cells(2).Value
        combanoturma.Text = datagridturma.CurrentRow.Cells(3).Value
        combotipocursoturma.Text = datagridturma.CurrentRow.Cells(4).Value
        txtnometurma.Enabled = True
        txtnometurma.Visible = True
    End Sub

    Private Sub combotipocursoturma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotipocursoturma.SelectedIndexChanged
        Dim texto As String
        texto = combotipocursoturma.SelectedItem
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