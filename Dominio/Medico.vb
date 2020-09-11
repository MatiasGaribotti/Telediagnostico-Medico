Public Class Medico
    Inherits Empleado
    Public Property Especialidades As List(Of Especialidad)

    'Constructor por defecto
    Public Sub New()
        MyBase.New()
        Me.IsMedico = True
        Especialidades = New List(Of Especialidad)
    End Sub

    Public Sub New(ci As Integer)
        MyBase.New(ci)
        Me.IsMedico = True
        Especialidades = New List(Of Especialidad)
    End Sub
    Public Sub New(ci As Integer, password As String)
        MyBase.New(ci, password)
        Me.IsMedico = True
        Especialidades = New List(Of Especialidad)
    End Sub

    'Constructor comúm completo
    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   especialidades As List(Of Especialidad),
                   horarios As List(Of Horario),
                   Password As String
                   )
        MyBase.New(ci, nombre, apellidoP, apellidoM, direccion, telefono, fecha_nacimiento, horarios, Password)
        Me.IsMedico = True
        Me.Especialidades = especialidades
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   especialidades As List(Of Especialidad),
                   password As String
                   )
        MyBase.New(ci, nombre, apellidoP, apellidoM, direccion, telefono, fecha_nacimiento, password)
        Me.IsMedico = True
        Me.Especialidades = especialidades
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
        IsMedico = True
        Me.Especialidades = New List(Of Especialidad)
    End Sub
End Class
