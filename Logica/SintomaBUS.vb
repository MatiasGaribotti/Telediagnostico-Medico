Imports Datos2
Imports Dominio
Public Class SintomaBUS
    Public Sub AsociarEnfermedad(enfermedad As Enfermedad)
        Me.Enfermedades.Add(enfermedad)
    End Sub

    Public Sub Insert()
        Dim DBSintoma As New DSintoma(Env.UserType, Nombre, Descripcion, Tipo)
        Dim objEnfermedad As New Enfermedad()
        Dim listDEnfermedades As New List(Of DEnfermedad)

        For Each enfermedad In GetEnfermedadesAsociadas()
            Dim converted = objEnfermedad.ToDEnfermedad(enfermedad)
            listDEnfermedades.Add(converted)
        Next
        DBSintoma.Enfermedades = listDEnfermedades

        Try
            DBSintoma.Insert()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetSintomas() As DataTable
        Dim db As New DSintoma()
        Return db.GetSintomas()
    End Function

    Public Function GetSintomas(pattern As String, type As TiposSintomas) As DataTable
        Dim db As New DSintoma()
        Dim query = "SELECT id,nombre,descripcion,tipo FROM sintomas  WHERE ENABLED=1" & " AND nombre LIKE '%" & pattern & "%'" & " AND s.tipo=" & type.ToString & ";"
        If type = 0 Then
            query = "SELECT id,nombre,descripcion,tipo FROM sintomas  WHERE ENABLED=1" & " AND nombre LIKE '%" & pattern & "%';"
        End If
        Return db.GetSintomas(query)
    End Function

    Public Function Filter() As DataTable
        Dim db As New DSintoma(Env.UserType, Nombre, Tipo)
        Return db.Filter()
    End Function

    Public Function GetEnfermedadesAsociadas() As List(Of Enfermedad)
        Dim db As New DSintoma(Env.UserType, Id)
        Dim DEnfermedades = db.GetEnfermedadesAsociadas()
        Dim enfermedades As New List(Of Enfermedad)
        For Each i In DEnfermedades
            enfermedades.Add(New Enfermedad(i.Id, i.Nombre))
        Next
        Return enfermedades
    End Function

    Public Sub Delete()
        Dim db As New DSintoma(Env.UserType, Id)
        db.Delete()
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
        Dim dsintoma As New DSintoma(Env.UserType, Id, Nombre, Descripcion, Tipo, DEnfermedades)
        Try
            dsintoma.Modify()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
