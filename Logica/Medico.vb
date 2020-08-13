Imports Datos2

Public Class Medico
    Inherits Persona

    'Constructor comúm completo
    Public Sub New(ci As Integer,
                   nombre As String,
                   apellidoP As String,
                   apellidoM As String,
                   direccion As Direccion,
                   telefono As Integer,
                   fecha_nacimiento As Date,
                   especialidad As String,
                   password As String
                   )
        Me.Ci = ci
        Me.Nombre = nombre
        Me.ApellidoP = apellidoP
        Me.ApellidoM = apellidoM
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Fecha_Nacimiento = fecha_nacimiento
        Me.Especialidad = especialidad
        Me.Password = password

    End Sub

    Public Sub Insert()

        Dim db As New DMedico("admin", "123456789")
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
        Especialidad,
        Password)
        If result Then
            MsgBox("Médico ingresado exitosamente", MsgBoxStyle.Information, "Información")
        Else
            MsgBox("No se pudo ingresar el médico.", MsgBoxStyle.Critical, "Error en el ingreso de médico")

        End If

    End Sub
End Class
