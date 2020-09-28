Imports Dominio
Imports Logica

Public Class F_Main
    Private Sub F_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDgv()
    End Sub

    Private Sub LoadDgv()
        Dim MedicoBUS As New MedicoBUS

        Try
            Dim dt = MedicoBUS.GetChats()
            DgvChats.DataSource = dt
            DgvChats.Refresh()
        Catch ex As Exception

        End Try
    End Sub
End Class