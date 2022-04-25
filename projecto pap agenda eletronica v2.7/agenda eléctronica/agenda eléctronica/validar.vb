Imports System.Text
Imports System.Text.RegularExpressions
Public Class validar
    Public Shared Function isvalidtelefone(ByVal telefone As String) As Boolean
        Dim padraoregex As String = "^[20-30]{2}[0-9]{7}$"
        Dim verifica As New regularexpressions.Regex(padraoregex)
        Dim valida As Boolean = False
        If telefone = "" Then
            valida = False
        Else
            valida = verifica.IsMatch(telefone, 0)
        End If
        Return valida
    End Function

    Public Shared Function isValidDataDDMMYYYY(ByVal ddmmyyyy As String) As Boolean
        Dim padraoRegex As String = "^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02]))\/\d{4}$"
        Dim verifica As New RegularExpressions.Regex(padraoRegex)
        Dim valida As Boolean = False
        If ddmmyyyy = "" Then
            valida = False
        Else
            valida = verifica.IsMatch(ddmmyyyy, 0)
        End If
        Return valida
    End Function
End Class
