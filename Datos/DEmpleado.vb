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
    End Sub

End Class
