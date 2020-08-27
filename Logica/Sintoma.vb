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
        Dim DBEnfermedad As New DEnfermedad(Env.UserType)

        Try
            Enfermedades = GetEnfermedades()
            DBSintoma.Insert() '<<===============================CHECK
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetDgvData() As DataTable
        Dim db As New DSintoma()
        'Return db.GetDgvData()
        Return db.test()
    End Function

    Public Function Filter() As DataTable
        Dim db As New DSintoma(Env.UserType, Nombre, Tipo)
        Return db.GetSintomasFound()
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

    Public Function Delete() As Boolean
        Dim db As New DSintoma(Env.UserType, Id)
        Return db.Delete()
    End Function

    Public Function Modify() As Boolean
        Dim DEnfermedades = EnfermedadToDEnfermeadad()
        Dim dsintoma As New DSintoma(Env.UserType, Id, Nombre, Descripcion, Tipo, DEnfermedades)

        Try
            dsintoma.Modify()

        Catch ex As Exception
            Throw ex
        End Try

        'Return db.Modify()

    End Function

    'Funcion que retorna la información de las enfermedades ingresadas, si es que existen
    Public Function GetEnfermedades() As List(Of Enfermedad)
        Dim DBEnfermedad As New DEnfermedad(Env.UserType)
        Dim found As New List(Of Enfermedad)

        'Veifico que existan las enfermedades y las agrego a la lista de enfermedades
        For Each enfermedad In Enfermedades
            Dim id = DBEnfermedad.Find(enfermedad.Nombre)
            found.Add(New Enfermedad(id, enfermedad.Nombre))
        Next
        Return found
    End Function

    Private Function EnfermedadToDEnfermeadad() As List(Of DEnfermedad)
        Dim DEnfermedades As New List(Of DEnfermedad)
        For Each enf In Enfermedades
            DEnfermedades.Add(New DEnfermedad(CShort(Env.UserType), enf.Id, enf.Nombre))
        Next
        Return DEnfermedades
    End Function

End Class