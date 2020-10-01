'Requerido para soportar varios idiomas
Imports System.Threading
Imports System.Globalization
Imports Logica
Imports Dominio
Public Class F_Login

    ''' <summary>
    ''' Constructor por defecto.
    ''' </summary>
    Public Sub New()
        Env.CurrentApp = Env.Apps.Medico
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()
    End Sub

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        Try
            AuthenticationBUS.ValidateFields(TxtCi.Text, TxtPassword.Text)
            Dim user = New Persona(CInt(TxtCi.Text), TxtPassword.Text)

            If AuthenticationBUS.Authenticate(user) Then
                'Abre el formulario de ABM y cierra este
                F_Main.Show()
                Me.Close()
            Else
                MsgBox("CI y/o contraseña incorrecta.", MsgBoxStyle.Critical, "Autenticación")
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
End Class
