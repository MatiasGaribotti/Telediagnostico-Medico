Imports MySql.Data.MySqlClient

Public Class DBConnection

    Private Function Conectar() As MySqlConnection
        Dim conexion As New MySqlConnection()
        conexion.ConnectionString = "server=127.0.0.1; port=3306; database=sistema_telediagnostico; uid=root; pwd="
        conexion.Open()

        Return conexion
    End Function

    Private Function HasConnection() As Boolean
        Try
            Dim bd As MySqlConnection = Conectar()
            bd.Open()
            bd.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
