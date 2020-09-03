Imports Datos2
Public Class Administrador
    Inherits Medico

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
                                        paciente.Email,
                                        paciente.NucleoFlia,
                                        paciente.AntecedentesFlia,
                                        paciente.AntecedentesLab
                                        )

        Try
            objDPaciente.Insert()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function GetPaciente(ci As Integer) As Paciente
        Dim objDPaciente As New DPaciente(Env.UserType)
        Dim paciente As Paciente


    End Function

End Class
