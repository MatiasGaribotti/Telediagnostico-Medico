Imports ADODB
Public MustInherit Class DBConnection
    Public Property User() As String
    Public Property Password() As String
    Public Property ConStr() As String

    Public Sub New()
        Me.User = "admin"
        Me.Password = "123456789"
        Me.ConStr = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=192.168.1.131;" &
                                      "port=3306;" &
                                      "database=sistema_telediagnostico;" &
                                      "uid=" & Me.User & ";" &
                                      "pwd=" & Me.Password & ";"
    End Sub

    Public Sub New(user As String, password As String)
        Me.User = user
        Me.Password = password
        Me.ConStr = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=192.168.1.131;" &
                                      "port=3306;" &
                                      "database=sistema_telediagnostico;" &
                                      "uid=" & Me.User & ";" &
                                      "pwd=" & Me.Password & ";"
    End Sub

    'Funcion que retorna una conexión a la base de datos
    Protected Function Conectar() As Connection
        Dim Con = New Connection() With {.ConnectionString = Me.ConStr}
        Con.Open()
        Return Con
    End Function

    Protected Function HasConnection() As Boolean
        Try
            Dim Con = New Connection() With {.ConnectionString = Me.ConStr}
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
