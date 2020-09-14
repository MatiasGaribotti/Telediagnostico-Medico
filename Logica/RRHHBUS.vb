Imports Datos
Imports Dominio
Public Class RRHHBUS
    Inherits EmpleadoBUS

    Private MedicoDAO As MedicoDAO
    Private HorarioDAO As HorarioDAO
    Private EmpleadoDAO As EmpleadoDAO


    Public Sub InsertEmployee(pEmpleado As Empleado)
        If pEmpleado.IsMedico Then
            InsertMedico(pEmpleado)
        ElseIf pEmpleado.IsRRHH Then
            InsertRRHH(pEmpleado)

        ElseIf pEmpleado.IsRecepcionista Then
            InsertRecepcionista(pEmpleado)
        End If
    End Sub

    Public Sub ModifyEmployee(pEmployee As Empleado)

    End Sub

    Public Sub DeleteEmployee(ci As Integer)
        MyBase.DeletePersona(ci)
    End Sub

    Public Sub InsertMedico(medico As Medico)
        Try
            MedicoDAO = New MedicoDAO

            For Each especialidad In medico.Especialidades
                especialidad.Id = GetEspecialidad(especialidad.Nombre).Id

            Next

            MedicoDAO.Insert(medico)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GetEspecialidad(pNombre As String) As Especialidad
        Try
            Dim dt = MedicoDAO.GetEspecialidad(pNombre)
            Dim row = dt.Rows.Item(0)

            Dim id As Short = row.Field(Of Integer)("id")
            Dim nombre As String = row.Field(Of String)("nombre")

            Return New Especialidad(id, nombre)
        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Sub ModifyMedico(pMedico As Medico)

    End Sub

    Public Sub InsertRRHH(pRRHH As RRHH)
    End Sub

    Public Sub ModifyRRHH(pRRHH As RRHH)
        ModifyEmployee(pRRHH)
    End Sub

    Public Sub InsertRecepcionista(pRecepcionista As Recepcionista)

    End Sub

    Public Sub ModifyRecepcionista(pRecepcionista As Recepcionista)
        ModifyEmployee(pRecepcionista)
    End Sub


    Public Sub AddHorarioEmpleado(pHorario As Horario)

        Try
            HorarioDAO = New HorarioDAO()
            HorarioDAO.Insert(pHorario)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ModifyHorarioEmpleado(pHorario As Horario)

    End Sub

    Public Sub DeleteHorarioEmpleado(horario As Horario)

    End Sub

    Public Sub ResetPassword(pEmpleado As Empleado)
        EmpleadoDAO = New EmpleadoDAO()

        pEmpleado.Password = Logica.Password.Generate(New Random)
        Try
            EmpleadoDAO.UpdatePassword(pEmpleado.Ci, pEmpleado.Password)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub MakeAdministrator(ci As Integer)
        Dim MedicoDAO As New MedicoDAO
        MedicoDAO.MakeAdministrator(ci)
    End Sub
End Class
