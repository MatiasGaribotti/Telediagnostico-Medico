Imports Datos
Imports Dominio
Public Class MedicoBUS
    Inherits EmpleadoBUS

    Public Overloads Sub ValidateFields(ci As String,
                              nombres As String,
                              apellidoP As String,
                              apellidoM As String,
                              calle As String,
                              numero As String,
                              localidad As String,
                              telefono As String,
                              rol As String,
                              especialidades As List(Of String)
                              )
        MyBase.ValidateFields(ci,
                              nombres,
                              apellidoP,
                              apellidoM,
                              calle,
                              numero,
                              localidad,
                              telefono,
                              rol
                              )
        ValidateEspecialidades(especialidades)

    End Sub

    ''' <summary>
    ''' Valida que las especialidades ingresadas se encuentren en la base de datos.
    ''' </summary>
    ''' <param name="pEspecialidades">Lista de especialidades a validar.</param>
    ''' <exception cref="KeyNotFoundException">Tirada cuando la especialidad no existe en la base de datos.</exception>
    Private Sub ValidateEspecialidades(pEspecialidades As List(Of String))
        Dim ListaEspecialidades As List(Of Especialidad) = GetEspecialidades()

        For Each esp In pEspecialidades
            If Not ListaEspecialidades.Contains(New Especialidad(esp)) Then
                Throw New KeyNotFoundException("Especialidad '" & esp & "' no encontrada")

            End If
        Next

    End Sub

    ''' <summary>
    ''' Obtiene las especialidades que se encuentran ingresadas en la base de datos.
    ''' </summary>
    ''' <returns>Retorna la lista de especialidaes que se encontró.</returns>
    Public Function GetEspecialidades() As List(Of Especialidad)
        Dim MedicoDAO As New MedicoDAO()
        Try
            Dim data = MedicoDAO.GetEspecialidades()
            Dim especialidades As New List(Of Especialidad)


            For Each row As DataRow In data.Rows
                Dim especialidad As New Especialidad
                especialidad.Id = row.Field(Of Integer)(0)
                especialidad.Nombre = row.Field(Of String)(1)

                especialidades.Add(especialidad)
            Next
            Return especialidades

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ParseEspecialidades(pPspecialidades As String, separator As Char) As List(Of Especialidad)
        Dim listaEspecialidades As New List(Of Especialidad)

        Try
            Dim tempEspecialidades = pPspecialidades.Split(separator)
            For Each especialidad In tempEspecialidades
                listaEspecialidades.Add(New Especialidad(especialidad))
            Next

            Return listaEspecialidades
        Catch ex As Exception
            Throw New Exception("Ha ocurrido un error en la conversión de especialidades.")
        End Try
    End Function

    Public Function GetChats() As DataTable
        Dim ConsultaDAO As New ConsultaDAO

        Try
            Return ConsultaDAO.GetSolicitudesChats()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub StartChat(idConsulta As Long, ciMedico As Integer)
        Dim ConsultaDAO As New ConsultaDAO

        Try
            ChatBUS.StartChat(idConsulta, ciMedico)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetChat(idConsulta As Long) As Chat
        Return ChatBUS.GetChat(idConsulta)
    End Function

    Public Function GetMensajesChat(idChat As Long, Optional startIndex As Long = 0) As List(Of Mensaje)
        Try
            Return ChatBUS.GetMensajesChat(idChat, startIndex)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub SendMsg(idChat As Long, msg As Mensaje)
        Try
            ChatBUS.SendMsg(idChat, msg)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub UpdateChats(ByRef consultasActivas As List(Of ConsultaMedica))

        For Each consulta In consultasActivas
            Dim greatestIndex As Long = GetGreatestMsgIndex(consulta.Chat.Mensajes)
            Try
                Dim mensajesObtenidos = GetMensajesChat(consulta.Chat.Id, greatestIndex)
                For Each mensaje In mensajesObtenidos
                    consulta.Chat.Mensajes.Add(mensaje)
                Next

            Catch ex As Exception
                Throw ex
            End Try
        Next
    End Sub

    Private Function GetGreatestMsgIndex(mensajes As List(Of Mensaje)) As Long
        Return ChatBUS.GetGreatestMsgIndex(mensajes)
    End Function
End Class
