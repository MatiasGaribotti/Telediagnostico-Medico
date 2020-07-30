
Public Class Paciente
    Inherits Persona

    Private _Email As String
    Private _NucleoFlia As String
    Private _AntecedentesFlia As String
    Private _AntecedentesLab As String
    Private _Medicacion As String
    Private _Tratamiento As String

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   password As String,
                   Email As String,
                   NucleoFlia As String,
                   AntecedentesFlia As String,
                   antecedentesLab As String,
                   medicacion As String,
                   tratamiento As String)

        MyBase.New(ci,
                   nombre,
                   apellidoP,
                   apellidoM,
                   direccion,
                   telefono,
                   fecha_nacimiento,
                   password)
        _Email = Email
        _NucleoFlia = NucleoFlia
        _AntecedentesFlia = AntecedentesFlia
        _AntecedentesLab = antecedentesLab
        _Medicacion = medicacion
        _Tratamiento = tratamiento
    End Sub

    Property Email As String
        Get
            Return _Email
        End Get
        Set
            _Email = Value
        End Set
    End Property

    Property NucleoFlia As String
        Get
            Return _NucleoFlia
        End Get
        Set
            _NucleoFlia = Value
        End Set
    End Property

    Property AntecedentesFlia As String
        Get
            Return _AntecedentesFlia
        End Get
        Set
            _AntecedentesFlia = Value
        End Set
    End Property

    Property AntecedentesLab As String
        Get
            Return _AntecedentesLab
        End Get
        Set
            _AntecedentesLab = Value
        End Set
    End Property

    Property Medicacion As String
        Get
            Return _Medicacion
        End Get
        Set
            _Medicacion = Value
        End Set
    End Property

    Property Tratamiento As String
        Get
            Return _Tratamiento
        End Get
        Set
            _Tratamiento = Value
        End Set
    End Property
End Class
