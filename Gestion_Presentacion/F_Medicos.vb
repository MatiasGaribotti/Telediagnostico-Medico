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

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
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

    Private Sub TxtICi_TextChanged(sender As Object, e As EventArgs) Handles TxtICi.TextChanged

    End Sub

    Private Sub TxtICalle_TextChanged(sender As Object, e As EventArgs) Handles TxtICalle.TextChanged

    End Sub

    Private Sub CmbIDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbIDepartamento.SelectedIndexChanged

    End Sub

    Private Sub gbtn_nPassw_Click(sender As Object, e As EventArgs) Handles gbtn_nPassw.Click

    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click

    End Sub
End Class