Imports System.Threading
Imports System.Globalization
Imports Logica
Public Class F_Medicos_Horarios
    Private Sub Btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        F_Medicos.Show()
        Me.Close()
    End Sub

    Private Sub Btn_ingresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim horario As Horario
        'dia
        'If (RbtnL.Checked) Then

        'End If
        horario = New Horario(
                    CInt(TxtICi.Text),
                    CByte(CmbISucursal.SelectedItem.ToString),
                    Horario.Dias.Lunes,
                    TxtIHoraIn.Text,
                    TxtIHoraOut.Text
                    )

        horario.Insert()
    End Sub

    Private Sub pnl_ingresar_Paint(sender As Object, e As PaintEventArgs) Handles pnl_ingresar.Paint

    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class