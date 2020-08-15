Imports Datos2
Public Class Authentication
    Public Shared Sub LogOut()
        Env.CurrentUser = Nothing
        Env.UserType = Nothing
        Env.ChangeLanguage(Env.Cultures.Espannol)
    End Sub

    Public Shared Function Authenticate(user As Persona) As Boolean
        Dim authenticated = False
        Dim db As New DAuthentication("system", "kHzRj1&5")
        'Dim RecordSet As RecordSet

        'Return authenticated
        Return True
    End Function
End Class
