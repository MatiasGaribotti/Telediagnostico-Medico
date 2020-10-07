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

    Public Function GetPacienteByCi(ciPaciente As Integer) As Paciente
        Dim PacienteDAO As New PacienteDAO
        Dim dt As DataTable

        Try
            dt = PacienteDAO.GetPacienteByCi(ciPaciente)
        Catch ex As Exception
            Throw New Exception("No se pudo obtener el paciente.")
        End Try

        If dt.Rows.Count = 1 Then
            Try
                Dim row = dt.Rows.Item(0)

                Dim ci As Integer = row.Field(Of Int32)("Cedula")
                Dim tempNombre As String() = row.Field(Of String)("Nombre Completo").Split(",")
                Dim sexo As Persona.Sexos = row.Field(Of String)("Sexo")
                Dim fechaNacimiento As Date = row.Field(Of Date)("Fecha de Nacimiento")
                Dim telefono As Integer = row.Field(Of Integer)("Telefono")
                Dim email As String = row.Field(Of String)("Email")
                Dim tempDireccion As String() = row.Field(Of String)("Direccion").Split(",")
                Dim nucleoFamiliar As String = row.Field(Of String)("Nucleo Familiar")
                Dim antecedentesFamiliares As String = row.Field(Of String)("Antecedentes Familiares")
                Dim antecedentesLaborales As String = row.Field(Of String)("Antecedentes Laborales")

                Dim nombre As String = tempNombre.ElementAt(0)
                Dim apellidoP As String = tempNombre.ElementAt(1)
                Dim apellidoM As String = tempNombre.ElementAt(2)

                Dim direccion As New Direccion(tempDireccion.ElementAt(0),
                                           tempDireccion.ElementAt(1),
                                           tempDireccion.ElementAt(2),
                                           tempDireccion.ElementAt(3)
                                           )

                Return New Paciente(ci, nombre, apellidoP, apellidoM, sexo, direccion, telefono, fechaNacimiento, email, nucleoFamiliar, antecedentesFamiliares, antecedentesLaborales)

            Catch ex As Exception
                Throw New Exception("No se pudo obtener la información del paciente.")
            End Try
        Else
            Return Nothing
        End If
    End Function

    Public Function GetSintomasRegistrados(idConsulta As Long) As List(Of Sintoma)
        Dim ConsultaDAO As New ConsultaDAO
        Dim dt As DataTable
        Dim listaSintomas As New List(Of Sintoma)

        Try
            dt = ConsultaDAO.GetSintomasRegistrados(idConsulta)
        Catch ex As Exception
            Throw New Exception("No se pudieron obtener los síntomas registrados por el paciente.")
        End Try

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Dim idSintoma As Short = row.Field(Of Int16)("id")
                Dim nombre As String = row.Field(Of String)("nombre")
                Dim descripcion As String = row.Field(Of String)("descripcion")
                Dim tipo As Sintoma.TiposSintomas = [Enum].Parse(GetType(Sintoma.TiposSintomas), row.Field(Of String)("tipo"))

                listaSintomas.Add(New Sintoma(idSintoma, nombre, descripcion, tipo))
            Next

            Return listaSintomas

        Else
            Return Nothing
        End If
    End Function

    Public Function GetDiagnosticos(idConsulta As Long) As List(Of Enfermedad)
        Dim ConsultaDAO As New ConsultaDAO
        Dim dt As DataTable
        Dim listaDiagnosticos As New List(Of Enfermedad)


        Try
            dt = ConsultaDAO.GetDiagnosticos(idConsulta)
        Catch ex As Exception
            Throw New Exception("No se pudieron obtener los diagnósticos de la consulta.")
        End Try

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows

                Dim idEnfermedad As Short = row.Field(Of Int32)("id")
                Dim nombre As String = row.Field(Of String)("nombre")
                Dim descripcion As String = row.Field(Of String)("descripcion")
                Dim urgencia As Enfermedad.Urgencias = [Enum].Parse(GetType(Enfermedad.Urgencias), row.Field(Of String)("urgencia"))
                Dim cronica As Boolean = CBool(row.Field(Of Byte)("cronica"))

                listaDiagnosticos.Add(New Enfermedad(idEnfermedad, nombre, descripcion, urgencia, cronica))
            Next

            Return listaDiagnosticos

        Else
            Return Nothing
        End If
    End Function
End Class
