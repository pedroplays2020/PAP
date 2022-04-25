Imports System.Data.SqlClient
Public Class horario
    Dim botao As Integer

    Public Sub lercategoria()
        Call conectar()
        Dim sql As String = "select idArea, nome from Areav order by idArea"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combocategoriapesquisa.ValueMember = "idArea"
        combocategoriapesquisa.DisplayMember = "nome"
        combocategoriapesquisa.DataSource = dt
        Call desconectar()
    End Sub
    Public Sub lerarea()
        Call conectar()
        Dim sql As String = "select idarea, nomearea from area order by idarea"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combareahorario.ValueMember = "idarea"
        combareahorario.DisplayMember = "nomearea"
        combareahorario.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lerdisciplina()
        Call conectar()
        Dim sql As String = "select idDisciplina, Nomedisciplina from Disciplina order by idDisciplina"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combodisciplinahorario.ValueMember = "idDisciplina"
        combodisciplinahorario.DisplayMember = "Nomedisciplina"
        combodisciplinahorario.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lerbloco()

        Call conectar()
        Dim sql As String = "select idbloco, nomebloco from bloco order by idbloco"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        comboblocohorario.ValueMember = "idbloco"
        comboblocohorario.DisplayMember = "nomebloco"
        comboblocohorario.DataSource = dt
        Call desconectar()
    End Sub
    Public Sub lerfuncao()
        Call conectar()
        Dim sql As String = "select idFuncao, funcao from  Funcao order by idFuncao"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combofuncaopesquisa.ValueMember = "idFuncao"
        combofuncaopesquisa.DisplayMember = "funcao"
        combofuncaopesquisa.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lersala()

        Call conectar()
        Dim sql As String = "select idsala, sala from sala order by idsala"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combosalahorario.ValueMember = "idsala"
        combosalahorario.DisplayMember = "sala"
        combosalahorario.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lerdias()
        Dim sql As String = "select idDiaSemana, diaSemana from DiasSemana order by idDiaSemana"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combodiashorario.ValueMember = "idDiaSemana"
        combodiashorario.DisplayMember = "diaSemana"
        combodiashorario.DataSource = dt
        Call desconectar()

    End Sub

    Public Sub lerhoras()
        Dim sql As String = "select idtempo, intervaloHorario from Tempo order by idtempo"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combohorashorario.ValueMember = "idtempo"
        combohorashorario.DisplayMember = "intervaloHorario"
        combohorashorario.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub consulthorario()
        Call conectar()
        Dim sql As String = "select * from Horario"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridhorario.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridhorario.Columns.Add(campo, campo)
        Next
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridhorario.Rows.Add(linha)
            datagridhorario.Rows(i).Cells(0).Value = dr.Item(0)
            datagridhorario.Rows(i).Cells(1).Value = dr.Item(1)
            datagridhorario.Rows(i).Cells(2).Value = dr.Item(2)
            datagridhorario.Rows(i).Cells(3).Value = dr.Item(3)

            i = i + 1
        End While
        datagridhorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Public Sub desbloquearhorario(ByVal estado As Boolean)
        txtnumpesquisa.Enabled = estado
        txtnumhorario.Enabled = estado
        combofuncaopesquisa.Enabled = estado
        combocategoriapesquisa.Enabled = estado
        combareahorario.Enabled = estado
        combodisciplinahorario.Enabled = estado
        comboblocohorario.Enabled = estado
        combosalahorario.Enabled = estado
        combodiashorario.Enabled = estado
        combohorashorario.Enabled = estado
    End Sub

    Public Sub ativarhorario(ByVal estado As Boolean)
        lblobrigatorioarea.Visible = estado
        lblobrigatoriodisciplina.Visible = estado
        lblobrigatoriobloco.Visible = estado
        lblobrigatoriosala.Visible = estado
        lblobrigatoriodias.Visible = estado
        lblobrigatoriohoras.Visible = estado
    End Sub

    Public Sub limparhorario()
        txtnumpesquisa.Clear()
        txtnumpesquisa.Enabled = False
        txtnumhorario.Clear()
        txtnumhorario.Enabled = False
        combofuncaopesquisa.SelectedItem = -1
        combocategoriapesquisa.SelectedItem = -1
        combareahorario.SelectedItem = -1
        combareahorario.Focus()
        combodisciplinahorario.SelectedItem = -1
        combodisciplinahorario.Focus()
        comboblocohorario.SelectedItem = -1
        comboblocohorario.Focus()
        combosalahorario.SelectedItem = -1
        combosalahorario.Focus()
        combodiashorario.SelectedItem = -1
        combodiashorario.Focus()
        combohorashorario.SelectedItem = -1
        combohorashorario.Focus()

    End Sub

    Private Sub btnovohorario_Click(sender As Object, e As EventArgs) Handles btnovohorario.Click
        Me.Text = " Novo horário"
        botao = 1
        desbloquearhorario(True)
        txtnumpesquisa.Enabled = False
        txtnumhorario.Enabled = False
        txtnomepesquisa.Enabled = True
        combofuncaopesquisa.Enabled = True
        combocategoriapesquisa.Enabled = True
        combareahorario.Enabled = True
        combodisciplinahorario.Enabled = True
        comboblocohorario.Enabled = True
        combosalahorario.Enabled = True
        combodiashorario.Enabled = True
        combohorashorario.Enabled = True
        btncancelarhorario.Enabled = True
        btnovohorario.Enabled = False
        btneditarhorario.Enabled = False
        btneliminarhorario.Enabled = False
        btnguardarhorario.Enabled = True
        btnconsultarhorario.Enabled = False
        btnsairhorario.Enabled = False
        consulthorario()
        limparhorario()
        botao = 1
    End Sub

    Private Sub btnguardarhorario_Click(sender As Object, e As EventArgs) Handles btnguardarhorario.Click
        If botao = 1 Then
            If combareahorario.SelectedItem = -1 Then
                lblobrigatorioarea.Visible = True
                combareahorario.Focus()
            End If
            If combodisciplinahorario.SelectedItem = -1 Then
                lblobrigatoriodisciplina.Visible = True
                combodisciplinahorario.Focus()

                If comboblocohorario.SelectedItem = -1 Then
                    lblobrigatoriobloco.Visible = True
                    comboblocohorario.Focus()
                End If

                If combosalahorario.SelectedItem = -1 Then
                    lblobrigatoriosala.Visible = True
                    combosalahorario.Focus()
                End If
                If combodiashorario.SelectedItem = -1 Then
                    lblobrigatoriodias.Visible = True
                    combodiashorario.Focus()
                End If
                If combohorashorario.SelectedItem = -1 Then
                    lblobrigatoriohoras.Visible = True
                    combohorashorario.Focus()

                Else
                    lblobrigatorioarea.Visible = False
                    lblobrigatoriodisciplina.Visible = True
                    lblobrigatoriobloco.Visible = False
                    lblobrigatoriosala.Visible = False
                    lblobrigatoriodias.Visible = False
                    lblobrigatoriohoras.Visible = False
                    Call conectar()
                    Dim sql As String = "insert into Horario values ('" & txtnomepesquisa.Text & "', '" & combofuncaopesquisa.SelectedValue & "','" & combocategoriapesquisa.SelectedValue & "', '" & RTrim(combareahorario.SelectedValue) & "', '" & combodisciplinahorario.SelectedValue & "', '" & comboblocohorario.SelectedValue & "', '" & combosalahorario.SelectedValue & "', '" & combodiashorario.SelectedValue & "', '" & combohorashorario.SelectedValue & "')"
                    Dim sqlcom As New SqlCommand(sql, con)
                    Dim dr As SqlDataReader = sqlcom.ExecuteReader
                    Call desconectar()
                    consulthorario()
                    btnsairhorario.Enabled = True
                    limparhorario()
                End If
            ElseIf botao = 2 Then
                Call conectar()
                'Dim sql1 As String = "update horario  set idHorario = '" & txtnomebloco.Text & "' where idbloco= '" & txtbloconum.Text & "'"
                'Dim sqlcon1 As New SqlCommand(sql1, con)
                'Dim dr1 As SqlDataReader = sqlcon1.ExecuteReader
                'dr1.Close()
                Call desconectar()
                consulthorario()
                limparhorario()
            End If
        End If
    End Sub

    Private Sub btnconsultarhorario_Click(sender As Object, e As EventArgs) Handles btnconsultarhorario.Click
        btnovohorario.Enabled = False
        btncancelarhorario.Enabled = True
        txtconsultahorario.Visible = True
        txtconsultahorario.Enabled = True

    End Sub

    Private Sub btncancelarhorario_Click(sender As Object, e As EventArgs) Handles btncancelarhorario.Click
        Me.Text = " Cancelar horario"
        desbloquearhorario(False)
        ativarhorario(True)
        txtnumhorario.Clear()
        txtnumpesquisa.Clear()
        txtnomepesquisa.Clear()
        txtnomepesquisa.Enabled = False
        combofuncaopesquisa.SelectedItem = -1
        combocategoriapesquisa.SelectedItem = -1
        combareahorario.SelectedItem = -1
        combodisciplinahorario.SelectedItem = -1
        comboblocohorario.SelectedItem = -1
        combosalahorario.SelectedItem = -1
        combodiashorario.SelectedItem = -1
        combohorashorario.SelectedItem = -1
        btnovohorario.Enabled = True
        btneditarhorario.Enabled = True
        btneliminarhorario.Enabled = True
        btnguardarhorario.Enabled = False
        btnconsultarhorario.Enabled = True
        btncancelarhorario.Enabled = False
        btnsairhorario.Enabled = True
        limparhorario()
    End Sub

    Private Sub btnsairhorario_Click(sender As Object, e As EventArgs) Handles btnsairhorario.Click
        Me.Close()
    End Sub

    Private Sub horario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lerfuncao()
        lercategoria()
        lerarea()
        lerbloco()
        lerdias()
        lerdisciplina()
        lerhoras()
        lersala()

        desbloquearhorario(False)
        ativarhorario(False)
        lblobrigatorioarea.Visible = False
        lblobrigatoriodisciplina.Visible = True
        lblobrigatoriobloco.Visible = False
        lblobrigatoriosala.Visible = False
        lblobrigatoriodias.Visible = False
        lblobrigatoriohoras.Visible = False
        btncancelarhorario.Enabled = False
        btnguardarhorario.Enabled = False
        consulthorario()
        limparhorario()
        txtnomepesquisa.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtconsultahorario.TextChanged
        Call conectar()
        Dim sql As String = "select * from  Horario " & " where  idHorario like '" & txtconsultahorario.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datagridhorario.Columns.Clear()

        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridhorario.Columns.Add(campo, campo)
        Next
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridhorario.Rows.Add(linha)
            datagridhorario.Rows(i).Cells(0).Value = dr.Item(0)
            datagridhorario.Rows(i).Cells(1).Value = dr.Item(1)
            datagridhorario.Rows(i).Cells(2).Value = dr.Item(2)
            i = i + 1
        End While
        datagridhorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btneliminarhorario_Click(sender As Object, e As EventArgs) Handles btneliminarhorario.Click
        Try
            txtnumhorario.Clear()
            combareahorario.SelectedItem = -1
            combareahorario.Visible = True
            btncancelarhorario.Enabled = True

            txtnumhorario.Text = datagridhorario.CurrentRow.Cells(0).Value
            combareahorario.Text = datagridhorario.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Horario")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from Disciplina where idDisciplina = '" & txtnumhorario.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Horario")
                consulthorario()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Horario ")
        End Try
    End Sub

    Private Sub btneditarhorario_Click(sender As Object, e As EventArgs) Handles btneditarhorario.Click
        botao = 2
        btnovohorario.Enabled = False
        btneliminarhorario.Enabled = False
        btnconsultarhorario.Enabled = False
        btnguardarhorario.Enabled = True
        btncancelarhorario.Enabled = True
        txtnumhorario.Text = datagridhorario.CurrentRow.Cells(0).Value
        txtconsultahorario.Text = datagridhorario.CurrentRow.Cells(1).Value
        txtconsultahorario.Enabled = True
    End Sub


End Class