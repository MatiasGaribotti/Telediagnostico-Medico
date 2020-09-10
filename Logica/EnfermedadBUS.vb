Imports Datos
Imports Dominio
Public Class EnfermedadBUS
    Public Sub Insert(enfermedad As Enfermedad)

        Dim EnfermedadDAO As New EnfermedadDAO()
        Dim idFound = EnfermedadDAO.Find(enfermedad.Nombre)

        ' Si la enfermedad no se está en la BD la ingreso
        If idFound = -1 Then
            EnfermedadDAO.Insert(enfermedad)
        Else
            Throw New DuplicateNameException("La enfermedad ya se encuentra en el sistema.")
        End If

    End Sub

    'Funcion que retorna la información de las enfermedades asociadas a un síntoma, si es que existen
    Public Function GetInfoEnfermedades(enfermedades As List(Of Enfermedad)) As List(Of Enfermedad)
        Dim DBEnfermedad As New EnfermedadDAO()
        Dim found As New List(Of Enfermedad)

        'Veifico que existan las enfermedades y las agrego a la lista de enfermedades
        For Each enfermedad In enfermedades
            Dim id = DBEnfermedad.Find(enfermedad.Nombre)
            found.Add(New Enfermedad(id, enfermedad.Nombre))
        Next
        Return found
    End Function

    ' Función que obtiene las enfermedades ingresadas en el sistema
    Public Function GetEnfermedades() As DataTable
        Dim EnfermedadDAO As New EnfermedadDAO()
        Return EnfermedadDAO.GetEnfermedades()
    End Function
End Class
