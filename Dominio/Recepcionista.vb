Public Class Recepcionista
    Inherits Empleado

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ci As Integer)
        MyBase.New(ci)
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   Fecha_Nacimiento As Date,
                   Optional password As String = ""
                   )
        MyBase.New(ci,
                   nombre,
                   apellidoP,
                   apellidoM,
                   direccion,
                   telefono,
                   Fecha_Nacimiento,
                   password)
        IsRecepcionista = True

    End Sub
End Class
