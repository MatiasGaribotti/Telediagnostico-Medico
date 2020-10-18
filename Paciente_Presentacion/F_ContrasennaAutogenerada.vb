Imports Dominio
Imports Logica

Public Class F_ContrasennaAutogenerada
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim PacienteBUS As New PacienteBUS

        If TxtNewPassword.Text = TxtConfirmPassword.Text Then
            Try
                Password.Validate(TxtNewPassword.Text)
                PacienteBUS.ChangePassword(Env.CurrentUser.Ci, TxtNewPassword.Text)
                MsgBox("contrasenna_cambio_exito", MsgBoxStyle.Information, "informacion")

                F_Sintomas.Show()
                Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
            End Try

        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click, Me.FormClosing
        Dim result = MsgBox("contrasenna_cambio_confirmacion_cancelar", MsgBoxStyle.YesNo, "confirmacion")

        If result = MsgBoxResult.Yes Then
            AuthenticationBUS.LogOut()
            F_Login.Show()
            Close()

        End If
    End Sub
End Class