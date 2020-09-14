Imports Datos
Imports Dominio
Public Class EnfermedadBUS

    ''' <summary>
    ''' Funcion que retorna la información de las enfermedades asociadas a un síntoma, si es que existen
    ''' </summary>
    ''' <param name="enfermedades"></param>
    ''' <returns></returns>
    Public Function GetInfoEnfermedades(enfermedades As List(Of Enfermedad)) As List(Of Enfermedad)
        Dim EnfermedadDAO As New EnfermedadDAO()
        Dim found As New List(Of Enfermedad)

        'Veifico que existan las enfermedades y las agrego a la lista de enfermedades
        For Each enfermedad In enfermedades
            Try
                Dim id = EnfermedadDAO.GetEnfermedadByName(enfermedad.Nombre)
                found.Add(New Enfermedad(id, enfermedad.Nombre))

            Catch ex As Exception
                Throw ex
            End Try
        Next
        Return found
    End Function

    ''' <summary>
    ''' Obtiene todas las enfermedades ingresadas en el sistema.
    ''' </summary>
    ''' <returns>Retorna un DataTable con todas las enfermedades.</returns>
    Public Function GetEnfermedades() As DataTable
        Dim EnfermedadDAO As New EnfermedadDAO()
        Return EnfermedadDAO.GetEnfermedades()
    End Function

    Public Function GetEnfermedades(pattern As Enfermedad) As DataTable
        Dim EnfermedadDAO As New EnfermedadDAO()
        Try
            Return EnfermedadDAO.GetEnfermedades(pattern.Nombre, pattern.Urgencia, pattern.Cronica)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
