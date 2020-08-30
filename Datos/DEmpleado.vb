Public Class DEmpleado
    Inherits DPersona

    Public Property Horarios As List(Of DHorario)

    Public Sub New(userType As Short)
        MyBase.New(userType)
    End Sub

    'Constructor para autenticación
    Public Sub New(userType As Short, ci As Integer,
                   password As String)
        MyBase.New(userType, ci, password)
        Horarios = New List(Of DHorario)
    End Sub

    Public Sub New(userType As Short, ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As DDireccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   password As String
                   )
        MyBase.New(userType,
                   ci,
                   nombre,
                   apellidoP,
                   apellidoM,
                   direccion,
                   telefono,
                   fecha_nacimiento,
                   password)
    End Sub

    Public Sub New(userType As Short,
                   ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As DDireccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   horarios As List(Of DHorario),
                   Password As String
                   )
        MyBase.New(userType,
                   ci,
                   nombre,
                   apellidoP,
                   apellidoM,
                   direccion,
                   telefono,
                   fecha_nacimiento,
                   Password)
        Me.Horarios = horarios
    End Sub

End Class
