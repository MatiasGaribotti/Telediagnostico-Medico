Imports Datos2
Public Class Sintoma
    Public Property Id As Short
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Tipo As TiposSintomas
    Public Property Enfermedades As List(Of Enfermedad)

    Public Enum TiposSintomas
        Cabeza = 1 'inicializo en 1 el primer miembro para que coincida con la BD.
        Torso
        Extremidades
    End Enum

    Public Sub New()
        Me.Id = -1
        Me.Nombre = "Default"
        Me.Descripcion = "Default"
        Me.Tipo = TiposSintomas.Cabeza
        Me.Enfermedades = New List(Of Enfermedad)
    End Sub

    Public Sub New(id As Short)
        Me.Id = id
        Me.Nombre = "Default"
        Me.Descripcion = "Default"
        Me.Tipo = TiposSintomas.Cabeza
        Me.Enfermedades = New List(Of Enfermedad)
    End Sub

    Public Sub New(id As Short,
                   nombre As String,
                   descripcion As String,
                   tipo As TiposSintomas)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Tipo = tipo
        Me.Enfermedades = New List(Of Enfermedad)
    End Sub

    Public Sub New(id As Short,
                   nombre As String,
                   descripcion As String,
                   tipo As TiposSintomas,
                   enfermedades As List(Of Enfermedad))
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Tipo = tipo
        Me.Enfermedades = enfermedades
    End Sub

    Public Sub New(nombre As String, descripcion As String, Tipo As TiposSintomas)
        Me.Id = -1
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Tipo = Tipo
        Me.Enfermedades = New List(Of Enfermedad)
    End Sub

    Public Sub New(nombre As String, Tipo As TiposSintomas)
        Me.Id = -1
        Me.Nombre = nombre
        Me.Descripcion = Descripcion
        Me.Tipo = Tipo
        Me.Enfermedades = New List(Of Enfermedad)
    End Sub

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