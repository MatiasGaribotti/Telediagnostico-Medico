Public Class DEmpleado
    Inherits DPersona

    Public Property Horarios As List(Of DHorario)

    Public Sub New(DB_User As String,
                   DB_Password As String)
        MyBase.New(DB_User, DB_Password)
    End Sub

    'Constructor para autenticación
    Public Sub New(ci As Integer,
                   password As String)
        MyBase.New(ci, password)
    End Sub

End Class
