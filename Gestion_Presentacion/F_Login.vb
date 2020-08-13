'Requerido para soportar varios idiomas
Imports System.Threading
Imports System.Globalization
Imports Logica

Public Class F_Login

    Public Sub New()
        'Se obtienen el idioma a emplear de la propiedad estática (Shared)
        'Ubicada en la clase LanguageControl
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()
    End Sub

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        If Authentication.Authenticate(New Empleado(TxtCi.Text, TxtPassword.Text)) Then
            'Abre el formulario de ABM y cierra este
            F_ABM.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnChangeLang_Click(sender As Object, e As EventArgs) Handles BtnChangeLang.Click

        If (Env.CurrentLangugage.ToString = "es-UY") Then
            Env.ChangeLanguage(Env.Cultures.Ingles)

        ElseIf (Env.CurrentLangugage.ToString = "en-US") Then
            Env.ChangeLanguage(Env.Cultures.Espannol)
        End If

        'Esta nueva ventana inicializará los componentes
        'obteniendo los recursos con el idioma actualizado
        Dim window As New F_Login()
        window.Show()
        Me.Close()
    End Sub
End Class
