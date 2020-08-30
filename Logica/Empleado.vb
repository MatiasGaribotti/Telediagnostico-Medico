Imports Datos2
Public Class Empleado
    Inherits Persona

    Public Property Horarios As List(Of Horario)
    Public Sub New()
        MyBase.New()
        Horarios = New List(Of Horario)
    End Sub

    Public Sub New(ci As Integer)
        MyBase.New(ci)
        Horarios = New List(Of Horario)
    End Sub

    Public Sub New(ci As Integer, password As String)
        MyBase.New(ci, password)
        Horarios = New List(Of Horario)
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   password As String
                   )
        MyBase.New(ci,
                   nombre,
                   apellidoP,
                   apellidoM,
                   direccion,
                   telefono,
                   fecha_nacimiento,
                   password)
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   horarios As List(Of Horario),
                   Password As String
                   )
        MyBase.New(ci,
                   nombre,
                   apellidoP,
                   apellidoM,
                   direccion,
                   telefono,
                   fecha_nacimiento,
                   Password)
        Me.Horarios = horarios
    End Sub

    'Public Function NuevoTrabajo(horario As Horario) As Boolean
    '    Dim Db As New DHorario(Env.UserType, Me.Ci, horario.Sucursal, horario.Dia, horario.HoraInicio, horario.HoraFin)

    '    Try
    '        Db.Insert()
    '        Horarios.Add(horario)
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function
End Class
