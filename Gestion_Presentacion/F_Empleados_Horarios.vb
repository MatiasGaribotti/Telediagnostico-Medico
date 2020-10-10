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
        Dim horario As Horario = GetHorario()

        Try
            Dim RRHHBUS As New RRHHBUS
            RRHHBUS.AddHorarioEmpleado(horario)
            MsgBox("Horario agregado con éxito", MsgBoxStyle.Information, "Información")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function GetHorario() As Horario

        Dim ci As Integer = Integer.Parse(TxtICi.Text)
        Dim nombreSucursal As String = CmbISucursal.SelectedItem.ToString
        Dim strHorarioEntrada As String() = TxtIEntrada.Text.Split(":")
        Dim horaEntrada As Integer = Integer.Parse(strHorarioEntrada.ElementAt(0))
        Dim minutosEntrada As Integer = Integer.Parse(strHorarioEntrada.ElementAt(1))

        Dim strHorarioSalida As String() = TxtISalida.Text.Split(":")
        Dim horaSalida As Integer = Integer.Parse(strHorarioSalida.ElementAt(0))
        Dim minutosSalida As Integer = Integer.Parse(strHorarioSalida.ElementAt(1))

        Dim horarioEntrada As New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, horaEntrada, minutosEntrada, 0)
        Dim horarioSalida As New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, horaSalida, minutosSalida, 0)

        Dim diasGuardia As List(Of Horario.DiasSemana) = GetCheckedDiasInsert()

        Return New Horario(Env.CurrentUser.Ci, Env.CurrentSucursal, diasGuardia, horarioEntrada, horarioSalida)
    End Function

    Private Function GetCheckedDiasInsert() As List(Of Horario.DiasSemana)
        Dim dias As New List(Of Horario.DiasSemana)

        If ChkILunes.Checked Then
            dias.Add(Horario.DiasSemana.Lunes)
        End If

        If ChkIMartes.Checked Then
            dias.Add(Horario.DiasSemana.Martes)
        End If

        If ChkIMiercoles.Checked Then
            dias.Add(Horario.DiasSemana.Miercoles)
        End If

        If ChkIJueves.Checked Then
            dias.Add(Horario.DiasSemana.Jueves)
        End If

        If ChkIViernes.Checked Then
            dias.Add(Horario.DiasSemana.Viernes)
        End If

        If ChkISabado.Checked Then
            dias.Add(Horario.DiasSemana.Sabado)
        End If

        If ChkIDomingo.Checked Then
            dias.Add(Horario.DiasSemana.Domingo)
        End If

        Return dias
    End Function
End Class