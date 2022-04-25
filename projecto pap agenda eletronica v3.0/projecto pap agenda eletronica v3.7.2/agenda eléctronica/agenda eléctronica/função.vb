Imports System.Data.SqlClient

Public Class função
    Dim botao As Integer

    'Shared ConnectionString As String = "Data Source=.\;Initial Catalog=Agenda;Integrated Security=True"
    Public Shared Function verificarfuncao(funcao As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                con.ConnectionString = ConnectionString_new
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM funcao WHERE funcao = '" & funcao & "'"
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

    Public Sub limpar()
        txtfuncaonum.Clear()
        txtfuncaonum.Enabled = False
        txtNomefuncao.Clear()
        txtNomefuncao.Focus()
    End Sub

    ' lista todos os dados da tabela na datagridview
    Public Sub consfuncao()
        Call conectar()
        Dim sql As String = "select * from Funcao"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datgridfuncaocategoria.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datgridfuncaocategoria.Columns.Add(0, "Código")
        datgridfuncaocategoria.Columns.Add(1, "Descrição")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datgridfuncaocategoria.Rows.Add(linha)
            datgridfuncaocategoria.Rows(i).Cells(0).Value = dr.Item(0)
            datgridfuncaocategoria.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datgridfuncaocategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Public Sub desbloquearfunção(ByVal estadofuncao As Boolean)
        txtfuncaonum.Enabled = estadofuncao
        txtNomefuncao.Enabled = estadofuncao
    End Sub

    Public Sub ativar_função(ByVal estadofuncao As Boolean)
        lblobrigatoriofuncao.Visible = estadofuncao
    End Sub

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsairfuncao.Click
        gbMSG.Visible = False
        Me.Close()
        If tipouser = 0 Then
            Bloquear_menu(False)
            formulario_principal.tsbFuncao.Enabled = True
        Else
            Bloquear_menu(True)
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardarfuncao.Click
        ativar_função(False)
        If txtNomefuncao.Text = "" Then
            lblobrigatoriofuncao.Visible = True
            txtNomefuncao.Focus()
            Exit Sub
        Else
            If verificarfuncao(txtNomefuncao.Text) = True Then
                gbMSG.Visible = True
                lblmsgutilizador.Text = "A função a inserir já se encontra registada."
                Exit Sub
            End If
        End If

        If botao = 1 Then
            If lblobrigatoriofuncao.Visible = False Then
                Call conectar()
                Dim sql As String = "insert into Funcao values ('" & RTrim(txtNomefuncao.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                consfuncao()
                txtNomefuncao.Enabled = False
                btnnovofuncao.Enabled = True
                btneditarfuncao.Enabled = True
                btneliminarfuncao.Enabled = True
                btnguardarfuncao.Enabled = False
                btnconsultarfuncao.Enabled = True
                btncancelarfuncao.Enabled = False
                btnsairfuncao.Enabled = True
                limpar()
            End If

        ElseIf botao = 2 Then
            If lblobrigatoriofuncao.Visible = False Then
                Call conectar()
                Dim sql1 As String = "update  Funcao set funcao = '" & txtNomefuncao.Text & "' where idFuncao = '" & txtfuncaonum.Text & "'"
                Dim sqlcon As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
                dr1.Close()
                Call desconectar()
                consfuncao()
                txtNomefuncao.Enabled = False
                limpar()
                btnnovofuncao.Enabled = True
                btneditarfuncao.Enabled = True
                btneliminarfuncao.Enabled = True
                btnguardarfuncao.Enabled = False
                btnconsultarfuncao.Enabled = True
                btncancelarfuncao.Enabled = False
            End If
        End If
    End Sub

    Private Sub função_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datgridfuncaocategoria.AllowUserToAddRows = False
        desbloquearfunção(False)
        ativar_função(False)
        txtNomefuncao.Enabled = False
        lblobrigatorionumfuncao.Visible = False
        lblobrigatoriofuncao.Visible = False
        btncancelarfuncao.Enabled = False
        btnguardarfuncao.Enabled = False
        consfuncao()
        limpar()
    End Sub

    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovofuncao.Click
        Me.Text = " Nova Função"
        gbMSG.Visible = False
        limpar()
        desbloquearfunção(True)
        txtfuncaonum.Enabled = False
        txtNomefuncao.Enabled = True
        btncancelarfuncao.Enabled = True
        btnnovofuncao.Enabled = False
        btneditarfuncao.Enabled = False
        btneliminarfuncao.Enabled = False
        btnconsultarfuncao.Enabled = False
        btnsairfuncao.Enabled = False
        btnguardarfuncao.Enabled = True
        btnconsultarfuncao.Enabled = True

        botao = 1
    End Sub
    Public Sub lerfuncao()
        Call conectar()
        Dim sql As String = "select idFuncao, funcao from Funcao order by idFuncao"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        Combopesquisaeditarfuncao.ValueMember = "idFuncao"
        Combopesquisaeditarfuncao.DisplayMember = "funcao"
        Combopesquisaeditarfuncao.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub carregardadosfuncao()
        Call conectar()
        Dim sql As String = "select * from Funcao where funcao = '" & RTrim(Combopesquisaeditarfuncao.Text) & "'"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataReader = com.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            txtfuncaonum.Text = dr.Item("idFuncao")
            txtNomefuncao.Text = RTrim(dr.Item("funcao"))
        End If
        Call desconectar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditarfuncao.Click
        gbMSG.Visible = False
        'txtNomefuncao.Visible = False
        botao = 2
        btnnovofuncao.Enabled = False
        btneliminarfuncao.Enabled = False
        btnconsultarfuncao.Enabled = False
        btnguardarfuncao.Enabled = True
        btncancelarfuncao.Enabled = True
        txtfuncaonum.Text = datgridfuncaocategoria.CurrentRow.Cells(0).Value
        txtNomefuncao.Text = datgridfuncaocategoria.CurrentRow.Cells(1).Value
        txtNomefuncao.Enabled = True

    End Sub

    Private Sub Combopesquisaeditarfuncao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combopesquisaeditarfuncao.SelectedIndexChanged
        carregardadosfuncao()

    End Sub

    Private Sub btncancelarfuncao_Click(sender As Object, e As EventArgs) Handles btncancelarfuncao.Click
        gbMSG.Visible = False
        Me.Text = " Cancelar função"
        desbloquearfunção(False)
        ativar_função(False)
        txtfuncaonum.Clear()
        txtNomefuncao.Clear()
        txtNomefuncao.Enabled = False
        btnnovofuncao.Enabled = True
        btneditarfuncao.Enabled = True
        btneliminarfuncao.Enabled = True
        btnguardarfuncao.Enabled = False
        btnconsultarfuncao.Enabled = True
        btncancelarfuncao.Enabled = False
        btnsairfuncao.Enabled = True
        limpar()
    End Sub

    Private Sub btnconsultarfuncao_Click(sender As Object, e As EventArgs) Handles btnconsultarfuncao.Click
        gbMSG.Visible = False
        btnnovofuncao.Enabled = False
        txtNomefuncao.Enabled = True
        btncancelarfuncao.Enabled = True
        'txtNomefuncao.Visible = True
    End Sub

    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNomefuncao.TextChanged
        Call conectar()
        Dim sql As String = "select * from Funcao " & " where funcao like '" & txtNomefuncao.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datgridfuncaocategoria.Columns.Clear()
        datgridfuncaocategoria.Columns.Add(0, "Código")
        datgridfuncaocategoria.Columns.Add(1, "Descrição")
        While dr.Read
            Dim linha As New DataGridViewRow
            datgridfuncaocategoria.Rows.Add(linha)
            datgridfuncaocategoria.Rows(i).Cells(0).Value = dr.Item(0)
            datgridfuncaocategoria.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datgridfuncaocategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btneliminarfuncao_Click(sender As Object, e As EventArgs) Handles btneliminarfuncao.Click
        gbMSG.Visible = False
        Try
            'txtNomefuncao.Visible = False
            btncancelarfuncao.Enabled = True
            txtfuncaonum.Text = datgridfuncaocategoria.CurrentRow.Cells(0).Value
            txtNomefuncao.Text = datgridfuncaocategoria.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende eliminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Função")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from Funcao where idFuncao = '" & txtfuncaonum.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                'MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Função")
                gbMSG.Visible = True
                lblmsgutilizador.Text = "A função selecionada foi eliminada com sucesso."
                consfuncao()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Função")
        End Try
    End Sub

End Class