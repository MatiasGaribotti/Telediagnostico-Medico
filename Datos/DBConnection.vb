Imports ADODB
Public MustInherit Class DBConnection
    Public Property DB_User() As String
    Public Property DB_Password() As String
    Public Property ConStr() As String

    Public Sub New()
        Me.DB_User = "system"
        Me.DB_Password = "kHzRj1&5"
        Me.ConStr = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=192.168.1.131;" &
                                      "port=3306;" &
                                      "database=sistema_telediagnostico;" &
                                      "uid=" & Me.DB_User & ";" &
                                      "pwd=" & Me.DB_Password & ";"
    End Sub

    Public Sub New(user As String, password As String)
        Me.DB_User = user
        Me.DB_Password = password
        Me.ConStr = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=192.168.1.131;" &
                                      "port=3306;" &
                                      "database=sistema_telediagnostico;" &
                                      "uid=" & Me.DB_User & ";" &
                                      "pwd=" & Me.DB_Password & ";"
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
