Public Class formulario_principal

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
        espaço.Show()

    End Sub

    Private Sub RegistosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Registo.Show()

    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub formulario_principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        login.Close()
        If MessageBox.Show("Pretende fechar a aplicação?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then

        Else
            Me.Close()
        End If
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
        espaço.Show()
    End Sub

    Private Sub tsbUtilizador_Click(sender As Object, e As EventArgs) Handles tsbUtilizador.Click
        Utilizadores.Show()
        Utilizadores.MdiParent = Me
    End Sub

    Private Sub tsbHorario_Click(sender As Object, e As EventArgs) Handles tsbHorario.Click
        horario.Show()
    End Sub

    Private Sub tsbRegistos_Click(sender As Object, e As EventArgs) Handles tsbRegistos.Click
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

    Private Sub BlocoSalaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoSalaToolStripMenuItem.Click
        blocoSala.MdiParent = Me
        blocoSala.Show()
    End Sub
End Class
