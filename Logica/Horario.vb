Imports Datos2
Public Class Horario

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

    Public Sub New(ci As String,
                   sucursal As String,
                   dia As Dias,
                   horaInicio As String,
                   horaFin As String)
        Me.Ci = ci
        Me.Sucursal = sucursal
        Me.Dia = dia
        Me.HoraInicio = horaInicio
        Me.HoraFin = horaFin

    End Sub




    Public Sub Insert()

        Dim db As New DHorario("admin", "123456789")
        Dim result = db.Insert(Ci,
                               Sucursal,
                               Dia,
                               HoraInicio,
                               HoraFin)
        If result Then
            MsgBox("Horario Ingresado exitosamente", MsgBoxStyle.Information, "Información")
        Else
            MsgBox("No se pudo ingresar la franja horaria.", MsgBoxStyle.Critical, "Error en el ingreso del horario")

        End If
    End Sub

End Class
