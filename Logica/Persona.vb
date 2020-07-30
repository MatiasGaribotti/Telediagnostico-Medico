Imports Datos
Public MustInherit Class Persona

    Protected _Ci As Integer
    Protected _Nombre As String
    Protected _ApellidoP As String
    Protected _ApellidoM As String
    Protected _Direccion As Direccion
    Protected _Telefono As Integer
    Protected _Fecha_Nacimiento As Date
    Protected _Password As String

    Protected Property Ci() As Integer
        Get
            Return _Ci
        End Get
        Set(ByVal value As Integer)
            _Ci = value
        End Set
    End Property

    Protected Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(nombre As String)
            _Nombre = nombre
        End Set
    End Property

    Protected Property ApellidoP As String
        Get
            Return _ApellidoP
        End Get
        Set(value As String)
            _ApellidoP = value
        End Set
    End Property

    Protected Property ApellidoM As String
        Get
            Return _ApellidoM
        End Get
        Set(value As String)
            _ApellidoM = value
        End Set
    End Property

    Protected Property Direccion As Direccion
        Get
            Return _Direccion
        End Get
        Set(value As Direccion)
            _Direccion = value
        End Set
    End Property

    Protected Property Telefono As Integer
        Get
            Return _Telefono
        End Get
        Set(value As Integer)
            _ApellidoM = value
        End Set
    End Property

    Protected Property Fecha_Nacimiento As Date
        Get
            Return _Fecha_Nacimiento
        End Get
        Set(value As Date)
            _Fecha_Nacimiento = value
        End Set
    End Property

    Protected Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

    Protected Sub New()

    End Sub

    Protected Sub New(ci As Integer,
                      nombre As String,
                      apellidoP As String,
                      apellidoM As String,
                      direccion As Direccion,
                      telefono As Integer,
                      fecha_Nacimiento As Date,
                      password As String)
        _Ci = ci
        _Nombre = nombre
        _ApellidoP = apellidoP
        _ApellidoM = apellidoM
        _Direccion = direccion
        _Telefono = telefono
        _Fecha_Nacimiento = fecha_Nacimiento
        _Password = password
    End Sub

    Protected Function ValidateCi() As Boolean
        'Valida que la cédula de identidad sea válida
        Dim valida As Boolean = True



        Return valida
    End Function

End Class
