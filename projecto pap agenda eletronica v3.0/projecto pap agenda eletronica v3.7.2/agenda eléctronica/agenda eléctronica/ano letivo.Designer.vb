<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ano_letivo
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
        Me.Menuregistos = New System.Windows.Forms.MenuStrip()
        Me.btnovoano = New System.Windows.Forms.Button()
        Me.btneditarano = New System.Windows.Forms.Button()
        Me.btneliminarano = New System.Windows.Forms.Button()
        Me.btnguardarano = New System.Windows.Forms.Button()
        Me.btnconsultarano = New System.Windows.Forms.Button()
        Me.btncancelarano = New System.Windows.Forms.Button()
        Me.btnsairano = New System.Windows.Forms.Button()
        Me.lblnumano = New System.Windows.Forms.Label()
        Me.lblanoletivo = New System.Windows.Forms.Label()
        Me.txtnunanoletivo = New System.Windows.Forms.TextBox()
        Me.datagridanoletivo = New System.Windows.Forms.DataGridView()
        Me.lblobrigatorioano = New System.Windows.Forms.Label()
        Me.txtconsultaanoletivo = New System.Windows.Forms.TextBox()
        Me.lbconsulta = New System.Windows.Forms.Label()
        Me.gbAnoLetivo = New System.Windows.Forms.GroupBox()
        Me.lblObrigatorioEstado = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtanoletivo = New System.Windows.Forms.TextBox()
        CType(Me.datagridanoletivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAnoLetivo.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menuregistos
        '
        Me.Menuregistos.Location = New System.Drawing.Point(0, 0)
        Me.Menuregistos.Name = "Menuregistos"
        Me.Menuregistos.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.Menuregistos.Size = New System.Drawing.Size(592, 24)
        Me.Menuregistos.TabIndex = 0
        Me.Menuregistos.Text = "MenuStrip1"
        '
        'btnovoano
        '
        Me.btnovoano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnovoano.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnovoano.Location = New System.Drawing.Point(0, 0)
        Me.btnovoano.Name = "btnovoano"
        Me.btnovoano.Size = New System.Drawing.Size(87, 23)
        Me.btnovoano.TabIndex = 1
        Me.btnovoano.Text = "Novo"
        Me.btnovoano.UseVisualStyleBackColor = True
        '
        'btneditarano
        '
        Me.btneditarano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarano.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btneditarano.Location = New System.Drawing.Point(83, 0)
        Me.btneditarano.Name = "btneditarano"
        Me.btneditarano.Size = New System.Drawing.Size(87, 23)
        Me.btneditarano.TabIndex = 2
        Me.btneditarano.Text = "Editar"
        Me.btneditarano.UseVisualStyleBackColor = True
        '
        'btneliminarano
        '
        Me.btneliminarano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarano.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btneliminarano.Location = New System.Drawing.Point(166, 0)
        Me.btneliminarano.Name = "btneliminarano"
        Me.btneliminarano.Size = New System.Drawing.Size(87, 23)
        Me.btneliminarano.TabIndex = 3
        Me.btneliminarano.Text = "Eliminar"
        Me.btneliminarano.UseVisualStyleBackColor = True
        '
        'btnguardarano
        '
        Me.btnguardarano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarano.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardarano.Location = New System.Drawing.Point(250, 0)
        Me.btnguardarano.Name = "btnguardarano"
        Me.btnguardarano.Size = New System.Drawing.Size(87, 23)
        Me.btnguardarano.TabIndex = 4
        Me.btnguardarano.Text = "Guardar"
        Me.btnguardarano.UseVisualStyleBackColor = True
        '
        'btnconsultarano
        '
        Me.btnconsultarano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultarano.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnconsultarano.Location = New System.Drawing.Point(334, 0)
        Me.btnconsultarano.Name = "btnconsultarano"
        Me.btnconsultarano.Size = New System.Drawing.Size(87, 23)
        Me.btnconsultarano.TabIndex = 5
        Me.btnconsultarano.Text = "Filtrar"
        Me.btnconsultarano.UseVisualStyleBackColor = True
        '
        'btncancelarano
        '
        Me.btncancelarano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarano.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelarano.Location = New System.Drawing.Point(420, 0)
        Me.btncancelarano.Name = "btncancelarano"
        Me.btncancelarano.Size = New System.Drawing.Size(87, 23)
        Me.btncancelarano.TabIndex = 6
        Me.btncancelarano.Text = "Cancelar"
        Me.btncancelarano.UseVisualStyleBackColor = True
        '
        'btnsairano
        '
        Me.btnsairano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairano.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnsairano.Location = New System.Drawing.Point(504, 0)
        Me.btnsairano.Name = "btnsairano"
        Me.btnsairano.Size = New System.Drawing.Size(87, 23)
        Me.btnsairano.TabIndex = 7
        Me.btnsairano.Text = "Sair"
        Me.btnsairano.UseVisualStyleBackColor = True
        '
        'lblnumano
        '
        Me.lblnumano.AutoSize = True
        Me.lblnumano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumano.ForeColor = System.Drawing.Color.Blue
        Me.lblnumano.Location = New System.Drawing.Point(51, 32)
        Me.lblnumano.Name = "lblnumano"
        Me.lblnumano.Size = New System.Drawing.Size(25, 13)
        Me.lblnumano.TabIndex = 8
        Me.lblnumano.Text = "Nº:"
        '
        'lblanoletivo
        '
        Me.lblanoletivo.AutoSize = True
        Me.lblanoletivo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblanoletivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanoletivo.ForeColor = System.Drawing.Color.Blue
        Me.lblanoletivo.Location = New System.Drawing.Point(43, 64)
        Me.lblanoletivo.Name = "lblanoletivo"
        Me.lblanoletivo.Size = New System.Drawing.Size(33, 13)
        Me.lblanoletivo.TabIndex = 9
        Me.lblanoletivo.Text = "Ano:"
        '
        'txtnunanoletivo
        '
        Me.txtnunanoletivo.Location = New System.Drawing.Point(87, 29)
        Me.txtnunanoletivo.Name = "txtnunanoletivo"
        Me.txtnunanoletivo.Size = New System.Drawing.Size(45, 20)
        Me.txtnunanoletivo.TabIndex = 1
        '
        'datagridanoletivo
        '
        Me.datagridanoletivo.BackgroundColor = System.Drawing.Color.White
        Me.datagridanoletivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridanoletivo.Location = New System.Drawing.Point(334, 47)
        Me.datagridanoletivo.Name = "datagridanoletivo"
        Me.datagridanoletivo.ReadOnly = True
        Me.datagridanoletivo.RowHeadersVisible = False
        Me.datagridanoletivo.Size = New System.Drawing.Size(247, 288)
        Me.datagridanoletivo.TabIndex = 12
        '
        'lblobrigatorioano
        '
        Me.lblobrigatorioano.AutoSize = True
        Me.lblobrigatorioano.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorioano.Location = New System.Drawing.Point(182, 64)
        Me.lblobrigatorioano.Name = "lblobrigatorioano"
        Me.lblobrigatorioano.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorioano.TabIndex = 13
        Me.lblobrigatorioano.Text = "*Obrigatório"
        '
        'txtconsultaanoletivo
        '
        Me.txtconsultaanoletivo.Location = New System.Drawing.Point(90, 27)
        Me.txtconsultaanoletivo.Name = "txtconsultaanoletivo"
        Me.txtconsultaanoletivo.Size = New System.Drawing.Size(88, 20)
        Me.txtconsultaanoletivo.TabIndex = 3
        Me.txtconsultaanoletivo.Visible = False
        '
        'lbconsulta
        '
        Me.lbconsulta.AutoSize = True
        Me.lbconsulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbconsulta.Location = New System.Drawing.Point(8, 30)
        Me.lbconsulta.Name = "lbconsulta"
        Me.lbconsulta.Size = New System.Drawing.Size(60, 13)
        Me.lbconsulta.TabIndex = 16
        Me.lbconsulta.Text = "Consulta:"
        Me.lbconsulta.Visible = False
        '
        'gbAnoLetivo
        '
        Me.gbAnoLetivo.Controls.Add(Me.txtanoletivo)
        Me.gbAnoLetivo.Controls.Add(Me.lblObrigatorioEstado)
        Me.gbAnoLetivo.Controls.Add(Me.cmbEstado)
        Me.gbAnoLetivo.Controls.Add(Me.lblEstado)
        Me.gbAnoLetivo.Controls.Add(Me.lblnumano)
        Me.gbAnoLetivo.Controls.Add(Me.lblanoletivo)
        Me.gbAnoLetivo.Controls.Add(Me.txtnunanoletivo)
        Me.gbAnoLetivo.Controls.Add(Me.lblobrigatorioano)
        Me.gbAnoLetivo.Location = New System.Drawing.Point(23, 47)
        Me.gbAnoLetivo.Name = "gbAnoLetivo"
        Me.gbAnoLetivo.Size = New System.Drawing.Size(298, 143)
        Me.gbAnoLetivo.TabIndex = 17
        Me.gbAnoLetivo.TabStop = False
        Me.gbAnoLetivo.Text = "Ano Letivo"
        '
        'lblObrigatorioEstado
        '
        Me.lblObrigatorioEstado.AutoSize = True
        Me.lblObrigatorioEstado.ForeColor = System.Drawing.Color.Red
        Me.lblObrigatorioEstado.Location = New System.Drawing.Point(182, 104)
        Me.lblObrigatorioEstado.Name = "lblObrigatorioEstado"
        Me.lblObrigatorioEstado.Size = New System.Drawing.Size(74, 13)
        Me.lblObrigatorioEstado.TabIndex = 19
        Me.lblObrigatorioEstado.Text = "*Obrigatório"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Ativo", "Desativo"})
        Me.cmbEstado.Location = New System.Drawing.Point(87, 96)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(89, 21)
        Me.cmbEstado.TabIndex = 18
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(18, 99)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(50, 13)
        Me.lblEstado.TabIndex = 17
        Me.lblEstado.Text = "Estado:"
        '
        'gbFiltro
        '
        Me.gbFiltro.Controls.Add(Me.lbconsulta)
        Me.gbFiltro.Controls.Add(Me.txtconsultaanoletivo)
        Me.gbFiltro.Location = New System.Drawing.Point(23, 196)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(298, 65)
        Me.gbFiltro.TabIndex = 18
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.lblInfo)
        Me.gbInfo.Location = New System.Drawing.Point(23, 268)
        Me.gbInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.gbInfo.Size = New System.Drawing.Size(298, 71)
        Me.gbInfo.TabIndex = 95
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Mensagem"
        Me.gbInfo.Visible = False
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(13, 19)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(277, 44)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "Label2"
        '
        'txtanoletivo
        '
        Me.txtanoletivo.Enabled = False
        Me.txtanoletivo.Location = New System.Drawing.Point(87, 61)
        Me.txtanoletivo.Name = "txtanoletivo"
        Me.txtanoletivo.Size = New System.Drawing.Size(89, 20)
        Me.txtanoletivo.TabIndex = 20
        '
        'ano_letivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(592, 347)
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.gbFiltro)
        Me.Controls.Add(Me.gbAnoLetivo)
        Me.Controls.Add(Me.datagridanoletivo)
        Me.Controls.Add(Me.btnsairano)
        Me.Controls.Add(Me.btncancelarano)
        Me.Controls.Add(Me.btnconsultarano)
        Me.Controls.Add(Me.btnguardarano)
        Me.Controls.Add(Me.btneliminarano)
        Me.Controls.Add(Me.btneditarano)
        Me.Controls.Add(Me.btnovoano)
        Me.Controls.Add(Me.Menuregistos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.Menuregistos
        Me.Name = "ano_letivo"
        Me.Text = "ano_letivo"
        CType(Me.datagridanoletivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAnoLetivo.ResumeLayout(False)
        Me.gbAnoLetivo.PerformLayout()
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.gbInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menuregistos As System.Windows.Forms.MenuStrip
    Friend WithEvents btnovoano As System.Windows.Forms.Button
    Friend WithEvents btneditarano As System.Windows.Forms.Button
    Friend WithEvents btneliminarano As System.Windows.Forms.Button
    Friend WithEvents btnguardarano As System.Windows.Forms.Button
    Friend WithEvents btnconsultarano As System.Windows.Forms.Button
    Friend WithEvents btncancelarano As System.Windows.Forms.Button
    Friend WithEvents btnsairano As System.Windows.Forms.Button
    Friend WithEvents lblnumano As System.Windows.Forms.Label
    Friend WithEvents lblanoletivo As System.Windows.Forms.Label
    Friend WithEvents txtnunanoletivo As System.Windows.Forms.TextBox
    Friend WithEvents datagridanoletivo As System.Windows.Forms.DataGridView
    Friend WithEvents lblobrigatorioano As System.Windows.Forms.Label
    Friend WithEvents txtconsultaanoletivo As System.Windows.Forms.TextBox
    Friend WithEvents lbconsulta As System.Windows.Forms.Label
    Friend WithEvents gbAnoLetivo As System.Windows.Forms.GroupBox
    Friend WithEvents lblObrigatorioEstado As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents gbFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents txtanoletivo As System.Windows.Forms.TextBox
End Class
