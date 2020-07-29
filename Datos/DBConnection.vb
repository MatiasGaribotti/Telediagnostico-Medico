Imports MySql.Data.MySqlClient

Public Class DBConnection
    Private ReadOnly ConnectionString As String = "server=127.0.0.1; port=3306; database=sistema_telediagnostico; uid=root; pwd="

    Private Function Conectar() As MySqlConnection
        Dim conexion As New MySqlConnection(ConnectionString)
        Try
            conexion.Open()
            Return conexion
        Catch ex As Exception
            Return New MySqlConnection()
        End Try
    End Function

    Public Function HasConnection() As Boolean
        Try
            Dim bd As New MySqlConnection(ConnectionString)
            bd.Open()
            bd.Close()
            Return True
        Catch ex As Exception
            Console.WriteLine("No hay Conexion con la base de datos." & vbCrLf & "Error:" & ex.Message)
            Return False
        End Try

    End Function

End Class
