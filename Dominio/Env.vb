Imports System.Globalization
Public Class Env

    Public Shared Property CurrentApp As Apps
    Public Shared Property CurrentLangugage As CultureInfo = New CultureInfo("es-UY")
    Public Shared Property CurrentUser As New Persona()

    Private Sub New()

    End Sub
    Public Shared Sub ChangeLanguage(culture As Cultures)
        If culture = Cultures.Espannol Then
            CurrentLangugage = New CultureInfo("es-UY")
        ElseIf culture = Cultures.Ingles Then
            CurrentLangugage = New CultureInfo("en-US")
        End If

    End Sub

    Public Enum Roles
        Medico
        Recursos_Humanos
        Recepcionista
    End Enum

    Public Enum Cultures
        Espannol
        Ingles
    End Enum

    Public Enum Apps
        Paciente
        Medico
        Gestion
    End Enum
End Class
