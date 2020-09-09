Imports Datos2
Public Class Recepcionista
    Inherits Empleado

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ci As Integer)
        MyBase.New(ci)
    End Sub
End Class
