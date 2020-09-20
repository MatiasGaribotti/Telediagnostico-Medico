Imports Datos
Imports Dominio
Public Class RecepcionistaBUS
    Inherits EmpleadoBUS

    Public Sub IngresarPaciente(pPaciente As Paciente)
        Dim PacienteDAO As New PacienteDAO()

        Try
            PacienteDAO.Insert(pPaciente)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ModifyPaciente(pPaciente As Paciente)
        Dim PacienteDAO As New PacienteDAO
        Try
            PacienteDAO.Modify(pPaciente)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeletePaciente(pPaciente As Paciente)
        Dim PacienteDAO As New PacienteDAO

        Try
            DeletePersona(pPaciente.Ci)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ResetPassword(paciente As Paciente)
        Dim PacienteDAO As New PacienteDAO()
        Dim password = Logica.Password.Generate(New Random)
        Dim hashedPassword = Logica.Password.Hash(password)
        paciente.Password = hashedPassword

        Try
            ' Implementar la impresión en una impresora POS
            Console.WriteLine("Nueva contraseña: " & password & vbCrLf & "SHA256: " & hashedPassword)

            PacienteDAO.UpdatePassword(paciente.Ci, paciente.Password)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
