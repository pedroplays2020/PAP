Imports System.Data.SqlClient
Public Class tempo
    Dim botao As Integer

    Public Sub desbloqueartempo(ByVal estadotempo As Boolean)
        txttempo.Enabled = estadotempo
        txtintervalodetempo.Enabled = estadotempo


    End Sub


    Public Sub ativar_tempo(ByVal estadotempo As Boolean)
        lblobrigatoriointervalodetempo.Enabled = estadotempo

    End Sub

    Public Sub limpartempo()
        txttempo.Clear()
        txttempo.Enabled = False
        txtintervalodetempo.Clear()
        txtintervalodetempo.Focus()

    End Sub

    Public Sub constempo()
        Call conectar()
        Dim sql As String = "select * from Tempo"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridtempo.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        'Dim k As Integer
        'Dim campo As String
        'For k = 0 To n - 1

        'campo = dr.GetName(k)
        'datagridtempo.Columns.Add(campo, campo)
        'Next
        'datagridtempo.Columns.Add("Codigo", "Descrição")
        datagridtempo.Columns.Add(0, "Código")
        datagridtempo.Columns.Add(1, "Descrição")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridtempo.Rows.Add(linha)
            datagridtempo.Rows(i).Cells(0).Value = dr.Item(0)
            datagridtempo.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datagridtempo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btnnovotempo_Click(sender As Object, e As EventArgs) Handles btnnovotempo.Click
        Me.Text = "Novo tempo"
        txttempo.Enabled = False
        txtintervalodetempo.Enabled = True
        btncancelartempo.Enabled = True
        btnnovotempo.Enabled = False
        btneditartempo.Enabled = False
        btneliminartempo.Enabled = False
        btnconsultartempo.Enabled = False
        btnsairtempo.Enabled = False
        btnguardartempo.Enabled = True
        botao = 1

    End Sub

    Private Sub btnguardartempo_Click(sender As Object, e As EventArgs) Handles btnguardartempo.Click

        If botao = 1 Then
            ativar_tempo(False)

            If txtintervalodetempo.Text = "" Then
                lblobrigatoriointervalodetempo.Visible = True
                txtintervalodetempo.Focus()
            Else
                lblobrigatoriointervalodetempo.Visible = False
                Call conectar()
                Dim sql As String = "insert into Tempo values ( '" & RTrim(txtintervalodetempo.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                constempo()
                btnsairtempo.Enabled = True
                limpartempo()
                btnnovotempo.Enabled = True
                btneditartempo.Enabled = True
                btneliminartempo.Enabled = True
                btnguardartempo.Enabled = False
                btnconsultartempo.Enabled = True
                btncancelartempo.Enabled = False
                btnsairtempo.Enabled = True
            End If
        ElseIf botao = 2 Then
            Call conectar()
            Dim sql2 As String = " update Tempo set intervaloHorario = '" & txtintervalodetempo.Text & "' where idtempo = '" & txttempo.Text & "'"
            Dim sqlcom2 As New SqlCommand(sql2, con)
            Dim dr2 As SqlDataReader = sqlcom2.ExecuteReader
            Call desconectar()
            constempo()
            btnnovotempo.Enabled = True
            btneditartempo.Enabled = True
            btneliminartempo.Enabled = True
            btnguardartempo.Enabled = False
            btnconsultartempo.Enabled = True
            btncancelartempo.Enabled = False
            btnsairtempo.Enabled = True



        End If



    End Sub

    Private Sub tempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desbloqueartempo(False)
        ativar_tempo(False)
        lblobrigatoriointervalodetempo.Visible = True
        btncancelartempo.Visible = True
        lblobrigatoriointervalodetempo.Visible = False
        btncancelartempo.Enabled = True
        btnguardartempo.Enabled = False
        constempo()
        limpartempo()

    End Sub

    Private Sub btnsairtempo_Click(sender As Object, e As EventArgs) Handles btnsairtempo.Click
        Me.Close()

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs)
        Me.Text = "Cancelar tempo"
        desbloqueartempo(False)
        ativar_tempo(True)
        txttempo.Clear()
        txtintervalodetempo.Clear()
        btnnovotempo.Enabled = True
        btneditartempo.Enabled = True
        btneliminartempo.Enabled = True
        btnguardartempo.Enabled = False
        btnconsultartempo.Enabled = True
        btncancelartempo.Enabled = False
        btnsairtempo.Enabled = True
        limpartempo()


    End Sub

    Private Sub btnconsultartempo_Click(sender As Object, e As EventArgs) Handles btnconsultartempo.Click
        btnnovotempo.Enabled = False
        btncancelartempo.Enabled = True
        txttempoencontrado.Visible = True






    End Sub

    Private Sub txttempoencontrado_TextChanged(sender As Object, e As EventArgs) Handles txttempoencontrado.TextChanged
        Call conectar()
        Dim sql As String = "select * from Tempo " & " where interHorario like '" & txttempoencontrado.Text & "%'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim n As Integer = dr.FieldCount
        Dim i As Integer = 0
        datagridtempo.Columns.Clear()
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridtempo.Columns.Add(campo, campo)
        Next
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridtempo.Rows.Add(linha)
            datagridtempo.Rows(i).Cells(0).Value = dr.Item(0)
            datagridtempo.Rows(i).Cells(1).Value = dr.Item(1)
            i = i + 1
        End While
        datagridtempo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub btneditartempo_Click(sender As Object, e As EventArgs) Handles btneditartempo.Click

        botao = 2
        btnnovotempo.Enabled = False
        btneliminartempo.Enabled = False
        btnconsultartempo.Enabled = False
        btnguardartempo.Enabled = True
        btncancelartempo.Enabled = True
        txttempo.Text = datagridtempo.CurrentRow.Cells(0).Value
        txtintervalodetempo.Text = datagridtempo.CurrentRow.Cells(1).Value
        txtintervalodetempo.Visible = True
        txtintervalodetempo.Enabled = True
        txttempoencontrado.Enabled = False


    End Sub

    Private Sub btneliminartempo_Click(sender As Object, e As EventArgs) Handles btneliminartempo.Click
        Try

            btncancelartempo.Enabled = True
            txttempo.Text = datagridtempo.CurrentRow.Cells(0).Value
            txtintervalodetempo.Text = datagridtempo.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Função")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from Tempo where idtempo = '" & txttempo.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Função")
                constempo()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Função")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncancelartempo.Click
        Me.Text = " Cancelar tempo"
        ativar_tempo(False)
        desbloqueartempo(True)
        txtintervalodetempo.Clear()
        txttempo.Clear()
        btnnovotempo.Enabled = True
        btneditartempo.Enabled = True
        btneditartempo.Enabled = True
        btneliminartempo.Enabled = True
        btnguardartempo.Enabled = False
        btnconsultartempo.Enabled = True
        btncancelartempo.Enabled = False
        btnsairtempo.Enabled = True
        limpartempo()





    End Sub
End Class