Imports Dominio
Public Class EmpleadoDAO
    Inherits PersonaDAO

    Public Sub InsertEmpleado(pEmpleado As Empleado)
        Dim query As String = "UPDATE personas SET esEmpleado=1" &
            " WHERE ci=" & pEmpleado.Ci & ";"
        Try
            InsertPersona(pEmpleado)
            Conn.Execute(query)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class
