
Imports System.Data.SqlClient

Public Class blocoSala
    Dim botao, tab As Integer

    Public Shared Function verificarbloco(bloco As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                con.ConnectionString = ConnectionString_new
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM bloco WHERE nomebloco = '" & bloco & "'"
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

    Public Shared Function verificarsala(sala As String, bloco As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                con.ConnectionString = ConnectionString_new
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM sala WHERE sala = '" & sala & "' and idbloco = '" & bloco & "'"
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

    Public Sub desbloquear_sala(ByVal estado As Boolean)
        txtnomesala.Enabled = estado
    End Sub
    Public Sub desbloquear_bloco(ByVal estado As Boolean)
        txtnomebloco.Enabled = estado
        txtnomesala.Enabled = estado
        comblocosala.Enabled = estado
    End Sub
    Public Sub ativar_sala(ByVal estado As Boolean)
        lblobrigatorionomesala.Visible = estado
    End Sub
    Public Sub ativar_bloco(ByVal estado As Boolean)
        lblobrigatorionomebloco.Visible = estado
    End Sub

    Public Sub limparsala()
        txtnumsala.Clear()
        txtnomesala.Clear()
        comblocosala.SelectedIndex = -1
    End Sub
    Public Sub limparbloco()
        txtbloconum.Clear()
        txtnomebloco.Clear()
    End Sub

    Public Sub carregarbloco()
        Call conectar()
        Dim sql As String = "select idbloco, nomebloco from bloco order by idbloco"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        comblocosala.ValueMember = "idbloco"
        comblocosala.DisplayMember = "nomebloco"
        comblocosala.DataSource = dt
        Call desconectar()
        comblocosala.SelectedIndex = -1
    End Sub

    Public Sub gridbsala(sql As String)
        Call conectar()
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridsala.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datagridsala.Columns.Add(0, "Código")
        datagridsala.Columns.Add(1, "Sala")
        datagridsala.Columns.Add(2, "Bloco")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridsala.Rows.Add(linha)
            datagridsala.Rows(i).Cells(0).Value = dr.Item(0)
            datagridsala.Rows(i).Cells(1).Value = dr.Item(1)
            datagridsala.Rows(i).Cells(2).Value = dr.Item(2)
            i = i + 1
        End While
        datagridsala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Public Sub gridbloco()
        Call conectar()
        Dim sql As String = "select * from bloco"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        DataGridBloco.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        DataGridBloco.Columns.Add(0, "Código")
        DataGridBloco.Columns.Add(1, "Descrição")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            DataGridBloco.Rows.Add(linha)
            DataGridBloco.Rows(i).Cells(0).Value = dr.Item(0)
            DataGridBloco.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        DataGridBloco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btnnovofuncao_Click(sender As Object, e As EventArgs) Handles btnnovoblocosala.Click
        gbMSG.Visible = False
        comblocosala.Enabled = True
        If tab = 1 Then
            gridbloco()
            gbBloco.Visible = True
            Me.Text = " Novo bloco"
            limparbloco()
            desbloquear_bloco(True)
            txtbloconum.Enabled = False
            txtnomebloco.Enabled = True
            lblobrigatorionomebloco.Visible = False
            btncancelarblocosala.Enabled = True
            btnnovoblocosala.Enabled = False
            btneditarblocosala.Enabled = False
            btneliminarblocosala.Enabled = False
            btnconsultarblocosala.Enabled = False
            btnsairblocosala.Enabled = False
            btnguardarblocosala.Enabled = True

            botao = 1
        ElseIf tab = 2 Then
            gbMSG.Visible = False
            gbsala.Visible = True
            Me.Text = "Nova sala"
            desbloquear_sala(True)
            txtnumsala.Enabled = False
            txtnomesala.Enabled = True
            lblobrigatorionomesala.Visible = False
            btncancelarblocosala.Enabled = True
            btnnovoblocosala.Enabled = False
            btneditarblocosala.Enabled = False
            btneliminarblocosala.Enabled = False
            btnconsultarblocosala.Enabled = False
            btnguardarblocosala.Enabled = True
            btnsairblocosala.Enabled = True
            botao = 1
            carregarbloco()
        End If
    End Sub

    Private Sub blocoSala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridBloco.AllowUserToAddRows = False
        datagridsala.AllowUserToAddRows = False
        gbMSG.Visible = False
        gbBloco.Visible = True
        gridbloco()
        comblocosala.Enabled = False
        gbsala.Visible = True
        Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B where S.idbloco= B.idbloco"
        gridbsala(sql)
        If tab = 1 Then
            tpBloco.Select()
            lblobrigatorionomebloco.Visible = False
            btncancelarblocosala.Enabled = False
            btnguardarblocosala.Enabled = False
            btneliminarblocosala.Enabled = True
            desbloquear_bloco(False)
            ativar_bloco(False)
        ElseIf tab = 2 Then
            tpSala.Select()

            lblobrigatorionomesala.Visible = False
            btncancelarblocosala.Enabled = False
            btnguardarblocosala.Enabled = False
            btneliminarblocosala.Enabled = True
            desbloquear_sala(False)
            ativar_sala(False)
            'lblnumsala.Enabled = False
            txtnumsala.Enabled = False
        End If

    End Sub

    Private Sub tpBloco_Layout(sender As Object, e As LayoutEventArgs) Handles tpBloco.Layout
        tab = 1
    End Sub

    Private Sub tpSala_Layout(sender As Object, e As LayoutEventArgs) Handles tpSala.Layout
        tab = 2
    End Sub

    Private Sub btnguardarblocosala_Click(sender As Object, e As EventArgs) Handles btnguardarblocosala.Click

        If tab = 1 Then
            lblobrigatorionomebloco.Visible = False
            If txtnomebloco.Text = "" Then
                lblobrigatorionomebloco.Visible = True
                txtnomebloco.Focus()
                Exit Sub
            Else
                If verificarbloco(txtnomebloco.Text) = True Then
                    gbMSG.Visible = True
                    lblmsgutilizador.Text = "O BLOCO a inserir já se encontra registado."
                    Exit Sub
                End If
            End If

            If botao = 1 Then
                If lblobrigatorionomebloco.Visible = False Then
                    Call conectar()
                    Dim sql As String = "insert into bloco values ('" & RTrim(txtnomebloco.Text) & "')"
                    Dim sqlcom As New SqlCommand(sql, con)
                    Dim dr As SqlDataReader = sqlcom.ExecuteReader
                    Call desconectar()
                    gridbloco()
                    gbMSG.Visible = True
                    lblmsgutilizador.Text = "Bloco foi inserido com sucesso!"
                    txtbloconum.ResetText()
                    txtnomebloco.ResetText()
                    txtnomebloco.Enabled = False
                    btnnovoblocosala.Enabled = True
                    btneditarblocosala.Enabled = True
                    btneditarblocosala.Enabled = True
                    btnguardarblocosala.Enabled = False
                    btnconsultarblocosala.Enabled = True
                    btneliminarblocosala.Enabled = True
                    btncancelarblocosala.Enabled = False
                    btnsairblocosala.Enabled = True
                    limparbloco()
                End If
            ElseIf botao = 2 Then
                Call conectar()
                Dim sql1 As String = "update bloco  set nomebloco  = '" & txtnomebloco.Text & "' where idbloco= '" & txtbloconum.Text & "'"
                Dim sqlcon1 As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcon1.ExecuteReader
                dr1.Close()
                Call desconectar()
                gridbloco()
                gbMSG.Visible = True
                lblmsgutilizador.Text = "Bloco foi Alterado com sucesso!"
                limparbloco()
                btnnovoblocosala.Enabled = True
                btneditarblocosala.Enabled = True
                btneditarblocosala.Enabled = True
                btnguardarblocosala.Enabled = False
                btnconsultarblocosala.Enabled = True
                btneliminarblocosala.Enabled = True
                btncancelarblocosala.Enabled = False
                btnsairblocosala.Enabled = True
            End If
        ElseIf tab = 2 Then
            lblobrigatorionomesala.Visible = False
            If txtnomesala.Text = "" Or comblocosala.SelectedIndex = -1 Then
                If txtnomesala.Text = "" Then
                    lblobrigatorionomesala.Visible = True
                    txtnomesala.Focus()
                End If
                If comblocosala.SelectedIndex = -1 Then
                    lblobrigBlocoSala.Visible = True
                    comblocosala.Focus()
                End If
                Exit Sub
            Else
                If verificarsala(txtnomesala.Text, comblocosala.SelectedValue) = True Then
                    gbMSG1.Visible = True
                    lblmsgSala.Text = "A SALA a inserir já se encontra registada."
                    Exit Sub
                End If
            End If
            If botao = 1 Then
                If lblobrigatorionomesala.Visible = False Then
                    Call conectar()
                    Dim sql2 As String = "insert into sala values ('" & RTrim(txtnomesala.Text) & "', '" & comblocosala.SelectedValue & "')"
                    Dim sqlcom2 As New SqlCommand(sql2, con)
                    Dim dr As SqlDataReader = sqlcom2.ExecuteReader
                    Call desconectar()
                    gbMSG1.Visible = True
                    lblmsgSala.Text = "Sala inserida com sucesso!"
                    txtnumsala.ResetText()
                    txtnomesala.ResetText()
                    btnnovoblocosala.Enabled = True
                    btneditarblocosala.Enabled = True
                    btneditarblocosala.Enabled = True
                    btnguardarblocosala.Enabled = False
                    btnconsultarblocosala.Enabled = True
                    btneliminarblocosala.Enabled = True
                    btncancelarblocosala.Enabled = False
                    txtnomebloco.Enabled = False
                    btnsairblocosala.Enabled = True
                    txtnomesala.Enabled = False
                    comblocosala.Enabled = False
                End If
            ElseIf botao = 2 Then
                Call conectar()
                Dim sql3 As String = "update sala  set sala  = '" & txtnomesala.Text & "', idbloco = '" & comblocosala.SelectedValue & "' where idsala= '" & txtnumsala.Text & "' and idbloco = '" & comblocosala.SelectedValue & "'"
                Dim sqlcon3 As New SqlCommand(sql3, con)
                Dim dr3 As SqlDataReader = sqlcon3.ExecuteReader
                dr3.Close()
                Call desconectar()
                gbMSG1.Visible = True
                lblmsgSala.Text = "Sala atlerada com sucesso!"
                btnnovoblocosala.Enabled = True
                btneditarblocosala.Enabled = True
                btneditarblocosala.Enabled = True
                btnguardarblocosala.Enabled = False
                btnconsultarblocosala.Enabled = True
                btneliminarblocosala.Enabled = True
                btncancelarblocosala.Enabled = False
                txtnomebloco.Enabled = False
                btnsairblocosala.Enabled = True
            End If
            limparsala()
            Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B where S.idbloco= B.idbloco"
            gridbsala(sql)
        End If
    End Sub

    Private Sub btnconsultarblocosala_Click(sender As Object, e As EventArgs) Handles btnconsultarblocosala.Click
        gbMSG.Visible = False

        If tab = 1 Then
            btnnovoblocosala.Enabled = False
            btncancelarblocosala.Enabled = True
            txtnomebloco.Enabled = True
        ElseIf tab = 2 Then
            carregarbloco()
            btnnovoblocosala.Enabled = False
            btncancelarblocosala.Enabled = True
            txtnomesala.Enabled = True
            comblocosala.Enabled = True
        End If

    End Sub

    Private Sub btneditarblocosala_Click(sender As Object, e As EventArgs) Handles btneditarblocosala.Click
        gbMSG.Visible = False
        If tab = 1 Then
            botao = 2
            btnnovoblocosala.Enabled = False
            btneliminarblocosala.Enabled = False
            btnconsultarblocosala.Enabled = False
            btnguardarblocosala.Enabled = True
            btncancelarblocosala.Enabled = True
            txtbloconum.Text = DataGridBloco.CurrentRow.Cells(0).Value
            txtnomebloco.Text = DataGridBloco.CurrentRow.Cells(1).Value
            txtnomebloco.Enabled = True
        ElseIf tab = 2 Then
            gbMSG.Visible = False
            'carregarbloco()
            botao = 2
            btnnovoblocosala.Enabled = False
            btneliminarblocosala.Enabled = False
            btnconsultarblocosala.Enabled = False
            btnguardarblocosala.Enabled = True
            btncancelarblocosala.Enabled = True
            txtnumsala.Text = datagridsala.CurrentRow.Cells(0).Value
            txtnomesala.Text = datagridsala.CurrentRow.Cells(1).Value
            comblocosala.Text = datagridsala.CurrentRow.Cells(2).Value
            comblocosala.Enabled = True
            txtnomesala.Enabled = True
        End If
    End Sub

    Private Sub btneliminarblocosala_Click(sender As Object, e As EventArgs) Handles btneliminarblocosala.Click
        gbMSG.Visible = False
        If tab = 1 Then
            Try
                btncancelarblocosala.Enabled = True
                txtbloconum.Text = DataGridBloco.CurrentRow.Cells(0).Value
                txtnomebloco.Text = DataGridBloco.CurrentRow.Cells(1).Value
                Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar bloco")
                If resultado = DialogResult.Yes Then
                    Call conectar()
                    Dim sql As String = "delete from bloco where idbloco = '" & txtbloconum.Text & "'"
                    Dim sqlcom As New SqlCommand(sql, con)
                    Dim dr As SqlDataReader = sqlcom.ExecuteReader
                    Call desconectar()
                    'MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar bloco")
                    gbMSG.Visible = True
                    lblmsgSala.Text = "O bloco selecionado foi eliminado com sucesso."
                    gridbloco()
                    limparbloco()
                    btnnovoblocosala.Enabled = True
                    btneditarblocosala.Enabled = True
                    btneditarblocosala.Enabled = True
                    btnguardarblocosala.Enabled = False
                    btnconsultarblocosala.Enabled = True
                    btneliminarblocosala.Enabled = True
                    btncancelarblocosala.Enabled = False
                    btnsairblocosala.Enabled = True

                End If
            Catch
                MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar bloco")
               
            End Try
        ElseIf tab = 2 Then
            gbMSG.Visible = False
            Try
                btncancelarblocosala.Enabled = True
                txtnumsala.Text = datagridsala.CurrentRow.Cells(0).Value
                txtnomesala.Text = datagridsala.CurrentRow.Cells(1).Value
                comblocosala.SelectedText = datagridsala.CurrentRow.Cells(2).Value
                Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar sala")
                If resultado = DialogResult.Yes Then
                    Call conectar()
                    Dim sql As String = "delete from sala where idsala = '" & txtnumsala.Text & "'"
                    Dim sqlcom As New SqlCommand(sql, con)
                    Dim dr As SqlDataReader = sqlcom.ExecuteReader
                    Call desconectar()
                    ' MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar sala")
                    gbMSG.Visible = True
                    lblmsgutilizador.Text = "Sala eliminada com sucesso!"
                    limparsala()
                    Dim sql1 As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B where S.idbloco= B.idbloco"
                    gridbsala(sql1)
                    limparsala()
                    btnnovoblocosala.Enabled = True
                    btneditarblocosala.Enabled = True
                    btneditarblocosala.Enabled = True
                    btnguardarblocosala.Enabled = False
                    btnconsultarblocosala.Enabled = True
                    btneliminarblocosala.Enabled = True
                    btncancelarblocosala.Enabled = False
                    btnsairblocosala.Enabled = True

                End If
            Catch
                MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar sala")
            End Try
        End If

    End Sub

    Private Sub btncancelarblocosala_Click(sender As Object, e As EventArgs) Handles btncancelarblocosala.Click
        gbMSG.Visible = False
        gbMSG1.Visible = False
        If tab = 1 Then
            ativar_bloco(False)
            btnnovoblocosala.Enabled = True
            btneditarblocosala.Enabled = True
            btneditarblocosala.Enabled = True
            btnguardarblocosala.Enabled = False
            btnconsultarblocosala.Enabled = True
            btneliminarblocosala.Enabled = True
            btncancelarblocosala.Enabled = False
            txtnomebloco.Enabled = False
            btnsairblocosala.Enabled = True
            limparbloco()
            gridbloco()
        ElseIf tab = 2 Then
            btnnovoblocosala.Enabled = True
            btneditarblocosala.Enabled = True
            btneditarblocosala.Enabled = True
            btnguardarblocosala.Enabled = False
            btnconsultarblocosala.Enabled = True
            btneliminarblocosala.Enabled = True
            btncancelarblocosala.Enabled = False
            btnsairblocosala.Enabled = True
            txtnomesala.Enabled = False
            comblocosala.Enabled = False
            limparsala()


        End If

    End Sub

    Private Sub txtnomebloco_TextChanged(sender As Object, e As EventArgs) Handles txtnomebloco.TextChanged
        Call conectar()
        Dim sql As String = "select * from bloco " & " where nomebloco like '" & txtnomebloco.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        DataGridBloco.Columns.Clear()
        DataGridBloco.Columns.Add(0, "Código")
        DataGridBloco.Columns.Add(1, "Descrição")

        While dr.Read
            Dim linha As New DataGridViewRow
            DataGridBloco.Rows.Add(linha)
            DataGridBloco.Rows(i).Cells(0).Value = dr.Item(0)
            DataGridBloco.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        DataGridBloco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btnsairblocosala_Click(sender As Object, e As EventArgs) Handles btnsairblocosala.Click
        gbMSG.Visible = False
        Me.Close()
        If tipouser = 0 Then
            Bloquear_menu(False)
            formulario_principal.tsbEspaco.Enabled = True
        Else
            Bloquear_menu(True)
        End If
    End Sub

    Private Sub txtnomesala_TextChanged(sender As Object, e As EventArgs) Handles txtnomesala.TextChanged
        If txtnomesala.Text = "" And comblocosala.SelectedIndex = -1 Then
            Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B where S.idbloco= B.idbloco"
            gridbsala(sql)
        ElseIf txtnomesala.Text = "" Then
            Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B " & " where S.idbloco = '" & comblocosala.SelectedValue & "' and S.idbloco= B.idbloco"
            gridbsala(sql)
        ElseIf comblocosala.SelectedIndex = -1 Then
            Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B " & " where S.sala like '" & txtnomesala.Text & "%' and S.idbloco= B.idbloco"
            gridbsala(sql)
        Else
            Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B " & " where S.sala like '" & txtnomesala.Text & "%' and S.idbloco = '" & comblocosala.SelectedValue & "' and S.idbloco= B.idbloco"
            gridbsala(sql)
        End If
    End Sub

    Private Sub comblocosala_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comblocosala.SelectedIndexChanged
        If txtnomesala.Text = "" And comblocosala.SelectedIndex = -1 Then
            Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B where S.idbloco= B.idbloco"
            gridbsala(sql)
        ElseIf txtnomesala.Text = "" Then
            Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B " & " where S.idbloco = '" & comblocosala.SelectedValue & "' and S.idbloco= B.idbloco"
            gridbsala(sql)
        ElseIf comblocosala.SelectedIndex = -1 Then
            Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B " & " where S.sala like '" & txtnomesala.Text & "%' and S.idbloco= B.idbloco"
            gridbsala(sql)
        Else
            Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B " & " where S.sala like '" & txtnomesala.Text & "%' and S.idbloco = '" & comblocosala.SelectedValue & "' and S.idbloco= B.idbloco"
            gridbsala(sql)
        End If
    End Sub
End Class
