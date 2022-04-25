Imports System.Data.SqlClient

Public Class Disciplina
    Shared ConnectionString As String = "Data Source=.\;Initial Catalog=Agenda;Integrated Security=True"
    Public Shared Function verificardisciplina(disciplina As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                con.ConnectionString = ConnectionString
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM Disciplina WHERE Nomedisciplina = '" & disciplina & "'"
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

    Public Sub lerarea()
        Call conectar()
        Dim sql As String = "select idarea, nomearea from area order by idarea"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combareadisciplina.ValueMember = "idarea"
        combareadisciplina.DisplayMember = "nomearea"
        combareadisciplina.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub limpardisciplina()
        txtnumdisciplina.Clear()
        txtnumdisciplina.Enabled = False
        txtnomedisciplina.Clear()
        txtnomedisciplina.Focus()
    End Sub
    Public Sub desbloquear_disciplina(ByVal estado As Boolean)
        txtnomedisciplina.Enabled = estado
        combareadisciplina.Enabled = estado

    End Sub
    Public Sub ativar_disciplina(ByVal estado As Boolean)
        lblobrigatorionomedisciplina.Visible = estado
        lblobgareadisciplina.Visible = estado
    End Sub


    Private Sub btnovodisciplina_Click(sender As Object, e As EventArgs) Handles btnovodisciplina.Click
        Me.Text = " Nova disciplina"
        gbmgsdisciplina.Visible = False
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
        combareadisciplina.Enabled = True
        lblareadisciplina.Enabled = True

        botao = 1
    End Sub

    Private Sub btneditardisciplina_Click(sender As Object, e As EventArgs) Handles btneditardisciplina.Click
        botao = 2
        gbmgsdisciplina.Visible = False
        btnovodisciplina.Enabled = False
        btneliminardisciplina.Enabled = False
        btnconsultardisciplina.Enabled = False
        btnguardardisciplina.Enabled = True
        btncancelardisciplina.Enabled = True
        txtnumdisciplina.Text = datagridisciplina.CurrentRow.Cells(0).Value
        txtnomedisciplina.Text = datagridisciplina.CurrentRow.Cells(1).Value
        combareadisciplina.Text = datagridisciplina.CurrentRow.Cells(2).Value
        combareadisciplina.Enabled = True
        txtnomedisciplina.Enabled = True
    End Sub

    Private Sub btnguardardisciplina_Click(sender As Object, e As EventArgs) Handles btnguardardisciplina.Click

        If botao = 1 Then
            ativar_disciplina(False)
            desbloquear_disciplina(False)
            If txtnomedisciplina.Text = "" Then
                lblobrigatorionomedisciplina.Visible = True
                txtnomedisciplina.Focus()
            End If

            If combareadisciplina.SelectedIndex = -1 Then
                lblobgareadisciplina.Visible = True
                combareadisciplina.Focus()
            End If

            If verificardisciplina(txtnomedisciplina.Text) = True Then
                gbmgsdisciplina.Visible = True
                lblmsgdisciplina.Text = "A disciplina  a inserir já se encontra registada."
                Exit Sub
            End If

            If lblobrigatorionomedisciplina.Visible = False Then
                Call conectar()
                Dim sql2 As String = "insert into Disciplina values ('" & RTrim(txtnomedisciplina.Text) & "', '" & combareadisciplina.SelectedValue & "') "
                Dim sqlcom As New SqlCommand(sql2, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                gbmgsdisciplina.Visible = True
                lblmsgdisciplina.Text = "Disciplina inserida com sucesso! "
                consdisciplina()
                limpardisciplina()
                btnovodisciplina.Enabled = True
                btneditardisciplina.Enabled = True
                btneliminardisciplina.Enabled = True
                btnguardardisciplina.Enabled = False
                btnconsultardisciplina.Enabled = True
                btncancelardisciplina.Enabled = False
                btnsairdisciplina.Enabled = True
            End If

        ElseIf botao = 2 Then
            desbloquear_disciplina(False)
            Call conectar()
            Dim sql1 As String = "update  Disciplina set Nomedisciplina  = '" & txtnomedisciplina.Text & "' where idDisciplina = '" & txtnumdisciplina.Text & "'"
            Dim sqlcon As New SqlCommand(sql1, con)
            Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
            dr1.Close()
            Call desconectar()
            gbmgsdisciplina.Visible = True
            lblmsgdisciplina.Text = "Disciplina alterada com sucesso!"
            consdisciplina()
            limpardisciplina()
            btnovodisciplina.Enabled = True
            btneditardisciplina.Enabled = True
            btneliminardisciplina.Enabled = True
            btnguardardisciplina.Enabled = False
            btnconsultardisciplina.Enabled = True
            btncancelardisciplina.Enabled = False
            btnsairdisciplina.Enabled = True
        End If
    End Sub
    Public Sub consdisciplina()
        Call conectar()
        Dim sql As String = "select * from Disciplina"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridisciplina.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        'Dim k As Integer
        'Dim campo As String
        'For k = 0 To n - 1

        'campo = dr.GetName(k)
        'datagridtempo.Columns.Add(campo, campo)
        'Next
        'datagridtempo.Columns.Add("Codigo", "Descrição")
        datagridisciplina.Columns.Add(0, "Código")
        datagridisciplina.Columns.Add(1, "Descrição")
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
        lerarea
        consdisciplina()
        lblobrigatorionomedisciplina.Visible = False
        btncancelardisciplina.Enabled = False
        btnguardardisciplina.Enabled = False
        desbloquear_disciplina(False)
        ativar_disciplina(False)
        'lblnumdisciplina.Visible = False
        txtnumdisciplina.Enabled = False
        'lblareadisciplina.Enabled = False
        combareadisciplina.Enabled = False

    End Sub

    Private Sub btnconsultardisciplina_Click(sender As Object, e As EventArgs) Handles btnconsultardisciplina.Click
        btnovodisciplina.Enabled = False
        btncancelardisciplina.Enabled = True
        txtnomedisciplina.Enabled = True


    End Sub

    Private Sub btncancelardisciplina_Click(sender As Object, e As EventArgs) Handles btncancelardisciplina.Click
        desbloquear_disciplina(False)
        ativar_disciplina(False)
        gbmgsdisciplina.Visible = False
        btnovodisciplina.Enabled = True
        btneditardisciplina.Enabled = True
        btneliminardisciplina.Enabled = True
        btnguardardisciplina.Enabled = False
        btnconsultardisciplina.Enabled = True
        btncancelardisciplina.Enabled = False
        btnsairdisciplina.Enabled = True
    End Sub

    Private Sub btneliminardisciplina_Click(sender As Object, e As EventArgs) Handles btneliminardisciplina.Click
        gbmgsdisciplina.Visible = False

        Try
            txtnumdisciplina.Clear()
            combareadisciplina.SelectedItem = -1
            combareadisciplina.Visible = True
            btncancelardisciplina.Enabled = True

            txtnumdisciplina.Text = datagridisciplina.CurrentRow.Cells(0).Value
            combareadisciplina.Text = datagridisciplina.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende elminar o registo? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Disciplina")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from Disciplina where idDisciplina = '" & txtnumdisciplina.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                'MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Disciplina")
                gbmgsdisciplina.Visible = True
                lblmsgdisciplina.Text = "Disciplina eliminada com sucesso!"
                consdisciplina()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Disciplina ")
        End Try
    End Sub

  

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblareadisciplina.Click

    End Sub

    Private Sub btnsairdisciplina_Click(sender As Object, e As EventArgs) Handles btnsairdisciplina.Click
        Me.Close()
        Bloquear_menu(True)
    End Sub

    Private Sub txtnomedisciplina_TextChanged_1(sender As Object, e As EventArgs) Handles txtnomedisciplina.TextChanged
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
            datagridisciplina.Rows(i).Cells(2).Value = dr.Item(2)
            i = i + 1
        End While
        datagridisciplina.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call desconectar()
    End Sub

    Private Sub lblobrigatorionomedisciplina_Click(sender As Object, e As EventArgs) Handles lblobrigatorionomedisciplina.Click

    End Sub
End Class


  
