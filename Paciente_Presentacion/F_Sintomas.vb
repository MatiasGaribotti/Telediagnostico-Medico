Imports Dominio
Imports Logica
Imports System.Threading
Public Class F_Sintomas

    Private pattern As Sintoma
    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()
        pattern = New Sintoma
        ConfigureSelectedColumnVisibility()
        LoadDgv()

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim result = MsgBox("¿Está seguro de que desea cerrar sesión?", MsgBoxStyle.YesNo, "Confirmación")

        If result = vbYes Then
            AuthenticationBUS.LogOut()
            F_Login.Show()
            Close()
        End If
    End Sub

    Private Sub LoadDgv()
        Dim SintomaBUS As New SintomaBUS()
        Try
            Dim dt As DataTable = SintomaBUS.GetSintomas()
            DgvAllSintomas.DataSource = dt
            ConfigureColumnVisibility()
            DgvAllSintomas.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadDgv(pattern As Sintoma)
        Dim SintomaBUS As New SintomaBUS()
        Try
            Dim dt As DataTable = SintomaBUS.GetSintomas(pattern)
            DgvAllSintomas.DataSource = dt
            ConfigureColumnVisibility()
            DgvAllSintomas.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigureColumnVisibility()
        For i As Integer = 0 To DgvAllSintomas.Columns.Count - 1
            If Not i = 1 Then
                DgvAllSintomas.Columns.Item(i).Visible = False
            End If
        Next
    End Sub

    Private Sub ConfigureSelectedColumnVisibility()
        For i As Integer = 0 To DgvSelectedSintomas.Columns.Count - 1
            If Not i = 1 Then
                DgvSelectedSintomas.Columns.Item(i).Visible = False
            End If
        Next

        DgvSelectedSintomas.Refresh()
    End Sub

    Private Sub OpenMainRightPanel()

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

    Private Sub DgvPacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSelectedSintomas.CellContentClick

    End Sub

    Private Sub BtnDiagnosticoTest_Click(sender As Object, e As EventArgs) Handles BtnDiagnosticoTest.Click

        AutoconsultaBUS.instance.AddSintoma(New Sintoma(1, "Dolor de Cabeza", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(5, "Fiebre", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(6, "Tos", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(7, "Flemas", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(10, "Fatiga", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(11, "Falta de apetito", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(12, "Dificultad para respirar", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(13, "Escalofríos", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(14, "Dolor muscular generalizado", "", Sintoma.TiposSintomas.Cabeza))

        Try

            Dim diagnosisList = AutoconsultaBUS.instance.GetDiagnosis()

            For Each diagnosis In diagnosisList
                Console.WriteLine("Se diagnosticó: {0}", diagnosis.Enfermedad.Nombre)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCross_Click(sender As Object, e As EventArgs) Handles BtnCross.Click
        TxtSearch.ResetText()
    End Sub

    Private Sub DgvAllSintomas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAllSintomas.CellClick
        Dim sintomaSelected = GetSelected()
        Try
            DgvSelectedSintomas.Rows.Add("1", "test", "desccc", "tipo")
            DgvSelectedSintomas.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetSelected()
        Dim cells = DgvAllSintomas.SelectedRows.Item(0).Cells

        Dim id As Integer = CInt(cells.Item(0).Value)
        Dim nombre As String = cells.Item(1).ToString
        Dim descripcion As String = cells.Item(2).ToString

    End Function
End Class
