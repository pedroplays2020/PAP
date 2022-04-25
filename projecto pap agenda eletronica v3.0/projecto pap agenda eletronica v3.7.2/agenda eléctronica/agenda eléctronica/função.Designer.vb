<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class função
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
        Me.lblfuncaonum = New System.Windows.Forms.Label()
        Me.lblfuncao = New System.Windows.Forms.Label()
        Me.txtfuncaonum = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnnovofuncao = New System.Windows.Forms.Button()
        Me.btneditarfuncao = New System.Windows.Forms.Button()
        Me.btnguardarfuncao = New System.Windows.Forms.Button()
        Me.btnconsultarfuncao = New System.Windows.Forms.Button()
        Me.btnsairfuncao = New System.Windows.Forms.Button()
        Me.lblobrigatorionumfuncao = New System.Windows.Forms.Label()
        Me.lblobrigatoriofuncao = New System.Windows.Forms.Label()
        Me.datgridfuncaocategoria = New System.Windows.Forms.DataGridView()
        Me.Combopesquisaeditarfuncao = New System.Windows.Forms.ComboBox()
        Me.btncancelarfuncao = New System.Windows.Forms.Button()
        Me.btneliminarfuncao = New System.Windows.Forms.Button()
        Me.txtNomefuncao = New System.Windows.Forms.TextBox()
        Me.gbMSG = New System.Windows.Forms.GroupBox()
        Me.lblmsgutilizador = New System.Windows.Forms.Label()
        Me.gbFuncao = New System.Windows.Forms.GroupBox()
        CType(Me.datgridfuncaocategoria,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbMSG.SuspendLayout
        Me.gbFuncao.SuspendLayout
        Me.SuspendLayout
        '
        'lblfuncaonum
        '
        Me.lblfuncaonum.AutoSize = true
        Me.lblfuncaonum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblfuncaonum.ForeColor = System.Drawing.Color.Blue
        Me.lblfuncaonum.Location = New System.Drawing.Point(24, 32)
        Me.lblfuncaonum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfuncaonum.Name = "lblfuncaonum"
        Me.lblfuncaonum.Size = New System.Drawing.Size(84, 17)
        Me.lblfuncaonum.TabIndex = 0
        Me.lblfuncaonum.Text = "Nº função:"
        '
        'lblfuncao
        '
        Me.lblfuncao.AutoSize = True
        Me.lblfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuncao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblfuncao.Location = New System.Drawing.Point(40, 76)
        Me.lblfuncao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfuncao.Name = "lblfuncao"
        Me.lblfuncao.Size = New System.Drawing.Size(66, 17)
        Me.lblfuncao.TabIndex = 1
        Me.lblfuncao.Text = "Função:"
        '
        'txtfuncaonum
        '
        Me.txtfuncaonum.Enabled = False
        Me.txtfuncaonum.Location = New System.Drawing.Point(117, 28)
        Me.txtfuncaonum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfuncaonum.Name = "txtfuncaonum"
        Me.txtfuncaonum.Size = New System.Drawing.Size(47, 22)
        Me.txtfuncaonum.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnnovofuncao
        '
        Me.btnnovofuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnovofuncao.Location = New System.Drawing.Point(0, 1)
        Me.btnnovofuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnovofuncao.Name = "btnnovofuncao"
        Me.btnnovofuncao.Size = New System.Drawing.Size(100, 28)
        Me.btnnovofuncao.TabIndex = 6
        Me.btnnovofuncao.Text = "Novo"
        Me.btnnovofuncao.UseVisualStyleBackColor = True
        '
        'btneditarfuncao
        '
        Me.btneditarfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarfuncao.Location = New System.Drawing.Point(96, 1)
        Me.btneditarfuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.btneditarfuncao.Name = "btneditarfuncao"
        Me.btneditarfuncao.Size = New System.Drawing.Size(100, 28)
        Me.btneditarfuncao.TabIndex = 7
        Me.btneditarfuncao.Text = "Editar"
        Me.btneditarfuncao.UseVisualStyleBackColor = True
        '
        'btnguardarfuncao
        '
        Me.btnguardarfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarfuncao.Location = New System.Drawing.Point(295, 1)
        Me.btnguardarfuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguardarfuncao.Name = "btnguardarfuncao"
        Me.btnguardarfuncao.Size = New System.Drawing.Size(100, 28)
        Me.btnguardarfuncao.TabIndex = 8
        Me.btnguardarfuncao.Text = "Guardar"
        Me.btnguardarfuncao.UseVisualStyleBackColor = True
        '
        'btnconsultarfuncao
        '
        Me.btnconsultarfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultarfuncao.Location = New System.Drawing.Point(395, 1)
        Me.btnconsultarfuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconsultarfuncao.Name = "btnconsultarfuncao"
        Me.btnconsultarfuncao.Size = New System.Drawing.Size(100, 28)
        Me.btnconsultarfuncao.TabIndex = 9
        Me.btnconsultarfuncao.Text = "consultar"
        Me.btnconsultarfuncao.UseVisualStyleBackColor = True
        '
        'btnsairfuncao
        '
        Me.btnsairfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairfuncao.Location = New System.Drawing.Point(593, 1)
        Me.btnsairfuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsairfuncao.Name = "btnsairfuncao"
        Me.btnsairfuncao.Size = New System.Drawing.Size(100, 28)
        Me.btnsairfuncao.TabIndex = 10
        Me.btnsairfuncao.Text = "sair"
        Me.btnsairfuncao.UseVisualStyleBackColor = True
        '
        'lblobrigatorionumfuncao
        '
        Me.lblobrigatorionumfuncao.AutoSize = True
        Me.lblobrigatorionumfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorionumfuncao.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorionumfuncao.Location = New System.Drawing.Point(191, 33)
        Me.lblobrigatorionumfuncao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblobrigatorionumfuncao.Name = "lblobrigatorionumfuncao"
        Me.lblobrigatorionumfuncao.Size = New System.Drawing.Size(87, 17)
        Me.lblobrigatorionumfuncao.TabIndex = 12
        Me.lblobrigatorionumfuncao.Text = "obrigatório"
        '
        'lblobrigatoriofuncao
        '
        Me.lblobrigatoriofuncao.AutoSize = True
        Me.lblobrigatoriofuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriofuncao.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriofuncao.Location = New System.Drawing.Point(280, 76)
        Me.lblobrigatoriofuncao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblobrigatoriofuncao.Name = "lblobrigatoriofuncao"
        Me.lblobrigatoriofuncao.Size = New System.Drawing.Size(87, 17)
        Me.lblobrigatoriofuncao.TabIndex = 13
        Me.lblobrigatoriofuncao.Text = "obrigatório"
        '
        'datgridfuncaocategoria
        '
        Me.datgridfuncaocategoria.AllowUserToAddRows = False
        Me.datgridfuncaocategoria.AllowUserToDeleteRows = False
        Me.datgridfuncaocategoria.BackgroundColor = System.Drawing.Color.White
        Me.datgridfuncaocategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datgridfuncaocategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datgridfuncaocategoria.Location = New System.Drawing.Point(32, 69)
        Me.datgridfuncaocategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.datgridfuncaocategoria.Name = "datgridfuncaocategoria"
        Me.datgridfuncaocategoria.ReadOnly = True
        Me.datgridfuncaocategoria.RowHeadersVisible = False
        Me.datgridfuncaocategoria.Size = New System.Drawing.Size(320, 295)
        Me.datgridfuncaocategoria.TabIndex = 14
        '
        'Combopesquisaeditarfuncao
        '
        Me.Combopesquisaeditarfuncao.FormattingEnabled = True
        Me.Combopesquisaeditarfuncao.Location = New System.Drawing.Point(816, 0)
        Me.Combopesquisaeditarfuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.Combopesquisaeditarfuncao.Name = "Combopesquisaeditarfuncao"
        Me.Combopesquisaeditarfuncao.Size = New System.Drawing.Size(225, 24)
        Me.Combopesquisaeditarfuncao.TabIndex = 15
        Me.Combopesquisaeditarfuncao.Visible = False
        '
        'btncancelarfuncao
        '
        Me.btncancelarfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarfuncao.Location = New System.Drawing.Point(493, 1)
        Me.btncancelarfuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancelarfuncao.Name = "btncancelarfuncao"
        Me.btncancelarfuncao.Size = New System.Drawing.Size(100, 28)
        Me.btncancelarfuncao.TabIndex = 16
        Me.btncancelarfuncao.Text = "Cancelar"
        Me.btncancelarfuncao.UseVisualStyleBackColor = True
        '
        'btneliminarfuncao
        '
        Me.btneliminarfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarfuncao.Location = New System.Drawing.Point(195, 1)
        Me.btneliminarfuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.btneliminarfuncao.Name = "btneliminarfuncao"
        Me.btneliminarfuncao.Size = New System.Drawing.Size(100, 28)
        Me.btneliminarfuncao.TabIndex = 17
        Me.btneliminarfuncao.Text = "Eliminar"
        Me.btneliminarfuncao.UseVisualStyleBackColor = True
        '
        'txtNomefuncao
        '
        Me.txtNomefuncao.Location = New System.Drawing.Point(117, 73)
        Me.txtNomefuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomefuncao.Name = "txtNomefuncao"
        Me.txtNomefuncao.Size = New System.Drawing.Size(153, 22)
        Me.txtNomefuncao.TabIndex = 18
        '
        'gbMSG
        '
        Me.gbMSG.Controls.Add(Me.lblmsgutilizador)
        Me.gbMSG.Location = New System.Drawing.Point(395, 211)
        Me.gbMSG.Margin = New System.Windows.Forms.Padding(4)
        Me.gbMSG.Name = "gbMSG"
        Me.gbMSG.Padding = New System.Windows.Forms.Padding(4)
        Me.gbMSG.Size = New System.Drawing.Size(446, 71)
        Me.gbMSG.TabIndex = 93
        Me.gbMSG.TabStop = False
        Me.gbMSG.Text = "Mensagem"
        Me.gbMSG.Visible = False
        '
        'lblmsgutilizador
        '
        Me.lblmsgutilizador.AutoSize = True
        Me.lblmsgutilizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsgutilizador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmsgutilizador.Location = New System.Drawing.Point(13, 31)
        Me.lblmsgutilizador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmsgutilizador.Name = "lblmsgutilizador"
        Me.lblmsgutilizador.Size = New System.Drawing.Size(57, 17)
        Me.lblmsgutilizador.TabIndex = 0
        Me.lblmsgutilizador.Text = "Label2"
        '
        'gbFuncao
        '
        Me.gbFuncao.Controls.Add(Me.lblfuncaonum)
        Me.gbFuncao.Controls.Add(Me.txtfuncaonum)
        Me.gbFuncao.Controls.Add(Me.txtNomefuncao)
        Me.gbFuncao.Controls.Add(Me.lblobrigatorionumfuncao)
        Me.gbFuncao.Controls.Add(Me.lblfuncao)
        Me.gbFuncao.Controls.Add(Me.lblobrigatoriofuncao)
        Me.gbFuncao.Location = New System.Drawing.Point(399, 61)
        Me.gbFuncao.Margin = New System.Windows.Forms.Padding(4)
        Me.gbFuncao.Name = "gbFuncao"
        Me.gbFuncao.Padding = New System.Windows.Forms.Padding(4)
        Me.gbFuncao.Size = New System.Drawing.Size(441, 142)
        Me.gbFuncao.TabIndex = 94
        Me.gbFuncao.TabStop = False
        Me.gbFuncao.Text = "Função"
        '
        'função
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(864, 421)
        Me.Controls.Add(Me.gbFuncao)
        Me.Controls.Add(Me.gbMSG)
        Me.Controls.Add(Me.btneliminarfuncao)
        Me.Controls.Add(Me.btncancelarfuncao)
        Me.Controls.Add(Me.Combopesquisaeditarfuncao)
        Me.Controls.Add(Me.datgridfuncaocategoria)
        Me.Controls.Add(Me.btnsairfuncao)
        Me.Controls.Add(Me.btnconsultarfuncao)
        Me.Controls.Add(Me.btnguardarfuncao)
        Me.Controls.Add(Me.btneditarfuncao)
        Me.Controls.Add(Me.btnnovofuncao)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = false
        Me.Name = "função"
        Me.Text = "função"
        CType(Me.datgridfuncaocategoria,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbMSG.ResumeLayout(false)
        Me.gbMSG.PerformLayout
        Me.gbFuncao.ResumeLayout(false)
        Me.gbFuncao.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblfuncaonum As System.Windows.Forms.Label
    Friend WithEvents lblfuncao As System.Windows.Forms.Label
    Friend WithEvents txtfuncaonum As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnnovofuncao As System.Windows.Forms.Button
    Friend WithEvents btneditarfuncao As System.Windows.Forms.Button
    Friend WithEvents btnguardarfuncao As System.Windows.Forms.Button
    Friend WithEvents btnconsultarfuncao As System.Windows.Forms.Button
    Friend WithEvents btnsairfuncao As System.Windows.Forms.Button
    Friend WithEvents lblobrigatorionumfuncao As System.Windows.Forms.Label
    Friend WithEvents lblobrigatoriofuncao As System.Windows.Forms.Label
    Friend WithEvents datgridfuncaocategoria As System.Windows.Forms.DataGridView
    Friend WithEvents Combopesquisaeditarfuncao As System.Windows.Forms.ComboBox
    Friend WithEvents btncancelarfuncao As System.Windows.Forms.Button
    Friend WithEvents btneliminarfuncao As System.Windows.Forms.Button
    Friend WithEvents txtNomefuncao As System.Windows.Forms.TextBox
    Friend WithEvents gbMSG As System.Windows.Forms.GroupBox
    Friend WithEvents lblmsgutilizador As System.Windows.Forms.Label
    Friend WithEvents gbFuncao As System.Windows.Forms.GroupBox
End Class
