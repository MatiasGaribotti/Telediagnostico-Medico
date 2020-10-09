Imports ADODB
Imports Dominio
Public MustInherit Class DBConnection

    Protected Shared Property Conn As Connection
    Private Property ConStr As String

    Public Sub New()
        CredentialsByUserType()
    End Sub

    'Funcion que retorna una conexión a la base de datos
    ''' <summary>
    ''' Función que inicia una conexión con la base de datos.
    ''' </summary>
    ''' <returns>Retorna una conexión abierta con la base de datos</returns>
    ''' <exception cref="ApplicationException">Tirada cuando no ocurre un error al conectar con la base de datos o cuando no hay conexión con el servidor de bases de datos.</exception>
    Protected Function Connect() As Connection
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

    ''' <summary>
    ''' Función que evalua si hay conexión con el servidor de bases de datos.
    ''' </summary>
    ''' <returns>Retorna True si hay conexión con el servidor de bases de datos, de lo contrario retorna False.</returns>
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

    ''' <summary>
    ''' Procedimiento que configura las credenciales para el acceso a la base de datos, dependiendo de qué tipo de usuario sea el que va a ingresar.
    ''' </summary>
    Private Sub CredentialsByUserType()
        If Env.CurrentUser.IsPaciente Then
            SetConnectionString("paciente", "dbpacienteST")

        ElseIf Env.CurrentUser.IsMedico Then
            If Env.CurrentUser.IsAdministrador And Env.CurrentApp = Env.Apps.Gestion Then
                SetConnectionString("administrador", "dbadminST")
            Else
                SetConnectionString("medico", "dbmedicoST")

            End If

        ElseIf Env.CurrentUser.IsRRHH Then
                SetConnectionString("rrhh", "dbrrhhST")

            ElseIf Env.CurrentUser.IsRecepcionista Then
                SetConnectionString("recepcionista", "dbrecepcionistaST")

            Else
                SetConnectionString("system", "kHzRj1&5")

        End If

    End Sub

    ''' <summary>
    ''' Función que configura el string de conexión con la base de datos.
    ''' </summary>
    ''' <param name="user">Usuario de la base de datos.</param>
    ''' <param name="password">Contaseña del usuario de la base de datos.</param>
    Private Sub SetConnectionString(user As String, password As String)
        ConStr = "Driver={MYSQL ODBC 8.0 Unicode Driver};" &
                                      "server=localhost;" &
                                      "database=sistema_telediagnostico;" &
                                      "uid=" & user & ";" &
                                      "pwd=" & password & ";"
    End Sub
End Class
