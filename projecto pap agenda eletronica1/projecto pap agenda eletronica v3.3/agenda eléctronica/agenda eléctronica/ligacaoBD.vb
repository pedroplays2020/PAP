Imports System.Data.SqlClient
Module ligacaoBD
    Public tipouser As Integer
    Public user As String
    Public con As New SqlConnection
    Public comando As New SqlCommand

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
