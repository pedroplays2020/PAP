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
        Me.lblnumdia = New System.Windows.Forms.Label()
        Me.diadasemana = New System.Windows.Forms.Label()
        Me.txtnundiadasemana = New System.Windows.Forms.TextBox()
        Me.txtdiadasemana = New System.Windows.Forms.TextBox()
        Me.Menudiadasemana = New System.Windows.Forms.MenuStrip()
        Me.btnovodiadasemana = New System.Windows.Forms.Button()
        Me.btneditardiadasemanana = New System.Windows.Forms.Button()
        Me.btnelimanardiadasemana = New System.Windows.Forms.Button()
        Me.btnguardardiasdasemana = New System.Windows.Forms.Button()
        Me.lblibrigatorionundiadasemana = New System.Windows.Forms.Label()
        Me.lblobrobrigatoriodiasdasemana = New System.Windows.Forms.Label()
        Me.btnconsultardiasdasemana = New System.Windows.Forms.Button()
        Me.btnsairdiasdasemana = New System.Windows.Forms.Button()
        Me.btncancelardiasadasemana = New System.Windows.Forms.Button()
        Me.datagriddiasdasemana = New System.Windows.Forms.DataGridView()
        Me.diadadesemana1 = New System.Windows.Forms.Label()
        Me.txtdiaddsemana = New System.Windows.Forms.TextBox()
        CType(Me.datagriddiasdasemana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnumdia
        '
        Me.lblnumdia.AutoSize = True
        Me.lblnumdia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumdia.ForeColor = System.Drawing.Color.Blue
        Me.lblnumdia.Location = New System.Drawing.Point(7, 38)
        Me.lblnumdia.Name = "lblnumdia"
        Me.lblnumdia.Size = New System.Drawing.Size(46, 13)
        Me.lblnumdia.TabIndex = 0
        Me.lblnumdia.Text = "Nº dia:"
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
        Me.Menudiadasemana.Size = New System.Drawing.Size(807, 24)
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
        'btnguardardiasdasemana
        '
        Me.btnguardardiasdasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardardiasdasemana.Location = New System.Drawing.Point(201, 0)
        Me.btnguardardiasdasemana.Name = "btnguardardiasdasemana"
        Me.btnguardardiasdasemana.Size = New System.Drawing.Size(75, 23)
        Me.btnguardardiasdasemana.TabIndex = 8
        Me.btnguardardiasdasemana.Text = "Guardar"
        Me.btnguardardiasdasemana.UseVisualStyleBackColor = True
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
        'btnconsultardiasdasemana
        '
        Me.btnconsultardiasdasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultardiasdasemana.Location = New System.Drawing.Point(273, 0)
        Me.btnconsultardiasdasemana.Name = "btnconsultardiasdasemana"
        Me.btnconsultardiasdasemana.Size = New System.Drawing.Size(75, 23)
        Me.btnconsultardiasdasemana.TabIndex = 11
        Me.btnconsultardiasdasemana.Text = "Consultar"
        Me.btnconsultardiasdasemana.UseVisualStyleBackColor = True
        '
        'btnsairdiasdasemana
        '
        Me.btnsairdiasdasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairdiasdasemana.Location = New System.Drawing.Point(420, 0)
        Me.btnsairdiasdasemana.Name = "btnsairdiasdasemana"
        Me.btnsairdiasdasemana.Size = New System.Drawing.Size(75, 23)
        Me.btnsairdiasdasemana.TabIndex = 12
        Me.btnsairdiasdasemana.Text = "Sair"
        Me.btnsairdiasdasemana.UseVisualStyleBackColor = True
        '
        'btncancelardiasadasemana
        '
        Me.btncancelardiasadasemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelardiasadasemana.Location = New System.Drawing.Point(347, 0)
        Me.btncancelardiasadasemana.Name = "btncancelardiasadasemana"
        Me.btncancelardiasadasemana.Size = New System.Drawing.Size(75, 23)
        Me.btncancelardiasadasemana.TabIndex = 13
        Me.btncancelardiasadasemana.Text = "Cancelar"
        Me.btncancelardiasadasemana.UseVisualStyleBackColor = True
        '
        'datagriddiasdasemana
        '
        Me.datagriddiasdasemana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagriddiasdasemana.Location = New System.Drawing.Point(12, 100)
        Me.datagriddiasdasemana.Name = "datagriddiasdasemana"
        Me.datagriddiasdasemana.Size = New System.Drawing.Size(240, 150)
        Me.datagriddiasdasemana.TabIndex = 14
        '
        'diadadesemana1
        '
        Me.diadadesemana1.AutoSize = True
        Me.diadadesemana1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diadadesemana1.ForeColor = System.Drawing.Color.Blue
        Me.diadadesemana1.Location = New System.Drawing.Point(12, 81)
        Me.diadadesemana1.Name = "diadadesemana1"
        Me.diadadesemana1.Size = New System.Drawing.Size(95, 13)
        Me.diadadesemana1.TabIndex = 15
        Me.diadadesemana1.Text = "Dia da semana:"
        '
        'txtdiaddsemana
        '
        Me.txtdiaddsemana.ForeColor = System.Drawing.Color.Blue
        Me.txtdiaddsemana.Location = New System.Drawing.Point(109, 78)
        Me.txtdiaddsemana.Name = "txtdiaddsemana"
        Me.txtdiaddsemana.Size = New System.Drawing.Size(100, 20)
        Me.txtdiaddsemana.TabIndex = 16
        '
        'dias_da_seamana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(807, 305)
        Me.Controls.Add(Me.txtdiaddsemana)
        Me.Controls.Add(Me.diadadesemana1)
        Me.Controls.Add(Me.datagriddiasdasemana)
        Me.Controls.Add(Me.btncancelardiasadasemana)
        Me.Controls.Add(Me.btnsairdiasdasemana)
        Me.Controls.Add(Me.btnconsultardiasdasemana)
        Me.Controls.Add(Me.lblobrobrigatoriodiasdasemana)
        Me.Controls.Add(Me.lblibrigatorionundiadasemana)
        Me.Controls.Add(Me.btnguardardiasdasemana)
        Me.Controls.Add(Me.btnelimanardiadasemana)
        Me.Controls.Add(Me.btneditardiadasemanana)
        Me.Controls.Add(Me.btnovodiadasemana)
        Me.Controls.Add(Me.txtdiadasemana)
        Me.Controls.Add(Me.txtnundiadasemana)
        Me.Controls.Add(Me.diadasemana)
        Me.Controls.Add(Me.lblnumdia)
        Me.Controls.Add(Me.Menudiadasemana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.Menudiadasemana
        Me.Name = "dias_da_seamana"
        Me.Text = "dias_da_semana:"
        CType(Me.datagriddiasdasemana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnumdia As System.Windows.Forms.Label
    Friend WithEvents diadasemana As System.Windows.Forms.Label
    Friend WithEvents txtnundiadasemana As TextBox
    Friend WithEvents txtdiadasemana As TextBox
    Friend WithEvents Menudiadasemana As MenuStrip
    Friend WithEvents btnovodiadasemana As Button
    Friend WithEvents btneditardiadasemanana As Button
    Friend WithEvents btnelimanardiadasemana As Button
    Friend WithEvents btnguardardiasdasemana As Button
    Friend WithEvents lblibrigatorionundiadasemana As Label
    Friend WithEvents lblobrobrigatoriodiasdasemana As Label
    Friend WithEvents btnconsultardiasdasemana As System.Windows.Forms.Button
    Friend WithEvents btnsairdiasdasemana As System.Windows.Forms.Button
    Friend WithEvents btncancelardiasadasemana As System.Windows.Forms.Button
    Friend WithEvents datagriddiasdasemana As System.Windows.Forms.DataGridView
    Friend WithEvents diadadesemana1 As System.Windows.Forms.Label
    Friend WithEvents txtdiaddsemana As System.Windows.Forms.TextBox
End Class
