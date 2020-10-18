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

    Public Function GetSucursales() As List(Of Sucursal)
        Dim SucursalDAO As New SucursalDAO
        Dim dt As DataTable
        Dim listaSucursales As New List(Of Sucursal)

        Try
            dt = SucursalDAO.GetSucursales()
        Catch ex As Exception
            Throw New Exception("ex_get_sucursales")

        End Try

        For Each row As DataRow In dt.Rows
            Dim idSucursal = row.Field(Of Byte)("idSucursal")
            Dim nombreSucursal = row.Field(Of String)("nombreSucursal")

            Dim idDireccion = row.Field(Of Int64)("idDireccion")
            Dim calle = row.Field(Of String)("calle")
            Dim numero = row.Field(Of Int32)("numero")
            Dim localidad = row.Field(Of String)("localidad")
            Dim departamento As Direccion.Departamentos = [Enum].Parse(GetType(Direccion.Departamentos), row.Field(Of String)("departamento"))
            Dim detalle = row.Field(Of String)("detalle")
            Dim direccion As New Direccion(idDireccion, calle, numero, localidad, departamento, detalle)

            listaSucursales.Add(New Sucursal(idSucursal, nombreSucursal, direccion))
        Next

        Return listaSucursales
    End Function

    Public Function GetHorariosEmpleados() As DataTable
        Try
            Dim HorarioDAO As New HorarioDAO
            Return HorarioDAO.GetHorariosEmpleados()

        Catch ex As Exception
            Throw New Exception("No se pudo obtener los horarios de los empleados.")

        End Try
    End Function

    Public Function GetHorariosEmpleados(searchPattern As Horario) As DataTable
        Try
            Dim HorarioDAO As New HorarioDAO

            Dim parsedCi As String = ParseCi(searchPattern.Empleado.Ci)
            Dim rangoHorario As String() = ParseRangoHorario(searchPattern.HoraInicio, searchPattern.HoraFin)
            Dim sucursalNombre As String

            If searchPattern.Sucursal.Id = 0 Then
                sucursalNombre = "%"

            Else
                sucursalNombre = searchPattern.Sucursal.Nombre
            End If


            If searchPattern.Dias.Count > 0 Then
                Return HorarioDAO.GetHorariosEmpleados(searchPattern.Dias, parsedCi, rangoHorario.ElementAt(0), rangoHorario.ElementAt(1), sucursalNombre)

            Else
                Return HorarioDAO.GetHorariosEmpleados(parsedCi, rangoHorario.ElementAt(0), rangoHorario.ElementAt(1), sucursalNombre)

            End If


        Catch ex As Exception
            Throw New Exception("No se pudo obtener los horarios de los empleados.")

        End Try
    End Function

    Private Function ParseCi(ci As Integer) As String
        If ci = -1 Then
            Return ""
        Else
            Return ci.ToString
        End If
    End Function

    Private Function ParseRangoHorario(entrada As Date, salida As Date) As String()
        Dim rangoHorario(2) As String

        If entrada.Year = 1 And salida.Year = 1 Then
            rangoHorario = {"00:00", "23:59"}

        Else
            rangoHorario = {entrada.ToShortTimeString, salida.ToShortTimeString}
        End If

        Return rangoHorario
    End Function

    Public Sub InsertHorarioEmpleado(pHorario As Horario)

        Try
            HorarioDAO = New HorarioDAO()
            HorarioDAO.Insert(pHorario)

        Catch ex As Exception
            Throw New Exception("No se pudo insertar el horario.")
        End Try
    End Sub

    Public Sub ModifyHorarioEmpleado(newHorario As Horario, oldHorario As Horario)
        Dim HorarioDAO As New HorarioDAO

        Try
            HorarioDAO.Modify(newHorario, oldHorario)
        Catch ex As Exception
            Throw New Exception("error_horario_modify")
        End Try
    End Sub

    Public Sub DeleteHorarioEmpleado(horario As Horario)
        Dim HorarioDAO As New HorarioDAO

        Try
            HorarioDAO.Delete(horario)

        Catch ex As Exception
            Throw New Exception("error_horario_delete")
        End Try
    End Sub


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
        pEmpleado.Password = Logica.Password.Generate(New Random)
        Try
            ChangePassword(pEmpleado.Ci, pEmpleado.Password)

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
