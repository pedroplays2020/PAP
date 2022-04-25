<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class categoria
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
        Me.Menucategoria = New System.Windows.Forms.MenuStrip()
        Me.lblnumcategoria = New System.Windows.Forms.Label()
        Me.btnovocategoria = New System.Windows.Forms.Button()
        Me.btneditarcategoria = New System.Windows.Forms.Button()
        Me.btnelimnarcategoria = New System.Windows.Forms.Button()
        Me.btnguardarcategoria = New System.Windows.Forms.Button()
        Me.btnconsultarcategoria = New System.Windows.Forms.Button()
        Me.btnsaircategoria = New System.Windows.Forms.Button()
        Me.lblfuncaocategoria = New System.Windows.Forms.Label()
        Me.lblnomecategoria = New System.Windows.Forms.Label()
        Me.txtnumcategoria = New System.Windows.Forms.TextBox()
        Me.txtnomecategoria = New System.Windows.Forms.TextBox()
        Me.lblobrigatoriofumcaocategoria = New System.Windows.Forms.Label()
        Me.lblobrigatorionomecategoria = New System.Windows.Forms.Label()
        Me.combofuncaocategoria = New System.Windows.Forms.ComboBox()
        Me.datgridcategoria = New System.Windows.Forms.DataGridView()
        Me.btncancelarcategoria = New System.Windows.Forms.Button()
        Me.gbMensagem = New System.Windows.Forms.GroupBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.lblNumRegistos = New System.Windows.Forms.Label()
        Me.lblNumReg = New System.Windows.Forms.Label()
        CType(Me.datgridcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMensagem.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menucategoria
        '
        Me.Menucategoria.Location = New System.Drawing.Point(0, 0)
        Me.Menucategoria.Name = "Menucategoria"
        Me.Menucategoria.Size = New System.Drawing.Size(771, 24)
        Me.Menucategoria.TabIndex = 0
        Me.Menucategoria.Text = "Menucategoria"
        '
        'lblnumcategoria
        '
        Me.lblnumcategoria.AutoSize = True
        Me.lblnumcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumcategoria.ForeColor = System.Drawing.Color.Blue
        Me.lblnumcategoria.Location = New System.Drawing.Point(12, 38)
        Me.lblnumcategoria.Name = "lblnumcategoria"
        Me.lblnumcategoria.Size = New System.Drawing.Size(82, 13)
        Me.lblnumcategoria.TabIndex = 1
        Me.lblnumcategoria.Text = "Nº categoria:"
        '
        'btnovocategoria
        '
        Me.btnovocategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnovocategoria.Location = New System.Drawing.Point(0, 0)
        Me.btnovocategoria.Name = "btnovocategoria"
        Me.btnovocategoria.Size = New System.Drawing.Size(75, 23)
        Me.btnovocategoria.TabIndex = 2
        Me.btnovocategoria.Text = "Novo"
        Me.btnovocategoria.UseVisualStyleBackColor = True
        '
        'btneditarcategoria
        '
        Me.btneditarcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarcategoria.Location = New System.Drawing.Point(71, 0)
        Me.btneditarcategoria.Name = "btneditarcategoria"
        Me.btneditarcategoria.Size = New System.Drawing.Size(75, 23)
        Me.btneditarcategoria.TabIndex = 3
        Me.btneditarcategoria.Text = "Editar"
        Me.btneditarcategoria.UseVisualStyleBackColor = True
        '
        'btnelimnarcategoria
        '
        Me.btnelimnarcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnelimnarcategoria.Location = New System.Drawing.Point(140, 0)
        Me.btnelimnarcategoria.Name = "btnelimnarcategoria"
        Me.btnelimnarcategoria.Size = New System.Drawing.Size(75, 23)
        Me.btnelimnarcategoria.TabIndex = 4
        Me.btnelimnarcategoria.Text = "Eliminar"
        Me.btnelimnarcategoria.UseVisualStyleBackColor = True
        '
        'btnguardarcategoria
        '
        Me.btnguardarcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarcategoria.Location = New System.Drawing.Point(210, 0)
        Me.btnguardarcategoria.Name = "btnguardarcategoria"
        Me.btnguardarcategoria.Size = New System.Drawing.Size(75, 23)
        Me.btnguardarcategoria.TabIndex = 5
        Me.btnguardarcategoria.Text = "Guardar"
        Me.btnguardarcategoria.UseVisualStyleBackColor = True
        '
        'btnconsultarcategoria
        '
        Me.btnconsultarcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultarcategoria.Location = New System.Drawing.Point(281, 0)
        Me.btnconsultarcategoria.Name = "btnconsultarcategoria"
        Me.btnconsultarcategoria.Size = New System.Drawing.Size(75, 23)
        Me.btnconsultarcategoria.TabIndex = 6
        Me.btnconsultarcategoria.Text = "Consultar"
        Me.btnconsultarcategoria.UseVisualStyleBackColor = True
        '
        'btnsaircategoria
        '
        Me.btnsaircategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaircategoria.Location = New System.Drawing.Point(427, 0)
        Me.btnsaircategoria.Name = "btnsaircategoria"
        Me.btnsaircategoria.Size = New System.Drawing.Size(75, 23)
        Me.btnsaircategoria.TabIndex = 7
        Me.btnsaircategoria.Text = "Sair"
        Me.btnsaircategoria.UseVisualStyleBackColor = True
        '
        'lblfuncaocategoria
        '
        Me.lblfuncaocategoria.AutoSize = True
        Me.lblfuncaocategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfuncaocategoria.ForeColor = System.Drawing.Color.Blue
        Me.lblfuncaocategoria.Location = New System.Drawing.Point(35, 107)
        Me.lblfuncaocategoria.Name = "lblfuncaocategoria"
        Me.lblfuncaocategoria.Size = New System.Drawing.Size(53, 13)
        Me.lblfuncaocategoria.TabIndex = 8
        Me.lblfuncaocategoria.Text = "Função:"
        '
        'lblnomecategoria
        '
        Me.lblnomecategoria.AutoSize = True
        Me.lblnomecategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomecategoria.ForeColor = System.Drawing.Color.Blue
        Me.lblnomecategoria.Location = New System.Drawing.Point(45, 75)
        Me.lblnomecategoria.Name = "lblnomecategoria"
        Me.lblnomecategoria.Size = New System.Drawing.Size(43, 13)
        Me.lblnomecategoria.TabIndex = 9
        Me.lblnomecategoria.Text = "Nome:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtnumcategoria
        '
        Me.txtnumcategoria.Enabled = False
        Me.txtnumcategoria.Location = New System.Drawing.Point(95, 35)
        Me.txtnumcategoria.Name = "txtnumcategoria"
        Me.txtnumcategoria.Size = New System.Drawing.Size(27, 20)
        Me.txtnumcategoria.TabIndex = 10
        '
        'txtnomecategoria
        '
        Me.txtnomecategoria.Enabled = False
        Me.txtnomecategoria.Location = New System.Drawing.Point(94, 72)
        Me.txtnomecategoria.Name = "txtnomecategoria"
        Me.txtnomecategoria.Size = New System.Drawing.Size(180, 20)
        Me.txtnomecategoria.TabIndex = 12
        '
        'lblobrigatoriofumcaocategoria
        '
        Me.lblobrigatoriofumcaocategoria.AutoSize = True
        Me.lblobrigatoriofumcaocategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatoriofumcaocategoria.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatoriofumcaocategoria.Location = New System.Drawing.Point(286, 107)
        Me.lblobrigatoriofumcaocategoria.Name = "lblobrigatoriofumcaocategoria"
        Me.lblobrigatoriofumcaocategoria.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatoriofumcaocategoria.TabIndex = 15
        Me.lblobrigatoriofumcaocategoria.Text = "*Obrigatório"
        '
        'lblobrigatorionomecategoria
        '
        Me.lblobrigatorionomecategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorionomecategoria.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorionomecategoria.Location = New System.Drawing.Point(286, 75)
        Me.lblobrigatorionomecategoria.Name = "lblobrigatorionomecategoria"
        Me.lblobrigatorionomecategoria.Size = New System.Drawing.Size(74, 32)
        Me.lblobrigatorionomecategoria.TabIndex = 16
        Me.lblobrigatorionomecategoria.Text = "*Obrigatorio"
        '
        'combofuncaocategoria
        '
        Me.combofuncaocategoria.Enabled = False
        Me.combofuncaocategoria.FormattingEnabled = True
        Me.combofuncaocategoria.Location = New System.Drawing.Point(93, 104)
        Me.combofuncaocategoria.Name = "combofuncaocategoria"
        Me.combofuncaocategoria.Size = New System.Drawing.Size(180, 21)
        Me.combofuncaocategoria.TabIndex = 17
        '
        'datgridcategoria
        '
        Me.datgridcategoria.AllowUserToAddRows = False
        Me.datgridcategoria.BackgroundColor = System.Drawing.Color.White
        Me.datgridcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datgridcategoria.Location = New System.Drawing.Point(376, 34)
        Me.datgridcategoria.Name = "datgridcategoria"
        Me.datgridcategoria.RowHeadersVisible = False
        Me.datgridcategoria.Size = New System.Drawing.Size(383, 160)
        Me.datgridcategoria.TabIndex = 18
        '
        'btncancelarcategoria
        '
        Me.btncancelarcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarcategoria.Location = New System.Drawing.Point(354, 0)
        Me.btncancelarcategoria.Name = "btncancelarcategoria"
        Me.btncancelarcategoria.Size = New System.Drawing.Size(75, 23)
        Me.btncancelarcategoria.TabIndex = 19
        Me.btncancelarcategoria.Text = "Cancelar"
        Me.btncancelarcategoria.UseVisualStyleBackColor = True
        '
        'gbMensagem
        '
        Me.gbMensagem.Controls.Add(Me.lblMsg)
        Me.gbMensagem.Location = New System.Drawing.Point(15, 146)
        Me.gbMensagem.Name = "gbMensagem"
        Me.gbMensagem.Size = New System.Drawing.Size(345, 48)
        Me.gbMensagem.TabIndex = 20
        Me.gbMensagem.TabStop = False
        Me.gbMensagem.Text = "Mensagem"
        Me.gbMensagem.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMsg.Location = New System.Drawing.Point(5, 16)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(334, 29)
        Me.lblMsg.TabIndex = 21
        Me.lblMsg.Text = "Eliminar Categoria"
        '
        'lblNumRegistos
        '
        Me.lblNumRegistos.AutoSize = True
        Me.lblNumRegistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumRegistos.ForeColor = System.Drawing.Color.Blue
        Me.lblNumRegistos.Location = New System.Drawing.Point(379, 206)
        Me.lblNumRegistos.Name = "lblNumRegistos"
        Me.lblNumRegistos.Size = New System.Drawing.Size(73, 13)
        Me.lblNumRegistos.TabIndex = 21
        Me.lblNumRegistos.Text = "Nº registos:"
        '
        'lblNumReg
        '
        Me.lblNumReg.AutoSize = True
        Me.lblNumReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumReg.ForeColor = System.Drawing.Color.Blue
        Me.lblNumReg.Location = New System.Drawing.Point(458, 206)
        Me.lblNumReg.Name = "lblNumReg"
        Me.lblNumReg.Size = New System.Drawing.Size(14, 13)
        Me.lblNumReg.TabIndex = 22
        Me.lblNumReg.Text = "0"
        '
        'categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(771, 228)
        Me.Controls.Add(Me.lblNumReg)
        Me.Controls.Add(Me.lblNumRegistos)
        Me.Controls.Add(Me.gbMensagem)
        Me.Controls.Add(Me.btncancelarcategoria)
        Me.Controls.Add(Me.datgridcategoria)
        Me.Controls.Add(Me.combofuncaocategoria)
        Me.Controls.Add(Me.lblobrigatorionomecategoria)
        Me.Controls.Add(Me.lblobrigatoriofumcaocategoria)
        Me.Controls.Add(Me.txtnomecategoria)
        Me.Controls.Add(Me.txtnumcategoria)
        Me.Controls.Add(Me.lblnomecategoria)
        Me.Controls.Add(Me.lblfuncaocategoria)
        Me.Controls.Add(Me.btnsaircategoria)
        Me.Controls.Add(Me.btnconsultarcategoria)
        Me.Controls.Add(Me.btnguardarcategoria)
        Me.Controls.Add(Me.btnelimnarcategoria)
        Me.Controls.Add(Me.btneditarcategoria)
        Me.Controls.Add(Me.btnovocategoria)
        Me.Controls.Add(Me.lblnumcategoria)
        Me.Controls.Add(Me.Menucategoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.Menucategoria
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "categoria"
        Me.Text = "categoria"
        CType(Me.datgridcategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMensagem.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menucategoria As MenuStrip
    Friend WithEvents lblnumcategoria As Label
    Friend WithEvents btnovocategoria As Button
    Friend WithEvents btneditarcategoria As Button
    Friend WithEvents btnelimnarcategoria As Button
    Friend WithEvents btnguardarcategoria As Button
    Friend WithEvents btnconsultarcategoria As Button
    Friend WithEvents btnsaircategoria As Button
    Friend WithEvents lblfuncaocategoria As Label
    Friend WithEvents lblnomecategoria As Label
    Friend WithEvents txtnumcategoria As TextBox
    Friend WithEvents txtnomecategoria As TextBox
    Friend WithEvents lblobrigatoriofumcaocategoria As System.Windows.Forms.Label
    Friend WithEvents lblobrigatorionomecategoria As System.Windows.Forms.Label
    Friend WithEvents combofuncaocategoria As System.Windows.Forms.ComboBox
    Friend WithEvents datgridcategoria As System.Windows.Forms.DataGridView
    Friend WithEvents btncancelarcategoria As System.Windows.Forms.Button
    Friend WithEvents gbMensagem As System.Windows.Forms.GroupBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents lblNumRegistos As System.Windows.Forms.Label
    Friend WithEvents lblNumReg As System.Windows.Forms.Label
End Class
