
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

    Public Sub New(ci As Integer)
        Me.Ci = ci
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

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_Nacimiento As Date,
                   password As String)
        Me.Ci = ci
        Me.Nombre = nombre
        Me.ApellidoP = apellidoP
        Me.ApellidoM = apellidoM
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Fecha_Nacimiento = fecha_Nacimiento
        Me.Password = password
    End Sub

    Public Function ValidateCi(ciAValidar As Integer) As Boolean
        'Valida que la cédula de identidad sea válida
        Dim valida As Boolean = True
        Dim ci As String = ciAValidar.ToString()

        If (ci.Length <> 8) Then

            valida = False

        ElseIf valida Then

            Dim digitoVerificador As Integer = Integer.Parse(ci.ToCharArray.Last.ToString)

            'ElseIF
        End If

        Return valida
    End Function

End Class
