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
                                            CmbBDepartamento.SelectedItem.ToString),
                            CInt(TxtITelefono.Text),
                            Format(DTPickerFNac.Value, "yyyy-MM-dd"),
                            "password",
                            TxtIEmail.Text
                            )

        paciente.Insert()
    End Sub
End Class