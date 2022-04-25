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
        Me.txtfuncao = New System.Windows.Forms.TextBox()
        Me.lblobrigatorionumfuncao = New System.Windows.Forms.Label()
        Me.lblobrigatoriofuncao = New System.Windows.Forms.Label()
        Me.datgridfuncaocategoria = New System.Windows.Forms.DataGridView()
        Me.Combopesquisaeditarfuncao = New System.Windows.Forms.ComboBox()
        Me.btncancelarfuncao = New System.Windows.Forms.Button()
        Me.btneliminarfuncao = New System.Windows.Forms.Button()
        CType(Me.datgridfuncaocategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblfuncaonum
        '
        Me.lblfuncaonum.AutoSize = True
        Me.lblfuncaonum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuncaonum.ForeColor = System.Drawing.Color.Blue
        Me.lblfuncaonum.Location = New System.Drawing.Point(12, 39)
        Me.lblfuncaonum.Name = "lblfuncaonum"
        Me.lblfuncaonum.Size = New System.Drawing.Size(68, 13)
        Me.lblfuncaonum.TabIndex = 0
        Me.lblfuncaonum.Text = "Nº função:"
        '
        'lblfuncao
        '
        Me.lblfuncao.AutoSize = True
        Me.lblfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuncao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblfuncao.Location = New System.Drawing.Point(198, 39)
        Me.lblfuncao.Name = "lblfuncao"
        Me.lblfuncao.Size = New System.Drawing.Size(53, 13)
        Me.lblfuncao.TabIndex = 1
        Me.lblfuncao.Text = "Função:"
        '
        'txtfuncaonum
        '
        Me.txtfuncaonum.Enabled = False
        Me.txtfuncaonum.Location = New System.Drawing.Point(82, 36)
        Me.txtfuncaonum.Name = "txtfuncaonum"
        Me.txtfuncaonum.Size = New System.Drawing.Size(36, 20)
        Me.txtfuncaonum.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnnovofuncao
        '
        Me.btnnovofuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnovofuncao.Location = New System.Drawing.Point(0, 1)
        Me.btnnovofuncao.Name = "btnnovofuncao"
        Me.btnnovofuncao.Size = New System.Drawing.Size(75, 23)
        Me.btnnovofuncao.TabIndex = 6
        Me.btnnovofuncao.Text = "Novo"
        Me.btnnovofuncao.UseVisualStyleBackColor = True
        '
        'btneditarfuncao
        '
        Me.btneditarfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarfuncao.Location = New System.Drawing.Point(75, 1)
        Me.btneditarfuncao.Name = "btneditarfuncao"
        Me.btneditarfuncao.Size = New System.Drawing.Size(75, 23)
        Me.btneditarfuncao.TabIndex = 7
        Me.btneditarfuncao.Text = "Editar"
        Me.btneditarfuncao.UseVisualStyleBackColor = True
        '
        'btnguardarfuncao
        '
        Me.btnguardarfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarfuncao.Location = New System.Drawing.Point(226, 1)
        Me.btnguardarfuncao.Name = "btnguardarfuncao"
        Me.btnguardarfuncao.Size = New System.Drawing.Size(75, 23)
        Me.btnguardarfuncao.TabIndex = 8
        Me.btnguardarfuncao.Text = "Guardar"
        Me.btnguardarfuncao.UseVisualStyleBackColor = True
        '
        'btnconsultarfuncao
        '
        Me.btnconsultarfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultarfuncao.Location = New System.Drawing.Point(298, 1)
        Me.btnconsultarfuncao.Name = "btnconsultarfuncao"
        Me.btnconsultarfuncao.Size = New System.Drawing.Size(75, 23)
        Me.btnconsultarfuncao.TabIndex = 9
        Me.btnconsultarfuncao.Text = "consultar"
        Me.btnconsultarfuncao.UseVisualStyleBackColor = True
        '
        'btnsairfuncao
        '
        Me.btnsairfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairfuncao.Location = New System.Drawing.Point(450, 2)
        Me.btnsairfuncao.Name = "btnsairfuncao"
        Me.btnsairfuncao.Size = New System.Drawing.Size(75, 23)
        Me.btnsairfuncao.TabIndex = 10
        Me.btnsairfuncao.Text = "sair"
        Me.btnsairfuncao.UseVisualStyleBackColor = True
        '
        'txtfuncao
        '
        Me.txtfuncao.Enabled = False
        Me.txtfuncao.Location = New System.Drawing.Point(253, 36)
        Me.txtfuncao.Name = "txtfuncao"
        Me.txtfuncao.Size = New System.Drawing.Size(116, 20)
        Me.txtfuncao.TabIndex = 11
        '
        'lblobrigatorionumfuncao
        '
        Me.lblobrigatorionumfuncao.AutoSize = True
        Me.lblobrigatorionumfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorionumfuncao.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorionumfuncao.Location = New System.Drawing.Point(125, 39)
        Me.lblobrigatorionumfuncao.Name = "lblobrigatorionumfuncao"
        Me.lblobrigatorionumfuncao.Size = New System.Drawing.Size(67, 13)
        Me.lblobrigatorionumfuncao.TabIndex = 12
        Me.lblobrigatorionumfuncao.Text = "obrigatório"
        '
        'lblobrigatoriofuncao
        '
        Me.lblobrigatoriofuncao.AutoSize = True
        Me.lblobrigatoriofuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriofuncao.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriofuncao.Location = New System.Drawing.Point(375, 39)
        Me.lblobrigatoriofuncao.Name = "lblobrigatoriofuncao"
        Me.lblobrigatoriofuncao.Size = New System.Drawing.Size(67, 13)
        Me.lblobrigatoriofuncao.TabIndex = 13
        Me.lblobrigatoriofuncao.Text = "obrigatório"
        '
        'datgridfuncaocategoria
        '
        Me.datgridfuncaocategoria.AllowUserToAddRows = False
        Me.datgridfuncaocategoria.AllowUserToDeleteRows = False
        Me.datgridfuncaocategoria.BackgroundColor = System.Drawing.Color.White
        Me.datgridfuncaocategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datgridfuncaocategoria.Location = New System.Drawing.Point(24, 77)
        Me.datgridfuncaocategoria.Name = "datgridfuncaocategoria"
        Me.datgridfuncaocategoria.ReadOnly = True
        Me.datgridfuncaocategoria.Size = New System.Drawing.Size(240, 240)
        Me.datgridfuncaocategoria.TabIndex = 14
        '
        'Combopesquisaeditarfuncao
        '
        Me.Combopesquisaeditarfuncao.FormattingEnabled = True
        Me.Combopesquisaeditarfuncao.Location = New System.Drawing.Point(612, 0)
        Me.Combopesquisaeditarfuncao.Name = "Combopesquisaeditarfuncao"
        Me.Combopesquisaeditarfuncao.Size = New System.Drawing.Size(170, 21)
        Me.Combopesquisaeditarfuncao.TabIndex = 15
        Me.Combopesquisaeditarfuncao.Visible = False
        '
        'btncancelarfuncao
        '
        Me.btncancelarfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarfuncao.Location = New System.Drawing.Point(373, 1)
        Me.btncancelarfuncao.Name = "btncancelarfuncao"
        Me.btncancelarfuncao.Size = New System.Drawing.Size(75, 23)
        Me.btncancelarfuncao.TabIndex = 16
        Me.btncancelarfuncao.Text = "Cancelar"
        Me.btncancelarfuncao.UseVisualStyleBackColor = True
        '
        'btneliminarfuncao
        '
        Me.btneliminarfuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarfuncao.Location = New System.Drawing.Point(150, 1)
        Me.btneliminarfuncao.Name = "btneliminarfuncao"
        Me.btneliminarfuncao.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarfuncao.TabIndex = 17
        Me.btneliminarfuncao.Text = "Eliminar"
        Me.btneliminarfuncao.UseVisualStyleBackColor = True
        '
        'função
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(782, 342)
        Me.Controls.Add(Me.btneliminarfuncao)
        Me.Controls.Add(Me.btncancelarfuncao)
        Me.Controls.Add(Me.Combopesquisaeditarfuncao)
        Me.Controls.Add(Me.datgridfuncaocategoria)
        Me.Controls.Add(Me.lblobrigatoriofuncao)
        Me.Controls.Add(Me.lblobrigatorionumfuncao)
        Me.Controls.Add(Me.txtfuncao)
        Me.Controls.Add(Me.btnsairfuncao)
        Me.Controls.Add(Me.btnconsultarfuncao)
        Me.Controls.Add(Me.btnguardarfuncao)
        Me.Controls.Add(Me.btneditarfuncao)
        Me.Controls.Add(Me.btnnovofuncao)
        Me.Controls.Add(Me.txtfuncaonum)
        Me.Controls.Add(Me.lblfuncao)
        Me.Controls.Add(Me.lblfuncaonum)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "função"
        Me.Text = "função"
        CType(Me.datgridfuncaocategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents txtfuncao As System.Windows.Forms.TextBox
    Friend WithEvents lblobrigatorionumfuncao As System.Windows.Forms.Label
    Friend WithEvents lblobrigatoriofuncao As System.Windows.Forms.Label
    Friend WithEvents datgridfuncaocategoria As System.Windows.Forms.DataGridView
    Friend WithEvents Combopesquisaeditarfuncao As System.Windows.Forms.ComboBox
    Friend WithEvents btncancelarfuncao As System.Windows.Forms.Button
    Friend WithEvents btneliminarfuncao As System.Windows.Forms.Button
End Class
