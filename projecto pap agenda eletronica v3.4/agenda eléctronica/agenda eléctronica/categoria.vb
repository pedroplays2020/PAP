﻿Imports System.Data.SqlClient

Public Class categoria
    Dim flag As Integer
    Shared ConnectionString As String = "Data Source=.\;Initial Catalog=Agenda;Integrated Security=True"

    Public Sub desbloquearcategoria(ByVal estadocatedoria As Boolean)
        txtnumcategoria.Enabled = estadocatedoria
        txtnomecategoria.Enabled = estadocatedoria
        combofuncaocategoria.Enabled = estadocatedoria
    End Sub

    Public Sub ativar_obrigatoriocategoria(ByVal estadocategoria As Boolean)
        lblobrigatorionomecategoria.Visible = estadocategoria
        lblobrigatoriofumcaocategoria.Visible = estadocategoria
    End Sub

    Public Sub ContarReg()
        Dim total As Integer
        total = datgridcategoria.RowCount
        lblNumReg.Text = total
    End Sub

    Public Sub lerfuncao()
        Call conectar()
        Dim sql As String = "select idFuncao, funcao from Funcao order by idFuncao"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combofuncaocategoria.ValueMember = "idFuncao"
        combofuncaocategoria.DisplayMember = "funcao"
        combofuncaocategoria.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub conscategoria()
        Call conectar()
        'Dim sql As String = "select  * from  Areav "
        Dim sql As String = " select t1.idArea, t1.nome, t2.Funcao, t1.idFuncao from Areav t1  Inner Join  Funcao t2 on (t1.idFuncao = t2.idFuncao) order by t2.funcao"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datgridcategoria.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        'Dim k As Integer
        'Dim campo As String
        'For k = 0 To n - 1

        'campo = dr.GetName(k)
        'datagridtempo.Columns.Add(campo, campo)
        'Next
        'datagridtempo.Columns.Add("Codigo", "Descrição")
        datgridcategoria.Columns.Add(0, "Nº")
        datgridcategoria.Columns.Add(1, "Função")
        datgridcategoria.Columns.Add(2, "Categoria")
        datgridcategoria.Columns.Add(3, "idFunção")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datgridcategoria.Rows.Add(linha)
            datgridcategoria.Rows(i).Cells(0).Value = dr.Item(0)
            datgridcategoria.Rows(i).Cells(1).Value = dr.Item(2)
            datgridcategoria.Rows(i).Cells(2).Value = dr.Item(1)
            datgridcategoria.Rows(i).Cells(3).Value = dr.Item(3)
            i = i + 1
        End While
        datgridcategoria.Columns(3).Visible = False
        datgridcategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        Call desconectar()
    End Sub

    Public Sub conscategoria_pesquisa(funcao As Integer)
        Call conectar()
        'Dim sql As String = "select  * from  Areav "
        'Dim sql As String = " select t1.idArea, t1.nome, t2.Funcao, t1.idFuncao from Areav t1  Inner Join  Funcao t2 on (t1.idFuncao = t2.idFuncao) where t1.idFuncao= '" & funcao & "' order by t2.funcao"
        Dim sql As String = "select t1.idArea, t1.nome, t2.Funcao, t1.idFuncao from Areav t1  Inner Join  Funcao t2 on (t1.idFuncao = t2.idFuncao) " & " where t1.nome like '" & txtnomecategoria.Text & "%' and t1.idFuncao like '" & combofuncaocategoria.SelectedValue & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datgridcategoria.Columns.Clear()
        Dim n As Integer = dr.FieldCount

        datgridcategoria.Columns.Add(0, "Nº")
        datgridcategoria.Columns.Add(1, "Categoria")
        datgridcategoria.Columns.Add(2, "Função")
        datgridcategoria.Columns.Add(3, "idFunção")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datgridcategoria.Rows.Add(linha)
            datgridcategoria.Rows(i).Cells(0).Value = dr.Item(0)
            datgridcategoria.Rows(i).Cells(1).Value = dr.Item(1)
            datgridcategoria.Rows(i).Cells(2).Value = dr.Item(2)
            datgridcategoria.Rows(i).Cells(3).Value = dr.Item(3)
            i = i + 1
        End While
        'datgridcategoria.Columns(3).Visible = False
        datgridcategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        Call desconectar()
    End Sub

    Private Sub categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lerfuncao()
        conscategoria()
        ContarReg()
        lblobrigatorionomecategoria.Visible = False
        lblobrigatoriofumcaocategoria.Visible = False
        btncancelarcategoria.Enabled = False
        btnguardarcategoria.Enabled = False
        desbloquearcategoria(False)
        ativar_obrigatoriocategoria(False)
        gbMensagem.Visible = False
        datgridcategoria.AllowUserToAddRows = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnguardarcategoria.Click
       
        If combofuncaocategoria.SelectedIndex = -1 Then
            lblobrigatoriofumcaocategoria.Visible = True
            combofuncaocategoria.Focus()
        End If
        If txtnomecategoria.Text = "" Then
            lblobrigatorionomecategoria.Visible = True

            txtnomecategoria.Focus()
        End If
        If lblobrigatorionomecategoria.Visible = False And lblobrigatoriofumcaocategoria.Visible = False Then
            'Dim countreg As Integer = datgridcategoria.RowCount.ToString() - 1
            Dim con As SqlConnection = New SqlConnection()
            con.ConnectionString = ConnectionString
            Dim cmd As SqlCommand = con.CreateCommand()
            cmd.CommandText = "SELECT COUNT(*) FROM areav WHERE nome = '" & txtnomecategoria.Text & "' and idFuncao = '" & combofuncaocategoria.SelectedValue & "'"
            con.Open()
            Dim countreg As Integer = Integer.Parse(cmd.ExecuteScalar())

            If countreg = 0 Then
                If flag = 1 Then
                    Call conectar()
                    Dim sql1 As String = "insert into Areav values ('" & RTrim(txtnomecategoria.Text) & "',  '" & RTrim(combofuncaocategoria.SelectedValue) & "')"
                    Dim sqlcom1 As New SqlCommand(sql1, con)
                    Dim dr1 As SqlDataReader = sqlcom1.ExecuteReader
                    Call desconectar()
                    desbloquearcategoria(False)
                    btnovocategoria.Enabled = True
                    btneditarcategoria.Enabled = True
                    btnelimnarcategoria.Enabled = True
                    btnguardarcategoria.Enabled = False
                    btnconsultarcategoria.Enabled = True
                    ativar_obrigatoriocategoria(False)

                    gbMensagem.Visible = True
                    lblMsg.Text = "Categoria Inserida com sucesso."
                    conscategoria()
                    txtnumcategoria.ResetText()
                    txtnomecategoria.ResetText()

                    combofuncaocategoria.SelectedIndex = -1
                    btncancelarcategoria.Enabled = False
                    btnsaircategoria.Enabled = True
                ElseIf flag = 2 Then
                    Dim resultado = MsgBox("Tem a certeza que pretende alterar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Editar Categoria")
                    If resultado = DialogResult.Yes Then
                        Call conectar()
                        Dim sql1 As String = "update  Areav  set nome  = '" & txtnomecategoria.Text & "' where idArea = '" & txtnumcategoria.Text & "'"
                        Dim sqlcom1 As New SqlCommand(sql1, con)
                        Dim dr1 As SqlDataReader = sqlcom1.ExecuteReader
                        Call desconectar()
                        desbloquearcategoria(False)
                        btnovocategoria.Enabled = True
                        btneditarcategoria.Enabled = True
                        btnelimnarcategoria.Enabled = True
                        btnguardarcategoria.Enabled = False
                        btnconsultarcategoria.Enabled = True
                        gbMensagem.Visible = True
                        lblMsg.Text = "Categoria Alterada com sucesso"
                        conscategoria()
                        txtnumcategoria.ResetText()
                        txtnomecategoria.ResetText()

                        combofuncaocategoria.SelectedIndex = -1
                        btncancelarcategoria.Enabled = False
                        btnsaircategoria.Enabled = True
                    End If
                End If
            Else
                'lblobrigatorionomecategoria.Text = "Categoria existente"
                'lblobrigatorionomecategoria.Visible = True
                gbMensagem.Visible = True
                lblMsg.Text = "A Categoria referenciada já se encontra definida no Sistema."
                txtnomecategoria.Focus()
                Exit Sub
            End If
            'Dim sqlcom1 As New SqlCommand(sql1, con)
            'Dim dr1 As SqlDataReader = sqlcom1.ExecuteReader
        End If
        ContarReg()
    End Sub

    Private Sub btnsaircategoria_Click(sender As Object, e As EventArgs) Handles btnsaircategoria.Click
        Me.Close()
        txtnumcategoria.Enabled = False
        Bloquear_menu(True)

    End Sub

    Private Function sql() As Object
        Throw New NotImplementedException
    End Function

    Private Sub btnovocategoria_Click(sender As Object, e As EventArgs) Handles btnovocategoria.Click
        lblMsg.Text = "Inserir Nova Categoria"
        gbMensagem.Visible = True
        desbloquearcategoria(True)
        Me.Text = " Nova categoria"
        txtnumcategoria.Enabled = False
        txtnomecategoria.Enabled = True
        combofuncaocategoria.Enabled = True
        btneditarcategoria.Enabled = False
        btnelimnarcategoria.Enabled = False
        btnconsultarcategoria.Enabled = False
        btnsaircategoria.Enabled = False
        btnguardarcategoria.Enabled = True
        btnovocategoria.Enabled = False
        btncancelarcategoria.Enabled = True
        btnsaircategoria.Enabled = True
        flag = 1
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnelimnarcategoria.Click
        Dim numreg As Integer
        numreg = datgridcategoria.RowCount

        Me.Text = "Eliminar Categoria"
        If numreg = 0 Then
            gbMensagem.Visible = True
            lblMsg.Text = "Não selecionou nenhuma categoria"

        Else
            ContarReg()
            gbMensagem.Visible = False
            ' eliminar dados da  consulta categoria
            'Try
            btnovocategoria.Enabled = False
            btneditarcategoria.Enabled = False
            btnguardarcategoria.Enabled = False
            btnconsultarcategoria.Enabled = False
            btncancelarcategoria.Enabled = True
            txtnumcategoria.Text = datgridcategoria.CurrentRow.Cells(0).Value
            combofuncaocategoria.Text = datgridcategoria.CurrentRow.Cells(1).Value
            txtnomecategoria.Text = datgridcategoria.CurrentRow.Cells(2).Value
            Dim resultado = MsgBox("Tem a certeza que pretende eliminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Categoria")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from Areav where idArea = '" & txtnumcategoria.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                lblMsg.Text = "Categoria eliminada com sucesso"
                gbMensagem.Visible = True
                'MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Categoria")
                conscategoria()
                ContarReg()
            Else
                ativar_obrigatoriocategoria(False)
                desbloquearcategoria(False)
                btnovocategoria.Enabled = True
                btneditarcategoria.Enabled = True
                btnelimnarcategoria.Enabled = True
                btnguardarcategoria.Enabled = False
                btnconsultarcategoria.Enabled = True
                txtnumcategoria.Clear()
                txtnomecategoria.Clear()
                combofuncaocategoria.SelectedIndex = -1
                conscategoria()
                ativar_obrigatoriocategoria(False)
                btnsaircategoria.Enabled = True
                btncancelarcategoria.Enabled = True
            End If
            'Catch
            '    MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Categoria")
            ' End Try
        End If
    End Sub


    Private Sub btbeditarcategoria_Click(sender As Object, e As EventArgs) Handles btneditarcategoria.Click
        Dim numreg As Integer
        numreg = datgridcategoria.RowCount

        Me.Text = "Editar Categoria"
        If numreg = 0 Then
            gbMensagem.Visible = True
            lblMsg.Text = "Não selecionou nenhuma categoria"

            Else
                gbMensagem.Visible = False
                btnovocategoria.Enabled = False
                btnelimnarcategoria.Enabled = False
                btnconsultarcategoria.Enabled = False
                btnguardarcategoria.Enabled = True
                btncancelarcategoria.Enabled = True
                txtnumcategoria.Text = datgridcategoria.CurrentRow.Cells(0).Value
            txtnomecategoria.Text = datgridcategoria.CurrentRow.Cells(1).Value
            ' combofuncaocategoria.Text = datgridcategoria.CurrentRow.Cells(2).Value
                txtnomecategoria.Enabled = True
                flag = 2
            End If

    End Sub

    Private Sub btnconsultarcategoria_Click(sender As Object, e As EventArgs) Handles btnconsultarcategoria.Click
        Me.Text = "Consultar categoria"
        lblMsg.Text = "Para consultar preencha um dos campos."
        gbMensagem.Visible = True
        ContarReg()
        btnovocategoria.Enabled = False
        btncancelarcategoria.Enabled = True
        txtnomecategoria.Enabled = True
        combofuncaocategoria.Enabled = True
        btnconsultarcategoria.Enabled = False


    End Sub

    Private Sub btncancelarcategoria_Click(sender As Object, e As EventArgs) Handles btncancelarcategoria.Click
        gbMensagem.Visible = False
        ativar_obrigatoriocategoria(False)
        desbloquearcategoria(False)
        btnovocategoria.Enabled = True
        btneditarcategoria.Enabled = True
        btnelimnarcategoria.Enabled = True
        btnguardarcategoria.Enabled = False
        btnconsultarcategoria.Enabled = True
        txtnumcategoria.Clear()
        txtnomecategoria.Clear()
        combofuncaocategoria.SelectedIndex = -1
        conscategoria()
        btnsaircategoria.Enabled = True
        btncancelarcategoria.Enabled = True
        ContarReg()
    End Sub

    Private Sub txtnomecategoria_TextChanged(sender As Object, e As EventArgs) Handles txtnomecategoria.TextChanged
        ContarReg()
        Call conectar()
        'Dim sql As String = "select * from Areav " & " where nome like '" & txtnomecategoria.Text & "%'"
        Dim sql As String = "select * from Areav " & " where nome like '" & txtnomecategoria.Text & "%' and idFuncao like '" & combofuncaocategoria.SelectedValue & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datgridcategoria.Columns.Clear()
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datgridcategoria.Columns.Add(campo, campo)
        Next
        datgridcategoria.Columns.Add(0, "Nº")
        datgridcategoria.Columns.Add(1, "Nome")
        datgridcategoria.Columns.Add(2, "Nº Função")
        datgridcategoria.Columns.Add(3, "Função")
        datgridcategoria.Columns(2).Visible = False
        While dr.Read
            Dim linha As New DataGridViewRow
            datgridcategoria.Rows.Add(linha)
            datgridcategoria.Rows(i).Cells(0).Value = dr.Item(0)
            datgridcategoria.Rows(i).Cells(1).Value = dr.Item(1)
            datgridcategoria.Rows(i).Cells(2).Value = dr.Item(2)
            datgridcategoria.Rows(i).Cells(3).Value = combofuncaocategoria.Text
            i = i + 1
        End While

        datgridcategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
        ContarReg()
    End Sub

    Private Sub combofuncaocategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combofuncaocategoria.SelectedIndexChanged
        ContarReg()
        conscategoria_pesquisa(combofuncaocategoria.SelectedValue)
        ContarReg()
    End Sub

    Private Sub lblNumReg_Click(sender As Object, e As EventArgs) Handles lblNumReg.Click

    End Sub
End Class