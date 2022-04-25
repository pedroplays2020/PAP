
Imports System.Data.SqlClient
Imports agenda_eléctronica
Imports System.IO

Public Class Utilizadores
    Dim botao As Integer
    Dim nome_foto As String
    Dim nome_foto_final As String
    Dim caminho_foto As String
    'variavel de destino da copia da BD
    Dim dFilePath As String = String.Empty
    Dim mensagem, titulo, botões, icone

    Public Sub ContarReg()
        Dim total As Integer
        total = datagridutilizadores.RowCount
        lblU.Text = total
    End Sub

    Function ValidarEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

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

    Public Sub lercategoria(funcao As Integer)
        Call conectar()
        Dim sql As String = "select idArea, nome from areav where idFuncao = '" & funcao & "'order by nome"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combocategoriautilizadores.ValueMember = "idarea"
        combocategoriautilizadores.DisplayMember = "nome"
        combocategoriautilizadores.DataSource = dt
        Call desconectar()
    End Sub

    Public Shared Function verificarutilizador(username As String) As Boolean
        Try
            Using con As SqlConnection = New SqlConnection()
                'Call ligacaoBD.conectar()
                con.ConnectionString = ConnectionString_new
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM utilizador WHERE utilizador = '" & username & "'"
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

        'Call desconectar()
    End Function

    Public Sub ler_sql()
        If txtuserfiltro.Text = "" And txtnomedeutilizador.Text = "" And combotipofiltro.SelectedIndex = -1 And comboestadofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea)"
            consutilizador(sql)
        ElseIf txtuserfiltro.Text = "" And txtnomedeutilizador.Text = "" And combotipofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.estado = '" & comboestadofiltro.Text & "'"
            consutilizador(sql)
        ElseIf txtuserfiltro.Text = "" And txtnomedeutilizador.Text = "" And comboestadofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.tipodeutilizador = '" & combotipofiltro.Text & "'"
            consutilizador(sql)
        ElseIf txtuserfiltro.Text = "" And combotipofiltro.SelectedIndex = -1 And comboestadofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.nome LIKE '" & txtnomedeutilizador.Text & "%'"
            consutilizador(sql)
        ElseIf txtnomedeutilizador.Text = "" And combotipofiltro.SelectedIndex = -1 And comboestadofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.utilizador LIKE '" & txtuserfiltro.Text & "%'"
            consutilizador(sql)
        ElseIf txtuserfiltro.Text = "" And txtnomedeutilizador.Text = "" Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.estado = '" & comboestadofiltro.Text & "' and t1.tipodeutilizador = '" & combotipofiltro.Text & "'"
            consutilizador(sql)
        ElseIf txtuserfiltro.Text = "" And combotipofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.estado = '" & comboestadofiltro.Text & "' and t1.nome LIKE '" & txtnomedeutilizador.Text & "%'"
            consutilizador(sql)
        ElseIf txtuserfiltro.Text = "" And comboestadofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.nome LIKE '" & txtnomedeutilizador.Text & "%' and t1.tipodeutilizador = '" & combotipofiltro.Text & "'"
            consutilizador(sql)
        ElseIf txtnomedeutilizador.Text = "" And combotipofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.estado = '" & comboestadofiltro.Text & "' and t1.utilizador LIKE '" & txtuserfiltro.Text & "%'"
            consutilizador(sql)
        ElseIf txtnomedeutilizador.Text = "" And comboestadofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.utilizador LIKE '" & txtuserfiltro.Text & "%' and t1.tipodeutilizador = '" & combotipofiltro.Text & "'"
            consutilizador(sql)
        ElseIf combotipofiltro.SelectedIndex = -1 And comboestadofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.utilizador LIKE '" & txtuserfiltro.Text & "%' and t1.nome LIKE '" & txtnomedeutilizador.Text & "%'"
            consutilizador(sql)
        ElseIf txtuserfiltro.Text = "" Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.nome LIKE '" & txtnomedeutilizador.Text & "%' and t1.tipodeutilizador = '" & combotipofiltro.Text & "'"
            consutilizador(sql)
        ElseIf txtnomedeutilizador.Text = "" Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.estado = '" & comboestadofiltro.Text & "' and t1.utilizador LIKE '" & txtuserfiltro.Text & "%' and t1.tipodeutilizador = '" & combotipofiltro.Text & "'"
            consutilizador(sql)
        ElseIf combotipofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.estado = '" & comboestadofiltro.Text & "' and t1.utilizador LIKE '" & txtuserfiltro.Text & "%' and t1.nome LIKE '" & txtnomedeutilizador.Text & "%'"
            consutilizador(sql)
        ElseIf comboestadofiltro.SelectedIndex = -1 Then
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.estado = '" & comboestadofiltro.Text & "' and t1.utilizador LIKE '" & txtuserfiltro.Text & "%' and t1.nome LIKE '" & txtnomedeutilizador.Text & "%'"
            consutilizador(sql)
        Else
            Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where t1.utilizador LIKE '" & txtuserfiltro.Text & "%' and t1.nome LIKE '" & txtnomedeutilizador.Text & "%' and t1.tipodeutilizador = '" & combotipofiltro.Text & "'"
            consutilizador(sql)
        End If
        ContarReg()
    End Sub

    Public Sub consutilizador(sqlnew As String)
        Call conectar()
        Dim sqlcom As New SqlCommand(sqlnew, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridutilizadores.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datagridutilizadores.Columns.Add(0, "Nº")
        datagridutilizadores.Columns.Add(1, "Utilizador")
        datagridutilizadores.Columns.Add(2, "Nome")
        datagridutilizadores.Columns.Add(3, "Tipo de utilizador")
        datagridutilizadores.Columns.Add(4, "Tipo de estado")
        datagridutilizadores.Columns.Add(5, "morada")
        datagridutilizadores.Columns.Add(6, "codigoPostal")
        datagridutilizadores.Columns.Add(7, "codigoPostal2")
        datagridutilizadores.Columns.Add(8, "localidade")
        datagridutilizadores.Columns.Add(9, "telefone")
        datagridutilizadores.Columns.Add(10, "telemovel")
        datagridutilizadores.Columns.Add(11, "email")
        datagridutilizadores.Columns.Add(12, "dataNascimento")
        datagridutilizadores.Columns.Add(13, "Funcao")
        datagridutilizadores.Columns.Add(14, "Area")
        datagridutilizadores.Columns.Add(15, "obs")
        datagridutilizadores.Columns.Add(16, "Password")
        datagridutilizadores.Columns.Add(17, "Foto")

        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridutilizadores.Rows.Add(linha)
            datagridutilizadores.Rows(i).Cells(0).Value = dr.Item(0)
            datagridutilizadores.Rows(i).Cells(1).Value = dr.Item(1)
            datagridutilizadores.Rows(i).Cells(2).Value = dr.Item(2)
            datagridutilizadores.Rows(i).Cells(3).Value = dr.Item(3)
            datagridutilizadores.Rows(i).Cells(4).Value = dr.Item(4)
            datagridutilizadores.Rows(i).Cells(5).Value = dr.Item(5)
            datagridutilizadores.Rows(i).Cells(6).Value = dr.Item(6)
            datagridutilizadores.Rows(i).Cells(7).Value = dr.Item(7)
            datagridutilizadores.Rows(i).Cells(8).Value = dr.Item(8)
            datagridutilizadores.Rows(i).Cells(9).Value = dr.Item(9)
            datagridutilizadores.Rows(i).Cells(10).Value = dr.Item(10)
            datagridutilizadores.Rows(i).Cells(11).Value = dr.Item(11)
            datagridutilizadores.Rows(i).Cells(12).Value = dr.Item(12)
            datagridutilizadores.Rows(i).Cells(13).Value = dr.Item(13)
            datagridutilizadores.Rows(i).Cells(14).Value = dr.Item(14)
            datagridutilizadores.Rows(i).Cells(15).Value = dr.Item(15)
            datagridutilizadores.Rows(i).Cells(16).Value = dr.Item(16)
            datagridutilizadores.Rows(i).Cells(17).Value = dr.Item(17)
            i = i + 1
        End While
        datagridutilizadores.Columns(5).Visible = False
        datagridutilizadores.Columns(6).Visible = False
        datagridutilizadores.Columns(7).Visible = False
        datagridutilizadores.Columns(8).Visible = False
        datagridutilizadores.Columns(9).Visible = False
        datagridutilizadores.Columns(10).Visible = False
        datagridutilizadores.Columns(11).Visible = False
        datagridutilizadores.Columns(12).Visible = False
        datagridutilizadores.Columns(13).Visible = False
        datagridutilizadores.Columns(14).Visible = False
        datagridutilizadores.Columns(15).Visible = False
        datagridutilizadores.Columns(16).Visible = False
        datagridutilizadores.Columns(17).Visible = False

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
        Picturefoto.Image = Nothing
        Picturefoto.Image = Image.FromFile(My.Settings.foto_inicial)
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
        Picturefoto.Enabled = estado
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

    Public Sub preencher_campos()

        If datagridutilizadores.CurrentRow.Cells(1).Value = "Admin" Then
            txtnunutilizadores.Text = datagridutilizadores.CurrentRow.Cells(0).Value
            txtutilizadorutilizadores.Text = datagridutilizadores.CurrentRow.Cells(1).Value
            txtnomeutilizadores.Text = datagridutilizadores.CurrentRow.Cells(2).Value
            combotipoutilizadores.Text = datagridutilizadores.CurrentRow.Cells(3).Value
            Comboestadoutilizadores.SelectedItem = datagridutilizadores.CurrentRow.Cells(4).Value
        Else
            txtnunutilizadores.Text = datagridutilizadores.CurrentRow.Cells(0).Value
            txtutilizadorutilizadores.Text = datagridutilizadores.CurrentRow.Cells(1).Value
            txtnomeutilizadores.Text = datagridutilizadores.CurrentRow.Cells(2).Value
            combotipoutilizadores.Text = datagridutilizadores.CurrentRow.Cells(3).Value
            Comboestadoutilizadores.SelectedItem = datagridutilizadores.CurrentRow.Cells(4).Value
            txtmoradautilizadores.Text = datagridutilizadores.CurrentRow.Cells(5).Value
            mtxtcodigopostalutilizadores.Text = datagridutilizadores.CurrentRow.Cells(6).Value
            mtxtcodigopostalutilizadores2.Text = datagridutilizadores.CurrentRow.Cells(7).Value
            txtlocalidadeutilizadores.Text = datagridutilizadores.CurrentRow.Cells(8).Value
            mtxttelefoneutilizador.Text = datagridutilizadores.CurrentRow.Cells(9).Value
            mtxttelemovelutilizadores.Text = datagridutilizadores.CurrentRow.Cells(10).Value
            txtemailutilizadores.Text = datagridutilizadores.CurrentRow.Cells(11).Value
            datanascimentoutilizadores.Text = datagridutilizadores.CurrentRow.Cells(12).Value
            comfunçãoutilizadores.Text = datagridutilizadores.CurrentRow.Cells(13).Value
            combocategoriautilizadores.Text = datagridutilizadores.CurrentRow.Cells(14).Value
            txtobsutilizadores.Text = datagridutilizadores.CurrentRow.Cells(15).Value
            txtpasswordutilizadores.Text = datagridutilizadores.CurrentRow.Cells(16).Value
            txtconfirmapasswordutilizadores.Text = datagridutilizadores.CurrentRow.Cells(16).Value
            Dim foto1 As String = datagridutilizadores.CurrentRow.Cells(1).Value & ".jpg"
            If datagridutilizadores.CurrentRow.Cells(17).Value = "" Then
                Picturefoto.Image = Image.FromFile(My.Settings.foto_inicial)
            ElseIf datagridutilizadores.CurrentRow.Cells(17).Value <> foto1 Then

            Else
                Dim caminho_foto = My.Settings.caminhofoto & "\" & datagridutilizadores.CurrentRow.Cells(17).Value
                nome_foto_final = datagridutilizadores.CurrentRow.Cells(17).Value
                Picturefoto.Image = Image.FromFile(caminho_foto)
            End If

        End If
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs)
        formulario_principal.Show()
    End Sub

    Private Sub btnsairutilizador_Click(sender As Object, e As EventArgs) Handles btnsairutilizador.Click
        Close()
        If tipouser = 0 Then
            Bloquear_menu(False)

            formulario_principal.tsbUtilizador.Enabled = True
            formulario_principal.tsbRegistos.Enabled = True
            formulario_principal.tsbHorario.Enabled = True
            formulario_principal.tsbSair.Enabled = True
        Else
            Bloquear_menu(True)
        End If
    End Sub

    Private Sub btnguardarutilizadores_Click(sender As Object, e As EventArgs) Handles btnguardarutilizadores.Click
        Ativar_obrigatorio(False)
        Dim sql As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where utilizador like '" & txtnomedeutilizador.Text & "%'"
        consutilizador(sql)

        If combocategoriautilizadores.SelectedIndex = -1 And txtutilizadorutilizadores.Text <> "Admin" Then
            lblobrigatoriocategoriautilizador.Visible = True
            combocategoriautilizadores.Focus()
        End If
        If comfunçãoutilizadores.SelectedIndex = -1 And txtutilizadorutilizadores.Text <> "Admin" Then
            lblobrigatoriofuncaoutilizador.Visible = True
            comfunçãoutilizadores.Focus()
        End If

        If datanascimentoutilizadores.Text = "" And txtutilizadorutilizadores.Text <> "Admin" Then
            lblobrigatoriodatanascimentoutilizadores.Visible = True
            datanascimentoutilizadores.Focus()
        End If

        If ValidarEmail(txtemailutilizadores.Text) = False And txtutilizadorutilizadores.Text <> "Admin" Then
            lblobrigatorioemailutilizador.Text = "* Inválido"
            lblobrigatorioemailutilizador.Visible = True
            txtemailutilizadores.Focus()
            If txtemailutilizadores.Text = "" Then
                lblobrigatorioemailutilizador.Text = "* Obrigatório"
            End If
        End If

        If mtxttelefoneutilizador.Text = "" And mtxttelemovelutilizadores.Text = "" And txtutilizadorutilizadores.Text <> "Admin" Then
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

        If mtxttelefoneutilizador.Text <> "" And mtxttelefoneutilizador.TextLength <> 9 And txtutilizadorutilizadores.Text <> "Admin" Then
            lblobrigatoriotelefonetelemovelutilizadores.Text = " *Inválido"
            mtxttelefoneutilizador.Focus()
            lblobrigatoriotelefonetelemovelutilizadores.Visible = True
        End If

        If mtxttelemovelutilizadores.Text <> "" And mtxttelemovelutilizadores.TextLength <> 9 And txtutilizadorutilizadores.Text <> "Admin" Then
            lblobrigatoriotelefonetelemovelutilizadores.Text = " *Inválido"
            mtxttelemovelutilizadores.Focus()
            lblobrigatoriotelefonetelemovelutilizadores.Visible = True
        End If

        'validar tamanho dos campos
        If (mtxtcodigopostalutilizadores.TextLength <> 4 Or mtxtcodigopostalutilizadores2.TextLength <> 3 Or txtlocalidadeutilizadores.Text = "") And txtutilizadorutilizadores.Text <> "Admin" Then
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

        If mtxtcodigopostalutilizadores.Text <> "" And mtxtcodigopostalutilizadores2.Text <> "" And txtlocalidadeutilizadores.Text <> "" And txtutilizadorutilizadores.Text <> "Admin" Then
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

        If txtmoradautilizadores.Text = "" And txtutilizadorutilizadores.Text <> "Admin" Then
            lblobrigatoriomoradautilizador.Visible = True
            txtmoradautilizadores.Focus()
        End If

        If txtnomeutilizadores.Text = "" And txtutilizadorutilizadores.Text <> "Admin" Then
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

        If txtpasswordutilizadores.Text <> "" And txtconfirmapasswordutilizadores.Text <> "" Then
            If txtpasswordutilizadores.Text Like txtconfirmapasswordutilizadores.Text Then
            Else
                lblobrigatorioconfirmpasswordutilizadores.Visible = True
                lblobrigatorioutilzadorpassword.Visible = True
                'MessageBox.Show(" A sua password está incorreta, introduza novamente")
                gbutilizador.Visible = True
                lblmsgutilizador.Text = "A sua password está incorreta, introduza novamente."
                txtpasswordutilizadores.Clear()
                txtconfirmapasswordutilizadores.Clear()
                txtpasswordutilizadores.Focus()
            End If
        End If

        If txtutilizadorutilizadores.Text = "" Then
            lblobrigatorioutilizadadores.Visible = True
            txtutilizadorutilizadores.Focus()
        ElseIf botao = 1 Then
            If verificarutilizador(txtutilizadorutilizadores.Text) = True Then
                gbutilizador.Visible = True
                lblmsgutilizador.Text = "O utilizador a inserir já se encontra registado."
            End If
        End If

        If lblobrigatorioutilizadadores.Visible = False And lblobrigatorioutilzadorpassword.Visible = False And lblobrigatorioconfirmpasswordutilizadores.Visible = False And lblobrigatorioestadoutilizador.Visible = False And lblobrigatoriotipoutilizador.Visible = False And lblobrigatorionomeutilizador.Visible = False And lblobrigatoriomoradautilizador.Visible = False And lblobrigatoriocodigopostalocalidadeutilizadores.Visible = False And lblobrigatoriotelefonetelemovelutilizadores.Visible = False And lblobrigatorioemailutilizador.Visible = False And lblobrigatoriodatanascimentoutilizadores.Visible = False And lblobrigatoriofuncaoutilizador.Visible = False And lblobrigatoriocategoriautilizador.Visible = False Then
            If botao = 1 Then
                Call conectar()
                Dim sql1 As String = "insert into Utilizador values ('" & txtutilizadorutilizadores.Text & _
                                                                "', '" & RTrim(txtpasswordutilizadores.Text) & _
                                                                "', '" & Comboestadoutilizadores.SelectedItem & _
                                                                "', '" & combotipoutilizadores.SelectedItem & _
                                                                "', '" & Format(txtregistutilizadores.Text, "Short Date") & _
                                                                "', '" & txthoraregistoutilizadores.Text & _
                                                                "', '" & RTrim(txtnomeutilizadores.Text) & _
                                                                "', '" & RTrim(txtmoradautilizadores.Text) & _
                                                                "', '" & RTrim(mtxtcodigopostalutilizadores.Text) & _
                                                                "', '" & RTrim(mtxtcodigopostalutilizadores2.Text) & _
                                                                "', '" & RTrim(txtlocalidadeutilizadores.Text) & _
                                                                "', '" & RTrim(mtxttelefoneutilizador.Text) & _
                                                                "', '" & RTrim(mtxttelemovelutilizadores.Text) & _
                                                                "', '" & RTrim(txtemailutilizadores.Text) & _
                                                                "', '" & Format(datanascimentoutilizadores.Value, "Short Date") & _
                                                                "', '" & comfunçãoutilizadores.SelectedValue & _
                                                                "', '" & combocategoriautilizadores.SelectedValue & _
                                                                "', '" & txtobsutilizadores.Text & _
                                                                "', '" & nome_foto_final & "')"
                Dim sqlcom As New SqlCommand(sql1, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                Dim sqlnew As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea)"
                consutilizador(sqlnew)
                gbutilizador.Visible = True
                lblmsgutilizador.Text = "Utilizador foi inserido com sucesso."
            ElseIf botao = 2 Then
                ' contarReg()
                Call conectar()
                If txtutilizadorutilizadores.Text = "Admin" Then
                    Dim sql1 As String = "update Utilizador set chave = '" & txtpasswordutilizadores.Text & "' where  idUtilizador = '" & txtnunutilizadores.Text & "'"
                    Dim sqlcon As New SqlCommand(sql1, con)
                    Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
                    dr1.Close()
                Else
                    Dim sql1 As String = "update Utilizador set chave = '" & txtpasswordutilizadores.Text & "', estado = '" & Comboestadoutilizadores.Text & "', tipodeutilizador = '" & combotipoutilizadores.Text & "',  nome = '" & txtnomeutilizadores.Text & "', morada = '" & txtmoradautilizadores.Text & "',codigoPostal = '" & mtxtcodigopostalutilizadores.Text & "', codigoPostal2 = '" & mtxtcodigopostalutilizadores2.Text & "', localidade = '" & txtlocalidadeutilizadores.Text & "',telefone = '" & mtxttelefoneutilizador.Text & "',telemovel= '" & mtxttelemovelutilizadores.Text & "', email = '" & txtemailutilizadores.Text & "',dataNascimento = '" & Format(datanascimentoutilizadores.Value, "Short Date") & "',idFuncao = '" & comfunçãoutilizadores.SelectedValue & "', idArea = '" & combocategoriautilizadores.SelectedValue & "',obs = '" & txtobsutilizadores.Text & "', Foto = '" & nome_foto_final & "' where  idUtilizador = '" & txtnunutilizadores.Text & "'"
                    Dim sqlcon As New SqlCommand(sql1, con)
                    Dim dr1 As SqlDataReader = sqlcon.ExecuteReader
                    dr1.Close()
                End If

                Call desconectar()
                Dim sqlnew As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where utilizador like '" & txtnomedeutilizador.Text & "%'"
                consutilizador(sqlnew)
                gbutilizador.Visible = True
                lblmsgutilizador.Text = "Utilizador Alterado"
                'Limpar()
                'btnovoutilizador.Enabled = True
                'btneditarutilizadores.Enabled = True
                'btneliminarutilizador.Enabled = True
                'btnguardarutilizadores.Enabled = False
                'btnconsultarutilizador.Enabled = True
                'btncancelarutilizadores.Enabled = False
                'Ativar_obrigatorio(False)

                'ContarReg()
                'txtnomedeutilizador.Clear()
                'Desbloquear(False)
            End If
            ContarReg()
            Limpar()
            btneditarutilizadores.Enabled = True
            btneliminarutilizador.Enabled = True
            btnguardarutilizadores.Enabled = False
            btnconsultarutilizador.Enabled = True
            btncancelarutilizadores.Enabled = False
            btnsairutilizador.Enabled = True
            btnovoutilizador.Enabled = True
            Ativar_obrigatorio(False)
            Desbloquear(False)
        End If

    End Sub

    Private Sub Utilizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridutilizadores.AllowUserToAddRows = False
        ContarReg()
        gbutilizador.Visible = False
        Ativar_obrigatorio(False)
        Desbloquear(False)
        btncancelarutilizadores.Enabled = False
        btnguardarutilizadores.Enabled = False
        datanascimentoutilizadores.Text = Now
        datanascimentoutilizadores.MaxDate = Now
        txtregistutilizadores.Text = DateTime.Now.Date
        lerfuncao()
        'Dim sqlnew As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea)"
        'consutilizador(sqlnew)
        ler_sql()
        'lblnomedeutilizador.Visible = False
        btnexcluirutilizador.Visible = False
        txtuserfiltro.Enabled = True
        'txtnomedeutilizador.Enabled = True
        combotipofiltro.Enabled = True
        comboestadofiltro.Enabled = True
        ContarReg()

        'colocar o campo com o Text Obrigatório
        lblobrigatoriocodigopostalocalidadeutilizadores.Text = "* Obrigatório"
        lblobrigatoriotelefonetelemovelutilizadores.Text = "* Obrigatório"

    End Sub

    Public Sub CopyFiles(ByVal sourcePath As String, ByVal DestinationPath As String)
        If (Directory.Exists(sourcePath)) Then
            mensagem = "Falha na cópia da imagem a inserir."
            titulo = Me.Text
            botões = MessageBoxButtons.OK
            icone = MessageBoxIcon.Information
            MessageBox.Show(mensagem, titulo, botões, icone)
        Else
            File.Copy(sourcePath, DestinationPath, True)
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Picturefoto.Click
        Using Foto As New OpenFileDialog()
            'Foto.InitialDirectory = My.Settings.caminhofoto
            Foto.Filter = "Access files (*.jpg)|*.jpg"
            Foto.FilterIndex = 0
            Foto.RestoreDirectory = True
            If txtutilizadorutilizadores.Text = "" And botao = 1 Then
                mensagem = "Para inserir a foto do utilizador tem primeiro de validar o nome do utilizador."
                titulo = Me.Text
                botões = MessageBoxButtons.OK
                icone = MessageBoxIcon.Information
                MessageBox.Show(mensagem, titulo, botões, icone)
                txtutilizadorutilizadores.Focus()
                Exit Sub
            ElseIf verificarutilizador(txtutilizadorutilizadores.Text) = True And botao = 1 Then
                gbutilizador.Visible = True
                lblmsgutilizador.Text = "O utilizador a inserir já se encontra registado."
                mensagem = "Para inserir a foto do utilizador tem primeiro de validar o nome do utilizador."
                titulo = Me.Text
                botões = MessageBoxButtons.OK
                icone = MessageBoxIcon.Information
                MessageBox.Show(mensagem, titulo, botões, icone)
                txtutilizadorutilizadores.Focus()
                Exit Sub
            Else
                If Foto.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    nome_foto = Foto.SafeFileName
                    caminho_foto = Foto.FileName
                    Picturefoto.Image = Image.FromFile(caminho_foto)
                    'CopyFiles(caminho_foto, My.Settings.caminhofoto & "\" & nome_foto)
                    nome_foto_final = txtutilizadorutilizadores.Text & ".jpg"
                    CopyFiles(caminho_foto, My.Settings.caminhofoto & "\" & txtutilizadorutilizadores.Text & ".jpg")
                    If (File.Exists(dFilePath) = True) Then
                        mensagem = "Falha na inserção da foto do utilizador."
                        titulo = Me.Text
                        botões = MessageBoxButtons.OK
                        icone = MessageBoxIcon.Information
                        MessageBox.Show(mensagem, titulo, botões, icone)
                    Else
                        'mensagem = "Imagem inserida com sucesso."
                        'titulo = Me.Text
                        'botões = MessageBoxButtons.OK
                        'icone = MessageBoxIcon.Information
                        'MessageBox.Show(mensagem, titulo, botões, icone)
                    End If
                End If
            End If
        End Using

    End Sub

    Private Sub btnovoutilizador_Click(sender As Object, e As EventArgs) Handles btnovoutilizador.Click
        Me.Text = "Novo Utilizador"
        gbutilizador.Visible = True
        lblmsgutilizador.Text = " Inserir Novo Utilizador "
        Desbloquear(True)
        btnconsultarutilizador.Enabled = False
        btneliminarutilizador.Enabled = False
        btneditarutilizadores.Enabled = False
        btncancelarutilizadores.Enabled = True
        btnsairutilizador.Enabled = False
        btnguardarutilizadores.Enabled = True
        btnovoutilizador.Enabled = False
        'txtnomedeutilizador.Visible = False
        'lblnomedeutilizador.Visible = False
        ' btnexcluirutilizador.Visible = False

        botao = 1
    End Sub

    Private Sub btncancelarutilizadores_Click(sender As Object, e As EventArgs) Handles btncancelarutilizadores.Click
        Me.Text = ""
        Desbloquear(False)
        Dim sqlnew As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea)"
        consutilizador(sqlnew)
        Limpar()
        gbutilizador.Visible = False
        'txtnomedeutilizador.Visible = False
        'lblnomedeutilizador.Visible = False
        txtnomedeutilizador.Clear()
        Ativar_obrigatorio(False)
        btneditarutilizadores.Enabled = True
        btneliminarutilizador.Enabled = True
        btnguardarutilizadores.Enabled = False
        btnconsultarutilizador.Enabled = True
        btncancelarutilizadores.Enabled = False
        btnsairutilizador.Enabled = True
        btnovoutilizador.Enabled = True
        btnexcluirutilizador.Visible = False


        ContarReg()
    End Sub

    Private Sub Hora_Tick(sender As Object, e As EventArgs) Handles Hora.Tick
        txthoraregistoutilizadores.Text = TimeOfDay
    End Sub

    Private Sub btneditarutilizadores_Click(sender As Object, e As EventArgs) Handles btneditarutilizadores.Click
        Dim numreg As Integer

        numreg = datagridutilizadores.RowCount

        Me.Text = "Editar Utilizador"
        If numreg = 0 Then
            gbutilizador.Visible = True
            lblmsgutilizador.Text = "Não selecionou nenhum utilizador"
        ElseIf datagridutilizadores.CurrentRow.Cells(1).Value = "Admin" Then
            gbutilizador.Visible = True
            lblmsgutilizador.Text = "O utilizador ADMIN só pode alterar a password"
            preencher_campos()
            txtpasswordutilizadores.Enabled = True
            txtconfirmapasswordutilizadores.Enabled = True
            Me.Text = "Editar Utilizador "
            'txtnomedeutilizador.Visible = True
            'lblnomedeutilizador.Visible = True
            botao = 2
            btnovoutilizador.Enabled = False
            btneliminarutilizador.Enabled = False
            btnconsultarutilizador.Enabled = False
            btnguardarutilizadores.Enabled = True
            btncancelarutilizadores.Enabled = True
        Else
            gbutilizador.Visible = False
            Me.Text = "Editar Utilizador "
            'txtnomedeutilizador.Visible = True
            'lblnomedeutilizador.Visible = True
            botao = 2
            btnovoutilizador.Enabled = False
            btneliminarutilizador.Enabled = False
            btnconsultarutilizador.Enabled = False
            btnguardarutilizadores.Enabled = True
            btncancelarutilizadores.Enabled = True
            'txtnomedeutilizador.Enabled = True
            btnexcluirutilizador.Enabled = True
            preencher_campos()
            Desbloquear(True)
            txtutilizadorutilizadores.Enabled = False
        End If
    End Sub

    Private Sub btneliminarutilizador_Click(sender As Object, e As EventArgs) Handles btneliminarutilizador.Click
        Dim numreg As Integer
        numreg = datagridutilizadores.RowCount

        Me.Text = "Eliminar Utilizador"
        If numreg = 0 Then
            gbutilizador.Visible = True
            lblmsgutilizador.Text = "Não selecionou nenhuma categoria"
        Else
            If datagridutilizadores.CurrentRow.Cells(1).Value = "Admin" Then
                gbutilizador.Visible = True
                lblmsgutilizador.Text = "O administrador não pode ser eliminado."
                btnexcluirutilizador.Visible = False
            ElseIf datagridutilizadores.CurrentRow.Cells(1).Value = user Then
                gbutilizador.Visible = True
                lblmsgutilizador.Text = "O Utilizador" & datagridutilizadores.CurrentRow.Cells(1).Value & " não pode ser eliminado uma vez que está a ser utilizado."
                btnexcluirutilizador.Visible = False
            Else
                ContarReg()
                gbutilizador.Visible = True
                lblmsgutilizador.Text = "Confirme se o utilizador a eliminar se encontra bem definido."
                btnovoutilizador.Enabled = False
                btneliminarutilizador.Enabled = False
                btneditarutilizadores.Enabled = False
                btnconsultarutilizador.Enabled = False
                btncancelarutilizadores.Enabled = True
                btnsairutilizador.Enabled = True
                'txtnomedeutilizador.Visible = True
                'lblnomedeutilizador.Visible = True
                btnexcluirutilizador.Visible = True
                preencher_campos()

                ' eliminar dados da  consulta utilizadores
                ' Try
                'txtnunutilizadores.Text = datagridutilizadores.CurrentRow.Cells(0).Value
                'txtnomedeutilizador.Text = datagridutilizadores.CurrentRow.Cells(1).Value
                'Dim resultado = MsgBox("Tem a certeza que pretende eliminar o utilizador? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar utilizador")
                'If resultado = DialogResult.Yes Then
                ' Call conectar()
                ' Dim sql As String = "delete from Utilizador where idUtilizador = '" & txtnunutilizadores.Text & "'"
                'Dim sqlcom As New SqlCommand(sql, con)
                'Dim dr As SqlDataReader = sqlcom.ExecuteReader
                'Call desconectar()
                'MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar utilizador")
                'Dim sqlnew As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea)"
                'consutilizador(sqlnew)
                'ContarReg()
                'End If
                '   Catch
                ' MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar utilizador")
                'End Try
            End If
        End If

    End Sub


    Private Sub btnconsultarutilizador_Click(sender As Object, e As EventArgs) Handles btnconsultarutilizador.Click
        Dim numreg As Integer

        Me.Text = "Consultar Utilizador"
        'lblmsgutilizador.Text = "Preencha um dos campos para realizar a consulta"
        'gbutilizador.Visible = True
        btnovoutilizador.Enabled = False
        btneditarutilizadores.Enabled = False
        btnguardarutilizadores.Enabled = False
        btneliminarutilizador.Enabled = False
        btncancelarutilizadores.Enabled = True

        numreg = datagridutilizadores.RowCount
        If numreg = 0 Then
            gbutilizador.Visible = True
            lblmsgutilizador.Text = "Não selecionou nenhum utilizador"
        Else
            preencher_campos()
        End If


    End Sub

    Private Sub mtxttelefoneutilizador_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxttelefoneutilizador.MaskInputRejected

        If validar.isvalidtelefone(mtxttelefoneutilizador.Text) = True Then
            mtxttelefoneutilizador.BackColor = Color.PaleGreen
        Else
            mtxttelefoneutilizador.BackColor = Color.LightCoral
        End If

    End Sub

    Private Sub txtemailutilizadores_TextChanged(sender As Object, e As EventArgs) Handles txtemailutilizadores.TextChanged
        If ValidarEmail(txtemailutilizadores.Text) = True Then
            txtemailutilizadores.BackColor = Color.PaleGreen
        Else
            txtemailutilizadores.BackColor = Color.LightCoral
        End If
    End Sub

    Private Sub txtnomedeutilizador_TextChanged(sender As Object, e As EventArgs)
        Dim sqlnew As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea) where utilizador like '" & txtnomedeutilizador.Text & "%'"
        consutilizador(sqlnew)
        ContarReg()
    End Sub

    Private Sub comfunçãoutilizadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comfunçãoutilizadores.SelectedIndexChanged
        lercategoria(comfunçãoutilizadores.SelectedValue)
    End Sub

    Private Sub btnexcluirutilizador_Click(sender As Object, e As EventArgs) Handles btnexcluirutilizador.Click
        Try
            btncancelarutilizadores.Enabled = True
            txtnunutilizadores.Text = datagridutilizadores.CurrentRow.Cells(0).Value
            txtnomedeutilizador.Text = datagridutilizadores.CurrentRow.Cells(1).Value
            Dim resultado = MsgBox("Tem a certeza que pretende eliminar o utilizador? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar utilizador")
            If resultado = DialogResult.Yes Then
                Call conectar()
                Dim sql As String = "delete from Utilizador where idUtilizador = '" & txtnunutilizadores.Text & "'"
                Dim sqlcom As New SqlCommand(sql, con)
                Dim dr As SqlDataReader = sqlcom.ExecuteReader
                Call desconectar()
                MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar utilizador")
                Desbloquear(False)
                Dim sqlnew As String = "select t1.idUtilizador, t1.utilizador, t1.nome, t1.tipodeutilizador, t1.estado, t1.morada, t1.codigoPostal, t1.codigoPostal2, t1.localidade, t1.telefone, t1.telemovel, t1.email, t1.dataNascimento, t2.Funcao, t3.nome, t1.obs, t1.chave, t1.foto from Utilizador t1 Inner Join Funcao t2 on (t1.idFuncao = t2.idFuncao) Inner Join AreaV t3 on (t1.idArea = t3.idArea)"
                consutilizador(sqlnew)
                Limpar()
                gbutilizador.Visible = False
                txtnomedeutilizador.Clear()
                Ativar_obrigatorio(False)
                btneditarutilizadores.Enabled = True
                btneliminarutilizador.Enabled = True
                btnguardarutilizadores.Enabled = False
                btnconsultarutilizador.Enabled = True
                btncancelarutilizadores.Enabled = False
                btnsairutilizador.Enabled = True
                btnovoutilizador.Enabled = True
                btnexcluirutilizador.Visible = False
                ContarReg()
            End If
        Catch
            MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Horario ")
        End Try
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtuserfiltro.Clear()
        txtnomedeutilizador.Clear()
        combotipofiltro.SelectedIndex = -1
        comboestadofiltro.SelectedIndex = -1
    End Sub

    Private Sub comboestadofiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboestadofiltro.SelectedIndexChanged
        ler_sql()
    End Sub

    Private Sub combotipofiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotipofiltro.SelectedIndexChanged
        ler_sql()
    End Sub

    Private Sub txtnomedeutilizador_TextChanged_1(sender As Object, e As EventArgs) Handles txtnomedeutilizador.TextChanged
        ler_sql()
    End Sub

    Private Sub txtuserfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtuserfiltro.TextChanged
        ler_sql()
    End Sub
End Class



