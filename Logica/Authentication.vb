Public Class Authentication
    Public Shared Sub LogOut()
        Env.CurrentUser = Nothing
        Env.ChangeLanguage(Env.Cultures.Espannol)
    End Sub

    Public Shared Function Authenticate(user As Persona) As Boolean
        Dim authenticated = False


        Return authenticated
    End Function
End Class
