Imports Dominio
Imports Logica

Public Class F_ContrasennaAutogenerada
    Public Sub New()
        InitializeComponent()
        Translator.TranslateForm(Me)
        Me.Text = Translator.TranslateKey("restablecer_contrasenna")
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim MedicoBUS As New MedicoBUS

        If TxtNewPassword.Text = TxtConfirmPassword.Text Then
            Dim result = MsgBox(Translator.TranslateKey("confirmacion_cambiar_contrasenna"), MsgBoxStyle.YesNo, Translator.TranslateKey("confirmacion"))

            If result = MsgBoxResult.Yes Then
                Try
                    Password.Validate(TxtNewPassword.Text)
                    MedicoBUS.ChangePassword(Env.CurrentUser.Ci, TxtNewPassword.Text)
                    MsgBox(Translator.TranslateKey("contrasenna_cambiada_exito"), MsgBoxStyle.Information, Translator.TranslateKey("informacion"))

                    F_Main.Show()
                    Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, Translator.TranslateKey("error"))
                End Try
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim result = MsgBox(Translator.TranslateKey("confirmacion_cancelar_cambio_contrasenna"), MsgBoxStyle.YesNo, Translator.TranslateKey("confirmacion"))

        If result = MsgBoxResult.Yes Then
            AuthenticationBUS.LogOut()
            F_Login.Show()
            Close()

        End If
    End Sub
End Class