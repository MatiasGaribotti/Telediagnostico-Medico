Imports Dominio
Imports Logica
Public Class F_Sintomas

    Public Sub New()

        InitializeComponent()
        LeftPanel.BackColor = ColorTranslator.FromHtml("#E9F4F5")
        OpenMainRightPanel()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs)
        OpenMainRightPanel()
    End Sub

    'Este procedimiento abri el panel derecho principal
    Private Sub OpenMainRightPanel()

        Dim frmSintomasTipo As New F_Sintomas_Buscar_Tipo With {
           .MdiParent = Me
       }
        frmSintomasTipo.Show()
        frmSintomasTipo.SetBounds(960, 0, 955, 1075) ' 5px menos de ancho y alto para que no aparezcan las scrollbars
        frmSintomasTipo.AutoScroll = False
    End Sub

    Private Sub OpenMainRightPanel2()

        Dim frmSintomasTipo As New F_Sintomas_Buscar With {
           .MdiParent = Me
       }
        frmSintomasTipo.Show()
        frmSintomasTipo.SetBounds(960, 0, 955, 1075) ' 5px menos de ancho y alto para que no aparezcan las scrollbars
        frmSintomasTipo.AutoScroll = False
    End Sub

    Private Sub Btn_HC_Click(sender As Object, e As EventArgs)
        F_Login.Show()
        Close()
    End Sub

    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs)
        OpenMainRightPanel2()
    End Sub

    Private Sub DgvPacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSintomas.CellContentClick

    End Sub

    Private Sub BtnDiagnosticoTest_Click(sender As Object, e As EventArgs) Handles BtnDiagnosticoTest.Click
        Dim Autoconsulta As New AutoconsultaBUS
        Dim test As New List(Of Sintoma)
        test.Add(New Sintoma(1, "Dolor de Cabeza", "", Sintoma.TiposSintomas.Cabeza))
        'test.Add(New Sintoma(5, "Fiebre", "", Sintoma.TiposSintomas.Cabeza))
        'test.Add(New Sintoma(6, "Tos", "", Sintoma.TiposSintomas.Cabeza))
        test.Add(New Sintoma(7, "Flemas", "", Sintoma.TiposSintomas.Cabeza))
        test.Add(New Sintoma(10, "Fatiga", "", Sintoma.TiposSintomas.Cabeza))
        test.Add(New Sintoma(11, "Falta de apetito", "", Sintoma.TiposSintomas.Cabeza))
        test.Add(New Sintoma(12, "Dificultad para respirar", "", Sintoma.TiposSintomas.Cabeza))
        test.Add(New Sintoma(13, "Escalofríos", "", Sintoma.TiposSintomas.Cabeza))
        test.Add(New Sintoma(14, "Dolor muscular generalizado", "", Sintoma.TiposSintomas.Cabeza))

        Try
            Dim diagnosisList = Autoconsulta.GetDiagnosis(test)

            For Each diagnosis In diagnosisList
                Console.WriteLine("Se diagnosticó: {0}", diagnosis.Enfermedad.Nombre)
            Next

        Catch ex As Exception

        End Try
    End Sub
End Class
