Public Class RRHH
    Inherits Empleado

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
                   password As String
                   )
        MyBase.New(ci,
                   nombre,
                   apellidoP,
                   apellidoM,
                   direccion,
                   telefono,
                   Fecha_Nacimiento,
                   password)
        IsRRHH = True

    End Sub
End Class
