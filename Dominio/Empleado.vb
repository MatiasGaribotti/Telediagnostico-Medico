Public Class Empleado
    Inherits Persona

    Public Property Horarios As List(Of Horario)
    Public Sub New()
        MyBase.New()
        IsEmpleado = True
        Horarios = New List(Of Horario)
    End Sub

    Public Sub New(ci As Integer)
        MyBase.New(ci)
        IsEmpleado = True
        Horarios = New List(Of Horario)
    End Sub

    Public Sub New(ci As Integer, password As String)
        MyBase.New(ci, password)
        IsEmpleado = True
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
        IsEmpleado = True
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
        IsEmpleado = True
        Me.Horarios = horarios
    End Sub

End Class
