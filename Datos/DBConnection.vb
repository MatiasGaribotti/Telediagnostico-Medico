Imports ADODB
Public MustInherit Class DBConnection

    Private Protected _User As String
    Private Protected _Password As String
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
    End Sub

    Public Sub New(user As String, password As String)
        _User = user
        _Password = password
    End Sub

    'Funcion que retorna una conexión a la base de datos
    Protected Function Conectar() As Connection

        Dim connection As New Connection With {
            .ConnectionString = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=127.0.0.1;" &
                                      "port=3306;" &
                                      "database=sistema_telediagnostico;" &
                                      "uid=" & _User & ";" &
                                      "pwd=" & _Password & ";"
        }
        Try
            'Intento abrir la conexión
            connection.Open()
            Return connection

        Catch ex As Exception
            Console.WriteLine("No se pudo conectar a la base de datos.")
            Return New Connection() 'retorna una conexión vacia
        End Try

    End Function

End Class
