Imports Datos2

Public Class Medico
    Inherits Persona



    'Constructor comúm completo
    Public Sub New(ci As Integer,
                   foto As String,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   especialidad As String,
                   password As String
                   )
        _Ci = ci
        _Foto = foto
        _Nombre = nombre
        _ApellidoP = apellidoP
        _ApellidoM = apellidoM
        _Direccion = direccion
        _Telefono = telefono
        _Fecha_Nacimiento = fecha_nacimiento
        _Especialidad = especialidad
        _Password = password

    End Sub

    ' Constructor común para recepcionistas
    ' Sin foto
    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   password As String,
                   especialidad As String)
        _Ci = ci
        _Foto = ""
        _Nombre = nombre
        _ApellidoP = apellidoP
        _ApellidoM = apellidoM
        _Direccion = direccion
        _Telefono = telefono
        _Fecha_Nacimiento = fecha_nacimiento
        _Password = password
        _Especialidad = especialidad

    End Sub





    Public Sub Insert()

        Dim db As New DMedico("admin", "123456789")
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
        Especialidad,
        Password)
        If result Then
            MsgBox("Médico ingresado exitosamente", MsgBoxStyle.Information, "Información")
        Else
            MsgBox("No se pudo ingresar el médico.", MsgBoxStyle.Critical, "Error en el ingreso de médico")

        End If

    End Sub
End Class
