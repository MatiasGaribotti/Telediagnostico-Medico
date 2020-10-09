Public Class Horario

    Public Property Ci As Integer
    Public Property Sucursal As Sucursal
    Public Property Dias As List(Of DiasSemana)
    Public Property HoraInicio As Date
    Public Property HoraFin As Date

    Public Enum DiasSemana
        Lunes = 1
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
        Domingo
    End Enum

    Public Sub New(ci As String,
                   sucursal As Sucursal,
                   dias As List(Of DiasSemana),
                   horaInicio As Date,
                   horaFin As Date)
        Me.Ci = ci
        Me.Sucursal = sucursal
        Me.Dias = dias
        Me.HoraInicio = horaInicio
        Me.HoraFin = horaFin

    End Sub
End Class
