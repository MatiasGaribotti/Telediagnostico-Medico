Public Class Mensaje
    Public Property Id As Long
    Public Property Persona As Persona
    Public Property Texto As String
    Public Property Timestamp As Date

    Public Sub New(id As Long, persona As Persona, texto As String, timestamp As Date)
        Me.Id = id
        Me.Persona = persona
        Me.Texto = texto
        Me.Timestamp = timestamp
    End Sub

    Public Sub New(persona As Persona, texto As String, timestamp As Date)
        Me.Persona = persona
        Me.Texto = texto
        Me.Timestamp = timestamp
    End Sub
End Class
