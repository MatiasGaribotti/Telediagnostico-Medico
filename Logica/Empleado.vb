Imports Datos2
Public Class Empleado
    Inherits Persona
    Public Property Horarios As List(Of Horario)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ci As Integer, password As String)
        MyBase.New(ci, password)
    End Sub

    Public Function NuevoTrabajo(horario As Horario) As Boolean
        Dim Db As New DHorario()

        Try
            Db.Insert(Ci, horario.Sucursal, horario.Dia, horario.HoraInicio, horario.HoraFin)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
