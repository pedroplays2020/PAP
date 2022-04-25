<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dias_da_seamana
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
        Me.lbl = New System.Windows.Forms.Label()
        Me.diadasemana = New System.Windows.Forms.Label()
        Me.txtnundiadasemana = New System.Windows.Forms.TextBox()
        Me.txtdiadasemana = New System.Windows.Forms.TextBox()
        Me.Menudiadasemana = New System.Windows.Forms.MenuStrip()
        Me.btnovodiadasemana = New System.Windows.Forms.Button()
        Me.btneditardiadasemanana = New System.Windows.Forms.Button()
        Me.btnelimanardiadasemana = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lblibrigatorionundiadasemana = New System.Windows.Forms.Label()
        Me.lblobrobrigatoriodiasdasemana = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Blue
        Me.lbl.Location = New System.Drawing.Point(7, 38)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(46, 13)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Nº dia:"
        '
        'diadasemana
        '
        Me.diadasemana.AutoSize = True
        Me.diadasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diadasemana.ForeColor = System.Drawing.Color.Blue
        Me.diadasemana.Location = New System.Drawing.Point(163, 38)
        Me.diadasemana.Name = "diadasemana"
        Me.diadasemana.Size = New System.Drawing.Size(101, 13)
        Me.diadasemana.TabIndex = 1
        Me.diadasemana.Text = "Dias da semana:"
        '
        'txtnundiadasemana
        '
        Me.txtnundiadasemana.Enabled = False
        Me.txtnundiadasemana.Location = New System.Drawing.Point(59, 35)
        Me.txtnundiadasemana.Name = "txtnundiadasemana"
        Me.txtnundiadasemana.Size = New System.Drawing.Size(25, 20)
        Me.txtnundiadasemana.TabIndex = 2
        '
        'txtdiadasemana
        '
        Me.txtdiadasemana.Enabled = False
        Me.txtdiadasemana.Location = New System.Drawing.Point(270, 35)
        Me.txtdiadasemana.Name = "txtdiadasemana"
        Me.txtdiadasemana.Size = New System.Drawing.Size(75, 20)
        Me.txtdiadasemana.TabIndex = 3
        '
        'Menudiadasemana
        '
        Me.Menudiadasemana.Location = New System.Drawing.Point(0, 0)
        Me.Menudiadasemana.Name = "Menudiadasemana"
        Me.Menudiadasemana.Size = New System.Drawing.Size(440, 24)
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
        'btneditardiadasemanana
        '
        Me.btneditardiadasemanana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditardiadasemanana.Location = New System.Drawing.Point(68, 0)
        Me.btneditardiadasemanana.Name = "btneditardiadasemanana"
        Me.btneditardiadasemanana.Size = New System.Drawing.Size(75, 23)
        Me.btneditardiadasemanana.TabIndex = 6
        Me.btneditardiadasemanana.Text = "Editar"
        Me.btneditardiadasemanana.UseVisualStyleBackColor = True
        '
        'btnelimanardiadasemana
        '
        Me.btnelimanardiadasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnelimanardiadasemana.Location = New System.Drawing.Point(139, 0)
        Me.btnelimanardiadasemana.Name = "btnelimanardiadasemana"
        Me.btnelimanardiadasemana.Size = New System.Drawing.Size(65, 23)
        Me.btnelimanardiadasemana.TabIndex = 7
        Me.btnelimanardiadasemana.Text = "Eliminar"
        Me.btnelimanardiadasemana.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(201, 0)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 8
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'lblibrigatorionundiadasemana
        '
        Me.lblibrigatorionundiadasemana.AutoSize = True
        Me.lblibrigatorionundiadasemana.Enabled = False
        Me.lblibrigatorionundiadasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblibrigatorionundiadasemana.ForeColor = System.Drawing.Color.Red
        Me.lblibrigatorionundiadasemana.Location = New System.Drawing.Point(90, 38)
        Me.lblibrigatorionundiadasemana.Name = "lblibrigatorionundiadasemana"
        Me.lblibrigatorionundiadasemana.Size = New System.Drawing.Size(72, 13)
        Me.lblibrigatorionundiadasemana.TabIndex = 9
        Me.lblibrigatorionundiadasemana.Text = "*obrigatório"
        '
        'lblobrobrigatoriodiasdasemana
        '
        Me.lblobrobrigatoriodiasdasemana.AutoSize = True
        Me.lblobrobrigatoriodiasdasemana.Enabled = False
        Me.lblobrobrigatoriodiasdasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrobrigatoriodiasdasemana.ForeColor = System.Drawing.Color.Red
        Me.lblobrobrigatoriodiasdasemana.Location = New System.Drawing.Point(351, 38)
        Me.lblobrobrigatoriodiasdasemana.Name = "lblobrobrigatoriodiasdasemana"
        Me.lblobrobrigatoriodiasdasemana.Size = New System.Drawing.Size(72, 13)
        Me.lblobrobrigatoriodiasdasemana.TabIndex = 10
        Me.lblobrobrigatoriodiasdasemana.Text = "*obrigatório"
        '
        'dias_da_seamana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(440, 173)
        Me.Controls.Add(Me.lblobrobrigatoriodiasdasemana)
        Me.Controls.Add(Me.lblibrigatorionundiadasemana)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnelimanardiadasemana)
        Me.Controls.Add(Me.btneditardiadasemanana)
        Me.Controls.Add(Me.btnovodiadasemana)
        Me.Controls.Add(Me.txtdiadasemana)
        Me.Controls.Add(Me.txtnundiadasemana)
        Me.Controls.Add(Me.diadasemana)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Menudiadasemana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.Menudiadasemana
        Me.Name = "dias_da_seamana"
        Me.Text = "dias_da_semana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents diadasemana As System.Windows.Forms.Label
    Friend WithEvents txtnundiadasemana As TextBox
    Friend WithEvents txtdiadasemana As TextBox
    Friend WithEvents Menudiadasemana As MenuStrip
    Friend WithEvents btnovodiadasemana As Button
    Friend WithEvents btneditardiadasemanana As Button
    Friend WithEvents btnelimanardiadasemana As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblibrigatorionundiadasemana As Label
    Friend WithEvents lblobrobrigatoriodiasdasemana As Label
End Class
