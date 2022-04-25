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
        Me.menuhorario.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.menuhorario.Size = New System.Drawing.Size(1317, 24)
        Me.menuhorario.TabIndex = 0
        Me.menuhorario.Text = "menuhorario"
        '
        'btnovoregisto
        '
        Me.btnovoregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnovoregisto.Location = New System.Drawing.Point(0, -4)
        Me.btnovoregisto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnovoregisto.Name = "btnovoregisto"
        Me.btnovoregisto.Size = New System.Drawing.Size(100, 28)
        Me.btnovoregisto.TabIndex = 13
        Me.btnovoregisto.Text = "Novo"
        Me.btnovoregisto.UseVisualStyleBackColor = True
        '
        'btneditarregisto
        '
        Me.btneditarregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarregisto.Location = New System.Drawing.Point(88, -4)
        Me.btneditarregisto.Margin = New System.Windows.Forms.Padding(4)
        Me.btneditarregisto.Name = "btneditarregisto"
        Me.btneditarregisto.Size = New System.Drawing.Size(100, 28)
        Me.btneditarregisto.TabIndex = 14
        Me.btneditarregisto.Text = "Editar"
        Me.btneditarregisto.UseVisualStyleBackColor = True
        '
        'btneliminarregisto
        '
        Me.btneliminarregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarregisto.Location = New System.Drawing.Point(185, -4)
        Me.btneliminarregisto.Margin = New System.Windows.Forms.Padding(4)
        Me.btneliminarregisto.Name = "btneliminarregisto"
        Me.btneliminarregisto.Size = New System.Drawing.Size(100, 28)
        Me.btneliminarregisto.TabIndex = 15
        Me.btneliminarregisto.Text = "Eliminar"
        Me.btneliminarregisto.UseVisualStyleBackColor = True
        '
        'btnguardarregisto
        '
        Me.btnguardarregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarregisto.Location = New System.Drawing.Point(279, -4)
        Me.btnguardarregisto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguardarregisto.Name = "btnguardarregisto"
        Me.btnguardarregisto.Size = New System.Drawing.Size(100, 28)
        Me.btnguardarregisto.TabIndex = 16
        Me.btnguardarregisto.Text = "Guardar"
        Me.btnguardarregisto.UseVisualStyleBackColor = True
        '
        'btnsairregisto
        '
        Me.btnsairregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairregisto.Location = New System.Drawing.Point(559, -4)
        Me.btnsairregisto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsairregisto.Name = "btnsairregisto"
        Me.btnsairregisto.Size = New System.Drawing.Size(100, 28)
        Me.btnsairregisto.TabIndex = 19
        Me.btnsairregisto.Text = "Sair"
        Me.btnsairregisto.UseVisualStyleBackColor = True
        '
        'btncancelarregisto
        '
        Me.btncancelarregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarregisto.Location = New System.Drawing.Point(461, -4)
        Me.btncancelarregisto.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancelarregisto.Name = "btncancelarregisto"
        Me.btncancelarregisto.Size = New System.Drawing.Size(100, 28)
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
        Me.grouputilizadorhorario.Location = New System.Drawing.Point(13, 46)
        Me.grouputilizadorhorario.Margin = New System.Windows.Forms.Padding(4)
        Me.grouputilizadorhorario.Name = "grouputilizadorhorario"
        Me.grouputilizadorhorario.Padding = New System.Windows.Forms.Padding(4)
        Me.grouputilizadorhorario.Size = New System.Drawing.Size(627, 130)
        Me.grouputilizadorhorario.TabIndex = 27
        Me.grouputilizadorhorario.TabStop = False
        Me.grouputilizadorhorario.Text = "Dados do Utilizador"
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(405, 18)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(132, 22)
        Me.txtUser.TabIndex = 8
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Blue
        Me.lblUser.Location = New System.Drawing.Point(313, 25)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(82, 17)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "Utilizador:"
        '
        'txtCategoria
        '
        Me.txtCategoria.Enabled = False
        Me.txtCategoria.Location = New System.Drawing.Point(405, 89)
        Me.txtCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(132, 22)
        Me.txtCategoria.TabIndex = 6
        '
        'txtFuncao
        '
        Me.txtFuncao.Enabled = False
        Me.txtFuncao.Location = New System.Drawing.Point(156, 86)
        Me.txtFuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFuncao.Name = "txtFuncao"
        Me.txtFuncao.Size = New System.Drawing.Size(132, 22)
        Me.txtFuncao.TabIndex = 5
        '
        'txtnomeutilizador
        '
        Me.txtnomeutilizador.Enabled = False
        Me.txtnomeutilizador.Location = New System.Drawing.Point(156, 53)
        Me.txtnomeutilizador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnomeutilizador.Name = "txtnomeutilizador"
        Me.txtnomeutilizador.Size = New System.Drawing.Size(384, 22)
        Me.txtnomeutilizador.TabIndex = 4
        '
        'txtnumutilizador
        '
        Me.txtnumutilizador.Enabled = False
        Me.txtnumutilizador.Location = New System.Drawing.Point(157, 25)
        Me.txtnumutilizador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumutilizador.Name = "txtnumutilizador"
        Me.txtnumutilizador.Size = New System.Drawing.Size(41, 22)
        Me.txtnumutilizador.TabIndex = 3
        '
        'lblnomeutilizadorhorario
        '
        Me.lblnomeutilizadorhorario.AutoSize = True
        Me.lblnomeutilizadorhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeutilizadorhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblnomeutilizadorhorario.Location = New System.Drawing.Point(93, 57)
        Me.lblnomeutilizadorhorario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnomeutilizadorhorario.Name = "lblnomeutilizadorhorario"
        Me.lblnomeutilizadorhorario.Size = New System.Drawing.Size(54, 17)
        Me.lblnomeutilizadorhorario.TabIndex = 1
        Me.lblnomeutilizadorhorario.Text = "Nome:"
        '
        'lblcategoriaoutilizadorhorario
        '
        Me.lblcategoriaoutilizadorhorario.AutoSize = True
        Me.lblcategoriaoutilizadorhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategoriaoutilizadorhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblcategoriaoutilizadorhorario.Location = New System.Drawing.Point(316, 91)
        Me.lblcategoriaoutilizadorhorario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcategoriaoutilizadorhorario.Name = "lblcategoriaoutilizadorhorario"
        Me.lblcategoriaoutilizadorhorario.Size = New System.Drawing.Size(83, 17)
        Me.lblcategoriaoutilizadorhorario.TabIndex = 2
        Me.lblcategoriaoutilizadorhorario.Text = "Categoria:"
        '
        'lblfuncaoutilizadorhorario
        '
        Me.lblfuncaoutilizadorhorario.AutoSize = True
        Me.lblfuncaoutilizadorhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuncaoutilizadorhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblfuncaoutilizadorhorario.Location = New System.Drawing.Point(81, 91)
        Me.lblfuncaoutilizadorhorario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfuncaoutilizadorhorario.Name = "lblfuncaoutilizadorhorario"
        Me.lblfuncaoutilizadorhorario.Size = New System.Drawing.Size(66, 17)
        Me.lblfuncaoutilizadorhorario.TabIndex = 1
        Me.lblfuncaoutilizadorhorario.Text = "Função:"
        '
        'lblnumhorario
        '
        Me.lblnumhorario.AutoSize = True
        Me.lblnumhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblnumhorario.Location = New System.Drawing.Point(117, 27)
        Me.lblnumhorario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnumhorario.Name = "lblnumhorario"
        Me.lblnumhorario.Size = New System.Drawing.Size(30, 17)
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
        Me.datutilizadores.Location = New System.Drawing.Point(20, 98)
        Me.datutilizadores.Margin = New System.Windows.Forms.Padding(4)
        Me.datutilizadores.Name = "datutilizadores"
        Me.datutilizadores.ReadOnly = True
        Me.datutilizadores.RowHeadersVisible = False
        Me.datutilizadores.Size = New System.Drawing.Size(604, 395)
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
        Me.groupesquisa.Location = New System.Drawing.Point(664, 49)
        Me.groupesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.groupesquisa.Name = "groupesquisa"
        Me.groupesquisa.Padding = New System.Windows.Forms.Padding(4)
        Me.groupesquisa.Size = New System.Drawing.Size(641, 514)
        Me.groupesquisa.TabIndex = 28
        Me.groupesquisa.TabStop = False
        Me.groupesquisa.Text = "Pesquisa"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(524, 62)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(100, 28)
        Me.btnLimpar.TabIndex = 26
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'combonome
        '
        Me.combonome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.combonome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combonome.FormattingEnabled = True
        Me.combonome.Location = New System.Drawing.Point(92, 23)
        Me.combonome.Margin = New System.Windows.Forms.Padding(4)
        Me.combonome.Name = "combonome"
        Me.combonome.Size = New System.Drawing.Size(532, 24)
        Me.combonome.TabIndex = 25
        '
        'combocategoriapesquisa
        '
        Me.combocategoriapesquisa.FormattingEnabled = True
        Me.combocategoriapesquisa.Location = New System.Drawing.Point(329, 62)
        Me.combocategoriapesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.combocategoriapesquisa.Name = "combocategoriapesquisa"
        Me.combocategoriapesquisa.Size = New System.Drawing.Size(125, 24)
        Me.combocategoriapesquisa.TabIndex = 23
        '
        'combofuncaopesquisa
        '
        Me.combofuncaopesquisa.FormattingEnabled = True
        Me.combofuncaopesquisa.Location = New System.Drawing.Point(92, 60)
        Me.combofuncaopesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.combofuncaopesquisa.Name = "combofuncaopesquisa"
        Me.combofuncaopesquisa.Size = New System.Drawing.Size(125, 24)
        Me.combofuncaopesquisa.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(31, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nome:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Blue
        Me.lbl.Location = New System.Drawing.Point(237, 65)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(83, 17)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "Categoria:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(17, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
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
        Me.registosdados.Location = New System.Drawing.Point(13, 192)
        Me.registosdados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.registosdados.Name = "registosdados"
        Me.registosdados.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.registosdados.Size = New System.Drawing.Size(627, 370)
        Me.registosdados.TabIndex = 29
        Me.registosdados.TabStop = False
        Me.registosdados.Text = "Registos de dados"
        '
        'lblObrigatorioComunicacao
        '
        Me.lblObrigatorioComunicacao.AutoSize = True
        Me.lblObrigatorioComunicacao.ForeColor = System.Drawing.Color.Red
        Me.lblObrigatorioComunicacao.Location = New System.Drawing.Point(423, 135)
        Me.lblObrigatorioComunicacao.Name = "lblObrigatorioComunicacao"
        Me.lblObrigatorioComunicacao.Size = New System.Drawing.Size(96, 17)
        Me.lblObrigatorioComunicacao.TabIndex = 31
        Me.lblObrigatorioComunicacao.Text = "*Obrigatório"
        Me.lblObrigatorioComunicacao.Visible = False
        '
        'lblobrigatorioanolectivoregistos
        '
        Me.lblobrigatorioanolectivoregistos.AutoSize = True
        Me.lblobrigatorioanolectivoregistos.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorioanolectivoregistos.Location = New System.Drawing.Point(423, 207)
        Me.lblobrigatorioanolectivoregistos.Name = "lblobrigatorioanolectivoregistos"
        Me.lblobrigatorioanolectivoregistos.Size = New System.Drawing.Size(96, 17)
        Me.lblobrigatorioanolectivoregistos.TabIndex = 30
        Me.lblobrigatorioanolectivoregistos.Text = "*Obrigatório"
        Me.lblobrigatorioanolectivoregistos.Visible = False
        '
        'lblobrigatoriotiposerviçoregistos
        '
        Me.lblobrigatoriotiposerviçoregistos.AutoSize = True
        Me.lblobrigatoriotiposerviçoregistos.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriotiposerviçoregistos.Location = New System.Drawing.Point(423, 270)
        Me.lblobrigatoriotiposerviçoregistos.Name = "lblobrigatoriotiposerviçoregistos"
        Me.lblobrigatoriotiposerviçoregistos.Size = New System.Drawing.Size(96, 17)
        Me.lblobrigatoriotiposerviçoregistos.TabIndex = 29
        Me.lblobrigatoriotiposerviçoregistos.Text = "*Obrigatório"
        Me.lblobrigatoriotiposerviçoregistos.Visible = False
        '
        'lblobrigatorioturmaregistos
        '
        Me.lblobrigatorioturmaregistos.AutoSize = True
        Me.lblobrigatorioturmaregistos.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorioturmaregistos.Location = New System.Drawing.Point(423, 238)
        Me.lblobrigatorioturmaregistos.Name = "lblobrigatorioturmaregistos"
        Me.lblobrigatorioturmaregistos.Size = New System.Drawing.Size(96, 17)
        Me.lblobrigatorioturmaregistos.TabIndex = 28
        Me.lblobrigatorioturmaregistos.Text = "*Obrigatório"
        Me.lblobrigatorioturmaregistos.Visible = False
        '
        'lblobrigatoriodestinatarioregistos
        '
        Me.lblobrigatoriodestinatarioregistos.AutoSize = True
        Me.lblobrigatoriodestinatarioregistos.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriodestinatarioregistos.Location = New System.Drawing.Point(423, 174)
        Me.lblobrigatoriodestinatarioregistos.Name = "lblobrigatoriodestinatarioregistos"
        Me.lblobrigatoriodestinatarioregistos.Size = New System.Drawing.Size(96, 17)
        Me.lblobrigatoriodestinatarioregistos.TabIndex = 27
        Me.lblobrigatoriodestinatarioregistos.Text = "*Obrigatório"
        Me.lblobrigatoriodestinatarioregistos.Visible = False
        '
        'combanoletivoregisto
        '
        Me.combanoletivoregisto.FormattingEnabled = True
        Me.combanoletivoregisto.Location = New System.Drawing.Point(152, 198)
        Me.combanoletivoregisto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.combanoletivoregisto.Name = "combanoletivoregisto"
        Me.combanoletivoregisto.Size = New System.Drawing.Size(116, 25)
        Me.combanoletivoregisto.TabIndex = 26
        '
        'comboturmaregistos
        '
        Me.comboturmaregistos.Enabled = False
        Me.comboturmaregistos.FormattingEnabled = True
        Me.comboturmaregistos.Location = New System.Drawing.Point(153, 234)
        Me.comboturmaregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comboturmaregistos.Name = "comboturmaregistos"
        Me.comboturmaregistos.Size = New System.Drawing.Size(116, 25)
        Me.comboturmaregistos.TabIndex = 25
        '
        'numdowqtregistos
        '
        Me.numdowqtregistos.Location = New System.Drawing.Point(152, 129)
        Me.numdowqtregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numdowqtregistos.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.numdowqtregistos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numdowqtregistos.Name = "numdowqtregistos"
        Me.numdowqtregistos.Size = New System.Drawing.Size(44, 23)
        Me.numdowqtregistos.TabIndex = 24
        Me.numdowqtregistos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtobsregistos
        '
        Me.txtobsregistos.Location = New System.Drawing.Point(152, 304)
        Me.txtobsregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtobsregistos.Multiline = True
        Me.txtobsregistos.Name = "txtobsregistos"
        Me.txtobsregistos.Size = New System.Drawing.Size(455, 46)
        Me.txtobsregistos.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(77, 306)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Obs:"
        '
        'mtelemovelregistos
        '
        Me.mtelemovelregistos.Location = New System.Drawing.Point(533, 94)
        Me.mtelemovelregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtelemovelregistos.Mask = "000000000"
        Me.mtelemovelregistos.Name = "mtelemovelregistos"
        Me.mtelemovelregistos.Size = New System.Drawing.Size(87, 23)
        Me.mtelemovelregistos.TabIndex = 21
        Me.mtelemovelregistos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'telemovelregistos
        '
        Me.telemovelregistos.AutoSize = True
        Me.telemovelregistos.Location = New System.Drawing.Point(445, 97)
        Me.telemovelregistos.Name = "telemovelregistos"
        Me.telemovelregistos.Size = New System.Drawing.Size(87, 17)
        Me.telemovelregistos.TabIndex = 20
        Me.telemovelregistos.Text = "Telemóvel:"
        '
        'mtelefoneregistos
        '
        Me.mtelefoneregistos.Location = New System.Drawing.Point(353, 94)
        Me.mtelefoneregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtelefoneregistos.Mask = "000000000"
        Me.mtelefoneregistos.Name = "mtelefoneregistos"
        Me.mtelefoneregistos.Size = New System.Drawing.Size(89, 23)
        Me.mtelefoneregistos.TabIndex = 19
        Me.mtelefoneregistos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lbltelefoneregisto
        '
        Me.lbltelefoneregisto.AutoSize = True
        Me.lbltelefoneregisto.Location = New System.Drawing.Point(277, 97)
        Me.lbltelefoneregisto.Name = "lbltelefoneregisto"
        Me.lbltelefoneregisto.Size = New System.Drawing.Size(77, 17)
        Me.lbltelefoneregisto.TabIndex = 18
        Me.lbltelefoneregisto.Text = "Telefone:"
        '
        'combotiposerviçosregistos
        '
        Me.combotiposerviçosregistos.FormattingEnabled = True
        Me.combotiposerviçosregistos.Items.AddRange(New Object() {"Direção ", "Director de Curso", "Director de Turma", "Secretaria"})
        Me.combotiposerviçosregistos.Location = New System.Drawing.Point(153, 270)
        Me.combotiposerviçosregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.combotiposerviçosregistos.Name = "combotiposerviçosregistos"
        Me.combotiposerviçosregistos.Size = New System.Drawing.Size(177, 25)
        Me.combotiposerviçosregistos.TabIndex = 17
        '
        'lbltiposervicoregistos
        '
        Me.lbltiposervicoregistos.AutoSize = True
        Me.lbltiposervicoregistos.Location = New System.Drawing.Point(24, 272)
        Me.lbltiposervicoregistos.Name = "lbltiposervicoregistos"
        Me.lbltiposervicoregistos.Size = New System.Drawing.Size(125, 17)
        Me.lbltiposervicoregistos.TabIndex = 16
        Me.lbltiposervicoregistos.Text = "Tipo de serviço:"
        '
        'lblturmaregistos
        '
        Me.lblturmaregistos.AutoSize = True
        Me.lblturmaregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblturmaregistos.Location = New System.Drawing.Point(77, 238)
        Me.lblturmaregistos.Name = "lblturmaregistos"
        Me.lblturmaregistos.Size = New System.Drawing.Size(59, 17)
        Me.lblturmaregistos.TabIndex = 15
        Me.lblturmaregistos.Text = "Turma:"
        '
        'txtdestinarioregistos
        '
        Me.txtdestinarioregistos.Location = New System.Drawing.Point(152, 167)
        Me.txtdestinarioregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdestinarioregistos.Name = "txtdestinarioregistos"
        Me.txtdestinarioregistos.Size = New System.Drawing.Size(255, 23)
        Me.txtdestinarioregistos.TabIndex = 13
        '
        'lbldestinarioregisto
        '
        Me.lbldestinarioregisto.AutoSize = True
        Me.lbldestinarioregisto.ForeColor = System.Drawing.Color.Blue
        Me.lbldestinarioregisto.Location = New System.Drawing.Point(41, 170)
        Me.lbldestinarioregisto.Name = "lbldestinarioregisto"
        Me.lbldestinarioregisto.Size = New System.Drawing.Size(101, 17)
        Me.lbldestinarioregisto.TabIndex = 12
        Me.lbldestinarioregisto.Text = "Destinatário:"
        '
        'lblqtregistos
        '
        Me.lblqtregistos.AutoSize = True
        Me.lblqtregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblqtregistos.Location = New System.Drawing.Point(44, 133)
        Me.lblqtregistos.Name = "lblqtregistos"
        Me.lblqtregistos.Size = New System.Drawing.Size(97, 17)
        Me.lblqtregistos.TabIndex = 10
        Me.lblqtregistos.Text = "Quantidade:"
        '
        'combocomuniregistos
        '
        Me.combocomuniregistos.FormattingEnabled = True
        Me.combocomuniregistos.Items.AddRange(New Object() {"Email", "Carta", "Carta Registada", "Telefone", "Telemóvel"})
        Me.combocomuniregistos.Location = New System.Drawing.Point(152, 94)
        Me.combocomuniregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.combocomuniregistos.Name = "combocomuniregistos"
        Me.combocomuniregistos.Size = New System.Drawing.Size(116, 25)
        Me.combocomuniregistos.TabIndex = 9
        '
        'lblvcomunicacaoregistos
        '
        Me.lblvcomunicacaoregistos.AutoSize = True
        Me.lblvcomunicacaoregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblvcomunicacaoregistos.Location = New System.Drawing.Point(11, 97)
        Me.lblvcomunicacaoregistos.Name = "lblvcomunicacaoregistos"
        Me.lblvcomunicacaoregistos.Size = New System.Drawing.Size(137, 17)
        Me.lblvcomunicacaoregistos.TabIndex = 8
        Me.lblvcomunicacaoregistos.Text = "Via Comunicação:"
        '
        'txthorasregisto
        '
        Me.txthorasregisto.Enabled = False
        Me.txthorasregisto.Location = New System.Drawing.Point(353, 59)
        Me.txthorasregisto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txthorasregisto.Name = "txthorasregisto"
        Me.txthorasregisto.Size = New System.Drawing.Size(89, 23)
        Me.txthorasregisto.TabIndex = 7
        '
        'lblhoraregistos
        '
        Me.lblhoraregistos.AutoSize = True
        Me.lblhoraregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoraregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblhoraregistos.Location = New System.Drawing.Point(297, 62)
        Me.lblhoraregistos.Name = "lblhoraregistos"
        Me.lblhoraregistos.Size = New System.Drawing.Size(53, 17)
        Me.lblhoraregistos.TabIndex = 6
        Me.lblhoraregistos.Text = "Hora :"
        '
        'txtdataregistos
        '
        Me.txtdataregistos.Enabled = False
        Me.txtdataregistos.Location = New System.Drawing.Point(152, 59)
        Me.txtdataregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdataregistos.Name = "txtdataregistos"
        Me.txtdataregistos.Size = New System.Drawing.Size(116, 23)
        Me.txtdataregistos.TabIndex = 5
        '
        'lbldataregisto
        '
        Me.lbldataregisto.AutoSize = True
        Me.lbldataregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldataregisto.ForeColor = System.Drawing.Color.Blue
        Me.lbldataregisto.Location = New System.Drawing.Point(73, 62)
        Me.lbldataregisto.Name = "lbldataregisto"
        Me.lbldataregisto.Size = New System.Drawing.Size(52, 17)
        Me.lbldataregisto.TabIndex = 4
        Me.lbldataregisto.Text = "Data :"
        '
        'lblanoletivoregisto
        '
        Me.lblanoletivoregisto.AutoSize = True
        Me.lblanoletivoregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanoletivoregisto.ForeColor = System.Drawing.Color.Blue
        Me.lblanoletivoregisto.Location = New System.Drawing.Point(44, 202)
        Me.lblanoletivoregisto.Name = "lblanoletivoregisto"
        Me.lblanoletivoregisto.Size = New System.Drawing.Size(98, 17)
        Me.lblanoletivoregisto.TabIndex = 2
        Me.lblanoletivoregisto.Text = "Ano Lectivo:"
        '
        'txtnumregistos
        '
        Me.txtnumregistos.Enabled = False
        Me.txtnumregistos.Location = New System.Drawing.Point(153, 26)
        Me.txtnumregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnumregistos.Name = "txtnumregistos"
        Me.txtnumregistos.Size = New System.Drawing.Size(27, 23)
        Me.txtnumregistos.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(43, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nº Registos:"
        '
        'datagridregistos
        '
        Me.datagridregistos.BackgroundColor = System.Drawing.Color.White
        Me.datagridregistos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridregistos.Location = New System.Drawing.Point(12, 569)
        Me.datagridregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datagridregistos.Name = "datagridregistos"
        Me.datagridregistos.ReadOnly = True
        Me.datagridregistos.RowHeadersVisible = False
        Me.datagridregistos.Size = New System.Drawing.Size(1293, 236)
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
        Me.btnconsultaregistos.Location = New System.Drawing.Point(377, -4)
        Me.btnconsultaregistos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnconsultaregistos.Name = "btnconsultaregistos"
        Me.btnconsultaregistos.Size = New System.Drawing.Size(87, 28)
        Me.btnconsultaregistos.TabIndex = 31
        Me.btnconsultaregistos.Text = "Consultar"
        Me.btnconsultaregistos.UseVisualStyleBackColor = True
        '
        'Registo_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1317, 780)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
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
