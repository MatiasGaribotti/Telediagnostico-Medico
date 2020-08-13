Public MustInherit Class Persona
    Public Property Ci As Integer
    Public Property Nombre As String
    Public Property ApellidoP As String
    Public Property ApellidoM As String
    Public Property Direccion As Direccion
    Public Property Telefono As Integer
    Public Property Fecha_Nacimiento As Date
    Public Property Password As String

    Public Sub New()
        Me.Ci = 11111111
        Me.Nombre = "Default"
        Me.ApellidoP = "Default"
        Me.ApellidoM = "Default"
        Me.Direccion = New Direccion()
        Me.Telefono = -1
        Me.Fecha_Nacimiento = New Date(1, 1, 1)
        Me.Password = "Default"
    End Sub

    Public Sub New(ci As Integer, password As String)
        Me.Ci = ci
        Me.Nombre = "Default"
        Me.ApellidoP = "Default"
        Me.ApellidoM = "Default"
        Me.Direccion = New Direccion()
        Me.Telefono = -1
        Me.Fecha_Nacimiento = New Date(1, 1, 1)
        Me.Password = password
    End Sub
    Public Function ValidateCi() As Boolean
        'Valida que la cédula de identidad sea válida
        Dim valida As Boolean = True

        Return valida
    End Function

End Class
