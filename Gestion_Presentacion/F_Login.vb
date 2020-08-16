'Requerido para soportar varios idiomas
Imports System.Threading
Imports System.Globalization
Imports Logica
Imports System.Text.RegularExpressions

Public Class F_Login

    Public Sub New()
        'Se obtienen el idioma a emplear de la propiedad estática (Shared)
        'Ubicada en la clase LanguageControl
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()
    End Sub

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click

        Dim user = GetUser()

        If Authentication.Authenticate(user) Then
            'Abre el formulario de ABM y cierra este
            F_ABM.Show()
            Me.Close()
            Env.CurrentUser = user
            'Env.UserType = 
        Else
            MsgBox("CI y/o contraseña incorrecta.")
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
    'Función que valida el formato de los campos
    Private Function ValidateFields() As Boolean
        Dim valid = True

        Dim ci = TxtCi.Text
        Dim password = TxtPassword.Text

        Dim expression As String = ""
        If Regex.IsMatch(ci, expression) Then
            'valid = False
        ElseIf Regex.IsMatch(password, expression) Then
            'valid = False
        End If

        Return valid
    End Function

    Private Function GetUser() As Empleado
        If ValidateFields() Then
            Return New Empleado(CInt(TxtCi.Text), TxtPassword.Text)
        Else
            MsgBox("El formato de la CI no es válido.")
            Return Nothing
        End If

    End Function

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click

    End Sub

    Private Sub Btn_Minimize_Click(sender As Object, e As EventArgs) Handles Btn_Minimize.Click

    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub
End Class
