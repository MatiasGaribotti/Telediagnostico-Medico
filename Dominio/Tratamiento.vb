Public Class Tratamiento
    Public Property Id As Integer
    Public Property Descripcion As String
    Public Property Medicaciones As List(Of String)

    Public Sub New()
        Id = -1
        Descripcion = ""
        Medicaciones = New List(Of String)
    End Sub

    Public Sub New(descripcion As String, medicaciones As List(Of String))
        Me.Descripcion = descripcion
        Me.Medicaciones = medicaciones
    End Sub

    Public Sub New(id As Integer, descripcion As String, medicaciones As List(Of String))
        Me.Id = id
        Me.Descripcion = descripcion
        Me.Medicaciones = medicaciones
    End Sub

End Class
