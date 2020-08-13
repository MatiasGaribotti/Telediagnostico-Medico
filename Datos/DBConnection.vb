Imports ADODB
Public MustInherit Class DBConnection
    Protected Property Con As Connection
    Public Property User() As String
    Public Property Password() As String
    Public Property ConStr() As String

    'Funcion que retorna una conexión a la base de datos
    Protected Function Conectar() As Connection
        Con = New Connection() With {.ConnectionString = Me.ConStr}
        Con.Open()
        Return Con
    End Function

    Protected Function HasConnection() As Boolean
        Try
            Con = New Connection() With {.ConnectionString = Me.ConStr}
            'Intento abrir la conexión
            Con.Open()
            Con.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function
End Class
