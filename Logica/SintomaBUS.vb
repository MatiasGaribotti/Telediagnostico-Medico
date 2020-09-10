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

    Public Function GetSintomas(pattern As String, type As Sintoma.TiposSintomas) As DataTable
        Dim db As New SintomaDAO()

        If type = 0 Then
            query = "SELECT id,nombre,descripcion,tipo FROM sintomas  WHERE ENABLED=1" & " AND nombre LIKE '%" & pattern & "%';"
        End If
        Return db.GetSintomas(query)
    End Function

    Public Function Filter() As DataTable
        Dim db As New SintomaDAO(Env.UserType, Nombre, Tipo)
        Return db.Filter()
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

    Public Sub Modify()
        'objeto para utilizar las utilidades de la clase Enfermedad
        Dim objEnfermedad As New Enfermedad()

        'Lista de enfermedades pero adaptadas para ir hacia la BD
        Dim DEnfermedades As New List(Of DEnfermedad)

        'Para cada enfermedad, la convierto en una enfermedad compatible con la BD y la agrego a la lista
        For Each enfermedad In Me.Enfermedades
            Dim converted As DEnfermedad = objEnfermedad.ToDEnfermedad(enfermedad)
            DEnfermedades.Add(converted)
        Next

        'Creo el objeto del sintoma con los datos modificados
        Dim SintomaDAO As New SintomaDAO(Env.UserType, Id, Nombre, Descripcion, Tipo, DEnfermedades)
        Try
            SintomaDAO.Modify()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
