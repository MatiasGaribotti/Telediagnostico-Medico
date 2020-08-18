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

    Public Function Insert() As Boolean
        Dim saved As Boolean = False

        Dim DBSintoma As New DSintoma(Env.UserType, Nombre, Descripcion, Tipo)
        Dim DBEnfermedad As New DEnfermedad(Env.UserType)
        Dim idEnfermedades As New List(Of Short)

        'Veificar que existan las enfermedades
        Dim existenEnfermedades = False

        For Each enfermedad As Enfermedad In Enfermedades
            Dim id = DBEnfermedad.Find(enfermedad.Nombre)

            If id <> -1 Then
                idEnfermedades.Add(id)
                existenEnfermedades = True
            End If
        Next

        If existenEnfermedades Then
            saved = DBSintoma.Insert(Nombre, Descripcion, Tipo, idEnfermedades)
        End If
        Return saved
    End Function

    Public Function GetDgvData() As DataTable
        Dim db As DSintoma

        If Enfermedades.Count > 0 Then
            Dim dbenfermedades = EnfermedadToDEnfermeadad()
            dbenfermedades = New List(Of DEnfermedad)

            For Each enf In Enfermedades
                dbenfermedades.Add(New DEnfermedad(enf.Nombre))
            Next
            db = New DSintoma(Env.UserType, Nombre, Tipo, dbenfermedades)
        Else
            db = New DSintoma(Env.UserType, Me.Nombre, Me.Tipo)
        End If

        Return db.GetDgvData()
    End Function

    Public Function Filter() As DataTable
        Dim db As New DSintoma(Env.UserType, Nombre, Tipo)
        Return db.GetSintomasFound()
    End Function

    Public Function Find() As Sintoma

    End Function

    Public Function Delete() As Boolean
        Dim db As New DSintoma(Env.UserType, Id)
        Return db.Delete()
    End Function

    Public Function Modify() As Boolean
        Dim DEnfermedades = EnfermedadToDEnfermeadad()
        Dim db As New DSintoma(Env.UserType, Id, Nombre, Descripcion, Tipo, DEnfermedades)
        Return db.Modify()
    End Function

    Private Function EnfermedadToDEnfermeadad() As List(Of DEnfermedad)
        Dim DEnfermedades As New List(Of DEnfermedad)
        For Each enf In Enfermedades
            DEnfermedades.Add(New DEnfermedad(enf.Nombre))
        Next
        Return DEnfermedades
    End Function
End Class
