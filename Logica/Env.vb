Imports System.Globalization
Public Class Env
    Public Shared Property CurrentLangugage As CultureInfo = New CultureInfo("es-UY")
    Public Shared Property CurrentUser As Persona

    Public Shared Sub ChangeLanguage(culture As Cultures)
        If culture = Cultures.Espannol Then
            CurrentLangugage = New CultureInfo("es-UY")
        ElseIf culture = Cultures.Ingles Then
            CurrentLangugage = New CultureInfo("en-US")
        End If

    End Sub

    Public Enum Cultures
        Espannol
        Ingles
    End Enum
End Class
