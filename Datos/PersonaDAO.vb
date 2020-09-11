Public Class PersonaDAO
    Inherits DBConnection

    Public Sub UpdatePassword(ci As Integer, password As String)
        Dim query As String = "UPDATE personas SET password='" & password & "' WHERE ci='" & ci & "';"

        Try
            Conn = Connect()

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

    Public Sub DeletePersona(pCi As Integer)
        Dim query = "UPDATE personas SET ENABLE=0 WHERE ci='" & pCi & "';"

        Try
            Conn = Connect()
        Catch ex As ApplicationException
            Throw ex
        End Try

        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja la persona.")
        Finally
            Conn.Close()
        End Try
    End Sub
End Class
