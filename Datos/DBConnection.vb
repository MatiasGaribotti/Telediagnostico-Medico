Imports ADODB
Imports Dominio
Public MustInherit Class DBConnection

    Protected Property Conn As Connection
    Private Property ConStr As String

    Public Sub New()
        CredentialsByUserType()
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

    Private Sub CredentialsByUserType()
        If Env.CurrentUser.IsPaciente Then
            SetConnectionString("paciente", "dbpacienteST")

        ElseIf Env.CurrentUser.IsMedico Then
            SetConnectionString("medico", "dbmedicoST")

        ElseIf Env.CurrentUser.IsAdministrador Then
            SetConnectionString("administrador", "dbadminST")

        ElseIf Env.CurrentUser.IsRRHH Then
            SetConnectionString("rrhh", "dbrrhhST")

        ElseIf Env.CurrentUser.IsRecepcionista Then
            SetConnectionString("recepcionista", "dbrecepcionistaST")

        Else
            SetConnectionString("system", "kHzRj1&5")

        End If

    End Sub

    Private Sub SetConnectionString(user As String, password As String)
        ConStr = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=192.168.1.131;" &
                                      "port=3306;" &
                                      "database=sistema_telediagnostico;" &
                                      "uid=" & user & ";" &
                                      "pwd=" & password & ";"
    End Sub
End Class
