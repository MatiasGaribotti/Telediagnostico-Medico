Imports Datos2
Public Class Paciente
    Inherits Persona
    Public Property Email As String
    Public Property NucleoFlia As String
    Public Property AntecedentesFlia As String
    Public Property AntecedentesLab As String
    Public Property Medicacion As String
    Public Property Tratamiento As String


    'Constructor comúm completo
    Public Sub New(ci As Integer,
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
        Me.Ci = ci
        Me.Nombre = nombre
        Me.ApellidoP = apellidoP
        Me.ApellidoM = apellidoM
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Fecha_Nacimiento = fecha_nacimiento
        Me.Password = password
        Me.Email = email
        Me.NucleoFlia = NucleoFlia
        Me.AntecedentesFlia = AntecedentesFlia
        Me.AntecedentesLab = antecedentesLab
        Me.Medicacion = medicacion
        Me.Tratamiento = tratamiento
    End Sub

    ' Constructor común Parcial
    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   password As String,
                   email As String)
        Me.Ci = ci
        Me.Nombre = nombre
        Me.ApellidoP = apellidoP
        Me.ApellidoM = apellidoM
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Fecha_Nacimiento = fecha_nacimiento
        Me.Password = password
        Me.Email = email
        Me.NucleoFlia = "Sin ingresar"
        Me.AntecedentesFlia = "Sin ingresar"
        Me.AntecedentesLab = "Sin ingresar"
        Me.Medicacion = "Sin ingresar"
        Me.Tratamiento = "Sin ingresar"
    End Sub

    Public Sub Insert()

        Dim db As New DPaciente("admin", "123456789")
        Dim result = db.Insert(Ci,
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
