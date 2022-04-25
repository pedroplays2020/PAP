Imports System.Data.SqlClient
Public Class ano_letivo
    Dim botao As Integer
    Public Sub desbloquearano(ByVal estado As Boolean)
        txtnunanoletivo.Enabled = estado
        manoletivo.Enabled = estado
    End Sub
    Public Sub ativaranoletivo(ByVal estado As Boolean)
        lblobrigatorioano.Visible = estado
    End Sub

    Public Sub constano()
        Call conectar()
        Dim sql As String = "select * from Anolectivo"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridanoletivo.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datagridanoletivo.Columns.Add(0, "Código")
        datagridanoletivo.Columns.Add(1, "Descrição")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridanoletivo.Rows.Add(linha)
            datagridanoletivo.Rows(i).Cells(0).Value = dr.Item(0)
            datagridanoletivo.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datagridanoletivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Public Sub limparano()
        txtnunanoletivo.Clear()
        txtnunanoletivo.Enabled = False
        manoletivo.Clear()
    End Sub
    Private Sub btnovoano_Click(sender As Object, e As EventArgs) Handles btnovoano.Click
        Me.Text = " Novo Ano"
        desbloquearano(True)
        btnconsultarano.Enabled = False
        btneliminarano.Enabled = False
        btneditarano.Enabled = False
        btncancelarano.Enabled = True
        btnsairano.Enabled = False
        btnguardarano.Enabled = True
        btnovoano.Enabled = False
        txtnunanoletivo.Enabled = False
        botao = 1
        constano()
    End Sub

    Private Sub ano_letivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desbloquearano(False)
        ativaranoletivo(False)
        btncancelarano.Enabled = False
        btnguardarano.Enabled = False
        constano()
        limparano()

    End Sub

    Private Sub btnguardarano_Click(sender As Object, e As EventArgs) Handles btnguardarano.Click

        If botao = 1 Then

            If manoletivo.Text = "" Then
                lblobrigatorioano.Visible = True
                manoletivo.Focus()
            Else
                lblobrigatorioano.Visible = False
                Call conectar()
                Dim sql As String = "insert into Anolectivo values ('" & RTrim(manoletivo.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                constano()
                limparano()

            End If
        ElseIf botao = 2 Then
            Call conectar()
            Dim sql1 As String = "update  Anolectivo set anolectivo = '" & manoletivo.Text & "' where idAnolectivo  = '" & txtnunanoletivo.Text & "'"
            Dim sqlcon As New SqlCommand(sql1, con)
            Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
            dr1.Close()
            Call desconectar()
            constano()
            manoletivo.Enabled = False
            limparano()
            btnovoano.Enabled = True
            btneditarano.Enabled = True
            btneliminarano.Enabled = True
            btnguardarano.Enabled = False
            btnconsultarano.Enabled = True
            btncancelarano.Enabled = False


        End If
    End Sub

    Private Sub btnsairano_Click(sender As Object, e As EventArgs) Handles btnsairano.Click
        Me.Close()
    End Sub

    Private Sub btneditarano_Click(sender As Object, e As EventArgs) Handles btneditarano.Click
        manoletivo.Visible = False
        botao = 2
        btnovoano.Enabled = False
        btneliminarano.Enabled = False
        btnconsultarano.Enabled = False
        btnguardarano.Enabled = True
        btncancelarano.Enabled = True
        txtnunanoletivo.Text = datagridanoletivo.CurrentRow.Cells(0).Value
        manoletivo.Text = datagridanoletivo.CurrentRow.Cells(1).Value
        manoletivo.Enabled = True
        manoletivo.Visible = True
    End Sub

    Private Sub btncancelarano_Click(sender As Object, e As EventArgs) Handles btncancelarano.Click
1111111: Me.Text = " Cancelar Ano"
        desbloquearano(False)
        ativaranoletivo(True)
        txtnunanoletivo.Clear()
        manoletivo.Clear()
        btnovoano.Enabled = True
        btneditarano.Enabled = True
        btneliminarano.Enabled = True
        btnguardarano.Enabled = False
        btnconsultarano.Enabled = True
        btncancelarano.Enabled = False
        btnsairano.Enabled = True
        limparano()
    End Sub

    Private Sub btnconsultarano_Click(sender As Object, e As EventArgs) Handles btnconsultarano.Click
        btnovoano.Enabled = False
        btncancelarano.Enabled = True
        manoletivo.Visible = True
        manoletivo.Enabled = True
    End Sub

    Private Sub txtconsultaanoletivo_TextChanged(sender As Object, e As EventArgs) Handles txtconsultaanoletivo.TextChanged
        Call conectar()
        Dim sql As String = "select * from Anolectivo " & " where anolectivo like '" & txtconsultaanoletivo.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datagridanoletivo.Columns.Clear()
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridanoletivo.Columns.Add(campo, campo)
        Next
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridanoletivo.Rows.Add(linha)
            datagridanoletivo.Rows(i).Cells(0).Value = dr.Item(0)
            datagridanoletivo.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datagridanoletivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btneliminarano_Click(sender As Object, e As EventArgs) Handles btneliminarano.Click
        Try
            manoletivo.Visible = False
            btncancelarano.Enabled = True
            txtnunanoletivo.Text = datagridanoletivo.CurrentRow.Cells(0).Value
            txtconsultaanoletivo.Text = datagridanoletivo.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar anolectivo")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from Anolectivo where idAnolectivo = '" & txtnunanoletivo.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar anolectivo")
                constano()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar anolectivo")
        End Try
    End Sub

End Class