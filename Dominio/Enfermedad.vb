Public Class Enfermedad
    Public Property Id As Short
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Urgencia As Urgencias
    Public Property Cronica As Boolean
    Public Enum Urgencias
        Baja = 1 'inicializo en 1 el primer miembro para que coincida con la BD.
        Media
        Alta
    End Enum

    Public Sub New()
        Me.Id = -1
        Me.Nombre = "Default"
        Me.Descripcion = "Default"
        Me.Urgencia = Urgencias.Baja
        Me.Cronica = False
    End Sub

    Public Sub New(nombre As String)
        Me.Id = -1
        Me.Nombre = nombre
        Me.Descripcion = "Default"
        Me.Urgencia = Urgencias.Baja
        Me.Cronica = False
    End Sub

    Public Sub New(id As Short, nombre As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = Descripcion
        Me.Urgencia = Urgencia
        Me.Cronica = False
    End Sub

    Public Sub New(nombre As String, descripcion As String, urgencia As Urgencias, Optional cronica As Boolean = False)
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Urgencia = urgencia
        Me.Cronica = cronica
    End Sub

    Public Sub New(id As Short, nombre As String, descripcion As String, urgencia As Urgencias, cronica As Boolean)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Urgencia = urgencia
        Me.Cronica = cronica
    End Sub
End Class
