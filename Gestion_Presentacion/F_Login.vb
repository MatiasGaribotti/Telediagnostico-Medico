'Requerido para soportar varios idiomas
Imports System.Threading
Imports System.Globalization
Imports Logica
Imports System.Text.RegularExpressions

Public Class F_Login

    Public Sub New()
        'Se obtienen el idioma a emplear de la propiedad estática (Shared)
        'Ubicada en la clase LanguageControl
        Env.CurrentApp = Env.Apps.Gestion
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()
    End Sub

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click

        Try
            If ValidateFields() Then
                Dim user = GetUser()
                If Authentication.Authenticate(user) Then
                    'Abre el formulario de ABM y cierra este
                    F_ABM.Show()
                    Me.Close()
                Else
                    MsgBox("CI y/o contraseña incorrecta.", MsgBoxStyle.Critical, "Autenticación")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Autenticación")
        End Try
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

        If Not ci.Length = 0 And Not password.Length = 0 Then
            If Not ci.Length > 8 Then
                Dim chars = ci.ToCharArray


                For Each caracter In chars
                    If Not Char.IsDigit(caracter) Then
                        Throw New FormatException("La cédula de identidad debe contener solo números.")
                    End If
                Next

            Else
                Throw New FormatException("La cédula de identidad es obligatoria.")
            End If

        Else
            MsgBox("La CI o contraseña no pueden ser vacías.")
            valid = False
        End If
        Return valid
    End Function

    Private Function GetUser() As Empleado
        Return New Empleado(CInt(TxtCi.Text), TxtPassword.Text)
    End Function
End Class
