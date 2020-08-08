Imports System.Threading
Imports System.Globalization
Imports Logica
Public Class F_Medicos_Horarios
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim horario
        'dia
        'If (RbtnL.Checked) Then

        'End If
        horario = New Horario(
                    CInt(TxtCi.Text),
                    CByte(CmbISucursal.SelectedItem.ToString),
                    "lunes",
                    TxtIHoraIn.Text,
                    TxtIHoraOut.Text
                    )

        horario.Insert()
    End Sub

End Class