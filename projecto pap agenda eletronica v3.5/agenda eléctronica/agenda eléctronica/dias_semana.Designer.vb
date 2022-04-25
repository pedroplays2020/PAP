<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dias
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
        Me.diadasemana = New System.Windows.Forms.Label()
        Me.Menudiadasemana = New System.Windows.Forms.MenuStrip()
        Me.btnovodiadasemana = New System.Windows.Forms.Button()
        Me.btnguardardiasdasemana = New System.Windows.Forms.Button()
        Me.lblobrobrigatoriodiasdasemana = New System.Windows.Forms.Label()
        Me.btnsairdiasdasemana = New System.Windows.Forms.Button()
        Me.btncancelardiasadasemana = New System.Windows.Forms.Button()
        Me.chkListDiasSemana = New System.Windows.Forms.CheckedListBox()
        Me.listboxDias = New System.Windows.Forms.ListBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.gbmsgdias = New System.Windows.Forms.GroupBox()
        Me.lblmsgdias = New System.Windows.Forms.Label()
        Me.gbmsgdias.SuspendLayout()
        Me.SuspendLayout()
        '
        'diadasemana
        '
        Me.diadasemana.AutoSize = True
        Me.diadasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diadasemana.ForeColor = System.Drawing.Color.Blue
        Me.diadasemana.Location = New System.Drawing.Point(12, 40)
        Me.diadasemana.Name = "diadasemana"
        Me.diadasemana.Size = New System.Drawing.Size(101, 13)
        Me.diadasemana.TabIndex = 1
        Me.diadasemana.Text = "Dias da semana:"
        '
        'Menudiadasemana
        '
        Me.Menudiadasemana.Location = New System.Drawing.Point(0, 0)
        Me.Menudiadasemana.Name = "Menudiadasemana"
        Me.Menudiadasemana.Size = New System.Drawing.Size(472, 24)
        Me.Menudiadasemana.TabIndex = 4
        Me.Menudiadasemana.Text = "MenuStrip1"
        '
        'btnovodiadasemana
        '
        Me.btnovodiadasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnovodiadasemana.Location = New System.Drawing.Point(0, 0)
        Me.btnovodiadasemana.Name = "btnovodiadasemana"
        Me.btnovodiadasemana.Size = New System.Drawing.Size(75, 23)
        Me.btnovodiadasemana.TabIndex = 5
        Me.btnovodiadasemana.Text = "Novo"
        Me.btnovodiadasemana.UseVisualStyleBackColor = True
        '
        'btnguardardiasdasemana
        '
        Me.btnguardardiasdasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardardiasdasemana.Location = New System.Drawing.Point(76, 0)
        Me.btnguardardiasdasemana.Name = "btnguardardiasdasemana"
        Me.btnguardardiasdasemana.Size = New System.Drawing.Size(75, 23)
        Me.btnguardardiasdasemana.TabIndex = 8
        Me.btnguardardiasdasemana.Text = "Guardar"
        Me.btnguardardiasdasemana.UseVisualStyleBackColor = True
        '
        'lblobrobrigatoriodiasdasemana
        '
        Me.lblobrobrigatoriodiasdasemana.AutoSize = True
        Me.lblobrobrigatoriodiasdasemana.Enabled = False
        Me.lblobrobrigatoriodiasdasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrobrigatoriodiasdasemana.ForeColor = System.Drawing.Color.Red
        Me.lblobrobrigatoriodiasdasemana.Location = New System.Drawing.Point(119, 40)
        Me.lblobrobrigatoriodiasdasemana.Name = "lblobrobrigatoriodiasdasemana"
        Me.lblobrobrigatoriodiasdasemana.Size = New System.Drawing.Size(72, 13)
        Me.lblobrobrigatoriodiasdasemana.TabIndex = 10
        Me.lblobrobrigatoriodiasdasemana.Text = "*obrigatório"
        '
        'btnsairdiasdasemana
        '
        Me.btnsairdiasdasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairdiasdasemana.Location = New System.Drawing.Point(226, 0)
        Me.btnsairdiasdasemana.Name = "btnsairdiasdasemana"
        Me.btnsairdiasdasemana.Size = New System.Drawing.Size(75, 23)
        Me.btnsairdiasdasemana.TabIndex = 12
        Me.btnsairdiasdasemana.Text = "Sair"
        Me.btnsairdiasdasemana.UseVisualStyleBackColor = True
        '
        'btncancelardiasadasemana
        '
        Me.btncancelardiasadasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelardiasadasemana.Location = New System.Drawing.Point(151, 0)
        Me.btncancelardiasadasemana.Name = "btncancelardiasadasemana"
        Me.btncancelardiasadasemana.Size = New System.Drawing.Size(75, 23)
        Me.btncancelardiasadasemana.TabIndex = 13
        Me.btncancelardiasadasemana.Text = "Cancelar"
        Me.btncancelardiasadasemana.UseVisualStyleBackColor = True
        '
        'chkListDiasSemana
        '
        Me.chkListDiasSemana.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.chkListDiasSemana.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkListDiasSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkListDiasSemana.FormattingEnabled = True
        Me.chkListDiasSemana.Items.AddRange(New Object() {"Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado"})
        Me.chkListDiasSemana.Location = New System.Drawing.Point(27, 62)
        Me.chkListDiasSemana.Name = "chkListDiasSemana"
        Me.chkListDiasSemana.Size = New System.Drawing.Size(120, 128)
        Me.chkListDiasSemana.TabIndex = 17
        '
        'listboxDias
        '
        Me.listboxDias.FormattingEnabled = True
        Me.listboxDias.Location = New System.Drawing.Point(222, 50)
        Me.listboxDias.Name = "listboxDias"
        Me.listboxDias.Size = New System.Drawing.Size(194, 121)
        Me.listboxDias.TabIndex = 18
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'gbmsgdias
        '
        Me.gbmsgdias.Controls.Add(Me.lblmsgdias)
        Me.gbmsgdias.Location = New System.Drawing.Point(16, 180)
        Me.gbmsgdias.Name = "gbmsgdias"
        Me.gbmsgdias.Size = New System.Drawing.Size(238, 64)
        Me.gbmsgdias.TabIndex = 19
        Me.gbmsgdias.TabStop = False
        Me.gbmsgdias.Text = "mensagem"
        '
        'lblmsgdias
        '
        Me.lblmsgdias.AutoSize = True
        Me.lblmsgdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsgdias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmsgdias.Location = New System.Drawing.Point(8, 25)
        Me.lblmsgdias.Name = "lblmsgdias"
        Me.lblmsgdias.Size = New System.Drawing.Size(51, 15)
        Me.lblmsgdias.TabIndex = 0
        Me.lblmsgdias.Text = "Label1"
        '
        'dias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(472, 256)
        Me.Controls.Add(Me.gbmsgdias)
        Me.Controls.Add(Me.listboxDias)
        Me.Controls.Add(Me.chkListDiasSemana)
        Me.Controls.Add(Me.btncancelardiasadasemana)
        Me.Controls.Add(Me.btnsairdiasdasemana)
        Me.Controls.Add(Me.lblobrobrigatoriodiasdasemana)
        Me.Controls.Add(Me.btnguardardiasdasemana)
        Me.Controls.Add(Me.btnovodiadasemana)
        Me.Controls.Add(Me.diadasemana)
        Me.Controls.Add(Me.Menudiadasemana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.Menudiadasemana
        Me.Name = "dias"
        Me.Text = "dias da semana:"
        Me.gbmsgdias.ResumeLayout(False)
        Me.gbmsgdias.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents diadasemana As System.Windows.Forms.Label
    Friend WithEvents Menudiadasemana As MenuStrip
    Friend WithEvents btnovodiadasemana As Button
    Friend WithEvents btnguardardiasdasemana As Button
    Friend WithEvents lblobrobrigatoriodiasdasemana As Label
    Friend WithEvents btnsairdiasdasemana As System.Windows.Forms.Button
    Friend WithEvents btncancelardiasadasemana As System.Windows.Forms.Button
    Friend WithEvents chkListDiasSemana As System.Windows.Forms.CheckedListBox
    Friend WithEvents listboxDias As System.Windows.Forms.ListBox
    Friend WithEvents DirectorySearcher1 As System.DirectoryServices.DirectorySearcher
    Friend WithEvents gbmsgdias As System.Windows.Forms.GroupBox
    Friend WithEvents lblmsgdias As System.Windows.Forms.Label
End Class
