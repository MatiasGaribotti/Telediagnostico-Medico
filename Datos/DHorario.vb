Imports ADODB
Public Class DHorario
    Inherits DBConnection

    Public Sub New()
        Me.User = "admin"
        Me.Password = "123456789"
        Me.ConStr = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=127.0.0.1;" &
                                      "port=3306;" &
                                      "database=sistemaMe.telediagnostico;" &
                                      "uid=" & Me.User & ";" &
                                      "pwd=" & Me.Password & ";"
    End Sub

    Public Sub New(user As String, password As String)
        Me.User = user
        Me.Password = password
        Me.ConStr = "Driver={MYSQL ODBC 5.3 Unicode Driver};" &
                                      "server=127.0.0.1;" &
                                      "port=3306;" &
                                      "database=sistemaMe.telediagnostico;" &
                                      "uid=" & Me.User & ";" &
                                      "pwd=" & Me.Password & ";"
    End Sub

    Public Function Insert(
            ci As Integer,
            sucursal As Byte,
            dia As String,
            horaInicio As String,
            horaFin As String) As Boolean

        If HasConnection() Then

            Dim rs As Recordset

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
