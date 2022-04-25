Imports System.Data.SqlClient
Public Class horario
    Dim botao As Integer
    Dim linhas As Integer

    Public Function verificar_horario() As Boolean
        Using con As SqlConnection = New SqlConnection()
            con.ConnectionString = ConnectionString_new
            Using cmd As SqlCommand = con.CreateCommand()
                cmd.CommandText = "select COUNT(*)  from Horario where idutilizador= '" & txtnumutilizadohorario.Text & "'"
                con.Open()
                Dim countreg As Integer = Integer.Parse(cmd.ExecuteScalar())
                linhas = countreg
                If countreg = 0 Then
                    Return True
                End If
            End Using
        End Using
    End Function

    Public Sub ler_sql()
        If combonomehorario.SelectedIndex = -1 And combofuncaopesquisa.SelectedIndex = -1 And combocategoriapesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonomehorario.Text & "%' and f.Funcao like '" & combofuncaopesquisa.Text & "%' and A.nome like '" & combocategoriapesquisa.Text & "%'"
            carregarutilizador(sql)
        ElseIf combonomehorario.SelectedIndex = -1 And combofuncaopesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where A.nome like '" & combocategoriapesquisa.Text & "%'"
            carregarutilizador(sql)
        ElseIf combonomehorario.SelectedIndex = -1 And combocategoriapesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where f.Funcao like '" & combofuncaopesquisa.Text & "%'"
            carregarutilizador(sql)
        ElseIf combofuncaopesquisa.SelectedIndex = -1 And combocategoriapesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonomehorario.Text & "%'"
            carregarutilizador(sql)
        ElseIf combonomehorario.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where f.Funcao like '" & combofuncaopesquisa.Text & "%' and A.nome like '" & combocategoriapesquisa.Text & "%'"
            carregarutilizador(sql)
        ElseIf combofuncaopesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonomehorario.Text & "%' and A.nome like '" & combocategoriapesquisa.Text & "%'"
            carregarutilizador(sql)
        ElseIf combocategoriapesquisa.SelectedIndex = -1 Then
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonomehorario.Text & "%' and f.Funcao like '" & combofuncaopesquisa.Text & "%'"
            carregarutilizador(sql)
        Else
            Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U INNER JOIN funcao F ON (U.idFuncao=F.idfuncao) INNER JOIN areav A ON (U.idArea=A.idArea) " & " where U.nome like '" & combonomehorario.Text & "%' and f.Funcao like '" & combofuncaopesquisa.Text & "%' and A.nome like '" & combocategoriapesquisa.Text & "%'"
            carregarutilizador(sql)
        End If
    End Sub

    Public Sub consGrelha()
        Call conectar()
        Dim sql As String = "Select  U.idUtilizador, U.utilizador, U.nome, F.Funcao, A.nome, U.idArea from utilizador U, funcao F, areav A  where U.idFuncao=F.idfuncao and U.idArea=A.idArea"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        dathorario.Columns.Clear()
        Dim n As Integer = dr.FieldCount

        dathorario.Columns.Add(0, "Código")
        dathorario.Columns.Add(1, "Utilizador")
        dathorario.Columns.Add(2, "Nome")
        dathorario.Columns.Add(3, "Função")
        dathorario.Columns.Add(4, "Categoria")
        dathorario.Columns.Add(5, "Área")

        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            dathorario.Rows.Add(linha)
            dathorario.Rows(i).Cells(0).Value = dr.Item(0)
            dathorario.Rows(i).Cells(1).Value = dr.Item(1)
            dathorario.Rows(i).Cells(2).Value = dr.Item(2)
            dathorario.Rows(i).Cells(3).Value = dr.Item(3)
            dathorario.Rows(i).Cells(4).Value = dr.Item(4)
            dathorario.Rows(i).Cells(5).Value = dr.Item(5)
            i = i + 1
        End While
        dathorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        dathorario.Columns(5).Visible = False
        Call desconectar()
    End Sub
    Public Sub carregarutilizador(sql As String)
        Call conectar()
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        dathorario.Columns.Clear()
        Dim n As Integer = dr.FieldCount

        dathorario.Columns.Add(0, "Código")
        dathorario.Columns.Add(1, "Utilizador")
        dathorario.Columns.Add(2, "Nome")
        dathorario.Columns.Add(3, "Função")
        dathorario.Columns.Add(4, "Categoria")
        dathorario.Columns.Add(5, "Área")
        Dim i As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            dathorario.Rows.Add(linha)
            dathorario.Rows(i).Cells(0).Value = dr.Item(0)
            dathorario.Rows(i).Cells(1).Value = dr.Item(1)
            dathorario.Rows(i).Cells(2).Value = dr.Item(2)
            dathorario.Rows(i).Cells(3).Value = dr.Item(3)
            dathorario.Rows(i).Cells(4).Value = dr.Item(4)
            dathorario.Rows(i).Cells(5).Value = dr.Item(5)
            i = i + 1
        End While
        dathorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Call desconectar()
        dathorario.Columns(5).Visible = False
    End Sub

    Public Sub lercategoria(funcao As Integer)
        Call conectar()
        Dim sql As String = "select idArea, nome from Areav where idFuncao = '" & funcao & "' order by nome"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combocategoriapesquisa.SelectedIndex = -1
        combocategoriapesquisa.ValueMember = "idArea"
        combocategoriapesquisa.DisplayMember = "nome"
        combocategoriapesquisa.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lerutilizador()
        Call conectar()
        Dim sql As String = "select idUtilizador, utilizador from Utilizador order by idUtilizador"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combonomehorario.ValueMember = "idUtilizador"
        combonomehorario.DisplayMember = "utilizador"
        combonomehorario.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lerdisciplina(area As Integer)
        If area <> -1 Then
            Call conectar()
            Dim sql As String = "select idDisciplina, Nomedisciplina from Disciplina where idArea = '" & area & "' order by NomeDisciplina"
            Dim com As SqlCommand = New SqlCommand(sql, con)
            Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
            Dim dt As DataTable = New DataTable
            dr.Fill(dt)
            'combodisciplinahorario.ValueMember = "idDisciplina"
            'combodisciplinahorario.DisplayMember = "Nomedisciplina"
            'combodisciplinahorario.DataSource = dt
            If dr.Fill(dt) = 0 Then
                lblInfo.Text = "A área disciplinar selecionada não possui disciplinas definidas."
                gbInfo.Visible = True
            End If
            Call desconectar()
        End If
    End Sub

    Public Sub lerbloco()

        Call conectar()
        Dim sql As String = "select idbloco, nomebloco from bloco order by Nomebloco"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        comboblocohorario.ValueMember = "idbloco"
        comboblocohorario.DisplayMember = "nomebloco"
        comboblocohorario.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lerarea()
        Call conectar()
        Dim sql As String = "select idarea, nomearea from area order by nomearea"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combareahorario.ValueMember = "idarea"
        combareahorario.DisplayMember = "nomearea"
        combareahorario.DataSource = dt
        Call desconectar()
        combareahorario.SelectedIndex = -1
    End Sub

    Public Sub lerfuncao()
        Call conectar()
        Dim sql As String = "select idFuncao, funcao from  Funcao order by Funcao"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        combofuncaopesquisa.ValueMember = "idFuncao"
        combofuncaopesquisa.DisplayMember = "funcao"
        combofuncaopesquisa.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lersala()

        Call conectar()
        Dim sql As String = "select idsala, sala from sala order by sala"
        Dim com As SqlCommand = New SqlCommand(sql, con)
        Dim dr As SqlDataAdapter = New SqlDataAdapter(com)
        Dim dt As DataTable = New DataTable
        dr.Fill(dt)
        'combosalahorario.ValueMember = "idsala"
        'combosalahorario.DisplayMember = "sala"
        'combosalahorario.DataSource = dt
        Call desconectar()
    End Sub

    Public Sub lerhoras()
        Call conectar()
        Dim sql As String = "select idtempo, intervaloHorario from Tempo order by idtempo"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        'Dim n As Integer = dr.FieldCount

        Dim i As Integer = 0
        Dim Lista_Horas = New ArrayList()
        While dr.Read
            Lista_Horas.Add(dr.Item(0))
            i = i + 1
        End While
        Call desconectar()
    End Sub

    Public Sub CarregarHorario()
        datagridhorario.Columns.Clear()
        combareahorario.Enabled = False
        'Dim colunaHoras = New DataGridViewComboBoxColumn()
        Dim colunaSegunda = New DataGridViewComboBoxColumn()
        Dim ColunaSalaSegunda = New DataGridViewComboBoxColumn()
        Dim colunaTerca = New DataGridViewComboBoxColumn()
        Dim ColunaSalaTerca = New DataGridViewComboBoxColumn()
        Dim colunaQuarta = New DataGridViewComboBoxColumn()
        Dim ColunaSalaQuarta = New DataGridViewComboBoxColumn()
        Dim colunaQuinta = New DataGridViewComboBoxColumn()
        Dim ColunaSalaQuinta = New DataGridViewComboBoxColumn()
        Dim colunaSexta = New DataGridViewComboBoxColumn()
        Dim ColunaSalaSexta = New DataGridViewComboBoxColumn()

        'colunaHoras.Name = "colunaHoras"
        colunaSegunda.Name = "colunaSegunda"
        ColunaSalaSegunda.Name = "ColunaSalaSegunda"
        colunaTerca.Name = "colunaTerca"
        ColunaSalaTerca.Name = "ColunaSalaTerca"
        colunaQuarta.Name = "colunaQuarta"
        ColunaSalaQuarta.Name = "ColunaSalaQuarta"
        colunaQuinta.Name = "colunaQuinta"
        ColunaSalaQuinta.Name = "ColunaSalaQuinta"
        colunaSexta.Name = "colunaSexta"
        ColunaSalaSexta.Name = "ColunaSalaSexta"

        'Configurando o texto do cabeçalho
        'colunaHoras.HeaderText = "Horas"
        colunaSegunda.HeaderText = "Segunda-feira"
        ColunaSalaSegunda.HeaderText = "Sala"
        colunaTerca.HeaderText = "Terça-feira"
        ColunaSalaTerca.HeaderText = "Sala"
        colunaQuarta.HeaderText = "Quarta-feira"
        ColunaSalaQuarta.HeaderText = "Sala"
        colunaQuinta.HeaderText = "Quinta-feira"
        ColunaSalaQuinta.HeaderText = "Sala"
        colunaSexta.HeaderText = "Sexta-feira"
        ColunaSalaSexta.HeaderText = "Sala"

        ' buscar os valores das horas na BD
        Call conectar()
        Dim sql As String = "select idtempo, intervaloHorario from Tempo order by idtempo"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader

        Dim i As Integer = 0
        'Dim Lista_Horas = New ArrayList()
        datagridhorario.Columns.Add(0, "Horas")
        datagridhorario.Columns(0).Width = 50
        datagridhorario.Columns(0).ReadOnly = True
        While dr.Read
            'Lista_Horas.Add(dr.Item(1))
            Dim linha As New DataGridViewRow
            datagridhorario.Rows.Add(linha)
            datagridhorario.Rows(i).Cells(0).Value = dr.Item(1)
            i = i + 1
        End While
        Call desconectar()

        ' buscar os valores das disciplinas na BD
        Call conectar()
        Dim sql1 As String = "select idDisciplina, Nomedisciplina from Disciplina where idArea = '" & combareahorario.SelectedValue & "' order by NomeDisciplina"
        Dim sqlcom1 As New SqlCommand(sql1, con)
        Dim dr1 As SqlDataReader = sqlcom1.ExecuteReader

        Dim k As Integer = 1
        Dim Lista_Disc = New ArrayList()
        Lista_Disc.Add("")
        While dr1.Read
            Lista_Disc.Add(dr1.Item(1))
            k = k + 1
        End While
        Call desconectar()

        ' buscar os valores das salas na BD
        Call conectar()
        Dim sql2 As String = "select idsala, sala from sala order by sala"
        Dim sqlcom2 As New SqlCommand(sql2, con)
        Dim dr2 As SqlDataReader = sqlcom2.ExecuteReader

        Dim J As Integer = 1
        Dim Lista_Sala = New ArrayList()
        Lista_Sala.Add("")
        While dr2.Read
            Lista_Sala.Add(dr2.Item(1))
            J = J + 1
        End While
        Call desconectar()

        'colunaHoras.Items.AddRange(Lista_Horas.ToArray())
        colunaSegunda.Items.AddRange(Lista_Disc.ToArray())
        ColunaSalaSegunda.Items.AddRange(Lista_Sala.ToArray())
        colunaTerca.Items.AddRange(Lista_Disc.ToArray())
        ColunaSalaTerca.Items.AddRange(Lista_Sala.ToArray())
        colunaQuarta.Items.AddRange(Lista_Disc.ToArray())
        ColunaSalaQuarta.Items.AddRange(Lista_Sala.ToArray())
        colunaQuinta.Items.AddRange(Lista_Disc.ToArray())
        ColunaSalaQuinta.Items.AddRange(Lista_Sala.ToArray())
        colunaSexta.Items.AddRange(Lista_Disc.ToArray())
        ColunaSalaSexta.Items.AddRange(Lista_Sala.ToArray())

        'Adicionando as colunas no grid
        'datagridhorario.Columns.Insert(0, colunaHoras)
        datagridhorario.Columns.Insert(1, colunaSegunda)
        datagridhorario.Columns.Insert(2, ColunaSalaSegunda)
        datagridhorario.Columns.Insert(3, colunaTerca)
        datagridhorario.Columns.Insert(4, ColunaSalaTerca)
        datagridhorario.Columns.Insert(5, colunaQuarta)
        datagridhorario.Columns.Insert(6, ColunaSalaQuarta)
        datagridhorario.Columns.Insert(7, colunaQuinta)
        datagridhorario.Columns.Insert(8, ColunaSalaQuinta)
        datagridhorario.Columns.Insert(9, colunaSexta)
        datagridhorario.Columns.Insert(10, ColunaSalaSexta)

        'Configurando a largura das colunas
        'Opção 1 - tamanho fixo
        'colunaHoras.Width = 70
        colunaSegunda.Width = 120
        ColunaSalaSegunda.Width = 50
        colunaTerca.Width = 120
        ColunaSalaTerca.Width = 50
        colunaQuarta.Width = 120
        ColunaSalaQuarta.Width = 50
        colunaQuinta.Width = 120
        ColunaSalaQuinta.Width = 50
        colunaSexta.Width = 120
        ColunaSalaSexta.Width = 50

        'Configurando a altura da linha do grid
        datagridhorario.RowTemplate.Height = 25

    End Sub

    Public Sub EditarHorario()
        'datagridhorario.Columns.Clear()
        combareahorario.Enabled = False
        Dim colunaHoras = New DataGridViewComboBoxColumn()
        Dim colunaSegunda = New DataGridViewComboBoxColumn()
        Dim ColunaSalaSegunda = New DataGridViewComboBoxColumn()
        Dim colunaTerca = New DataGridViewComboBoxColumn()
        Dim ColunaSalaTerca = New DataGridViewComboBoxColumn()
        Dim colunaQuarta = New DataGridViewComboBoxColumn()
        Dim ColunaSalaQuarta = New DataGridViewComboBoxColumn()
        Dim colunaQuinta = New DataGridViewComboBoxColumn()
        Dim ColunaSalaQuinta = New DataGridViewComboBoxColumn()
        Dim colunaSexta = New DataGridViewComboBoxColumn()
        Dim ColunaSalaSexta = New DataGridViewComboBoxColumn()

        'colunaNum.Name = "colunaNum"
        'colunaUser.Name = "colunaUser"
        colunaHoras.Name = "colunaHoras"
        colunaSegunda.Name = "colunaSegunda"
        ColunaSalaSegunda.Name = "ColunaSalaSegunda"
        colunaTerca.Name = "colunaTerca"
        ColunaSalaTerca.Name = "ColunaSalaTerca"
        colunaQuarta.Name = "colunaQuarta"
        ColunaSalaQuarta.Name = "ColunaSalaQuarta"
        colunaQuinta.Name = "colunaQuinta"
        ColunaSalaQuinta.Name = "ColunaSalaQuinta"
        colunaSexta.Name = "colunaSexta"
        ColunaSalaSexta.Name = "ColunaSalaSexta"

        'Configurando o texto do cabeçalho
        'colunaNum.HeaderText = "Nº"
        'colunaUser.HeaderText = "User"
        colunaHoras.HeaderText = "Horas"
        colunaSegunda.HeaderText = "Segunda-feira"
        ColunaSalaSegunda.HeaderText = "Sala"
        colunaTerca.HeaderText = "Terça-feira"
        ColunaSalaTerca.HeaderText = "Sala"
        colunaQuarta.HeaderText = "Quarta-feira"
        ColunaSalaQuarta.HeaderText = "Sala"
        colunaQuinta.HeaderText = "Quinta-feira"
        ColunaSalaQuinta.HeaderText = "Sala"
        colunaSexta.HeaderText = "Sexta-feira"
        ColunaSalaSexta.HeaderText = "Sala"

        ' buscar os valores das horas na BD
        Call conectar()
        Dim sql As String = "select idtempo, intervaloHorario from Tempo order by idtempo"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader

        Dim i As Integer = 0
        Dim Lista_Horas = New ArrayList()
        While dr.Read
            Lista_Horas.Add(dr.Item(1))
            i = i + 1
        End While
        Call desconectar()

        ' buscar os valores das disciplinas na BD
        Call conectar()
        Dim sql1 As String = "select idDisciplina, Nomedisciplina from Disciplina order by NomeDisciplina"
        Dim sqlcom1 As New SqlCommand(sql1, con)
        Dim dr1 As SqlDataReader = sqlcom1.ExecuteReader

        Dim k As Integer = 1
        Dim Lista_Disc = New ArrayList()
        Lista_Disc.Add("")
        While dr1.Read
            Lista_Disc.Add(dr1.Item(1))
            k = k + 1
        End While
        Call desconectar()

        ' buscar os valores das salas na BD
        Call conectar()
        Dim sql2 As String = "select idsala, sala from sala order by sala"
        Dim sqlcom2 As New SqlCommand(sql2, con)
        Dim dr2 As SqlDataReader = sqlcom2.ExecuteReader

        Dim J As Integer = 1
        Dim Lista_Sala = New ArrayList()
        Lista_Sala.Add("")
        While dr2.Read
            Lista_Sala.Add(dr2.Item(1))
            J = J + 1
        End While
        Call desconectar()

        'colunaNum.Items.AddRange(1)
        'colunaUser.Items.AddRange(1)
        colunaHoras.Items.AddRange(Lista_Horas.ToArray())
        colunaSegunda.Items.AddRange(Lista_Disc.ToArray())
        ColunaSalaSegunda.Items.AddRange(Lista_Sala.ToArray())
        colunaTerca.Items.AddRange(Lista_Disc.ToArray())
        ColunaSalaTerca.Items.AddRange(Lista_Sala.ToArray())
        colunaQuarta.Items.AddRange(Lista_Disc.ToArray())
        ColunaSalaQuarta.Items.AddRange(Lista_Sala.ToArray())
        colunaQuinta.Items.AddRange(Lista_Disc.ToArray())
        ColunaSalaQuinta.Items.AddRange(Lista_Sala.ToArray())
        colunaSexta.Items.AddRange(Lista_Disc.ToArray())
        ColunaSalaSexta.Items.AddRange(Lista_Sala.ToArray())

        'Adicionando as colunas no grid
        'datagridhorario.Columns.Add(0, "Num")
        'datagridhorario.Columns.Add(1, "User")
        'datagridhorario.Columns.Insert(1, colunaUser)
        datagridhorario.Columns.Insert(0, colunaHoras)
        datagridhorario.Columns.Insert(1, colunaSegunda)
        datagridhorario.Columns.Insert(2, ColunaSalaSegunda)
        datagridhorario.Columns.Insert(3, colunaTerca)
        datagridhorario.Columns.Insert(4, ColunaSalaTerca)
        datagridhorario.Columns.Insert(5, colunaQuarta)
        datagridhorario.Columns.Insert(6, ColunaSalaQuarta)
        datagridhorario.Columns.Insert(7, colunaQuinta)
        datagridhorario.Columns.Insert(8, ColunaSalaQuinta)
        datagridhorario.Columns.Insert(9, colunaSexta)
        datagridhorario.Columns.Insert(10, ColunaSalaSexta)

        'Configurando a largura das colunas
        'Opção 1 - tamanho fixo
        'colunaNum.Width = 50
        'colunaUser.Width = 50
        colunaHoras.Width = 70
        colunaSegunda.Width = 120
        ColunaSalaSegunda.Width = 50
        colunaTerca.Width = 120
        ColunaSalaTerca.Width = 50
        colunaQuarta.Width = 120
        ColunaSalaQuarta.Width = 50
        colunaQuinta.Width = 120
        ColunaSalaQuinta.Width = 50
        colunaSexta.Width = 120
        ColunaSalaSexta.Width = 50

        'Configurando a altura da linha do grid
        datagridhorario.RowTemplate.Height = 25

        'inserir do horário atribuido ao utilizador
        Call conectar()
        Dim sql5 As String = "select * from Horario where idutilizador= '" & txtnumutilizadohorario.Text & "'"
        Dim sqlcom5 As New SqlCommand(sql5, con)
        Dim dr5 As SqlDataReader = sqlcom5.ExecuteReader
        'datagridhorario.Columns.Clear()
        Dim valor As Integer = dr5.FieldCount
        Dim m As Integer = 0
        Dim n As Integer = 0
        While dr5.Read
            Dim linha As New DataGridViewRow
            datagridhorario.Rows.Add(linha)
            For n = 0 To 10
                datagridhorario.Rows(m).Cells(n).Value = dr5.Item(n + 3)
            Next
            m = m + 1
        End While
        Call desconectar()

    End Sub

    Public Sub consulthorario()
        Call conectar()
        Dim sql As String = "select * from Horario where idutilizador= '" & txtnumutilizadohorario.Text & "'"
        Dim sqlcom As New SqlCommand(sql, con)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader
        datagridhorario.Columns.Clear()
        Dim n As Integer = dr.FieldCount
        datagridhorario.Columns.Add(0, "Horas")
        datagridhorario.Columns.Add(1, "Segunda-feira")
        datagridhorario.Columns.Add(2, "Sala")
        datagridhorario.Columns.Add(3, "Terça-feira")
        datagridhorario.Columns.Add(4, "Sala")
        datagridhorario.Columns.Add(5, "Quarta-feira")
        datagridhorario.Columns.Add(6, "Sala")
        datagridhorario.Columns.Add(7, "Quinta-feira")
        datagridhorario.Columns.Add(8, "Sala")
        datagridhorario.Columns.Add(9, "Sexta-feira")
        datagridhorario.Columns.Add(10, "Sala")

        Dim i As Integer = 0
        Dim j As Integer = 0
        While dr.Read
            Dim linha As New DataGridViewRow
            datagridhorario.Rows.Add(linha)
            For j = 3 To 13
                datagridhorario.Rows(i).Cells(j - 3).Value = dr.Item(j)
            Next
            i = i + 1
        End While
        'datagridhorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        datagridhorario.Columns(0).Width = "50"
        datagridhorario.Columns(1).Width = "120"
        datagridhorario.Columns(2).Width = "50"
        datagridhorario.Columns(3).Width = "120"
        datagridhorario.Columns(4).Width = "50"
        datagridhorario.Columns(5).Width = "120"
        datagridhorario.Columns(6).Width = "50"
        datagridhorario.Columns(7).Width = "120"
        datagridhorario.Columns(8).Width = "50"
        datagridhorario.Columns(9).Width = "120"
        datagridhorario.Columns(10).Width = "50"
        Call desconectar()
    End Sub

    Public Sub desbloquearhorario(ByVal estado As Boolean)
        txtnumutilizadohorario.Enabled = estado
        txtUser.Enabled = estado
        txtnomeutilizadorhorario.Enabled = estado
        txtFuncao.Enabled = estado
        txtCategoria.Enabled = estado
        txtnumhorario.Enabled = estado
        combareahorario.Enabled = estado
        comboblocohorario.Enabled = estado
    End Sub

    Public Sub ativarhorario(ByVal estado As Boolean)
        lblobrigatorioarea.Visible = estado
        lblobrigatoriobloco.Visible = estado
    End Sub

    Public Sub limparhorario()
        txtnumutilizadohorario.Clear()
        txtnumutilizadohorario.Enabled = False
        txtnumhorario.Clear()
        txtnumhorario.Enabled = False
        combofuncaopesquisa.SelectedItem = -1
        combocategoriapesquisa.SelectedItem = -1
        combareahorario.SelectedItem = -1
        combareahorario.Focus()
        comboblocohorario.SelectedItem = -1
        comboblocohorario.Focus()
        txtUser.Clear()
        txtFuncao.Clear()
        txtCategoria.Clear()
        txtnomeutilizadorhorario.Clear()
        combareahorario.SelectedIndex = -1
    End Sub

    Private Sub btnovohorario_Click(sender As Object, e As EventArgs) Handles btnovohorario.Click
        Me.Text = " Novo horário"
        gbInfo.Visible = False
        txtnumutilizadohorario.Text = dathorario.CurrentRow.Cells(0).Value
        txtUser.Text = dathorario.CurrentRow.Cells(1).Value
        txtnomeutilizadorhorario.Text = dathorario.CurrentRow.Cells(2).Value
        txtFuncao.Text = dathorario.CurrentRow.Cells(3).Value
        txtCategoria.Text = dathorario.CurrentRow.Cells(4).Value
        If verificar_horario() = False Then
            lblInfo.Text = "O utilizador " & txtUser.Text & " já tem horário atribuido"
            gbInfo.Visible = True
            limparhorario()
            Exit Sub
        End If
        lerarea()
        btncancelarhorario.Enabled = True
        btnovohorario.Enabled = False
        btneditarhorario.Enabled = False
        btneliminarhorario.Enabled = False
        btnguardarhorario.Enabled = True
        btnsairhorario.Enabled = False
        combareahorario.Enabled = True
        botao = 1
    End Sub

    Private Sub btnguardarhorario_Click(sender As Object, e As EventArgs) Handles btnguardarhorario.Click
        ativarhorario(False)
        If botao = 1 Then
            If lblobrigatorioarea.Visible = False And lblobrigatoriobloco.Visible = False Then
                Dim res As String
                res = datagridhorario.RowCount - 1
                Call conectar()
                Dim i As Integer
                For i = 0 To res
                    Call conectar()
                    Dim sql3 As String = "insert into Horario values ('" & txtnumutilizadohorario.Text & "', '" & i + 1 & "', '" & datagridhorario.Rows(i).Cells(0).Value & "','" & datagridhorario.Rows(i).Cells(1).Value & "', '" & datagridhorario.Rows(i).Cells(2).Value & "', '" & datagridhorario.Rows(i).Cells(3).Value & "', '" & datagridhorario.Rows(i).Cells(4).Value & "', '" & datagridhorario.Rows(i).Cells(5).Value & "', '" & datagridhorario.Rows(i).Cells(6).Value & "', '" & datagridhorario.Rows(i).Cells(7).Value & "', '" & datagridhorario.Rows(i).Cells(8).Value & "', '" & datagridhorario.Rows(i).Cells(9).Value & "', '" & datagridhorario.Rows(i).Cells(10).Value & "')"
                    Dim sqlcom3 As New SqlCommand(sql3, con)
                    Dim dr3 As SqlDataReader = sqlcom3.ExecuteReader
                    Call desconectar()
                Next
                consulthorario()
                btnsairhorario.Enabled = True
                limparhorario()
            End If
        ElseIf botao = 2 Then
            If lblobrigatorioarea.Visible = False And lblobrigatoriobloco.Visible = False Then
                Dim res1 As String
                res1 = datagridhorario.RowCount - 2

                Dim j As Integer
                For j = 0 To res1
                    Call conectar()
                    Dim sql4 As String = "update Horario set hora = '" & datagridhorario.Rows(j).Cells(0).Value & "', disc_seg = '" & datagridhorario.Rows(j).Cells(1).Value & "', sala_seg = '" & datagridhorario.Rows(j).Cells(2).Value & "', disc_ter = '" & datagridhorario.Rows(j).Cells(3).Value & "', sala_ter = '" & datagridhorario.Rows(j).Cells(4).Value & "', disc_qua = '" & datagridhorario.Rows(j).Cells(5).Value & "', sala_qua ='" & datagridhorario.Rows(j).Cells(6).Value & "', disc_qui = '" & datagridhorario.Rows(j).Cells(7).Value & "', sala_qui = '" & datagridhorario.Rows(j).Cells(8).Value & "', disc_sex = '" & datagridhorario.Rows(j).Cells(9).Value & "', sala_sex = '" & datagridhorario.Rows(j).Cells(10).Value & "' where idUtilizador= '" & txtnumutilizadohorario.Text & "' and NumHorario = '" & j + 1 & "'"
                    Dim sqlcom4 As New SqlCommand(sql4, con)
                    Dim dr4 As SqlDataReader = sqlcom4.ExecuteReader
                    Call desconectar()
                Next
                consulthorario()
                btnsairhorario.Enabled = True
                'limparhorario()
                lblInfo.Text = "Atualizado o horário do utilizador " & txtUser.Text & "."
                gbInfo.Visible = True

            End If
            'Call conectar()
            'Dim sql1 As String = "update horario  set idHorario = '" & txtnomebloco.Text & "' where idbloco= '" & txtbloconum.Text & "'"
            'Dim sqlcon1 As New SqlCommand(sql1, con)
            'Dim dr1 As SqlDataReader = sqlcon1.ExecuteReader
            'dr1.Close()
        End If
        btncancelarhorario.Enabled = False
        btnovohorario.Enabled = True
        btneditarhorario.Enabled = True
        btneliminarhorario.Enabled = True
        btnguardarhorario.Enabled = False
        btnsairhorario.Enabled = True
    End Sub

    Private Sub btncancelarhorario_Click(sender As Object, e As EventArgs) Handles btncancelarhorario.Click
        Me.Text = "Cancelar horario"
        gbInfo.Visible = False
        desbloquearhorario(False)
        ativarhorario(False)
        datagridhorario.Columns.Clear()
        btnovohorario.Enabled = True
        btneditarhorario.Enabled = True
        btneliminarhorario.Enabled = True
        btnguardarhorario.Enabled = False
        btncancelarhorario.Enabled = False
        btnsairhorario.Enabled = True
        limparhorario()
    End Sub

    Private Sub btnsairhorario_Click(sender As Object, e As EventArgs) Handles btnsairhorario.Click
        Me.Close()
        If tipouser = 0 Then
            Bloquear_menu(False)
            formulario_principal.tsbHorario.Enabled = True
            formulario_principal.tsbUtilizador.Enabled = True
            formulario_principal.tsbRegistos.Enabled = True
            formulario_principal.tsbHorario.Enabled = True
            formulario_principal.tsbSair.Enabled = True
        Else
            Bloquear_menu(True)
        End If
    End Sub

    Private Sub horario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridhorario.AllowUserToAddRows = False
        gbInfo.Visible = False
        lerfuncao()
        lerbloco()
        lersala()
        lerutilizador()
        consGrelha()
        combonomehorario.SelectedIndex = -1
        combofuncaopesquisa.SelectedIndex = -1
        combocategoriapesquisa.SelectedIndex = -1
        combareahorario.SelectedIndex = -1
        comboblocohorario.SelectedIndex = -1
        desbloquearhorario(False)
        ativarhorario(False)
        btncancelarhorario.Enabled = False
        btnguardarhorario.Enabled = False
        limparhorario()
        'txtnomeutilizadorhorario.Enabled = False
        If tipouser = "0" Then
            btnovohorario.Enabled = False
            btneditarhorario.Enabled = False
            btneliminarhorario.Enabled = False
            btnguardarhorario.Enabled = False
            btncancelarhorario.Enabled = False
            btnsairhorario.Enabled = True
            btnconsultaregistos.Enabled = True
        End If
    End Sub

    Private Sub btneliminarhorario_Click(sender As Object, e As EventArgs) Handles btneliminarhorario.Click
        gbInfo.Visible = False
        datagridhorario.Columns.Clear()
        gbInfo.Visible = False
        lerarea()
        txtnumutilizadohorario.Text = dathorario.CurrentRow.Cells(0).Value
        txtUser.Text = dathorario.CurrentRow.Cells(1).Value
        txtnomeutilizadorhorario.Text = dathorario.CurrentRow.Cells(2).Value
        txtFuncao.Text = dathorario.CurrentRow.Cells(3).Value
        txtCategoria.Text = dathorario.CurrentRow.Cells(4).Value
        combareahorario.SelectedValue = dathorario.CurrentRow.Cells(5).Value
        btncancelarhorario.Enabled = True
        btnovohorario.Enabled = False
        btneditarhorario.Enabled = False
        btneliminarhorario.Enabled = True
        btnconsultaregistos.Enabled = False
        btnguardarhorario.Enabled = False
        btnsairhorario.Enabled = False
        'datagridhorario.Columns.Clear()
        consulthorario()
        If verificar_horario() = True Then
            lblInfo.Text = "O utilizador " & txtUser.Text & " não pode eliminar, uma vez que não tem horário definido."
            gbInfo.Visible = True
        Else
            Dim resultado = MsgBox("Tem a certeza que pretende eliminar o horário? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Horario")
            If resultado = DialogResult.Yes Then
                Dim i As Integer
                For i = 1 To linhas
                    Call conectar()
                    Dim sql As String = "delete from Horario where idUtilizador = '" & txtnumutilizadohorario.Text & "' and NumHorario = '" & i & "'"
                    Dim sqlcom As New SqlCommand(sql, con)
                    Dim dr As SqlDataReader = sqlcom.ExecuteReader
                    Call desconectar()
                Next
                MsgBox("Eliminado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Horario")
                consulthorario()
            End If
        End If
        'Catch
        'MsgBox("Não pode ser eliminado. Está a ser utilizado noutro sitio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Eliminar Horario ")
        'End Try
    End Sub

    Private Sub btneditarhorario_Click(sender As Object, e As EventArgs) Handles btneditarhorario.Click
        gbInfo.Visible = False
        If verificar_horario() = False Then
            lblInfo.Text = "O utilizador" & txtUser.Text & " não tem horário definido. Clique em NOVO para inserir horário."
            gbInfo.Visible = True
            Exit Sub
        End If
        botao = 2
        btnovohorario.Enabled = False
        btneliminarhorario.Enabled = False
        btnguardarhorario.Enabled = True
        btncancelarhorario.Enabled = True
        lerarea()
        txtnumutilizadohorario.Text = dathorario.CurrentRow.Cells(0).Value
        txtUser.Text = dathorario.CurrentRow.Cells(1).Value
        txtnomeutilizadorhorario.Text = dathorario.CurrentRow.Cells(2).Value
        txtFuncao.Text = dathorario.CurrentRow.Cells(3).Value
        txtCategoria.Text = dathorario.CurrentRow.Cells(4).Value
        combareahorario.SelectedValue = dathorario.CurrentRow.Cells(5).Value
        btncancelarhorario.Enabled = True
        btnovohorario.Enabled = False
        btneditarhorario.Enabled = False
        btneliminarhorario.Enabled = False
        btnguardarhorario.Enabled = True
        btnsairhorario.Enabled = False
        datagridhorario.Columns.Clear()
        'consulthorario()
        'definição das parametrizações da datagridhorario
        EditarHorario()
    End Sub

    Private Sub combonomehorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combonomehorario.SelectedIndexChanged
        ler_sql()
    End Sub

    Private Sub combofuncaopesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combofuncaopesquisa.SelectedIndexChanged
        lercategoria(combofuncaopesquisa.SelectedValue)
        combocategoriapesquisa.SelectedIndex = -1
        ler_sql()
    End Sub

    Private Sub combocategoriapesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocategoriapesquisa.SelectedIndexChanged
        ler_sql()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        combofuncaopesquisa.SelectedIndex = -1
        combocategoriapesquisa.SelectedIndex = -1
        combonomehorario.SelectedIndex = -1
    End Sub

    'Private Sub datagridhorario_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles datagridhorario.EditingControlShowing
    'Dim comboBoxColumn As DataGridViewComboBoxColumn = datagridhorario.Columns(0)

    '   If (datagridhorario.CurrentCellAddress.X = comboBoxColumn.DisplayIndex) Then
    'Dim cb As ComboBox = e.Control
    '       If (cb IsNot Nothing) Then
    '          cb.DropDownStyle = ComboBoxStyle.DropDown
    '     End If
    ' End If
    'End Sub

    Private Sub combareahorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combareahorario.SelectedIndexChanged
        'Dim area As Integer
        'area = comboblocohorario.SelectedValue
        'MsgBox(area)
        'lerdisciplina(Area)

        'definição das parametrizações da datagridhorario
        If combareahorario.SelectedIndex <> -1 And combareahorario.Enabled = True Then
            CarregarHorario()
        End If
    End Sub

    Private Sub btnconsultaregistos_Click(sender As Object, e As EventArgs) Handles btnconsultaregistos.Click
        datagridhorario.Columns.Clear()
        gbInfo.Visible = False
        lerarea()
        txtnumutilizadohorario.Text = dathorario.CurrentRow.Cells(0).Value
        txtUser.Text = dathorario.CurrentRow.Cells(1).Value
        txtnomeutilizadorhorario.Text = dathorario.CurrentRow.Cells(2).Value
        txtFuncao.Text = dathorario.CurrentRow.Cells(3).Value
        txtCategoria.Text = dathorario.CurrentRow.Cells(4).Value
        combareahorario.SelectedValue = dathorario.CurrentRow.Cells(5).Value
        btncancelarhorario.Enabled = True
        btnovohorario.Enabled = False
        btneditarhorario.Enabled = False
        btneliminarhorario.Enabled = False
        btnguardarhorario.Enabled = False
        btnsairhorario.Enabled = False
        'datagridhorario.Columns.Clear()
        consulthorario()
        If tipouser = "0" Then
            btncancelarhorario.Enabled = False
            btnsairhorario.Enabled = True
        End If
    End Sub
End Class