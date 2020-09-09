Imports ADODB
Imports Dominio
Public MustInherit Class DBConnection

    Protected Property Conn As Connection
    Public Property DB_User() As String
    Public Property DB_Password() As String
    Public Property ConStr() As String
    Public Sub New()
        CredentialsByUserType()
        SetConnectionString()
    End Sub

    'Funcion que retorna una conexión a la base de datos
    Protected Function Conectar() As Connection
        Conn = New Connection() With {.ConnectionString = ConStr}
        If HasConnection() Then
            Try
                Conn.Open()
                Return Conn
            Catch ex As Exception
                Throw New ApplicationException("Error al conectar con la base de datos")
            End Try
        Else
            Throw New ApplicationException("No hay conexión con la base de datos.")
        End If
    End Function

    Private Function HasConnection() As Boolean
        Try
            'Intento abrir la conexión
            Conn.Open()
            Conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Protected Sub CredentialsByUserType()
        Select Case Env.UserType
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
