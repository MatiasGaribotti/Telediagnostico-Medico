Imports System.Threading
Imports System.Globalization
Imports Logica

Public Class F_Pacientes

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Logica.LanguageControl.CurrentLangugage
        InitializeComponent()

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        'Dim paciente As New Paciente(
        '    11111111, "n1 n2", "ap1", "ap2",
        '    New Direccion("8 de Octubre", 1245, "Montevideo", Direccion.Departamentos.Montevideo), 91111111,
        '    New Date(2001, 5, 19), "password", "email@test.com")

        Dim paciente As New Paciente(
           11111111, "n1 n2", "ap1", "ap2",
           New Direccion("8 de Octubre", 1245, "Montevideo", "Montevideo"), 91111111,
           New Date(2001, 5, 19), "password", "email@test.com")
        MsgBox(paciente.Direccion.Departamento)
    End Sub
End Class