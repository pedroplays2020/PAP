<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class turma
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
        Me.btnovoturma = New System.Windows.Forms.Button()
        Me.btneditarturma = New System.Windows.Forms.Button()
        Me.btneliminarturma = New System.Windows.Forms.Button()
        Me.btnguardarturma = New System.Windows.Forms.Button()
        Me.btnconsultarturma = New System.Windows.Forms.Button()
        Me.btncancelarturma = New System.Windows.Forms.Button()
        Me.btnsairturma = New System.Windows.Forms.Button()
        Me.lblnumturma = New System.Windows.Forms.Label()
        Me.lblnometurma = New System.Windows.Forms.Label()
        Me.lblanoturma = New System.Windows.Forms.Label()
        Me.lbltipocursoturma = New System.Windows.Forms.Label()
        Me.lblanoletivoturma = New System.Windows.Forms.Label()
        Me.txtnumturma = New System.Windows.Forms.TextBox()
        Me.txtnometurma = New System.Windows.Forms.TextBox()
        Me.combanoturma = New System.Windows.Forms.ComboBox()
        Me.combotipocursoturma = New System.Windows.Forms.ComboBox()
        Me.comboanoletivoturma = New System.Windows.Forms.ComboBox()
        Me.datagridturma = New System.Windows.Forms.DataGridView()
        Me.lblobrigatorionometurma = New System.Windows.Forms.Label()
        Me.lblobrigatorioanoturma = New System.Windows.Forms.Label()
        Me.lblobrigatoriotipocursoturma = New System.Windows.Forms.Label()
        Me.lblobrigatorioanoletivoturma = New System.Windows.Forms.Label()
        Me.gbturma = New System.Windows.Forms.GroupBox()
        Me.lblmsgturma = New System.Windows.Forms.Label()
        Me.gbmsgturma = New System.Windows.Forms.GroupBox()
        CType(Me.datagridturma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbturma.SuspendLayout()
        Me.gbmsgturma.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(926, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnovoturma
        '
        Me.btnovoturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnovoturma.Location = New System.Drawing.Point(0, 0)
        Me.btnovoturma.Name = "btnovoturma"
        Me.btnovoturma.Size = New System.Drawing.Size(87, 23)
        Me.btnovoturma.TabIndex = 1
        Me.btnovoturma.Text = "Novo"
        Me.btnovoturma.UseVisualStyleBackColor = True
        '
        'btneditarturma
        '
        Me.btneditarturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarturma.Location = New System.Drawing.Point(87, 0)
        Me.btneditarturma.Name = "btneditarturma"
        Me.btneditarturma.Size = New System.Drawing.Size(87, 23)
        Me.btneditarturma.TabIndex = 2
        Me.btneditarturma.Text = "Editar"
        Me.btneditarturma.UseVisualStyleBackColor = True
        '
        'btneliminarturma
        '
        Me.btneliminarturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarturma.Location = New System.Drawing.Point(175, 0)
        Me.btneliminarturma.Name = "btneliminarturma"
        Me.btneliminarturma.Size = New System.Drawing.Size(87, 23)
        Me.btneliminarturma.TabIndex = 3
        Me.btneliminarturma.Text = "Eliminar"
        Me.btneliminarturma.UseVisualStyleBackColor = True
        '
        'btnguardarturma
        '
        Me.btnguardarturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarturma.Location = New System.Drawing.Point(262, 0)
        Me.btnguardarturma.Name = "btnguardarturma"
        Me.btnguardarturma.Size = New System.Drawing.Size(87, 23)
        Me.btnguardarturma.TabIndex = 4
        Me.btnguardarturma.Text = "Guardar"
        Me.btnguardarturma.UseVisualStyleBackColor = True
        '
        'btnconsultarturma
        '
        Me.btnconsultarturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultarturma.Location = New System.Drawing.Point(350, 0)
        Me.btnconsultarturma.Name = "btnconsultarturma"
        Me.btnconsultarturma.Size = New System.Drawing.Size(87, 23)
        Me.btnconsultarturma.TabIndex = 5
        Me.btnconsultarturma.Text = "Consultar"
        Me.btnconsultarturma.UseVisualStyleBackColor = True
        '
        'btncancelarturma
        '
        Me.btncancelarturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarturma.Location = New System.Drawing.Point(437, 0)
        Me.btncancelarturma.Name = "btncancelarturma"
        Me.btncancelarturma.Size = New System.Drawing.Size(87, 23)
        Me.btncancelarturma.TabIndex = 6
        Me.btncancelarturma.Text = "Cancelar"
        Me.btncancelarturma.UseVisualStyleBackColor = True
        '
        'btnsairturma
        '
        Me.btnsairturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairturma.Location = New System.Drawing.Point(524, 0)
        Me.btnsairturma.Name = "btnsairturma"
        Me.btnsairturma.Size = New System.Drawing.Size(87, 23)
        Me.btnsairturma.TabIndex = 7
        Me.btnsairturma.Text = "Sair"
        Me.btnsairturma.UseVisualStyleBackColor = True
        '
        'lblnumturma
        '
        Me.lblnumturma.AutoSize = True
        Me.lblnumturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumturma.ForeColor = System.Drawing.Color.Blue
        Me.lblnumturma.Location = New System.Drawing.Point(35, 19)
        Me.lblnumturma.Name = "lblnumturma"
        Me.lblnumturma.Size = New System.Drawing.Size(60, 13)
        Me.lblnumturma.TabIndex = 8
        Me.lblnumturma.Text = "Nº turma:"
        '
        'lblnometurma
        '
        Me.lblnometurma.AutoSize = True
        Me.lblnometurma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnometurma.ForeColor = System.Drawing.Color.Blue
        Me.lblnometurma.Location = New System.Drawing.Point(19, 111)
        Me.lblnometurma.Name = "lblnometurma"
        Me.lblnometurma.Size = New System.Drawing.Size(78, 13)
        Me.lblnometurma.TabIndex = 9
        Me.lblnometurma.Text = "Nome turma:"
        '
        'lblanoturma
        '
        Me.lblanoturma.AutoSize = True
        Me.lblanoturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanoturma.ForeColor = System.Drawing.Color.Blue
        Me.lblanoturma.Location = New System.Drawing.Point(15, 142)
        Me.lblanoturma.Name = "lblanoturma"
        Me.lblanoturma.Size = New System.Drawing.Size(84, 13)
        Me.lblanoturma.TabIndex = 11
        Me.lblanoturma.Text = "Escolaridade:"
        '
        'lbltipocursoturma
        '
        Me.lbltipocursoturma.AutoSize = True
        Me.lbltipocursoturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipocursoturma.ForeColor = System.Drawing.Color.Blue
        Me.lbltipocursoturma.Location = New System.Drawing.Point(9, 80)
        Me.lbltipocursoturma.Name = "lbltipocursoturma"
        Me.lbltipocursoturma.Size = New System.Drawing.Size(89, 13)
        Me.lbltipocursoturma.TabIndex = 13
        Me.lbltipocursoturma.Text = "Tipo de curso:"
        '
        'lblanoletivoturma
        '
        Me.lblanoletivoturma.AutoSize = True
        Me.lblanoletivoturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanoletivoturma.ForeColor = System.Drawing.Color.Blue
        Me.lblanoletivoturma.Location = New System.Drawing.Point(24, 47)
        Me.lblanoletivoturma.Name = "lblanoletivoturma"
        Me.lblanoletivoturma.Size = New System.Drawing.Size(75, 13)
        Me.lblanoletivoturma.TabIndex = 15
        Me.lblanoletivoturma.Text = "Ano lectivo:"
        '
        'txtnumturma
        '
        Me.txtnumturma.Location = New System.Drawing.Point(101, 16)
        Me.txtnumturma.Name = "txtnumturma"
        Me.txtnumturma.Size = New System.Drawing.Size(25, 20)
        Me.txtnumturma.TabIndex = 16
        '
        'txtnometurma
        '
        Me.txtnometurma.Location = New System.Drawing.Point(99, 108)
        Me.txtnometurma.Name = "txtnometurma"
        Me.txtnometurma.Size = New System.Drawing.Size(115, 20)
        Me.txtnometurma.TabIndex = 17
        '
        'combanoturma
        '
        Me.combanoturma.FormattingEnabled = True
        Me.combanoturma.Items.AddRange(New Object() {"1º ano", "2º ano", "3º ano", "4º ano", "5º ano", "6º ano", "7º ano", "8º ano", "9º ano", "10º ano", "11º ano", "12º ano"})
        Me.combanoturma.Location = New System.Drawing.Point(100, 136)
        Me.combanoturma.Name = "combanoturma"
        Me.combanoturma.Size = New System.Drawing.Size(116, 21)
        Me.combanoturma.TabIndex = 18
        '
        'combotipocursoturma
        '
        Me.combotipocursoturma.FormattingEnabled = True
        Me.combotipocursoturma.Items.AddRange(New Object() {"Curso Profissional", "Curso Cientifico", "Curso Línguas e Humanidades", "Curso SocioEconomico", "Curso Artes Visuais", "Primeiro Ciclo", "Segundo Ciclo", "Terceiro Ciclo"})
        Me.combotipocursoturma.Location = New System.Drawing.Point(100, 77)
        Me.combotipocursoturma.Name = "combotipocursoturma"
        Me.combotipocursoturma.Size = New System.Drawing.Size(168, 21)
        Me.combotipocursoturma.TabIndex = 19
        '
        'comboanoletivoturma
        '
        Me.comboanoletivoturma.FormattingEnabled = True
        Me.comboanoletivoturma.Location = New System.Drawing.Point(101, 44)
        Me.comboanoletivoturma.Name = "comboanoletivoturma"
        Me.comboanoletivoturma.Size = New System.Drawing.Size(115, 21)
        Me.comboanoletivoturma.TabIndex = 20
        '
        'datagridturma
        '
        Me.datagridturma.AllowUserToAddRows = False
        Me.datagridturma.BackgroundColor = System.Drawing.Color.White
        Me.datagridturma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridturma.Location = New System.Drawing.Point(388, 45)
        Me.datagridturma.Name = "datagridturma"
        Me.datagridturma.ReadOnly = True
        Me.datagridturma.RowHeadersVisible = False
        Me.datagridturma.Size = New System.Drawing.Size(526, 252)
        Me.datagridturma.TabIndex = 21
        '
        'lblobrigatorionometurma
        '
        Me.lblobrigatorionometurma.AutoSize = True
        Me.lblobrigatorionometurma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorionometurma.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorionometurma.Location = New System.Drawing.Point(225, 112)
        Me.lblobrigatorionometurma.Name = "lblobrigatorionometurma"
        Me.lblobrigatorionometurma.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorionometurma.TabIndex = 22
        Me.lblobrigatorionometurma.Text = "*Obrigatório"
        '
        'lblobrigatorioanoturma
        '
        Me.lblobrigatorioanoturma.AutoSize = True
        Me.lblobrigatorioanoturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorioanoturma.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorioanoturma.Location = New System.Drawing.Point(225, 142)
        Me.lblobrigatorioanoturma.Name = "lblobrigatorioanoturma"
        Me.lblobrigatorioanoturma.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorioanoturma.TabIndex = 23
        Me.lblobrigatorioanoturma.Text = "*Obrigatório"
        '
        'lblobrigatoriotipocursoturma
        '
        Me.lblobrigatoriotipocursoturma.AutoSize = True
        Me.lblobrigatoriotipocursoturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriotipocursoturma.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriotipocursoturma.Location = New System.Drawing.Point(274, 80)
        Me.lblobrigatoriotipocursoturma.Name = "lblobrigatoriotipocursoturma"
        Me.lblobrigatoriotipocursoturma.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriotipocursoturma.TabIndex = 24
        Me.lblobrigatoriotipocursoturma.Text = "*Obrigatório"
        '
        'lblobrigatorioanoletivoturma
        '
        Me.lblobrigatorioanoletivoturma.AutoSize = True
        Me.lblobrigatorioanoletivoturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorioanoletivoturma.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorioanoletivoturma.Location = New System.Drawing.Point(225, 48)
        Me.lblobrigatorioanoletivoturma.Name = "lblobrigatorioanoletivoturma"
        Me.lblobrigatorioanoletivoturma.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorioanoletivoturma.TabIndex = 25
        Me.lblobrigatorioanoletivoturma.Text = "*Obrigatório"
        '
        'gbturma
        '
        Me.gbturma.Controls.Add(Me.lblnumturma)
        Me.gbturma.Controls.Add(Me.lblobrigatoriotipocursoturma)
        Me.gbturma.Controls.Add(Me.lblobrigatorioanoletivoturma)
        Me.gbturma.Controls.Add(Me.lblobrigatorioanoturma)
        Me.gbturma.Controls.Add(Me.txtnumturma)
        Me.gbturma.Controls.Add(Me.lblobrigatorionometurma)
        Me.gbturma.Controls.Add(Me.combotipocursoturma)
        Me.gbturma.Controls.Add(Me.comboanoletivoturma)
        Me.gbturma.Controls.Add(Me.combanoturma)
        Me.gbturma.Controls.Add(Me.lbltipocursoturma)
        Me.gbturma.Controls.Add(Me.lblanoletivoturma)
        Me.gbturma.Controls.Add(Me.lblanoturma)
        Me.gbturma.Controls.Add(Me.txtnometurma)
        Me.gbturma.Controls.Add(Me.lblnometurma)
        Me.gbturma.Location = New System.Drawing.Point(12, 38)
        Me.gbturma.Name = "gbturma"
        Me.gbturma.Size = New System.Drawing.Size(357, 179)
        Me.gbturma.TabIndex = 26
        Me.gbturma.TabStop = False
        Me.gbturma.Text = "Turma"
        '
        'lblmsgturma
        '
        Me.lblmsgturma.AutoSize = True
        Me.lblmsgturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsgturma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmsgturma.Location = New System.Drawing.Point(7, 25)
        Me.lblmsgturma.Name = "lblmsgturma"
        Me.lblmsgturma.Size = New System.Drawing.Size(45, 13)
        Me.lblmsgturma.TabIndex = 1
        Me.lblmsgturma.Text = "Label2"
        '
        'gbmsgturma
        '
        Me.gbmsgturma.Controls.Add(Me.lblmsgturma)
        Me.gbmsgturma.Location = New System.Drawing.Point(12, 237)
        Me.gbmsgturma.Name = "gbmsgturma"
        Me.gbmsgturma.Size = New System.Drawing.Size(357, 60)
        Me.gbmsgturma.TabIndex = 27
        Me.gbmsgturma.TabStop = False
        Me.gbmsgturma.Text = "msg"
        Me.gbmsgturma.Visible = False
        '
        'turma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(926, 324)
        Me.Controls.Add(Me.gbmsgturma)
        Me.Controls.Add(Me.gbturma)
        Me.Controls.Add(Me.datagridturma)
        Me.Controls.Add(Me.btnsairturma)
        Me.Controls.Add(Me.btncancelarturma)
        Me.Controls.Add(Me.btnconsultarturma)
        Me.Controls.Add(Me.btnguardarturma)
        Me.Controls.Add(Me.btneliminarturma)
        Me.Controls.Add(Me.btneditarturma)
        Me.Controls.Add(Me.btnovoturma)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "turma"
        Me.Text = "turma"
        CType(Me.datagridturma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbturma.ResumeLayout(False)
        Me.gbturma.PerformLayout()
        Me.gbmsgturma.ResumeLayout(False)
        Me.gbmsgturma.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnovoturma As System.Windows.Forms.Button
    Friend WithEvents btneditarturma As System.Windows.Forms.Button
    Friend WithEvents btneliminarturma As System.Windows.Forms.Button
    Friend WithEvents btnguardarturma As System.Windows.Forms.Button
    Friend WithEvents btnconsultarturma As System.Windows.Forms.Button
    Friend WithEvents btncancelarturma As System.Windows.Forms.Button
    Friend WithEvents btnsairturma As System.Windows.Forms.Button
    Friend WithEvents lblnumturma As System.Windows.Forms.Label
    Friend WithEvents lblnometurma As System.Windows.Forms.Label
    Friend WithEvents lblanoturma As System.Windows.Forms.Label
    Friend WithEvents lbltipocursoturma As System.Windows.Forms.Label
    Friend WithEvents lblanoletivoturma As System.Windows.Forms.Label
    Friend WithEvents txtnumturma As System.Windows.Forms.TextBox
    Friend WithEvents txtnometurma As System.Windows.Forms.TextBox
    Friend WithEvents combanoturma As System.Windows.Forms.ComboBox
    Friend WithEvents combotipocursoturma As System.Windows.Forms.ComboBox
    Friend WithEvents comboanoletivoturma As System.Windows.Forms.ComboBox
    Friend WithEvents datagridturma As System.Windows.Forms.DataGridView
    Friend WithEvents lblobrigatorionometurma As System.Windows.Forms.Label
    Friend WithEvents lblobrigatorioanoturma As System.Windows.Forms.Label
    Friend WithEvents lblobrigatoriotipocursoturma As System.Windows.Forms.Label
    Friend WithEvents lblobrigatorioanoletivoturma As System.Windows.Forms.Label
    Friend WithEvents gbturma As System.Windows.Forms.GroupBox
    Friend WithEvents lblmsgturma As System.Windows.Forms.Label
    Friend WithEvents gbmsgturma As System.Windows.Forms.GroupBox
End Class
