Imports System.Data.SqlClient
Module ligacaoBD
    Public tipouser As Integer
    Public user As String
    Public con As New SqlConnection
    Public comando As New SqlCommand
    Public ConnectionString_new As String = "Data Source=.\;Initial Catalog=Agenda;Integrated Security=True"

    Public Sub Bloquear_menu(ByVal estado As Boolean)
        formulario_principal.tsbUtilizador.Enabled = estado
        formulario_principal.tsbCategoria.Enabled = estado
        formulario_principal.tsbHorario.Enabled = estado
        formulario_principal.tsbRegistos.Enabled = estado
        formulario_principal.tsbFuncao.Enabled = estado
        formulario_principal.tsbEspaco.Enabled = estado
        formulario_principal.tsbDiaSemana.Enabled = estado
        formulario_principal.tsbSair.Enabled = estado
    End Sub

    Public Function conectar()
        con.Close()
        con.ConnectionString = "Data Source=.\;Initial Catalog=Agenda;Integrated Security=True"
        con.Open()
        comando.Connection = con
        Return True
    End Function

    Public Function desconectar()
        con.Close()
        Return True
    End Function


End Module
