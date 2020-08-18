Imports ADODB
Public Class DHorario
    Inherits DBConnection

    Public Property Ci As Integer
    Public Property Sucursal As String
    Public Property Dia As Dias
    Public Property HoraInicio As String
    Public Property HoraFin As String
    Public Enum Dias
        Lunes
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
        Domingo
    End Enum

    Public Sub New(userType As Short,
                   Ci As String,
                   Sucursal As String,
                   Dia As Dias,
                   horaInicio As String,
                   horaFin As String)
        MyBase.New(userType)
        Me.Ci = Ci
        Me.Sucursal = Sucursal
        Me.Dia = Dia
        Me.HoraInicio = horaInicio
        Me.HoraFin = horaFin

    End Sub

    Public Function Insert() As Boolean

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
                                  Ci & ",'" &
                                  Sucursal & "','" &
                                  Dia & "','" &
                                  HoraInicio & "'," &
                                  HoraFin &
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
                Console.WriteLine("No se pudo insertar el horario." & vbCrLf & ex.Message) ' Mensaje en consola para debug

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
