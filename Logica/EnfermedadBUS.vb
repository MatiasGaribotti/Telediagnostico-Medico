Imports Dominio
Public Class EnfermedadBUS
    Public Sub Insert()

        Dim db As New DEnfermedad(Env.UserType)
        Dim idFound = db.Find(Nombre)

        ' Si la enfermedad no se está en la BD la ingreso
        If idFound = -1 Then
            db.Insert(Nombre, Descripcion, Urgencia)
        Else
            Throw New DuplicateNameException("La enfermedad ya se encuentra en el sistema.")
        End If

    End Sub

    'Funcion que retorna la información de las enfermedades asociadas a un síntoma, si es que existen
    Public Function GetInfoEnfermedades(enfermedades As List(Of Enfermedad)) As List(Of Enfermedad)
        Dim DBEnfermedad As New DEnfermedad(Env.UserType)
        Dim found As New List(Of Enfermedad)

        'Veifico que existan las enfermedades y las agrego a la lista de enfermedades
        For Each enfermedad In enfermedades
            Dim id = DBEnfermedad.Find(enfermedad.Nombre)
            found.Add(New Enfermedad(id, enfermedad.Nombre))
        Next
        Return found
    End Function

    Public Function ToDEnfermedad(ByVal enfermedad As Enfermedad) As DEnfermedad
        Dim DEnfermedad As DEnfermedad = New DEnfermedad(CShort(Env.UserType), enfermedad.Id, enfermedad.Nombre)
        Return DEnfermedad
    End Function

    ' Función que obtiene las enfermedades ingresadas en el sistema
    Public Function GetEnfermedades() As DataTable
        Dim objDEnfermedad As New DEnfermedad(Env.UserType)
        Return objDEnfermedad.GetEnfermedades()
    End Function
End Class
