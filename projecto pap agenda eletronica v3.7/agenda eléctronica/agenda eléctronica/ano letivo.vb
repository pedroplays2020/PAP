Imports System.Data.SqlClient
Public Class ano_letivo
    Dim botao As Integer

    Public Function verificar_anoletivo() As Boolean
        Using con As SqlConnection = New SqlConnection()
            con.ConnectionString = ConnectionString_new
            Using cmd As SqlCommand = con.CreateCommand()
                cmd.CommandText = "select COUNT(*)  from AnoLectivo where anolectivo= '" & manoletivo.Text & "'"
                con.Open()
                Dim countreg As Integer = Integer.Parse(cmd.ExecuteScalar())
                If countreg = 0 Then
                    Return True
                End If
            End Using
        End Using
    End Function

    Public Sub desbloquearano(ByVal estado As Boolean)
        txtnunanoletivo.Enabled = estado
        manoletivo.Enabled = estado
        cmbEstado.Enabled = estado
    End Sub

    Public Sub ativaranoletivo(ByVal estado As Boolean)
        lblobrigatorioano.Visible = estado
        lblObrigatorioEstado.Visible = estado
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
        datagridanoletivo.Columns.Add(2, "Estado")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridanoletivo.Rows.Add(linha)
            datagridanoletivo.Rows(i).Cells(0).Value = dr.Item(0)
            datagridanoletivo.Rows(i).Cells(1).Value = dr.Item(1)
            datagridanoletivo.Rows(i).Cells(2).Value = dr.Item(2)
            i = i + 1
        End While
        datagridanoletivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Public Sub limparano()
        txtnunanoletivo.Clear()
        txtnunanoletivo.Enabled = False
        manoletivo.Clear()
        cmbEstado.SelectedIndex = -1
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
        manoletivo.Focus()
        botao = 1
        constano()
    End Sub

    Private Sub ano_letivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbInfo.Visible = False
        gbFiltro.Visible = False
        datagridanoletivo.AllowUserToAddRows = False
        manoletivo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        desbloquearano(False)
        ativaranoletivo(False)
        btncancelarano.Enabled = False
        btnguardarano.Enabled = False
        constano()
        limparano()
    End Sub

    Private Sub btnguardarano_Click(sender As Object, e As EventArgs) Handles btnguardarano.Click
        ativaranoletivo(False)

        If cmbEstado.SelectedIndex = -1 Then
            lblObrigatorioEstado.Visible = True
            cmbEstado.Focus()
        End If

        MsgBox(verificar_anoletivo())
        If manoletivo.Text = "" Then
            lblobrigatorioano.Visible = True
            manoletivo.Focus()
        ElseIf verificar_anoletivo() = False Then

        End If

        If lblobrigatorioano.Visible = False And lblObrigatorioEstado.Visible = False Then
            If botao = 1 Then
                Call conectar()
                Dim sql As String = "insert into Anolectivo values ('" & RTrim(manoletivo.Text) & "', '" & RTrim(cmbEstado.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
            ElseIf botao = 2 Then
                Call conectar()
                Dim sql1 As String = "update  Anolectivo set anolectivo = '" & manoletivo.Text & "' and estado = '" & cmbEstado.Text & "' where idAnolectivo  = '" & txtnunanoletivo.Text & "'"
                Dim sqlcon As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
                dr1.Close()
                Call desconectar()

            End If
            constano()
            desbloquearano(False)
            limparano()
            btnovoano.Enabled = True
            btneditarano.Enabled = True
            btneliminarano.Enabled = True
            btnguardarano.Enabled = False
            btnconsultarano.Enabled = True
            btncancelarano.Enabled = False
            btnsairano.Enabled = True
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnsairano_Click(sender As Object, e As EventArgs) Handles btnsairano.Click
        Me.Close()
        If tipouser = 0 Then
            Bloquear_menu(False)
            formulario_principal.AnoLetivoToolStripMenuItem.Enabled = True
        Else
            Bloquear_menu(True)
        End If
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
        cmbEstado.Text = datagridanoletivo.CurrentRow.Cells(2).Value
        manoletivo.Enabled = True
        manoletivo.Visible = True
        cmbEstado.Enabled = True
    End Sub

    Private Sub btncancelarano_Click(sender As Object, e As EventArgs) Handles btncancelarano.Click
        gbFiltro.Visible = False
        gbInfo.Visible = False
        Me.Text = " Cancelar Ano"
        desbloquearano(False)
        ativaranoletivo(False)
        txtnunanoletivo.Clear()
        manoletivo.Clear()
        cmbEstado.SelectedIndex = -1
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
        gbFiltro.Visible = True
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
                MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar anolectivo")
                constano()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar anolectivo")
        End Try
    End Sub

    Private Sub manoletivo_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles manoletivo.TypeValidationCompleted
        'If (e.ReturnValue <> "") Then

        '    Dim valor = (DateTime)e.ReturnValue
        '    MessageBox.Show("Validado: " + valor.ToLongDateString())

        'Else
        '    MessageBox.Show("Informe uma data válida!")
        'End If
    End Sub
End Class