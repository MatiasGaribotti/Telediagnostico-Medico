Imports Datos2
Imports Dominio
Public Class MedicoBUS
    Inherits EmpleadoBUS
    Public Function GetEmpleados() As DataTable
        Dim db As New DMedico(Env.UserType)
        Try
            Dim dt = db.GetEmpleados()
            Return dt

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
