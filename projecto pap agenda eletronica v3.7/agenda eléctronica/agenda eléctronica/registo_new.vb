Imports System.Data.SqlClient
Public Class Registo_new
    Dim botao As Integer

    Public Sub consGrelha()
        Call conectar()
        Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U, funcao F, areav A  where U.idFuncao=F.idfuncao and U.idArea=A.idArea"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datutilizadores.Columns.Clear()
        Dim n As Integer = dr.FieldCount

        datutilizadores.Columns.Add(0, "Código")
        datutilizadores.Columns.Add(1, "Utilizador")
        datutilizadores.Columns.Add(2, "Nome")
        datutilizadores.Columns.Add(3, "Função")
        datutilizadores.Columns.Add(4, "Categoria")
        datutilizadores.Columns.Add(5, "Área")

        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datutilizadores.Rows.Add(linha)
            datutilizadores.Rows(i).Cells(0).Value = dr.Item(0)
            datutilizadores.Rows(i).Cells(1).Value = dr.Item(1)
            datutilizadores.Rows(i).Cells(2).Value = dr.Item(2)
            datutilizadores.Rows(i).Cells(3).Value = dr.Item(3)
            datutilizadores.Rows(i).Cells(4).Value = dr.Item(4)
            datutilizadores.Rows(i).Cells(5).Value = dr.Item(5)
            i = i + 1
        End While
        datutilizadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        datutilizadores.Columns(5).Visible = False
        Call desconectar()
    End Sub

    Public Sub ler_sql()
        If combonome.SelectedIndex = -1 And combofuncaopesquisa.SelectedIndex = -1 And combocategoriapesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonome.Text & "%' and f.Funcao like '" & combofuncaopesquisa.Text & "%' and A.nome like '" & combocategoriapesquisa.Text & "%'"
            carregarutilizador(sql)
        ElseIf combonome.SelectedIndex = -1 And combofuncaopesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where A.nome like '" & combocategoriapesquisa.Text & "%'"
            carregarutilizador(sql)
        ElseIf combonome.SelectedIndex = -1 And combocategoriapesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where f.Funcao like '" & combofuncaopesquisa.Text & "%'"
            carregarutilizador(sql)
        ElseIf combofuncaopesquisa.SelectedIndex = -1 And combocategoriapesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonome.Text & "%'"
            carregarutilizador(sql)
        ElseIf combonome.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where f.Funcao like '" & combofuncaopesquisa.Text & "%' and A.nome like '" & combocategoriapesquisa.Text & "%'"
            carregarutilizador(sql)
        ElseIf combofuncaopesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonome.Text & "%' and A.nome like '" & combocategoriapesquisa.Text & "%'"
            carregarutilizador(sql)
        ElseIf combocategoriapesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonome.Text & "%' and f.Funcao like '" & combofuncaopesquisa.Text & "%'"
            carregarutilizador(sql)
        Else
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonome.Text & "%' and f.Funcao like '" & combofuncaopesquisa.Text & "%' and A.nome like '" & combocategoriapesquisa.Text & "%'"
            carregarutilizador(sql)
        End If
    End Sub

    Public Sub carregarutilizador(sql As String)
        Call conectar()
        'Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonomehorario.Text & "%' or f.Funcao like '" & combofuncaopesquisa.Text & "%' or A.nome like '" & combocategoriapesquisa.Text & "%'"
        'Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonomehorario.Text & "%' and f.Funcao like '" & combofuncaopesquisa.Text & "%' and A.nome like '" & combocategoriapesquisa.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datutilizadores.Columns.Clear()
        Dim n As Integer = dr.FieldCount

        datutilizadores.Columns.Add(0, "Código")
        datutilizadores.Columns.Add(1, "Utilizador")
        datutilizadores.Columns.Add(2, "Nome")
        datutilizadores.Columns.Add(3, "Função")
        datutilizadores.Columns.Add(4, "Categoria")
        datutilizadores.Columns.Add(5, "Área")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datutilizadores.Rows.Add(linha)
            datutilizadores.Rows(i).Cells(0).Value = dr.Item(0)
            datutilizadores.Rows(i).Cells(1).Value = dr.Item(1)
            datutilizadores.Rows(i).Cells(2).Value = dr.Item(2)
            datutilizadores.Rows(i).Cells(3).Value = dr.Item(3)
            datutilizadores.Rows(i).Cells(4).Value = dr.Item(4)
            datutilizadores.Rows(i).Cells(5).Value = dr.Item(5)
            i = i + 1
        End While
        datutilizadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
        datutilizadores.Columns(5).Visible = False
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

    Public Sub lercategoria(funcao As Integer)
        Call conectar()
        Dim sql As String = "select idArea, nome from Areav where idFuncao = '" & funcao & "' order by nome"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combocategoriapesquisa.SelectedIndex = -1
        combocategoriapesquisa.ValueMember = "idArea"
        combocategoriapesquisa.DisplayMember = "nome"
        combocategoriapesquisa.DataSource = dt

        Call desconectar()
    End Sub

    Public Sub leranolectivo()
        Call conectar()
        Dim sql As String = "select * from anolectivo order by idanolectivo"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combanoletivoregisto.ValueMember = "idanolectivo"
        combanoletivoregisto.DisplayMember = "anolectivo"
        combanoletivoregisto.DataSource = dt

        Call desconectar()
    End Sub

    Public Sub lerturma()
        Call conectar()
        Dim sql As String = "select idTurma, descricao from turma where idAnoLectivo = '" & combanoletivoregisto.SelectedValue & "' order by idTurma"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        comboturmaregistos.ValueMember = "idTurma"
        comboturmaregistos.DisplayMember = "descricao"
        comboturmaregistos.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lerutilizador()
        Call conectar()
        Dim sql As String = "select idUtilizador, utilizador from Utilizador order by idUtilizador"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combonome.ValueMember = "idUtilizador"
        combonome.DisplayMember = "utilizador"
        combonome.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub desbloquearhorario(ByVal estado As Boolean)
        txtnumutilizador.Enabled = estado
        txtUser.Enabled = estado
        txtnomeutilizador.Enabled = estado
        txtFuncao.Enabled = estado
        txtCategoria.Enabled = estado
    End Sub

    Public Sub constregisto(sql As String)
        Call conectar()
        'Dim sql As String = "SELECT R.idregisto, R.idUtilizador,R.data,R.hora,R.viacomunicação,R.telefone,R.telemovel,R.qta,R.destinario,T.descricao,R.tiposerviço,A.anolectivo,R.obs  FROM Registo R, Anolectivo A, turma T  WHERE R.anoletivo=A.idAnolectivo and R.turma=T.idTurma"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridregistos.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datagridregistos.Columns.Add(0, "Código")
        datagridregistos.Columns.Add(1, "Utilizador")
        datagridregistos.Columns.Add(2, "Data")
        datagridregistos.Columns.Add(3, "Hora")
        datagridregistos.Columns.Add(4, "Via Comunicação")
        datagridregistos.Columns.Add(5, "Telefone")
        datagridregistos.Columns.Add(6, "Telemóvel")
        datagridregistos.Columns.Add(7, "Quantidade")
        datagridregistos.Columns.Add(8, "Destino")
        datagridregistos.Columns.Add(9, "Turma")
        datagridregistos.Columns.Add(10, "Tipo de serviço")
        datagridregistos.Columns.Add(11, "Ano Letivo")
        datagridregistos.Columns.Add(12, "Observação")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridregistos.Rows.Add(linha)
            datagridregistos.Rows(i).Cells(0).Value = dr.Item(0)
            datagridregistos.Rows(i).Cells(1).Value = dr.Item(1)
            datagridregistos.Rows(i).Cells(2).Value = dr.Item(2)
            datagridregistos.Rows(i).Cells(3).Value = dr.Item(3)
            datagridregistos.Rows(i).Cells(4).Value = dr.Item(4)
            datagridregistos.Rows(i).Cells(5).Value = dr.Item(5)
            datagridregistos.Rows(i).Cells(6).Value = dr.Item(6)
            datagridregistos.Rows(i).Cells(7).Value = dr.Item(7)
            datagridregistos.Rows(i).Cells(8).Value = dr.Item(8)
            datagridregistos.Rows(i).Cells(9).Value = dr.Item(9)
            datagridregistos.Rows(i).Cells(10).Value = dr.Item(10)
            datagridregistos.Rows(i).Cells(11).Value = dr.Item(11)
            datagridregistos.Rows(i).Cells(12).Value = dr.Item(12)
            i = i + 1
        End While
        datagridregistos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()

    End Sub

    Public Sub ativarregisto(ByVal estado As Boolean)
        lblobrigatoriodestinatarioregistos.Visible = estado
        lblobrigatorioturmaregistos.Visible = estado
        lblobrigatoriotiposerviçoregistos.Visible = estado
        lblobrigatorioanolectivoregistos.Visible = estado
    End Sub

    Public Sub desbloquearegisto(ByVal estado As Boolean)
        'txtnumregistos.Enabled = estado
        'txtdataregistos.Enabled = estado
        'txthorasregisto.Enabled = estado
        combocomuniregistos.Enabled = estado
        txtdestinarioregistos.Enabled = estado
        comboturmaregistos.Enabled = estado
        combotiposerviçosregistos.Enabled = estado
        combanoletivoregisto.Enabled = estado
        txtobsregistos.Enabled = estado
        numdowqtregistos.Enabled = estado
        mtelefoneregistos.Enabled = estado
        mtelefoneregistos.Visible = estado
        mtelemovelregistos.Enabled = estado
        mtelemovelregistos.Visible = estado
    End Sub

    Public Sub limparregisto()
        txtnumutilizador.Clear()
        txtnumutilizador.Enabled = False
        combofuncaopesquisa.SelectedItem = -1
        combocategoriapesquisa.SelectedItem = -1
        txtUser.Clear()
        txtFuncao.Clear()
        txtCategoria.Clear()
        txtnomeutilizador.Clear()
        txtnumregistos.Clear()
        combocomuniregistos.SelectedIndex = -1
        numdowqtregistos.Value = 1
        txtdestinarioregistos.Clear()
        combanoletivoregisto.SelectedIndex = -1
        comboturmaregistos.SelectedIndex = -1
        combotiposerviçosregistos.SelectedIndex = -1
        txtobsregistos.Clear()

    End Sub

    Private Sub btnovohorario_Click(sender As Object, e As EventArgs) Handles btnovoregisto.Click
        Me.Text = " Novo horário"

        txtnumutilizador.Text = datutilizadores.CurrentRow.Cells(0).Value
        txtUser.Text = datutilizadores.CurrentRow.Cells(1).Value
        txtnomeutilizador.Text = datutilizadores.CurrentRow.Cells(2).Value
        txtFuncao.Text = datutilizadores.CurrentRow.Cells(3).Value
        txtCategoria.Text = datutilizadores.CurrentRow.Cells(4).Value
        btncancelarregisto.Enabled = True
        btnovoregisto.Enabled = False
        btneditarregisto.Enabled = False
        btneliminarregisto.Enabled = False
        btnguardarregisto.Enabled = True
        btnsairregisto.Enabled = False
        Dim sql As String = "SELECT R.idregisto, R.idUtilizador,R.data,R.hora,R.viacomunicação,R.telefone,R.telemovel,R.qta,R.destinario,T.descricao,R.tiposerviço,A.anolectivo,R.obs  FROM Registo R, Anolectivo A, turma T  WHERE R.idUtilizador = '" & txtnumutilizador.Text & "' and R.anoletivo=A.idAnolectivo and R.turma=T.idTurma"
        constregisto(sql)
        botao = 1

        desbloquearegisto(True)
        mtelefoneregistos.Enabled = False
        mtelefoneregistos.Visible = False
        mtelemovelregistos.Enabled = False
        mtelemovelregistos.Visible = False
        'ativaregistos(True)
        numdowqtregistos.Enabled = False
    End Sub

    Private Sub btncancelarhorario_Click(sender As Object, e As EventArgs) Handles btncancelarregisto.Click
        Me.Text = "Cancelar horario"
        desbloquearhorario(False)
        desbloquearegisto(False)
        ativarregisto(False)
        btnovoregisto.Enabled = True
        btneditarregisto.Enabled = True
        btneliminarregisto.Enabled = True
        btnguardarregisto.Enabled = False
        btncancelarregisto.Enabled = False
        btnsairregisto.Enabled = True
        limparregisto()
        Dim sql As String = "SELECT R.idregisto, R.idUtilizador,R.data,R.hora,R.viacomunicação,R.telefone,R.telemovel,R.qta,R.destinario,T.descricao,R.tiposerviço,A.anolectivo,R.obs  FROM Registo R, Anolectivo A, turma T  WHERE R.anoletivo=A.idAnolectivo and R.turma=T.idTurma"
        constregisto(Sql)
    End Sub

    Private Sub btnsairhorario_Click(sender As Object, e As EventArgs) Handles btnsairregisto.Click
        Me.Close()
        If tipouser = 0 Then
            Bloquear_menu(False)
            formulario_principal.tsbUtilizador.Enabled = True
            formulario_principal.tsbRegistos.Enabled = True
            formulario_principal.tsbHorario.Enabled = True
            formulario_principal.tsbSair.Enabled = True
        Else
            Bloquear_menu(True)
        End If
    End Sub

    Private Sub Registo_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridregistos.AllowUserToAddRows = False
        datutilizadores.AllowUserToAddRows = False
        Dim sql As String = "SELECT R.idregisto, R.idUtilizador,R.data,R.hora,R.viacomunicação,R.telefone,R.telemovel,R.qta,R.destinario,T.descricao,R.tiposerviço,A.anolectivo,R.obs  FROM Registo R, Anolectivo A, turma T  WHERE R.anoletivo=A.idAnolectivo and R.turma=T.idTurma"
        lerutilizador()
        lerfuncao()
        lerturma()
        leranolectivo()
        consGrelha()
        constregisto(sql)
        combonome.SelectedIndex = -1
        combofuncaopesquisa.SelectedIndex = -1
        combocategoriapesquisa.SelectedIndex = -1
        comboturmaregistos.SelectedIndex = -1
        desbloquearhorario(False)
        desbloquearegisto(False)
        ativarregisto(False)
        btncancelarregisto.Enabled = False
        btnguardarregisto.Enabled = False
        limparregisto()

        lblobrigatoriodestinatarioregistos.Visible = False
        lblobrigatorioturmaregistos.Visible = False
        lblobrigatoriotiposerviçoregistos.Visible = False
        lblobrigatorioanolectivoregistos.Visible = False
        'txtnutilizadoregistos.Enabled = False
        txtdataregistos.Text = DateTime.Now.Date
        mtelefoneregistos.Enabled = False
        mtelefoneregistos.Visible = False
        mtelemovelregistos.Enabled = False
        mtelemovelregistos.Visible = False
        lbltelefoneregisto.Visible = False
        telemovelregistos.Visible = False
        numdowqtregistos.Enabled = False

    End Sub

    Private Sub btneliminarhorario_Click(sender As Object, e As EventArgs) Handles btneliminarregisto.Click

    End Sub

    Private Sub btneditarhorario_Click(sender As Object, e As EventArgs) Handles btneditarregisto.Click

        botao = 2
        btnovoregisto.Enabled = False
        btneliminarregisto.Enabled = False
        btnguardarregisto.Enabled = True
        btncancelarregisto.Enabled = True
        txtnumutilizador.Text = datutilizadores.CurrentRow.Cells(0).Value
        txtUser.Text = datutilizadores.CurrentRow.Cells(1).Value
        txtnomeutilizador.Text = datutilizadores.CurrentRow.Cells(2).Value
        txtFuncao.Text = datutilizadores.CurrentRow.Cells(3).Value
        txtCategoria.Text = datutilizadores.CurrentRow.Cells(4).Value
        btncancelarregisto.Enabled = True
        btnovoregisto.Enabled = False
        btneditarregisto.Enabled = False
        btneliminarregisto.Enabled = False
        btnguardarregisto.Enabled = True
        btnsairregisto.Enabled = False
        Dim sql As String = "SELECT R.idregisto, R.idUtilizador,R.data,R.hora,R.viacomunicação,R.telefone,R.telemovel,R.qta,R.destinario,T.descricao,R.tiposerviço,A.anolectivo,R.obs  FROM Registo R, Anolectivo A, turma T  WHERE R.idUtilizador = '" & txtnumutilizador.Text & "' and R.anoletivo=A.idAnolectivo and R.turma=T.idTurma"
        constregisto(sql)
    End Sub

    Private Sub combonomehorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combonome.SelectedIndexChanged
        ler_sql()
    End Sub

    Private Sub combofuncaopesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combofuncaopesquisa.SelectedIndexChanged
        lercategoria(combofuncaopesquisa.SelectedValue)
        combocategoriapesquisa.SelectedIndex = -1
        ler_sql()
    End Sub

    Private Sub combocategoriapesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocategoriapesquisa.SelectedIndexChanged
        ler_sql()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        combofuncaopesquisa.SelectedIndex = -1
        combocategoriapesquisa.SelectedIndex = -1
        combonome.SelectedIndex = -1
    End Sub

    Private Sub mtelefoneregistos_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtelefoneregistos.MaskInputRejected
        If validar.isvalidtelefone(mtelefoneregistos.Text) = True Then
            mtelefoneregistos.BackColor = Color.Green
        Else
            mtelefoneregistos.BackColor = Color.Red
        End If
    End Sub

    Private Sub Horaregisto_Tick(sender As Object, e As EventArgs) Handles Horaregisto.Tick
        txthorasregisto.Text = TimeOfDay
    End Sub

    Private Sub combocomuniregistos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocomuniregistos.SelectedIndexChanged
        Dim text As String

        'text = combocomuniregistos.SelectedItem.ToString
        text = combocomuniregistos.Text
        If text = "Telefone" Then
            lbltelefoneregisto.Visible = True
            mtelefoneregistos.Visible = True
            mtelefoneregistos.Enabled = True
            mtelefoneregistos.Focus()
        Else
            lbltelefoneregisto.Visible = False
            mtelefoneregistos.Visible = False
            mtelefoneregistos.Enabled = False
        End If
        If text = "Telemóvel" Then
            telemovelregistos.Visible = True
            mtelemovelregistos.Visible = True
            mtelemovelregistos.Enabled = True
            mtelemovelregistos.Focus()
        Else
            telemovelregistos.Visible = False
            mtelemovelregistos.Visible = False
            mtelemovelregistos.Enabled = False
        End If
        If text = "Email" Or text = "Carta" Or text = "Carta Registada" Then
            numdowqtregistos.Enabled = True
            numdowqtregistos.Focus()
        Else
            numdowqtregistos.Enabled = False
        End If
    End Sub

    Private Sub combanoletivoregisto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combanoletivoregisto.SelectedIndexChanged
        lerturma()
    End Sub

    Private Sub btnguardarregisto_Click(sender As Object, e As EventArgs) Handles btnguardarregisto.Click
        ativarregisto(False)

        If txtdestinarioregistos.Text = "" Then
            lblobrigatoriodestinatarioregistos.Visible = True
            txtdestinarioregistos.Focus()
        End If

        If comboturmaregistos.SelectedIndex = -1 Then
            lblobrigatorioturmaregistos.Visible = True
            comboturmaregistos.Focus()
        End If

        If combotiposerviçosregistos.SelectedIndex = -1 Then
            lblobrigatoriotiposerviçoregistos.Visible = True
            combotiposerviçosregistos.Focus()
        End If

        If combanoletivoregisto.SelectedIndex = -1 Then
            lblobrigatorioanolectivoregistos.Visible = True
            combanoletivoregisto.Focus()
        End If

        If lblobrigatorioanolectivoregistos.Visible = False And lblobrigatoriodestinatarioregistos.Visible = False And lblobrigatoriotiposerviçoregistos.Visible = False And lblobrigatorioturmaregistos.Visible = False Then
            If botao = 1 Then
                Call conectar()
                Dim sql1 As String = "insert into Registo Values ('" & txtnumutilizador.Text & "', '" & Format(txtdataregistos.Text, "Short Date") & "','" & txthorasregisto.Text & "','" & combocomuniregistos.SelectedItem & "', '" & mtelefoneregistos.Text & "',  '" & mtelemovelregistos.Text & "', '" & numdowqtregistos.Value & "',  '" & txtdestinarioregistos.Text & "', '" & comboturmaregistos.SelectedValue & "', '" & combotiposerviçosregistos.SelectedItem & "', '" & combanoletivoregisto.SelectedValue & "', '" & txtobsregistos.Text & "')"
                Dim sqlcom As New SqlCommand(sql1, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                Dim sql As String = "SELECT R.idregisto, R.idUtilizador,R.data,R.hora,R.viacomunicação,R.telefone,R.telemovel,R.qta,R.destinario,T.descricao,R.tiposerviço,A.anolectivo,R.obs  FROM Registo R, Anolectivo A, turma T  WHERE R.idUtilizador = '" & txtnumutilizador.Text & "' and R.anoletivo=A.idAnolectivo and R.turma=T.idTurma"
                constregisto(Sql)
                combonome.SelectedItem = -1
                combofuncaopesquisa.SelectedItem = -1
                combocategoriapesquisa.SelectedItem = -1
                combocomuniregistos.SelectedItem = -1
                mtelefoneregistos.Clear()
                mtelemovelregistos.Clear()
                txtdestinarioregistos.Clear()
                comboturmaregistos.SelectedItem = -1
                combotiposerviçosregistos.SelectedItem = -1
                combanoletivoregisto.SelectedItem = -1
                txtobsregistos.Clear()
                btncancelarregisto.Enabled = False
                btnovoregisto.Enabled = True
                btneditarregisto.Enabled = True
                btneliminarregisto.Enabled = True
                btnguardarregisto.Enabled = False
                btnsairregisto.Enabled = True
                btnconsultaregistos.Enabled = True
                limparregisto()
            ElseIf botao = 2 Then
                Call conectar()
                Dim sql1 As String = "update  Registo set  idregisto = '" & txtnumregistos.Text & "' where  = '" & txtnumregistos.Text & "'"
                Dim sqlcon As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
                dr1.Close()
                Call desconectar()
                Dim sql As String = "SELECT R.idregisto, R.idUtilizador,R.data,R.hora,R.viacomunicação,R.telefone,R.telemovel,R.qta,R.destinario,T.descricao,R.tiposerviço,A.anolectivo,R.obs  FROM Registo R, Anolectivo A, turma T  WHERE R.idUtilizador = '" & txtnumutilizador.Text & "' and R.anoletivo=A.idAnolectivo and R.turma=T.idTurma"
                constregisto(Sql)
                combonome.Enabled = False
                limparregisto()
                btncancelarregisto.Enabled = False
                btnovoregisto.Enabled = True
                btneditarregisto.Enabled = True
                btneliminarregisto.Enabled = True
                btnguardarregisto.Enabled = False
                btnsairregisto.Enabled = True
                btnconsultaregistos.Enabled = True
            End If
            desbloquearegisto(False)
            limparregisto()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub datutilizadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datutilizadores.CellContentClick
        Utilizadores.Show()
    End Sub
End Class