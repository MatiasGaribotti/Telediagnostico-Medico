Imports System.Threading
Imports System.Globalization
Imports Logica
Imports Dominio
Public Class F_Login

    ''' <summary>
    ''' Constructor por defecto.
    ''' </summary>
    Public Sub New()
        Env.CurrentApp = Env.Apps.Paciente
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()

    End Sub
    Private Sub F_Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Translator.TranslateForm(Me)
        Refresh()
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

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        Try
            AuthenticationBUS.ValidateFields(TxtCi.Text, TxtPassword.Text)
            AuthenticationBUS.LogIn(CInt(TxtCi.Text), TxtPassword.Text)

            If Password.IsGenerated(TxtPassword.Text) Then
                F_ContrasennaAutogenerada.Show()
            Else
                F_Sintomas.Show()
                Me.Close()

            End If

        Catch ex As Exception
            MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("autenticacion"))
        End Try
    End Sub

End Class
