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
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.datagridanoletivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menuregistos
        '
        Me.Menuregistos.Location = New System.Drawing.Point(0, 0)
        Me.Menuregistos.Name = "Menuregistos"
        Me.Menuregistos.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.Menuregistos.Size = New System.Drawing.Size(725, 24)
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
        Me.lblnumano.Location = New System.Drawing.Point(20, 30)
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
        Me.lblanoletivo.Location = New System.Drawing.Point(12, 55)
        Me.lblanoletivo.Name = "lblanoletivo"
        Me.lblanoletivo.Size = New System.Drawing.Size(33, 13)
        Me.lblanoletivo.TabIndex = 9
        Me.lblanoletivo.Text = "Ano:"
        '
        'txtnunanoletivo
        '
        Me.txtnunanoletivo.Location = New System.Drawing.Point(44, 27)
        Me.txtnunanoletivo.Name = "txtnunanoletivo"
        Me.txtnunanoletivo.Size = New System.Drawing.Size(27, 20)
        Me.txtnunanoletivo.TabIndex = 10
        '
        'datagridanoletivo
        '
        Me.datagridanoletivo.BackgroundColor = System.Drawing.Color.White
        Me.datagridanoletivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridanoletivo.Location = New System.Drawing.Point(221, 30)
        Me.datagridanoletivo.Name = "datagridanoletivo"
        Me.datagridanoletivo.Size = New System.Drawing.Size(240, 217)
        Me.datagridanoletivo.TabIndex = 12
        '
        'lblobrigatorioano
        '
        Me.lblobrigatorioano.AutoSize = True
        Me.lblobrigatorioano.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorioano.Location = New System.Drawing.Point(120, 55)
        Me.lblobrigatorioano.Name = "lblobrigatorioano"
        Me.lblobrigatorioano.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorioano.TabIndex = 13
        Me.lblobrigatorioano.Text = "*Obrigatório"
        '
        'manoletivo
        '
        Me.manoletivo.Location = New System.Drawing.Point(44, 52)
        Me.manoletivo.Mask = "0000/0000"
        Me.manoletivo.Name = "manoletivo"
        Me.manoletivo.Size = New System.Drawing.Size(68, 20)
        Me.manoletivo.TabIndex = 14
        '
        'txtconsultaanoletivo
        '
        Me.txtconsultaanoletivo.Location = New System.Drawing.Point(65, 78)
        Me.txtconsultaanoletivo.Name = "txtconsultaanoletivo"
        Me.txtconsultaanoletivo.Size = New System.Drawing.Size(68, 20)
        Me.txtconsultaanoletivo.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Consulta:"
        '
        'ano_letivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(725, 259)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtconsultaanoletivo)
        Me.Controls.Add(Me.manoletivo)
        Me.Controls.Add(Me.lblobrigatorioano)
        Me.Controls.Add(Me.datagridanoletivo)
        Me.Controls.Add(Me.txtnunanoletivo)
        Me.Controls.Add(Me.lblanoletivo)
        Me.Controls.Add(Me.lblnumano)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.Menuregistos
        Me.Name = "ano_letivo"
        Me.Text = "ano_letivo"
        CType(Me.datagridanoletivo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
