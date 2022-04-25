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
        Me.txtnomeutilizadorhorario = New System.Windows.Forms.TextBox()
        Me.txtnumutilizadohorario = New System.Windows.Forms.TextBox()
        Me.lblnomeutilizadorhorario = New System.Windows.Forms.Label()
        Me.lblcategoriaoutilizadorhorario = New System.Windows.Forms.Label()
        Me.lblfuncaoutilizadorhorario = New System.Windows.Forms.Label()
        Me.lblnumhorario = New System.Windows.Forms.Label()
        Me.grouputilizadorhorario = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.datagridhorario = New System.Windows.Forms.DataGridView()
        Me.btncancelarhorario = New System.Windows.Forms.Button()
        Me.lblnumutilizadorpesquisahorario = New System.Windows.Forms.Label()
        Me.txtnumhorario = New System.Windows.Forms.TextBox()
        Me.grouphorario = New System.Windows.Forms.GroupBox()
        Me.comboblocohorario = New System.Windows.Forms.ComboBox()
        Me.txtconsultahorario = New System.Windows.Forms.TextBox()
        Me.lblconsulta = New System.Windows.Forms.Label()
        Me.lblobrigatoriobloco = New System.Windows.Forms.Label()
        Me.lblBloco = New System.Windows.Forms.Label()
        Me.lblobrigatorioarea = New System.Windows.Forms.Label()
        Me.combareahorario = New System.Windows.Forms.ComboBox()
        Me.lblareahorario = New System.Windows.Forms.Label()
        Me.combosalahorario = New System.Windows.Forms.ComboBox()
        Me.combodisciplinahorario = New System.Windows.Forms.ComboBox()
        Me.combodiashorario = New System.Windows.Forms.ComboBox()
        Me.lblobrigatoriodias = New System.Windows.Forms.Label()
        Me.lblbdaisemana = New System.Windows.Forms.Label()
        Me.combohorashorario = New System.Windows.Forms.ComboBox()
        Me.lblobrigatoriohoras = New System.Windows.Forms.Label()
        Me.lbltempohorario = New System.Windows.Forms.Label()
        Me.lblobrigatoriosala = New System.Windows.Forms.Label()
        Me.lblsalahorario = New System.Windows.Forms.Label()
        Me.lblobrigatoriodisciplina = New System.Windows.Forms.Label()
        Me.lbldisciplinahorario = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combonomehorario = New System.Windows.Forms.ComboBox()
        Me.dathorario = New System.Windows.Forms.DataGridView()
        Me.combocategoriapesquisa = New System.Windows.Forms.ComboBox()
        Me.combofuncaopesquisa = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grouputilizadorhorario.SuspendLayout()
        CType(Me.datagridhorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grouphorario.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dathorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuhorario
        '
        Me.menuhorario.Location = New System.Drawing.Point(0, 0)
        Me.menuhorario.Name = "menuhorario"
        Me.menuhorario.Size = New System.Drawing.Size(916, 24)
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
        'txtnomeutilizadorhorario
        '
        Me.txtnomeutilizadorhorario.Location = New System.Drawing.Point(74, 40)
        Me.txtnomeutilizadorhorario.Name = "txtnomeutilizadorhorario"
        Me.txtnomeutilizadorhorario.Size = New System.Drawing.Size(289, 20)
        Me.txtnomeutilizadorhorario.TabIndex = 4
        '
        'txtnumutilizadohorario
        '
        Me.txtnumutilizadohorario.Location = New System.Drawing.Point(75, 16)
        Me.txtnumutilizadohorario.Name = "txtnumutilizadohorario"
        Me.txtnumutilizadohorario.Size = New System.Drawing.Size(32, 20)
        Me.txtnumutilizadohorario.TabIndex = 3
        '
        'lblnomeutilizadorhorario
        '
        Me.lblnomeutilizadorhorario.AutoSize = True
        Me.lblnomeutilizadorhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeutilizadorhorario.ForeColor = System.Drawing.Color.Blue
        Me.lblnomeutilizadorhorario.Location = New System.Drawing.Point(28, 43)
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
        Me.lblcategoriaoutilizadorhorario.Location = New System.Drawing.Point(194, 71)
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
        Me.lblfuncaoutilizadorhorario.Location = New System.Drawing.Point(18, 71)
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
        Me.lblnumhorario.Location = New System.Drawing.Point(46, 19)
        Me.lblnumhorario.Name = "lblnumhorario"
        Me.lblnumhorario.Size = New System.Drawing.Size(25, 13)
        Me.lblnumhorario.TabIndex = 0
        Me.lblnumhorario.Text = "Nº:"
        '
        'grouputilizadorhorario
        '
        Me.grouputilizadorhorario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grouputilizadorhorario.Controls.Add(Me.TextBox3)
        Me.grouputilizadorhorario.Controls.Add(Me.TextBox1)
        Me.grouputilizadorhorario.Controls.Add(Me.txtnomeutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.txtnumutilizadohorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblnomeutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblcategoriaoutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblfuncaoutilizadorhorario)
        Me.grouputilizadorhorario.Controls.Add(Me.lblnumhorario)
        Me.grouputilizadorhorario.Enabled = False
        Me.grouputilizadorhorario.Location = New System.Drawing.Point(12, 29)
        Me.grouputilizadorhorario.Name = "grouputilizadorhorario"
        Me.grouputilizadorhorario.Size = New System.Drawing.Size(369, 106)
        Me.grouputilizadorhorario.TabIndex = 23
        Me.grouputilizadorhorario.TabStop = False
        Me.grouputilizadorhorario.Text = "Dados do Utilizador"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(262, 68)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'datagridhorario
        '
        Me.datagridhorario.BackgroundColor = System.Drawing.Color.White
        Me.datagridhorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridhorario.Location = New System.Drawing.Point(12, 344)
        Me.datagridhorario.Name = "datagridhorario"
        Me.datagridhorario.Size = New System.Drawing.Size(883, 191)
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
        Me.lblnumutilizadorpesquisahorario.Location = New System.Drawing.Point(18, 19)
        Me.lblnumutilizadorpesquisahorario.Name = "lblnumutilizadorpesquisahorario"
        Me.lblnumutilizadorpesquisahorario.Size = New System.Drawing.Size(25, 13)
        Me.lblnumutilizadorpesquisahorario.TabIndex = 0
        Me.lblnumutilizadorpesquisahorario.Text = "Nº:"
        '
        'txtnumhorario
        '
        Me.txtnumhorario.Location = New System.Drawing.Point(52, 12)
        Me.txtnumhorario.Name = "txtnumhorario"
        Me.txtnumhorario.Size = New System.Drawing.Size(32, 20)
        Me.txtnumhorario.TabIndex = 3
        '
        'grouphorario
        '
        Me.grouphorario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grouphorario.Controls.Add(Me.comboblocohorario)
        Me.grouphorario.Controls.Add(Me.txtconsultahorario)
        Me.grouphorario.Controls.Add(Me.lblconsulta)
        Me.grouphorario.Controls.Add(Me.lblobrigatoriobloco)
        Me.grouphorario.Controls.Add(Me.lblBloco)
        Me.grouphorario.Controls.Add(Me.lblobrigatorioarea)
        Me.grouphorario.Controls.Add(Me.combareahorario)
        Me.grouphorario.Controls.Add(Me.lblareahorario)
        Me.grouphorario.Controls.Add(Me.combosalahorario)
        Me.grouphorario.Controls.Add(Me.combodisciplinahorario)
        Me.grouphorario.Controls.Add(Me.combodiashorario)
        Me.grouphorario.Controls.Add(Me.lblobrigatoriodias)
        Me.grouphorario.Controls.Add(Me.lblbdaisemana)
        Me.grouphorario.Controls.Add(Me.combohorashorario)
        Me.grouphorario.Controls.Add(Me.lblobrigatoriohoras)
        Me.grouphorario.Controls.Add(Me.lbltempohorario)
        Me.grouphorario.Controls.Add(Me.lblobrigatoriosala)
        Me.grouphorario.Controls.Add(Me.lblsalahorario)
        Me.grouphorario.Controls.Add(Me.lblobrigatoriodisciplina)
        Me.grouphorario.Controls.Add(Me.lbldisciplinahorario)
        Me.grouphorario.Controls.Add(Me.txtnumhorario)
        Me.grouphorario.Controls.Add(Me.lblnumutilizadorpesquisahorario)
        Me.grouphorario.Location = New System.Drawing.Point(12, 141)
        Me.grouphorario.Name = "grouphorario"
        Me.grouphorario.Size = New System.Drawing.Size(369, 188)
        Me.grouphorario.TabIndex = 21
        Me.grouphorario.TabStop = False
        Me.grouphorario.Text = "Horário"
        '
        'comboblocohorario
        '
        Me.comboblocohorario.FormattingEnabled = True
        Me.comboblocohorario.Location = New System.Drawing.Point(51, 64)
        Me.comboblocohorario.Name = "comboblocohorario"
        Me.comboblocohorario.Size = New System.Drawing.Size(94, 21)
        Me.comboblocohorario.TabIndex = 47
        '
        'txtconsultahorario
        '
        Me.txtconsultahorario.Location = New System.Drawing.Point(127, 151)
        Me.txtconsultahorario.Name = "txtconsultahorario"
        Me.txtconsultahorario.Size = New System.Drawing.Size(72, 20)
        Me.txtconsultahorario.TabIndex = 28
        '
        'lblconsulta
        '
        Me.lblconsulta.AutoSize = True
        Me.lblconsulta.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblconsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconsulta.ForeColor = System.Drawing.Color.Blue
        Me.lblconsulta.Location = New System.Drawing.Point(18, 151)
        Me.lblconsulta.Name = "lblconsulta"
        Me.lblconsulta.Size = New System.Drawing.Size(103, 13)
        Me.lblconsulta.TabIndex = 29
        Me.lblconsulta.Text = "Consulta horario:"
        '
        'lblobrigatoriobloco
        '
        Me.lblobrigatoriobloco.AutoSize = True
        Me.lblobrigatoriobloco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriobloco.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriobloco.Location = New System.Drawing.Point(173, 71)
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
        Me.lblBloco.Location = New System.Drawing.Point(3, 67)
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
        Me.lblobrigatorioarea.Location = New System.Drawing.Point(153, 41)
        Me.lblobrigatorioarea.Name = "lblobrigatorioarea"
        Me.lblobrigatorioarea.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorioarea.TabIndex = 44
        Me.lblobrigatorioarea.Text = "*Obrigatório"
        '
        'combareahorario
        '
        Me.combareahorario.FormattingEnabled = True
        Me.combareahorario.Location = New System.Drawing.Point(52, 38)
        Me.combareahorario.Name = "combareahorario"
        Me.combareahorario.Size = New System.Drawing.Size(94, 21)
        Me.combareahorario.TabIndex = 43
        '
        'lblareahorario
        '
        Me.lblareahorario.AutoSize = True
        Me.lblareahorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblareahorario.ForeColor = System.Drawing.Color.Blue
        Me.lblareahorario.Location = New System.Drawing.Point(9, 41)
        Me.lblareahorario.Name = "lblareahorario"
        Me.lblareahorario.Size = New System.Drawing.Size(37, 13)
        Me.lblareahorario.TabIndex = 42
        Me.lblareahorario.Text = "Área:"
        '
        'combosalahorario
        '
        Me.combosalahorario.FormattingEnabled = True
        Me.combosalahorario.Location = New System.Drawing.Point(255, 71)
        Me.combosalahorario.Name = "combosalahorario"
        Me.combosalahorario.Size = New System.Drawing.Size(94, 21)
        Me.combosalahorario.TabIndex = 41
        '
        'combodisciplinahorario
        '
        Me.combodisciplinahorario.FormattingEnabled = True
        Me.combodisciplinahorario.Location = New System.Drawing.Point(255, 44)
        Me.combodisciplinahorario.Name = "combodisciplinahorario"
        Me.combodisciplinahorario.Size = New System.Drawing.Size(94, 21)
        Me.combodisciplinahorario.TabIndex = 40
        '
        'combodiashorario
        '
        Me.combodiashorario.FormattingEnabled = True
        Me.combodiashorario.Location = New System.Drawing.Point(50, 91)
        Me.combodiashorario.Name = "combodiashorario"
        Me.combodiashorario.Size = New System.Drawing.Size(95, 21)
        Me.combodiashorario.TabIndex = 39
        '
        'lblobrigatoriodias
        '
        Me.lblobrigatoriodias.AutoSize = True
        Me.lblobrigatoriodias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriodias.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriodias.Location = New System.Drawing.Point(175, 101)
        Me.lblobrigatoriodias.Name = "lblobrigatoriodias"
        Me.lblobrigatoriodias.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriodias.TabIndex = 38
        Me.lblobrigatoriodias.Text = "*Obrigatório"
        '
        'lblbdaisemana
        '
        Me.lblbdaisemana.AutoSize = True
        Me.lblbdaisemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbdaisemana.ForeColor = System.Drawing.Color.Blue
        Me.lblbdaisemana.Location = New System.Drawing.Point(9, 94)
        Me.lblbdaisemana.Name = "lblbdaisemana"
        Me.lblbdaisemana.Size = New System.Drawing.Size(36, 13)
        Me.lblbdaisemana.TabIndex = 37
        Me.lblbdaisemana.Text = "Dias:"
        '
        'combohorashorario
        '
        Me.combohorashorario.FormattingEnabled = True
        Me.combohorashorario.Location = New System.Drawing.Point(254, 98)
        Me.combohorashorario.Name = "combohorashorario"
        Me.combohorashorario.Size = New System.Drawing.Size(95, 21)
        Me.combohorashorario.TabIndex = 36
        '
        'lblobrigatoriohoras
        '
        Me.lblobrigatoriohoras.AutoSize = True
        Me.lblobrigatoriohoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriohoras.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriohoras.Location = New System.Drawing.Point(356, 101)
        Me.lblobrigatoriohoras.Name = "lblobrigatoriohoras"
        Me.lblobrigatoriohoras.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriohoras.TabIndex = 35
        Me.lblobrigatoriohoras.Text = "*Obrigatório"
        '
        'lbltempohorario
        '
        Me.lbltempohorario.AutoSize = True
        Me.lbltempohorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltempohorario.ForeColor = System.Drawing.Color.Blue
        Me.lbltempohorario.Location = New System.Drawing.Point(205, 101)
        Me.lbltempohorario.Name = "lbltempohorario"
        Me.lbltempohorario.Size = New System.Drawing.Size(44, 13)
        Me.lbltempohorario.TabIndex = 33
        Me.lbltempohorario.Text = "Horas:"
        '
        'lblobrigatoriosala
        '
        Me.lblobrigatoriosala.AutoSize = True
        Me.lblobrigatoriosala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriosala.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriosala.Location = New System.Drawing.Point(343, 79)
        Me.lblobrigatoriosala.Name = "lblobrigatoriosala"
        Me.lblobrigatoriosala.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriosala.TabIndex = 32
        Me.lblobrigatoriosala.Text = "*Obrigatório"
        '
        'lblsalahorario
        '
        Me.lblsalahorario.AutoSize = True
        Me.lblsalahorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalahorario.ForeColor = System.Drawing.Color.Blue
        Me.lblsalahorario.Location = New System.Drawing.Point(213, 74)
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
        Me.lblobrigatoriodisciplina.Location = New System.Drawing.Point(343, 47)
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
        Me.lbldisciplinahorario.Location = New System.Drawing.Point(183, 47)
        Me.lbldisciplinahorario.Name = "lbldisciplinahorario"
        Me.lbldisciplinahorario.Size = New System.Drawing.Size(66, 13)
        Me.lbldisciplinahorario.TabIndex = 27
        Me.lbldisciplinahorario.Text = "Disciplina:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.combonomehorario)
        Me.GroupBox1.Controls.Add(Me.dathorario)
        Me.GroupBox1.Controls.Add(Me.combocategoriapesquisa)
        Me.GroupBox1.Controls.Add(Me.combofuncaopesquisa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(387, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 300)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisa"
        '
        'combonomehorario
        '
        Me.combonomehorario.FormattingEnabled = True
        Me.combonomehorario.Location = New System.Drawing.Point(69, 19)
        Me.combonomehorario.Name = "combonomehorario"
        Me.combonomehorario.Size = New System.Drawing.Size(427, 21)
        Me.combonomehorario.TabIndex = 25
        '
        'dathorario
        '
        Me.dathorario.BackgroundColor = System.Drawing.Color.White
        Me.dathorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dathorario.Location = New System.Drawing.Point(6, 87)
        Me.dathorario.Name = "dathorario"
        Me.dathorario.Size = New System.Drawing.Size(490, 170)
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
        'horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(916, 583)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncancelarhorario)
        Me.Controls.Add(Me.datagridhorario)
        Me.Controls.Add(Me.grouputilizadorhorario)
        Me.Controls.Add(Me.grouphorario)
        Me.Controls.Add(Me.btnsairhorario)
        Me.Controls.Add(Me.btnconsultarhorario)
        Me.Controls.Add(Me.btnpesquisarhorario)
        Me.Controls.Add(Me.btnguardarhorario)
        Me.Controls.Add(Me.btneliminarhorario)
        Me.Controls.Add(Me.btneditarhorario)
        Me.Controls.Add(Me.btnovohorario)
        Me.Controls.Add(Me.menuhorario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.menuhorario
        Me.Name = "horario"
        Me.Text = " "
        Me.grouputilizadorhorario.ResumeLayout(False)
        Me.grouputilizadorhorario.PerformLayout()
        CType(Me.datagridhorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grouphorario.ResumeLayout(False)
        Me.grouphorario.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dathorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents lblobrigatoriodisciplina As System.Windows.Forms.Label
    Friend WithEvents lbldisciplinahorario As System.Windows.Forms.Label
    Friend WithEvents lblobrigatoriosala As System.Windows.Forms.Label
    Friend WithEvents lblsalahorario As System.Windows.Forms.Label
    Friend WithEvents lblobrigatoriohoras As System.Windows.Forms.Label
    Friend WithEvents lbltempohorario As System.Windows.Forms.Label
    Friend WithEvents combohorashorario As System.Windows.Forms.ComboBox
    Friend WithEvents lblobrigatoriodias As System.Windows.Forms.Label
    Friend WithEvents lblbdaisemana As System.Windows.Forms.Label
    Friend WithEvents combodiashorario As System.Windows.Forms.ComboBox
    Friend WithEvents combosalahorario As System.Windows.Forms.ComboBox
    Friend WithEvents combodisciplinahorario As System.Windows.Forms.ComboBox
    Friend WithEvents lblobrigatorioarea As System.Windows.Forms.Label
    Friend WithEvents combareahorario As System.Windows.Forms.ComboBox
    Friend WithEvents lblareahorario As System.Windows.Forms.Label
    Friend WithEvents comboblocohorario As System.Windows.Forms.ComboBox
    Friend WithEvents lblobrigatoriobloco As System.Windows.Forms.Label
    Friend WithEvents lblBloco As System.Windows.Forms.Label
    Friend WithEvents txtconsultahorario As System.Windows.Forms.TextBox
    Friend WithEvents lblconsulta As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents combonomehorario As System.Windows.Forms.ComboBox
    Friend WithEvents dathorario As System.Windows.Forms.DataGridView
    Friend WithEvents combocategoriapesquisa As System.Windows.Forms.ComboBox
    Friend WithEvents combofuncaopesquisa As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
