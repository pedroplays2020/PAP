<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblutilizadorregistos = New System.Windows.Forms.Label()
        Me.txtnutilizadoregistos = New System.Windows.Forms.TextBox()
        Me.lblnomeutilizadorregistos = New System.Windows.Forms.Label()
        Me.combocategoriaregistos = New System.Windows.Forms.ComboBox()
        Me.lblfunçãoregistos = New System.Windows.Forms.Label()
        Me.categoriaregistos = New System.Windows.Forms.Label()
        Me.combofunçaoregistos = New System.Windows.Forms.ComboBox()
        Me.dadosdoutilizador = New System.Windows.Forms.GroupBox()
        Me.combonomeregistos = New System.Windows.Forms.ComboBox()
        Me.lblobrigatoriocatregistos = New System.Windows.Forms.Label()
        Me.lblobrigatoriofuncregisto = New System.Windows.Forms.Label()
        Me.lblobrigatorionomeregisto = New System.Windows.Forms.Label()
        Me.datagridregistos = New System.Windows.Forms.DataGridView()
        Me.menuregistos = New System.Windows.Forms.MenuStrip()
        Me.btnnovoregisto = New System.Windows.Forms.Button()
        Me.btneditaregisto = New System.Windows.Forms.Button()
        Me.btneliminaregisto = New System.Windows.Forms.Button()
        Me.btnguardaregisto = New System.Windows.Forms.Button()
        Me.btnconsultaregistos = New System.Windows.Forms.Button()
        Me.btnsairegisto = New System.Windows.Forms.Button()
        Me.btncancelaregisto = New System.Windows.Forms.Button()
        Me.registosdados = New System.Windows.Forms.GroupBox()
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
        Me.Horaregisto = New System.Windows.Forms.Timer(Me.components)
        Me.dadosdoutilizador.SuspendLayout()
        CType(Me.datagridregistos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.registosdados.SuspendLayout()
        CType(Me.numdowqtregistos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblutilizadorregistos
        '
        Me.lblutilizadorregistos.AutoSize = True
        Me.lblutilizadorregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblutilizadorregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblutilizadorregistos.Location = New System.Drawing.Point(18, 28)
        Me.lblutilizadorregistos.Name = "lblutilizadorregistos"
        Me.lblutilizadorregistos.Size = New System.Drawing.Size(102, 13)
        Me.lblutilizadorregistos.TabIndex = 0
        Me.lblutilizadorregistos.Text = "Nº de utilizador :"
        '
        'txtnutilizadoregistos
        '
        Me.txtnutilizadoregistos.Location = New System.Drawing.Point(122, 25)
        Me.txtnutilizadoregistos.Name = "txtnutilizadoregistos"
        Me.txtnutilizadoregistos.Size = New System.Drawing.Size(22, 20)
        Me.txtnutilizadoregistos.TabIndex = 1
        '
        'lblnomeutilizadorregistos
        '
        Me.lblnomeutilizadorregistos.AutoSize = True
        Me.lblnomeutilizadorregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeutilizadorregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblnomeutilizadorregistos.Location = New System.Drawing.Point(77, 57)
        Me.lblnomeutilizadorregistos.Name = "lblnomeutilizadorregistos"
        Me.lblnomeutilizadorregistos.Size = New System.Drawing.Size(43, 13)
        Me.lblnomeutilizadorregistos.TabIndex = 2
        Me.lblnomeutilizadorregistos.Text = "Nome:"
        '
        'combocategoriaregistos
        '
        Me.combocategoriaregistos.FormattingEnabled = True
        Me.combocategoriaregistos.Location = New System.Drawing.Point(122, 108)
        Me.combocategoriaregistos.Name = "combocategoriaregistos"
        Me.combocategoriaregistos.Size = New System.Drawing.Size(140, 21)
        Me.combocategoriaregistos.TabIndex = 4
        '
        'lblfunçãoregistos
        '
        Me.lblfunçãoregistos.AutoSize = True
        Me.lblfunçãoregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfunçãoregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblfunçãoregistos.Location = New System.Drawing.Point(67, 83)
        Me.lblfunçãoregistos.Name = "lblfunçãoregistos"
        Me.lblfunçãoregistos.Size = New System.Drawing.Size(53, 13)
        Me.lblfunçãoregistos.TabIndex = 5
        Me.lblfunçãoregistos.Text = "Função:"
        '
        'categoriaregistos
        '
        Me.categoriaregistos.AutoSize = True
        Me.categoriaregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoriaregistos.ForeColor = System.Drawing.Color.Blue
        Me.categoriaregistos.Location = New System.Drawing.Point(55, 111)
        Me.categoriaregistos.Name = "categoriaregistos"
        Me.categoriaregistos.Size = New System.Drawing.Size(65, 13)
        Me.categoriaregistos.TabIndex = 6
        Me.categoriaregistos.Text = "Categoria:"
        '
        'combofunçaoregistos
        '
        Me.combofunçaoregistos.FormattingEnabled = True
        Me.combofunçaoregistos.Location = New System.Drawing.Point(122, 80)
        Me.combofunçaoregistos.Name = "combofunçaoregistos"
        Me.combofunçaoregistos.Size = New System.Drawing.Size(140, 21)
        Me.combofunçaoregistos.TabIndex = 7
        '
        'dadosdoutilizador
        '
        Me.dadosdoutilizador.Controls.Add(Me.combonomeregistos)
        Me.dadosdoutilizador.Controls.Add(Me.lblobrigatoriocatregistos)
        Me.dadosdoutilizador.Controls.Add(Me.lblobrigatoriofuncregisto)
        Me.dadosdoutilizador.Controls.Add(Me.lblobrigatorionomeregisto)
        Me.dadosdoutilizador.Controls.Add(Me.combofunçaoregistos)
        Me.dadosdoutilizador.Controls.Add(Me.lblutilizadorregistos)
        Me.dadosdoutilizador.Controls.Add(Me.categoriaregistos)
        Me.dadosdoutilizador.Controls.Add(Me.txtnutilizadoregistos)
        Me.dadosdoutilizador.Controls.Add(Me.lblfunçãoregistos)
        Me.dadosdoutilizador.Controls.Add(Me.lblnomeutilizadorregistos)
        Me.dadosdoutilizador.Controls.Add(Me.combocategoriaregistos)
        Me.dadosdoutilizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dadosdoutilizador.Location = New System.Drawing.Point(15, 38)
        Me.dadosdoutilizador.Name = "dadosdoutilizador"
        Me.dadosdoutilizador.Size = New System.Drawing.Size(403, 142)
        Me.dadosdoutilizador.TabIndex = 8
        Me.dadosdoutilizador.TabStop = False
        Me.dadosdoutilizador.Text = "Dados de utilizador"
        '
        'combonomeregistos
        '
        Me.combonomeregistos.FormattingEnabled = True
        Me.combonomeregistos.Location = New System.Drawing.Point(122, 53)
        Me.combonomeregistos.Name = "combonomeregistos"
        Me.combonomeregistos.Size = New System.Drawing.Size(140, 21)
        Me.combonomeregistos.TabIndex = 13
        '
        'lblobrigatoriocatregistos
        '
        Me.lblobrigatoriocatregistos.AutoSize = True
        Me.lblobrigatoriocatregistos.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriocatregistos.Location = New System.Drawing.Point(269, 111)
        Me.lblobrigatoriocatregistos.Name = "lblobrigatoriocatregistos"
        Me.lblobrigatoriocatregistos.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriocatregistos.TabIndex = 12
        Me.lblobrigatoriocatregistos.Text = "*Obrigatório"
        '
        'lblobrigatoriofuncregisto
        '
        Me.lblobrigatoriofuncregisto.AutoSize = True
        Me.lblobrigatoriofuncregisto.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriofuncregisto.Location = New System.Drawing.Point(268, 83)
        Me.lblobrigatoriofuncregisto.Name = "lblobrigatoriofuncregisto"
        Me.lblobrigatoriofuncregisto.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriofuncregisto.TabIndex = 10
        Me.lblobrigatoriofuncregisto.Text = "*Obrigatório"
        '
        'lblobrigatorionomeregisto
        '
        Me.lblobrigatorionomeregisto.AutoSize = True
        Me.lblobrigatorionomeregisto.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorionomeregisto.Location = New System.Drawing.Point(268, 57)
        Me.lblobrigatorionomeregisto.Name = "lblobrigatorionomeregisto"
        Me.lblobrigatorionomeregisto.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorionomeregisto.TabIndex = 9
        Me.lblobrigatorionomeregisto.Text = "*Obrigatório"
        '
        'datagridregistos
        '
        Me.datagridregistos.BackgroundColor = System.Drawing.Color.White
        Me.datagridregistos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridregistos.Location = New System.Drawing.Point(610, 38)
        Me.datagridregistos.Name = "datagridregistos"
        Me.datagridregistos.Size = New System.Drawing.Size(599, 503)
        Me.datagridregistos.TabIndex = 13
        '
        'menuregistos
        '
        Me.menuregistos.Location = New System.Drawing.Point(0, 0)
        Me.menuregistos.Name = "menuregistos"
        Me.menuregistos.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.menuregistos.Size = New System.Drawing.Size(1221, 24)
        Me.menuregistos.TabIndex = 10
        Me.menuregistos.Text = "menuregistos"
        '
        'btnnovoregisto
        '
        Me.btnnovoregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnovoregisto.Location = New System.Drawing.Point(0, 0)
        Me.btnnovoregisto.Name = "btnnovoregisto"
        Me.btnnovoregisto.Size = New System.Drawing.Size(87, 23)
        Me.btnnovoregisto.TabIndex = 11
        Me.btnnovoregisto.Text = "Novo"
        Me.btnnovoregisto.UseVisualStyleBackColor = True
        '
        'btneditaregisto
        '
        Me.btneditaregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditaregisto.Location = New System.Drawing.Point(85, 0)
        Me.btneditaregisto.Name = "btneditaregisto"
        Me.btneditaregisto.Size = New System.Drawing.Size(87, 23)
        Me.btneditaregisto.TabIndex = 12
        Me.btneditaregisto.Text = "Editar"
        Me.btneditaregisto.UseVisualStyleBackColor = True
        '
        'btneliminaregisto
        '
        Me.btneliminaregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminaregisto.Location = New System.Drawing.Point(168, 0)
        Me.btneliminaregisto.Name = "btneliminaregisto"
        Me.btneliminaregisto.Size = New System.Drawing.Size(87, 23)
        Me.btneliminaregisto.TabIndex = 13
        Me.btneliminaregisto.Text = "Eliminar"
        Me.btneliminaregisto.UseVisualStyleBackColor = True
        '
        'btnguardaregisto
        '
        Me.btnguardaregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardaregisto.Location = New System.Drawing.Point(251, 0)
        Me.btnguardaregisto.Name = "btnguardaregisto"
        Me.btnguardaregisto.Size = New System.Drawing.Size(87, 23)
        Me.btnguardaregisto.TabIndex = 14
        Me.btnguardaregisto.Text = "Guardar"
        Me.btnguardaregisto.UseVisualStyleBackColor = True
        '
        'btnconsultaregistos
        '
        Me.btnconsultaregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultaregistos.Location = New System.Drawing.Point(331, 0)
        Me.btnconsultaregistos.Name = "btnconsultaregistos"
        Me.btnconsultaregistos.Size = New System.Drawing.Size(87, 23)
        Me.btnconsultaregistos.TabIndex = 15
        Me.btnconsultaregistos.Text = "Consultar"
        Me.btnconsultaregistos.UseVisualStyleBackColor = True
        '
        'btnsairegisto
        '
        Me.btnsairegisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairegisto.Location = New System.Drawing.Point(494, 0)
        Me.btnsairegisto.Name = "btnsairegisto"
        Me.btnsairegisto.Size = New System.Drawing.Size(87, 23)
        Me.btnsairegisto.TabIndex = 16
        Me.btnsairegisto.Text = "Sair"
        Me.btnsairegisto.UseVisualStyleBackColor = True
        '
        'btncancelaregisto
        '
        Me.btncancelaregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelaregisto.Location = New System.Drawing.Point(411, 0)
        Me.btncancelaregisto.Name = "btncancelaregisto"
        Me.btncancelaregisto.Size = New System.Drawing.Size(87, 23)
        Me.btncancelaregisto.TabIndex = 17
        Me.btncancelaregisto.Text = "Cancelar"
        Me.btncancelaregisto.UseVisualStyleBackColor = True
        '
        'registosdados
        '
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
        Me.registosdados.Location = New System.Drawing.Point(15, 189)
        Me.registosdados.Name = "registosdados"
        Me.registosdados.Size = New System.Drawing.Size(552, 334)
        Me.registosdados.TabIndex = 9
        Me.registosdados.TabStop = False
        Me.registosdados.Text = "Registos de dados"
        '
        'combanoletivoregisto
        '
        Me.combanoletivoregisto.FormattingEnabled = True
        Me.combanoletivoregisto.Items.AddRange(New Object() {"2015/2016"})
        Me.combanoletivoregisto.Location = New System.Drawing.Point(117, 252)
        Me.combanoletivoregisto.Name = "combanoletivoregisto"
        Me.combanoletivoregisto.Size = New System.Drawing.Size(62, 21)
        Me.combanoletivoregisto.TabIndex = 26
        '
        'comboturmaregistos
        '
        Me.comboturmaregistos.FormattingEnabled = True
        Me.comboturmaregistos.Location = New System.Drawing.Point(117, 199)
        Me.comboturmaregistos.Name = "comboturmaregistos"
        Me.comboturmaregistos.Size = New System.Drawing.Size(62, 21)
        Me.comboturmaregistos.TabIndex = 25
        '
        'numdowqtregistos
        '
        Me.numdowqtregistos.Location = New System.Drawing.Point(117, 144)
        Me.numdowqtregistos.Name = "numdowqtregistos"
        Me.numdowqtregistos.Size = New System.Drawing.Size(44, 20)
        Me.numdowqtregistos.TabIndex = 24
        Me.numdowqtregistos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtobsregistos
        '
        Me.txtobsregistos.Location = New System.Drawing.Point(117, 282)
        Me.txtobsregistos.Multiline = True
        Me.txtobsregistos.Name = "txtobsregistos"
        Me.txtobsregistos.Size = New System.Drawing.Size(309, 46)
        Me.txtobsregistos.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(78, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Obs:"
        '
        'mtelemovelregistos
        '
        Me.mtelemovelregistos.Location = New System.Drawing.Point(460, 111)
        Me.mtelemovelregistos.Mask = "000000000"
        Me.mtelemovelregistos.Name = "mtelemovelregistos"
        Me.mtelemovelregistos.Size = New System.Drawing.Size(73, 20)
        Me.mtelemovelregistos.TabIndex = 21
        Me.mtelemovelregistos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'telemovelregistos
        '
        Me.telemovelregistos.AutoSize = True
        Me.telemovelregistos.Location = New System.Drawing.Point(393, 114)
        Me.telemovelregistos.Name = "telemovelregistos"
        Me.telemovelregistos.Size = New System.Drawing.Size(69, 13)
        Me.telemovelregistos.TabIndex = 20
        Me.telemovelregistos.Text = "Telemóvel:"
        '
        'mtelefoneregistos
        '
        Me.mtelefoneregistos.Location = New System.Drawing.Point(311, 111)
        Me.mtelefoneregistos.Mask = "000000000"
        Me.mtelefoneregistos.Name = "mtelefoneregistos"
        Me.mtelefoneregistos.Size = New System.Drawing.Size(73, 20)
        Me.mtelefoneregistos.TabIndex = 19
        Me.mtelefoneregistos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lbltelefoneregisto
        '
        Me.lbltelefoneregisto.AutoSize = True
        Me.lbltelefoneregisto.Location = New System.Drawing.Point(249, 114)
        Me.lbltelefoneregisto.Name = "lbltelefoneregisto"
        Me.lbltelefoneregisto.Size = New System.Drawing.Size(61, 13)
        Me.lbltelefoneregisto.TabIndex = 18
        Me.lbltelefoneregisto.Text = "Telefone:"
        '
        'combotiposerviçosregistos
        '
        Me.combotiposerviçosregistos.FormattingEnabled = True
        Me.combotiposerviçosregistos.Location = New System.Drawing.Point(117, 225)
        Me.combotiposerviçosregistos.Name = "combotiposerviçosregistos"
        Me.combotiposerviçosregistos.Size = New System.Drawing.Size(116, 21)
        Me.combotiposerviçosregistos.TabIndex = 17
        '
        'lbltiposervicoregistos
        '
        Me.lbltiposervicoregistos.AutoSize = True
        Me.lbltiposervicoregistos.Location = New System.Drawing.Point(12, 228)
        Me.lbltiposervicoregistos.Name = "lbltiposervicoregistos"
        Me.lbltiposervicoregistos.Size = New System.Drawing.Size(99, 13)
        Me.lbltiposervicoregistos.TabIndex = 16
        Me.lbltiposervicoregistos.Text = "Tipo de serviço:"
        '
        'lblturmaregistos
        '
        Me.lblturmaregistos.AutoSize = True
        Me.lblturmaregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblturmaregistos.Location = New System.Drawing.Point(65, 202)
        Me.lblturmaregistos.Name = "lblturmaregistos"
        Me.lblturmaregistos.Size = New System.Drawing.Size(46, 13)
        Me.lblturmaregistos.TabIndex = 15
        Me.lblturmaregistos.Text = "Turma:"
        '
        'txtdestinarioregistos
        '
        Me.txtdestinarioregistos.Location = New System.Drawing.Point(117, 173)
        Me.txtdestinarioregistos.Name = "txtdestinarioregistos"
        Me.txtdestinarioregistos.Size = New System.Drawing.Size(309, 20)
        Me.txtdestinarioregistos.TabIndex = 13
        '
        'lbldestinarioregisto
        '
        Me.lbldestinarioregisto.AutoSize = True
        Me.lbldestinarioregisto.ForeColor = System.Drawing.Color.Blue
        Me.lbldestinarioregisto.Location = New System.Drawing.Point(36, 176)
        Me.lbldestinarioregisto.Name = "lbldestinarioregisto"
        Me.lbldestinarioregisto.Size = New System.Drawing.Size(79, 13)
        Me.lbldestinarioregisto.TabIndex = 12
        Me.lbldestinarioregisto.Text = "Destinatário:"
        '
        'lblqtregistos
        '
        Me.lblqtregistos.AutoSize = True
        Me.lblqtregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblqtregistos.Location = New System.Drawing.Point(39, 146)
        Me.lblqtregistos.Name = "lblqtregistos"
        Me.lblqtregistos.Size = New System.Drawing.Size(76, 13)
        Me.lblqtregistos.TabIndex = 10
        Me.lblqtregistos.Text = "Quantidade:"
        '
        'combocomuniregistos
        '
        Me.combocomuniregistos.FormattingEnabled = True
        Me.combocomuniregistos.Items.AddRange(New Object() {"Email", "Carta", "Carta Registada", "Telefone", "Telemóvel"})
        Me.combocomuniregistos.Location = New System.Drawing.Point(117, 111)
        Me.combocomuniregistos.Name = "combocomuniregistos"
        Me.combocomuniregistos.Size = New System.Drawing.Size(116, 21)
        Me.combocomuniregistos.TabIndex = 9
        '
        'lblvcomunicacaoregistos
        '
        Me.lblvcomunicacaoregistos.AutoSize = True
        Me.lblvcomunicacaoregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblvcomunicacaoregistos.Location = New System.Drawing.Point(6, 114)
        Me.lblvcomunicacaoregistos.Name = "lblvcomunicacaoregistos"
        Me.lblvcomunicacaoregistos.Size = New System.Drawing.Size(109, 13)
        Me.lblvcomunicacaoregistos.TabIndex = 8
        Me.lblvcomunicacaoregistos.Text = "Via Comunicação:"
        '
        'txthorasregisto
        '
        Me.txthorasregisto.Location = New System.Drawing.Point(117, 79)
        Me.txthorasregisto.Name = "txthorasregisto"
        Me.txthorasregisto.Size = New System.Drawing.Size(62, 20)
        Me.txthorasregisto.TabIndex = 7
        '
        'lblhoraregistos
        '
        Me.lblhoraregistos.AutoSize = True
        Me.lblhoraregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoraregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblhoraregistos.Location = New System.Drawing.Point(73, 82)
        Me.lblhoraregistos.Name = "lblhoraregistos"
        Me.lblhoraregistos.Size = New System.Drawing.Size(42, 13)
        Me.lblhoraregistos.TabIndex = 6
        Me.lblhoraregistos.Text = "Hora :"
        '
        'txtdataregistos
        '
        Me.txtdataregistos.Location = New System.Drawing.Point(117, 53)
        Me.txtdataregistos.Name = "txtdataregistos"
        Me.txtdataregistos.Size = New System.Drawing.Size(62, 20)
        Me.txtdataregistos.TabIndex = 5
        '
        'lbldataregisto
        '
        Me.lbldataregisto.AutoSize = True
        Me.lbldataregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldataregisto.ForeColor = System.Drawing.Color.Blue
        Me.lbldataregisto.Location = New System.Drawing.Point(73, 56)
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
        Me.lblanoletivoregisto.Location = New System.Drawing.Point(39, 255)
        Me.lblanoletivoregisto.Name = "lblanoletivoregisto"
        Me.lblanoletivoregisto.Size = New System.Drawing.Size(72, 13)
        Me.lblanoletivoregisto.TabIndex = 2
        Me.lblanoletivoregisto.Text = "Ano Letivo:"
        '
        'txtnumregistos
        '
        Me.txtnumregistos.Location = New System.Drawing.Point(117, 26)
        Me.txtnumregistos.Name = "txtnumregistos"
        Me.txtnumregistos.Size = New System.Drawing.Size(27, 20)
        Me.txtnumregistos.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(37, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nº Registos:"
        '
        'Horaregisto
        '
        Me.Horaregisto.Enabled = True
        Me.Horaregisto.Interval = 1000
        '
        'Registo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1221, 565)
        Me.Controls.Add(Me.datagridregistos)
        Me.Controls.Add(Me.btnsairegisto)
        Me.Controls.Add(Me.btnconsultaregistos)
        Me.Controls.Add(Me.btncancelaregisto)
        Me.Controls.Add(Me.btnguardaregisto)
        Me.Controls.Add(Me.btneliminaregisto)
        Me.Controls.Add(Me.btneditaregisto)
        Me.Controls.Add(Me.btnnovoregisto)
        Me.Controls.Add(Me.registosdados)
        Me.Controls.Add(Me.dadosdoutilizador)
        Me.Controls.Add(Me.menuregistos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.menuregistos
        Me.Name = "Registo"
        Me.Text = "registos"
        Me.dadosdoutilizador.ResumeLayout(False)
        Me.dadosdoutilizador.PerformLayout()
        CType(Me.datagridregistos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.registosdados.ResumeLayout(False)
        Me.registosdados.PerformLayout()
        CType(Me.numdowqtregistos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblutilizadorregistos As Label
    Friend WithEvents txtnutilizadoregistos As TextBox
    Friend WithEvents lblnomeutilizadorregistos As Label
    Friend WithEvents combocategoriaregistos As ComboBox
    Friend WithEvents lblfunçãoregistos As Label
    Friend WithEvents categoriaregistos As Label
    Friend WithEvents combofunçaoregistos As ComboBox
    Friend WithEvents dadosdoutilizador As GroupBox
    Friend WithEvents menuregistos As MenuStrip
    Friend WithEvents btnnovoregisto As Button
    Friend WithEvents btneditaregisto As Button
    Friend WithEvents btneliminaregisto As Button
    Friend WithEvents btnguardaregisto As Button
    Friend WithEvents btnconsultaregistos As Button
    Friend WithEvents btnsairegisto As Button
    Friend WithEvents btncancelaregisto As Button
    Friend WithEvents lblobrigatoriocatregistos As System.Windows.Forms.Label
    Friend WithEvents lblobrigatoriofuncregisto As System.Windows.Forms.Label
    Friend WithEvents lblobrigatorionomeregisto As System.Windows.Forms.Label
    Friend WithEvents registosdados As System.Windows.Forms.GroupBox
    Friend WithEvents txthorasregisto As System.Windows.Forms.TextBox
    Friend WithEvents lblhoraregistos As System.Windows.Forms.Label
    Friend WithEvents txtdataregistos As System.Windows.Forms.TextBox
    Friend WithEvents lbldataregisto As System.Windows.Forms.Label
    Friend WithEvents lblanoletivoregisto As System.Windows.Forms.Label
    Friend WithEvents txtnumregistos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblturmaregistos As System.Windows.Forms.Label
    Friend WithEvents txtdestinarioregistos As System.Windows.Forms.TextBox
    Friend WithEvents lbldestinarioregisto As System.Windows.Forms.Label
    Friend WithEvents lblqtregistos As System.Windows.Forms.Label
    Friend WithEvents combocomuniregistos As System.Windows.Forms.ComboBox
    Friend WithEvents lblvcomunicacaoregistos As System.Windows.Forms.Label
    Friend WithEvents mtelemovelregistos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents telemovelregistos As System.Windows.Forms.Label
    Friend WithEvents mtelefoneregistos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbltelefoneregisto As System.Windows.Forms.Label
    Friend WithEvents combotiposerviçosregistos As System.Windows.Forms.ComboBox
    Friend WithEvents lbltiposervicoregistos As System.Windows.Forms.Label
    Friend WithEvents txtobsregistos As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents datagridregistos As System.Windows.Forms.DataGridView
    Friend WithEvents Horaregisto As System.Windows.Forms.Timer
    Friend WithEvents combonomeregistos As System.Windows.Forms.ComboBox
    Friend WithEvents numdowqtregistos As System.Windows.Forms.NumericUpDown
    Friend WithEvents comboturmaregistos As System.Windows.Forms.ComboBox
    Friend WithEvents combanoletivoregisto As System.Windows.Forms.ComboBox
End Class
