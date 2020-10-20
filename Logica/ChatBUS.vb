Imports Dominio
Imports Datos
Imports System.IO
Imports System.Text

Public Class ChatBUS

    Friend Shared Sub StartChat(idConsulta As Long, ciMedico As Integer)
        Dim ConsultaDAO As New ConsultaDAO

        Try
            ConsultaDAO.StartChat(idConsulta, ciMedico)
        Catch ex As Exception
            Throw New Exception("No se pudo iniciar el chat.")
        End Try
    End Sub

    Friend Shared Sub EndChat(idChat As Long)
        Dim ConsultaDAO As New ConsultaDAO

        Try
            ConsultaDAO.EndChat(idChat)
            SendChatCopyByEmail(idChat)

        Catch ex As Exception
            Throw New Exception("No se pudo finalizar el chat.")
        End Try
    End Sub

    Friend Shared Function GetChatStatusByIdConsulta(idConsulta As Long) As Chat.ChatStatus
        Dim ConsultaDAO As New ConsultaDAO
        Dim dt As DataTable

        Try
            dt = ConsultaDAO.GetChatStatus(idConsulta)
        Catch ex As Exception
            Throw New Exception("Error al obtener el estado del chat.")
        End Try

        Dim row = dt.Rows.Item(0)
        Dim ciMedico As Long = 0

        If row.Field(Of Object)("ciMedico") IsNot Nothing Then
            ciMedico = row.Field(Of Int64)("ciMedico")

        End If

        Dim finalizado = CBool(row.Field(Of Int16)("finalizado"))

        If ciMedico = 0 Then
            Return Chat.ChatStatus.Waiting

        ElseIf ciMedico <> 0 And finalizado = False Then
            Return Chat.ChatStatus.Active

        Else
            Return Chat.ChatStatus.Ended
        End If
    End Function

    Friend Shared Function GetChat(idConsulta As Long) As Chat
        Dim ConsultaDAO As New ConsultaDAO
        Dim dt As DataTable

        Try
            dt = ConsultaDAO.GetChatId(idConsulta)

            If dt.Rows.Count > 0 Then
                Dim idChat = Long.Parse(dt.Rows.Item(0).Field(Of Decimal)("id"))

                Return New Chat(idChat)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Console.WriteLine("Error: {0}" & vbCrLf & "StackTrace: {1}", ex.Message, ex.StackTrace)
            Throw New Exception("Error al obtener el chat.")
        End Try
    End Function

    Friend Shared Function GetMensajesChat(idChat As Long, Optional startIndex As Long = 0) As List(Of Mensaje)
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
                    Dim nombrePersona As String = cells.Field(Of String)("nombre")
                    Dim texto As String = cells.Field(Of String)("mensaje")
                    Dim timestamp As Date = cells.Field(Of System.DateTime)("fechaHora")

                    mensajes.Add(New Mensaje(id, New Medico(ciPersona, nombrePersona), texto, timestamp))
                Next

            Catch ex As Exception

            End Try

        End If
        Return mensajes
    End Function

    Friend Shared Sub SendMsg(idChat As Long, msg As Mensaje)
        Dim ConsultaDAO As New ConsultaDAO
        Try
            ConsultaDAO.SendMsg(idChat, msg)

        Catch ex As Exception
            Throw New Exception("error_enviar_mensaje")
        End Try
    End Sub

    Friend Shared Function GetGreatestMsgIndex(mensajes As List(Of Mensaje)) As Long
        Dim greatest As Long = 1
        For Each mensaje In mensajes
            If mensaje.Id > greatest Then
                greatest = mensaje.Id
            End If
        Next

        Return greatest
    End Function

    Friend Shared Sub SendChatCopyByEmail(idChat As Long)
        Dim path = My.Computer.FileSystem.CurrentDirectory & "\" & Date.Now.ToShortDateString.Replace("/", ".") & "-" & Date.Now.ToLongTimeString.Replace(":", ".") & "-Copia_de_Chat.txt"

        Try
            Dim mensajes As List(Of Mensaje) = GetMensajesChat(idChat)
            If mensajes.Count > 0 Then
                Dim fs As FileStream = File.Create(path)

                For Each mensaje In mensajes
                    Dim text As String = mensaje.Timestamp & "-" & mensaje.Persona.Nombre & ": " & mensaje.Texto & vbCrLf
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(text)
                    fs.Write(info, 0, info.Length)

                Next
                fs.Close()

            End If
        Catch ex As Exception
            Throw New Exception("error_copia_chat")
        End Try
    End Sub
End Class
