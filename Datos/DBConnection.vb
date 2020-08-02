Imports ADODB
Public MustInherit Class DBConnection

    Protected _User As String
    Protected _Password As String
    Protected _Con As Connection

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

    Protected Sub New()
        _User = "root"
        _Password = ""

        _Con = New Connection() With {.ConnectionString = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=127.0.0.1;" &
                                      "port=3306;" &
                                      "database=sistema_telediagnostico;" &
                                      "uid=" & _User & ";" &
                                      "pwd=" & _Password & ";"
                                      }
    End Sub

    Public Sub New(user As String, password As String)
        _User = user
        _Password = password
        _Con.ConnectionString = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=127.0.0.1;" &
                                      "port=3306;" &
                                      "database=sistema_telediagnostico;" &
                                      "uid=" & _User & ";" &
                                      "pwd=" & _Password & ";"
    End Sub

    'Funcion que retorna una conexión a la base de datos
    Protected Function Conectar() As Connection
        _Con.Open()
        Return _Con
    End Function

    Protected Function HasConnection() As Boolean
        Try
            _Con.Open()
            'Intento abrir la conexión
            _Con.Open()
            _Con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function
End Class
