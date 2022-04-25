Imports System.Data.SqlClient
Public Class ano_letivo
    Dim botao As Integer
    Dim anoletivo As String
    Dim anoletivo_new As String

    Public Function verificar_anoletivo(sql As String) As Boolean
        Using con As SqlConnection = New SqlConnection()
            con.ConnectionString = ConnectionString_new
            Using cmd As SqlCommand = con.CreateCommand()
                cmd.CommandText = sql
                con.Open()
                Dim countreg As Integer = Integer.Parse(cmd.ExecuteScalar())
                If countreg = 0 Then
                    Return True
                End If
            End Using
        End Using
        'Return False
    End Function

    Public Sub desbloquearano(ByVal estado As Boolean)
        txtnunanoletivo.Enabled = estado
        'txtanoletivo.Enabled = estado
        cmbEstado.Enabled = estado
    End Sub

    Public Sub ativaranoletivo(ByVal estado As Boolean)
        lblobrigatorioano.Visible = estado
        lblObrigatorioEstado.Visible = estado
    End Sub

    Public Sub constano(sql As String)
        Call conectar()
        Dim sqlcom As New SqlCommand(Sql, con)
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
        txtanoletivo.Clear()
        cmbEstado.SelectedIndex = -1
    End Sub
    Private Sub btnovoano_Click(sender As Object, e As EventArgs) Handles btnovoano.Click
        Me.Text = " Novo Ano"
        limparano()
        gbInfo.Visible = False
        desbloquearano(False)
        btnconsultarano.Enabled = False
        btneliminarano.Enabled = False
        btneditarano.Enabled = False
        btncancelarano.Enabled = True
        btnsairano.Enabled = False
        btnguardarano.Enabled = True
        btnovoano.Enabled = False
        txtnunanoletivo.Enabled = False
        txtanoletivo.Focus()
        Dim resultado = MsgBox("Tem a certeza que pretende criar o Ano Letivo " & anoletivo & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Novo ano lectivo")
        If resultado = DialogResult.Yes Then
            desbloquearano(False)
            Dim sql3 As String = "select COUNT(*) from AnoLectivo where anolectivo= '" & anoletivo & "'"
            If verificar_anoletivo(sql3) = False Then
                gbInfo.Visible = True
                lblInfo.Text = "O ano letivo " & anoletivo & " já se encontra inserido no sistema."
                btnovoano.Enabled = True
                btneditarano.Enabled = True
                btneliminarano.Enabled = True
                btnguardarano.Enabled = False
                btnconsultarano.Enabled = True
                btncancelarano.Enabled = False
                btnsairano.Enabled = True
            End If

            Dim sql2 As String = "select COUNT(*) from AnoLectivo where estado = 'Ativo'"
            If verificar_anoletivo(sql2) = False Then
                gbInfo.Visible = True
                lblInfo.Text = "Não pode inserir o ano letivo " & anoletivo & ", tendo para isso de terminar os anos letivos definidos como ATIVO."
                btnovoano.Enabled = True
                btneditarano.Enabled = True
                btneliminarano.Enabled = True
                btnguardarano.Enabled = False
                btnconsultarano.Enabled = True
                btncancelarano.Enabled = False
                btnsairano.Enabled = True
            End If

            If verificar_anoletivo(sql3) = True And verificar_anoletivo(sql2) = True Then
                cmbEstado.Text = "Ativo"
                txtanoletivo.Text = anoletivo
                gbInfo.Visible = True
                lblInfo.Text = "Para validar o ano letivo " & anoletivo & ", clique no botão GUARDAR."
            End If
        Else
            Dim resultado_new = MsgBox("Tem a certeza que pretende criar o Ano Letivo " & anoletivo_new & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Novo ano lectivo")
            If resultado_new = DialogResult.Yes Then
                desbloquearano(False)
                Dim sql4 As String = "select COUNT(*) from AnoLectivo where anolectivo= '" & anoletivo_new & "'"
                If verificar_anoletivo(sql4) = False Then
                    gbInfo.Visible = True
                    lblInfo.Text = "O ano letivo " & anoletivo_new & " já se encontra inserido no sistema."
                    btnovoano.Enabled = True
                    btneditarano.Enabled = True
                    btneliminarano.Enabled = True
                    btnguardarano.Enabled = False
                    btnconsultarano.Enabled = True
                    btncancelarano.Enabled = False
                    btnsairano.Enabled = True
                End If

                Dim sql5 As String = "select COUNT(*) from AnoLectivo where estado = 'Ativo'"
                If verificar_anoletivo(sql5) = False Then
                    gbInfo.Visible = True
                    lblInfo.Text = "Não pode inserir o ano letivo " & anoletivo_new & ", tendo para isso de terminar os anos letivos definidos como ATIVO."
                    btnovoano.Enabled = True
                    btneditarano.Enabled = True
                    btneliminarano.Enabled = True
                    btnguardarano.Enabled = False
                    btnconsultarano.Enabled = True
                    btncancelarano.Enabled = False
                    btnsairano.Enabled = True
                End If

                If verificar_anoletivo(sql5) = True And verificar_anoletivo(sql4) = True Then
                    cmbEstado.Text = "Ativo"
                    txtanoletivo.Text = anoletivo
                    gbInfo.Visible = True
                    lblInfo.Text = "Para validar o ano letivo " & anoletivo_new & ", clique no botão GUARDAR."
                End If
            Else
                gbFiltro.Visible = False
                gbInfo.Visible = False
                Me.Text = " Cancelar Ano"
                desbloquearano(False)
                ativaranoletivo(False)
                txtnunanoletivo.Clear()
                txtanoletivo.Clear()
                cmbEstado.SelectedIndex = -1
                btnovoano.Enabled = True
                btneditarano.Enabled = True
                btneliminarano.Enabled = True
                btnguardarano.Enabled = False
                btnconsultarano.Enabled = True
                btncancelarano.Enabled = False
                btnsairano.Enabled = True
                limparano()
            End If
        End If
        botao = 1
        Dim sql As String = "select * from Anolectivo"
        constano(sql)
    End Sub

    Private Sub ano_letivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anoletivo = Now.Year & "/" & Now.Year + 1
        anoletivo_new = Now.Year - 1 & "/" & Now.Year
        gbInfo.Visible = False
        gbFiltro.Visible = False
        datagridanoletivo.AllowUserToAddRows = False
        'txtanoletivo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        desbloquearano(False)
        ativaranoletivo(False)
        btncancelarano.Enabled = False
        btnguardarano.Enabled = False
        Dim sql As String = "select * from Anolectivo"
        constano(sql)
        limparano()
    End Sub

    Private Sub btnguardarano_Click(sender As Object, e As EventArgs) Handles btnguardarano.Click
        ativaranoletivo(False)

        If cmbEstado.SelectedIndex = -1 Then
            lblObrigatorioEstado.Visible = True
            cmbEstado.Focus()
        End If

        Dim sql3 As String = "select COUNT(*) from AnoLectivo where estado = 'Ativo'"
        If verificar_anoletivo(sql3) = False And cmbEstado.Text = "Ativo" Then
            gbInfo.Visible = True
            lblInfo.Text = "Não pode alterar o estado do ano letivo " & anoletivo & ", tendo para isso de terminar os anos letivos definidos como ATIVO."
            btnovoano.Enabled = True
            btneditarano.Enabled = True
            btneliminarano.Enabled = True
            btnguardarano.Enabled = False
            btnconsultarano.Enabled = True
            btncancelarano.Enabled = False
            btnsairano.Enabled = True
            desbloquearano(False)
            Exit Sub
        End If

        If lblobrigatorioano.Visible = False And lblObrigatorioEstado.Visible = False Then
            If botao = 1 Then
                Call conectar()
                Dim sql As String = "insert into Anolectivo values ('" & RTrim(txtanoletivo.Text) & "', '" & RTrim(cmbEstado.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
            ElseIf botao = 2 Then
                Call conectar()
                Dim sql1 As String = "update  Anolectivo set anolectivo = '" & txtanoletivo.Text & "', estado = '" & cmbEstado.Text & "' where idAnolectivo  = '" & txtnunanoletivo.Text & "'"
                Dim sqlcon As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
                dr1.Close()
                Call desconectar()

            End If
            Dim sql2 As String = "select * from Anolectivo"
            constano(sql2)

            limparano()
            btnovoano.Enabled = True
            btneditarano.Enabled = True
            btneliminarano.Enabled = True
            btnguardarano.Enabled = False
            btnconsultarano.Enabled = True
            btncancelarano.Enabled = False
            btnsairano.Enabled = True
            gbInfo.Visible = False
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnsairano_Click(sender As Object, e As EventArgs) Handles btnsairano.Click
        Dim sql3 As String = "select COUNT(*) from AnoLectivo where estado = 'Ativo'"
        If verificar_anoletivo(sql3) = False Then
            Me.Close()
            If tipouser = 0 Then
                Bloquear_menu(False)
                formulario_principal.AnoLetivoToolStripMenuItem.Enabled = True
            Else
                Bloquear_menu(True)
            End If
        Else
            gbInfo.Visible = True
            lblInfo.Text = "O administrador tem de definir pelo menos um Ano letivo como ATIVO."
        End If
    End Sub

    Private Sub btneditarano_Click(sender As Object, e As EventArgs) Handles btneditarano.Click
        'txtanoletivo.Visible = False
        botao = 2
        gbInfo.Visible = False
        btnovoano.Enabled = False
        btneliminarano.Enabled = False
        btnconsultarano.Enabled = False
        btnguardarano.Enabled = True
        btncancelarano.Enabled = True
        txtnunanoletivo.Text = datagridanoletivo.CurrentRow.Cells(0).Value
        txtanoletivo.Text = datagridanoletivo.CurrentRow.Cells(1).Value
        cmbEstado.Text = datagridanoletivo.CurrentRow.Cells(2).Value
        'txtanoletivo.Enabled = True
        'txtanoletivo.Visible = True
        cmbEstado.Enabled = True
    End Sub

    Private Sub btncancelarano_Click(sender As Object, e As EventArgs) Handles btncancelarano.Click
        gbFiltro.Visible = False
        gbInfo.Visible = False
        Me.Text = " Cancelar Ano"
        desbloquearano(False)
        ativaranoletivo(False)
        txtnunanoletivo.Clear()
        txtanoletivo.Clear()
        cmbEstado.SelectedIndex = -1
        btnovoano.Enabled = True
        btneditarano.Enabled = True
        btneliminarano.Enabled = True
        btnguardarano.Enabled = False
        btnconsultarano.Enabled = True
        btncancelarano.Enabled = False
        btnsairano.Enabled = True
        Dim sql As String = "select * from Anolectivo"
        constano(sql)
        limparano()
    End Sub

    Private Sub btnconsultarano_Click(sender As Object, e As EventArgs) Handles btnconsultarano.Click
        gbFiltro.Visible = True
        lbconsulta.Visible = True
        txtconsultaanoletivo.Visible = True
        btnovoano.Enabled = False
        btncancelarano.Enabled = True
        'txtanoletivo.Visible = True
        'txtanoletivo.Enabled = True
    End Sub

    Private Sub txtconsultaanoletivo_TextChanged(sender As Object, e As EventArgs) Handles txtconsultaanoletivo.TextChanged
        Dim sql As String = "select * from Anolectivo " & " where anolectivo like '" & txtconsultaanoletivo.Text & "%'"
        constano(sql)
    End Sub

    Private Sub btneliminarano_Click(sender As Object, e As EventArgs) Handles btneliminarano.Click
        Try
            gbInfo.Visible = False
            btncancelarano.Enabled = True
            txtnunanoletivo.Text = datagridanoletivo.CurrentRow.Cells(0).Value
            txtanoletivo.Text = datagridanoletivo.CurrentRow.Cells(1).Value
            cmbEstado.Text = datagridanoletivo.CurrentRow.Cells(2).Value
            If cmbEstado.Text = "Ativo" Then
                gbInfo.Visible = True
                lblInfo.Text = "O ano letivo " & txtanoletivo.Text & " não pode ser eliminado "
                Exit Sub
            Else
                Dim resultado = MsgBox("Tem a certeza que pretende eliminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar anolectivo")
                If resultado = DialogResult.Yes Then
                    Call conectar()
                    Dim sql As String = "delete from Anolectivo where idAnolectivo = '" & txtnunanoletivo.Text & "'"
                    Dim sqlcom As New SqlCommand(sql, con)
                    Dim dr As SqlDataReader = sqlcom.ExecuteReader
                    Call desconectar()
                    MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar anolectivo")
                    Dim sql1 As String = "select * from Anolectivo"
                    constano(sql1)
                End If
            End If
            
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar anolectivo")
        End Try
    End Sub

    Private Sub manoletivo_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs)
        'If (e.ReturnValue <> "") Then

        '    Dim valor = (DateTime)e.ReturnValue
        '    MessageBox.Show("Validado: " + valor.ToLongDateString())

        'Else
        '    MessageBox.Show("Informe uma data válida!")
        'End If
    End Sub

    Private Sub gbFiltro_Enter(sender As Object, e As EventArgs) Handles gbFiltro.Enter

    End Sub
End Class