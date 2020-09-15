Imports System.Threading
Imports System.Globalization
Imports Logica
Imports Dominio
Public Class F_Empleados_Horarios
    Private Sub Btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        If Env.CurrentUser.IsRecepcionista Then
            F_ABM.Show()

        Else
            F_Empleados.Show()
        End If

        Close()
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
        Try
            Dim RRHHBUS As New RRHHBUS
            RRHHBUS.AddHorarioEmpleado(horario)
            MsgBox("Horario agregado con éxito", MsgBoxStyle.Information, "Información")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class