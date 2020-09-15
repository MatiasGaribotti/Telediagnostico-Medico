Imports Logica
Imports Dominio
Public Class F_ABM

    Private Sub Btn_Pacientes_Click(sender As Object, e As EventArgs) Handles Btn_Pacientes.Click
        If Env.CurrentUser.IsAdministrador Or Env.CurrentUser.IsRecepcionista Then
            F_Pacientes.Show()
            Close()
        Else
            MsgBox("Accesso Denegado", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Btn_Sitnomas_Click(sender As Object, e As EventArgs) Handles Btn_Sitnomas.Click
        If Env.CurrentUser.IsAdministrador Then
            F_Sintomas.Show()
            Close()
        Else
            MsgBox("Accesso Denegado", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub Btn_Enfermedades_Click(sender As Object, e As EventArgs) Handles Btn_Enfermedades.Click
        If Env.CurrentUser.IsAdministrador Then
            F_Enfermedades.Show()
            Close()
        Else
            MsgBox("Accesso Denegado", MsgBoxStyle.Critical)

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
            MsgBox("Accesso Denegado", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        'Reseteo la variable de entorno de usuario
        AuthenticationBUS.LogOut()
        F_Login.Show()
        Close()
    End Sub

End Class