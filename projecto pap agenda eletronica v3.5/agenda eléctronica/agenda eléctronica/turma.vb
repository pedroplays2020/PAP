Imports System.Data.SqlClient
Public Class turma
    Shared ConnectionString As String = "Data Source=.\;Initial Catalog=Agenda;Integrated Security=True"
    Public Shared Function verificarturma(turma As String, anoletivo As Integer) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                con.ConnectionString = ConnectionString
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM turma WHERE descricao = '" & turma & "' and idAnoLectivo = '" & anoletivo & "'"
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
    End Function

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
        Dim sql As String = "select T.idTurma, T.descricao, A.anolectivo, T.ano, T.Tipocurso from turma T, Anolectivo A where  T.idAnolectivo = A.idAnolectivo"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridturma.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datagridturma.Columns.Add(0, "Código")
        datagridturma.Columns.Add(1, "Turma")
        datagridturma.Columns.Add(2, "Tipo de Curso")
        datagridturma.Columns.Add(3, "Escolaridade")
        datagridturma.Columns.Add(4, "Ano letivo")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridturma.Rows.Add(linha)
            datagridturma.Rows(i).Cells(0).Value = dr.Item(0)
            datagridturma.Rows(i).Cells(1).Value = dr.Item(1)
            datagridturma.Rows(i).Cells(4).Value = dr.Item(4)
            datagridturma.Rows(i).Cells(3).Value = dr.Item(3)
            datagridturma.Rows(i).Cells(2).Value = dr.Item(2)
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
        'combotipocursoturma.SelectedIndex = -1
        comboanoletivoturma.SelectedIndex = -1
    End Sub
    Private Sub btnovoturma_Click(sender As Object, e As EventArgs) Handles btnovoturma.Click
        gbmsgturma.Visible = False
        Me.Text = "Novo turma"
        desbloquearturma(True)
        txtnumturma.Enabled = False
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
        gbmsgturma.Visible = False
        desbloquearturma(False)
        ativarturma(False)
        lblobrigatorionometurma.Visible = False
        btncancelarturma.Enabled = False
        btnguardarturma.Enabled = False
        consturma()
        leranoletivo()
        limparturma()
        txtnometurma.Enabled = False
        combanoturma.Enabled = False
    End Sub

    Private Sub btnguardarturma_Click(sender As Object, e As EventArgs) Handles btnguardarturma.Click
        If txtnometurma.Text = "" Then
            lblobrigatorionometurma.Visible = True
            txtnometurma.Focus()
        End If
        If comboanoletivoturma.SelectedIndex = -1 Then
            lblobrigatorioanoletivoturma.Visible = True
            comboanoletivoturma.Focus()
        End If
        If combotipocursoturma.SelectedIndex = -1 Then
            lblobrigatoriotipocursoturma.Visible = True
            combotipocursoturma.Focus()
        End If
        If combanoturma.SelectedIndex = -1 Then
            lblobrigatorioanoturma.Visible = True
            combanoturma.Focus()
        End If
        If verificarturma(txtnometurma.Text, comboanoletivoturma.SelectedValue) = True Then
            gbmsgturma.Visible = True
            lblmsgturma.Text = "A turma a inserir já se encontra registada."
            Exit Sub
        End If

        If botao = 1 Then
            If lblobrigatorionometurma.Visible = False And lblobrigatorioanoletivoturma.Visible = False And lblobrigatorioanoturma.Visible = False And lblobrigatoriotipocursoturma.Visible = False Then
                Call conectar()
                Dim sql As String = "insert into turma values ('" & txtnometurma.Text & _
                                                                "', '" & combanoturma.Text & _
                                                                "', '" & combotipocursoturma.Text & _
                                                                "', '" & comboanoletivoturma.SelectedValue & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                gbmsgturma.Visible = True
                lblmsgturma.Text = "A turma inserida com sucesso!"
                consturma()
                btnsairturma.Enabled = True
                btnovoturma.Enabled = True
                btneditarturma.Enabled = True
                btneliminarturma.Enabled = True
                btnguardarturma.Enabled = False
                btnconsultarturma.Enabled = True
                btncancelarturma.Enabled = False
                desbloquearturma(False)
                limparturma()
                txtnometurma.Enabled = False
                combanoturma.Enabled = False
            End If
        ElseIf botao = 2 Then
            If lblobrigatorionometurma.Visible = False And lblobrigatorioanoletivoturma.Visible = False And lblobrigatorioanoturma.Visible = False And lblobrigatoriotipocursoturma.Visible = False Then
                Call conectar()
                Dim sql1 As String = "update  turma set descricao = '" & txtnometurma.Text & "' where idTurma = '" & txtnumturma.Text & "'"
                Dim sqlcon As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
                dr1.Close()
                Call desconectar()
                gbmsgturma.Visible = True
                lblmsgturma.Text = "Turma alterada com sucesso!"
                consturma()
                txtnometurma.Enabled = False
                limparturma()
                btnovoturma.Enabled = True
                btneditarturma.Enabled = True
                btneliminarturma.Enabled = True
                btnguardarturma.Enabled = False
                btnconsultarturma.Enabled = True
                btncancelarturma.Enabled = False
                txtnometurma.Enabled = False
                combanoturma.Enabled = False
            End If
            combotipocursoturma.Items.Clear()
        End If

    End Sub

    Private Sub btncancelarturma_Click(sender As Object, e As EventArgs) Handles btncancelarturma.Click
        Me.Text = " Cancelar turma"
        gbmsgturma.Visible = False
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
        txtnometurma.Enabled = False
        comboanoletivoturma.Enabled = False
    End Sub

    Private Sub btnconsultarturma_Click(sender As Object, e As EventArgs) Handles btnconsultarturma.Click
        btnovoturma.Enabled = False
        btncancelarturma.Enabled = True
        txtnometurma.Visible = True
        txtnometurma.Enabled = True
    End Sub

    Private Sub btnsairturma_Click(sender As Object, e As EventArgs) Handles btnsairturma.Click
        Me.Close()
        Bloquear_menu(True)
    End Sub

    Private Sub txtnometurma_TextChanged(sender As Object, e As EventArgs) Handles txtnometurma.TextChanged
        Call conectar()

        Dim sql As String = "select  T.idTurma, T.descricao, T.tipocurso, T.ano, A.anolectivo from turma T, Anolectivo A " & " where T.descricao  like '" & txtnometurma.Text & "%' and T.idAnolectivo = A.idAnolectivo"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datagridturma.Columns.Clear()
        datagridturma.Columns.Add(0, "Código")
        datagridturma.Columns.Add(1, "Turma")
        datagridturma.Columns.Add(2, "Tipo de Curso")
        datagridturma.Columns.Add(3, "Escolaridade")
        datagridturma.Columns.Add(4, " Ano letivo")
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
        datagridturma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btneliminarturma_Click(sender As Object, e As EventArgs) Handles btneliminarturma.Click
        combanoturma.Enabled = False
        txtnometurma.Enabled = False

        gbmsgturma.Visible = False
        Try
            btncancelarturma.Enabled = True
            txtnumturma.Text = datagridturma.CurrentRow.Cells(0).Value
            txtnometurma.Text = datagridturma.CurrentRow.Cells(1).Value
            combotipocursoturma.Text = datagridturma.CurrentRow.Cells(2).Value
            combanoturma.Text = datagridturma.CurrentRow.Cells(3).Value
            comboanoletivoturma.Text = datagridturma.CurrentRow.Cells(4).Value
            Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar turma")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from turma where idTurma= '" & txtnumturma.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                ' MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar turma")
                gbmsgturma.Visible = True
                lblmsgturma.Text = "Turma eliminada com sucesso!"
                consturma()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar turma")
        End Try
    End Sub

    Private Sub btneditarturma_Click(sender As Object, e As EventArgs) Handles btneditarturma.Click
        gbmsgturma.Visible = False
        txtnometurma.Visible = False

        btnovoturma.Enabled = False
        btneliminarturma.Enabled = False
        btnconsultarturma.Enabled = False
        btnguardarturma.Enabled = True
        btncancelarturma.Enabled = True
        txtnumturma.Text = datagridturma.CurrentRow.Cells(0).Value
        txtnometurma.Text = datagridturma.CurrentRow.Cells(1).Value
        combotipocursoturma.Text = datagridturma.CurrentRow.Cells(2).Value
        'MsgBox(datagridturma.CurrentRow.Cells(3).Value)
        combanoturma.Text = datagridturma.CurrentRow.Cells(3).Value
        comboanoletivoturma.Text = datagridturma.CurrentRow.Cells(4).Value
        txtnometurma.Enabled = True
        txtnometurma.Visible = True
        botao = 2
    End Sub

    Private Sub combotipocursoturma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotipocursoturma.SelectedIndexChanged
        Dim texto As String
        texto = combotipocursoturma.SelectedItem.ToString
        If texto = "Curso Profissional" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("1º Ano")
            combanoturma.Items.Add("2º Ano")
            combanoturma.Items.Add("3º Ano")
        ElseIf texto = "Curso Cientifico" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("10º Ano")
            combanoturma.Items.Add("11º Ano")
            combanoturma.Items.Add("12º Ano")
        ElseIf texto = "Curso Línguas e Humanidades" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("10º Ano")
            combanoturma.Items.Add("11º Ano")
            combanoturma.Items.Add("12º Ano")
        ElseIf texto = "Curso SocioEconomico" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("10º Ano")
            combanoturma.Items.Add("11º Ano")
            combanoturma.Items.Add("12º Ano")
        ElseIf texto = "Curso Artes Visuais" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("10º Ano")
            combanoturma.Items.Add("11º Ano")
            combanoturma.Items.Add("12º Ano")
        ElseIf texto = "Primeiro Ciclo" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("1º Ano")
            combanoturma.Items.Add("2º Ano")
            combanoturma.Items.Add("3º Ano")
            combanoturma.Items.Add("4º Ano")
        ElseIf texto = "Segundo Ciclo" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("5º Ano")
            combanoturma.Items.Add("6º Ano")
        ElseIf texto = "Terceiro Ciclo" Then
            combanoturma.Items.Clear()
            combanoturma.Items.Add("7º Ano")
            combanoturma.Items.Add("8º Ano")
            combanoturma.Items.Add("9º Ano")
        End If
        txtnometurma.Enabled = True
        combanoturma.Enabled = True
    End Sub

    Private Sub lbltipocursoturma_Click(sender As Object, e As EventArgs) Handles lbltipocursoturma.Click

    End Sub
End Class