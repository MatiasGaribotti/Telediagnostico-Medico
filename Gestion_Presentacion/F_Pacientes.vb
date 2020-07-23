Imports System.Threading
Imports System.Globalization

Public Class F_Pacientes
    Private _Language As CultureInfo

    Public Function GetLanguage() As CultureInfo
        Return _Language
    End Function

    Public Sub SetLanguage(AutoPropertyValue As CultureInfo)
        _Language = AutoPropertyValue
    End Sub

    Public Sub New()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

End Class