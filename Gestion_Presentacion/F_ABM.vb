Public Class F_ABM

    Private Sub BtnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        F_Pacientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click
        F_Medicos.Show()
        Me.Hide()
    End Sub
End Class