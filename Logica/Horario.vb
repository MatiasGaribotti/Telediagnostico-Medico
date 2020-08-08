Imports Datos2
Public Class Horario

    Private _Ci As Integer
    Private _Sucursal As String
    Private _Dia As String
    Private _HoraInicio As String
    Private _HoraFin As String

    Public Sub New(ci As String,
                   sucursal As String,
                   dia As String,
                   horaInicio As String,
                   horaFin As String)
        _Ci = ci
        _Sucursal = sucursal
        _Dia = dia
        _HoraInicio = horaInicio
        _HoraFin = horaFin

    End Sub


    Public Property Ci() As Integer
        Get
            Return _Ci
        End Get
        Set(ByVal value As Integer)
            _Ci = value
        End Set
    End Property

    Public Property Sucursal As String
        Get
            Return _Sucursal
        End Get
        Set(value As String)
            _Sucursal = value
        End Set
    End Property

    Public Property Dia As String
        Get
            Return _Dia
        End Get
        Set(value As String)
            _Dia = value
        End Set
    End Property

    Public Property HoraInicio As String
        Get
            Return _HoraInicio
        End Get
        Set(value As String)
            _HoraInicio = value
        End Set
    End Property

    Public Property HoraFin As String
        Get
            Return _HoraFin
        End Get
        Set(value As String)
            _HoraFin = value
        End Set
    End Property

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
