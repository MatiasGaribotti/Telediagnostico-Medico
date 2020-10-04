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

    Public Sub New(ci As Integer, nombre As String)
        MyBase.New(ci, nombre)
        IsEmpleado = True
        Horarios = New List(Of Horario)
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   sexo As Sexos,
                   Direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   password As String
                   )
        MyBase.New(ci,
                   nombre,
                   apellidoP,
                   apellidoM,
                   sexo,
                   Direccion,
                   telefono,
                   fecha_nacimiento,
                   password)
        IsEmpleado = True
        Horarios = New List(Of Horario)
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   sexo As Sexos,
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
                   sexo,
                   direccion,
                   telefono,
                   fecha_nacimiento,
                   Password)
        IsEmpleado = True
        Me.Horarios = horarios
    End Sub

End Class
