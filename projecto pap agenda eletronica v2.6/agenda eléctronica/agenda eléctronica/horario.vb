Imports System.Data.SqlClient
Public Class horario
    Public Sub ativar_hora(ByVal estado As Boolean)
        'lblobrigatorionomehorario.Visible = estado
        'lblobrigatoriofuncaohorario.Visible = estado
        'lblobrigatoriocategoriahorario.Visible = estado

    End Sub
    Public Sub limpar()
        'txtnomehorario.Clear()
        'combofunçãohorario.SelectedIndex = -1
        'combocategoriahorário.SelectedIndex = -1
        'txtdisciplinahorario.Clear()
        'txtsalahorario.Clear()
        'combofunçãohorario.SelectedIndex = -1
        'combodiashorario.SelectedIndex = -1

    End Sub


    Public Sub desbloquear_horario(ByVal estado As Boolean)
        'txtnomehorario.Enabled = estado
        'combofunçãohorario.Enabled = estado
        'combocategoriahorário.Enabled = estado
        'txtdisciplinahorario.enabled = estado
        'txtsalahorario.enabled = estado
        'combohorashorario.enabled = estado
    End Sub

    Private Sub btnguardarhorario_Click(sender As Object, e As EventArgs) Handles btnguardarhorario.Click

        'If txtnomehorario.Text = "" Then
        'lblobrigatorionomehorario.Visible = True
        'txtnomehorario.Focus()
        'End If
        'If combofunçãohorario.SelectedIndex = -1 Then
        'lblobrigatoriofuncaohorario.Visible = True
        'combofunçãohorario.Focus()
        'End If
        'If combocategoriahorário.SelectedIndex = -1 Then
        'lblobrigatoriofuncaohorario.Visible = True
        'combocategoriahorário.Focus()
        'End If

        'lblobrigatorionomehorario.Visible = False
        'lblobrigatorionomehorario.Visible = False
        'lblobrigatoriofuncaohorario.Visible = False
        'lblobrigatoriocategoriahorario.Visible = False
        'Call conectar()
        'Dim sql As String = "insert into Horario values ('" & RTrim(txtnomehorario.Text) & "', '" & combofunçãohorario.SelectedItem & "', '" & combocategoriahorário.SelectedItem & "' , '" & txtdisciplinahorario.Text & "', '" & txtsalahorario.Text & "', '" & combohorashorario.SelectedItem & "', '" & combodiashorario.SelectedItem & "' )"
        'Dim sqlcom As New SqlCommand(sql, con)
        'Dim dr As SqlDataReader = sqlcom.ExecuteReader
        'Call desconectar()


    End Sub

    Private Sub horario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblobrigatorionomehorario.Visible = False

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblobrigatoriodisciplina.Click

    End Sub

    Private Sub txtdisciplinahorario_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnovohorario_Click(sender As Object, e As EventArgs) Handles btnovohorario.Click

        Me.Text = " Novo horário"
        desbloquear_horario(True)
        txtnumhorario.Enabled = False
        'txtnomehorario.Enabled = True
        btncancelarhorario.Enabled = True
        btnovohorario.Enabled = False
        btneditarhorario.Enabled = False
        btneliminarhorario.Enabled = False
        btnguardarhorario.Enabled = True
        btnconsultarhorario.Enabled = False
        btnsairhorario.Enabled = False

    End Sub

    Private Sub lbldisciplinahorario_Click(sender As Object, e As EventArgs) Handles lbldisciplinahorario.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub lblobrigatoriodiashorario_Click(sender As Object, e As EventArgs) Handles lblobrigatoriodiashorario.Click

    End Sub

    Private Sub combodiashorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combodiashorario.SelectedIndexChanged

    End Sub

    Private Sub lblbdaisemana_Click(sender As Object, e As EventArgs) Handles lblbdaisemana.Click

    End Sub

    Private Sub lbltempohorario_Click(sender As Object, e As EventArgs) Handles lbltempohorario.Click

    End Sub

    Private Sub lblsalahorario_Click(sender As Object, e As EventArgs) Handles lblsalahorario.Click

    End Sub

    Private Sub combohorashorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combohorashorario.SelectedIndexChanged

    End Sub

    Private Sub lblobrigatoriohorashorario_Click(sender As Object, e As EventArgs) Handles lblobrigatoriohorashorario.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub lblobrigatoriosalahorario_Click(sender As Object, e As EventArgs) Handles lblobrigatoriosalahorario.Click

    End Sub

    Private Sub datagridhorario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridhorario.CellContentClick

    End Sub
End Class