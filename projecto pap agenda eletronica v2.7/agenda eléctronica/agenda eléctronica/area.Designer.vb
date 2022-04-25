<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Area
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
        Me.lblnumarea = New System.Windows.Forms.Label()
        Me.lblnomearea = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.txtnumarea = New System.Windows.Forms.TextBox()
        Me.txtnomearea = New System.Windows.Forms.TextBox()
        Me.lblobrigatorionomearea = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnovoarea = New System.Windows.Forms.Button()
        Me.btneditarea = New System.Windows.Forms.Button()
        Me.btneliminarea = New System.Windows.Forms.Button()
        Me.btnguardarea = New System.Windows.Forms.Button()
        Me.btnconsultarea = New System.Windows.Forms.Button()
        Me.btncancelarea = New System.Windows.Forms.Button()
        Me.btnsairarea = New System.Windows.Forms.Button()
        Me.datagridarea = New System.Windows.Forms.DataGridView()
        CType(Me.datagridarea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnumarea
        '
        Me.lblnumarea.AutoSize = True
        Me.lblnumarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumarea.ForeColor = System.Drawing.Color.Blue
        Me.lblnumarea.Location = New System.Drawing.Point(14, 49)
        Me.lblnumarea.Name = "lblnumarea"
        Me.lblnumarea.Size = New System.Drawing.Size(54, 13)
        Me.lblnumarea.TabIndex = 0
        Me.lblnumarea.Text = "Nº area:"
        '
        'lblnomearea
        '
        Me.lblnomearea.AutoSize = True
        Me.lblnomearea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomearea.ForeColor = System.Drawing.Color.Blue
        Me.lblnomearea.Location = New System.Drawing.Point(147, 49)
        Me.lblnomearea.Name = "lblnomearea"
        Me.lblnomearea.Size = New System.Drawing.Size(37, 13)
        Me.lblnomearea.TabIndex = 1
        Me.lblnomearea.Text = "Area:"
        '
        'txtnumarea
        '
        Me.txtnumarea.Location = New System.Drawing.Point(79, 46)
        Me.txtnumarea.Name = "txtnumarea"
        Me.txtnumarea.Size = New System.Drawing.Size(39, 20)
        Me.txtnumarea.TabIndex = 2
        '
        'txtnomearea
        '
        Me.txtnomearea.Location = New System.Drawing.Point(187, 46)
        Me.txtnomearea.Name = "txtnomearea"
        Me.txtnomearea.Size = New System.Drawing.Size(80, 20)
        Me.txtnomearea.TabIndex = 3
        '
        'lblobrigatorionomearea
        '
        Me.lblobrigatorionomearea.AutoSize = True
        Me.lblobrigatorionomearea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobrigatorionomearea.ForeColor = System.Drawing.Color.Red
        Me.lblobrigatorionomearea.Location = New System.Drawing.Point(271, 49)
        Me.lblobrigatorionomearea.Name = "lblobrigatorionomearea"
        Me.lblobrigatorionomearea.Size = New System.Drawing.Size(74, 13)
        Me.lblobrigatorionomearea.TabIndex = 4
        Me.lblobrigatorionomearea.Text = "*Obrigatório"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(659, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnovoarea
        '
        Me.btnovoarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnovoarea.Location = New System.Drawing.Point(0, 0)
        Me.btnovoarea.Name = "btnovoarea"
        Me.btnovoarea.Size = New System.Drawing.Size(87, 23)
        Me.btnovoarea.TabIndex = 6
        Me.btnovoarea.Text = "Novo"
        Me.btnovoarea.UseVisualStyleBackColor = True
        '
        'btneditarea
        '
        Me.btneditarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditarea.Location = New System.Drawing.Point(85, 0)
        Me.btneditarea.Name = "btneditarea"
        Me.btneditarea.Size = New System.Drawing.Size(87, 23)
        Me.btneditarea.TabIndex = 7
        Me.btneditarea.Text = "Editar"
        Me.btneditarea.UseVisualStyleBackColor = True
        '
        'btneliminarea
        '
        Me.btneliminarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarea.Location = New System.Drawing.Point(166, 0)
        Me.btneliminarea.Name = "btneliminarea"
        Me.btneliminarea.Size = New System.Drawing.Size(87, 23)
        Me.btneliminarea.TabIndex = 8
        Me.btneliminarea.Text = "Eliminar"
        Me.btneliminarea.UseVisualStyleBackColor = True
        '
        'btnguardarea
        '
        Me.btnguardarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarea.Location = New System.Drawing.Point(244, 0)
        Me.btnguardarea.Name = "btnguardarea"
        Me.btnguardarea.Size = New System.Drawing.Size(87, 23)
        Me.btnguardarea.TabIndex = 9
        Me.btnguardarea.Text = "Guardar"
        Me.btnguardarea.UseVisualStyleBackColor = True
        '
        'btnconsultarea
        '
        Me.btnconsultarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultarea.Location = New System.Drawing.Point(323, 0)
        Me.btnconsultarea.Name = "btnconsultarea"
        Me.btnconsultarea.Size = New System.Drawing.Size(87, 23)
        Me.btnconsultarea.TabIndex = 10
        Me.btnconsultarea.Text = "Consultar"
        Me.btnconsultarea.UseVisualStyleBackColor = True
        '
        'btncancelarea
        '
        Me.btncancelarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelarea.Location = New System.Drawing.Point(401, 0)
        Me.btncancelarea.Name = "btncancelarea"
        Me.btncancelarea.Size = New System.Drawing.Size(87, 23)
        Me.btncancelarea.TabIndex = 11
        Me.btncancelarea.Text = "Cancelar"
        Me.btncancelarea.UseVisualStyleBackColor = True
        '
        'btnsairarea
        '
        Me.btnsairarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsairarea.Location = New System.Drawing.Point(481, 0)
        Me.btnsairarea.Name = "btnsairarea"
        Me.btnsairarea.Size = New System.Drawing.Size(87, 23)
        Me.btnsairarea.TabIndex = 12
        Me.btnsairarea.Text = "Sair"
        Me.btnsairarea.UseVisualStyleBackColor = True
        '
        'datagridarea
        '
        Me.datagridarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridarea.Location = New System.Drawing.Point(17, 92)
        Me.datagridarea.Name = "datagridarea"
        Me.datagridarea.Size = New System.Drawing.Size(240, 150)
        Me.datagridarea.TabIndex = 13
        '
        'Area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(659, 375)
        Me.Controls.Add(Me.datagridarea)
        Me.Controls.Add(Me.btnsairarea)
        Me.Controls.Add(Me.btncancelarea)
        Me.Controls.Add(Me.btnconsultarea)
        Me.Controls.Add(Me.btnguardarea)
        Me.Controls.Add(Me.btneliminarea)
        Me.Controls.Add(Me.btneditarea)
        Me.Controls.Add(Me.btnovoarea)
        Me.Controls.Add(Me.lblobrigatorionomearea)
        Me.Controls.Add(Me.txtnomearea)
        Me.Controls.Add(Me.txtnumarea)
        Me.Controls.Add(Me.lblnomearea)
        Me.Controls.Add(Me.lblnumarea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Area"
        Me.Text = "Area_disciplina"
        CType(Me.datagridarea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnumarea As System.Windows.Forms.Label
    Friend WithEvents lblnomearea As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents txtnumarea As System.Windows.Forms.TextBox
    Friend WithEvents txtnomearea As System.Windows.Forms.TextBox
    Friend WithEvents lblobrigatorionomearea As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnovoarea As System.Windows.Forms.Button
    Friend WithEvents btneditarea As System.Windows.Forms.Button
    Friend WithEvents btneliminarea As System.Windows.Forms.Button
    Friend WithEvents btnguardarea As System.Windows.Forms.Button
    Friend WithEvents btnconsultarea As System.Windows.Forms.Button
    Friend WithEvents btncancelarea As System.Windows.Forms.Button
    Friend WithEvents btnsairarea As System.Windows.Forms.Button
    Friend WithEvents datagridarea As System.Windows.Forms.DataGridView
End Class
