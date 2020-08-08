Imports System.Threading
Imports System.Globalization
Imports Logica

Public Class F_Pacientes

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Logica.LanguageControl.CurrentLangugage
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
End Class