Public Class Mensaje
    Public Property Id As Long
    Public Property CiPersona As Integer
    Public Property Texto As String
    Public Property Timestamp As Date

    Public Sub New(id As Long, ciPersona As Integer, texto As String, timestamp As Date)
        Me.Id = id
        Me.CiPersona = ciPersona
        Me.Texto = texto
        Me.Timestamp = timestamp
    End Sub
End Class
