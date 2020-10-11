Public Class Chat

    Public Property Id As Long
    Public Property Mensajes As List(Of Mensaje)

    Public Property Status As ChatStatus

    Public Enum ChatStatus
        Waiting
        Active
        Ended
    End Enum

    Public Sub New()
        Id = -1
        Mensajes = New List(Of Mensaje)
        Status = ChatStatus.Waiting
    End Sub

    Public Sub New(id As Long)
        Me.Id = id
        Me.Mensajes = New List(Of Mensaje)
        Me.Status = ChatStatus.Active
    End Sub
End Class
