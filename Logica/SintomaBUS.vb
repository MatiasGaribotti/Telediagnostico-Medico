Imports Datos
Imports Dominio
Public Class SintomaBUS


    Public Function GetSintomas() As DataTable
        Dim SintomaDAO As New SintomaDAO()
        Try
            Return SintomaDAO.GetSintomas()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetSintomas(pattern As Sintoma) As DataTable
        Dim db As New SintomaDAO()
        Dim dt As DataTable
        If pattern.Enfermedades.Count > 0 Then
            dt = db.GetSintomas(pattern.Nombre, pattern.Tipo, pattern.Enfermedades)
        Else
            dt = db.GetSintomas(pattern.Nombre, pattern.Tipo)
        End If

        Return dt
    End Function


End Class
