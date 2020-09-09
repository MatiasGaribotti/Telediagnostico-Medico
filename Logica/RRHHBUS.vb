Imports Datos2
Imports Dominio
Public Class RRHHBUS
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
        Dim objEmpleado As New DEmpleado(Env.UserType)
        empleado.Password = Logica.Password.Generate(New Random)
        Try
            objEmpleado.ActualizarContraseña(empleado.Ci, empleado.Password)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DoAdministrator(medico As Medico)

    End Sub
End Class
