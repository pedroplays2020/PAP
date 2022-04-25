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
        Me.groupesquisahorario = New System.Windows.Forms.GroupBox()
        Me.combopesquisahorário = New System.Windows.Forms.ComboBox()
        Me.combopesquisafunçãohorario = New System.Windows.Forms.ComboBox()
        Me.txtnomepesquisahorario = New System.Windows.Forms.TextBox()
        Me.txtnumpesquisahorario = New System.Windows.Forms.TextBox()
        Me.nomepesquisahorario = New System.Windows.Forms.Label()
        Me.lblcategoriahorario = New System.Windows.Forms.Label()
        Me.lblfuncaohorario = New System.Windows.Forms.Label()
        Me.lblnumutilizadorpesquisahorario = New System.Windows.Forms.Label()
        Me.combocategoriahorario = New System.Windows.Forms.ComboBox()
        Me.combofuncaohorario = New System.Windows.Forms.ComboBox()
        Me.txtnomehorario = New System.Windows.Forms.TextBox()
        Me.txtnunhorario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnumhorario = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datagridlistahorario = New System.Windows.Forms.DataGridView()
        Me.datagridhorario = New System.Windows.Forms.DataGridView()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupesquisahorario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datagridlistahorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridhorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuhorario
        '
        Me.menuhorario.Location = New System.Drawing.Point(0, 0)
        Me.menuhorario.Name = "menuhorario"
        Me.menuhorario.Size = New System.Drawing.Size(794, 24)
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
        Me.btnconsultarhorario.Location = New System.Drawing.Point(353, 0)
        Me.btnconsultarhorario.Name = "btnconsultarhorario"
        Me.btnconsultarhorario.Size = New System.Drawing.Size(75, 23)
        Me.btnconsultarhorario.TabIndex = 18
        Me.btnconsultarhorario.Text = "Consultar"
        Me.btnconsultarhorario.UseVisualStyleBackColor = True
        '
        'btnsairhorario
        '
        Me.btnsairhorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairhorario.Location = New System.Drawing.Point(419, 0)
        Me.btnsairhorario.Name = "btnsairhorario"
        Me.btnsairhorario.Size = New System.Drawing.Size(75, 23)
        Me.btnsairhorario.TabIndex = 19
        Me.btnsairhorario.Text = "Sair"
        Me.btnsairhorario.UseVisualStyleBackColor = True
        '
        'groupesquisahorario
        '
        Me.groupesquisahorario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.groupesquisahorario.Controls.Add(Me.combopesquisahorário)
        Me.groupesquisahorario.Controls.Add(Me.combopesquisafunçãohorario)
        Me.groupesquisahorario.Controls.Add(Me.txtnomepesquisahorario)
        Me.groupesquisahorario.Controls.Add(Me.txtnumpesquisahorario)
        Me.groupesquisahorario.Controls.Add(Me.nomepesquisahorario)
        Me.groupesquisahorario.Controls.Add(Me.lblcategoriahorario)
        Me.groupesquisahorario.Controls.Add(Me.lblfuncaohorario)
        Me.groupesquisahorario.Controls.Add(Me.lblnumutilizadorpesquisahorario)
        Me.groupesquisahorario.Location = New System.Drawing.Point(12, 38)
        Me.groupesquisahorario.Name = "groupesquisahorario"
        Me.groupesquisahorario.Size = New System.Drawing.Size(369, 136)
        Me.groupesquisahorario.TabIndex = 21
        Me.groupesquisahorario.TabStop = False
        Me.groupesquisahorario.Text = "Pesquisa"
        '
        'combopesquisahorário
        '
        Me.combopesquisahorário.FormattingEnabled = True
        Me.combopesquisahorário.Location = New System.Drawing.Point(74, 98)
        Me.combopesquisahorário.Name = "combopesquisahorário"
        Me.combopesquisahorário.Size = New System.Drawing.Size(95, 21)
        Me.combopesquisahorário.TabIndex = 23
        '
        'combopesquisafunçãohorario
        '
        Me.combopesquisafunçãohorario.FormattingEnabled = True
        Me.combopesquisafunçãohorario.Location = New System.Drawing.Point(74, 68)
        Me.combopesquisafunçãohorario.Name = "combopesquisafunçãohorario"
        Me.combopesquisafunçãohorario.Size = New System.Drawing.Size(95, 21)
        Me.combopesquisafunçãohorario.TabIndex = 22
        '
        'txtnomepesquisahorario
        '
        Me.txtnomepesquisahorario.Location = New System.Drawing.Point(74, 40)
        Me.txtnomepesquisahorario.Name = "txtnomepesquisahorario"
        Me.txtnomepesquisahorario.Size = New System.Drawing.Size(95, 20)
        Me.txtnomepesquisahorario.TabIndex = 4
        '
        'txtnumpesquisahorario
        '
        Me.txtnumpesquisahorario.Location = New System.Drawing.Point(75, 16)
        Me.txtnumpesquisahorario.Name = "txtnumpesquisahorario"
        Me.txtnumpesquisahorario.Size = New System.Drawing.Size(32, 20)
        Me.txtnumpesquisahorario.TabIndex = 3
        '
        'nomepesquisahorario
        '
        Me.nomepesquisahorario.AutoSize = True
        Me.nomepesquisahorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomepesquisahorario.ForeColor = System.Drawing.Color.Blue
        Me.nomepesquisahorario.Location = New System.Drawing.Point(28, 43)
        Me.nomepesquisahorario.Name = "nomepesquisahorario"
        Me.nomepesquisahorario.Size = New System.Drawing.Size(43, 13)
        Me.nomepesquisahorario.TabIndex = 1
        Me.nomepesquisahorario.Text = "Nome:"
        '
        'lblcategoriahorario
        '
        Me.lblcategoriahorario.AutoSize = True
        Me.lblcategoriahorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategoriahorario.ForeColor = System.Drawing.Color.Blue
        Me.lblcategoriahorario.Location = New System.Drawing.Point(6, 101)
        Me.lblcategoriahorario.Name = "lblcategoriahorario"
        Me.lblcategoriahorario.Size = New System.Drawing.Size(65, 13)
        Me.lblcategoriahorario.TabIndex = 2
        Me.lblcategoriahorario.Text = "Categoria:"
        '
        'lblfuncaohorario
        '
        Me.lblfuncaohorario.AutoSize = True
        Me.lblfuncaohorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuncaohorario.ForeColor = System.Drawing.Color.Blue
        Me.lblfuncaohorario.Location = New System.Drawing.Point(18, 71)
        Me.lblfuncaohorario.Name = "lblfuncaohorario"
        Me.lblfuncaohorario.Size = New System.Drawing.Size(53, 13)
        Me.lblfuncaohorario.TabIndex = 1
        Me.lblfuncaohorario.Text = "Função:"
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
        'combocategoriahorario
        '
        Me.combocategoriahorario.FormattingEnabled = True
        Me.combocategoriahorario.Location = New System.Drawing.Point(74, 98)
        Me.combocategoriahorario.Name = "combocategoriahorario"
        Me.combocategoriahorario.Size = New System.Drawing.Size(95, 21)
        Me.combocategoriahorario.TabIndex = 23
        '
        'combofuncaohorario
        '
        Me.combofuncaohorario.FormattingEnabled = True
        Me.combofuncaohorario.Location = New System.Drawing.Point(74, 68)
        Me.combofuncaohorario.Name = "combofuncaohorario"
        Me.combofuncaohorario.Size = New System.Drawing.Size(95, 21)
        Me.combofuncaohorario.TabIndex = 22
        '
        'txtnomehorario
        '
        Me.txtnomehorario.Location = New System.Drawing.Point(74, 40)
        Me.txtnomehorario.Name = "txtnomehorario"
        Me.txtnomehorario.Size = New System.Drawing.Size(95, 20)
        Me.txtnomehorario.TabIndex = 4
        '
        'txtnunhorario
        '
        Me.txtnunhorario.Location = New System.Drawing.Point(75, 16)
        Me.txtnunhorario.Name = "txtnunhorario"
        Me.txtnunhorario.Size = New System.Drawing.Size(32, 20)
        Me.txtnunhorario.TabIndex = 3
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.datagridlistahorario)
        Me.GroupBox1.Controls.Add(Me.combocategoriahorario)
        Me.GroupBox1.Controls.Add(Me.combofuncaohorario)
        Me.GroupBox1.Controls.Add(Me.txtnomehorario)
        Me.GroupBox1.Controls.Add(Me.txtnunhorario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblnumhorario)
        Me.GroupBox1.Location = New System.Drawing.Point(402, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 136)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'datagridlistahorario
        '
        Me.datagridlistahorario.BackgroundColor = System.Drawing.Color.White
        Me.datagridlistahorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridlistahorario.Location = New System.Drawing.Point(196, 21)
        Me.datagridlistahorario.Name = "datagridlistahorario"
        Me.datagridlistahorario.Size = New System.Drawing.Size(162, 98)
        Me.datagridlistahorario.TabIndex = 24
        '
        'datagridhorario
        '
        Me.datagridhorario.BackgroundColor = System.Drawing.Color.White
        Me.datagridhorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridhorario.Location = New System.Drawing.Point(12, 190)
        Me.datagridhorario.Name = "datagridhorario"
        Me.datagridhorario.Size = New System.Drawing.Size(770, 220)
        Me.datagridhorario.TabIndex = 24
        '
        'horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(794, 422)
        Me.Controls.Add(Me.datagridhorario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupesquisahorario)
        Me.Controls.Add(Me.btnsairhorario)
        Me.Controls.Add(Me.btnconsultarhorario)
        Me.Controls.Add(Me.btnpesquisarhorario)
        Me.Controls.Add(Me.btnguardarhorario)
        Me.Controls.Add(Me.btneliminarhorario)
        Me.Controls.Add(Me.btneditarhorario)
        Me.Controls.Add(Me.btnovohorario)
        Me.Controls.Add(Me.menuhorario)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuhorario
        Me.Name = "horario"
        Me.Text = " "
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupesquisahorario.ResumeLayout(False)
        Me.groupesquisahorario.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datagridlistahorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridhorario, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents groupesquisahorario As GroupBox
    Friend WithEvents lblnumutilizadorpesquisahorario As Label
    Friend WithEvents nomepesquisahorario As Label
    Friend WithEvents lblcategoriahorario As Label
    Friend WithEvents lblfuncaohorario As Label
    Friend WithEvents txtnumpesquisahorario As TextBox
    Friend WithEvents combopesquisafunçãohorario As ComboBox
    Friend WithEvents txtnomepesquisahorario As TextBox
    Friend WithEvents combopesquisahorário As ComboBox
    Friend WithEvents combocategoriahorario As ComboBox
    Friend WithEvents combofuncaohorario As ComboBox
    Friend WithEvents txtnomehorario As TextBox
    Friend WithEvents txtnunhorario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblnumhorario As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents datagridlistahorario As DataGridView
    Friend WithEvents datagridhorario As DataGridView
End Class
