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
        Me.manoletivo = New System.Windows.Forms.MaskedTextBox()
        Me.txtconsultaanoletivo = New System.Windows.Forms.TextBox()
        Me.lbconsulta = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblmsganoletivo = New System.Windows.Forms.Label()
        Me.gbmsganoletivo = New System.Windows.Forms.GroupBox()
        CType(Me.datagridanoletivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbmsganoletivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menuregistos
        '
        Me.Menuregistos.Location = New System.Drawing.Point(0, 0)
        Me.Menuregistos.Name = "Menuregistos"
        Me.Menuregistos.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.Menuregistos.Size = New System.Drawing.Size(642, 24)
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
        Me.btnconsultarano.Text = "Consultar"
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
        Me.lblnumano.Location = New System.Drawing.Point(46, 22)
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
        Me.lblanoletivo.Location = New System.Drawing.Point(39, 57)
        Me.lblanoletivo.Name = "lblanoletivo"
        Me.lblanoletivo.Size = New System.Drawing.Size(33, 13)
        Me.lblanoletivo.TabIndex = 9
        Me.lblanoletivo.Text = "Ano:"
        '
        'txtnunanoletivo
        '
        Me.txtnunanoletivo.Location = New System.Drawing.Point(71, 22)
        Me.txtnunanoletivo.Name = "txtnunanoletivo"
        Me.txtnunanoletivo.Size = New System.Drawing.Size(27, 20)
        Me.txtnunanoletivo.TabIndex = 1
        '
        'datagridanoletivo
        '
        Me.datagridanoletivo.AllowUserToAddRows = False
        Me.datagridanoletivo.BackgroundColor = System.Drawing.Color.White
        Me.datagridanoletivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridanoletivo.Location = New System.Drawing.Point(354, 30)
        Me.datagridanoletivo.Name = "datagridanoletivo"
        Me.datagridanoletivo.ReadOnly = True
        Me.datagridanoletivo.RowHeadersVisible = False
        Me.datagridanoletivo.Size = New System.Drawing.Size(200, 217)
        Me.datagridanoletivo.TabIndex = 12
        '
        'lblobrigatorioano
        '
        Me.lblobrigatorioano.AutoSize = True
        Me.lblobrigatorioano.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorioano.Location = New System.Drawing.Point(147, 57)
        Me.lblobrigatorioano.Name = "lblobrigatorioano"
        Me.lblobrigatorioano.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorioano.TabIndex = 13
        Me.lblobrigatorioano.Text = "*Obrigatório"
        '
        'manoletivo
        '
        Me.manoletivo.Location = New System.Drawing.Point(71, 54)
        Me.manoletivo.Mask = "0000/0000"
        Me.manoletivo.Name = "manoletivo"
        Me.manoletivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.manoletivo.Size = New System.Drawing.Size(68, 20)
        Me.manoletivo.TabIndex = 2
        '
        'txtconsultaanoletivo
        '
        Me.txtconsultaanoletivo.Location = New System.Drawing.Point(70, 88)
        Me.txtconsultaanoletivo.Name = "txtconsultaanoletivo"
        Me.txtconsultaanoletivo.Size = New System.Drawing.Size(68, 20)
        Me.txtconsultaanoletivo.TabIndex = 3
        Me.txtconsultaanoletivo.Visible = False
        '
        'lbconsulta
        '
        Me.lbconsulta.AutoSize = True
        Me.lbconsulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbconsulta.Location = New System.Drawing.Point(8, 91)
        Me.lbconsulta.Name = "lbconsulta"
        Me.lbconsulta.Size = New System.Drawing.Size(60, 13)
        Me.lbconsulta.TabIndex = 16
        Me.lbconsulta.Text = "Consulta:"
        Me.lbconsulta.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnunanoletivo)
        Me.GroupBox1.Controls.Add(Me.lbconsulta)
        Me.GroupBox1.Controls.Add(Me.txtconsultaanoletivo)
        Me.GroupBox1.Controls.Add(Me.lblnumano)
        Me.GroupBox1.Controls.Add(Me.manoletivo)
        Me.GroupBox1.Controls.Add(Me.lblanoletivo)
        Me.GroupBox1.Controls.Add(Me.lblobrigatorioano)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 146)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ano letivo"
        '
        'lblmsganoletivo
        '
        Me.lblmsganoletivo.AutoSize = True
        Me.lblmsganoletivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsganoletivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmsganoletivo.Location = New System.Drawing.Point(7, 25)
        Me.lblmsganoletivo.Name = "lblmsganoletivo"
        Me.lblmsganoletivo.Size = New System.Drawing.Size(45, 13)
        Me.lblmsganoletivo.TabIndex = 1
        Me.lblmsganoletivo.Text = "Label2"
        '
        'gbmsganoletivo
        '
        Me.gbmsganoletivo.Controls.Add(Me.lblmsganoletivo)
        Me.gbmsganoletivo.Location = New System.Drawing.Point(12, 182)
        Me.gbmsganoletivo.Name = "gbmsganoletivo"
        Me.gbmsganoletivo.Size = New System.Drawing.Size(312, 60)
        Me.gbmsganoletivo.TabIndex = 18
        Me.gbmsganoletivo.TabStop = False
        Me.gbmsganoletivo.Text = "Msg"
        Me.gbmsganoletivo.Visible = False
        '
        'ano_letivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(642, 259)
        Me.Controls.Add(Me.gbmsganoletivo)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbmsganoletivo.ResumeLayout(False)
        Me.gbmsganoletivo.PerformLayout()
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
    Friend WithEvents manoletivo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtconsultaanoletivo As System.Windows.Forms.TextBox
    Friend WithEvents lbconsulta As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblmsganoletivo As System.Windows.Forms.Label
    Friend WithEvents gbmsganoletivo As System.Windows.Forms.GroupBox
End Class
