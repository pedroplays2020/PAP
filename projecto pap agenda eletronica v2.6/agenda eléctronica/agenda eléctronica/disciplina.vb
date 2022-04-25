Imports System.Data.SqlClient

Public Class Disciplina

    Dim botao As Integer
    Public Sub limpardisciplina()
        txtnomedisciplina.Clear()

    End Sub

    Public Sub desbloquear_disciplina(ByVal estado As Boolean)
        txtnomedisciplina.Enabled = estado

    End Sub
    Public Sub ativar_disciplina(ByVal estado As Boolean)
        lblobrigatorionomedisciplina.Visible = estado
    End Sub


    Private Sub btnovodisciplina_Click(sender As Object, e As EventArgs) Handles btnovodisciplina.Click
        Me.Text = " Nova disciplina"
        desbloquear_disciplina(True)
        txtnumdisciplina.Enabled = False
        txtnomedisciplina.Enabled = True
        btncancelardisciplina.Enabled = True
        btnovodisciplina.Enabled = False
        btneditardisciplina.Enabled = False
        btneliminardisciplina.Enabled = False
        btnguardardisciplina.Enabled = True
        btnconsultardisciplina.Enabled = False
        btnsairdisciplina.Enabled = False
        botao = 1
    End Sub

    Private Sub btneditardisciplina_Click(sender As Object, e As EventArgs) Handles btneditardisciplina.Click
        botao = 2
        btnovodisciplina.Enabled = False
        btneliminardisciplina.Enabled = False
        btnconsultardisciplina.Enabled = False
        btnguardardisciplina.Enabled = True
        btncancelardisciplina.Enabled = True
        txtnumdisciplina.Text = datagridisciplina.CurrentRow.Cells(0).Value
        txtnomedisciplina.Text = datagridisciplina.CurrentRow.Cells(1).Value
        txtnomedisciplina.Enabled = True

    End Sub

    Private Sub btnguardardisciplina_Click(sender As Object, e As EventArgs) Handles btnguardardisciplina.Click

        If botao = 1 Then
            ativar_disciplina(False)
            If txtnomedisciplina.Text = "" Then
                lblobrigatorionomedisciplina.Visible = True
            Else
                lblobrigatorionomedisciplina.Visible = False
                Call conectar()
                Dim sql As String = "insert into Disciplina values ('" & RTrim(txtnomedisciplina.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr1 As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                consdisciplina()
                limpardisciplina()
                btncancelardisciplina.Enabled = True
                btnsairdisciplina.Enabled = True
            End If
        ElseIf botao = 2 Then
            Call conectar()
            Dim sql1 As String = "update  Disciplina set Nomedisciplina  = '" & txtnomedisciplina.Text & "' where idDisciplina = '" & txtnumdisciplina.Text & "'"
            Dim sqlcon As New SqlCommand(sql1, con)
            Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
            dr1.Close()
            Call desconectar()
            consdisciplina()
            limpardisciplina()
            btnovodisciplina.Enabled = True
            btneditardisciplina.Enabled = True
            btneliminardisciplina.Enabled = True
            btnguardardisciplina.Enabled = False
            btnconsultardisciplina.Enabled = True
            btncancelardisciplina.Enabled = False
        End If
    End Sub
    Public Sub consdisciplina()
        Call conectar()
        Dim sql As String = "select * from Disciplina"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridisciplina.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridisciplina.Columns.Add(campo, campo)
        Next
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridisciplina.Rows.Add(linha)
            datagridisciplina.Rows(i).Cells(0).Value = dr.Item(0)
            datagridisciplina.Rows(i).Cells(1).Value = dr.Item(1)

            i = i + 1
        End While
        datagridisciplina.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Private Sub Disciplina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consdisciplina()
        lblobrigatorionomedisciplina.Visible = False
        btncancelardisciplina.Enabled = False
        btnguardardisciplina.Enabled = False
        desbloquear_disciplina(False)
        ativar_disciplina(False)
    End Sub

    Private Sub btnconsultardisciplina_Click(sender As Object, e As EventArgs) Handles btnconsultardisciplina.Click
        btnovodisciplina.Enabled = False
        btncancelardisciplina.Enabled = True
        txtnomedisciplina.Enabled = True


    End Sub

    Private Sub btncancelardisciplina_Click(sender As Object, e As EventArgs) Handles btncancelardisciplina.Click
        desbloquear_disciplina(False)
        ativar_disciplina(False)
        btnovodisciplina.Enabled = True
        btneditardisciplina.Enabled = True
        btneliminardisciplina.Enabled = True
        btnguardardisciplina.Enabled = False
        btnconsultardisciplina.Enabled = True
        btncancelardisciplina.Enabled = False
        btnsairdisciplina.Enabled = True




    End Sub

    Private Sub btneliminardisciplina_Click(sender As Object, e As EventArgs) Handles btneliminardisciplina.Click
        Try
            txtnumdisciplina.Clear()
            txtnomedisciplina.Clear()
            txtnomedisciplina.Visible = True
            btncancelardisciplina.Enabled = True
            txtnumdisciplina.Text = datagridisciplina.CurrentRow.Cells(0).Value
            txtnomedisciplina.Text = datagridisciplina.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Disciplina")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from Disciplina where idDisciplina = '" & txtnumdisciplina.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Disciplina")
                consdisciplina()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Disciplina ")
        End Try
    End Sub

    Private Sub txtnomedisciplina_TextChanged(sender As Object, e As EventArgs) Handles txtnomedisciplina.TextChanged
        Call conectar()
        Dim sql As String = "select * from Disciplina " & " where Nomedisciplina like '" & txtnomedisciplina.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datagridisciplina.Columns.Clear()
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridisciplina.Columns.Add(campo, campo)
        Next
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridisciplina.Rows.Add(linha)
            datagridisciplina.Rows(i).Cells(0).Value = dr.Item(0)
            datagridisciplina.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datagridisciplina.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub
End Class


  
