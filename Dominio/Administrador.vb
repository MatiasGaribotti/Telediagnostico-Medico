Public Class Administrador
    Inherits Medico

    Public Sub New(ci As Integer)
        MyBase.New(ci)
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   especialidades As List(Of Especialidad),
                   horarios As List(Of Horario),
                   Optional Password As String = ""
                   )
        MyBase.New(ci, nombre, apellidoP, apellidoM, direccion, telefono, fecha_nacimiento, especialidades, horarios, Password)
        Me.IsAdministrador = True
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   especialidades As List(Of Especialidad),
                   Optional password As String = ""
                   )
        MyBase.New(ci, nombre, apellidoP, apellidoM, direccion, telefono, fecha_nacimiento, especialidades, password)
        Me.IsAdministrador = True
    End Sub

End Class
