Imports System.Data.SqlClient
Public Class Area

    Shared ConnectionString As String = "Data Source=.\;Initial Catalog=Agenda;Integrated Security=True"
    Public Shared Function verificararea(area As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                con.ConnectionString = ConnectionString
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM area WHERE nomearea = '" & area & "'"
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
        gbmsgarea.Visible = True
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
        If botao = 1 Then
            If txtnomearea.Text = "" Then
                lblobrigatorionomearea.Visible = True
                txtnomearea.Focus()

            Else
                If verificararea(txtnomearea.Text) = True Then
                    gbmsgarea.Visible = True
                    lblmsgarea.Text = " A área a inserir já se encontra registado."
                    Exit Sub
                End If
            End If

            If lblobrigatorionomearea.Visible = False Then
                Call conectar()
                Dim sql As String = "insert into area values ('" & RTrim(txtnomearea.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                gbmsgarea.Visible = True
                lblmsgarea.Text = "Area inserida com sucesso!"
                consarea()
                txtnomearea.Enabled = False
                btnsairarea.Enabled = True
                btnovoarea.Enabled = True
                btneditarea.Enabled = True
                btneliminarea.Enabled = True
                btnguardarea.Enabled = False
                btnconsultarea.Enabled = True
                btncancelarea.Enabled = False
                limpararea()
            End If
        ElseIf botao = 2 Then
            Call conectar()
            Dim sql1 As String = "update  area set nomearea = '" & txtnomearea.Text & "' where idarea = '" & txtnumarea.Text & "'"
            Dim sqlcon As New SqlCommand(sql1, con)
            Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
            dr1.Close()
            Call desconectar()
            gbmsgarea.Visible = True
            lblmsgarea.Text = "Area alterada com sucesso!"
            consarea()
            txtnomearea.Enabled = False
            limpararea()
            btnovoarea.Enabled = True
            btneditarea.Enabled = True
            btneliminarea.Enabled = True
            btnguardarea.Enabled = False
            btnconsultarea.Enabled = True
            btncancelarea.Enabled = False
        End If
    End Sub

    Private Sub Area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbmsgarea.Visible = False
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
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridarea.Columns.Add(campo, campo)
        Next
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridarea.Rows.Add(linha)
            datagridarea.Rows(i).Cells(0).Value = dr.Item(0)
            datagridarea.Rows(i).Cells(1).Value = dr.Item(1)

            i = i + 1
        End While
        datagridarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btncancelarea_Click(sender As Object, e As EventArgs) Handles btncancelarea.Click
        Me.Text = " Cancelar area"
        gbmsgarea.Visible = False
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
        Bloquear_menu(True)
    End Sub

    Private Sub btneditarea_Click(sender As Object, e As EventArgs) Handles btneditarea.Click
        gbmsgarea.Visible = False
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
        gbmsgarea.Visible = False
        Try
            txtnomearea.Visible = True
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
                'MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar area")
                gbmsgarea.Visible = True
                lblmsgarea.Text = "Area eliminada com sucesso!"
                consarea()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar area")
        End Try
    End Sub

    Private Sub datagridarea_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridarea.CellContentClick

    End Sub

    Private Sub lblobrigatorionomearea_Click(sender As Object, e As EventArgs) Handles lblobrigatorionomearea.Click

    End Sub

    Private Sub txtnumarea_TextChanged(sender As Object, e As EventArgs) Handles txtnumarea.TextChanged

    End Sub

    Private Sub lblnomearea_Click(sender As Object, e As EventArgs) Handles lblnomearea.Click

    End Sub
End Class