<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tempo
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
        Me.lblnumtempo = New System.Windows.Forms.Label()
        Me.lblintervalotempo = New System.Windows.Forms.Label()
        Me.txtintervalodetempo = New System.Windows.Forms.TextBox()
        Me.txttempo = New System.Windows.Forms.TextBox()
        Me.Menutempo = New System.Windows.Forms.MenuStrip()
        Me.btnnovotempo = New System.Windows.Forms.Button()
        Me.btneditartempo = New System.Windows.Forms.Button()
        Me.btnguardartempo = New System.Windows.Forms.Button()
        Me.btneliminartempo = New System.Windows.Forms.Button()
        Me.lblobrigatoriointervalodetempo = New System.Windows.Forms.Label()
        Me.btnsairtempo = New System.Windows.Forms.Button()
        Me.btnconsultartempo = New System.Windows.Forms.Button()
        Me.datagridtempo = New System.Windows.Forms.DataGridView()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbltempoencontrado = New System.Windows.Forms.Label()
        Me.txttempoencontrado = New System.Windows.Forms.TextBox()
        Me.btncancelartempo = New System.Windows.Forms.Button()
        Me.lblmsgtempo = New System.Windows.Forms.Label()
        Me.gbmsgtempo = New System.Windows.Forms.GroupBox()
        Me.gbTempos = New System.Windows.Forms.GroupBox()
        CType(Me.datagridtempo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbmsgtempo.SuspendLayout()
        Me.gbTempos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblnumtempo
        '
        Me.lblnumtempo.AutoSize = True
        Me.lblnumtempo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblnumtempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumtempo.ForeColor = System.Drawing.Color.Blue
        Me.lblnumtempo.Location = New System.Drawing.Point(69, 19)
        Me.lblnumtempo.Name = "lblnumtempo"
        Me.lblnumtempo.Size = New System.Drawing.Size(62, 17)
        Me.lblnumtempo.TabIndex = 0
        Me.lblnumtempo.Text = "Tempo:"
        '
        'lblintervalotempo
        '
        Me.lblintervalotempo.AutoSize = True
        Me.lblintervalotempo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblintervalotempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblintervalotempo.ForeColor = System.Drawing.Color.Blue
        Me.lblintervalotempo.Location = New System.Drawing.Point(6, 59)
        Me.lblintervalotempo.Name = "lblintervalotempo"
        Me.lblintervalotempo.Size = New System.Drawing.Size(125, 17)
        Me.lblintervalotempo.TabIndex = 1
        Me.lblintervalotempo.Text = "Intervalo tempo:"
        '
        'txtintervalodetempo
        '
        Me.txtintervalodetempo.Enabled = False
        Me.txtintervalodetempo.Location = New System.Drawing.Point(151, 56)
        Me.txtintervalodetempo.Name = "txtintervalodetempo"
        Me.txtintervalodetempo.Size = New System.Drawing.Size(88, 23)
        Me.txtintervalodetempo.TabIndex = 2
        '
        'txttempo
        '
        Me.txttempo.Enabled = False
        Me.txttempo.Location = New System.Drawing.Point(152, 16)
        Me.txttempo.Name = "txttempo"
        Me.txttempo.Size = New System.Drawing.Size(31, 23)
        Me.txttempo.TabIndex = 3
        '
        'Menutempo
        '
        Me.Menutempo.Location = New System.Drawing.Point(0, 0)
        Me.Menutempo.Name = "Menutempo"
        Me.Menutempo.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.Menutempo.Size = New System.Drawing.Size(619, 24)
        Me.Menutempo.TabIndex = 4
        Me.Menutempo.Text = "Menutempo"
        '
        'btnnovotempo
        '
        Me.btnnovotempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnovotempo.ForeColor = System.Drawing.Color.Black
        Me.btnnovotempo.Location = New System.Drawing.Point(0, 0)
        Me.btnnovotempo.Name = "btnnovotempo"
        Me.btnnovotempo.Size = New System.Drawing.Size(77, 23)
        Me.btnnovotempo.TabIndex = 5
        Me.btnnovotempo.Text = "Novo"
        Me.btnnovotempo.UseVisualStyleBackColor = True
        '
        'btneditartempo
        '
        Me.btneditartempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditartempo.ForeColor = System.Drawing.Color.Black
        Me.btneditartempo.Location = New System.Drawing.Point(74, 0)
        Me.btneditartempo.Name = "btneditartempo"
        Me.btneditartempo.Size = New System.Drawing.Size(75, 23)
        Me.btneditartempo.TabIndex = 7
        Me.btneditartempo.Text = "Editar"
        Me.btneditartempo.UseVisualStyleBackColor = True
        '
        'btnguardartempo
        '
        Me.btnguardartempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardartempo.ForeColor = System.Drawing.Color.Black
        Me.btnguardartempo.Location = New System.Drawing.Point(214, 0)
        Me.btnguardartempo.Name = "btnguardartempo"
        Me.btnguardartempo.Size = New System.Drawing.Size(73, 23)
        Me.btnguardartempo.TabIndex = 9
        Me.btnguardartempo.Text = "Guardar"
        Me.btnguardartempo.UseVisualStyleBackColor = True
        '
        'btneliminartempo
        '
        Me.btneliminartempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminartempo.ForeColor = System.Drawing.Color.Black
        Me.btneliminartempo.Location = New System.Drawing.Point(146, 0)
        Me.btneliminartempo.Name = "btneliminartempo"
        Me.btneliminartempo.Size = New System.Drawing.Size(74, 23)
        Me.btneliminartempo.TabIndex = 6
        Me.btneliminartempo.Text = "Eliminar"
        Me.btneliminartempo.UseVisualStyleBackColor = True
        '
        'lblobrigatoriointervalodetempo
        '
        Me.lblobrigatoriointervalodetempo.AutoSize = True
        Me.lblobrigatoriointervalodetempo.Enabled = False
        Me.lblobrigatoriointervalodetempo.Location = New System.Drawing.Point(243, 59)
        Me.lblobrigatoriointervalodetempo.Name = "lblobrigatoriointervalodetempo"
        Me.lblobrigatoriointervalodetempo.Size = New System.Drawing.Size(93, 17)
        Me.lblobrigatoriointervalodetempo.TabIndex = 12
        Me.lblobrigatoriointervalodetempo.Text = "*obrigatório"
        '
        'btnsairtempo
        '
        Me.btnsairtempo.ForeColor = System.Drawing.Color.Black
        Me.btnsairtempo.Location = New System.Drawing.Point(430, 0)
        Me.btnsairtempo.Name = "btnsairtempo"
        Me.btnsairtempo.Size = New System.Drawing.Size(75, 23)
        Me.btnsairtempo.TabIndex = 10
        Me.btnsairtempo.Text = "Sair"
        Me.btnsairtempo.UseVisualStyleBackColor = True
        '
        'btnconsultartempo
        '
        Me.btnconsultartempo.ForeColor = System.Drawing.Color.Black
        Me.btnconsultartempo.Location = New System.Drawing.Point(285, 0)
        Me.btnconsultartempo.Name = "btnconsultartempo"
        Me.btnconsultartempo.Size = New System.Drawing.Size(75, 23)
        Me.btnconsultartempo.TabIndex = 14
        Me.btnconsultartempo.Text = "Consultar"
        Me.btnconsultartempo.UseVisualStyleBackColor = True
        '
        'datagridtempo
        '
        Me.datagridtempo.AllowUserToAddRows = False
        Me.datagridtempo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridtempo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.Descrição})
        Me.datagridtempo.Location = New System.Drawing.Point(387, 46)
        Me.datagridtempo.Name = "datagridtempo"
        Me.datagridtempo.ReadOnly = True
        Me.datagridtempo.RowHeadersVisible = False
        Me.datagridtempo.Size = New System.Drawing.Size(205, 240)
        Me.datagridtempo.TabIndex = 15
        '
        'Código
        '
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.ReadOnly = True
        '
        'Descrição
        '
        Me.Descrição.HeaderText = "Descrição"
        Me.Descrição.Name = "Descrição"
        Me.Descrição.ReadOnly = True
        '
        'lbltempoencontrado
        '
        Me.lbltempoencontrado.AutoSize = True
        Me.lbltempoencontrado.ForeColor = System.Drawing.Color.Blue
        Me.lbltempoencontrado.Location = New System.Drawing.Point(6, 96)
        Me.lbltempoencontrado.Name = "lbltempoencontrado"
        Me.lbltempoencontrado.Size = New System.Drawing.Size(144, 17)
        Me.lbltempoencontrado.TabIndex = 16
        Me.lbltempoencontrado.Text = "tempo encontrado:"
        '
        'txttempoencontrado
        '
        Me.txttempoencontrado.Enabled = False
        Me.txttempoencontrado.Location = New System.Drawing.Point(149, 93)
        Me.txttempoencontrado.Name = "txttempoencontrado"
        Me.txttempoencontrado.Size = New System.Drawing.Size(90, 23)
        Me.txttempoencontrado.TabIndex = 17
        '
        'btncancelartempo
        '
        Me.btncancelartempo.ForeColor = System.Drawing.Color.Black
        Me.btncancelartempo.Location = New System.Drawing.Point(357, 0)
        Me.btncancelartempo.Name = "btncancelartempo"
        Me.btncancelartempo.Size = New System.Drawing.Size(75, 23)
        Me.btncancelartempo.TabIndex = 18
        Me.btncancelartempo.Text = "Cancelar"
        Me.btncancelartempo.UseVisualStyleBackColor = True
        Me.btncancelartempo.Visible = False
        '
        'lblmsgtempo
        '
        Me.lblmsgtempo.AutoSize = True
        Me.lblmsgtempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsgtempo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmsgtempo.Location = New System.Drawing.Point(16, 28)
        Me.lblmsgtempo.Name = "lblmsgtempo"
        Me.lblmsgtempo.Size = New System.Drawing.Size(52, 18)
        Me.lblmsgtempo.TabIndex = 0
        Me.lblmsgtempo.Text = "label1"
        '
        'gbmsgtempo
        '
        Me.gbmsgtempo.Controls.Add(Me.lblmsgtempo)
        Me.gbmsgtempo.Location = New System.Drawing.Point(14, 222)
        Me.gbmsgtempo.Name = "gbmsgtempo"
        Me.gbmsgtempo.Size = New System.Drawing.Size(346, 64)
        Me.gbmsgtempo.TabIndex = 22
        Me.gbmsgtempo.TabStop = False
        Me.gbmsgtempo.Text = "Mensagem"
        '
        'gbTempos
        '
        Me.gbTempos.Controls.Add(Me.lblnumtempo)
        Me.gbTempos.Controls.Add(Me.lblintervalotempo)
        Me.gbTempos.Controls.Add(Me.txtintervalodetempo)
        Me.gbTempos.Controls.Add(Me.txttempoencontrado)
        Me.gbTempos.Controls.Add(Me.txttempo)
        Me.gbTempos.Controls.Add(Me.lbltempoencontrado)
        Me.gbTempos.Controls.Add(Me.lblobrigatoriointervalodetempo)
        Me.gbTempos.Location = New System.Drawing.Point(14, 46)
        Me.gbTempos.Name = "gbTempos"
        Me.gbTempos.Size = New System.Drawing.Size(346, 154)
        Me.gbTempos.TabIndex = 23
        Me.gbTempos.TabStop = False
        Me.gbTempos.Text = "Tempos Letivos"
        '
        'tempo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(619, 325)
        Me.Controls.Add(Me.gbTempos)
        Me.Controls.Add(Me.gbmsgtempo)
        Me.Controls.Add(Me.btncancelartempo)
        Me.Controls.Add(Me.datagridtempo)
        Me.Controls.Add(Me.btnconsultartempo)
        Me.Controls.Add(Me.btnsairtempo)
        Me.Controls.Add(Me.btnguardartempo)
        Me.Controls.Add(Me.btneditartempo)
        Me.Controls.Add(Me.btneliminartempo)
        Me.Controls.Add(Me.btnnovotempo)
        Me.Controls.Add(Me.Menutempo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.Menutempo
        Me.Name = "tempo"
        Me.Text = "tempo"
        CType(Me.datagridtempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbmsgtempo.ResumeLayout(False)
        Me.gbmsgtempo.PerformLayout()
        Me.gbTempos.ResumeLayout(False)
        Me.gbTempos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnumtempo As System.Windows.Forms.Label
    Friend WithEvents lblintervalotempo As System.Windows.Forms.Label
    Friend WithEvents txtintervalodetempo As System.Windows.Forms.TextBox
    Friend WithEvents txttempo As System.Windows.Forms.TextBox
    Friend WithEvents Menutempo As System.Windows.Forms.MenuStrip
    Friend WithEvents btnnovotempo As System.Windows.Forms.Button
    Friend WithEvents btneditartempo As System.Windows.Forms.Button
    Friend WithEvents btnguardartempo As System.Windows.Forms.Button
    Friend WithEvents btneliminartempo As System.Windows.Forms.Button
    Friend WithEvents lblobrigatoriointervalodetempo As Label
    Friend WithEvents btnsairtempo As Button
    Friend WithEvents btnconsultartempo As System.Windows.Forms.Button
    Friend WithEvents datagridtempo As System.Windows.Forms.DataGridView
    Friend WithEvents lbltempoencontrado As System.Windows.Forms.Label
    Friend WithEvents txttempoencontrado As System.Windows.Forms.TextBox
    Friend WithEvents btncancelartempo As System.Windows.Forms.Button
    Friend WithEvents Código As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descrição As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblmsgtempo As System.Windows.Forms.Label
    Friend WithEvents gbmsgtempo As System.Windows.Forms.GroupBox
    Friend WithEvents gbTempos As System.Windows.Forms.GroupBox
End Class
