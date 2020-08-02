Public Class F_ABM

    Private Sub Btn_Pacientes_Click(sender As Object, e As EventArgs) Handles Btn_Pacientes.Click
        F_Pacientes.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Personal_Click(sender As Object, e As EventArgs) Handles Btn_Personal.Click
        F_Medicos.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Horarios_Click(sender As Object, e As EventArgs) Handles Btn_Horarios.Click
        F_Medicos_Horarios.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Sitnomas_Click(sender As Object, e As EventArgs) Handles Btn_Sitnomas.Click
        F_Sintomas.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Enfermedades_Click(sender As Object, e As EventArgs) Handles Btn_Enfermedades.Click
        F_Enfermedades.Show()
        Me.Close()
    End Sub
End Class