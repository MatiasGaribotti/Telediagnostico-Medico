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

    Public Sub SendMsg(idChat As Long, msg As Mensaje)
        Dim ConsultaDAO As New ConsultaDAO

        Try
            ConsultaDAO.SendMsg(idChat, msg)
        Catch ex As Exception
            Console.WriteLine("Error: {0} " & vbCrLf & "StackTrace: {1}", ex.Message, ex.StackTrace)
            Throw New Exception("No se pudo enviar el mensaje.")
        End Try
    End Sub

    Public Function GetChatIfActive(idConsulta As Long) As Chat
        Dim ConsultaDAO As New ConsultaDAO
        Dim dt As DataTable

        Try
            dt = ConsultaDAO.GetChat(idConsulta)
        Catch ex As Exception
            Console.WriteLine("Error: {0} " & vbCrLf & "StackTrace: {1}", ex.Message, ex.StackTrace)
            Throw New Exception("Error al obtener la consulta.")
        End Try

        If dt.Rows.Count = 0 Then
            Return Nothing

        Else
            Dim row = dt.Rows.Item(0)

            Dim idChat = row.Field(Of Decimal)("id")
            Dim ciMedico As Integer = row.Field(Of Int64)("ciMedico")

            Return New Chat(idChat)

        End If
    End Function

    Public Function GetMensajes(idChat As Long, Optional startIndex As Long = 0) As List(Of Mensaje)
        Dim ConsultaDAO As New ConsultaDAO
        Dim dt As DataTable
        Dim mensajes As New List(Of Mensaje)


        Try
            dt = ConsultaDAO.GetMensajesChat(idChat, startIndex)
        Catch ex As Exception
            Console.WriteLine("Error: {0} " & vbCrLf & "StackTrace: {1}", ex.Message, ex.StackTrace)
            Throw New Exception("Error al obtener los mensajes del chat.")
        End Try

        If dt.Rows.Count > 0 Then
            Try
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim cells = dt.Rows.Item(i)

                    Dim id As Long = cells.Field(Of Decimal)("id")
                    Dim ciPersona As Integer = cells.Field(Of Int64)("ciPersona")
                    Dim texto As String = cells.Field(Of String)("mensaje")
                    Dim timestamp As Date = cells.Field(Of System.DateTime)("fechaHora")

                    mensajes.Add(New Mensaje(id, ciPersona, texto, timestamp))
                Next

            Catch ex As Exception

            End Try

        End If
        Return mensajes
    End Function
End Class
