Imports Datos2
Public Class Recepcionista
    Inherits Empleado

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ci As Integer)
        MyBase.New(ci)
    End Sub

    Public Sub IngresarPaciente(paciente As Paciente)
        Dim objDPaciente As New DPaciente(
                Env.UserType,
                paciente.Ci,
                paciente.Nombre,
                paciente.ApellidoP,
                paciente.ApellidoM,
                New DDireccion(
                                paciente.Direccion.Calle,
                                paciente.Direccion.Nro,
                                paciente.Direccion.Localidad,
                                paciente.Direccion.Departamento,
                                paciente.Direccion.Detalle),
                paciente.Telefono,
                paciente.Fecha_Nacimiento,
                paciente.Password,
                paciente.Email)

        Try
            objDPaciente.Insert()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ResetPassword(paciente As Paciente)
        Dim objDPaciente As New DPaciente(Env.UserType)
        Dim password = Logica.Password.Generate(New Random)
        Dim hashedPassword = Logica.Password.Hash(password)
        paciente.Password = hashedPassword
        Try
            ' Implementar la impresión en una impresora POS
            Console.WriteLine("Nueva contraseña: " & password & vbCrLf & "SHA256: " & hashedPassword)

            objDPaciente.ActualizarContraseña(paciente.Ci, paciente.Password)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
