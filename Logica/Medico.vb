Imports Datos2

Public Class Medico
    Inherits Empleado
    Public Property Especialidad As String

    'Constructor por defecto
    Public Sub New()
        MyBase.New()
        Especialidad = "Default"
    End Sub

    Public Sub New(ci As Integer)
        MyBase.New(ci)
    End Sub
    Public Sub New(ci As Integer, password As String)
        MyBase.New(ci, password)
        Horarios = New List(Of Horario)
    End Sub

    'Constructor comúm completo
    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   especialidad As String,
                   horarios As List(Of Horario),
                   password As String
                   )
        MyBase.New(ci, nombre, apellidoP, apellidoM, direccion, telefono, fecha_nacimiento, horarios, password)
        Me.Especialidad = especialidad
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   especialidad As String,
                   password As String
                   )
        MyBase.New(ci, nombre, apellidoP, apellidoM, direccion, telefono, fecha_nacimiento, password)
        Me.Especialidad = especialidad
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

    Public Function GetEmpleados() As DataTable
        Dim db As New DMedico(Env.UserType)
        Try
            Dim dt = db.GetEmpleados()
            Return dt

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
