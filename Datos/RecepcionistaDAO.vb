Imports ADODB
Imports Dominio
Public Class RecepcionistaDAO
    Inherits EmpleadoDAO

    Public Sub Insert(pRecepcionista As Recepcionista)
        Dim query As String = "UPDATE personas SET esRecepcionista=1 WHERE ci=" & pRecepcionista.Ci & ";"

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.BeginTrans()

            MyBase.InsertEmpleado(pRecepcionista)
            Conn.Execute(query)

            Conn.CommitTrans()
        Catch ex As Exception
            Conn.RollbackTrans()
            Throw New Exception("Error al ingresar recepcionista.")

        Finally
            Conn.Close()
        End Try
    End Sub

    Public Sub Modify(pRecepcionista As Recepcionista)
        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.BeginTrans()
            ModifyPersona(pRecepcionista)
            Conn.CommitTrans()
        Catch ex As Exception
            Conn.RollbackTrans()
            Throw New Exception("No se pudo modificar el recepcionista.")

        Finally
            Conn.Close()
        End Try
    End Sub
End Class
