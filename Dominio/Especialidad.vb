Public Class Especialidad

    Public Property Id As Short
    Public Property Nombre As String

    Public Sub New()
        Me.Id = -1
        Me.Nombre = ""
    End Sub

    Public Sub New(nombre As String)
        Me.Id = -1
        Me.Nombre = nombre
    End Sub

    Public Sub New(id As Short, nombre As String)
        Me.Id = id
        Me.Nombre = nombre
    End Sub
End Class
