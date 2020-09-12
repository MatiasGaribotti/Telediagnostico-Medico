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

End Class
