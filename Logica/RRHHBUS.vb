Imports Datos
Imports Dominio
Public Class RRHHBUS

    Private MedicoDAO As MedicoDAO
    Private HorarioDAO As HorarioDAO
    Private EmpleadoDAO As EmpleadoDAO

    Public Sub IngresarMedico(medico As Medico)
        Try
            MedicoDAO = New MedicoDAO
            MedicoDAO.Insert(medico)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ModificarMedico(old As Medico, newMedico As Medico)

    End Sub

    Public Sub EliminarMedico(ci As Integer)

    End Sub

    Public Sub NuevoHorario(horario As Horario)

        Try
            HorarioDAO = New HorarioDAO()
            HorarioDAO.Insert(horario)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ModificarHorario(newHorario As Horario)

    End Sub

    Public Sub EliminarHorario(horario As Horario)

    End Sub

    Public Sub ResetPassword(empleado As Empleado)
        EmpleadoDAO = New EmpleadoDAO()

        empleado.Password = Logica.Password.Generate(New Random)
        Try
            EmpleadoDAO.ActualizarContraseña(empleado.Ci, empleado.Password)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DoAdministrator(medico As Medico)

    End Sub
End Class
