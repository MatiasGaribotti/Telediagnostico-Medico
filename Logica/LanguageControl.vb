Imports System.Globalization
Public Class LanguageControl

    Private Shared _CurrentLangugage As New CultureInfo("es-UY")

    Public Shared Property CurrentLangugage As CultureInfo
        Get
            Return _CurrentLangugage
        End Get
        Set(value As CultureInfo)
            _CurrentLangugage = value
        End Set
    End Property
End Class
