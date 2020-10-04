Imports Dominio
Imports Datos
Public Class ChatBUS

    Friend Shared Sub StartChat(idConsulta As Long, ciMedico As Integer)
        Dim ConsultaDAO As New ConsultaDAO

        Try
            ConsultaDAO.StartChat(idConsulta, ciMedico)
        Catch ex As Exception
            Console.WriteLine("Error: {0}" & vbCrLf & "StackTrace: {1}", ex.Message, ex.StackTrace)
            Throw New Exception("No se pudo iniciar el chat.")
        End Try
    End Sub

    Friend Shared Function GetChat(idConsulta As Long) As Chat
        Dim chat As New Chat()
        Dim ConsultaDAO As New ConsultaDAO
        Dim dt As DataTable

        Try
            dt = ConsultaDAO.GetChatId(idConsulta)

            If dt.Rows.Count > 0 Then
                chat.Id = Long.Parse(dt.Rows.Item(0).Field(Of Decimal)("id"))
                Return chat
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
            Throw New Exception("No se pudo enviar el mensaje.")
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

End Class
