Public Class formulario_principal

    Public Sub Bloquear_menu(ByVal estado As Boolean)
        tsbUtilizador.Enabled = estado
        tsbCategoria.Enabled = estado
        tsbHorario.Enabled = estado
        'tsbRegistos.Enabled = estado
        tsbFuncao.Enabled = estado
        tsbEspaco.Enabled = estado
        tsbDiaSemana.Enabled = estado
        tsbuser.Enabled = estado
    End Sub

    Private Sub UtilizadorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Utilizadores.MdiParent = Me
        Utilizadores.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Pretende fechar a aplicação?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            login.Close()
        End If
    End Sub

    Private Sub FunçãoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        função.Show()
    End Sub

    Private Sub HorarioToolStripMenuItem_Click(sender As Object, e As EventArgs)

        horario.Show()

    End Sub

    Private Sub EspaçoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        blocoSala.MdiParent = Me
        blocoSala.Show()

    End Sub


    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub formulario_principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        'If MessageBox.Show("Pretende fechar a aplicação?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        'Me.Close()
        'End If
        'login.Close()
    End Sub

    Private Sub tsbCategoria_Click(sender As Object, e As EventArgs) Handles tsbCategoria.Click
        categoria.MdiParent = Me
        categoria.Show()
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click

        If MessageBox.Show("Pretende fechar a aplicação?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            login.Close()
        End If

    End Sub

    Private Sub tsbEspaco_Click(sender As Object, e As EventArgs) Handles tsbEspaco.Click
        blocoSala.MdiParent = Me
        blocoSala.Show()
    End Sub

    Private Sub tsbUtilizador_Click(sender As Object, e As EventArgs) Handles tsbUtilizador.Click
        Utilizadores.Show()
        Utilizadores.MdiParent = Me
    End Sub

    Private Sub tsbHorario_Click(sender As Object, e As EventArgs) Handles tsbHorario.Click
        horario.MdiParent = Me
        horario.Show()
    End Sub

    Private Sub tsbRegistos_Click(sender As Object, e As EventArgs) Handles tsbRegistos.Click
        Registo.MdiParent = Me
        Registo.Show()
    End Sub

    Private Sub tsbFuncao_Click(sender As Object, e As EventArgs) Handles tsbFuncao.Click
        função.MdiParent = Me
        função.Show()
    End Sub

    Private Sub HorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorasToolStripMenuItem.Click
        tempo.MdiParent = Me
        tempo.Show()
    End Sub

    Private Sub DiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiasToolStripMenuItem.Click
        dias.MdiParent = Me
        dias.Show()
    End Sub

    Private Sub DisciplinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisciplinasToolStripMenuItem.Click
        Disciplina.MdiParent = Me
        Disciplina.Show()
    End Sub

    Private Sub AreaDisciplinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaDisciplinaToolStripMenuItem.Click
        Area.MdiParent = Me
        Area.Show()
    End Sub

    Private Sub formulario_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tipouser = "0" Then
            'MsgBox("Utilizador Padrão")
            Bloquear_menu(False)
        ElseIf tipouser = "1" Then
            'MsgBox("Administrador")
            Bloquear_menu(True)
        End If
        tsbuser.Text = user
    End Sub

    Private Sub tsbDiaSemana_ButtonClick(sender As Object, e As EventArgs) Handles tsbDiaSemana.ButtonClick

    End Sub

    Private Sub AnoLetivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnoLetivoToolStripMenuItem.Click
        ano_letivo.MdiParent = Me
        ano_letivo.Show()
    End Sub

    Private Sub TurmaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurmaToolStripMenuItem.Click
        turma.MdiParent = Me
        turma.Show()
    End Sub
End Class
