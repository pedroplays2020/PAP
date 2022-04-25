Imports System.Data.SqlClient
Imports agenda_eléctronica

Public Class Utilizadores
    Dim botao As Integer
    Public Sub lerfuncao()
        Call conectar()
        Dim sql As String = "select idFuncao, funcao from Funcao order by idFuncao"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        comfunçãoutilizadores.ValueMember = "idFuncao"
        comfunçãoutilizadores.DisplayMember = "funcao"
        comfunçãoutilizadores.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lercategoria()
        Call conectar()
        Dim sql As String = "select idArea, nome from areav order by idArea"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combocategoriautilizadores.ValueMember = "idarea"
        combocategoriautilizadores.DisplayMember = "nome"
        combocategoriautilizadores.DataSource = dt
        Call desconectar()
    End Sub


    Public Sub consutilizador()
        Call conectar()
        Dim sql As String = "select idUtilizador,utilizador,nome from Utilizador"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridutilizadores.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        Dim k As Integer
        Dim campo As String
        For k = 0 To n - 1
            campo = dr.GetName(k)
            datagridutilizadores.Columns.Add(campo, campo)
        Next
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridutilizadores.Rows.Add(linha)
            datagridutilizadores.Rows(i).Cells(0).Value = dr.Item(0)
            datagridutilizadores.Rows(i).Cells(1).Value = dr.Item(1)
            datagridutilizadores.Rows(i).Cells(2).Value = dr.Item(2)
            i = i + 1
        End While
        datagridutilizadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
    End Sub

    Friend Shared Function Midparent() As formulario_principal
        Throw New NotImplementedException()
    End Function

    Private Sub timer_tick()
        txthoraregistoutilizadores.Text = TimeOfDay()
    End Sub

    Public Sub Limpar()
        txtnunutilizadores.Clear()
        txtutilizadorutilizadores.Clear()
        Comboestadoutilizadores.SelectedIndex = -1
        txtpasswordutilizadores.Clear()
        txtconfirmapasswordutilizadores.Clear()
        combotipoutilizadores.SelectedIndex = -1
        'txtregistutilizadores.Clear()
        txthoraregistoutilizadores.Clear()
        txtnomeutilizadores.Clear()
        txtmoradautilizadores.Clear()
        mtxtcodigopostalutilizadores.Clear()
        mtxtcodigopostalutilizadores2.Clear()
        txtlocalidadeutilizadores.Clear()
        mtxttelefoneutilizador.Clear()
        mtxttelemovelutilizadores.Clear()
        txtemailutilizadores.Clear()
        combocategoriautilizadores.SelectedIndex = -1
        comfunçãoutilizadores.SelectedIndex = -1
        txtobsutilizadores.Clear()
    End Sub

    Public Sub Desbloquear(ByVal estado As Boolean)
        'bloquear ou desbloquear os objectos do formulário
        'txtnunutilizadores.Enabled = estado
        txtutilizadorutilizadores.Enabled = estado
        Comboestadoutilizadores.Enabled = estado
        'txtregistutilizadores.Enabled = estado
        txtpasswordutilizadores.Enabled = estado
        txtconfirmapasswordutilizadores.Enabled = estado
        combotipoutilizadores.Enabled = estado
        'txthoraregistoutilizadores.Enabled = estado
        txtnomeutilizadores.Enabled = estado
        txtmoradautilizadores.Enabled = estado
        txtconfirmapasswordutilizadores.Enabled = estado
        mtxtcodigopostalutilizadores.Enabled = estado
        mtxtcodigopostalutilizadores2.Enabled = estado
        txtlocalidadeutilizadores.Enabled = estado
        mtxttelefoneutilizador.Enabled = estado
        mtxttelemovelutilizadores.Enabled = estado
        txtemailutilizadores.Enabled = estado
        datanascimentoutilizadores.Enabled = estado
        comfunçãoutilizadores.Enabled = estado
        combocategoriautilizadores.Enabled = estado
        txtobsutilizadores.Enabled = estado
        btncancelarutilizadores.Enabled = estado
    End Sub

    Public Sub Ativar_obrigatorio(ByVal estado As Boolean)
        'bloquear ou desbloquear os objectos do formulário como obrigatório
        lblobrigatorioestadoutilizador.Visible = estado
        lblobrigatorioutilizadadores.Visible = estado
        lblobrigatorioutilzadorpassword.Visible = estado
        lblobrigatorionomeutilizador.Visible = estado
        lblobrigatoriomoradautilizador.Visible = estado
        lblobrigatoriotipoutilizador.Visible = estado
        lblobrigatoriocodigopostalocalidadeutilizadores.Visible = estado
        lblobrigatoriotelefonetelemovelutilizadores.Visible = estado
        lblobrigatorioemailutilizadores.Visible = estado
        lblobrigatoriodatanascimentoutilizadores.Visible = estado
        lblobrigatoriofuncaoutilizador.Visible = estado
        lblobrigatoriocategoriautilizador.Visible = estado
        lblobrigatorioconfirmpasswordutilizadores.Visible = estado
        lblobrigatorioemailutilizador.Visible = estado

        'colocar o campo com o Text Obrigatório
        lblobrigatoriocodigopostalocalidadeutilizadores.Text = "* Obrigatório"
        lblobrigatoriotelefonetelemovelutilizadores.Text = "* Obrigatório"
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs)
        formulario_principal.Show()
    End Sub

    Private Sub btnsairutilizador_Click(sender As Object, e As EventArgs) Handles btnsairutilizador.Click
        Close()

    End Sub

    Private Sub btnguardarutilizadores_Click(sender As Object, e As EventArgs) Handles btnguardarutilizadores.Click

        If botao = 1 Then
            'consutilizador()
            Ativar_obrigatorio(False)
            'If txtobsutilizadores.Text = "" Then
            'txtobsutilizadores.Focus()
            'End If
            If combocategoriautilizadores.SelectedIndex = -1 Then
                lblobrigatoriocategoriautilizador.Visible = True
                combocategoriautilizadores.Focus()
                'MsgBox("123")
            End If
            If comfunçãoutilizadores.SelectedIndex = -1 Then
                lblobrigatoriofuncaoutilizador.Visible = True
                comfunçãoutilizadores.Focus()
            End If
            If datanascimentoutilizadores.Text = "" Then
                lblobrigatoriodatanascimentoutilizadores.Visible = True
                datanascimentoutilizadores.Focus()
            End If
            If txtemailutilizadores.Text = "" Then
                lblobrigatorioemailutilizador.Visible = True
                txtemailutilizadores.Focus()
            End If

            If mtxttelefoneutilizador.Text = "" And mtxttelemovelutilizadores.Text = "" Then
                lblobrigatoriotelefonetelemovelutilizadores.Text = "* Obrigatório"
                If mtxttelefoneutilizador.Text = "" Then
                    lblobrigatoriotelefonetelemovelutilizadores.Visible = True
                    mtxttelefoneutilizador.Focus()
                End If

                If mtxttelemovelutilizadores.Text = "" Then
                    lblobrigatoriotelefonetelemovelutilizadores.Visible = True
                    mtxttelemovelutilizadores.Focus()
                End If
            End If

            If mtxttelefoneutilizador.Text <> "" And mtxttelefoneutilizador.TextLength <> 9 Then
                lblobrigatoriotelefonetelemovelutilizadores.Text = " *Inválido"
                mtxttelefoneutilizador.Focus()
                lblobrigatoriotelefonetelemovelutilizadores.Visible = True
            End If

            If mtxttelemovelutilizadores.Text <> "" And mtxttelemovelutilizadores.TextLength <> 9 Then
                lblobrigatoriotelefonetelemovelutilizadores.Text = " *Inválido"
                mtxttelemovelutilizadores.Focus()
                lblobrigatoriotelefonetelemovelutilizadores.Visible = True
            End If

            'validar tamanho dos campos
            If mtxtcodigopostalutilizadores.TextLength <> 4 Or mtxtcodigopostalutilizadores2.TextLength <> 3 Or txtlocalidadeutilizadores.Text = "" Then
                lblobrigatoriocodigopostalocalidadeutilizadores.Text = "* Obrigatório"
                lblobrigatoriocodigopostalocalidadeutilizadores.Visible = True

                If mtxtcodigopostalutilizadores.Text = "" Then
                    lblobrigatoriocodigopostalocalidadeutilizadores.Visible = True
                    mtxtcodigopostalutilizadores.Focus()
                End If

                If mtxtcodigopostalutilizadores2.Text = "" Then
                    lblobrigatoriocodigopostalocalidadeutilizadores.Visible = True
                    mtxtcodigopostalutilizadores2.Focus()
                End If

                If txtlocalidadeutilizadores.Text = "" Then
                    lblobrigatoriocodigopostalocalidadeutilizadores.Visible = True
                End If
            End If

            If mtxtcodigopostalutilizadores.Text <> "" And mtxtcodigopostalutilizadores2.Text <> "" And txtlocalidadeutilizadores.Text <> "" Then
                lblobrigatoriocodigopostalocalidadeutilizadores.Text = "* Inválido"
                If mtxtcodigopostalutilizadores.TextLength <> 4 Then
                    lblobrigatoriocodigopostalocalidadeutilizadores.Visible = True
                    mtxtcodigopostalutilizadores.Focus()
                End If

                If mtxtcodigopostalutilizadores2.TextLength <> 3 Then
                    lblobrigatoriocodigopostalocalidadeutilizadores.Visible = True
                    mtxtcodigopostalutilizadores2.Focus()
                End If

            End If

            If txtmoradautilizadores.Text = "" Then
                lblobrigatoriomoradautilizador.Visible = True
                txtmoradautilizadores.Focus()
            End If
            If txtnomeutilizadores.Text = "" Then
                lblobrigatorionomeutilizador.Visible = True
                txtnomeutilizadores.Focus()
            End If
            If Comboestadoutilizadores.SelectedIndex = -1 Then
                lblobrigatorioestadoutilizador.Visible = True
                Comboestadoutilizadores.Focus()
            End If
            If combotipoutilizadores.SelectedIndex = -1 Then
                lblobrigatoriotipoutilizador.Visible = True
                combotipoutilizadores.Focus()
            End If
            If txtconfirmapasswordutilizadores.Text = "" Then
                lblobrigatorioconfirmpasswordutilizadores.Visible = True
                txtconfirmapasswordutilizadores.Focus()
            End If
            If txtpasswordutilizadores.Text = "" Then
                lblobrigatorioutilzadorpassword.Visible = True
                txtpasswordutilizadores.Focus()
            End If
            If txtutilizadorutilizadores.Text = "" Then
                lblobrigatorioutilizadadores.Visible = True
                txtutilizadorutilizadores.Focus()
            End If

            If txtpasswordutilizadores.Text Like txtconfirmapasswordutilizadores.Text Then
            Else
                lblobrigatorioconfirmpasswordutilizadores.Visible = True
                lblobrigatorioutilzadorpassword.Visible = True
                MessageBox.Show(" A sua password está incorreta, introduza novamente")
                txtpasswordutilizadores.Clear()
                txtconfirmapasswordutilizadores.Clear()
                txtpasswordutilizadores.Focus()
            End If
            If lblobrigatorioutilizadadores.Visible = False And lblobrigatorioutilzadorpassword.Visible = False And lblobrigatorioconfirmpasswordutilizadores.Visible = False And lblobrigatorioestadoutilizador.Visible = False And lblobrigatoriotipoutilizador.Visible = False And lblobrigatorionomeutilizador.Visible = False And lblobrigatoriomoradautilizador.Visible = False And lblobrigatoriocodigopostalocalidadeutilizadores.Visible = False And lblobrigatoriotelefonetelemovelutilizadores.Visible = False And lblobrigatorioemailutilizador.Visible = False And lblobrigatoriodatanascimentoutilizadores.Visible = False And lblobrigatoriofuncaoutilizador.Visible = False And lblobrigatoriocategoriautilizador.Visible = False Then
                Call conectar()
                Dim sql As String = "insert into Utilizador values ('" & RTrim(txtutilizadorutilizadores.Text) & "', '" & RTrim(txtpasswordutilizadores.Text) & "', '" & Comboestadoutilizadores.SelectedItem & "', '" & combotipoutilizadores.SelectedItem & "', '" & Format(txtregistutilizadores.Text, "Short Date") & "', '" & txthoraregistoutilizadores.Text & "', '" & RTrim(txtnomeutilizadores.Text) & "','" & RTrim(txtmoradautilizadores.Text) & "','" & RTrim(mtxtcodigopostalutilizadores.Text) & "','" & RTrim(mtxtcodigopostalutilizadores2.Text) & "','" & RTrim(txtlocalidadeutilizadores.Text) & "','" & RTrim(mtxttelefoneutilizador.Text) & "', '" & RTrim(mtxttelemovelutilizadores.Text) & "','" & RTrim(txtemailutilizadores.Text) & "', '" & Format(datanascimentoutilizadores.Value, "Short Date") & "', '" & comfunçãoutilizadores.SelectedValue & "', '" & combocategoriautilizadores.SelectedValue & "', '" & txtobsutilizadores.Text & "', '" & Picturefoto.Text & "')"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
            End If
            Limpar()
            consutilizador()
        Else
            If botao = 2 Then

            End If
        End If

    End Sub

    Private Sub Utilizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ativar_obrigatorio(False)
        Desbloquear(False)
        btncancelarutilizadores.Enabled = False
        btnguardarutilizadores.Enabled = False

        datanascimentoutilizadores.Text = Now
        datanascimentoutilizadores.MaxDate = Now
        txtregistutilizadores.Text = DateTime.Now.Date
        lercategoria()
        lerfuncao()
        consutilizador()

        'colocar o campo com o Text Obrigatório
        lblobrigatoriocodigopostalocalidadeutilizadores.Text = "* Obrigatório"
        lblobrigatoriotelefonetelemovelutilizadores.Text = "* Obrigatório"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Picturefoto.Click
        Dim nome As String
        OpenFileDialog1.ShowDialog()
        nome = OpenFileDialog1.FileName
        Picturefoto.Image = System.Drawing.Bitmap.FromFile(nome)
    End Sub

    Private Sub btnovoutilizador_Click(sender As Object, e As EventArgs) Handles btnovoutilizador.Click
        Me.Text = "Novo Utilizador"
        Desbloquear(True)
        btnconsultarutilizador.Enabled = False
        btneliminarutilizador.Enabled = False
        btneditarutilizadores.Enabled = False
        btncancelarutilizadores.Enabled = True
        btnsairutilizador.Enabled = False
        btnguardarutilizadores.Enabled = True
        btnovoutilizador.Enabled = False
        botao = 1
    End Sub

    Private Sub btncancelarutilizadores_Click(sender As Object, e As EventArgs) Handles btncancelarutilizadores.Click
        Me.Text = ""
        Desbloquear(False)
        Limpar()
        Ativar_obrigatorio(False)
        btneditarutilizadores.Enabled = True
        btneliminarutilizador.Enabled = True
        btnguardarutilizadores.Enabled = False
        btnconsultarutilizador.Enabled = True
        btncancelarutilizadores.Enabled = False
        btnsairutilizador.Enabled = True
        btnovoutilizador.Enabled = True
    End Sub

    Private Sub Hora_Tick(sender As Object, e As EventArgs) Handles Hora.Tick
        txthoraregistoutilizadores.Text = TimeOfDay
    End Sub

    Private Sub btneditarutilizadores_Click(sender As Object, e As EventArgs) Handles btneditarutilizadores.Click
        Me.Text = "Editar Utilizador "
    End Sub

    Private Sub btneliminarutilizador_Click(sender As Object, e As EventArgs) Handles btneliminarutilizador.Click
        Me.Text = "Eliminar Utilizador"
    End Sub

    Private Sub btnconsultarutilizador_Click(sender As Object, e As EventArgs) Handles btnconsultarutilizador.Click
        Me.Text = "Consultar Utilizador"
    End Sub

    Private Sub datagridutilizadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridutilizadores.CellContentClick

    End Sub

    Private Sub Menuutilizadores_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Menuutilizadores.ItemClicked

    End Sub
End Class


