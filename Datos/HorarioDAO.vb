Imports ADODB
Imports Dominio
Public Class HorarioDAO
    Inherits DBConnection

    Public Function GetHorariosEmpleados() As DataTable
        Dim rs As Recordset
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Dim query As String = "SELECT * FROM Horarios_Empleados;"

        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)

        Catch ex As Exception
            Throw ex
        Finally
            Conn.Close()
        End Try

        Return dt
    End Function

    Public Function GetHorariosEmpleados(dias As List(Of Horario.DiasSemana),
                                         Optional ci As String = "",
                                         Optional horaEntrada As String = "00:00",
                                         Optional horaSalida As String = "23:59",
                                         Optional sucursalNombre As String = "%") As DataTable
        Dim rs As Recordset
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Dim queryDias As String

        queryDias = " AND ("

        For i As Integer = 0 To dias.Count - 1
            queryDias += "Dia=" & dias(i)

            If i < dias.Count - 1 Then
                queryDias += " OR "
            Else
                queryDias += ")"
            End If
        Next



        Dim query As String = "SELECT * FROM Horarios_Empleados " &
                                " WHERE ci LIKE '" & ci & "%'" &
                                queryDias &
                                " AND sucursal LIKE '" & sucursalNombre & "'" &
                                " AND (Entrada BETWEEN '" & horaEntrada & "' AND '" & horaSalida & "')" &
                                " AND (Salida BETWEEN '" & horaEntrada & "' AND '" & horaSalida & "')" &
                                " ORDER BY 'Nombre Completo';"

        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)

        Catch ex As Exception
            Throw ex
        Finally
            Conn.Close()
        End Try

        Return dt
    End Function

    Public Function GetHorariosEmpleados(Optional ci As String = "", Optional horaEntrada As String = "00:00",
                                         Optional horaSalida As String = "23:59",
                                         Optional sucursalNombre As String = "%") As DataTable
        Dim rs As Recordset
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Dim query As String = "SELECT * FROM Horarios_Empleados " &
                                " WHERE CI Like '" & ci & "%'" &
                                " AND sucursal LIKE '" & sucursalNombre & "'" &
                                " AND (Entrada BETWEEN '" & horaEntrada & "' AND '" & horaSalida & "')" &
                                " AND (Salida BETWEEN '" & horaEntrada & "' AND '" & horaSalida & "')" &
                                " ORDER BY 'Nombre Completo';"
        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            rs = Conn.Execute(query)
            da.Fill(dt, rs)

        Catch ex As Exception
            Throw ex
        Finally
            Conn.Close()
        End Try

        Return dt
    End Function

    Public Sub Insert(horario As Horario)
        'Abro transacción
        Dim query As String

        'Abro la conexión con la base de datos
        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.BeginTrans()

            For Each dia As Horario.DiasSemana In horario.Dias
                query = "INSERT INTO trabajan_horario(" &
                                  "ciMedico," &
                                  "idSucursal," &
                                  "diaGuardia," &
                                  " horaEntrada," &
                                  " horaSalida)" &
                                  "VALUES(" &
                                    horario.Empleado.Ci & "," &
                                    horario.Sucursal.Id & ",'" &
                                    dia.ToString & "','" &
                                    horario.HoraInicio.ToShortTimeString & "','" &
                                    horario.HoraFin.ToShortTimeString & "');"

                Conn.Execute(query)
            Next

            Conn.CommitTrans()

        Catch ex As Exception
            Conn.RollbackTrans()
            Throw ex

        Finally
            Conn.Close()

        End Try
    End Sub

    Public Sub Modify(newHorario As Horario, oldHorario As Horario)
        Dim query As String = "UPDATE trabajan_horario SET idSucursal=" & newHorario.Sucursal.Id & "," &
                              "diaGuardia=" & newHorario.Dias.First & "," &
                              "horaEntrada='" & newHorario.HoraInicio.ToShortTimeString & "'," &
                              "horaSalida='" & newHorario.HoraFin.ToShortTimeString & "' " &
                              "WHERE ciMedico=" & oldHorario.Empleado.Ci & " AND " &
                              "idSucursal=" & oldHorario.Sucursal.Id & " AND " &
                              "diaGuardia=" & oldHorario.Dias.First & " AND " &
                              "horaEntrada='" & oldHorario.HoraInicio.ToShortTimeString & "' AND " &
                              "horaSalida='" & oldHorario.HoraFin.ToShortTimeString & "';"

        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.Execute(query)

        Catch ex As Exception
            Throw ex

        Finally
            Conn.Close()
        End Try
    End Sub

    Public Sub Delete(horario As Horario)
        Dim query As String = "DELETE FROM trabajan_horario WHERE " &
                              "ciMedico=" & horario.Empleado.Ci &
                              " AND idSucursal=" & horario.Sucursal.Id &
                              " AND diaGuardia=" & horario.Dias.First &
                              " AND horaEntrada='" & horario.HoraInicio.ToShortTimeString &
                              "' AND horaSalida='" & horario.HoraFin.ToShortTimeString &
                              "';"

        Try
            Conn = Connect()

        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.Execute(query)

        Catch ex As Exception
            Throw ex

        Finally
            Conn.Close()

        End Try
    End Sub
End Class
