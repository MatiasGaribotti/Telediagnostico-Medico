Public Class DPersona
    Inherits DBConnection

    Public Property Ci As Integer
    Public Property Nombre As String
    Public Property ApellidoP As String
    Public Property ApellidoM As String
    Public Property Direccion As DDireccion
    Public Property Telefono As Integer
    Public Property Fecha_Nacimiento As Date
    Public Property User_Password As String

    Public Sub New(userType As Short)
        MyBase.New(userType)
        Me.Ci = 11111111
        Me.Nombre = "Default"
        Me.ApellidoP = "Default"
        Me.ApellidoM = "Default"
        Me.Direccion = New DDireccion()
        Me.Telefono = -1
        Me.Fecha_Nacimiento = New Date(1, 1, 1)
        Me.User_Password = "Default"
    End Sub

    'Este constructor se utilizará unicamente para autenticación
    Public Sub New(userType As Short, ci As Integer, user_password As String)
        MyBase.New(userType)
        Me.Ci = ci
        Me.Nombre = "Default"
        Me.ApellidoP = "Default"
        Me.ApellidoM = "Default"
        Me.Direccion = New DDireccion()
        Me.Telefono = -1
        Me.Fecha_Nacimiento = New Date(1, 1, 1)
        Me.User_Password = user_password
    End Sub

    Public Sub New(
            userType As Short,
            Ci As Integer,
            nombre As String,
            apellidoP As String,
            apellidoM As String,
            direccion As DDireccion,
            telefono As Integer,
            fecha_Nacimiento As Date,
            user_Password As String)
        Me.New(userType)
        Me.Ci = Ci
        Me.Nombre = nombre
        Me.ApellidoP = apellidoP
        Me.ApellidoM = apellidoM
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Fecha_Nacimiento = fecha_Nacimiento
        Me.User_Password = user_Password
    End Sub

    Public Sub Modify()

    End Sub

    Public Sub ActualizarContraseña(ci As Integer, password As String)
        If HasConnection() Then
            Dim con = Conectar()
            Dim query As String = "UPDATE personas SET password='" & password & "' WHERE ci='" & ci & "';"

            Try
                con.Execute(query)
            Catch ex As Exception
                'Debug
                Console.WriteLine("Mensaje de la excepción: " & ex.Message & vbCrLf & "StackTrace: " & ex.StackTrace)
                Throw New Exception("No se pudo actualizar la contraseña.")
            Finally
                con.Close()
            End Try
        End If
    End Sub
End Class
