Imports ADODB
Imports Dominio
Public Class AuthenticationDAO
    Inherits DBConnection
    Public Sub New()
        MyBase.New()
    End Sub

    Public Function Find(ci As Integer, password As String) As Persona
        Dim user As Persona
        Dim rs As Recordset
        Dim query As String = "SELECT esPaciente, esEmpleado, esMedico, extendido, esRRHH, esRecepcionista FROM personas WHERE ci='" & ci & "' AND password='" & password & "';"


        Dim con = Connect()
        Try
            rs = con.Execute(query)

            ' Si BOF es True, entonces estoy antes del primer registro
            ' esto significa que no se encontraron registros.
            If Not rs.BOF Then
                Dim isPaciente, isEmpleado, isMedico, isAdministrador, isRRHH, isRecepcionista As Boolean

                isPaciente = CBool(rs.Fields("esPaciente").Value)
                isEmpleado = CBool(rs.Fields("esEmpleado").Value)
                isMedico = CBool(rs.Fields("esMedico").Value)
                isAdministrador = CBool(rs.Fields("extendido").Value)
                isRRHH = CBool(rs.Fields("esRRHH").Value)
                isRecepcionista = CBool(rs.Fields("esRecepcionista").Value)

                user = New Persona(ci,
                                   password,
                                   isPaciente,
                                   isEmpleado,
                                   isMedico,
                                   isAdministrador,
                                   isRRHH,
                                   isRecepcionista
                                   )
            Else
                'Arrojo una exception
                Throw New KeyNotFoundException("Usuario no encontrado")
            End If
        Catch ex As Exception
            Throw ex
        Finally
            con.Close()
        End Try


        Return user
    End Function
End Class
