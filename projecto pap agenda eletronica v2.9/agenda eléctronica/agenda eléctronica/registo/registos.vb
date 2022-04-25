Imports System.Data.SqlClient
Public Class Registo
    Dim botao As Integer
    Public Sub lerfuncao()
        Call conectar()
        Dim sql As String = "select idFuncao, funcao from Funcao order by idFuncao"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combofunçaoregistos.ValueMember = "idFuncao"
        combofunçaoregistos.DisplayMember = "funcao"
        combofunçaoregistos.DataSource = dt
        Call desconectar()
    End Sub
    Public Sub constregisto()
        Call conectar()
        Dim sql As String = "select * from Registo"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridadosutilizador.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridadosutilizador.Columns.Add(campo, campo)
        Next
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridadosutilizador.Rows.Add(linha)
            datagridadosutilizador.Rows(i).Cells(0).Value = dr.Item(0)
            datagridadosutilizador.Rows(i).Cells(1).Value = dr.Item(1)
            datagridadosutilizador.Rows(i).Cells(1).Value = dr.Item(2)
            i = i + 1
        End While
        datagridadosutilizador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()

    End Sub
    Public Sub limparregisto()
        txtnutilizadoregistos.Clear()
        txtnutilizadoregistos.Enabled = False
        txtnomeregistos.Clear()
        combofunçaoregistos.SelectedItem = -1
        combofunçaoregistos.Focus()
        combocategoriaregistos.SelectedItem = -1
        combocategoriaregistos.Focus()


    End Sub
    Public Sub desbloquearegisto(ByVal estado As Boolean)
        txtnutilizadoregistos.Enabled = estado
        txtnomeregistos.Enabled = estado
        combofunçaoregistos.Enabled = estado
        combocategoriaregistos.Enabled = estado
    End Sub

    Public Sub ativaregistos(ByVal estado As Boolean)
        lblobrigatorionomeregisto.Visible = estado
        lblobrigatoriofuncregisto.Enabled = estado
        lblobrigatoriocatregistos.Enabled = estado
    End Sub

    Private Sub btnnovoregisto_Click(sender As Object, e As EventArgs) Handles btnnovoregisto.Click
        Me.Text = " Novo registo"
        desbloquearegisto(True)
        btnconsultaregistos.Enabled = False
        btneliminaregisto.Enabled = False
        btneditaregisto.Enabled = False
        btncancelaregisto.Enabled = True
        btnsairegisto.Enabled = False
        btnguardaregisto.Enabled = True
        btnnovoregisto.Enabled = False
        txtnutilizadoregistos.Enabled = False
        txtnomeregistos.Visible = True
        lblnomeutilizadorregistos.Visible = True
        botao = 1

    End Sub

    Private Sub pesquisarregisto_Click(sender As Object, e As EventArgs) Handles btncancelaregisto.Click
        Me.Text = " Cancelar registo"
        desbloquearegisto(False)
        ativaregistos(True)
        txtnumregistos.Clear()
        txtnomeregistos.Clear()
        combofunçaoregistos.SelectedItem = -1
        combocategoriaregistos.SelectedItem = -1
        btnnovoregisto.Enabled = True
        btneditaregisto.Enabled = True
        btneliminaregisto.Enabled = True
        btnguardaregisto.Enabled = False
        btnconsultaregistos.Enabled = True
        btncancelaregisto.Enabled = False
        btnsairegisto.Enabled = True
        limparregisto()
    End Sub


    Private Sub btnguardaregisto_Click(sender As Object, e As EventArgs) Handles btnguardaregisto.Click
        ativaregistos(False)
        If botao = 1 Then
            If txtnomeregistos.Text = "" Then
                lblobrigatorionomeregisto.Visible = True
                txtnomeregistos.Focus()
            End If
            If combofunçaoregistos.SelectedItem = -1 Then
                lblobrigatoriofuncregisto.Visible = True
                combofunçaoregistos.Focus()
            End If
            If combocategoriaregistos.SelectedItem = -1 Then
                lblobrigatoriocatregistos.Visible = True
                combocategoriaregistos.Focus()
            Else
                lblobrigatorionomeregisto.Visible = False
                lblobrigatoriofuncregisto.Visible = False
                lblobrigatoriocatregistos.Visible = False

                Call conectar()
                Dim sql As String = "insert into Registo values ('" & RTrim(txtnomeregistos.Text) & "', '" & combofunçaoregistos.SelectedValue & "', '" & combocategoriaregistos.SelectedValue & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                limparregisto()
            End If
        ElseIf botao = 2 Then
        End If


    End Sub

    Private Sub Registo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ativaregistos(False)
        desbloquearegisto(False)
        btncancelaregisto.Enabled = False
        btnguardaregisto.Enabled = False
        lblobrigatorionomeregisto.Visible = False
        lblobrigatoriofuncregisto.Visible = False
        lblobrigatoriocatregistos.Visible = False
        txtnutilizadoregistos.Enabled = False

    End Sub

    Private Sub btnsairegisto_Click(sender As Object, e As EventArgs) Handles btnsairegisto.Click
        Me.Close()
    End Sub
End Class