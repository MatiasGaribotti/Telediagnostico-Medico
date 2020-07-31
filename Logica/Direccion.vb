Public Class Direccion

    Private _Id As Integer
    Private _Calle As String
    Private _Nro As Integer
    Private _Localidad As String
    Private _Departamento As Departamentos

    Public Sub New(calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As Departamentos)
        _Calle = calle
        _Nro = nro
        _Localidad = localidad
        _Departamento = departamento
    End Sub

    Public Sub New(id As Integer,
                   calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As Departamentos)
        _Id = id
        _Calle = calle
        _Nro = nro
        _Localidad = localidad
        _Departamento = departamento
    End Sub

    Public Property Calle As String
        Get
            Return _Calle
        End Get
        Set(value As String)
            _Calle = value
        End Set
    End Property

    Public Property Id As UInteger
        Get
            Return _Id
        End Get
        Set(value As UInteger)
            _Id = value
        End Set
    End Property

    Public Property Nro As Integer
        Get
            Return _Nro
        End Get
        Set(value As Integer)
            _Nro = value
        End Set
    End Property

    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            _Localidad = value
        End Set
    End Property

    Public Property Departamento As Departamentos
        Get
            Return _Departamento
        End Get
        Set(value As Departamentos)
            _Departamento = value
        End Set
    End Property

    Public Enum Departamentos
        Montevideo
        San_Jose
        Canelones
        Colonia
        Soriano
        Rio_Negro
        Maldonado
        Rocha
        Flores
        Florida
        Treinta_y_Tres
        Durazno
        Rivera
        Salto
        Paysandu
        Artigas
        Cerro_Largo
        Lavalleja
        Tacuarembo
    End Enum
End Class
