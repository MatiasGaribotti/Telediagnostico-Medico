Public Class DSintoma
    Inherits DBConnection
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(user As String, password As String)
        MyBase.New(user, password)
    End Sub

    Public Function Insert() As Boolean

        If HasConnection()

        End If

    End Function
End Class
