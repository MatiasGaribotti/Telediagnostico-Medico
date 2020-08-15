Imports System.Threading
Imports System.Globalization
Imports Logica

Public Class F_Pacientes

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Logica.Env.CurrentLangugage
        InitializeComponent()

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        Dim paciente As New Paciente(
                            CInt(TxtICi.Text),
                            TxtINombre.Text,
                            TxtIApellidoP.Text,
                            TxtIApellidoM.Text,
                            New Direccion(TxtICalle.Text,
                                            CInt(TxtINumero.Text),
                                            TxtILocalidad.Text,
                                            CmbIDepartamento.SelectedItem.ToString),
                            CInt(TxtITelefono.Text),
                            Format(DTPickerFNac.Value, "yyyy-MM-dd"),
                            "password",
                            TxtIEmail.Text
                            )

        paciente.Insert()
    End Sub

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each departamento As String In Direccion.Departamentos
            CmbIDepartamento.Items.Add(departamento)
        Next
    End Sub

    Private Sub TxtICi_TextChanged(sender As Object, e As EventArgs) Handles TxtICi.TextChanged

    End Sub

    Private Sub TxtICalle_TextChanged(sender As Object, e As EventArgs) Handles TxtICalle.TextChanged

    End Sub

    Private Sub CmbIDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbIDepartamento.SelectedIndexChanged

    End Sub

    Private Sub TxtIApellidoM_TextChanged(sender As Object, e As EventArgs) Handles TxtIApellidoM.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub CmbBDetalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBDetalle.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TxtBLocalidad_TextChanged(sender As Object, e As EventArgs) Handles TxtBLocalidad.TextChanged

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Close()
    End Sub
End Class