Imports Logica
Public Class F_ABM

    Private Sub Btn_Pacientes_Click(sender As Object, e As EventArgs) Handles Btn_Pacientes.Click
        F_Pacientes.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Medicos_Click(sender As Object, e As EventArgs) Handles Btn_Medicos.Click
        F_Medicos.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Administradores_Click(sender As Object, e As EventArgs) Handles Btn_Administradores.Click
        MsgBox("Work in progress.")
    End Sub

    Private Sub Btn_Sitnomas_Click(sender As Object, e As EventArgs) Handles Btn_Sitnomas.Click
        F_Sintomas.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Enfermedades_Click(sender As Object, e As EventArgs) Handles Btn_Enfermedades.Click
        F_Enfermedades.Show()
        Me.Close()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        'Reseteo la variable de entorno de usuario
        Authentication.LogOut()
        F_Login.Show()
        Close()
    End Sub

    Private Sub Btn_Empleados_Click(sender As Object, e As EventArgs) Handles Btn_Empleados.Click
        MsgBox("Work in Progress.")
    End Sub
End Class