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

    Public Sub Insert()

        If HasConnection() Then
            'Abro la conexión con la base de datos
            Dim con As Connection = Conectar()

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

            Try
                'Ingreso el horario del médico a la DB
                con.Execute(insertHorario)

                'Hago el commit de la transacción y retorno True
                con.CommitTrans()

            Catch ex As Exception
                Throw New Exception("No se pudo insertar el horario.")
                con.RollbackTrans()
            Finally
                con.Close()
            End Try
        Else
            Throw New Exception("No hay conexión con la base de datos.")
        End If
    End Sub

End Class
