Imports ADODB
Imports Dominio
Public Class RRHHDAO
    Inherits EmpleadoDAO

    Public Sub Insert(pRRHH As RRHH)
        Dim query As String = "UPDATE personas SET esRRHH=1 WHERE ci=" & pRRHH.Ci & ";"

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.BeginTrans()

            MyBase.InsertEmpleado(pRRHH)
            Conn.Execute(query)

            Conn.CommitTrans()
        Catch ex As Exception
            Conn.RollbackTrans()
            Throw New Exception("Error al ingresar nuevo personal de RRHH.")

        Finally
            Conn.Close()
        End Try
    End Sub

    Public Sub Modify(pRRHH As RRHH)
        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.BeginTrans()
            ModifyPersona(pRRHH)
            Conn.CommitTrans()
        Catch ex As Exception
            Conn.RollbackTrans()
            Throw New Exception("No se pudo modificar el personal de recursos humanos.")

        Finally
            Conn.Close()
        End Try
    End Sub
End Class
