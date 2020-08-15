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

    Public Sub AsociarEnfermedad(enfermedad As Enfermedad)
        Me.Enfermedades.Add(enfermedad)
    End Sub

    Public Function Insert() As Boolean
        Dim saved As Boolean = False

        Dim DBSintoma As New DSintoma("admin", "123456789")
        Dim DBEnfermedad As New DEnfermedad("admin", "123456789")
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
End Class
