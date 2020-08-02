Imports Datos2
Public Class Paciente
    Inherits Persona

    Private _Email As String
    Private _NucleoFlia As String
    Private _AntecedentesFlia As String
    Private _AntecedentesLab As String
    Private _Medicacion As String
    Private _Tratamiento As String

    Public Sub New(ci As Integer,
                   foto As String,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   password As String,
                   email As String,
                   NucleoFlia As String,
                   AntecedentesFlia As String,
                   antecedentesLab As String,
                   medicacion As String,
                   tratamiento As String)
        _Ci = ci
        _Foto = foto
        _Nombre = nombre
        _ApellidoP = apellidoP
        _ApellidoM = apellidoM
        _Direccion = direccion
        _Telefono = telefono
        _Fecha_Nacimiento = fecha_nacimiento
        _Password = password
        _Email = email
        _NucleoFlia = NucleoFlia
        _AntecedentesFlia = AntecedentesFlia
        _AntecedentesLab = antecedentesLab
        _Medicacion = medicacion
        _Tratamiento = tratamiento
    End Sub

    Public Sub New(ci As Integer,
                   foto As String,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   password As String,
                   email As String)
        _Ci = ci
        _Foto = foto
        _Nombre = nombre
        _ApellidoP = apellidoP
        _ApellidoM = apellidoM
        _Direccion = direccion
        _Telefono = telefono
        _Fecha_Nacimiento = fecha_nacimiento
        _Password = password
        _Email = email
        _NucleoFlia = "Sin ingresar"
        _AntecedentesFlia = "Sin ingresar"
        _AntecedentesLab = "Sin ingresar"
        _Medicacion = "Sin ingresar"
        _Tratamiento = "Sin ingresar"
    End Sub

    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   password As String,
                   email As String)
        _Ci = ci
        _Foto = ""
        _Nombre = nombre
        _ApellidoP = apellidoP
        _ApellidoM = apellidoM
        _Direccion = direccion
        _Telefono = telefono
        _Fecha_Nacimiento = fecha_nacimiento
        _Password = password
        _Email = email
        _NucleoFlia = "Sin ingresar"
        _AntecedentesFlia = "Sin ingresar"
        _AntecedentesLab = "Sin ingresar"
        _Medicacion = "Sin ingresar"
        _Tratamiento = "Sin ingresar"
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

    Public Sub Insert()

        Dim db As New DPaciente("root", "")
        Dim result = db.Insert(Ci,
                               Foto,
                               Nombre,
                               ApellidoP,
                               ApellidoM,
                               Direccion.Calle,
                               Direccion.Nro,
                               Direccion.Localidad,
                               Direccion.Departamento,
                               Direccion.Detalle,
                               Telefono,
                               Format(Fecha_Nacimiento, "yyyy-MM-dd"),
                               Password,
                               Email,
                               NucleoFlia,
                               AntecedentesFlia,
                               AntecedentesLab,
                               Medicacion,
                               Tratamiento)
        If result Then
            MsgBox("Paciente Ingresado exitosamente", MsgBoxStyle.Information, "Información")
        Else
            MsgBox("No se pudo ingresar al paciente.", MsgBoxStyle.Critical, "Error en el ingreso de paciente")

        End If
    End Sub
End Class
