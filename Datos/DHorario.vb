Imports ADODB
Public Class DHorario
    Inherits DBConnection

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(user As String, password As String)
        MyBase.New(user, password)
    End Sub

    Public Function Insert(
            ci As Integer,
            sucursal As Byte,
            dia As String,
            horaInicio As String,
            horaFin As String) As Boolean

        If HasConnection() Then
            'Abro la conexión con la base de datos
            Dim con As Connection = Conectar()

            Try
                'Abro transacción
                con.BeginTrans()

                ' Sentencia para ingresar un paciente
                Dim insertHorario = "INSERT INTO trabajanMe.horario(" &
                                  "ciMedico," &
                                  "idSucursal," &
                                  "diaGuardia," &
                                  " horaEntrada," &
                                  " horaSalida)" &
                                  "VALUES(" &
                                  ci & ",'" &
                                  sucursal & "','" &
                                  dia & "','" &
                                  horaInicio & "'," &
                                  horaFin &
                                  ");"
                MsgBox("Query Medico: " & insertHorario)

                'Ingreso el horario del médico a la DB
                con.Execute(insertHorario)

                'Hago el commit de la transacción y retorno True
                con.CommitTrans()
                Return True

            Catch ex As Exception
                'Hubo una excepción, por lo que debo hacer un rollback
                'para mantener la integridad de los datos.
                con.RollbackTrans()
                Console.WriteLine("No se pudo insertar el horario del médico." & vbCrLf & ex.Message) ' Mensaje en consola para debug

                'Retorno False, significando esto que la transacción
                'no se pudo concretar.
                Return False

            End Try
        Else
            MsgBox("No hay conexión con la base de datos.", MsgBoxStyle.Critical, "Error")
            Return False
        End If
    End Function

End Class
