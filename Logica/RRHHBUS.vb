Imports System.Text
Imports Datos
Imports Dominio
Public Class RRHHBUS
    Inherits EmpleadoBUS

    Private MedicoDAO As MedicoDAO
    Private HorarioDAO As HorarioDAO
    Private EmpleadoDAO As EmpleadoDAO


    Public Sub InsertEmpleado(pEmpleado As Empleado)
        pEmpleado.Password = Password.Hash(pEmpleado.Password)

        If pEmpleado.IsMedico Then
            InsertMedico(pEmpleado)
        ElseIf pEmpleado.IsRRHH Then
            InsertRRHH(pEmpleado)

        ElseIf pEmpleado.IsRecepcionista Then
            InsertRecepcionista(pEmpleado)
        End If
    End Sub

    Public Sub ModifyEmpleado(pEmpleado As Empleado)
        If pEmpleado.IsMedico Then
            ModifyMedico(pEmpleado)
        ElseIf pEmpleado.IsRRHH Then
            ModifyRRHH(pEmpleado)

        ElseIf pEmpleado.IsRecepcionista Then
            ModifyRecepcionista(pEmpleado)
        End If
    End Sub

    Public Sub DeleteEmpleado(ci As Integer)
        Try
            MyBase.DeletePersona(ci)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function DeleteEmpleados(pEmpleados As List(Of Empleado)) As String
        Dim count As Integer = pEmpleados.Count
        Dim outputMessage As String = " empleados eliminados exitosamente." & vbCrLf

        For Each empleado In pEmpleados
            Try
                DeleteEmpleado(empleado.Ci)

            Catch ex As Exception
                outputMessage += ex.Message & empleado.Nombre & vbCrLf
                count -= 1
            End Try
        Next
        outputMessage = count & outputMessage

        Dim strb As New StringBuilder
        strb.Append(outputMessage)
        strb.Replace("persona", "Empleado")

        Return strb.ToString
    End Function

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

    Public Sub ModifyMedico(pMedico As Medico)
        Dim MedicoDAO As New MedicoDAO

        Try
            For Each especialidad In pMedico.Especialidades
                especialidad.Id = GetEspecialidad(especialidad.Nombre).Id

            Next
            MedicoDAO.ModifyMedico(pMedico)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InsertRRHH(pRRHH As RRHH)
        Dim RRHHDAO As New RRHHDAO
        Try
            RRHHDAO.Insert(pRRHH)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ModifyRRHH(pRRHH As RRHH)
        Dim RRHHDAO As New RRHHDAO
        Try
            RRHHDAO.Modify(pRRHH)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InsertRecepcionista(pRecepcionista As Recepcionista)
        Dim RecepcionistaDAO As New RecepcionistaDAO
        Try
            RecepcionistaDAO.Insert(pRecepcionista)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ModifyRecepcionista(pRecepcionista As Recepcionista)
        Dim RecepcionistaDAO As New RecepcionistaDAO

        Try
            RecepcionistaDAO.Modify(pRecepcionista)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub AddHorarioEmpleado(pHorario As Horario)

        Try
            HorarioDAO = New HorarioDAO()
            HorarioDAO.Insert(pHorario)

        Catch ex As Exception
            Throw New Exception("No se pudo insertar el horario.")
        End Try
    End Sub

    Public Sub ModifyHorarioEmpleado(pHorario As Horario)

    End Sub

    Public Sub DeleteHorarioEmpleado(horario As Horario)

    End Sub

    Public Function GetHorariosEmpleados() As DataTable
        Try
            Dim HorarioDAO As New HorarioDAO
            'Return HorarioDAO.GetHorariosEmpleados()
        Catch ex As Exception
            Throw New Exception("No se pudo obtener los horarios de los empleados.")

        End Try
    End Function

    Private Function GetEspecialidad(pNombre As String) As Especialidad
        MedicoDAO = New MedicoDAO

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
        Try
            MedicoDAO.MakeAdministrator(ci)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
