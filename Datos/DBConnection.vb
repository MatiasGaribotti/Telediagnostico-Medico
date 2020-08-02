Imports ADODB
Public MustInherit Class DBConnection

    Protected _User As String
    Protected _Password As String
    Protected Con As Connection
    Protected _ConStr As String

    Public Property User() As String
        Get
            Return _User
        End Get
        Set(ByVal value As String)
            _User = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Public Property ConStr() As String
        Get
            Return _ConStr
        End Get
        Set(ByVal value As String)
            _ConStr = value
        End Set
    End Property

    'Funcion que retorna una conexión a la base de datos
    Protected Function Conectar() As Connection
        Con = New Connection() With {.ConnectionString = _ConStr}
        Con.Open()
        Return Con
    End Function

    Protected Function HasConnection() As Boolean
        Try
            Con = New Connection() With {.ConnectionString = _ConStr}
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
