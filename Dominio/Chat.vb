Public Class Chat

    Public Property Id As Long
    Public Property Mensajes As List(Of Mensaje)

    Public Sub New()
        Id = -1
        Mensajes = New List(Of Mensaje)
    End Sub
End Class
