Imports System.Threading
Imports System.Globalization
Imports Logica

Public Class F_Medicos

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Logica.Env.CurrentLangugage
        InitializeComponent()

    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs)
        Dim medico As New Medico(
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
                            "Medicina In General",
                            "password"
                            )

        medico.Insert()
    End Sub

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each departamento As String In Direccion.Departamentos
            CmbIDepartamento.Items.Add(departamento)
        Next
    End Sub

    Private Sub BtnHorarios_Click(sender As Object, e As EventArgs) Handles BtnHorarios.Click
        F_Medicos_Horarios.Show()
        Close()
    End Sub

    Private Sub BtnFiltrar_Click_1(sender As Object, e As EventArgs)

    End Sub

End Class