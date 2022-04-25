<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class blocoSala
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
        Me.btneliminarblocosala = New System.Windows.Forms.Button()
        Me.btncancelarblocosala = New System.Windows.Forms.Button()
        Me.lblobrigatorionomebloco = New System.Windows.Forms.Label()
        Me.txtnomebloco = New System.Windows.Forms.TextBox()
        Me.btnsairblocosala = New System.Windows.Forms.Button()
        Me.btnconsultarblocosala = New System.Windows.Forms.Button()
        Me.btnguardarblocosala = New System.Windows.Forms.Button()
        Me.btneditarblocosala = New System.Windows.Forms.Button()
        Me.btnnovoblocosala = New System.Windows.Forms.Button()
        Me.txtbloconum = New System.Windows.Forms.TextBox()
        Me.lblbloco = New System.Windows.Forms.Label()
        Me.lblfuncaonum = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpBloco = New System.Windows.Forms.TabPage()
        Me.gbBloco = New System.Windows.Forms.GroupBox()
        Me.DataGridBloco = New System.Windows.Forms.DataGridView()
        Me.tpSala = New System.Windows.Forms.TabPage()
        Me.gbsala = New System.Windows.Forms.GroupBox()
        Me.txtBloco = New System.Windows.Forms.TextBox()
        Me.comblocosala = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datagridsala = New System.Windows.Forms.DataGridView()
        Me.lblsala = New System.Windows.Forms.Label()
        Me.lblobrigatorionomesala = New System.Windows.Forms.Label()
        Me.txtnumsala = New System.Windows.Forms.TextBox()
        Me.lblnumsala = New System.Windows.Forms.Label()
        Me.txtnomesala = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tpBloco.SuspendLayout()
        Me.gbBloco.SuspendLayout()
        CType(Me.DataGridBloco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSala.SuspendLayout()
        Me.gbsala.SuspendLayout()
        CType(Me.datagridsala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btneliminarblocosala
        '
        Me.btneliminarblocosala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarblocosala.Location = New System.Drawing.Point(152, 0)
        Me.btneliminarblocosala.Name = "btneliminarblocosala"
        Me.btneliminarblocosala.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarblocosala.TabIndex = 33
        Me.btneliminarblocosala.Text = "Eliminar"
        Me.btneliminarblocosala.UseVisualStyleBackColor = True
        '
        'btncancelarblocosala
        '
        Me.btncancelarblocosala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarblocosala.Location = New System.Drawing.Point(375, 0)
        Me.btncancelarblocosala.Name = "btncancelarblocosala"
        Me.btncancelarblocosala.Size = New System.Drawing.Size(75, 23)
        Me.btncancelarblocosala.TabIndex = 32
        Me.btncancelarblocosala.Text = "Cancelar"
        Me.btncancelarblocosala.UseVisualStyleBackColor = True
        '
        'lblobrigatorionomebloco
        '
        Me.lblobrigatorionomebloco.AutoSize = True
        Me.lblobrigatorionomebloco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorionomebloco.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorionomebloco.Location = New System.Drawing.Point(248, 15)
        Me.lblobrigatorionomebloco.Name = "lblobrigatorionomebloco"
        Me.lblobrigatorionomebloco.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorionomebloco.TabIndex = 30
        Me.lblobrigatorionomebloco.Text = "*Obrigatório"
        Me.lblobrigatorionomebloco.Visible = False
        '
        'txtnomebloco
        '
        Me.txtnomebloco.Enabled = False
        Me.txtnomebloco.Location = New System.Drawing.Point(172, 12)
        Me.txtnomebloco.Name = "txtnomebloco"
        Me.txtnomebloco.Size = New System.Drawing.Size(62, 20)
        Me.txtnomebloco.TabIndex = 28
        '
        'btnsairblocosala
        '
        Me.btnsairblocosala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairblocosala.Location = New System.Drawing.Point(452, 1)
        Me.btnsairblocosala.Name = "btnsairblocosala"
        Me.btnsairblocosala.Size = New System.Drawing.Size(75, 23)
        Me.btnsairblocosala.TabIndex = 27
        Me.btnsairblocosala.Text = "sair"
        Me.btnsairblocosala.UseVisualStyleBackColor = True
        '
        'btnconsultarblocosala
        '
        Me.btnconsultarblocosala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultarblocosala.Location = New System.Drawing.Point(300, 0)
        Me.btnconsultarblocosala.Name = "btnconsultarblocosala"
        Me.btnconsultarblocosala.Size = New System.Drawing.Size(75, 23)
        Me.btnconsultarblocosala.TabIndex = 26
        Me.btnconsultarblocosala.Text = "consultar"
        Me.btnconsultarblocosala.UseVisualStyleBackColor = True
        '
        'btnguardarblocosala
        '
        Me.btnguardarblocosala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarblocosala.Location = New System.Drawing.Point(228, 0)
        Me.btnguardarblocosala.Name = "btnguardarblocosala"
        Me.btnguardarblocosala.Size = New System.Drawing.Size(75, 23)
        Me.btnguardarblocosala.TabIndex = 25
        Me.btnguardarblocosala.Text = "Guardar"
        Me.btnguardarblocosala.UseVisualStyleBackColor = True
        '
        'btneditarblocosala
        '
        Me.btneditarblocosala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarblocosala.Location = New System.Drawing.Point(77, 0)
        Me.btneditarblocosala.Name = "btneditarblocosala"
        Me.btneditarblocosala.Size = New System.Drawing.Size(75, 23)
        Me.btneditarblocosala.TabIndex = 24
        Me.btneditarblocosala.Text = "Editar"
        Me.btneditarblocosala.UseVisualStyleBackColor = True
        '
        'btnnovoblocosala
        '
        Me.btnnovoblocosala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnovoblocosala.Location = New System.Drawing.Point(2, 0)
        Me.btnnovoblocosala.Name = "btnnovoblocosala"
        Me.btnnovoblocosala.Size = New System.Drawing.Size(75, 23)
        Me.btnnovoblocosala.TabIndex = 23
        Me.btnnovoblocosala.Text = "Novo"
        Me.btnnovoblocosala.UseVisualStyleBackColor = True
        '
        'txtbloconum
        '
        Me.txtbloconum.Enabled = False
        Me.txtbloconum.Location = New System.Drawing.Point(69, 12)
        Me.txtbloconum.Name = "txtbloconum"
        Me.txtbloconum.Size = New System.Drawing.Size(36, 20)
        Me.txtbloconum.TabIndex = 21
        '
        'lblbloco
        '
        Me.lblbloco.AutoSize = True
        Me.lblbloco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbloco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblbloco.Location = New System.Drawing.Point(123, 15)
        Me.lblbloco.Name = "lblbloco"
        Me.lblbloco.Size = New System.Drawing.Size(39, 13)
        Me.lblbloco.TabIndex = 20
        Me.lblbloco.Text = "Nome"
        '
        'lblfuncaonum
        '
        Me.lblfuncaonum.AutoSize = True
        Me.lblfuncaonum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuncaonum.ForeColor = System.Drawing.Color.Blue
        Me.lblfuncaonum.Location = New System.Drawing.Point(3, 15)
        Me.lblfuncaonum.Name = "lblfuncaonum"
        Me.lblfuncaonum.Size = New System.Drawing.Size(60, 13)
        Me.lblfuncaonum.TabIndex = 19
        Me.lblfuncaonum.Text = "Nº bloco:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpBloco)
        Me.TabControl1.Controls.Add(Me.tpSala)
        Me.TabControl1.Location = New System.Drawing.Point(12, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(523, 305)
        Me.TabControl1.TabIndex = 35
        '
        'tpBloco
        '
        Me.tpBloco.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tpBloco.Controls.Add(Me.gbBloco)
        Me.tpBloco.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tpBloco.Location = New System.Drawing.Point(4, 22)
        Me.tpBloco.Name = "tpBloco"
        Me.tpBloco.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBloco.Size = New System.Drawing.Size(515, 279)
        Me.tpBloco.TabIndex = 0
        Me.tpBloco.Text = "Bloco"
        '
        'gbBloco
        '
        Me.gbBloco.Controls.Add(Me.DataGridBloco)
        Me.gbBloco.Controls.Add(Me.lblfuncaonum)
        Me.gbBloco.Controls.Add(Me.lblbloco)
        Me.gbBloco.Controls.Add(Me.txtbloconum)
        Me.gbBloco.Controls.Add(Me.txtnomebloco)
        Me.gbBloco.Controls.Add(Me.lblobrigatorionomebloco)
        Me.gbBloco.Location = New System.Drawing.Point(6, 7)
        Me.gbBloco.Name = "gbBloco"
        Me.gbBloco.Size = New System.Drawing.Size(415, 266)
        Me.gbBloco.TabIndex = 32
        Me.gbBloco.TabStop = False
        '
        'DataGridBloco
        '
        Me.DataGridBloco.BackgroundColor = System.Drawing.Color.White
        Me.DataGridBloco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBloco.Location = New System.Drawing.Point(6, 50)
        Me.DataGridBloco.Name = "DataGridBloco"
        Me.DataGridBloco.ReadOnly = True
        Me.DataGridBloco.RowHeadersVisible = False
        Me.DataGridBloco.Size = New System.Drawing.Size(186, 210)
        Me.DataGridBloco.TabIndex = 31
        '
        'tpSala
        '
        Me.tpSala.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tpSala.Controls.Add(Me.gbsala)
        Me.tpSala.Location = New System.Drawing.Point(4, 22)
        Me.tpSala.Name = "tpSala"
        Me.tpSala.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSala.Size = New System.Drawing.Size(515, 279)
        Me.tpSala.TabIndex = 1
        Me.tpSala.Text = "Sala"
        '
        'gbsala
        '
        Me.gbsala.Controls.Add(Me.txtBloco)
        Me.gbsala.Controls.Add(Me.comblocosala)
        Me.gbsala.Controls.Add(Me.Label1)
        Me.gbsala.Controls.Add(Me.datagridsala)
        Me.gbsala.Controls.Add(Me.lblsala)
        Me.gbsala.Controls.Add(Me.lblobrigatorionomesala)
        Me.gbsala.Controls.Add(Me.txtnumsala)
        Me.gbsala.Controls.Add(Me.lblnumsala)
        Me.gbsala.Controls.Add(Me.txtnomesala)
        Me.gbsala.Location = New System.Drawing.Point(6, 0)
        Me.gbsala.Name = "gbsala"
        Me.gbsala.Size = New System.Drawing.Size(503, 273)
        Me.gbsala.TabIndex = 6
        Me.gbsala.TabStop = False
        Me.gbsala.Text = "gbsala"
        '
        'txtBloco
        '
        Me.txtBloco.Location = New System.Drawing.Point(206, 45)
        Me.txtBloco.Name = "txtBloco"
        Me.txtBloco.Size = New System.Drawing.Size(69, 20)
        Me.txtBloco.TabIndex = 9
        Me.txtBloco.Visible = False
        '
        'comblocosala
        '
        Me.comblocosala.FormattingEnabled = True
        Me.comblocosala.Location = New System.Drawing.Point(413, 18)
        Me.comblocosala.Name = "comblocosala"
        Me.comblocosala.Size = New System.Drawing.Size(90, 21)
        Me.comblocosala.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(368, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bloco:"
        '
        'datagridsala
        '
        Me.datagridsala.BackgroundColor = System.Drawing.Color.White
        Me.datagridsala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridsala.Location = New System.Drawing.Point(67, 71)
        Me.datagridsala.Name = "datagridsala"
        Me.datagridsala.ReadOnly = True
        Me.datagridsala.RowHeadersVisible = False
        Me.datagridsala.Size = New System.Drawing.Size(214, 186)
        Me.datagridsala.TabIndex = 6
        '
        'lblsala
        '
        Me.lblsala.AutoSize = True
        Me.lblsala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsala.ForeColor = System.Drawing.Color.Blue
        Me.lblsala.Location = New System.Drawing.Point(112, 22)
        Me.lblsala.Name = "lblsala"
        Me.lblsala.Size = New System.Drawing.Size(88, 13)
        Me.lblsala.TabIndex = 3
        Me.lblsala.Text = "Nome da sala:"
        '
        'lblobrigatorionomesala
        '
        Me.lblobrigatorionomesala.AutoSize = True
        Me.lblobrigatorionomesala.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorionomesala.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorionomesala.Location = New System.Drawing.Point(281, 19)
        Me.lblobrigatorionomesala.Name = "lblobrigatorionomesala"
        Me.lblobrigatorionomesala.Size = New System.Drawing.Size(85, 15)
        Me.lblobrigatorionomesala.TabIndex = 5
        Me.lblobrigatorionomesala.Text = "*Obrigatório"
        '
        'txtnumsala
        '
        Me.txtnumsala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumsala.Location = New System.Drawing.Point(68, 18)
        Me.txtnumsala.Name = "txtnumsala"
        Me.txtnumsala.Size = New System.Drawing.Size(20, 20)
        Me.txtnumsala.TabIndex = 0
        '
        'lblnumsala
        '
        Me.lblnumsala.AutoSize = True
        Me.lblnumsala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumsala.ForeColor = System.Drawing.Color.Blue
        Me.lblnumsala.Location = New System.Drawing.Point(16, 22)
        Me.lblnumsala.Name = "lblnumsala"
        Me.lblnumsala.Size = New System.Drawing.Size(52, 13)
        Me.lblnumsala.TabIndex = 1
        Me.lblnumsala.Text = "Nº sala:"
        '
        'txtnomesala
        '
        Me.txtnomesala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomesala.Location = New System.Drawing.Point(206, 18)
        Me.txtnomesala.Name = "txtnomesala"
        Me.txtnomesala.Size = New System.Drawing.Size(69, 20)
        Me.txtnomesala.TabIndex = 2
        '
        'blocoSala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(578, 361)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btneliminarblocosala)
        Me.Controls.Add(Me.btncancelarblocosala)
        Me.Controls.Add(Me.btnsairblocosala)
        Me.Controls.Add(Me.btnconsultarblocosala)
        Me.Controls.Add(Me.btnguardarblocosala)
        Me.Controls.Add(Me.btneditarblocosala)
        Me.Controls.Add(Me.btnnovoblocosala)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "blocoSala"
        Me.Text = "blocoSala"
        Me.TabControl1.ResumeLayout(False)
        Me.tpBloco.ResumeLayout(False)
        Me.gbBloco.ResumeLayout(False)
        Me.gbBloco.PerformLayout()
        CType(Me.DataGridBloco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSala.ResumeLayout(False)
        Me.gbsala.ResumeLayout(False)
        Me.gbsala.PerformLayout()
        CType(Me.datagridsala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btneliminarblocosala As System.Windows.Forms.Button
    Friend WithEvents btncancelarblocosala As System.Windows.Forms.Button
    Friend WithEvents lblobrigatorionomebloco As System.Windows.Forms.Label
    Friend WithEvents txtnomebloco As System.Windows.Forms.TextBox
    Friend WithEvents btnsairblocosala As System.Windows.Forms.Button
    Friend WithEvents btnconsultarblocosala As System.Windows.Forms.Button
    Friend WithEvents btnguardarblocosala As System.Windows.Forms.Button
    Friend WithEvents btneditarblocosala As System.Windows.Forms.Button
    Friend WithEvents btnnovoblocosala As System.Windows.Forms.Button
    Friend WithEvents txtbloconum As System.Windows.Forms.TextBox
    Friend WithEvents lblbloco As System.Windows.Forms.Label
    Friend WithEvents lblfuncaonum As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpBloco As System.Windows.Forms.TabPage
    Friend WithEvents tpSala As System.Windows.Forms.TabPage
    Friend WithEvents txtnumsala As System.Windows.Forms.TextBox
    Friend WithEvents lblsala As System.Windows.Forms.Label
    Friend WithEvents txtnomesala As System.Windows.Forms.TextBox
    Friend WithEvents lblnumsala As System.Windows.Forms.Label
    Friend WithEvents lblobrigatorionomesala As System.Windows.Forms.Label
    Friend WithEvents DataGridBloco As System.Windows.Forms.DataGridView
    Friend WithEvents gbBloco As System.Windows.Forms.GroupBox
    Friend WithEvents gbsala As System.Windows.Forms.GroupBox
    Friend WithEvents datagridsala As System.Windows.Forms.DataGridView
    Friend WithEvents comblocosala As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBloco As System.Windows.Forms.TextBox
End Class
