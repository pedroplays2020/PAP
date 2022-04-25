<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class horario
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
        Me.btnovohorario = New System.Windows.Forms.Button()
        Me.btneditarhorario = New System.Windows.Forms.Button()
        Me.btneliminarhorario = New System.Windows.Forms.Button()
        Me.btnguardarhorario = New System.Windows.Forms.Button()
        Me.btnsairhorario = New System.Windows.Forms.Button()
        Me.txtnomeutilizadorhorario = New System.Windows.Forms.TextBox()
        Me.txtnumutilizadohorario = New System.Windows.Forms.TextBox()
        Me.lblnomeutilizadorhorario = New System.Windows.Forms.Label()
        Me.lblcategoriaoutilizadorhorario = New System.Windows.Forms.Label()
        Me.lblfuncaoutilizadorhorario = New System.Windows.Forms.Label()
        Me.lblnumhorario = New System.Windows.Forms.Label()
        Me.grouputilizadorhorario = New System.Windows.Forms.GroupBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtFuncao = New System.Windows.Forms.TextBox()
        Me.datagridhorario = New System.Windows.Forms.DataGridView()
        Me.btncancelarhorario = New System.Windows.Forms.Button()
        Me.lblnumutilizadorpesquisahorario = New System.Windows.Forms.Label()
        Me.txtnumhorario = New System.Windows.Forms.TextBox()
        Me.grouphorario = New System.Windows.Forms.GroupBox()
        Me.gbMSG = New System.Windows.Forms.GroupBox()
        Me.lblmsgutilizador = New System.Windows.Forms.Label()
        Me.comboblocohorario = New System.Windows.Forms.ComboBox()
        Me.lblobrigatoriobloco = New System.Windows.Forms.Label()
        Me.lblBloco = New System.Windows.Forms.Label()
        Me.lblobrigatorioarea = New System.Windows.Forms.Label()
        Me.combareahorario = New System.Windows.Forms.ComboBox()
        Me.lblareahorario = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.groupesquisa = New System.Windows.Forms.GroupBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.combonomehorario = New System.Windows.Forms.ComboBox()
        Me.dathorario = New System.Windows.Forms.DataGridView()
        Me.combocategoriapesquisa = New System.Windows.Forms.ComboBox()
        Me.combofuncaopesquisa = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.btnconsultaregistos = New System.Windows.Forms.Button()
        Me.grouputilizadorhorario.SuspendLayout()
        CType(Me.datagridhorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grouphorario.SuspendLayout()
        Me.gbMSG.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupesquisa.SuspendLayout()
        CType(Me.dathorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuhorario
        '
        Me.menuhorario.Location = New System.Drawing.Point(0, 0)
        Me.menuhorario.Name = "menuhorario"
        Me.menuhorario.Size = New System.Drawing.Size(946, 24)
        Me.menuhorario.TabIndex = 0
        Me.menuhorario.Text = "menuhorario"
        '
        'btnovohorario
        '
        Me.btnovohorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnovohorario.Location = New System.Drawing.Point(0, 0)
        Me.btnovohorario.Name = "btnovohorario"
        Me.btnovohorario.Size = New System.Drawing.Size(75, 23)
        Me.btnovohorario.TabIndex = 13
        Me.btnovohorario.Text = "Novo"
        Me.btnovohorario.UseVisualStyleBackColor = True
        '
        'btneditarhorario
        '
        Me.btneditarhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarhorario.Location = New System.Drawing.Point(66, 0)
        Me.btneditarhorario.Name = "btneditarhorario"
        Me.btneditarhorario.Size = New System.Drawing.Size(75, 23)
        Me.btneditarhorario.TabIndex = 14
        Me.btneditarhorario.Text = "Editar"
        Me.btneditarhorario.UseVisualStyleBackColor = True
        '
        'btneliminarhorario
        '
        Me.btneliminarhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarhorario.Location = New System.Drawing.Point(139, 0)
        Me.btneliminarhorario.Name = "btneliminarhorario"
        Me.btneliminarhorario.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarhorario.TabIndex = 15
        Me.btneliminarhorario.Text = "Eliminar"
        Me.btneliminarhorario.UseVisualStyleBackColor = True
        '
        'btnguardarhorario
        '
        Me.btnguardarhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarhorario.Location = New System.Drawing.Point(209, 0)
        Me.btnguardarhorario.Name = "btnguardarhorario"
        Me.btnguardarhorario.Size = New System.Drawing.Size(75, 23)
        Me.btnguardarhorario.TabIndex = 16
        Me.btnguardarhorario.Text = "Guardar"
        Me.btnguardarhorario.UseVisualStyleBackColor = True
        '
        'btnsairhorario
        '
        Me.btnsairhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairhorario.Location = New System.Drawing.Point(418, 0)
        Me.btnsairhorario.Name = "btnsairhorario"
        Me.btnsairhorario.Size = New System.Drawing.Size(75, 23)
        Me.btnsairhorario.TabIndex = 19
        Me.btnsairhorario.Text = "Sair"
        Me.btnsairhorario.UseVisualStyleBackColor = True
        '
        'txtnomeutilizadorhorario
        '
        Me.txtnomeutilizadorhorario.Location = New System.Drawing.Point(62, 40)
        Me.txtnomeutilizadorhorario.Name = "txtnomeutilizadorhorario"
        Me.txtnomeutilizadorhorario.Size = New System.Drawing.Size(289, 20)
        Me.txtnomeutilizadorhorario.TabIndex = 4
        '
        'txtnumutilizadohorario
        '
        Me.txtnumutilizadohorario.Location = New System.Drawing.Point(63, 16)
        Me.txtnumutilizadohorario.Name = "txtnumutilizadohorario"
        Me.txtnumutilizadohorario.Size = New System.Drawing.Size(32, 20)
        Me.txtnumutilizadohorario.TabIndex = 3
        '
        'lblnomeutilizadorhorario
        '
        Me.lblnomeutilizadorhorario.AutoSize = True
        Me.lblnomeutilizadorhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeutilizadorhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblnomeutilizadorhorario.Location = New System.Drawing.Point(16, 43)
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
        Me.lblcategoriaoutilizadorhorario.Location = New System.Drawing.Point(182, 71)
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
        Me.lblfuncaoutilizadorhorario.Location = New System.Drawing.Point(6, 71)
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
        Me.lblnumhorario.Location = New System.Drawing.Point(34, 19)
        Me.lblnumhorario.Name = "lblnumhorario"
        Me.lblnumhorario.Size = New System.Drawing.Size(25, 13)
        Me.lblnumhorario.TabIndex = 0
        Me.lblnumhorario.Text = "Nº:"
        '
        'grouputilizadorhorario
        '
        Me.grouputilizadorhorario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grouputilizadorhorario.Controls.Add(Me.txtUser)
        Me.grouputilizadorhorario.Controls.Add(Me.lblUser)
        Me.grouputilizadorhorario.Controls.Add(Me.txtCategoria)
        Me.grouputilizadorhorario.Controls.Add(Me.txtFuncao)
        Me.grouputilizadorhorario.Controls.Add(Me.txtnomeutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.txtnumutilizadohorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblnomeutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblcategoriaoutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblfuncaoutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblnumhorario)
        Me.grouputilizadorhorario.Location = New System.Drawing.Point(12, 29)
        Me.grouputilizadorhorario.Name = "grouputilizadorhorario"
        Me.grouputilizadorhorario.Size = New System.Drawing.Size(369, 106)
        Me.grouputilizadorhorario.TabIndex = 23
        Me.grouputilizadorhorario.TabStop = False
        Me.grouputilizadorhorario.Text = "Dados do Utilizador"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(250, 12)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 8
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Blue
        Me.lblUser.Location = New System.Drawing.Point(180, 16)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(64, 13)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "Utilizador:"
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(250, 68)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoria.TabIndex = 6
        '
        'txtFuncao
        '
        Me.txtFuncao.Location = New System.Drawing.Point(62, 67)
        Me.txtFuncao.Name = "txtFuncao"
        Me.txtFuncao.Size = New System.Drawing.Size(100, 20)
        Me.txtFuncao.TabIndex = 5
        '
        'datagridhorario
        '
        Me.datagridhorario.AllowUserToAddRows = False
        Me.datagridhorario.AllowUserToResizeColumns = False
        Me.datagridhorario.AllowUserToResizeRows = False
        Me.datagridhorario.BackgroundColor = System.Drawing.Color.White
        Me.datagridhorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridhorario.Location = New System.Drawing.Point(10, 310)
        Me.datagridhorario.Name = "datagridhorario"
        Me.datagridhorario.RowHeadersVisible = False
        Me.datagridhorario.Size = New System.Drawing.Size(927, 262)
        Me.datagridhorario.TabIndex = 24
        '
        'btncancelarhorario
        '
        Me.btncancelarhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarhorario.Location = New System.Drawing.Point(346, 0)
        Me.btncancelarhorario.Name = "btncancelarhorario"
        Me.btncancelarhorario.Size = New System.Drawing.Size(75, 23)
        Me.btncancelarhorario.TabIndex = 26
        Me.btncancelarhorario.Text = "Cancelar"
        Me.btncancelarhorario.UseVisualStyleBackColor = True
        '
        'lblnumutilizadorpesquisahorario
        '
        Me.lblnumutilizadorpesquisahorario.AutoSize = True
        Me.lblnumutilizadorpesquisahorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumutilizadorpesquisahorario.ForeColor = System.Drawing.Color.Blue
        Me.lblnumutilizadorpesquisahorario.Location = New System.Drawing.Point(32, 19)
        Me.lblnumutilizadorpesquisahorario.Name = "lblnumutilizadorpesquisahorario"
        Me.lblnumutilizadorpesquisahorario.Size = New System.Drawing.Size(25, 13)
        Me.lblnumutilizadorpesquisahorario.TabIndex = 0
        Me.lblnumutilizadorpesquisahorario.Text = "Nº:"
        '
        'txtnumhorario
        '
        Me.txtnumhorario.Location = New System.Drawing.Point(65, 12)
        Me.txtnumhorario.Name = "txtnumhorario"
        Me.txtnumhorario.Size = New System.Drawing.Size(32, 20)
        Me.txtnumhorario.TabIndex = 3
        '
        'grouphorario
        '
        Me.grouphorario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grouphorario.Controls.Add(Me.gbMSG)
        Me.grouphorario.Controls.Add(Me.comboblocohorario)
        Me.grouphorario.Controls.Add(Me.lblobrigatoriobloco)
        Me.grouphorario.Controls.Add(Me.lblBloco)
        Me.grouphorario.Controls.Add(Me.lblobrigatorioarea)
        Me.grouphorario.Controls.Add(Me.combareahorario)
        Me.grouphorario.Controls.Add(Me.lblareahorario)
        Me.grouphorario.Controls.Add(Me.txtnumhorario)
        Me.grouphorario.Controls.Add(Me.lblnumutilizadorpesquisahorario)
        Me.grouphorario.Location = New System.Drawing.Point(12, 141)
        Me.grouphorario.Name = "grouphorario"
        Me.grouphorario.Size = New System.Drawing.Size(369, 94)
        Me.grouphorario.TabIndex = 21
        Me.grouphorario.TabStop = False
        Me.grouphorario.Text = "Horário"
        '
        'gbMSG
        '
        Me.gbMSG.Controls.Add(Me.lblmsgutilizador)
        Me.gbMSG.Location = New System.Drawing.Point(2, 103)
        Me.gbMSG.Name = "gbMSG"
        Me.gbMSG.Size = New System.Drawing.Size(368, 58)
        Me.gbMSG.TabIndex = 94
        Me.gbMSG.TabStop = False
        Me.gbMSG.Text = "Mensagem"
        Me.gbMSG.Visible = False
        '
        'lblmsgutilizador
        '
        Me.lblmsgutilizador.AutoSize = True
        Me.lblmsgutilizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsgutilizador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmsgutilizador.Location = New System.Drawing.Point(10, 25)
        Me.lblmsgutilizador.Name = "lblmsgutilizador"
        Me.lblmsgutilizador.Size = New System.Drawing.Size(45, 13)
        Me.lblmsgutilizador.TabIndex = 0
        Me.lblmsgutilizador.Text = "Label2"
        '
        'comboblocohorario
        '
        Me.comboblocohorario.FormattingEnabled = True
        Me.comboblocohorario.Location = New System.Drawing.Point(64, 64)
        Me.comboblocohorario.Name = "comboblocohorario"
        Me.comboblocohorario.Size = New System.Drawing.Size(94, 21)
        Me.comboblocohorario.TabIndex = 47
        '
        'lblobrigatoriobloco
        '
        Me.lblobrigatoriobloco.AutoSize = True
        Me.lblobrigatoriobloco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriobloco.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriobloco.Location = New System.Drawing.Point(174, 64)
        Me.lblobrigatoriobloco.Name = "lblobrigatoriobloco"
        Me.lblobrigatoriobloco.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriobloco.TabIndex = 46
        Me.lblobrigatoriobloco.Text = "*Obrigatório"
        '
        'lblBloco
        '
        Me.lblBloco.AutoSize = True
        Me.lblBloco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBloco.ForeColor = System.Drawing.Color.Blue
        Me.lblBloco.Location = New System.Drawing.Point(16, 67)
        Me.lblBloco.Name = "lblBloco"
        Me.lblBloco.Size = New System.Drawing.Size(43, 13)
        Me.lblBloco.TabIndex = 45
        Me.lblBloco.Text = "Bloco:"
        '
        'lblobrigatorioarea
        '
        Me.lblobrigatorioarea.AutoSize = True
        Me.lblobrigatorioarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorioarea.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorioarea.Location = New System.Drawing.Point(174, 40)
        Me.lblobrigatorioarea.Name = "lblobrigatorioarea"
        Me.lblobrigatorioarea.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorioarea.TabIndex = 44
        Me.lblobrigatorioarea.Text = "*Obrigatório"
        '
        'combareahorario
        '
        Me.combareahorario.FormattingEnabled = True
        Me.combareahorario.Location = New System.Drawing.Point(65, 38)
        Me.combareahorario.Name = "combareahorario"
        Me.combareahorario.Size = New System.Drawing.Size(94, 21)
        Me.combareahorario.TabIndex = 43
        '
        'lblareahorario
        '
        Me.lblareahorario.AutoSize = True
        Me.lblareahorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblareahorario.ForeColor = System.Drawing.Color.Blue
        Me.lblareahorario.Location = New System.Drawing.Point(22, 41)
        Me.lblareahorario.Name = "lblareahorario"
        Me.lblareahorario.Size = New System.Drawing.Size(37, 13)
        Me.lblareahorario.TabIndex = 42
        Me.lblareahorario.Text = "Área:"
        '
        'groupesquisa
        '
        Me.groupesquisa.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.groupesquisa.Controls.Add(Me.btnLimpar)
        Me.groupesquisa.Controls.Add(Me.combonomehorario)
        Me.groupesquisa.Controls.Add(Me.dathorario)
        Me.groupesquisa.Controls.Add(Me.combocategoriapesquisa)
        Me.groupesquisa.Controls.Add(Me.combofuncaopesquisa)
        Me.groupesquisa.Controls.Add(Me.Label4)
        Me.groupesquisa.Controls.Add(Me.lbl)
        Me.groupesquisa.Controls.Add(Me.Label6)
        Me.groupesquisa.Location = New System.Drawing.Point(397, 29)
        Me.groupesquisa.Name = "groupesquisa"
        Me.groupesquisa.Size = New System.Drawing.Size(540, 273)
        Me.groupesquisa.TabIndex = 25
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
        'combonomehorario
        '
        Me.combonomehorario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.combonomehorario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combonomehorario.FormattingEnabled = True
        Me.combonomehorario.Location = New System.Drawing.Point(69, 19)
        Me.combonomehorario.Name = "combonomehorario"
        Me.combonomehorario.Size = New System.Drawing.Size(400, 21)
        Me.combonomehorario.TabIndex = 25
        '
        'dathorario
        '
        Me.dathorario.AllowUserToAddRows = False
        Me.dathorario.AllowUserToDeleteRows = False
        Me.dathorario.AllowUserToResizeColumns = False
        Me.dathorario.AllowUserToResizeRows = False
        Me.dathorario.BackgroundColor = System.Drawing.Color.White
        Me.dathorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dathorario.Location = New System.Drawing.Point(10, 87)
        Me.dathorario.Name = "dathorario"
        Me.dathorario.ReadOnly = True
        Me.dathorario.RowHeadersVisible = False
        Me.dathorario.Size = New System.Drawing.Size(524, 180)
        Me.dathorario.TabIndex = 24
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
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(10, 15)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(353, 36)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "Label2"
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.lblInfo)
        Me.gbInfo.Location = New System.Drawing.Point(12, 245)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(369, 58)
        Me.gbInfo.TabIndex = 94
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Mensagem"
        Me.gbInfo.Visible = False
        '
        'btnconsultaregistos
        '
        Me.btnconsultaregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultaregistos.Location = New System.Drawing.Point(283, 0)
        Me.btnconsultaregistos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnconsultaregistos.Name = "btnconsultaregistos"
        Me.btnconsultaregistos.Size = New System.Drawing.Size(65, 23)
        Me.btnconsultaregistos.TabIndex = 32
        Me.btnconsultaregistos.Text = "Consultar"
        Me.btnconsultaregistos.UseVisualStyleBackColor = True
        '
        'horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(946, 583)
        Me.Controls.Add(Me.btnconsultaregistos)
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.groupesquisa)
        Me.Controls.Add(Me.btncancelarhorario)
        Me.Controls.Add(Me.datagridhorario)
        Me.Controls.Add(Me.grouputilizadorhorario)
        Me.Controls.Add(Me.grouphorario)
        Me.Controls.Add(Me.btnsairhorario)
        Me.Controls.Add(Me.btnguardarhorario)
        Me.Controls.Add(Me.btneliminarhorario)
        Me.Controls.Add(Me.btneditarhorario)
        Me.Controls.Add(Me.btnovohorario)
        Me.Controls.Add(Me.menuhorario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.menuhorario
        Me.Name = "horario"
        Me.Text = " "
        Me.grouputilizadorhorario.ResumeLayout(False)
        Me.grouputilizadorhorario.PerformLayout()
        CType(Me.datagridhorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grouphorario.ResumeLayout(False)
        Me.grouphorario.PerformLayout()
        Me.gbMSG.ResumeLayout(False)
        Me.gbMSG.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupesquisa.ResumeLayout(False)
        Me.groupesquisa.PerformLayout()
        CType(Me.dathorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuhorario As MenuStrip
    Friend WithEvents btnovohorario As Button
    Friend WithEvents btneditarhorario As Button
    Friend WithEvents btneliminarhorario As Button
    Friend WithEvents btnguardarhorario As Button
    Friend WithEvents btnsairhorario As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtnomeutilizadorhorario As TextBox
    Friend WithEvents txtnumutilizadohorario As TextBox
    Friend WithEvents lblnomeutilizadorhorario As Label
    Friend WithEvents lblcategoriaoutilizadorhorario As Label
    Friend WithEvents lblfuncaoutilizadorhorario As Label
    Friend WithEvents lblnumhorario As Label
    Friend WithEvents grouputilizadorhorario As GroupBox
    Friend WithEvents datagridhorario As DataGridView
    Friend WithEvents btncancelarhorario As System.Windows.Forms.Button
    Friend WithEvents lblnumutilizadorpesquisahorario As System.Windows.Forms.Label
    Friend WithEvents txtnumhorario As System.Windows.Forms.TextBox
    Friend WithEvents grouphorario As System.Windows.Forms.GroupBox
    Friend WithEvents lblobrigatorioarea As System.Windows.Forms.Label
    Friend WithEvents combareahorario As System.Windows.Forms.ComboBox
    Friend WithEvents lblareahorario As System.Windows.Forms.Label
    Friend WithEvents comboblocohorario As System.Windows.Forms.ComboBox
    Friend WithEvents lblobrigatoriobloco As System.Windows.Forms.Label
    Friend WithEvents lblBloco As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtFuncao As System.Windows.Forms.TextBox
    Friend WithEvents groupesquisa As System.Windows.Forms.GroupBox
    Friend WithEvents combonomehorario As System.Windows.Forms.ComboBox
    Friend WithEvents dathorario As System.Windows.Forms.DataGridView
    Friend WithEvents combocategoriapesquisa As System.Windows.Forms.ComboBox
    Friend WithEvents combofuncaopesquisa As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents gbMSG As System.Windows.Forms.GroupBox
    Friend WithEvents lblmsgutilizador As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnconsultaregistos As System.Windows.Forms.Button
End Class
