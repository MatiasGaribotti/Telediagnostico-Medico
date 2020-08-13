Public MustInherit Class Persona
    Public Property Ci As Integer
    Public Property Nombre As String
    Public Property ApellidoP As String
    Public Property ApellidoM As String
    Public Property Direccion As Direccion
    Public Property Telefono As Integer
    Public Property Fecha_Nacimiento As Date
    Public Property Password As String
    Public Property Especialidad As String

    Public Function ValidateCi() As Boolean
        'Valida que la cédula de identidad sea válida
        Dim valida As Boolean = True



        Return valida
    End Function

End Class
