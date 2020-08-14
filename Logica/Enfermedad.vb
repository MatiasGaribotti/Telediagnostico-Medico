Public Class Enfermedad
    Public Property Id As Short
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Urgencia As Urgencias
    Public Enum Urgencias
        Baja
        Media
        Alta
    End Enum

    Public Sub New()
        Me.Id = -1
        Me.Nombre = "Default"
        Me.Descripcion = "Default"
        Me.Urgencia = "Default"
    End Sub

    Public Sub New(id As Short, nombre As String, descripcion As String, urgencia As Urgencias)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Urgencia = urgencia
    End Sub
End Class
