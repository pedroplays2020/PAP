Imports System.Data.SqlClient
Public Class Registo
    Dim botao As Integer

    Public Sub lerutilizador()
        Call conectar()
        Dim sql As String = "select idUtilizador, utilizador from Utilizador order by idUtilizador"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combonomeregistos.ValueMember = "idUtilizador"
        combonomeregistos.DisplayMember = "utilizador"
        combonomeregistos.DataSource = dt
        Call desconectar()
    End Sub



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

    Public Sub lercategoria()
        Call conectar()
        Dim sql As String = "select idArea, nome from Areav order by idArea"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combocategoriaregistos.ValueMember = "idArea"
        combocategoriaregistos.DisplayMember = "nome"
        combocategoriaregistos.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub constregisto()
        Call conectar()
        Dim sql As String = "select * from Registo"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridregistos.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridregistos.Columns.Add(campo, campo)
        Next
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridregistos.Rows.Add(linha)
            datagridregistos.Rows(i).Cells(0).Value = dr.Item(0)
            datagridregistos.Rows(i).Cells(1).Value = dr.Item(1)
            datagridregistos.Rows(i).Cells(2).Value = dr.Item(2)
            datagridregistos.Rows(i).Cells(3).Value = dr.Item(3)
            datagridregistos.Rows(i).Cells(4).Value = dr.Item(4)
            datagridregistos.Rows(i).Cells(5).Value = dr.Item(5)
            datagridregistos.Rows(i).Cells(6).Value = dr.Item(6)
            datagridregistos.Rows(i).Cells(7).Value = dr.Item(7)
            datagridregistos.Rows(i).Cells(8).Value = dr.Item(8)
            datagridregistos.Rows(i).Cells(9).Value = dr.Item(9)
            datagridregistos.Rows(i).Cells(10).Value = dr.Item(10)
            i = i + 1
        End While
        datagridregistos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()

    End Sub
    Public Sub limparregisto()
        txtnutilizadoregistos.Clear()
        txtnutilizadoregistos.Enabled = False
        combonomeregistos.SelectedItem = -1
        combonomeregistos.Focus()
        combofunçaoregistos.SelectedItem = -1
        combofunçaoregistos.Focus()
        combocategoriaregistos.SelectedItem = -1
        combocategoriaregistos.Focus()


    End Sub
    Public Sub desbloquearegisto(ByVal estado As Boolean)
        txtnumregistos.Enabled = estado
        txtnutilizadoregistos.Enabled = estado
        combonomeregistos.Enabled = estado
        combofunçaoregistos.Enabled = estado
        combocategoriaregistos.Enabled = estado
        txtdataregistos.Enabled = estado
        txthorasregisto.Enabled = estado
        combocomuniregistos.Enabled = estado
        txtdestinarioregistos.Enabled = estado
        comboturmaregistos.Enabled = estado
        combotiposerviçosregistos.Enabled = estado
        combanoletivoregisto.Enabled = estado
        txtobsregistos.Enabled = estado
        numdowqtregistos.Enabled = estado

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
        combonomeregistos.Visible = True
        lblnomeutilizadorregistos.Visible = True
        botao = 1
        
        numdowqtregistos.Enabled = False
    End Sub

    Private Sub pesquisarregisto_Click(sender As Object, e As EventArgs) Handles btncancelaregisto.Click
        Me.Text = " Cancelar registo"
        desbloquearegisto(False)
        ativaregistos(True)
        txtnumregistos.Clear()
        combonomeregistos.SelectedItem = -1
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
            If combonomeregistos.Text = "" Then
                lblobrigatorionomeregisto.Visible = True
                combonomeregistos.Focus()
            End If
            If combofunçaoregistos.SelectedIndex = -1 Then
                lblobrigatoriofuncregisto.Visible = True
                combofunçaoregistos.Focus()
            End If
            If combocategoriaregistos.SelectedIndex = -1 Then
                lblobrigatoriocatregistos.Visible = True
                combocategoriaregistos.Focus()
            Else
                lblobrigatorionomeregisto.Visible = False
                lblobrigatoriofuncregisto.Visible = False
                lblobrigatoriocatregistos.Visible = False

                Call conectar()
                Dim sql1 As String = "insert into Registo values ('" & txtnutilizadoregistos.Text & _
                                                                    "','" & Format(txtdataregistos.Text, "Short Date") & _
                                                                     "', '" & txthorasregisto.Text & _
                                                                    "', '" & combocomuniregistos.SelectedItem & _
                                                                    "', '" & mtelefoneregistos.Text & _
                                                                    "', '" & mtelemovelregistos.Text & _
                                                                     "', '" & numdowqtregistos.Text & _
                                                                     "', '" & txtdestinarioregistos.Text & _
                                                                     "', '" & comboturmaregistos.Text & _
                                                                     "', '" & combotiposerviçosregistos.SelectedItem & _
                                                                     "', '" & combanoletivoregisto.Text & _
                                                                     "','" & txtobsregistos.Text & "')"
                Dim sqlcom As New SqlCommand(sql1, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                constregisto()
                combonomeregistos.SelectedItem = -1
                combofunçaoregistos.SelectedItem = -1
                combocategoriaregistos.SelectedItem = -1
                combocomuniregistos.SelectedItem = -1
                mtelefoneregistos.Clear()
                mtelemovelregistos.Clear()
                txtdestinarioregistos.Clear()
                comboturmaregistos.SelectedItem = -1
                combotiposerviçosregistos.SelectedItem = -1
                combanoletivoregisto.SelectedItem = -1
                txtobsregistos.Clear()
                btnnovoregisto.Enabled = True
                btneditaregisto.Enabled = True
                btneliminaregisto.Enabled = True
                btnguardaregisto.Enabled = False
                btnconsultaregistos.Enabled = True
                btncancelaregisto.Enabled = False
                btnsairegisto.Enabled = True
                limparregisto()


            End If
        ElseIf botao = 2 Then
        End If


    End Sub
    Private Sub combocomuniregistos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocomuniregistos.SelectedIndexChanged
        Dim text As String

        text = combocomuniregistos.SelectedItem.ToString
        'MsgBox(text)

        If text = "Telefone" Then
            lbltelefoneregisto.Visible = True
            mtelefoneregistos.Visible = True
            mtelefoneregistos.Enabled = True
            mtelefoneregistos.Focus()
        Else
            lbltelefoneregisto.Visible = False
            mtelefoneregistos.Visible = False
            mtelefoneregistos.Enabled = False
        End If
        If text = "Telemóvel" Then
            telemovelregistos.Visible = True
            mtelemovelregistos.Visible = True
            mtelemovelregistos.Enabled = True
            mtelemovelregistos.Focus()
        Else
            telemovelregistos.Visible = False
            mtelemovelregistos.Visible = False
            mtelemovelregistos.Enabled = False
        End If
        If text = "Email" Or text = "Carta" Or text = "Carta Registada" Then
            numdowqtregistos.Enabled = True
            numdowqtregistos.Focus()
        Else
            numdowqtregistos.Enabled = False
        End If
    End Sub

    Private Sub Registo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lerutilizador()
        lerfuncao()
        lercategoria()
        constregisto()
        ativaregistos(False)
        desbloquearegisto(False)
        btncancelaregisto.Enabled = False
        btnguardaregisto.Enabled = False
        lblobrigatorionomeregisto.Visible = False
        lblobrigatoriofuncregisto.Visible = False
        lblobrigatoriocatregistos.Visible = False
        txtnutilizadoregistos.Enabled = False
        txtdataregistos.Text = DateTime.Now.Date
        mtelefoneregistos.Enabled = False
        mtelefoneregistos.Visible = False
        mtelemovelregistos.Enabled = False
        mtelemovelregistos.Visible = False
        lbltelefoneregisto.Visible = False
        telemovelregistos.Visible = False
        numdowqtregistos.Enabled = False

    End Sub

    Private Sub btnsairegisto_Click(sender As Object, e As EventArgs) Handles btnsairegisto.Click
        Me.Close()
    End Sub

    Private Sub Horaregisto_Tick(sender As Object, e As EventArgs) Handles Horaregisto.Tick
        txthorasregisto.Text = TimeOfDay
    End Sub

    Private Sub mtelefoneregistos_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtelefoneregistos.MaskInputRejected
        If validar.isvalidtelefone(mtelefoneregistos.Text) = True Then
            mtelefoneregistos.BackColor = Color.Green
        Else
            mtelefoneregistos.BackColor = Color.Red
        End If
    End Sub
End Class


