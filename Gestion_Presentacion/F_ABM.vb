Imports System.Threading
Imports Logica
Imports Dominio
Public Class F_ABM

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()

    End Sub
    Private Sub F_ABM_Load(sender As Object, e As EventArgs) Handles Me.Load
        Translator.TranslateForm(Me)
        Refresh()
    End Sub

    Private Sub Btn_Pacientes_Click(sender As Object, e As EventArgs) Handles Btn_Pacientes.Click
        If Env.CurrentUser.IsAdministrador Or Env.CurrentUser.IsRecepcionista Then
            F_Pacientes.Show()
            Close()
        Else
            MsgBox(Translator.TranslateKey("acceso_denegado"), MsgBoxStyle.Critical, Translator.TranslateKey("error"))
        End If
    End Sub

    Private Sub Btn_Sitnomas_Click(sender As Object, e As EventArgs) Handles Btn_Sitnomas.Click
        If Env.CurrentUser.IsAdministrador Then
            F_Sintomas.Show()
            Close()
        Else
            MsgBox(Translator.TranslateKey("acceso_denegado"), MsgBoxStyle.Critical, Translator.TranslateKey("error"))

        End If
    End Sub

    Private Sub Btn_Enfermedades_Click(sender As Object, e As EventArgs) Handles Btn_Enfermedades.Click
        If Env.CurrentUser.IsAdministrador Then
            F_Enfermedades.Show()
            Close()
        Else
            MsgBox(Translator.TranslateKey("acceso_denegado"), MsgBoxStyle.Critical, Translator.TranslateKey("error"))

        End If
    End Sub
    Private Sub Btn_Empleados_Click(sender As Object, e As EventArgs) Handles Btn_Empleados.Click
        If Env.CurrentUser.IsRRHH Then
            F_Empleados.Show()
            Close()

        ElseIf Env.CurrentUser.IsRecepcionista Then
            F_Empleados_Horarios.Show()
            Close()

        Else
            MsgBox(Translator.TranslateKey("acceso_denegado"), MsgBoxStyle.Critical, Translator.TranslateKey("error"))
        End If
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        'Reseteo la variable de entorno de usuario
        Dim result = MsgBox(Translator.TranslateKey("confirmacion_cerrar_sesion"), MsgBoxStyle.YesNo, Translator.TranslateKey("confirmacion"))

        If result = MsgBoxResult.Yes Then
            AuthenticationBUS.LogOut()
            F_Login.Show()
            Close()

        End If
    End Sub
End Class