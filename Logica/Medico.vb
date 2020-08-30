Imports Datos2

Public Class Medico
    Inherits Empleado
    Public Property Especialidad As String

    'Constructor por defecto
    Public Sub New()
        MyBase.New()
        Especialidad = "Default"
    End Sub

    Public Sub New(ci As Integer)
        MyBase.New(ci)
    End Sub

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
        MyBase.New(ci, nombre, apellidoP, apellidoM, direccion, telefono, fecha_nacimiento, password)
        Me.Especialidad = especialidad
    End Sub

    Public Sub Insert()

        Dim db As New DMedico(Env.UserType)
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

    Public Function GetDgvData() As DataTable
        Dim db As New DMedico(Env.UserType)
        Dim dt = db.GetDgvData()
        Return dt
    End Function
End Class
