Imports System.Data.SqlClient
Module ligacaoBD
    Public con As New SqlConnection
    Public comando As New SqlCommand

    Public Function conectar()
        con.Close()
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True"
        con.Open()
        comando.Connection = con
        Return True
    End Function

    Public Function desconectar()
        con.Close()
        Return True
    End Function


End Module
