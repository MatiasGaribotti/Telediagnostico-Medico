'Requerido para soportar varios idiomas
Imports System.Threading
Imports System.Globalization

Public Class F_Login

    Public Sub New()
        'Se obtienen el idioma a emplear de la propiedad estática (Shared)
        'Ubicada en la clase LanguageControl
        Thread.CurrentThread.CurrentUICulture = Logica.LanguageControl.CurrentLangugage
        InitializeComponent()
    End Sub

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        'Abre el formulario de ABM y cierra este
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnChangeLang_Click(sender As Object, e As EventArgs) Handles BtnChangeLang.Click

        If (Logica.LanguageControl.CurrentLangugage.ToString = "es-UY") Then
            Logica.LanguageControl.CurrentLangugage = New CultureInfo("en-US")

        ElseIf (Logica.LanguageControl.CurrentLangugage.ToString = "en-US") Then
            Logica.LanguageControl.CurrentLangugage = New CultureInfo("es-UY")
        End If

        'Esta nueva ventana inicializará los componentes
        'obteniendo los recursos con el idioma actualizado
        Dim window As New F_Login()
        window.Show()
        Me.Close()
    End Sub

End Class
