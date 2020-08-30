Imports ADODB
Public Class DAuthentication
    Inherits DBConnection
    Public Sub New()
        MyBase.New()
    End Sub

    Public Function Find(ci As Integer, password As String) As List(Of Boolean)
        Dim dataFound As New List(Of Boolean)
        Dim rs As Recordset
        Dim query As String = "SELECT esMedico, extendido, esPaciente, esPersonalRRHH, esRecepcionista FROM personas WHERE ci='" & ci & "' AND password='" & password & "';"

        If HasConnection() Then
            Dim con = Conectar()
            Try
                rs = con.Execute(query)

                ' Si BOF es True, entonces estoy antes del primer registro
                ' esto significa que no se encontraron registros.
                If Not rs.BOF Then
                    dataFound.Add(CBool(rs.Fields("esMedico").Value))
                    dataFound.Add(CBool(rs.Fields("extendido").Value))
                    dataFound.Add(CBool(rs.Fields("esPaciente").Value))
                    dataFound.Add(CBool(rs.Fields("esPersonalRRHH").Value))
                    dataFound.Add(CBool(rs.Fields("esRecepcionista").Value))
                Else
                    'Arrojo una exception
                    Throw New KeyNotFoundException("Usuario no encontrado")
                End If
            Catch ex As Exception
                Throw ex
            Finally
                con.Close()
            End Try
        End If
        Return dataFound
    End Function
End Class
