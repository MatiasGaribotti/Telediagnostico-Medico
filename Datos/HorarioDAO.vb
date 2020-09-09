Imports ADODB
Imports Dominio
Public Class HorarioDAO
    Inherits DBConnection
    Public Sub Insert(horario As Horario)

        'Abro la conexión con la base de datos
        Try
            Conn = Conectar()
        Catch ex As Exception
            Throw ex
        End Try

        'Abro transacción
        Conn.BeginTrans()

        ' Sentencia para ingresar un paciente
        Dim insertHorario = "INSERT INTO trabajanMe.horario(" &
                                  "ciMedico," &
                                  "idSucursal," &
                                  "diaGuardia," &
                                  " horaEntrada," &
                                  " horaSalida)" &
                                  "VALUES(" &
                                  horario.Ci & ",'" &
                                  horario.Sucursal & "','" &
                                  horario.Dia & "','" &
                                  horario.HoraInicio & "'," &
                                  horario.HoraFin &
                                  ");"

        Try
            'Ingreso el horario del médico a la DB
            Conn.Execute(insertHorario)

            'Hago el commit de la transacción y retorno True
            Conn.CommitTrans()

        Catch ex As Exception
            Throw New Exception("No se pudo insertar el horario.")
            Conn.RollbackTrans()
        Finally
            Conn.Close()
        End Try
    End Sub

End Class
