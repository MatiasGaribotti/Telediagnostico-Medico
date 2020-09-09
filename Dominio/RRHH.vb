Imports Datos2
Public Class RRHH
    Inherits Empleado

    Public Sub New(ci As Integer)
        MyBase.New(ci)
    End Sub


    Public Sub IngresarMedico(medico As Medico)
        Dim objDMedico As New DMedico(
                              Env.UserType,
                              medico.Ci,
                              medico.Nombre,
                              medico.ApellidoP,
                              medico.ApellidoM,
                              medico.Fecha_Nacimiento,
                              New DDireccion(medico.Direccion.Calle,
                                             medico.Direccion.Nro,
                                             medico.Direccion.Localidad,
                                             medico.Direccion.Departamento,
                                             medico.Direccion.Detalle),
                              medico.Telefono,
                              medico.Especialidad,
                              medico.Password
                              )

        Try
            objDMedico.Insert()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class
