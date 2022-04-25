Imports System.Data.SqlClient

Public Class blocoSala
    Dim botao, tab As Integer

    Public Sub desbloquear_sala(ByVal estado As Boolean)
        txtnomesala.Enabled = estado
    End Sub
    Public Sub desbloquear_bloco(ByVal estado As Boolean)
        txtnomebloco.Enabled = estado

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
    End Sub

    Public Sub gribsala()
        Call conectar()
        Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B where S.idbloco= B.idbloco"
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
        gbBloco.Visible = True
        gridbloco()

        gbsala.Visible = True
        gribsala()
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
            lblnumsala.Enabled = False
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
            If botao = 1 Then
                If txtnomebloco.Text = "" Then
                    lblobrigatorionomebloco.Visible = True
                    txtnomebloco.Focus()
                Else
                    lblobrigatorionomebloco.Visible = False
                End If
                If lblobrigatorionomebloco.Visible = False Then
                    Call conectar()
                    Dim sql As String = "insert into bloco values ('" & RTrim(txtnomebloco.Text) & "')"
                    Dim sqlcom As New SqlCommand(sql, con)
                    Dim dr As SqlDataReader = sqlcom.ExecuteReader
                    Call desconectar()
                    gridbloco()
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
                limparbloco()
            End If
        ElseIf tab = 2 Then
            If botao = 1 Then
                If txtnomesala.Text = "" Then
                    lblobrigatorionomesala.Visible = True
                    txtnomesala.Focus()
                Else
                    lblobrigatorionomesala.Visible = False
                    Call conectar()
                    Dim sql2 As String = "insert into sala values ('" & RTrim(txtnomesala.Text) & "', '" & comblocosala.SelectedValue & "')"
                    Dim sqlcom2 As New SqlCommand(sql2, con)
                    Dim dr As SqlDataReader = sqlcom2.ExecuteReader
                    Call desconectar()
                    txtnumsala.ResetText()
                    txtnomesala.ResetText()
                    btnnovoblocosala.Enabled = True
                    btneditarblocosala.Enabled = True
                    btneditarblocosala.Enabled = True
                    btnguardarblocosala.Enabled = False
                    btnconsultarblocosala.Enabled = True
                    btneliminarblocosala.Enabled = True
                    btncancelarblocosala.Enabled = False
                    btnsairblocosala.Enabled = True
                    limparsala()
                    gribsala()
                End If
            ElseIf botao = 2 Then
                Call conectar()
                Dim sql3 As String = "update sala  set sala  = '" & txtnomesala.Text & "', idbloco = '" & comblocosala.SelectedValue & "' where idsala= '" & txtnumsala.Text & "' and idbloco = '" & txtBloco.Text & "'"
                Dim sqlcon3 As New SqlCommand(sql3, con)
                Dim dr3 As SqlDataReader = sqlcon3.ExecuteReader
                dr3.Close()
                Call desconectar()
                gribsala()
                limparsala()
            End If

        End If
    End Sub

    Private Sub btnconsultarblocosala_Click(sender As Object, e As EventArgs) Handles btnconsultarblocosala.Click
        If tab = 1 Then
            btnnovoblocosala.Enabled = False
            btncancelarblocosala.Enabled = True
            txtnomebloco.Enabled = True
        ElseIf tab = 2 Then
            btnnovoblocosala.Enabled = False
            btncancelarblocosala.Enabled = True
            txtnomesala.Enabled = True
        End If


    End Sub


    Private Sub btneditarblocosala_Click(sender As Object, e As EventArgs) Handles btneditarblocosala.Click
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
            carregarbloco()
            botao = 2
            btnnovoblocosala.Enabled = False
            btneliminarblocosala.Enabled = False
            btnconsultarblocosala.Enabled = False
            btnguardarblocosala.Enabled = True
            btncancelarblocosala.Enabled = True
            txtnumsala.Text = datagridsala.CurrentRow.Cells(0).Value
            txtnomesala.Text = datagridsala.CurrentRow.Cells(1).Value
            txtBloco.Text = datagridsala.CurrentRow.Cells(2).Value
            comblocosala.SelectedItem = datagridsala.CurrentRow.Cells(2).Value

            txtnomesala.Enabled = True



        End If
    End Sub

    Private Sub btneliminarblocosala_Click(sender As Object, e As EventArgs) Handles btneliminarblocosala.Click
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
                    MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar bloco")
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
                    MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar sala")
                    gribsala()
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
        If tab = 1 Then
            btnnovoblocosala.Enabled = True
            btneditarblocosala.Enabled = True
            btneditarblocosala.Enabled = True
            btnguardarblocosala.Enabled = False
            btnconsultarblocosala.Enabled = True
            btneliminarblocosala.Enabled = True
            btncancelarblocosala.Enabled = False
            btnsairblocosala.Enabled = True
            limparbloco()
        ElseIf tab = 2 Then
            btnnovoblocosala.Enabled = True
            btneditarblocosala.Enabled = True
            btneditarblocosala.Enabled = True
            btnguardarblocosala.Enabled = False
            btnconsultarblocosala.Enabled = True
            btneliminarblocosala.Enabled = True
            btncancelarblocosala.Enabled = False
            btnsairblocosala.Enabled = True
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
        'Dim k As Integer
        'Dim campo As String
        'For k = 0 To n - 1
        'campo = dr.GetName(k)
        'DataGridBloco.Columns.Add(campo, campo)
        'Next
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
        Me.Close()
    End Sub

    Private Sub txtnomesala_TextChanged(sender As Object, e As EventArgs) Handles txtnomesala.TextChanged
        Call conectar()
        Dim sql As String = "select S.idsala, S.sala, B.nomebloco from sala S, bloco B " & " where S.sala like '" & txtnomesala.Text & "%' and S.idbloco= B.idbloco"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datagridsala.Columns.Clear()
       datagridsala.Columns.Add(0, "Código")
        datagridsala.Columns.Add(1, "Sala")
        datagridsala.Columns.Add(2, "Bloco")
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridsala.Rows.Add(linha)
            datagridsala.Rows(i).Cells(0).Value = dr.Item(0)
            datagridsala.Rows(i).Cells(1).Value = dr.Item(1)
            datagridsala.Rows(i).Cells(2).Value = dr.Item(2)
            i = i + 1
        End While
        DataGridBloco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub


    Private Sub comblocosala_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comblocosala.SelectedIndexChanged

    End Sub

    Private Sub tpBloco_Click(sender As Object, e As EventArgs) Handles tpBloco.Click

    End Sub
End Class