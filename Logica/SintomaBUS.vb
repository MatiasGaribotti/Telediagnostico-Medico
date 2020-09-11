Imports Datos
Imports Dominio
Public Class SintomaBUS
    Public Sub AsociarEnfermedad(ByRef sintoma As Sintoma, enfermedad As Enfermedad)
        sintoma.Enfermedades.Add(enfermedad)
    End Sub

    Public Sub Insert(sintoma As Sintoma)

        Dim DBSintoma As New SintomaDAO()
        Dim objEnfermedad As New Enfermedad()

        For Each enfermedad In GetEnfermedadesAsociadas(sintoma.Id)
            sintoma.Enfermedades.Add(enfermedad)
        Next

        Try
            DBSintoma.Insert(sintoma)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetSintomas() As DataTable
        Dim SintomaDAO As New SintomaDAO()
        Return SintomaDAO.GetSintomas()
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

    Public Function GetEnfermedadesAsociadas(id As Short) As List(Of Enfermedad)
        Dim SintomaDAO As New SintomaDAO()
        Return SintomaDAO.GetEnfermedadesAsociadas(id)
    End Function

    Public Sub Delete(id As Short)
        Dim db As New SintomaDAO()
        Try
            db.Delete(id)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modify(sintoma As Sintoma)

        'Creo el objeto del sintoma con los datos modificados
        Dim SintomaDAO As New SintomaDAO()

        Try
            SintomaDAO.Modify(sintoma)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
