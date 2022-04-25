Imports System.Data.SqlClient

Public Class função
    Dim botao As Integer

    Public Sub desbloquearfunção(ByVal estadofuncao As Boolean)
        txtfuncaonum.Enabled = estadofuncao
        txtfuncao.Enabled = estadofuncao
    End Sub

    Public Sub ativar_função(ByVal estadofuncao As Boolean)
        lblobrigatoriofuncao.Visible = estadofuncao


    End Sub


    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsairfuncao.Click
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardarfuncao.Click
        If botao = 1 Then
            ativar_função(False)
            'txtfuncaonum.Enabled = False
            If txtfuncao.Text = "" Then
                lblobrigatoriofuncao.Visible = True
                txtfuncao.Focus()
            Else
                lblobrigatoriofuncao.Visible = False
                Call conectar()
                Dim sql As String = "insert into Funcao values ('" & RTrim(txtfuncao.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                consfuncao()
                limpar()
                If botao = 2 Then

                End If
            End If
        End If



    End Sub

    Private Sub função_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desbloquearfunção(False)
        ativar_função(False)
        lblobrigatorionumfuncao.Visible = False
        lblobrigatoriofuncao.Visible = False
        btncancelarfuncao.Enabled = False
        btnguardarfuncao.Enabled = False


        consfuncao()
        limpar()
    End Sub

    Public Sub limpar()
        txtfuncaonum.Clear()
        txtfuncaonum.Enabled = False
        txtfuncao.Clear()
        txtfuncao.Focus()
    End Sub
    ' lista todos os dados da tabela na datagridview
    Public Sub consfuncao()
        Call conectar()
        Dim sql As String = "select * from Funcao"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datgridfuncaocategoria.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        Dim k As Integer
        'Dim campo As String
        For k = 0 To n - 1
            'campo = dr.GetName(k)
            datgridfuncaocategoria.Columns.Add("Código", "Descrição")
        Next
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


    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovofuncao.Click

        Me.Text= " Nova Categoria"
        limpar()
        desbloquearfunção(True)
        txtfuncaonum.Enabled = False
        txtfuncao.Enabled = True
        btncancelarfuncao.Enabled = True
        btnnovofuncao.Enabled = False
        btneditarfuncao.Enabled = False
        btneliminarfuncao.Enabled = False
        btnconsultarfuncao.Enabled = False
        btnsairfuncao.Enabled = False
        btnguardarfuncao.Enabled = True





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
            txtfuncao.Text = RTrim(dr.Item("funcao"))
        End If
        Call desconectar()
    End Sub
    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditarfuncao.Click
        lerfuncao()
        Combopesquisaeditarfuncao.Visible = True
        btnnovofuncao.Enabled = False
        btnconsultarfuncao.Enabled = False

        If Combopesquisaeditarfuncao.Text = "" Then
        Else

        End If
        'txtfuncaonum.Enabled = False
        'If txtfuncao.Text = "" Then
        'lblobrigatoriofuncao.Visible = True
        'txtfuncao.Focus()
        'txtfuncao.Select()
        'Else

        'lblobrigatoriofuncao.Visible = False
        'Call conectar()
        'Dim sql As String = "update Funcao set funcao = '" & RTrim(txtfuncao.Text) & "'"
        'Dim sqlcom As New SqlCommand(sql, con)
        'Dim dr As SqlDataReader = sqlcom.ExecuteReader
        'Call desconectar()
        'consfuncao()
        'limpar()
        'End If

    End Sub

    Private Sub Combopesquisaeditarfuncao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combopesquisaeditarfuncao.SelectedIndexChanged
        carregardadosfuncao()

    End Sub

    Private Sub btncancelarfuncao_Click(sender As Object, e As EventArgs) Handles btncancelarfuncao.Click
        Me.Text = ""
        desbloquearfunção(False)
        ativar_função(True)
        txtfuncaonum.Clear()
        txtfuncao.Clear()
        btnnovofuncao.Enabled = True
        btneditarfuncao.Enabled = True
        btneliminarfuncao.Enabled = True
        btnguardarfuncao.Enabled = False
        btnconsultarfuncao.Enabled = True
        btncancelarfuncao.Enabled = False
        btnsairfuncao.Enabled = True
        limpar()
    End Sub

    Private Sub btneliminarfuncao_Click(sender As Object, e As EventArgs) Handles btneliminarfuncao.Click
        Me.Text = " eliminar função"
    End Sub

    Private Sub btnconsultarfuncao_Click(sender As Object, e As EventArgs) Handles btnconsultarfuncao.Click
        Me.Text = "consultar função"

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class