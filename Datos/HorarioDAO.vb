Imports ADODB
Imports Dominio
Public Class HorarioDAO
    Inherits DBConnection

    Public Sub Insert(horario As Horario)
        'Abro transacción

        Dim query As String = ""
        For Each dia As Horario.DiasSemana In horario.Dias
            query += "INSERT INTO trabajan_horario(" &
                                  "ciMedico," &
                                  "idSucursal," &
                                  "diaGuardia," &
                                  " horaEntrada," &
                                  " horaSalida)" &
                                  "VALUES(" &
            horario.Ci & ",'" &
            horario.Sucursal.Id & "','" &
            dia & "','" &
            horario.HoraInicio & "'," &
            horario.HoraFin & ");"
        Next

        'Abro la conexión con la base de datos
        Try
            Conn = Connect()
        Catch ex As Exception
            Throw ex
        End Try

        Try
            Conn.BeginTrans()
            Conn.Execute(query)
            Conn.CommitTrans()

        Catch ex As Exception
            Conn.RollbackTrans()
            Throw ex

        Finally
            Conn.Close()

        End Try
    End Sub
End Class
