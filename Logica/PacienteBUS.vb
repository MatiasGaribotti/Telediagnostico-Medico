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
            Throw New FormatException("error_formato_nucleo_familiar")

        ElseIf ContainsSymbol(AntFam) Then
            ' Antecedentes familiares contiene símbolos
            Throw New FormatException("error_formato_antecedentes_familiares")


        ElseIf ContainsSymbol(AntLab) Then
            ' Antecedentes laborales contiene símbolos
            Throw New FormatException("error_formato_antecedentes_laborales")
        End If
    End Sub
    Public Sub EndChat(idChat As Long)
        Try
            ChatBUS.EndChat(idChat)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub SendMsg(idChat As Long, msg As Mensaje)
        Try
            ChatBUS.SendMsg(idChat, msg)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetChatStatusByIdConsulta(idConsulta As Long) As Chat.ChatStatus
        Return ChatBUS.GetChatStatusByIdConsulta(idConsulta)
    End Function

    Public Function GetChat(idConsulta As Long) As Chat
        Dim ConsultaDAO As New ConsultaDAO
        Return ChatBUS.GetChat(idConsulta)
    End Function

    Public Function GetMensajes(idChat As Long, Optional startIndex As Long = 0) As List(Of Mensaje)
        Try
            Return ChatBUS.GetMensajesChat(idChat, startIndex)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetGreatestMsgIndex(mensajes As List(Of Mensaje)) As Long
        Return ChatBUS.GetGreatestMsgIndex(mensajes)
    End Function

    Public Function GetMedico(consulta As ConsultaMedica) As Medico
        Dim ConsultaDAO As New ConsultaDAO
        Dim dt As DataTable
        Try
            dt = ConsultaDAO.GetMedico(consulta.Id)
        Catch ex As Exception
            Throw New Exception("Error al obtener el médico.")
        End Try

        If dt.Rows.Count = 1 Then
            Dim row = dt.Rows.Item(0)
            Dim ciMedico As Integer = row.Field(Of Int64)("ci")
            Dim nombre As String = row.Field(Of String)("nombre")
            Dim apellidoP As String = row.Field(Of String)("apellidoP")
            Dim apellidoM As String = row.Field(Of String)("apellidoM")
            Dim sexo As Persona.Sexos = [Enum].Parse(GetType(Persona.Sexos), row.Field(Of String)("sexo"))
            Dim fechaNacimiento As Date = row.Field(Of Date)("fechaNacimiento")
            Dim telefono As Integer = row.Field(Of Int32)("telefono")
            Dim idEspecialidad As Integer = row.Field(Of Int32)("idEspecialidad")
            Dim especialidad As String = row.Field(Of String)("especialidad")

            Return New Medico(
                ciMedico,
                nombre,
                apellidoP,
                apellidoM,
                sexo,
                telefono,
                fechaNacimiento,
                New List(Of Especialidad)({New Especialidad(idEspecialidad, especialidad)})
                )

        Else
            Return Nothing
        End If
    End Function
End Class