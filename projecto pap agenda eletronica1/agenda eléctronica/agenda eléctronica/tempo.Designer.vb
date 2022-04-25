<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tempo
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
        Me.lblnumtempo = New System.Windows.Forms.Label()
        Me.lblintervalotempo = New System.Windows.Forms.Label()
        Me.txtintervalodetempo = New System.Windows.Forms.TextBox()
        Me.txttempo = New System.Windows.Forms.TextBox()
        Me.Menutempo = New System.Windows.Forms.MenuStrip()
        Me.btnnovotempo = New System.Windows.Forms.Button()
        Me.btneditartempo = New System.Windows.Forms.Button()
        Me.btnguardartempo = New System.Windows.Forms.Button()
        Me.btneliminartempo = New System.Windows.Forms.Button()
        Me.lblobrigatoriointervalodetempo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncancelartempo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnumtempo
        '
        Me.lblnumtempo.AutoSize = True
        Me.lblnumtempo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblnumtempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumtempo.ForeColor = System.Drawing.Color.Blue
        Me.lblnumtempo.Location = New System.Drawing.Point(12, 36)
        Me.lblnumtempo.Name = "lblnumtempo"
        Me.lblnumtempo.Size = New System.Drawing.Size(49, 13)
        Me.lblnumtempo.TabIndex = 0
        Me.lblnumtempo.Text = "Tempo:"
        '
        'lblintervalotempo
        '
        Me.lblintervalotempo.AutoSize = True
        Me.lblintervalotempo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblintervalotempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblintervalotempo.ForeColor = System.Drawing.Color.Blue
        Me.lblintervalotempo.Location = New System.Drawing.Point(211, 36)
        Me.lblintervalotempo.Name = "lblintervalotempo"
        Me.lblintervalotempo.Size = New System.Drawing.Size(117, 13)
        Me.lblintervalotempo.TabIndex = 1
        Me.lblintervalotempo.Text = "Intervalo de tempo:"
        '
        'txtintervalodetempo
        '
        Me.txtintervalodetempo.Enabled = False
        Me.txtintervalodetempo.Location = New System.Drawing.Point(334, 33)
        Me.txtintervalodetempo.Name = "txtintervalodetempo"
        Me.txtintervalodetempo.Size = New System.Drawing.Size(63, 20)
        Me.txtintervalodetempo.TabIndex = 2
        '
        'txttempo
        '
        Me.txttempo.Enabled = False
        Me.txttempo.Location = New System.Drawing.Point(67, 33)
        Me.txttempo.Name = "txttempo"
        Me.txttempo.Size = New System.Drawing.Size(31, 20)
        Me.txttempo.TabIndex = 3
        '
        'Menutempo
        '
        Me.Menutempo.Location = New System.Drawing.Point(0, 0)
        Me.Menutempo.Name = "Menutempo"
        Me.Menutempo.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.Menutempo.Size = New System.Drawing.Size(542, 24)
        Me.Menutempo.TabIndex = 4
        Me.Menutempo.Text = "Menutempo"
        '
        'btnnovotempo
        '
        Me.btnnovotempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnovotempo.ForeColor = System.Drawing.Color.Black
        Me.btnnovotempo.Location = New System.Drawing.Point(0, 0)
        Me.btnnovotempo.Name = "btnnovotempo"
        Me.btnnovotempo.Size = New System.Drawing.Size(77, 23)
        Me.btnnovotempo.TabIndex = 5
        Me.btnnovotempo.Text = "Novo"
        Me.btnnovotempo.UseVisualStyleBackColor = True
        '
        'btneditartempo
        '
        Me.btneditartempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditartempo.ForeColor = System.Drawing.Color.Black
        Me.btneditartempo.Location = New System.Drawing.Point(74, 0)
        Me.btneditartempo.Name = "btneditartempo"
        Me.btneditartempo.Size = New System.Drawing.Size(75, 23)
        Me.btneditartempo.TabIndex = 7
        Me.btneditartempo.Text = "Editar"
        Me.btneditartempo.UseVisualStyleBackColor = True
        '
        'btnguardartempo
        '
        Me.btnguardartempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardartempo.ForeColor = System.Drawing.Color.Black
        Me.btnguardartempo.Location = New System.Drawing.Point(214, 0)
        Me.btnguardartempo.Name = "btnguardartempo"
        Me.btnguardartempo.Size = New System.Drawing.Size(73, 23)
        Me.btnguardartempo.TabIndex = 9
        Me.btnguardartempo.Text = "Guardar"
        Me.btnguardartempo.UseVisualStyleBackColor = True
        '
        'btneliminartempo
        '
        Me.btneliminartempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminartempo.ForeColor = System.Drawing.Color.Black
        Me.btneliminartempo.Location = New System.Drawing.Point(146, 0)
        Me.btneliminartempo.Name = "btneliminartempo"
        Me.btneliminartempo.Size = New System.Drawing.Size(74, 23)
        Me.btneliminartempo.TabIndex = 6
        Me.btneliminartempo.Text = "Eliminar"
        Me.btneliminartempo.UseVisualStyleBackColor = True
        '
        'lblobrigatoriointervalodetempo
        '
        Me.lblobrigatoriointervalodetempo.AutoSize = True
        Me.lblobrigatoriointervalodetempo.Location = New System.Drawing.Point(413, 36)
        Me.lblobrigatoriointervalodetempo.Name = "lblobrigatoriointervalodetempo"
        Me.lblobrigatoriointervalodetempo.Size = New System.Drawing.Size(72, 13)
        Me.lblobrigatoriointervalodetempo.TabIndex = 12
        Me.lblobrigatoriointervalodetempo.Text = "*obrigatório"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(282, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btncancelartempo
        '
        Me.btncancelartempo.ForeColor = System.Drawing.Color.Black
        Me.btncancelartempo.Location = New System.Drawing.Point(354, 0)
        Me.btncancelartempo.Name = "btncancelartempo"
        Me.btncancelartempo.Size = New System.Drawing.Size(75, 23)
        Me.btncancelartempo.TabIndex = 13
        Me.btncancelartempo.Text = "Cancelar"
        Me.btncancelartempo.UseVisualStyleBackColor = True
        '
        'tempo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(542, 325)
        Me.Controls.Add(Me.btncancelartempo)
        Me.Controls.Add(Me.lblobrigatoriointervalodetempo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnguardartempo)
        Me.Controls.Add(Me.btneditartempo)
        Me.Controls.Add(Me.btneliminartempo)
        Me.Controls.Add(Me.btnnovotempo)
        Me.Controls.Add(Me.txttempo)
        Me.Controls.Add(Me.txtintervalodetempo)
        Me.Controls.Add(Me.lblintervalotempo)
        Me.Controls.Add(Me.lblnumtempo)
        Me.Controls.Add(Me.Menutempo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.Menutempo
        Me.Name = "tempo"
        Me.Text = "tempo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnumtempo As System.Windows.Forms.Label
    Friend WithEvents lblintervalotempo As System.Windows.Forms.Label
    Friend WithEvents txtintervalodetempo As System.Windows.Forms.TextBox
    Friend WithEvents txttempo As System.Windows.Forms.TextBox
    Friend WithEvents Menutempo As System.Windows.Forms.MenuStrip
    Friend WithEvents btnnovotempo As System.Windows.Forms.Button
    Friend WithEvents btneditartempo As System.Windows.Forms.Button
    Friend WithEvents btnguardartempo As System.Windows.Forms.Button
    Friend WithEvents btneliminartempo As System.Windows.Forms.Button
    Friend WithEvents lblobrigatoriointervalodetempo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btncancelartempo As System.Windows.Forms.Button
End Class
