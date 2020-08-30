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

    Public Sub ModificarMedico(old As Medico, newMedico As Medico)

    End Sub

    Public Sub EliminarMedico(ci As Integer)

    End Sub

    Public Sub NuevoHorario(horario As Horario)
        Dim objDHorario As New DHorario(Env.UserTypes.RRHH,
                               horario.Ci,
                               horario.Sucursal,
                               horario.Dia,
                               horario.HoraInicio,
                               horario.HoraFin)
        Try
            objDHorario.Insert()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ModificarHorario(old As Horario, newHorario As Horario)

    End Sub

    Public Sub EliminarHorario(horario As Horario)

    End Sub

    Public Sub ResetPassword(empleado As Empleado)

    End Sub

    Public Sub DoAdministrator(medico As Medico)

    End Sub
End Class
