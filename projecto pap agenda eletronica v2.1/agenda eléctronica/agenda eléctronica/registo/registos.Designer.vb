<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registo
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
        Me.lblutilizadorregistos = New System.Windows.Forms.Label()
        Me.txtutilizadorregistos = New System.Windows.Forms.TextBox()
        Me.nomeutilizadorregistos = New System.Windows.Forms.Label()
        Me.txtnomeregistos = New System.Windows.Forms.TextBox()
        Me.Combocategoriaregistos = New System.Windows.Forms.ComboBox()
        Me.lblfunçãoregistos = New System.Windows.Forms.Label()
        Me.categoriaregistos = New System.Windows.Forms.Label()
        Me.Combofunçaoregistos = New System.Windows.Forms.ComboBox()
        Me.dadosdoutilizador = New System.Windows.Forms.GroupBox()
        Me.registodedados = New System.Windows.Forms.GroupBox()
        Me.txthoraregisto = New System.Windows.Forms.TextBox()
        Me.lblhoraregisto = New System.Windows.Forms.Label()
        Me.txtdataregisto = New System.Windows.Forms.TextBox()
        Me.lbldataregistos = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblanoletivoregistos = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblnumregistos = New System.Windows.Forms.Label()
        Me.menuregistos = New System.Windows.Forms.MenuStrip()
        Me.btnnovoregisto = New System.Windows.Forms.Button()
        Me.btneditaregisto = New System.Windows.Forms.Button()
        Me.btneliminaregisto = New System.Windows.Forms.Button()
        Me.btnguardaregisto = New System.Windows.Forms.Button()
        Me.btnconsultaregistos = New System.Windows.Forms.Button()
        Me.sairegisto = New System.Windows.Forms.Button()
        Me.pesquisarregisto = New System.Windows.Forms.Button()
        Me.dadosdoutilizador.SuspendLayout()
        Me.registodedados.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblutilizadorregistos
        '
        Me.lblutilizadorregistos.AutoSize = True
        Me.lblutilizadorregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblutilizadorregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblutilizadorregistos.Location = New System.Drawing.Point(15, 31)
        Me.lblutilizadorregistos.Name = "lblutilizadorregistos"
        Me.lblutilizadorregistos.Size = New System.Drawing.Size(102, 13)
        Me.lblutilizadorregistos.TabIndex = 0
        Me.lblutilizadorregistos.Text = "Nº de utilizador :"
        '
        'txtutilizadorregistos
        '
        Me.txtutilizadorregistos.Location = New System.Drawing.Point(123, 31)
        Me.txtutilizadorregistos.Name = "txtutilizadorregistos"
        Me.txtutilizadorregistos.Size = New System.Drawing.Size(121, 20)
        Me.txtutilizadorregistos.TabIndex = 1
        '
        'nomeutilizadorregistos
        '
        Me.nomeutilizadorregistos.AutoSize = True
        Me.nomeutilizadorregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeutilizadorregistos.ForeColor = System.Drawing.Color.Blue
        Me.nomeutilizadorregistos.Location = New System.Drawing.Point(74, 63)
        Me.nomeutilizadorregistos.Name = "nomeutilizadorregistos"
        Me.nomeutilizadorregistos.Size = New System.Drawing.Size(43, 13)
        Me.nomeutilizadorregistos.TabIndex = 2
        Me.nomeutilizadorregistos.Text = "Nome:"
        '
        'txtnomeregistos
        '
        Me.txtnomeregistos.Location = New System.Drawing.Point(123, 60)
        Me.txtnomeregistos.Name = "txtnomeregistos"
        Me.txtnomeregistos.Size = New System.Drawing.Size(121, 20)
        Me.txtnomeregistos.TabIndex = 3
        '
        'Combocategoriaregistos
        '
        Me.Combocategoriaregistos.FormattingEnabled = True
        Me.Combocategoriaregistos.Location = New System.Drawing.Point(322, 86)
        Me.Combocategoriaregistos.Name = "Combocategoriaregistos"
        Me.Combocategoriaregistos.Size = New System.Drawing.Size(121, 21)
        Me.Combocategoriaregistos.TabIndex = 4
        '
        'lblfunçãoregistos
        '
        Me.lblfunçãoregistos.AutoSize = True
        Me.lblfunçãoregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfunçãoregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblfunçãoregistos.Location = New System.Drawing.Point(65, 92)
        Me.lblfunçãoregistos.Name = "lblfunçãoregistos"
        Me.lblfunçãoregistos.Size = New System.Drawing.Size(53, 13)
        Me.lblfunçãoregistos.TabIndex = 5
        Me.lblfunçãoregistos.Text = "Função:"
        '
        'categoriaregistos
        '
        Me.categoriaregistos.AutoSize = True
        Me.categoriaregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoriaregistos.ForeColor = System.Drawing.Color.Blue
        Me.categoriaregistos.Location = New System.Drawing.Point(251, 89)
        Me.categoriaregistos.Name = "categoriaregistos"
        Me.categoriaregistos.Size = New System.Drawing.Size(65, 13)
        Me.categoriaregistos.TabIndex = 6
        Me.categoriaregistos.Text = "Categoria:"
        '
        'Combofunçaoregistos
        '
        Me.Combofunçaoregistos.FormattingEnabled = True
        Me.Combofunçaoregistos.Location = New System.Drawing.Point(124, 86)
        Me.Combofunçaoregistos.Name = "Combofunçaoregistos"
        Me.Combofunçaoregistos.Size = New System.Drawing.Size(121, 21)
        Me.Combofunçaoregistos.TabIndex = 7
        '
        'dadosdoutilizador
        '
        Me.dadosdoutilizador.Controls.Add(Me.txtnomeregistos)
        Me.dadosdoutilizador.Controls.Add(Me.Combofunçaoregistos)
        Me.dadosdoutilizador.Controls.Add(Me.lblutilizadorregistos)
        Me.dadosdoutilizador.Controls.Add(Me.categoriaregistos)
        Me.dadosdoutilizador.Controls.Add(Me.txtutilizadorregistos)
        Me.dadosdoutilizador.Controls.Add(Me.lblfunçãoregistos)
        Me.dadosdoutilizador.Controls.Add(Me.nomeutilizadorregistos)
        Me.dadosdoutilizador.Controls.Add(Me.Combocategoriaregistos)
        Me.dadosdoutilizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dadosdoutilizador.Location = New System.Drawing.Point(13, 41)
        Me.dadosdoutilizador.Name = "dadosdoutilizador"
        Me.dadosdoutilizador.Size = New System.Drawing.Size(498, 142)
        Me.dadosdoutilizador.TabIndex = 8
        Me.dadosdoutilizador.TabStop = False
        Me.dadosdoutilizador.Text = "  Dados o Utilizador"
        '
        'registodedados
        '
        Me.registodedados.Controls.Add(Me.txthoraregisto)
        Me.registodedados.Controls.Add(Me.lblhoraregisto)
        Me.registodedados.Controls.Add(Me.txtdataregisto)
        Me.registodedados.Controls.Add(Me.lbldataregistos)
        Me.registodedados.Controls.Add(Me.TextBox2)
        Me.registodedados.Controls.Add(Me.lblanoletivoregistos)
        Me.registodedados.Controls.Add(Me.TextBox1)
        Me.registodedados.Controls.Add(Me.lblnumregistos)
        Me.registodedados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registodedados.Location = New System.Drawing.Point(13, 204)
        Me.registodedados.Name = "registodedados"
        Me.registodedados.Size = New System.Drawing.Size(498, 130)
        Me.registodedados.TabIndex = 9
        Me.registodedados.TabStop = False
        Me.registodedados.Text = "Registo de Dados"
        '
        'txthoraregisto
        '
        Me.txthoraregisto.Location = New System.Drawing.Point(281, 61)
        Me.txthoraregisto.Name = "txthoraregisto"
        Me.txthoraregisto.Size = New System.Drawing.Size(100, 20)
        Me.txthoraregisto.TabIndex = 7
        '
        'lblhoraregisto
        '
        Me.lblhoraregisto.AutoSize = True
        Me.lblhoraregisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoraregisto.ForeColor = System.Drawing.Color.Blue
        Me.lblhoraregisto.Location = New System.Drawing.Point(233, 64)
        Me.lblhoraregisto.Name = "lblhoraregisto"
        Me.lblhoraregisto.Size = New System.Drawing.Size(42, 13)
        Me.lblhoraregisto.TabIndex = 6
        Me.lblhoraregisto.Text = "Hora :"
        '
        'txtdataregisto
        '
        Me.txtdataregisto.Location = New System.Drawing.Point(100, 61)
        Me.txtdataregisto.Name = "txtdataregisto"
        Me.txtdataregisto.Size = New System.Drawing.Size(100, 20)
        Me.txtdataregisto.TabIndex = 5
        '
        'lbldataregistos
        '
        Me.lbldataregistos.AutoSize = True
        Me.lbldataregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldataregistos.ForeColor = System.Drawing.Color.Blue
        Me.lbldataregistos.Location = New System.Drawing.Point(52, 64)
        Me.lbldataregistos.Name = "lbldataregistos"
        Me.lbldataregistos.Size = New System.Drawing.Size(42, 13)
        Me.lbldataregistos.TabIndex = 4
        Me.lbldataregistos.Text = "Data :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(413, 31)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(68, 20)
        Me.TextBox2.TabIndex = 3
        '
        'lblanoletivoregistos
        '
        Me.lblanoletivoregistos.AutoSize = True
        Me.lblanoletivoregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanoletivoregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblanoletivoregistos.Location = New System.Drawing.Point(335, 34)
        Me.lblanoletivoregistos.Name = "lblanoletivoregistos"
        Me.lblanoletivoregistos.Size = New System.Drawing.Size(72, 13)
        Me.lblanoletivoregistos.TabIndex = 2
        Me.lblanoletivoregistos.Text = "Ano Letivo:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblnumregistos
        '
        Me.lblnumregistos.AutoSize = True
        Me.lblnumregistos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumregistos.ForeColor = System.Drawing.Color.Blue
        Me.lblnumregistos.Location = New System.Drawing.Point(16, 34)
        Me.lblnumregistos.Name = "lblnumregistos"
        Me.lblnumregistos.Size = New System.Drawing.Size(78, 13)
        Me.lblnumregistos.TabIndex = 0
        Me.lblnumregistos.Text = "Nº Registos:"
        '
        'menuregistos
        '
        Me.menuregistos.Location = New System.Drawing.Point(0, 0)
        Me.menuregistos.Name = "menuregistos"
        Me.menuregistos.Size = New System.Drawing.Size(544, 24)
        Me.menuregistos.TabIndex = 10
        Me.menuregistos.Text = "menuregistos"
        '
        'btnnovoregisto
        '
        Me.btnnovoregisto.Location = New System.Drawing.Point(0, 0)
        Me.btnnovoregisto.Name = "btnnovoregisto"
        Me.btnnovoregisto.Size = New System.Drawing.Size(75, 23)
        Me.btnnovoregisto.TabIndex = 11
        Me.btnnovoregisto.Text = "Novo"
        Me.btnnovoregisto.UseVisualStyleBackColor = True
        '
        'btneditaregisto
        '
        Me.btneditaregisto.Location = New System.Drawing.Point(73, 0)
        Me.btneditaregisto.Name = "btneditaregisto"
        Me.btneditaregisto.Size = New System.Drawing.Size(75, 23)
        Me.btneditaregisto.TabIndex = 12
        Me.btneditaregisto.Text = "Editar"
        Me.btneditaregisto.UseVisualStyleBackColor = True
        '
        'btneliminaregisto
        '
        Me.btneliminaregisto.Location = New System.Drawing.Point(144, 0)
        Me.btneliminaregisto.Name = "btneliminaregisto"
        Me.btneliminaregisto.Size = New System.Drawing.Size(75, 23)
        Me.btneliminaregisto.TabIndex = 13
        Me.btneliminaregisto.Text = "Eliminar"
        Me.btneliminaregisto.UseVisualStyleBackColor = True
        '
        'btnguardaregisto
        '
        Me.btnguardaregisto.Location = New System.Drawing.Point(215, 0)
        Me.btnguardaregisto.Name = "btnguardaregisto"
        Me.btnguardaregisto.Size = New System.Drawing.Size(75, 23)
        Me.btnguardaregisto.TabIndex = 14
        Me.btnguardaregisto.Text = "Guardar"
        Me.btnguardaregisto.UseVisualStyleBackColor = True
        '
        'btnconsultaregistos
        '
        Me.btnconsultaregistos.Location = New System.Drawing.Point(284, 0)
        Me.btnconsultaregistos.Name = "btnconsultaregistos"
        Me.btnconsultaregistos.Size = New System.Drawing.Size(75, 23)
        Me.btnconsultaregistos.TabIndex = 15
        Me.btnconsultaregistos.Text = "Consultar"
        Me.btnconsultaregistos.UseVisualStyleBackColor = True
        '
        'sairegisto
        '
        Me.sairegisto.Location = New System.Drawing.Point(423, 0)
        Me.sairegisto.Name = "sairegisto"
        Me.sairegisto.Size = New System.Drawing.Size(75, 23)
        Me.sairegisto.TabIndex = 16
        Me.sairegisto.Text = "Sair"
        Me.sairegisto.UseVisualStyleBackColor = True
        '
        'pesquisarregisto
        '
        Me.pesquisarregisto.Location = New System.Drawing.Point(352, 0)
        Me.pesquisarregisto.Name = "pesquisarregisto"
        Me.pesquisarregisto.Size = New System.Drawing.Size(75, 23)
        Me.pesquisarregisto.TabIndex = 17
        Me.pesquisarregisto.Text = "Pesquisar"
        Me.pesquisarregisto.UseVisualStyleBackColor = True
        '
        'Registo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(544, 470)
        Me.Controls.Add(Me.sairegisto)
        Me.Controls.Add(Me.btnconsultaregistos)
        Me.Controls.Add(Me.pesquisarregisto)
        Me.Controls.Add(Me.btnguardaregisto)
        Me.Controls.Add(Me.btneliminaregisto)
        Me.Controls.Add(Me.btneditaregisto)
        Me.Controls.Add(Me.btnnovoregisto)
        Me.Controls.Add(Me.registodedados)
        Me.Controls.Add(Me.dadosdoutilizador)
        Me.Controls.Add(Me.menuregistos)
        Me.MainMenuStrip = Me.menuregistos
        Me.Name = "Registo"
        Me.Text = "registos"
        Me.dadosdoutilizador.ResumeLayout(False)
        Me.dadosdoutilizador.PerformLayout()
        Me.registodedados.ResumeLayout(False)
        Me.registodedados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblutilizadorregistos As Label
    Friend WithEvents txtutilizadorregistos As TextBox
    Friend WithEvents nomeutilizadorregistos As Label
    Friend WithEvents txtnomeregistos As TextBox
    Friend WithEvents Combocategoriaregistos As ComboBox
    Friend WithEvents lblfunçãoregistos As Label
    Friend WithEvents categoriaregistos As Label
    Friend WithEvents Combofunçaoregistos As ComboBox
    Friend WithEvents dadosdoutilizador As GroupBox
    Friend WithEvents registodedados As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblanoletivoregistos As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblnumregistos As Label
    Friend WithEvents txthoraregisto As TextBox
    Friend WithEvents lblhoraregisto As Label
    Friend WithEvents txtdataregisto As TextBox
    Friend WithEvents lbldataregistos As Label
    Friend WithEvents menuregistos As MenuStrip
    Friend WithEvents btnnovoregisto As Button
    Friend WithEvents btneditaregisto As Button
    Friend WithEvents btneliminaregisto As Button
    Friend WithEvents btnguardaregisto As Button
    Friend WithEvents btnconsultaregistos As Button
    Friend WithEvents sairegisto As Button
    Friend WithEvents pesquisarregisto As Button
End Class
