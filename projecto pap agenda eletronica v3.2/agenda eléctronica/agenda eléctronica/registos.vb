Imports System.Data.SqlClient
Public Class Registo
    Dim botao As Integer

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
        Dim sql As String = "select idTurma, descricao from turma order by idTurma"
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
        combonomeregistos.ValueMember = "idUtilizador"
        combonomeregistos.DisplayMember = "utilizador"
        combonomeregistos.DataSource = dt
        Call desconectar()
    End Sub



    Public Sub lerfuncao()
        Call conectar()
        Dim sql As String = "select idFuncao, funcao from Funcao order by idFuncao"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combofunçaoregistos.ValueMember = "idFuncao"
        combofunçaoregistos.DisplayMember = "funcao"
        combofunçaoregistos.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lercategoria()
        Call conectar()
        Dim sql As String = "select idArea, nome from Areav order by idArea"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combocategoriaregistos.ValueMember = "idArea"
        combocategoriaregistos.DisplayMember = "nome"
        combocategoriaregistos.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub consgrelhautilizador()
        Call conectar()
        Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome from utilizador U, funcao F, areav A  where idUtilizador = '" & combonomeregistos.SelectedValue & "' and U.idFuncao=F.idfuncao and U.idArea=A.idArea"

        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        Grelha.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        
        Grelha.Columns.Add(0, "Código")
        Grelha.Columns.Add(1, "Utilizador")
        Grelha.Columns.Add(2, "Nome")
        Grelha.Columns.Add(3, "Função")
        Grelha.Columns.Add(4, "Categoria")

        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            Grelha.Rows.Add(linha)
            Grelha.Rows(i).Cells(0).Value = dr.Item(0)
            Grelha.Rows(i).Cells(1).Value = dr.Item(1)
            Grelha.Rows(i).Cells(2).Value = dr.Item(2)
            Grelha.Rows(i).Cells(3).Value = dr.Item(3)
            Grelha.Rows(i).Cells(4).Value = dr.Item(4)
            i = i + 1
        End While
        Grelha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()

    End Sub

    Public Sub consgrelhacategoria()
        Call conectar()
        Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome from utilizador U, funcao F, areav A  where idUtilizador = '" & combocategoriaregistos.SelectedValue & "' and U.idFuncao=F.idfuncao and U.idArea=A.idArea"

        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        Grelha.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        'Dim k As Integer
        'Dim campo As String
        'For k = 0 To n - 1
        'campo = dr.GetName(k)
        'Grelha.Columns.Add(campo, campo)
        'Next
        Grelha.Columns.Add(0, "Código")
        Grelha.Columns.Add(1, "Utilizador")
        Grelha.Columns.Add(2, "Nome")
        Grelha.Columns.Add(3, "Função")
        Grelha.Columns.Add(4, "Categoria")

        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            Grelha.Rows.Add(linha)
            Grelha.Rows(i).Cells(0).Value = dr.Item(0)
            Grelha.Rows(i).Cells(1).Value = dr.Item(1)
            Grelha.Rows(i).Cells(2).Value = dr.Item(2)
            Grelha.Rows(i).Cells(3).Value = dr.Item(3)
            Grelha.Rows(i).Cells(4).Value = dr.Item(4)
            i = i + 1
        End While
        Grelha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()

    End Sub

    Public Sub ConsGrelhaFuncao()
        Call conectar()
        Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome from utilizador U, funcao F, areav A  where idUtilizador = '" & combofunçaoregistos.SelectedValue & "' and U.idFuncao=F.idfuncao and U.idArea=A.idArea"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        Grelha.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        'Dim k As Integer
        'Dim campo As String
        'For k = 0 To n - 1
        'campo = dr.GetName(k)
        'Grelha.Columns.Add(campo, campo)
        'Next
        Grelha.Columns.Add(0, "Código")
        Grelha.Columns.Add(1, "Utilizador")
        Grelha.Columns.Add(2, "Nome")
        Grelha.Columns.Add(3, "Função")
        Grelha.Columns.Add(4, "Categoria")

        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            Grelha.Rows.Add(linha)
            Grelha.Rows(i).Cells(0).Value = dr.Item(0)
            Grelha.Rows(i).Cells(1).Value = dr.Item(1)
            Grelha.Rows(i).Cells(2).Value = dr.Item(2)
            Grelha.Rows(i).Cells(3).Value = dr.Item(3)
            Grelha.Rows(i).Cells(4).Value = dr.Item(4)
            i = i + 1
        End While
        Grelha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()

    End Sub

    Public Sub ConsGrelha()
        Call conectar()
        Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome from utilizador U, funcao F, areav A  where U.idFuncao=F.idfuncao and U.idArea=A.idArea"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        Grelha.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        Grelha.Columns.Add(0, "Código")
        Grelha.Columns.Add(1, "Utilizador")
        Grelha.Columns.Add(2, "Nome")
        Grelha.Columns.Add(3, "Função")
        Grelha.Columns.Add(4, "Categoria")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            Grelha.Rows.Add(linha)
            Grelha.Rows(i).Cells(0).Value = dr.Item(0)
            Grelha.Rows(i).Cells(1).Value = dr.Item(1)
            Grelha.Rows(i).Cells(2).Value = dr.Item(2)
            Grelha.Rows(i).Cells(3).Value = dr.Item(3)
            Grelha.Rows(i).Cells(4).Value = dr.Item(4)
            i = i + 1
        End While
        datagridregistos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()

    End Sub


    Public Sub constregisto()
        Call conectar()
        Dim sql As String = "SELECT R.idregisto, R.idUtilizador,R.data,R.hora,R.viacomunicação,R.telefone,R.telemovel,R.qta,R.destinario,T.descricao,R.tiposerviço,A.anolectivo,R.obs  FROM Registo R, Anolectivo A, turma T  WHERE R.anoletivo=A.idAnolectivo and R.turma=T.idTurma"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridregistos.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datagridregistos.Columns.Add(0, "Código")
        datagridregistos.Columns.Add(1, "Utilizador")
        datagridregistos.Columns.Add(2, "data")
        datagridregistos.Columns.Add(3, "hora")
        datagridregistos.Columns.Add(4, "via comunicação")
        datagridregistos.Columns.Add(5, "telefone")
        datagridregistos.Columns.Add(6, "telemovel")
        datagridregistos.Columns.Add(7, "Quantidade")
        datagridregistos.Columns.Add(8, "Destino")
        datagridregistos.Columns.Add(9, "Turma")
        datagridregistos.Columns.Add(10, "Tipo de seviço")
        datagridregistos.Columns.Add(11, "Anoletivo")
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
    Public Sub limparregisto()
        txtnutilizadoregistos.Clear()
        txtnutilizadoregistos.Enabled = False
        combonomeregistos.SelectedItem = -1
        combonomeregistos.Focus()
        combofunçaoregistos.SelectedItem = -1
        combofunçaoregistos.Focus()
        combocategoriaregistos.SelectedItem = -1
        combocategoriaregistos.Focus()


    End Sub
    Public Sub desbloquearegisto(ByVal estado As Boolean)
        txtnumregistos.Enabled = estado
        txtdataregistos.Enabled = estado
        txthorasregisto.Enabled = estado
        combocomuniregistos.Enabled = estado
        txtdestinarioregistos.Enabled = estado
        comboturmaregistos.Enabled = estado
        combotiposerviçosregistos.Enabled = estado
        combanoletivoregisto.Enabled = estado
        txtobsregistos.Enabled = estado
        numdowqtregistos.Enabled = estado

    End Sub

    Public Sub ativaregistos(ByVal estado As Boolean)
        lblobrigatoriodestinatarioregistos.Enabled = estado
        lblobrigatorioturmaregistos.Visible = estado
        lblobrigatoriotiposerviçoregistos.Visible = estado
        lblobrigatorioanolectivoregistos.Visible = estado
    End Sub

    Private Sub btnnovoregisto_Click(sender As Object, e As EventArgs) Handles btnnovoregisto.Click
        Me.Text = " Novo registo"

        txtnutilizadoregistos.Text = Grelha.CurrentRow.Cells(0).Value
        txtUtulizador.Text = Grelha.CurrentRow.Cells(1).Value
        txtnomeutilizadoregisto.Text = Grelha.CurrentRow.Cells(2).Value
        txtfuncaoregistos.Text = Grelha.CurrentRow.Cells(3).Value
        txtcategoriaregisto.Text = Grelha.CurrentRow.Cells(4).Value
        desbloquearegisto(True)
        ativaregistos(True)
        btnconsultaregistos.Enabled = False
        btneliminaregisto.Enabled = False
        btneditaregisto.Enabled = False
        btncancelaregisto.Enabled = True
        btnsairegisto.Enabled = False
        btnguardaregisto.Enabled = True
        btnnovoregisto.Enabled = False
        txtnutilizadoregistos.Enabled = False
        combonomeregistos.Visible = True
        lblnomeutilizadorregistos.Visible = True
        txtnumregistos.Enabled = False
        txtdataregistos.Enabled = False
        txthorasregisto.Enabled = False
        lblobrigatorioanolectivoregistos.Visible = False
        lblobrigatoriodestinatarioregistos.Visible = False
        lblobrigatoriotiposerviçoregistos.Visible = False
        lblobrigatorioturmaregistos.Visible = False
        botao = 1

        numdowqtregistos.Enabled = False
    End Sub

    Private Sub pesquisarregisto_Click(sender As Object, e As EventArgs) Handles btncancelaregisto.Click
        Me.Text = " Cancelar registo"
        desbloquearegisto(False)
        ativaregistos(False)
        txtnumregistos.Clear()
        combocategoriaregistos.SelectedItem = -1
        btnnovoregisto.Enabled = True
        btneditaregisto.Enabled = True
        btneliminaregisto.Enabled = True
        btnguardaregisto.Enabled = False
        btnconsultaregistos.Enabled = True
        btncancelaregisto.Enabled = False
        btnsairegisto.Enabled = True
        limparregisto()
    End Sub


    Private Sub btnguardaregisto_Click(sender As Object, e As EventArgs) Handles btnguardaregisto.Click
        ativaregistos(False)
        If botao = 1 Then
            If txtdestinarioregistos.Text = "" Then
                lblobrigatoriodestinatarioregistos.Visible = True
                txtdestinarioregistos.Focus()

            ElseIf comboturmaregistos.SelectedIndex = -1 Then
                lblobrigatorioturmaregistos.Visible = True
                comboturmaregistos.Focus()

            ElseIf combotiposerviçosregistos.SelectedIndex = -1 Then
                lblobrigatoriotiposerviçoregistos.Visible = True
                combotiposerviçosregistos.Focus()

            ElseIf combanoletivoregisto.SelectedIndex = -1 Then
                lblobrigatorioanolectivoregistos.Visible = True
                combanoletivoregisto.Focus()
            Else
                lblobrigatoriodestinatarioregistos.Visible = False
                lblobrigatorioturmaregistos.Visible = False
                lblobrigatoriotiposerviçoregistos.Visible = False
                lblobrigatorioanolectivoregistos.Visible = False

                Call conectar()
                Dim sql1 As String = "insert into Registo Values ('" & txtnutilizadoregistos.Text & "', '" & Format(txtdataregistos.Text, "Short Date") & "','" & txthorasregisto.Text & "','" & combocomuniregistos.SelectedItem & "', '" & mtelefoneregistos.Text & "',  '" & mtelemovelregistos.Text & "', '" & numdowqtregistos.Value & "',  '" & txtdestinarioregistos.Text & "', '" & comboturmaregistos.SelectedValue & "', '" & combotiposerviçosregistos.SelectedItem & "', '" & combanoletivoregisto.SelectedValue & "', '" & txtobsregistos.Text & "')"
                ', , ,, ,, , , ,)"

                Dim sqlcom As New SqlCommand(sql1, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                constregisto()
                combonomeregistos.SelectedItem = -1
                combofunçaoregistos.SelectedItem = -1
                combocategoriaregistos.SelectedItem = -1
                combocomuniregistos.SelectedItem = -1
                mtelefoneregistos.Clear()
                mtelemovelregistos.Clear()
                txtdestinarioregistos.Clear()
                comboturmaregistos.SelectedItem = -1
                combotiposerviçosregistos.SelectedItem = -1
                combanoletivoregisto.SelectedItem = -1
                txtobsregistos.Clear()
                btnnovoregisto.Enabled = True
                btneditaregisto.Enabled = True
                btneliminaregisto.Enabled = True
                btnguardaregisto.Enabled = False
                btnconsultaregistos.Enabled = True
                btncancelaregisto.Enabled = False
                btnsairegisto.Enabled = True
                limparregisto()
            End If

            ElseIf botao = 2 Then
                Call conectar()
                Dim sql1 As String = "update  Registo set  idregisto = '" & txtnumregistos.Text & "' where  = '" & txtnumregistos.Text & "'"
                Dim sqlcon As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
                dr1.Close()
                Call desconectar()
                constregisto()
                combonomeregistos.Enabled = False
                limparregisto()
                btnnovoregisto.Enabled = True
                btneditaregisto.Enabled = True
                btneliminaregisto.Enabled = True
                btnguardaregisto.Enabled = False
                btnconsultaregistos.Enabled = True
                btncancelaregisto.Enabled = False
            End If
    End Sub
    Private Sub combocomuniregistos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocomuniregistos.SelectedIndexChanged
        Dim text As String

        text = combocomuniregistos.SelectedItem.ToString
        'MsgBox(text)

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

    Private Sub Registo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lerturma()
        leranolectivo()
        lerutilizador()
        lerfuncao()
        lercategoria()
        constregisto()
        ConsGrelha()

        ativaregistos(False)
        desbloquearegisto(False)

        txtnutilizadoregistos.Enabled = False
        combonomeregistos.Enabled = True
        combofunçaoregistos.Enabled = True
        combocategoriaregistos.Enabled = True

        btncancelaregisto.Enabled = False
        btnguardaregisto.Enabled = False
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
        lblnomeutilizadorregistos.Visible = True
        


    End Sub

    Private Sub btnsairegisto_Click(sender As Object, e As EventArgs) Handles btnsairegisto.Click
        Me.Close()
    End Sub

    Private Sub Horaregisto_Tick(sender As Object, e As EventArgs) Handles Horaregisto.Tick
        txthorasregisto.Text = TimeOfDay
    End Sub

    Private Sub mtelefoneregistos_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtelefoneregistos.MaskInputRejected
        If validar.isvalidtelefone(mtelefoneregistos.Text) = True Then
            mtelefoneregistos.BackColor = Color.Green
        Else
            mtelefoneregistos.BackColor = Color.Red
        End If
    End Sub



    Private Sub btneditaregisto_Click(sender As Object, e As EventArgs) Handles btneditaregisto.Click
        combonomeregistos.Visible = False
        lblnomeutilizadorregistos.Visible = True
        botao = 2
        btnnovoregisto.Enabled = False
        btneliminaregisto.Enabled = False
        btnconsultaregistos.Enabled = False
        btnguardaregisto.Enabled = True
        btncancelaregisto.Enabled = True
        txtnutilizadoregistos.Text = Grelha.CurrentRow.Cells(0).Value
        txtUtulizador.Text = Grelha.CurrentRow.Cells(1).Value
        txtnomeutilizadoregisto.Text = Grelha.CurrentRow.Cells(2).Value
        txtfuncaoregistos.Text = Grelha.CurrentRow.Cells(3).Value
        txtcategoriaregisto.Text = Grelha.CurrentRow.Cells(4).Value
        'combonomeregistos.SelectedIndex = Grelha.CurrentRow.Cells(1).Value
        combonomeregistos.Enabled = True
        combonomeregistos.Visible = True
    End Sub



    Private Sub btnconsultaregistos_Click(sender As Object, e As EventArgs) Handles btnconsultaregistos.Click
        btnnovoregisto.Enabled = False
        btncancelaregisto.Enabled = True
        combonomeregistos.Visible = True
        lblnomeutilizadorregistos.Visible = True
        lblfunçãoregistos.Enabled = True
        
        
    End Sub

    Private Sub txtconseliminaregistos_TextChanged(sender As Object, e As EventArgs)
        Call conectar()
        Dim sql As String = "select * from  Registo" & " where  idregisto like '" & txtnumregistos.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datagridregistos.Columns.Clear()
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridregistos.Columns.Add(campo, campo)
        Next
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridregistos.Rows.Add(linha)
            datagridregistos.Rows(i).Cells(0).Value = dr.Item(0)
            datagridregistos.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datagridregistos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub combofunçaoregistos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combofunçaoregistos.SelectedIndexChanged
        ConsGrelhaFuncao()
    End Sub

    Private Sub combocategoriaregistos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocategoriaregistos.SelectedIndexChanged
        consgrelhacategoria()
    End Sub

    Private Sub combonomeregistos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combonomeregistos.SelectedIndexChanged
        consgrelhautilizador()
    End Sub

    Private Sub btneliminaregisto_Click(sender As Object, e As EventArgs) Handles btneliminaregisto.Click
        Try
            txtnumregistos.Visible = False
            btncancelaregisto.Enabled = True
            txtnumregistos.Text = datagridregistos.CurrentRow.Cells(0).Value
            txtnumregistos.Text = datagridregistos.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar registos")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from registo where  idregisto = '" & txtnumregistos.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar registos")
                constregisto()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar registos")
        End Try
    End Sub


    Private Sub txtconsultaregistos_TextChanged(sender As Object, e As EventArgs)
        Call conectar()
        Dim sql As String = "select * from  Registo" & " where  idregisto  like '" & combonomeregistos.SelectedValue & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datagridregistos.Columns.Clear()
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridregistos.Columns.Add(campo, campo)
        Next
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridregistos.Rows.Add(linha)
            datagridregistos.Rows(i).Cells(0).Value = dr.Item(0)
            datagridregistos.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datagridregistos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

End Class





