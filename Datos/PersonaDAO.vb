Public Class PersonaDAO
    Inherits DBConnection

    Public Sub Modify()

    End Sub

    Public Sub ActualizarContraseña(ci As Integer, password As String)
        Dim query As String = "UPDATE personas SET password='" & password & "' WHERE ci='" & ci & "';"

        Try
            Conn = Conectar()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw New Exception("No se pudo actualizar la contraseña.")
        Finally
            Conn.Close()
        End Try
    End Sub
End Class
