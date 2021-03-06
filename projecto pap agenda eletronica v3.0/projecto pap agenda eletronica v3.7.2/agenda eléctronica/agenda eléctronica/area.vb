Imports System.Data.SqlClient
Public Class Area
    Dim botao As Integer
    Public Sub consarea()
        Call conectar()
        Dim sql As String = "select * from  area"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridarea.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datagridarea.Columns.Add(0, "Código")
        datagridarea.Columns.Add(1, "Descrição")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridarea.Rows.Add(linha)
            datagridarea.Rows(i).Cells(0).Value = dr.Item(0)
            datagridarea.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datagridarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Public Sub desbloquear_area(ByVal estado As Boolean)
        txtnumarea.Enabled = estado
        txtnomearea.Enabled = estado
    End Sub
    Public Sub ativar_area(ByVal estado As Boolean)
        lblobrigatorionomearea.Visible = True
    End Sub
    Public Sub limpararea()
        txtnumarea.Clear()
        txtnumarea.Enabled = False
        txtnomearea.Clear()
    End Sub

    Private Sub btnovoarea_Click(sender As Object, e As EventArgs) Handles btnovoarea.Click
        Me.Text = " Nova area"
        limpararea()
        desbloquear_area(True)
        txtnumarea.Enabled = False
        txtnomearea.Enabled = True
        btncancelarea.Enabled = True
        btnovoarea.Enabled = False
        btneditarea.Enabled = False
        btneliminarea.Enabled = False
        btnguardarea.Enabled = True
        btnconsultarea.Enabled = False
        btnsairarea.Enabled = False
        botao = 1
    End Sub

    Private Sub btnguardarea_Click(sender As Object, e As EventArgs) Handles btnguardarea.Click
        ativar_area(False)
        If txtnomearea.Text = "" Then
            lblobrigatorionomearea.Visible = True
            txtnomearea.Focus()
        Else
            lblobrigatorionomearea.Visible = False
        End If

        If lblobrigatorionomearea.Visible = False Then
            If botao = 1 Then
                Call conectar()
                Dim sql As String = "insert into area values ('" & RTrim(txtnomearea.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
            ElseIf botao = 2 Then
                Call conectar()
                Dim sql1 As String = "update  area set nomearea = '" & txtnomearea.Text & "' where idarea = '" & txtnumarea.Text & "'"
                Dim sqlcon As New SqlCommand(sql1, con)
                Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
                dr1.Close()
                Call desconectar()
            End If
            consarea()
            btnsairarea.Enabled = True
            btnovoarea.Enabled = True
            btneditarea.Enabled = True
            btneliminarea.Enabled = True
            btnguardarea.Enabled = False
            btnconsultarea.Enabled = True
            btncancelarea.Enabled = False
            limpararea()
            desbloquear_area(False)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridarea.AllowUserToAddRows = False
        desbloquear_area(False)
        ativar_area(False)
        lblobrigatorionomearea.Visible = False
        btncancelarea.Enabled = False
        btnguardarea.Enabled = False
        consarea()
        limpararea()
    End Sub

    Private Sub btnconsultarea_Click(sender As Object, e As EventArgs) Handles btnconsultarea.Click
        btnovoarea.Enabled = False
        btncancelarea.Enabled = True
        txtnomearea.Visible = True
        txtnomearea.Enabled = True
    End Sub

    Private Sub txtnomearea_TextChanged(sender As Object, e As EventArgs) Handles txtnomearea.TextChanged
        Call conectar()
        Dim sql As String = "select * from area " & " where nomearea like '" & txtnomearea.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datagridarea.Columns.Clear()
        datagridarea.Columns.Add(0, "Código")
        datagridarea.Columns.Add(1, "Descrição")
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridarea.Rows.Add(linha)
            datagridarea.Rows(i).Cells(0).Value = dr.Item(0)
            datagridarea.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datagridarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btncancelarea_Click(sender As Object, e As EventArgs) Handles btncancelarea.Click
        Me.Text = " Cancelar area"
        desbloquear_area(False)
        lblobrigatorionomearea.Visible = False
        'ativar_area(False)
        txtnumarea.Clear()
        txtnomearea.Clear()
        btnovoarea.Enabled = True
        btneditarea.Enabled = True
        btneliminarea.Enabled = True
        btnguardarea.Enabled = False
        btnconsultarea.Enabled = True
        btncancelarea.Enabled = False
        btnsairarea.Enabled = True
        limpararea()
    End Sub

    Private Sub btnsairarea_Click(sender As Object, e As EventArgs) Handles btnsairarea.Click
        Me.Close()
        If tipouser = 0 Then
            Bloquear_menu(False)
            formulario_principal.AreaDisciplinaToolStripMenuItem.Enabled = True
        Else
            Bloquear_menu(True)
        End If
    End Sub

    Private Sub btneditarea_Click(sender As Object, e As EventArgs) Handles btneditarea.Click
        txtnomearea.Visible = False
        botao = 2
        btnovoarea.Enabled = False
        btneliminarea.Enabled = False
        btnconsultarea.Enabled = False
        btnguardarea.Enabled = True
        btncancelarea.Enabled = True
        txtnumarea.Text = datagridarea.CurrentRow.Cells(0).Value
        txtnomearea.Text = datagridarea.CurrentRow.Cells(1).Value
        txtnomearea.Enabled = True
        txtnomearea.Visible = True
    End Sub

    Private Sub btneliminarea_Click(sender As Object, e As EventArgs) Handles btneliminarea.Click
        Try
            txtnomearea.Enabled = False
            btncancelarea.Enabled = True
            txtnumarea.Text = datagridarea.CurrentRow.Cells(0).Value
            txtnomearea.Text = datagridarea.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar area")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from area where idarea = '" & txtnumarea.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar area")
                consarea()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar area")
        End Try
    End Sub

End Class