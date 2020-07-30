Imports MySql.Data.MySqlClient

Public MustInherit Class DBConnection
    Protected User As String
    Protected Password As String
    Protected ConnectionString As String = "server=127.0.0.1; port=3306; database=sistema_telediagnostico;uid=" & User & "; pwd=" & Password

    Protected Sub New()

    End Sub

    Protected Sub New(user As String, password As String)
        Me.User = user
        Me.Password = password
    End Sub

    Protected Function Conectar() As MySqlConnection
        Dim conexion As New MySqlConnection(ConnectionString)
        Try
            conexion.Open()
            Return conexion
        Catch ex As Exception
            Return New MySqlConnection()
        End Try
    End Function

    Protected Function HasConnection() As Boolean
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
