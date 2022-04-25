Imports System.Data.SqlClient
Public Class ano_letivo
    Shared ConnectionString As String = "Data Source=.\;Initial Catalog=Agenda;Integrated Security=True"
    Public Shared Function verificaranoletivo(anoletivo As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                con.ConnectionString = ConnectionString
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM Anolectivo WHERE anolectivo = '" & anoletivo & "'"
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
        gbmsganoletivo.Visible = False
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
        manoletivo.Focus()
        botao = 1
        constano()
    End Sub

    Private Sub ano_letivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbmsganoletivo.Visible = False
        desbloquearano(False)
        ativaranoletivo(False)
        btncancelarano.Enabled = False
        btnguardarano.Enabled = False
        constano()
        limparano()

    End Sub

    Private Sub btnguardarano_Click(sender As Object, e As EventArgs) Handles btnguardarano.Click

        If botao = 1 Then
            MsgBox(manoletivo.Text)
            If manoletivo.Text = "/" Then
                lblobrigatorioano.Visible = True
                manoletivo.Focus()
            Else
                If verificaranoletivo(manoletivo.Text) = True Then
                    gbmsganoletivo.Visible = True
                    lblmsganoletivo.Text = "O ano a inserir já se encontra registado."
                    Exit Sub
                End If
            End If

            If lblobrigatorioano.Visible = False Then
                Call conectar()
                Dim sql As String = "insert into Anolectivo values ('" & RTrim(manoletivo.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                gbmsganoletivo.Visible = True
                lblmsganoletivo.Text = "ano letivo inserido com sucesso!"

                btnsairano.Enabled = True
                btnovoano.Enabled = True
                btneditarano.Enabled = True
                btneliminarano.Enabled = True
                btnguardarano.Enabled = False
                btnconsultarano.Enabled = True
                btncancelarano.Enabled = False
                manoletivo.Enabled = False
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
            gbmsganoletivo.Visible = True
            lblmsganoletivo.Text = "Ano letivo alterado com sucesso!"
            constano()
            manoletivo.Enabled = False
            limparano()
            btnovoano.Enabled = True
            btneditarano.Enabled = True
            btneliminarano.Enabled = True
            btnguardarano.Enabled = False
            btnconsultarano.Enabled = True
            btncancelarano.Enabled = False
            btnsairano.Enabled = True
        End If

    End Sub

    Private Sub btnsairano_Click(sender As Object, e As EventArgs) Handles btnsairano.Click
        Me.Close()
        Bloquear_menu(True)
    End Sub

    Private Sub btneditarano_Click(sender As Object, e As EventArgs) Handles btneditarano.Click
        manoletivo.Visible = False
        gbmsganoletivo.Visible = False
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
        Me.Text = " Cancelar Ano"
        gbmsganoletivo.Visible = False

        desbloquearano(False)
        ativaranoletivo(False)
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
        lbconsulta.Visible = True
        txtconsultaanoletivo.Visible = True
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
        gbmsganoletivo.Visible = False

        Try
            manoletivo.Visible = True
            btncancelarano.Enabled = True
            txtnunanoletivo.Text = datagridanoletivo.CurrentRow.Cells(0).Value
            manoletivo.Text = datagridanoletivo.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar anolectivo")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from Anolectivo where idAnolectivo = '" & txtnunanoletivo.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                'MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar anolectivo")
                gbmsganoletivo.Visible = True
                lblmsganoletivo.Text = "ano letivo eliminado com sucesso!"
                constano()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar anolectivo")
        End Try
    End Sub

End Class