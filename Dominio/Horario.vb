Public Class Horario

    Public Property Empleado As Empleado
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

    Public Sub New(empleado As Empleado,
                   sucursal As Sucursal,
                   dias As List(Of DiasSemana),
                   horaInicio As Date,
                   horaFin As Date)
        Me.Empleado = empleado
        Me.Sucursal = sucursal
        Me.Dias = dias
        Me.HoraInicio = horaInicio
        Me.HoraFin = horaFin

    End Sub
End Class
