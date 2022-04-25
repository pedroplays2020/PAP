<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disciplina
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnovodisciplina = New System.Windows.Forms.Button()
        Me.btneditardisciplina = New System.Windows.Forms.Button()
        Me.btneliminardisciplina = New System.Windows.Forms.Button()
        Me.btnguardardisciplina = New System.Windows.Forms.Button()
        Me.btnconsultardisciplina = New System.Windows.Forms.Button()
        Me.btncancelardisciplina = New System.Windows.Forms.Button()
        Me.btnsairdisciplina = New System.Windows.Forms.Button()
        Me.txtnumdisciplina = New System.Windows.Forms.TextBox()
        Me.lblnumdisciplina = New System.Windows.Forms.Label()
        Me.lblnomedisciplina = New System.Windows.Forms.Label()
        Me.lblobrigatorionomedisciplina = New System.Windows.Forms.Label()
        Me.datagridisciplina = New System.Windows.Forms.DataGridView()
        Me.txtnomedisciplina = New System.Windows.Forms.TextBox()
        Me.lblareadisciplina = New System.Windows.Forms.Label()
        Me.combareadisciplina = New System.Windows.Forms.ComboBox()
        Me.lblmsgdisciplina = New System.Windows.Forms.Label()
        Me.gbmgsdisciplina = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblObrigatorioArea = New System.Windows.Forms.Label()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.cmbareadisciplina = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.datagridisciplina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbmgsdisciplina.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(935, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnovodisciplina
        '
        Me.btnovodisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnovodisciplina.Location = New System.Drawing.Point(0, 0)
        Me.btnovodisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.btnovodisciplina.Name = "btnovodisciplina"
        Me.btnovodisciplina.Size = New System.Drawing.Size(100, 28)
        Me.btnovodisciplina.TabIndex = 1
        Me.btnovodisciplina.Text = "Novo"
        Me.btnovodisciplina.UseVisualStyleBackColor = True
        '
        'btneditardisciplina
        '
        Me.btneditardisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditardisciplina.Location = New System.Drawing.Point(97, 0)
        Me.btneditardisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.btneditardisciplina.Name = "btneditardisciplina"
        Me.btneditardisciplina.Size = New System.Drawing.Size(100, 28)
        Me.btneditardisciplina.TabIndex = 2
        Me.btneditardisciplina.Text = "Editar"
        Me.btneditardisciplina.UseVisualStyleBackColor = True
        '
        'btneliminardisciplina
        '
        Me.btneliminardisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminardisciplina.Location = New System.Drawing.Point(193, 0)
        Me.btneliminardisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.btneliminardisciplina.Name = "btneliminardisciplina"
        Me.btneliminardisciplina.Size = New System.Drawing.Size(100, 28)
        Me.btneliminardisciplina.TabIndex = 3
        Me.btneliminardisciplina.Text = "Eliminar"
        Me.btneliminardisciplina.UseVisualStyleBackColor = True
        '
        'btnguardardisciplina
        '
        Me.btnguardardisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardardisciplina.Location = New System.Drawing.Point(291, 0)
        Me.btnguardardisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguardardisciplina.Name = "btnguardardisciplina"
        Me.btnguardardisciplina.Size = New System.Drawing.Size(100, 28)
        Me.btnguardardisciplina.TabIndex = 4
        Me.btnguardardisciplina.Text = "Guardar"
        Me.btnguardardisciplina.UseVisualStyleBackColor = True
        '
        'btnconsultardisciplina
        '
        Me.btnconsultardisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultardisciplina.Location = New System.Drawing.Point(387, 0)
        Me.btnconsultardisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconsultardisciplina.Name = "btnconsultardisciplina"
        Me.btnconsultardisciplina.Size = New System.Drawing.Size(100, 28)
        Me.btnconsultardisciplina.TabIndex = 5
        Me.btnconsultardisciplina.Text = "Consultar"
        Me.btnconsultardisciplina.UseVisualStyleBackColor = True
        '
        'btncancelardisciplina
        '
        Me.btncancelardisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelardisciplina.Location = New System.Drawing.Point(483, 0)
        Me.btncancelardisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancelardisciplina.Name = "btncancelardisciplina"
        Me.btncancelardisciplina.Size = New System.Drawing.Size(108, 28)
        Me.btncancelardisciplina.TabIndex = 6
        Me.btncancelardisciplina.Text = "Cancelar"
        Me.btncancelardisciplina.UseVisualStyleBackColor = True
        '
        'btnsairdisciplina
        '
        Me.btnsairdisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairdisciplina.Location = New System.Drawing.Point(587, 0)
        Me.btnsairdisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsairdisciplina.Name = "btnsairdisciplina"
        Me.btnsairdisciplina.Size = New System.Drawing.Size(100, 28)
        Me.btnsairdisciplina.TabIndex = 7
        Me.btnsairdisciplina.Text = "Sair"
        Me.btnsairdisciplina.UseVisualStyleBackColor = True
        '
        'txtnumdisciplina
        '
        Me.txtnumdisciplina.Location = New System.Drawing.Point(84, 30)
        Me.txtnumdisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumdisciplina.Name = "txtnumdisciplina"
        Me.txtnumdisciplina.Size = New System.Drawing.Size(28, 22)
        Me.txtnumdisciplina.TabIndex = 10
        '
        'lblnumdisciplina
        '
        Me.lblnumdisciplina.AutoSize = True
        Me.lblnumdisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumdisciplina.ForeColor = System.Drawing.Color.Blue
        Me.lblnumdisciplina.Location = New System.Drawing.Point(45, 33)
        Me.lblnumdisciplina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnumdisciplina.Name = "lblnumdisciplina"
        Me.lblnumdisciplina.Size = New System.Drawing.Size(30, 17)
        Me.lblnumdisciplina.TabIndex = 11
        Me.lblnumdisciplina.Text = "Nº:"
        '
        'lblnomedisciplina
        '
        Me.lblnomedisciplina.AutoSize = True
        Me.lblnomedisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomedisciplina.ForeColor = System.Drawing.Color.Blue
        Me.lblnomedisciplina.Location = New System.Drawing.Point(18, 68)
        Me.lblnomedisciplina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnomedisciplina.Name = "lblnomedisciplina"
        Me.lblnomedisciplina.Size = New System.Drawing.Size(54, 17)
        Me.lblnomedisciplina.TabIndex = 13
        Me.lblnomedisciplina.Text = "Nome:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblobrigatorionomedisciplina
        '
        Me.lblobrigatorionomedisciplina.AutoSize = True
        Me.lblobrigatorionomedisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorionomedisciplina.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorionomedisciplina.Location = New System.Drawing.Point(266, 69)
        Me.lblobrigatorionomedisciplina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblobrigatorionomedisciplina.Name = "lblobrigatorionomedisciplina"
        Me.lblobrigatorionomedisciplina.Size = New System.Drawing.Size(96, 17)
        Me.lblobrigatorionomedisciplina.TabIndex = 14
        Me.lblobrigatorionomedisciplina.Text = "*Obrigatorio"
        Me.lblobrigatorionomedisciplina.Visible = False
        '
        'datagridisciplina
        '
        Me.datagridisciplina.BackgroundColor = System.Drawing.Color.White
        Me.datagridisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridisciplina.Location = New System.Drawing.Point(433, 63)
        Me.datagridisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.datagridisciplina.Name = "datagridisciplina"
        Me.datagridisciplina.ReadOnly = True
        Me.datagridisciplina.RowHeadersVisible = False
        Me.datagridisciplina.Size = New System.Drawing.Size(479, 306)
        Me.datagridisciplina.TabIndex = 15
        '
        'txtnomedisciplina
        '
        Me.txtnomedisciplina.Location = New System.Drawing.Point(84, 65)
        Me.txtnomedisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnomedisciplina.MaxLength = 20
        Me.txtnomedisciplina.Name = "txtnomedisciplina"
        Me.txtnomedisciplina.Size = New System.Drawing.Size(174, 22)
        Me.txtnomedisciplina.TabIndex = 16
        '
        'lblareadisciplina
        '
        Me.lblareadisciplina.AutoSize = True
        Me.lblareadisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblareadisciplina.ForeColor = System.Drawing.Color.Blue
        Me.lblareadisciplina.Location = New System.Drawing.Point(26, 107)
        Me.lblareadisciplina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblareadisciplina.Name = "lblareadisciplina"
        Me.lblareadisciplina.Size = New System.Drawing.Size(47, 17)
        Me.lblareadisciplina.TabIndex = 18
        Me.lblareadisciplina.Text = "Área:"
        '
        'combareadisciplina
        '
        Me.combareadisciplina.FormattingEnabled = True
        Me.combareadisciplina.Location = New System.Drawing.Point(84, 103)
        Me.combareadisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.combareadisciplina.Name = "combareadisciplina"
        Me.combareadisciplina.Size = New System.Drawing.Size(174, 24)
        Me.combareadisciplina.TabIndex = 19
        '
        'lblmsgdisciplina
        '
        Me.lblmsgdisciplina.AutoSize = True
        Me.lblmsgdisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsgdisciplina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmsgdisciplina.Location = New System.Drawing.Point(9, 31)
        Me.lblmsgdisciplina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmsgdisciplina.Name = "lblmsgdisciplina"
        Me.lblmsgdisciplina.Size = New System.Drawing.Size(57, 17)
        Me.lblmsgdisciplina.TabIndex = 1
        Me.lblmsgdisciplina.Text = "Label2"
        '
        'gbmgsdisciplina
        '
        Me.gbmgsdisciplina.Controls.Add(Me.lblmsgdisciplina)
        Me.gbmgsdisciplina.Location = New System.Drawing.Point(28, 295)
        Me.gbmgsdisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.gbmgsdisciplina.Name = "gbmgsdisciplina"
        Me.gbmgsdisciplina.Padding = New System.Windows.Forms.Padding(4)
        Me.gbmgsdisciplina.Size = New System.Drawing.Size(380, 74)
        Me.gbmgsdisciplina.TabIndex = 20
        Me.gbmgsdisciplina.TabStop = False
        Me.gbmgsdisciplina.Text = "MSG"
        Me.gbmgsdisciplina.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblObrigatorioArea)
        Me.GroupBox1.Controls.Add(Me.lblnumdisciplina)
        Me.GroupBox1.Controls.Add(Me.txtnumdisciplina)
        Me.GroupBox1.Controls.Add(Me.combareadisciplina)
        Me.GroupBox1.Controls.Add(Me.lblnomedisciplina)
        Me.GroupBox1.Controls.Add(Me.lblareadisciplina)
        Me.GroupBox1.Controls.Add(Me.lblobrigatorionomedisciplina)
        Me.GroupBox1.Controls.Add(Me.txtnomedisciplina)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 147)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados da Disciplina"
        '
        'lblObrigatorioArea
        '
        Me.lblObrigatorioArea.AutoSize = True
        Me.lblObrigatorioArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObrigatorioArea.ForeColor = System.Drawing.Color.Red
        Me.lblObrigatorioArea.Location = New System.Drawing.Point(267, 110)
        Me.lblObrigatorioArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObrigatorioArea.Name = "lblObrigatorioArea"
        Me.lblObrigatorioArea.Size = New System.Drawing.Size(96, 17)
        Me.lblObrigatorioArea.TabIndex = 20
        Me.lblObrigatorioArea.Text = "*Obrigatorio"
        Me.lblObrigatorioArea.Visible = False
        '
        'gbFiltro
        '
        Me.gbFiltro.Controls.Add(Me.cmbareadisciplina)
        Me.gbFiltro.Controls.Add(Me.Label1)
        Me.gbFiltro.Location = New System.Drawing.Point(28, 217)
        Me.gbFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Padding = New System.Windows.Forms.Padding(4)
        Me.gbFiltro.Size = New System.Drawing.Size(380, 74)
        Me.gbFiltro.TabIndex = 21
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        Me.gbFiltro.Visible = False
        '
        'cmbareadisciplina
        '
        Me.cmbareadisciplina.FormattingEnabled = True
        Me.cmbareadisciplina.Location = New System.Drawing.Point(84, 30)
        Me.cmbareadisciplina.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbareadisciplina.Name = "cmbareadisciplina"
        Me.cmbareadisciplina.Size = New System.Drawing.Size(174, 24)
        Me.cmbareadisciplina.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(28, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Área:"
        '
        'Disciplina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(935, 401)
        Me.Controls.Add(Me.gbFiltro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbmgsdisciplina)
        Me.Controls.Add(Me.datagridisciplina)
        Me.Controls.Add(Me.btnsairdisciplina)
        Me.Controls.Add(Me.btncancelardisciplina)
        Me.Controls.Add(Me.btnconsultardisciplina)
        Me.Controls.Add(Me.btnguardardisciplina)
        Me.Controls.Add(Me.btneliminardisciplina)
        Me.Controls.Add(Me.btneditardisciplina)
        Me.Controls.Add(Me.btnovodisciplina)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Disciplina"
        Me.Text = "v"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.datagridisciplina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbmgsdisciplina.ResumeLayout(False)
        Me.gbmgsdisciplina.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnovodisciplina As System.Windows.Forms.Button
    Friend WithEvents btneditardisciplina As System.Windows.Forms.Button
    Friend WithEvents btneliminardisciplina As System.Windows.Forms.Button
    Friend WithEvents btnguardardisciplina As System.Windows.Forms.Button
    Friend WithEvents btnconsultardisciplina As System.Windows.Forms.Button
    Friend WithEvents btncancelardisciplina As System.Windows.Forms.Button
    Friend WithEvents btnsairdisciplina As System.Windows.Forms.Button
    Friend WithEvents txtnumdisciplina As System.Windows.Forms.TextBox
    Friend WithEvents lblnumdisciplina As System.Windows.Forms.Label
    Friend WithEvents lblnomedisciplina As System.Windows.Forms.Label
    Friend WithEvents lblobrigatorionomedisciplina As System.Windows.Forms.Label
    Friend WithEvents datagridisciplina As System.Windows.Forms.DataGridView
    Friend WithEvents txtnomedisciplina As System.Windows.Forms.TextBox
    Friend WithEvents lblareadisciplina As System.Windows.Forms.Label
    Friend WithEvents combareadisciplina As System.Windows.Forms.ComboBox
    Friend WithEvents lblmsgdisciplina As System.Windows.Forms.Label
    Friend WithEvents gbmgsdisciplina As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblObrigatorioArea As System.Windows.Forms.Label
    Friend WithEvents gbFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents cmbareadisciplina As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
