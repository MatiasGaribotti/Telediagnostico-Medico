Imports Dominio
Imports Datos2
Public Class PacienteBUS
    Inherits PersonaBUS

    Public Sub Insert(pPaciente As Paciente)
        Dim DPaciente As DPaciente

        If Env.UserType = Env.UserTypes.Recepcionista Then
            DPaciente = New DPaciente(
                Env.UserType,
                Ci,
                Nombre,
                ApellidoP,
                ApellidoM,
                New DDireccion(
                                Direccion.Calle,
                                Direccion.Nro,
                                Direccion.Localidad,
                                Direccion.Departamento,
                                Direccion.Detalle),
                Telefono,
                Fecha_Nacimiento,
                Password,
                Email)

        ElseIf Env.UserType = Env.UserTypes.Administrador Then
            DPaciente = New DPaciente(Env.UserType, Ci,
                Nombre,
                ApellidoP,
                ApellidoM,
                New DDireccion(
                                Direccion.Calle,
                                Direccion.Nro,
                                Direccion.Localidad,
                                Direccion.Departamento,
                                Direccion.Detalle),
                Telefono,
                Fecha_Nacimiento,
                Password,
                Email,
                NucleoFlia,
                AntecedentesFlia,
                AntecedentesLab)

        End If
        Try
            DPaciente.Insert()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetPacientes() As DataTable
        Dim db As New DPaciente(Env.UserType)
        Dim dt As DataTable
        Try
            dt = db.GetPacientes()

        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function

    Public Overloads Sub ValidateFields(ci As String,
                                        nombres As String,
                                        apellidoP As String,
                                        ApellidoM As String,
                                        calle As String,
                                        numero As String,
                                        localidad As String,
                                        detalle As String,
                                        telefono As String,
                                        nucleoFlia As String,
                                        AntFam As String,
                                        AntLab As String)
        MyBase.ValidateFields(ci,
                              nombres,
                              apellidoP,
                              ApellidoM,
                              calle,
                              numero,
                              localidad,
                              detalle,
                              telefono)

        If ContainsSymbol(nucleoFlia) Then
            ' Núcleo Familiar contiene símbolos
            Throw New FormatException("El formato del campo núcleo familiar no es correcto.")

        ElseIf ContainsSymbol(AntFam) Then
            ' Antecedentes familiares contiene símbolos
            Throw New FormatException("El formato del campo antecedentes familiares no es correcto.")


        ElseIf ContainsSymbol(AntLab) Then
            ' Antecedentes laborales contiene símbolos
            Throw New FormatException("El formato del campo antecedentes laborales no es correcto.")
        End If
    End Sub
End Class
