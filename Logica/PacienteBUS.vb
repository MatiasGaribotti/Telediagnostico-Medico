Imports Dominio
Imports Datos
Public Class PacienteBUS
    Inherits PersonaBUS

    Public Sub Insert(pPaciente As Paciente)
        Dim PacienteDAO As New PacienteDAO
        If Env.CurrentUser.IsRecepcionista Then
            pPaciente.NucleoFlia = "Default"
            pPaciente.AntecedentesFlia = "Sin ingresar"
            pPaciente.AntecedentesLab = "Sin ingresar"
        End If

        Try
            PacienteDAO.Insert(pPaciente)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetPacientes() As DataTable
        Dim PacienteDAO As New PacienteDAO
        Dim dt As DataTable
        Try
            dt = PacienteDAO.GetPacientes()

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
