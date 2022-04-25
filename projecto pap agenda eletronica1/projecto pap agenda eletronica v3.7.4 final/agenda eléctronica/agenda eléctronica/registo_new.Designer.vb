<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registo_new
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.menuhorario = New System.Windows.Forms.MenuStrip()
        Me.btnovoregisto = New System.Windows.Forms.Button()
        Me.btneditarregisto = New System.Windows.Forms.Button()
        Me.btneliminarregisto = New System.Windows.Forms.Button()
        Me.btnguardarregisto = New System.Windows.Forms.Button()
        Me.btnsairregisto = New System.Windows.Forms.Button()
        Me.btncancelarregisto = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.grouputilizadorhorario = New System.Windows.Forms.GroupBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtFuncao = New System.Windows.Forms.TextBox()
        Me.txtnomeutilizador = New System.Windows.Forms.TextBox()
        Me.txtnumutilizador = New System.Windows.Forms.TextBox()
        Me.lblnomeutilizadorhorario = New System.Windows.Forms.Label()
        Me.lblcategoriaoutilizadorhorario = New System.Windows.Forms.Label()
        Me.lblfuncaoutilizadorhorario = New System.Windows.Forms.Label()
        Me.lblnumhorario = New System.Windows.Forms.Label()
        Me.datutilizadores = New System.Windows.Forms.DataGridView()
        Me.groupesquisa = New System.Windows.Forms.GroupBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.combonome = New System.Windows.Forms.ComboBox()
        Me.combocategoriapesquisa = New System.Windows.Forms.ComboBox()
        Me.combofuncaopesquisa = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.registosdados = New System.Windows.Forms.GroupBox()
        Me.lblObrigatorioComunicacao = New System.Windows.Forms.Label()
        Me.lblobrigatorioanolectivoregistos = New System.Windows.Forms.Label()
        Me.lblobrigatoriotiposerviçoregistos = New System.Windows.Forms.Label()
        Me.lblobrigatorioturmaregistos = New System.Windows.Forms.Label()
        Me.lblobrigatoriodestinatarioregistos = New System.Windows.Forms.Label()
        Me.combanoletivoregisto = New System.Windows.Forms.ComboBox()
        Me.comboturmaregistos = New System.Windows.Forms.ComboBox()
        Me.numdowqtregistos = New System.Windows.Forms.NumericUpDown()
        Me.txtobsregistos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mtelemovelregistos = New System.Windows.Forms.MaskedTextBox()
        Me.telemovelregistos = New System.Windows.Forms.Label()
        Me.mtelefoneregistos = New System.Windows.Forms.MaskedTextBox()
        Me.lbltelefoneregisto = New System.Windows.Forms.Label()
        Me.combotiposerviçosregistos = New System.Windows.Forms.ComboBox()
        Me.lbltiposervicoregistos = New System.Windows.Forms.Label()
        Me.lblturmaregistos = New System.Windows.Forms.Label()
        Me.txtdestinarioregistos = New System.Windows.Forms.TextBox()
        Me.lbldestinarioregisto = New System.Windows.Forms.Label()
        Me.lblqtregistos = New System.Windows.Forms.Label()
        Me.combocomuniregistos = New System.Windows.Forms.ComboBox()
        Me.lblvcomunicacaoregistos = New System.Windows.Forms.Label()
        Me.txthorasregisto = New System.Windows.Forms.TextBox()
        Me.lblhoraregistos = New System.Windows.Forms.Label()
        Me.txtdataregistos = New System.Windows.Forms.TextBox()
        Me.lbldataregisto = New System.Windows.Forms.Label()
        Me.lblanoletivoregisto = New System.Windows.Forms.Label()
        Me.txtnumregistos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.datagridregistos = New System.Windows.Forms.DataGridView()
        Me.Horaregisto = New System.Windows.Forms.Timer(Me.components)
        Me.btnconsultaregistos = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grouputilizadorhorario.SuspendLayout()
        CType(Me.datutilizadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupesquisa.SuspendLayout()
        Me.registosdados.SuspendLayout()
        CType(Me.numdowqtregistos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridregistos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuhorario
        '
        Me.menuhorario.Location = New System.Drawing.Point(0, 0)
        Me.menuhorario.Name = "menuhorario"
        Me.menuhorario.Size = New System.Drawing.Size(988, 24)
        Me.menuhorario.TabIndex = 0
        Me.menuhorario.Text = "menuhorario"
        '
        'btnovoregisto
        '
        Me.btnovoregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnovoregisto.Location = New System.Drawing.Point(0, -3)
        Me.btnovoregisto.Name = "btnovoregisto"
        Me.btnovoregisto.Size = New System.Drawing.Size(75, 23)
        Me.btnovoregisto.TabIndex = 13
        Me.btnovoregisto.Text = "Novo"
        Me.btnovoregisto.UseVisualStyleBackColor = True
        '
        'btneditarregisto
        '
        Me.btneditarregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarregisto.Location = New System.Drawing.Point(66, -3)
        Me.btneditarregisto.Name = "btneditarregisto"
        Me.btneditarregisto.Size = New System.Drawing.Size(75, 23)
        Me.btneditarregisto.TabIndex = 14
        Me.btneditarregisto.Text = "Editar"
        Me.btneditarregisto.UseVisualStyleBackColor = True
        '
        'btneliminarregisto
        '
        Me.btneliminarregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarregisto.Location = New System.Drawing.Point(139, -3)
        Me.btneliminarregisto.Name = "btneliminarregisto"
        Me.btneliminarregisto.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarregisto.TabIndex = 15
        Me.btneliminarregisto.Text = "Eliminar"
        Me.btneliminarregisto.UseVisualStyleBackColor = True
        '
        'btnguardarregisto
        '
        Me.btnguardarregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarregisto.Location = New System.Drawing.Point(209, -3)
        Me.btnguardarregisto.Name = "btnguardarregisto"
        Me.btnguardarregisto.Size = New System.Drawing.Size(75, 23)
        Me.btnguardarregisto.TabIndex = 16
        Me.btnguardarregisto.Text = "Guardar"
        Me.btnguardarregisto.UseVisualStyleBackColor = True
        '
        'btnsairregisto
        '
        Me.btnsairregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairregisto.Location = New System.Drawing.Point(419, -3)
        Me.btnsairregisto.Name = "btnsairregisto"
        Me.btnsairregisto.Size = New System.Drawing.Size(75, 23)
        Me.btnsairregisto.TabIndex = 19
        Me.btnsairregisto.Text = "Sair"
        Me.btnsairregisto.UseVisualStyleBackColor = True
        '
        'btncancelarregisto
        '
        Me.btncancelarregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarregisto.Location = New System.Drawing.Point(346, -3)
        Me.btncancelarregisto.Name = "btncancelarregisto"
        Me.btncancelarregisto.Size = New System.Drawing.Size(75, 23)
        Me.btncancelarregisto.TabIndex = 26
        Me.btncancelarregisto.Text = "Cancelar"
        Me.btncancelarregisto.UseVisualStyleBackColor = True
        '
        'grouputilizadorhorario
        '
        Me.grouputilizadorhorario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grouputilizadorhorario.Controls.Add(Me.txtUser)
        Me.grouputilizadorhorario.Controls.Add(Me.lblUser)
        Me.grouputilizadorhorario.Controls.Add(Me.txtCategoria)
        Me.grouputilizadorhorario.Controls.Add(Me.txtFuncao)
        Me.grouputilizadorhorario.Controls.Add(Me.txtnomeutilizador)
        Me.grouputilizadorhorario.Controls.Add(Me.txtnumutilizador)
        Me.grouputilizadorhorario.Controls.Add(Me.lblnomeutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblcategoriaoutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblfuncaoutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblnumhorario)
        Me.grouputilizadorhorario.Location = New System.Drawing.Point(10, 37)
        Me.grouputilizadorhorario.Name = "grouputilizadorhorario"
        Me.grouputilizadorhorario.Size = New System.Drawing.Size(470, 106)
        Me.grouputilizadorhorario.TabIndex = 27
        Me.grouputilizadorhorario.TabStop = False
        Me.grouputilizadorhorario.Text = "Dados do Utilizador"
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(304, 15)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 8
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Blue
        Me.lblUser.Location = New System.Drawing.Point(235, 20)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(64, 13)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "Utilizador:"
        '
        'txtCategoria
        '
        Me.txtCategoria.Enabled = False
        Me.txtCategoria.Location = New System.Drawing.Point(304, 72)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoria.TabIndex = 6
        '
        'txtFuncao
        '
        Me.txtFuncao.Enabled = False
        Me.txtFuncao.Location = New System.Drawing.Point(117, 70)
        Me.txtFuncao.Name = "txtFuncao"
        Me.txtFuncao.Size = New System.Drawing.Size(100, 20)
        Me.txtFuncao.TabIndex = 5
        '
        'txtnomeutilizador
        '
        Me.txtnomeutilizador.Enabled = False
        Me.txtnomeutilizador.Location = New System.Drawing.Point(117, 43)
        Me.txtnomeutilizador.Name = "txtnomeutilizador"
        Me.txtnomeutilizador.Size = New System.Drawing.Size(289, 20)
        Me.txtnomeutilizador.TabIndex = 4
        '
        'txtnumutilizador
        '
        Me.txtnumutilizador.Enabled = False
        Me.txtnumutilizador.Location = New System.Drawing.Point(118, 20)
        Me.txtnumutilizador.Name = "txtnumutilizador"
        Me.txtnumutilizador.Size = New System.Drawing.Size(32, 20)
        Me.txtnumutilizador.TabIndex = 3
        '
        'lblnomeutilizadorhorario
        '
        Me.lblnomeutilizadorhorario.AutoSize = True
        Me.lblnomeutilizadorhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeutilizadorhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblnomeutilizadorhorario.Location = New System.Drawing.Point(70, 46)
        Me.lblnomeutilizadorhorario.Name = "lblnomeutilizadorhorario"
        Me.lblnomeutilizadorhorario.Size = New System.Drawing.Size(43, 13)
        Me.lblnomeutilizadorhorario.TabIndex = 1
        Me.lblnomeutilizadorhorario.Text = "Nome:"
        '
        'lblcategoriaoutilizadorhorario
        '
        Me.lblcategoriaoutilizadorhorario.AutoSize = True
        Me.lblcategoriaoutilizadorhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategoriaoutilizadorhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblcategoriaoutilizadorhorario.Location = New System.Drawing.Point(237, 74)
        Me.lblcategoriaoutilizadorhorario.Name = "lblcategoriaoutilizadorhorario"
        Me.lblcategoriaoutilizadorhorario.Size = New System.Drawing.Size(65, 13)
        Me.lblcategoriaoutilizadorhorario.TabIndex = 2
        Me.lblcategoriaoutilizadorhorario.Text = "Categoria:"
        '
        'lblfuncaoutilizadorhorario
        '
        Me.lblfuncaoutilizadorhorario.AutoSize = True
        Me.lblfuncaoutilizadorhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuncaoutilizadorhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblfuncaoutilizadorhorario.Location = New System.Drawing.Point(61, 74)
        Me.lblfuncaoutilizadorhorario.Name = "lblfuncaoutilizadorhorario"
        Me.lblfuncaoutilizadorhorario.Size = New System.Drawing.Size(53, 13)
        Me.lblfuncaoutilizadorhorario.TabIndex = 1
        Me.lblfuncaoutilizadorhorario.Text = "Função:"
        '
        'lblnumhorario
        '
        Me.lblnumhorario.AutoSize = True
        Me.lblnumhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblnumhorario.Location = New System.Drawing.Point(88, 22)
        Me.lblnumhorario.Name = "lblnumhorario"
        Me.lblnumhorario.Size = New System.Drawing.Size(25, 13)
        Me.lblnumhorario.TabIndex = 0
        Me.lblnumhorario.Text = "Nº:"
        '
        'datutilizadores
        '
        Me.datutilizadores.AllowUserToAddRows = False
        Me.datutilizadores.AllowUserToResizeColumns = False
        Me.datutilizadores.AllowUserToResizeRows = False
        Me.datutilizadores.BackgroundColor = System.Drawing.Color.White
        Me.datutilizadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datutilizadores.Location = New System.Drawing.Point(15, 80)
        Me.datutilizadores.Name = "datutilizadores"
        Me.datutilizadores.ReadOnly = True
        Me.datutilizadores.RowHeadersVisible = False
        Me.datutilizadores.Size = New System.Drawing.Size(453, 321)
        Me.datutilizadores.TabIndex = 24
        '
        'groupesquisa
        '
        Me.groupesquisa.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.groupesquisa.Controls.Add(Me.btnLimpar)
        Me.groupesquisa.Controls.Add(Me.combonome)
        Me.groupesquisa.Controls.Add(Me.datutilizadores)
        Me.groupesquisa.Controls.Add(Me.combocategoriapesquisa)
        Me.groupesquisa.Controls.Add(Me.combofuncaopesquisa)
        Me.groupesquisa.Controls.Add(Me.Label4)
        Me.groupesquisa.Controls.Add(Me.lbl)
        Me.groupesquisa.Controls.Add(Me.Label6)
        Me.groupesquisa.Location = New System.Drawing.Point(498, 40)
        Me.groupesquisa.Name = "groupesquisa"
        Me.groupesquisa.Size = New System.Drawing.Size(481, 418)
        Me.groupesquisa.TabIndex = 28
        Me.groupesquisa.TabStop = False
        Me.groupesquisa.Text = "Pesquisa"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(393, 50)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpar.TabIndex = 26
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'combonome
        '
        Me.combonome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.combonome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combonome.FormattingEnabled = True
        Me.combonome.Location = New System.Drawing.Point(69, 19)
        Me.combonome.Name = "combonome"
        Me.combonome.Size = New System.Drawing.Size(400, 21)
        Me.combonome.TabIndex = 25
        '
        'combocategoriapesquisa
        '
        Me.combocategoriapesquisa.FormattingEnabled = True
        Me.combocategoriapesquisa.Location = New System.Drawing.Point(247, 50)
        Me.combocategoriapesquisa.Name = "combocategoriapesquisa"
        Me.combocategoriapesquisa.Size = New System.Drawing.Size(95, 21)
        Me.combocategoriapesquisa.TabIndex = 23
        '
        'combofuncaopesquisa
        '
        Me.combofuncaopesquisa.FormattingEnabled = True
        Me.combofuncaopesquisa.Location = New System.Drawing.Point(69, 49)
        Me.combofuncaopesquisa.Name = "combofuncaopesquisa"
        Me.combofuncaopesquisa.Size = New System.Drawing.Size(95, 21)
        Me.combofuncaopesquisa.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(23, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nome:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Blue
        Me.lbl.Location = New System.Drawing.Point(178, 53)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(65, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "Categoria:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(13, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Função:"
        '
        'registosdados
        '
        Me.registosdados.Controls.Add(Me.lblObrigatorioComunicacao)
        Me.registosdados.Controls.Add(Me.lblobrigatorioanolectivoregistos)
        Me.registosdados.Controls.Add(Me.lblobrigatoriotiposerviçoregistos)
        Me.registosdados.Controls.Add(Me.lblobrigatorioturmaregistos)
        Me.registosdados.Controls.Add(Me.lblobrigatoriodestinatarioregistos)
        Me.registosdados.Controls.Add(Me.combanoletivoregisto)
        Me.registosdados.Controls.Add(Me.comboturmaregistos)
        Me.registosdados.Controls.Add(Me.numdowqtregistos)
        Me.registosdados.Controls.Add(Me.txtobsregistos)
        Me.registosdados.Controls.Add(Me.Label12)
        Me.registosdados.Controls.Add(Me.mtelemovelregistos)
        Me.registosdados.Controls.Add(Me.telemovelregistos)
        Me.registosdados.Controls.Add(Me.mtelefoneregistos)
        Me.registosdados.Controls.Add(Me.lbltelefoneregisto)
        Me.registosdados.Controls.Add(Me.combotiposerviçosregistos)
        Me.registosdados.Controls.Add(Me.lbltiposervicoregistos)
        Me.registosdados.Controls.Add(Me.lblturmaregistos)
        Me.registosdados.Controls.Add(Me.txtdestinarioregistos)
        Me.registosdados.Controls.Add(Me.lbldestinarioregisto)
        Me.registosdados.Controls.Add(Me.lblqtregistos)
        Me.registosdados.Controls.Add(Me.combocomuniregistos)
        Me.registosdados.Controls.Add(Me.lblvcomunicacaoregistos)
        Me.registosdados.Controls.Add(Me.txthorasregisto)
        Me.registosdados.Controls.Add(Me.lblhoraregistos)
        Me.registosdados.Controls.Add(Me.txtdataregistos)
        Me.registosdados.Controls.Add(Me.lbldataregisto)
        Me.registosdados.Controls.Add(Me.lblanoletivoregisto)
        Me.registosdados.Controls.Add(Me.txtnumregistos)
        Me.registosdados.Controls.Add(Me.Label7)
        Me.registosdados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registosdados.ForeColor = System.Drawing.Color.Blue
        Me.registosdados.Location = New System.Drawing.Point(10, 156)
        Me.registosdados.Margin = New System.Windows.Forms.Padding(2)
        Me.registosdados.Name = "registosdados"
        Me.registosdados.Padding = New System.Windows.Forms.Padding(2)
        Me.registosdados.Size = New System.Drawing.Size(470, 301)
        Me.registosdados.TabIndex = 29
        Me.registosdados.TabStop = False
        Me.registosdados.Text = "Registos de dados"
        '
        'lblObrigatorioComunicacao
        '
        Me.lblObrigatorioComunicacao.AutoSize = True
        Me.lblObrigatorioComunicacao.ForeColor = System.Drawing.Color.Red
        Me.lblObrigatorioComunicacao.Location = New System.Drawing.Point(317, 110)
        Me.lblObrigatorioComunicacao.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObrigatorioComunicacao.Name = "lblObrigatorioComunicacao"
        Me.lblObrigatorioComunicacao.Size = New System.Drawing.Size(74, 13)
        Me.lblObrigatorioComunicacao.TabIndex = 31
        Me.lblObrigatorioComunicacao.Text = "*Obrigatório"
        Me.lblObrigatorioComunicacao.Visible = False
        '
        'lblobrigatorioanolectivoregistos
        '
        Me.lblobrigatorioanolectivoregistos.AutoSize = True
        Me.lblobrigatorioanolectivoregistos.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorioanolectivoregistos.Location = New System.Drawing.Point(317, 168)
        Me.lblobrigatorioanolectivoregistos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblobrigatorioanolectivoregistos.Name = "lblobrigatorioanolectivoregistos"
        Me.lblobrigatorioanolectivoregistos.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorioanolectivoregistos.TabIndex = 30
        Me.lblobrigatorioanolectivoregistos.Text = "*Obrigatório"
        Me.lblobrigatorioanolectivoregistos.Visible = False
        '
        'lblobrigatoriotiposerviçoregistos
        '
        Me.lblobrigatoriotiposerviçoregistos.AutoSize = True
        Me.lblobrigatoriotiposerviçoregistos.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriotiposerviçoregistos.Location = New System.Drawing.Point(317, 219)
        Me.lblobrigatoriotiposerviçoregistos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblobrigatoriotiposerviçoregistos.Name = "lblobrigatoriotiposerviçoregistos"
        Me.lblobrigatoriotiposerviçoregistos.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriotiposerviçoregistos.TabIndex = 29
        Me.lblobrigatoriotiposerviçoregistos.Text = "*Obrigatório"
        Me.lblobrigatoriotiposerviçoregistos.Visible = False
        '
        'lblobrigatorioturmaregistos
        '
        Me.lblobrigatorioturmaregistos.AutoSize = True
        Me.lblobrigatorioturmaregistos.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorioturmaregistos.Location = New System.Drawing.Point(317, 193)
        Me.lblobrigatorioturmaregistos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblobrigatorioturmaregistos.Name = "lblobrigatorioturmaregistos"
        Me.lblobrigatorioturmaregistos.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorioturmaregistos.TabIndex = 28
        Me.lblobrigatorioturmaregistos.Text = "*Obrigatório"
        Me.lblobrigatorioturmaregistos.Visible = False
        '
        'lblobrigatoriodestinatarioregistos
        '
        Me.lblobrigatoriodestinatarioregistos.AutoSize = True
        Me.lblobrigatoriodestinatarioregistos.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriodestinatarioregistos.Location = New System.Drawing.Point(317, 141)
        Me.lblobrigatoriodestinatarioregistos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblobrigatoriodestinatarioregistos.Name = "lblobrigatoriodestinatarioregistos"
        Me.lblobrigatoriodestinatarioregistos.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriodestinatarioregistos.TabIndex = 27
        Me.lblobrigatoriodestinatarioregistos.Text = "*Obrigatório"
        Me.lblobrigatoriodestinatarioregistos.Visible = False
        '
        'combanoletivoregisto
        '
        Me.combanoletivoregisto.FormattingEnabled = True
        Me.combanoletivoregisto.Location = New System.Drawing.Point(114, 161)
        Me.combanoletivoregisto.Margin = New System.Windows.Forms.Padding(2)
        Me.combanoletivoregisto.Name = "combanoletivoregisto"
        Me.combanoletivoregisto.Size = New System.Drawing.Size(88, 21)
        Me.combanoletivoregisto.TabIndex = 26
        '
        'comboturmaregistos
        '
        Me.comboturmaregistos.Enabled = False
        Me.comboturmaregistos.FormattingEnabled = True
        Me.comboturmaregistos.Location = New System.Drawing.Point(115, 190)
        Me.comboturmaregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.comboturmaregistos.Name = "comboturmaregistos"
        Me.comboturmaregistos.Size = New System.Drawing.Size(88, 21)
        Me.comboturmaregistos.TabIndex = 25
        '
        'numdowqtregistos
        '
        Me.numdowqtregistos.Location = New System.Drawing.Point(114, 105)
        Me.numdowqtregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.numdowqtregistos.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.numdowqtregistos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numdowqtregistos.Name = "numdowqtregistos"
        Me.numdowqtregistos.Size = New System.Drawing.Size(33, 20)
        Me.numdowqtregistos.TabIndex = 24
        Me.numdowqtregistos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtobsregistos
        '
        Me.txtobsregistos.Location = New System.Drawing.Point(114, 247)
        Me.txtobsregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtobsregistos.Multiline = True
        Me.txtobsregistos.Name = "txtobsregistos"
        Me.txtobsregistos.Size = New System.Drawing.Size(342, 38)
        Me.txtobsregistos.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(58, 249)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Obs:"
        '
        'mtelemovelregistos
        '
        Me.mtelemovelregistos.Location = New System.Drawing.Point(400, 76)
        Me.mtelemovelregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.mtelemovelregistos.Mask = "000000000"
        Me.mtelemovelregistos.Name = "mtelemovelregistos"
        Me.mtelemovelregistos.Size = New System.Drawing.Size(66, 20)
        Me.mtelemovelregistos.TabIndex = 21
        Me.mtelemovelregistos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'telemovelregistos
        '
        Me.telemovelregistos.AutoSize = True
        Me.telemovelregistos.Location = New System.Drawing.Point(334, 79)
        Me.telemovelregistos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.telemovelregistos.Name = "telemovelregistos"
        Me.telemovelregistos.Size = New System.Drawing.Size(69, 13)
        Me.telemovelregistos.TabIndex = 20
        Me.telemovelregistos.Text = "Telemóvel:"
        '
        'mtelefoneregistos
        '
        Me.mtelefoneregistos.Location = New System.Drawing.Point(265, 76)
        Me.mtelefoneregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.mtelefoneregistos.Mask = "000000000"
        Me.mtelefoneregistos.Name = "mtelefoneregistos"
        Me.mtelefoneregistos.Size = New System.Drawing.Size(68, 20)
        Me.mtelefoneregistos.TabIndex = 19
        Me.mtelefoneregistos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lbltelefoneregisto
        '
        Me.lbltelefoneregisto.AutoSize = True
        Me.lbltelefoneregisto.Location = New System.Drawing.Point(208, 79)
        Me.lbltelefoneregisto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltelefoneregisto.Name = "lbltelefoneregisto"
        Me.lbltelefoneregisto.Size = New System.Drawing.Size(61, 13)
        Me.lbltelefoneregisto.TabIndex = 18
        Me.lbltelefoneregisto.Text = "Telefone:"
        '
        'combotiposerviçosregistos
        '
        Me.combotiposerviçosregistos.FormattingEnabled = True
        Me.combotiposerviçosregistos.Items.AddRange(New Object() {"Direção ", "Director de Curso", "Director de Turma", "Secretaria"})
        Me.combotiposerviçosregistos.Location = New System.Drawing.Point(115, 219)
        Me.combotiposerviçosregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.combotiposerviçosregistos.Name = "combotiposerviçosregistos"
        Me.combotiposerviçosregistos.Size = New System.Drawing.Size(134, 21)
        Me.combotiposerviçosregistos.TabIndex = 17
        '
        'lbltiposervicoregistos
        '
        Me.lbltiposervicoregistos.AutoSize = True
        Me.lbltiposervicoregistos.Location = New System.Drawing.Point(18, 221)
        Me.lbltiposervicoregistos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltiposervicoregistos.Name = "lbltiposervicoregistos"
        Me.lbltiposervicoregistos.Size = New System.Drawing.Size(99, 13)
        Me.lbltiposervicoregistos.TabIndex = 16
        Me.lbltiposervicoregistos.Text = "Tipo de serviço:"
        '
        'lblturmaregistos
        '
        Me.lblturmaregistos.AutoSize = True
        Me.lblturmaregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblturmaregistos.Location = New System.Drawing.Point(58, 193)
        Me.lblturmaregistos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblturmaregistos.Name = "lblturmaregistos"
        Me.lblturmaregistos.Size = New System.Drawing.Size(46, 13)
        Me.lblturmaregistos.TabIndex = 15
        Me.lblturmaregistos.Text = "Turma:"
        '
        'txtdestinarioregistos
        '
        Me.txtdestinarioregistos.Location = New System.Drawing.Point(114, 136)
        Me.txtdestinarioregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdestinarioregistos.Name = "txtdestinarioregistos"
        Me.txtdestinarioregistos.Size = New System.Drawing.Size(192, 20)
        Me.txtdestinarioregistos.TabIndex = 13
        '
        'lbldestinarioregisto
        '
        Me.lbldestinarioregisto.AutoSize = True
        Me.lbldestinarioregisto.ForeColor = System.Drawing.Color.Blue
        Me.lbldestinarioregisto.Location = New System.Drawing.Point(31, 138)
        Me.lbldestinarioregisto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldestinarioregisto.Name = "lbldestinarioregisto"
        Me.lbldestinarioregisto.Size = New System.Drawing.Size(79, 13)
        Me.lbldestinarioregisto.TabIndex = 12
        Me.lbldestinarioregisto.Text = "Destinatário:"
        '
        'lblqtregistos
        '
        Me.lblqtregistos.AutoSize = True
        Me.lblqtregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblqtregistos.Location = New System.Drawing.Point(33, 108)
        Me.lblqtregistos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblqtregistos.Name = "lblqtregistos"
        Me.lblqtregistos.Size = New System.Drawing.Size(76, 13)
        Me.lblqtregistos.TabIndex = 10
        Me.lblqtregistos.Text = "Quantidade:"
        '
        'combocomuniregistos
        '
        Me.combocomuniregistos.FormattingEnabled = True
        Me.combocomuniregistos.Items.AddRange(New Object() {"Email", "Carta", "Carta Registada", "Telefone", "Telemóvel"})
        Me.combocomuniregistos.Location = New System.Drawing.Point(114, 76)
        Me.combocomuniregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.combocomuniregistos.Name = "combocomuniregistos"
        Me.combocomuniregistos.Size = New System.Drawing.Size(88, 21)
        Me.combocomuniregistos.TabIndex = 9
        '
        'lblvcomunicacaoregistos
        '
        Me.lblvcomunicacaoregistos.AutoSize = True
        Me.lblvcomunicacaoregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblvcomunicacaoregistos.Location = New System.Drawing.Point(8, 79)
        Me.lblvcomunicacaoregistos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblvcomunicacaoregistos.Name = "lblvcomunicacaoregistos"
        Me.lblvcomunicacaoregistos.Size = New System.Drawing.Size(109, 13)
        Me.lblvcomunicacaoregistos.TabIndex = 8
        Me.lblvcomunicacaoregistos.Text = "Via Comunicação:"
        '
        'txthorasregisto
        '
        Me.txthorasregisto.Enabled = False
        Me.txthorasregisto.Location = New System.Drawing.Point(265, 48)
        Me.txthorasregisto.Margin = New System.Windows.Forms.Padding(2)
        Me.txthorasregisto.Name = "txthorasregisto"
        Me.txthorasregisto.Size = New System.Drawing.Size(68, 20)
        Me.txthorasregisto.TabIndex = 7
        '
        'lblhoraregistos
        '
        Me.lblhoraregistos.AutoSize = True
        Me.lblhoraregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoraregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblhoraregistos.Location = New System.Drawing.Point(223, 50)
        Me.lblhoraregistos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhoraregistos.Name = "lblhoraregistos"
        Me.lblhoraregistos.Size = New System.Drawing.Size(42, 13)
        Me.lblhoraregistos.TabIndex = 6
        Me.lblhoraregistos.Text = "Hora :"
        '
        'txtdataregistos
        '
        Me.txtdataregistos.Enabled = False
        Me.txtdataregistos.Location = New System.Drawing.Point(114, 48)
        Me.txtdataregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdataregistos.Name = "txtdataregistos"
        Me.txtdataregistos.Size = New System.Drawing.Size(88, 20)
        Me.txtdataregistos.TabIndex = 5
        '
        'lbldataregisto
        '
        Me.lbldataregisto.AutoSize = True
        Me.lbldataregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldataregisto.ForeColor = System.Drawing.Color.Blue
        Me.lbldataregisto.Location = New System.Drawing.Point(55, 50)
        Me.lbldataregisto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldataregisto.Name = "lbldataregisto"
        Me.lbldataregisto.Size = New System.Drawing.Size(42, 13)
        Me.lbldataregisto.TabIndex = 4
        Me.lbldataregisto.Text = "Data :"
        '
        'lblanoletivoregisto
        '
        Me.lblanoletivoregisto.AutoSize = True
        Me.lblanoletivoregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanoletivoregisto.ForeColor = System.Drawing.Color.Blue
        Me.lblanoletivoregisto.Location = New System.Drawing.Point(33, 164)
        Me.lblanoletivoregisto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblanoletivoregisto.Name = "lblanoletivoregisto"
        Me.lblanoletivoregisto.Size = New System.Drawing.Size(79, 13)
        Me.lblanoletivoregisto.TabIndex = 2
        Me.lblanoletivoregisto.Text = "Ano Lectivo:"
        '
        'txtnumregistos
        '
        Me.txtnumregistos.Enabled = False
        Me.txtnumregistos.Location = New System.Drawing.Point(115, 21)
        Me.txtnumregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnumregistos.Name = "txtnumregistos"
        Me.txtnumregistos.Size = New System.Drawing.Size(21, 20)
        Me.txtnumregistos.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(32, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nº Registos:"
        '
        'datagridregistos
        '
        Me.datagridregistos.BackgroundColor = System.Drawing.Color.White
        Me.datagridregistos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridregistos.Location = New System.Drawing.Point(9, 462)
        Me.datagridregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.datagridregistos.Name = "datagridregistos"
        Me.datagridregistos.ReadOnly = True
        Me.datagridregistos.RowHeadersVisible = False
        Me.datagridregistos.Size = New System.Drawing.Size(970, 192)
        Me.datagridregistos.TabIndex = 30
        '
        'Horaregisto
        '
        Me.Horaregisto.Enabled = True
        Me.Horaregisto.Interval = 1000
        '
        'btnconsultaregistos
        '
        Me.btnconsultaregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultaregistos.Location = New System.Drawing.Point(283, -3)
        Me.btnconsultaregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnconsultaregistos.Name = "btnconsultaregistos"
        Me.btnconsultaregistos.Size = New System.Drawing.Size(65, 23)
        Me.btnconsultaregistos.TabIndex = 31
        Me.btnconsultaregistos.Text = "Consultar"
        Me.btnconsultaregistos.UseVisualStyleBackColor = True
        '
        'Registo_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(988, 634)
        Me.Controls.Add(Me.btnconsultaregistos)
        Me.Controls.Add(Me.datagridregistos)
        Me.Controls.Add(Me.registosdados)
        Me.Controls.Add(Me.grouputilizadorhorario)
        Me.Controls.Add(Me.groupesquisa)
        Me.Controls.Add(Me.btncancelarregisto)
        Me.Controls.Add(Me.btnsairregisto)
        Me.Controls.Add(Me.btnguardarregisto)
        Me.Controls.Add(Me.btneliminarregisto)
        Me.Controls.Add(Me.btneditarregisto)
        Me.Controls.Add(Me.btnovoregisto)
        Me.Controls.Add(Me.menuhorario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.menuhorario
        Me.Name = "Registo_new"
        Me.Text = " "
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grouputilizadorhorario.ResumeLayout(False)
        Me.grouputilizadorhorario.PerformLayout()
        CType(Me.datutilizadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupesquisa.ResumeLayout(False)
        Me.groupesquisa.PerformLayout()
        Me.registosdados.ResumeLayout(False)
        Me.registosdados.PerformLayout()
        CType(Me.numdowqtregistos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridregistos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuhorario As MenuStrip
    Friend WithEvents btnovoregisto As Button
    Friend WithEvents btneditarregisto As Button
    Friend WithEvents btneliminarregisto As Button
    Friend WithEvents btnguardarregisto As Button
    Friend WithEvents btnsairregisto As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btncancelarregisto As System.Windows.Forms.Button
    Friend WithEvents grouputilizadorhorario As System.Windows.Forms.GroupBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtFuncao As System.Windows.Forms.TextBox
    Friend WithEvents txtnomeutilizador As System.Windows.Forms.TextBox
    Friend WithEvents txtnumutilizador As System.Windows.Forms.TextBox
    Friend WithEvents lblnomeutilizadorhorario As System.Windows.Forms.Label
    Friend WithEvents lblcategoriaoutilizadorhorario As System.Windows.Forms.Label
    Friend WithEvents lblfuncaoutilizadorhorario As System.Windows.Forms.Label
    Friend WithEvents lblnumhorario As System.Windows.Forms.Label
    Friend WithEvents datutilizadores As System.Windows.Forms.DataGridView
    Friend WithEvents groupesquisa As System.Windows.Forms.GroupBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents combonome As System.Windows.Forms.ComboBox
    Friend WithEvents combocategoriapesquisa As System.Windows.Forms.ComboBox
    Friend WithEvents combofuncaopesquisa As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents registosdados As System.Windows.Forms.GroupBox
    Friend WithEvents lblobrigatorioanolectivoregistos As System.Windows.Forms.Label
    Friend WithEvents lblobrigatoriotiposerviçoregistos As System.Windows.Forms.Label
    Friend WithEvents lblobrigatorioturmaregistos As System.Windows.Forms.Label
    Friend WithEvents lblobrigatoriodestinatarioregistos As System.Windows.Forms.Label
    Friend WithEvents combanoletivoregisto As System.Windows.Forms.ComboBox
    Friend WithEvents comboturmaregistos As System.Windows.Forms.ComboBox
    Friend WithEvents numdowqtregistos As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtobsregistos As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mtelemovelregistos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents telemovelregistos As System.Windows.Forms.Label
    Friend WithEvents mtelefoneregistos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbltelefoneregisto As System.Windows.Forms.Label
    Friend WithEvents combotiposerviçosregistos As System.Windows.Forms.ComboBox
    Friend WithEvents lbltiposervicoregistos As System.Windows.Forms.Label
    Friend WithEvents lblturmaregistos As System.Windows.Forms.Label
    Friend WithEvents txtdestinarioregistos As System.Windows.Forms.TextBox
    Friend WithEvents lbldestinarioregisto As System.Windows.Forms.Label
    Friend WithEvents lblqtregistos As System.Windows.Forms.Label
    Friend WithEvents combocomuniregistos As System.Windows.Forms.ComboBox
    Friend WithEvents lblvcomunicacaoregistos As System.Windows.Forms.Label
    Friend WithEvents txthorasregisto As System.Windows.Forms.TextBox
    Friend WithEvents lblhoraregistos As System.Windows.Forms.Label
    Friend WithEvents txtdataregistos As System.Windows.Forms.TextBox
    Friend WithEvents lbldataregisto As System.Windows.Forms.Label
    Friend WithEvents lblanoletivoregisto As System.Windows.Forms.Label
    Friend WithEvents txtnumregistos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents datagridregistos As System.Windows.Forms.DataGridView
    Friend WithEvents Horaregisto As System.Windows.Forms.Timer
    Friend WithEvents btnconsultaregistos As System.Windows.Forms.Button
    Friend WithEvents lblObrigatorioComunicacao As System.Windows.Forms.Label
End Class
