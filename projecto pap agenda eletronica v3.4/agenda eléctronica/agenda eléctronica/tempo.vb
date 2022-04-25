Imports System.Data.SqlClient
Public Class tempo
    Dim botao As Integer
    Shared ConnectionString As String = "Data Source=.\;Initial Catalog=Agenda;Integrated Security=True"
    Public Shared Function verificartempo(tempo As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                con.ConnectionString = ConnectionString
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM Tempo WHERE intervaloHorario = '" & tempo & "'"
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
        gbmsgtempo.Visible = False
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
        If txtintervalodetempo.Text = "" Then
            lblobrigatoriointervalodetempo.Visible = True
            txtintervalodetempo.Focus()
            Exit Sub
        Else
            If verificartempo(txtintervalodetempo.Text) = True Then
                gbmsgtempo.Visible = True
                lblmsgtempo.Text = "O tempo a inserir já se encontra registado."
                Exit Sub
            End If
        End If

        If botao = 1 Then
            ativar_tempo(False)

            If lblobrigatoriointervalodetempo.Visible = False Then
                Call conectar()
                Dim sql As String = "insert into Tempo values ( '" & RTrim(txtintervalodetempo.Text) & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                gbmsgtempo.Visible = True
                lblmsgtempo.Text = "Tempo inserido com sucesso!"
                constempo()
                limpartempo()
                btnnovotempo.Enabled = True
                btneditartempo.Enabled = True
                btneliminartempo.Enabled = True
                btnguardartempo.Enabled = False
                btnconsultartempo.Enabled = True
                btncancelartempo.Enabled = False
                btnsairtempo.Enabled = True
                txtintervalodetempo.Enabled = False
            End If
        End If
        If botao = 2 Then
            If lblobrigatoriointervalodetempo.Visible = False Then
                Call conectar()
                Dim sql2 As String = " update Tempo set intervaloHorario = '" & txtintervalodetempo.Text & "' where idtempo = '" & txttempo.Text & "'"
                Dim sqlcom2 As New SqlCommand(sql2, con)
                Dim dr2 As SqlDataReader = sqlcom2.ExecuteReader
                Call desconectar()
                gbmsgtempo.Visible = True
                lblmsgtempo.Text = "Tempo atualizado com sucesso!"
                btnnovotempo.Enabled = True
                btneditartempo.Enabled = True
                btneliminartempo.Enabled = True
                btnguardartempo.Enabled = False
                btnconsultartempo.Enabled = True
                btncancelartempo.Enabled = False
                txtintervalodetempo.Enabled = False
                btnsairtempo.Enabled = True
                constempo()
                limpartempo()
            End If
        End If
    End Sub

    Private Sub tempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbmsgtempo.Visible = False
        desbloqueartempo(False)
        ativar_tempo(False)
        lblobrigatoriointervalodetempo.Visible = True
        btncancelartempo.Visible = True
        lblobrigatoriointervalodetempo.Visible = False
        btncancelartempo.Enabled = True
        btnguardartempo.Enabled = False
        txtintervalodetempo.Enabled = False
        constempo()
        limpartempo()

    End Sub

    Private Sub btnsairtempo_Click(sender As Object, e As EventArgs) Handles btnsairtempo.Click
        Me.Close()
        Bloquear_menu(True)
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
        gbmsgtempo.Visible = False
        btnnovotempo.Enabled = False
        btncancelartempo.Enabled = True
        txttempoencontrado.Visible = True
        txttempoencontrado.Enabled = True







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
        Me.Text = " Editar tempo"
        gbmsgtempo.Visible = False

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
        gbmsgtempo.Visible = False
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
                'MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Função")
                gbmsgtempo.Visible = True
                lblmsgtempo.Text = "Eliminado com sucesso!"
                constempo()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Função")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncancelartempo.Click
        Me.Text = " Cancelar tempo"
        gbmsgtempo.Visible = False
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
        txtintervalodetempo.Enabled = False
        txttempoencontrado.Enabled = False

        limpartempo()





    End Sub
End Class