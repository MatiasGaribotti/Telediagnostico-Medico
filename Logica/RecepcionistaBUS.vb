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

    Public Function ResetPassword(paciente As Paciente) As String
        Dim plainTextPassword = Logica.Password.Generate(New Random)

        Console.WriteLine("CI: {0} - Pass: {1}", paciente.Ci, plainTextPassword)

        Try
            ChangePassword(paciente.Ci, paciente.Password)

        Catch ex As Exception
            Throw ex
        End Try
        Return plainTextPassword
    End Function
End Class
