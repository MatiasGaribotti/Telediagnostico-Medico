Imports ADODB
Public MustInherit Class DBConnection
    Public Property DB_User() As String
    Public Property DB_Password() As String
    Public Property ConStr() As String
    Public Sub New()
        CredentialsByUserType(-1)
        SetConnectionString()
    End Sub

    Public Sub New(userType As Short)
        CredentialsByUserType(userType)
        SetConnectionString()
    End Sub

    'Funcion que retorna una conexión a la base de datos
    Protected Function Conectar() As Connection
        Try
            Dim Con = New Connection() With {.ConnectionString = ConStr}
            Con.Open()
            Return Con
        Catch ex As Exception
            Throw New ApplicationException("Error al conectar con la base de datos")
        End Try
    End Function

    Protected Function HasConnection() As Boolean
        Try
            Dim Con = New Connection() With {.ConnectionString = Me.ConStr}
            'Intento abrir la conexión
            Con.Open()
            Con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Protected Sub CredentialsByUserType(userType As Short)
        Select Case userType
            Case -1
                Me.DB_User = "system"
                Me.DB_Password = "kHzRj1&5"
            'Paciente
            Case 0
                Me.DB_User = "paciente"
                Me.DB_Password = "dbpacienteST"
            'Medico
            Case 1


            'Administrador
            Case 2
                Me.DB_User = "administrador"
                Me.DB_Password = "dbadminST"
            'RRHH
            Case 3
                Me.DB_User = "rrhh"
                Me.DB_Password = "dbrrhhST"
            'Recepcionista
            Case 4
                Me.DB_User = "recepcionista"
                Me.DB_Password = "dbrecepcionistaST"
        End Select
    End Sub
    Private Sub SetConnectionString()
        Me.ConStr = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=192.168.1.131;" &
                                      "port=3306;" &
                                      "database=sistema_telediagnostico;" &
                                      "uid=" & Me.DB_User & ";" &
                                      "pwd=" & Me.DB_Password & ";"
    End Sub
End Class
