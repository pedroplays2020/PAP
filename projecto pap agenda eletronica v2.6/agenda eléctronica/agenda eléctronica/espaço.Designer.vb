<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class espaço
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.numespaço = New System.Windows.Forms.Label()
        Me.lblnomeespaço = New System.Windows.Forms.Label()
        Me.lbltipoespaço = New System.Windows.Forms.Label()
        Me.Comboespaço = New System.Windows.Forms.ComboBox()
        Me.txtnomeespaço = New System.Windows.Forms.TextBox()
        Me.txtnumespaço = New System.Windows.Forms.TextBox()
        Me.btnovoespaco = New System.Windows.Forms.Button()
        Me.btneditarespaço = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'numespaço
        '
        Me.numespaço.AutoSize = True
        Me.numespaço.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numespaço.ForeColor = System.Drawing.Color.Blue
        Me.numespaço.Location = New System.Drawing.Point(22, 45)
        Me.numespaço.Name = "numespaço"
        Me.numespaço.Size = New System.Drawing.Size(66, 13)
        Me.numespaço.TabIndex = 1
        Me.numespaço.Text = "Nº espaço"
        '
        'lblnomeespaço
        '
        Me.lblnomeespaço.AutoSize = True
        Me.lblnomeespaço.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeespaço.ForeColor = System.Drawing.Color.Blue
        Me.lblnomeespaço.Location = New System.Drawing.Point(22, 95)
        Me.lblnomeespaço.Name = "lblnomeespaço"
        Me.lblnomeespaço.Size = New System.Drawing.Size(106, 13)
        Me.lblnomeespaço.TabIndex = 2
        Me.lblnomeespaço.Text = "Nome do espaço "
        '
        'lbltipoespaço
        '
        Me.lbltipoespaço.AutoSize = True
        Me.lbltipoespaço.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipoespaço.ForeColor = System.Drawing.Color.Blue
        Me.lbltipoespaço.Location = New System.Drawing.Point(22, 156)
        Me.lbltipoespaço.Name = "lbltipoespaço"
        Me.lbltipoespaço.Size = New System.Drawing.Size(95, 13)
        Me.lbltipoespaço.TabIndex = 3
        Me.lbltipoespaço.Text = "tipo de espaço "
        '
        'Comboespaço
        '
        Me.Comboespaço.FormattingEnabled = True
        Me.Comboespaço.Items.AddRange(New Object() {"PBX", "Sala", "Direção ", "Portaria", "Pavilhão Desportivo", "", ""})
        Me.Comboespaço.Location = New System.Drawing.Point(143, 153)
        Me.Comboespaço.Name = "Comboespaço"
        Me.Comboespaço.Size = New System.Drawing.Size(121, 21)
        Me.Comboespaço.TabIndex = 4
        '
        'txtnomeespaço
        '
        Me.txtnomeespaço.Location = New System.Drawing.Point(143, 95)
        Me.txtnomeespaço.Name = "txtnomeespaço"
        Me.txtnomeespaço.Size = New System.Drawing.Size(121, 20)
        Me.txtnomeespaço.TabIndex = 5
        '
        'txtnumespaço
        '
        Me.txtnumespaço.Location = New System.Drawing.Point(143, 42)
        Me.txtnumespaço.Name = "txtnumespaço"
        Me.txtnumespaço.Size = New System.Drawing.Size(121, 20)
        Me.txtnumespaço.TabIndex = 6
        '
        'btnovoespaco
        '
        Me.btnovoespaco.Location = New System.Drawing.Point(0, 1)
        Me.btnovoespaco.Name = "btnovoespaco"
        Me.btnovoespaco.Size = New System.Drawing.Size(75, 23)
        Me.btnovoespaco.TabIndex = 7
        Me.btnovoespaco.Text = "Novo"
        Me.btnovoespaco.UseVisualStyleBackColor = True
        '
        'btneditarespaço
        '
        Me.btneditarespaço.Location = New System.Drawing.Point(71, 0)
        Me.btneditarespaço.Name = "btneditarespaço"
        Me.btneditarespaço.Size = New System.Drawing.Size(75, 23)
        Me.btneditarespaço.TabIndex = 8
        Me.btneditarespaço.Text = "Button2"
        Me.btneditarespaço.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(143, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(215, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(287, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(359, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(430, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'espaço
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(554, 259)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btneditarespaço)
        Me.Controls.Add(Me.btnovoespaco)
        Me.Controls.Add(Me.txtnumespaço)
        Me.Controls.Add(Me.txtnomeespaço)
        Me.Controls.Add(Me.Comboespaço)
        Me.Controls.Add(Me.lbltipoespaço)
        Me.Controls.Add(Me.lblnomeespaço)
        Me.Controls.Add(Me.numespaço)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "espaço"
        Me.Text = "espaço"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents numespaço As Label
    Friend WithEvents lblnomeespaço As Label
    Friend WithEvents lbltipoespaço As Label
    Friend WithEvents Comboespaço As ComboBox
    Friend WithEvents txtnomeespaço As TextBox
    Friend WithEvents txtnumespaço As TextBox
    Friend WithEvents btnovoespaco As Button
    Friend WithEvents btneditarespaço As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
