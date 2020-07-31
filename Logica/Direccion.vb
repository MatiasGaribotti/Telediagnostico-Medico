Public Class Direccion

    Private _Id As Integer
    Private _Calle As String
    Private _Nro As Integer
    Private _Localidad As String
    Private _Departamento As String
    Private _Detalle As String

    Public Sub New(calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As String)
        _Calle = calle
        _Nro = nro
        _Localidad = localidad
        _Departamento = departamento
        _Detalle = "N/A"
    End Sub

    Public Sub New(calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As String,
                   detalle As String)
        _Calle = calle
        _Nro = nro
        _Localidad = localidad
        _Departamento = departamento
        _Detalle = detalle
    End Sub

    Public Sub New(id As Integer,
                   calle As String,
                   nro As Integer,
                   localidad As String,
                   departamento As String,
                   detalle As String)
        _Id = id
        _Calle = calle
        _Nro = nro
        _Localidad = localidad
        _Departamento = departamento
        _Detalle = detalle
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

    Public Property Departamento As String
        Get
            Return _Departamento
        End Get
        Set(value As String)
            _Departamento = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _Detalle
        End Get
        Set(value As String)
            _Detalle = value
        End Set
    End Property
End Class
