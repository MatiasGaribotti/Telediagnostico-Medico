'Requerido para soportar varios idiomas
Imports System.Threading
Imports System.Globalization

Public Class F_Login

    Public Sub New()
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
        Dim window As New F_Login()
        window.Show()
        Me.Close()
    End Sub
End Class
