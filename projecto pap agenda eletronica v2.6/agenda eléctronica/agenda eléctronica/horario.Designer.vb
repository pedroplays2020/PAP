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
        Me.btnpesquisarhorario = New System.Windows.Forms.Button()
        Me.btnconsultarhorario = New System.Windows.Forms.Button()
        Me.btnsairhorario = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.combocategoriapesquisa = New System.Windows.Forms.ComboBox()
        Me.combofuncaopesquisa = New System.Windows.Forms.ComboBox()
        Me.txtnomepesquisa = New System.Windows.Forms.TextBox()
        Me.txtnumpesquisa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnumhorario = New System.Windows.Forms.Label()
        Me.groupesquisahorario = New System.Windows.Forms.GroupBox()
        Me.datagridlistahorario = New System.Windows.Forms.DataGridView()
        Me.datagridhorario = New System.Windows.Forms.DataGridView()
        Me.btncancelarhorario = New System.Windows.Forms.Button()
        Me.lblnumutilizadorpesquisahorario = New System.Windows.Forms.Label()
        Me.txtnumhorario = New System.Windows.Forms.TextBox()
        Me.grouphorario = New System.Windows.Forms.GroupBox()
        Me.combodiashorario = New System.Windows.Forms.ComboBox()
        Me.lblobrigatoriodiashorario = New System.Windows.Forms.Label()
        Me.lblbdaisemana = New System.Windows.Forms.Label()
        Me.combohorashorario = New System.Windows.Forms.ComboBox()
        Me.lblobrigatoriohorashorario = New System.Windows.Forms.Label()
        Me.lbltempohorario = New System.Windows.Forms.Label()
        Me.lblobrigatoriosalahorario = New System.Windows.Forms.Label()
        Me.lblsalahorario = New System.Windows.Forms.Label()
        Me.lblobrigatoriodisciplina = New System.Windows.Forms.Label()
        Me.lbldisciplinahorario = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lblareahorario = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBloco = New System.Windows.Forms.ComboBox()
        Me.lblBlocoObrigatorio = New System.Windows.Forms.Label()
        Me.lblBloco = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupesquisahorario.SuspendLayout()
        CType(Me.datagridlistahorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridhorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grouphorario.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuhorario
        '
        Me.menuhorario.Location = New System.Drawing.Point(0, 0)
        Me.menuhorario.Name = "menuhorario"
        Me.menuhorario.Size = New System.Drawing.Size(1208, 24)
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
        'btnpesquisarhorario
        '
        Me.btnpesquisarhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpesquisarhorario.Location = New System.Drawing.Point(281, 0)
        Me.btnpesquisarhorario.Name = "btnpesquisarhorario"
        Me.btnpesquisarhorario.Size = New System.Drawing.Size(75, 23)
        Me.btnpesquisarhorario.TabIndex = 17
        Me.btnpesquisarhorario.Text = "Pesquisar"
        Me.btnpesquisarhorario.UseVisualStyleBackColor = True
        '
        'btnconsultarhorario
        '
        Me.btnconsultarhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultarhorario.Location = New System.Drawing.Point(354, 0)
        Me.btnconsultarhorario.Name = "btnconsultarhorario"
        Me.btnconsultarhorario.Size = New System.Drawing.Size(75, 23)
        Me.btnconsultarhorario.TabIndex = 18
        Me.btnconsultarhorario.Text = "Consultar"
        Me.btnconsultarhorario.UseVisualStyleBackColor = True
        '
        'btnsairhorario
        '
        Me.btnsairhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairhorario.Location = New System.Drawing.Point(499, 0)
        Me.btnsairhorario.Name = "btnsairhorario"
        Me.btnsairhorario.Size = New System.Drawing.Size(75, 23)
        Me.btnsairhorario.TabIndex = 19
        Me.btnsairhorario.Text = "Sair"
        Me.btnsairhorario.UseVisualStyleBackColor = True
        '
        'combocategoriapesquisa
        '
        Me.combocategoriapesquisa.FormattingEnabled = True
        Me.combocategoriapesquisa.Location = New System.Drawing.Point(74, 98)
        Me.combocategoriapesquisa.Name = "combocategoriapesquisa"
        Me.combocategoriapesquisa.Size = New System.Drawing.Size(95, 21)
        Me.combocategoriapesquisa.TabIndex = 23
        '
        'combofuncaopesquisa
        '
        Me.combofuncaopesquisa.FormattingEnabled = True
        Me.combofuncaopesquisa.Location = New System.Drawing.Point(74, 68)
        Me.combofuncaopesquisa.Name = "combofuncaopesquisa"
        Me.combofuncaopesquisa.Size = New System.Drawing.Size(95, 21)
        Me.combofuncaopesquisa.TabIndex = 22
        '
        'txtnomepesquisa
        '
        Me.txtnomepesquisa.Location = New System.Drawing.Point(74, 40)
        Me.txtnomepesquisa.Name = "txtnomepesquisa"
        Me.txtnomepesquisa.Size = New System.Drawing.Size(95, 20)
        Me.txtnomepesquisa.TabIndex = 4
        '
        'txtnumpesquisa
        '
        Me.txtnumpesquisa.Location = New System.Drawing.Point(75, 16)
        Me.txtnumpesquisa.Name = "txtnumpesquisa"
        Me.txtnumpesquisa.Size = New System.Drawing.Size(32, 20)
        Me.txtnumpesquisa.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(28, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Categoria:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(18, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Função:"
        '
        'lblnumhorario
        '
        Me.lblnumhorario.AutoSize = True
        Me.lblnumhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblnumhorario.Location = New System.Drawing.Point(46, 19)
        Me.lblnumhorario.Name = "lblnumhorario"
        Me.lblnumhorario.Size = New System.Drawing.Size(25, 13)
        Me.lblnumhorario.TabIndex = 0
        Me.lblnumhorario.Text = "Nº:"
        '
        'groupesquisahorario
        '
        Me.groupesquisahorario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.groupesquisahorario.Controls.Add(Me.datagridlistahorario)
        Me.groupesquisahorario.Controls.Add(Me.combocategoriapesquisa)
        Me.groupesquisahorario.Controls.Add(Me.combofuncaopesquisa)
        Me.groupesquisahorario.Controls.Add(Me.txtnomepesquisa)
        Me.groupesquisahorario.Controls.Add(Me.txtnumpesquisa)
        Me.groupesquisahorario.Controls.Add(Me.Label1)
        Me.groupesquisahorario.Controls.Add(Me.Label2)
        Me.groupesquisahorario.Controls.Add(Me.Label3)
        Me.groupesquisahorario.Controls.Add(Me.lblnumhorario)
        Me.groupesquisahorario.Location = New System.Drawing.Point(12, 29)
        Me.groupesquisahorario.Name = "groupesquisahorario"
        Me.groupesquisahorario.Size = New System.Drawing.Size(369, 208)
        Me.groupesquisahorario.TabIndex = 23
        Me.groupesquisahorario.TabStop = False
        Me.groupesquisahorario.Text = "Pesquisa"
        '
        'datagridlistahorario
        '
        Me.datagridlistahorario.BackgroundColor = System.Drawing.Color.White
        Me.datagridlistahorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridlistahorario.Location = New System.Drawing.Point(196, 21)
        Me.datagridlistahorario.Name = "datagridlistahorario"
        Me.datagridlistahorario.Size = New System.Drawing.Size(162, 170)
        Me.datagridlistahorario.TabIndex = 24
        '
        'datagridhorario
        '
        Me.datagridhorario.BackgroundColor = System.Drawing.Color.White
        Me.datagridhorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridhorario.Location = New System.Drawing.Point(411, 29)
        Me.datagridhorario.Name = "datagridhorario"
        Me.datagridhorario.Size = New System.Drawing.Size(770, 470)
        Me.datagridhorario.TabIndex = 24
        '
        'btncancelarhorario
        '
        Me.btncancelarhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarhorario.Location = New System.Drawing.Point(426, 0)
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
        Me.lblnumutilizadorpesquisahorario.Location = New System.Drawing.Point(51, 19)
        Me.lblnumutilizadorpesquisahorario.Name = "lblnumutilizadorpesquisahorario"
        Me.lblnumutilizadorpesquisahorario.Size = New System.Drawing.Size(25, 13)
        Me.lblnumutilizadorpesquisahorario.TabIndex = 0
        Me.lblnumutilizadorpesquisahorario.Text = "Nº:"
        '
        'txtnumhorario
        '
        Me.txtnumhorario.Location = New System.Drawing.Point(75, 16)
        Me.txtnumhorario.Name = "txtnumhorario"
        Me.txtnumhorario.Size = New System.Drawing.Size(32, 20)
        Me.txtnumhorario.TabIndex = 3
        '
        'grouphorario
        '
        Me.grouphorario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grouphorario.Controls.Add(Me.cmbBloco)
        Me.grouphorario.Controls.Add(Me.lblBlocoObrigatorio)
        Me.grouphorario.Controls.Add(Me.lblBloco)
        Me.grouphorario.Controls.Add(Me.Label4)
        Me.grouphorario.Controls.Add(Me.ComboBox3)
        Me.grouphorario.Controls.Add(Me.lblareahorario)
        Me.grouphorario.Controls.Add(Me.ComboBox2)
        Me.grouphorario.Controls.Add(Me.ComboBox1)
        Me.grouphorario.Controls.Add(Me.combodiashorario)
        Me.grouphorario.Controls.Add(Me.lblobrigatoriodiashorario)
        Me.grouphorario.Controls.Add(Me.lblbdaisemana)
        Me.grouphorario.Controls.Add(Me.combohorashorario)
        Me.grouphorario.Controls.Add(Me.lblobrigatoriohorashorario)
        Me.grouphorario.Controls.Add(Me.lbltempohorario)
        Me.grouphorario.Controls.Add(Me.lblobrigatoriosalahorario)
        Me.grouphorario.Controls.Add(Me.lblsalahorario)
        Me.grouphorario.Controls.Add(Me.lblobrigatoriodisciplina)
        Me.grouphorario.Controls.Add(Me.lbldisciplinahorario)
        Me.grouphorario.Controls.Add(Me.txtnumhorario)
        Me.grouphorario.Controls.Add(Me.lblnumutilizadorpesquisahorario)
        Me.grouphorario.Location = New System.Drawing.Point(12, 254)
        Me.grouphorario.Name = "grouphorario"
        Me.grouphorario.Size = New System.Drawing.Size(369, 208)
        Me.grouphorario.TabIndex = 21
        Me.grouphorario.TabStop = False
        Me.grouphorario.Text = "Horário"
        '
        'combodiashorario
        '
        Me.combodiashorario.FormattingEnabled = True
        Me.combodiashorario.Location = New System.Drawing.Point(73, 154)
        Me.combodiashorario.Name = "combodiashorario"
        Me.combodiashorario.Size = New System.Drawing.Size(95, 21)
        Me.combodiashorario.TabIndex = 39
        '
        'lblobrigatoriodiashorario
        '
        Me.lblobrigatoriodiashorario.AutoSize = True
        Me.lblobrigatoriodiashorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriodiashorario.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriodiashorario.Location = New System.Drawing.Point(175, 157)
        Me.lblobrigatoriodiashorario.Name = "lblobrigatoriodiashorario"
        Me.lblobrigatoriodiashorario.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriodiashorario.TabIndex = 38
        Me.lblobrigatoriodiashorario.Text = "*Obrigatório"
        '
        'lblbdaisemana
        '
        Me.lblbdaisemana.AutoSize = True
        Me.lblbdaisemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbdaisemana.ForeColor = System.Drawing.Color.Blue
        Me.lblbdaisemana.Location = New System.Drawing.Point(32, 157)
        Me.lblbdaisemana.Name = "lblbdaisemana"
        Me.lblbdaisemana.Size = New System.Drawing.Size(36, 13)
        Me.lblbdaisemana.TabIndex = 37
        Me.lblbdaisemana.Text = "Dias:"
        '
        'combohorashorario
        '
        Me.combohorashorario.FormattingEnabled = True
        Me.combohorashorario.Location = New System.Drawing.Point(73, 184)
        Me.combohorashorario.Name = "combohorashorario"
        Me.combohorashorario.Size = New System.Drawing.Size(95, 21)
        Me.combohorashorario.TabIndex = 36
        '
        'lblobrigatoriohorashorario
        '
        Me.lblobrigatoriohorashorario.AutoSize = True
        Me.lblobrigatoriohorashorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriohorashorario.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriohorashorario.Location = New System.Drawing.Point(175, 187)
        Me.lblobrigatoriohorashorario.Name = "lblobrigatoriohorashorario"
        Me.lblobrigatoriohorashorario.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriohorashorario.TabIndex = 35
        Me.lblobrigatoriohorashorario.Text = "*Obrigatório"
        '
        'lbltempohorario
        '
        Me.lbltempohorario.AutoSize = True
        Me.lbltempohorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltempohorario.ForeColor = System.Drawing.Color.Blue
        Me.lbltempohorario.Location = New System.Drawing.Point(24, 187)
        Me.lbltempohorario.Name = "lbltempohorario"
        Me.lbltempohorario.Size = New System.Drawing.Size(44, 13)
        Me.lbltempohorario.TabIndex = 33
        Me.lbltempohorario.Text = "Horas:"
        '
        'lblobrigatoriosalahorario
        '
        Me.lblobrigatoriosalahorario.AutoSize = True
        Me.lblobrigatoriosalahorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriosalahorario.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriosalahorario.Location = New System.Drawing.Point(175, 130)
        Me.lblobrigatoriosalahorario.Name = "lblobrigatoriosalahorario"
        Me.lblobrigatoriosalahorario.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriosalahorario.TabIndex = 32
        Me.lblobrigatoriosalahorario.Text = "*Obrigatório"
        '
        'lblsalahorario
        '
        Me.lblsalahorario.AutoSize = True
        Me.lblsalahorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalahorario.ForeColor = System.Drawing.Color.Blue
        Me.lblsalahorario.Location = New System.Drawing.Point(32, 130)
        Me.lblsalahorario.Name = "lblsalahorario"
        Me.lblsalahorario.Size = New System.Drawing.Size(36, 13)
        Me.lblsalahorario.TabIndex = 30
        Me.lblsalahorario.Text = "Sala:"
        '
        'lblobrigatoriodisciplina
        '
        Me.lblobrigatoriodisciplina.AutoSize = True
        Me.lblobrigatoriodisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriodisciplina.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriodisciplina.Location = New System.Drawing.Point(175, 74)
        Me.lblobrigatoriodisciplina.Name = "lblobrigatoriodisciplina"
        Me.lblobrigatoriodisciplina.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriodisciplina.TabIndex = 29
        Me.lblobrigatoriodisciplina.Text = "*Obrigatório"
        '
        'lbldisciplinahorario
        '
        Me.lbldisciplinahorario.AutoSize = True
        Me.lbldisciplinahorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisciplinahorario.ForeColor = System.Drawing.Color.Blue
        Me.lbldisciplinahorario.Location = New System.Drawing.Point(2, 74)
        Me.lbldisciplinahorario.Name = "lbldisciplinahorario"
        Me.lbldisciplinahorario.Size = New System.Drawing.Size(66, 13)
        Me.lbldisciplinahorario.TabIndex = 27
        Me.lbldisciplinahorario.Text = "Disciplina:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(74, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox1.TabIndex = 40
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(74, 127)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox2.TabIndex = 41
        '
        'lblareahorario
        '
        Me.lblareahorario.AutoSize = True
        Me.lblareahorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblareahorario.ForeColor = System.Drawing.Color.Blue
        Me.lblareahorario.Location = New System.Drawing.Point(31, 47)
        Me.lblareahorario.Name = "lblareahorario"
        Me.lblareahorario.Size = New System.Drawing.Size(37, 13)
        Me.lblareahorario.TabIndex = 42
        Me.lblareahorario.Text = "Área:"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(74, 44)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox3.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(175, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "*Obrigatório"
        '
        'cmbBloco
        '
        Me.cmbBloco.FormattingEnabled = True
        Me.cmbBloco.Location = New System.Drawing.Point(73, 99)
        Me.cmbBloco.Name = "cmbBloco"
        Me.cmbBloco.Size = New System.Drawing.Size(94, 21)
        Me.cmbBloco.TabIndex = 47
        '
        'lblBlocoObrigatorio
        '
        Me.lblBlocoObrigatorio.AutoSize = True
        Me.lblBlocoObrigatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlocoObrigatorio.ForeColor = System.Drawing.Color.Red
        Me.lblBlocoObrigatorio.Location = New System.Drawing.Point(174, 102)
        Me.lblBlocoObrigatorio.Name = "lblBlocoObrigatorio"
        Me.lblBlocoObrigatorio.Size = New System.Drawing.Size(74, 13)
        Me.lblBlocoObrigatorio.TabIndex = 46
        Me.lblBlocoObrigatorio.Text = "*Obrigatório"
        '
        'lblBloco
        '
        Me.lblBloco.AutoSize = True
        Me.lblBloco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBloco.ForeColor = System.Drawing.Color.Blue
        Me.lblBloco.Location = New System.Drawing.Point(31, 102)
        Me.lblBloco.Name = "lblBloco"
        Me.lblBloco.Size = New System.Drawing.Size(43, 13)
        Me.lblBloco.TabIndex = 45
        Me.lblBloco.Text = "Bloco:"
        '
        'horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1208, 500)
        Me.Controls.Add(Me.btncancelarhorario)
        Me.Controls.Add(Me.datagridhorario)
        Me.Controls.Add(Me.groupesquisahorario)
        Me.Controls.Add(Me.grouphorario)
        Me.Controls.Add(Me.btnsairhorario)
        Me.Controls.Add(Me.btnconsultarhorario)
        Me.Controls.Add(Me.btnpesquisarhorario)
        Me.Controls.Add(Me.btnguardarhorario)
        Me.Controls.Add(Me.btneliminarhorario)
        Me.Controls.Add(Me.btneditarhorario)
        Me.Controls.Add(Me.btnovohorario)
        Me.Controls.Add(Me.menuhorario)
        Me.IsMdiContainer = true
        Me.MainMenuStrip = Me.menuhorario
        Me.Name = "horario"
        Me.Text = " "
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupesquisahorario.ResumeLayout(false)
        Me.groupesquisahorario.PerformLayout
        CType(Me.datagridlistahorario,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.datagridhorario,System.ComponentModel.ISupportInitialize).EndInit
        Me.grouphorario.ResumeLayout(false)
        Me.grouphorario.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents menuhorario As MenuStrip
    Friend WithEvents btnovohorario As Button
    Friend WithEvents btneditarhorario As Button
    Friend WithEvents btneliminarhorario As Button
    Friend WithEvents btnguardarhorario As Button
    Friend WithEvents btnpesquisarhorario As Button
    Friend WithEvents btnconsultarhorario As Button
    Friend WithEvents btnsairhorario As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents combocategoriapesquisa As ComboBox
    Friend WithEvents combofuncaopesquisa As ComboBox
    Friend WithEvents txtnomepesquisa As TextBox
    Friend WithEvents txtnumpesquisa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblnumhorario As Label
    Friend WithEvents groupesquisahorario As GroupBox
    Friend WithEvents datagridlistahorario As DataGridView
    Friend WithEvents datagridhorario As DataGridView
    Friend WithEvents btncancelarhorario As System.Windows.Forms.Button
    Friend WithEvents lblnumutilizadorpesquisahorario As System.Windows.Forms.Label
    Friend WithEvents txtnumhorario As System.Windows.Forms.TextBox
    Friend WithEvents grouphorario As System.Windows.Forms.GroupBox
    Friend WithEvents lblobrigatoriodisciplina As System.Windows.Forms.Label
    Friend WithEvents lbldisciplinahorario As System.Windows.Forms.Label
    Friend WithEvents lblobrigatoriosalahorario As System.Windows.Forms.Label
    Friend WithEvents lblsalahorario As System.Windows.Forms.Label
    Friend WithEvents lblobrigatoriohorashorario As System.Windows.Forms.Label
    Friend WithEvents lbltempohorario As System.Windows.Forms.Label
    Friend WithEvents combohorashorario As System.Windows.Forms.ComboBox
    Friend WithEvents lblobrigatoriodiashorario As System.Windows.Forms.Label
    Friend WithEvents lblbdaisemana As System.Windows.Forms.Label
    Friend WithEvents combodiashorario As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents lblareahorario As System.Windows.Forms.Label
    Friend WithEvents cmbBloco As System.Windows.Forms.ComboBox
    Friend WithEvents lblBlocoObrigatorio As System.Windows.Forms.Label
    Friend WithEvents lblBloco As System.Windows.Forms.Label
End Class
