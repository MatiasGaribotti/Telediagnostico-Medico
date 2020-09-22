Imports Dominio
Imports Logica

Public Class F_Sintomas_Buscar_Tipo
    Private Property Pattern As Sintoma

    Public Sub New()
        InitializeComponent()
        Pattern = New Sintoma
    End Sub

    Private Sub PicCabeza_Click(sender As Object, e As EventArgs) Handles PicCabeza.Click
        Pattern.Tipo = Sintoma.TiposSintomas.Cabeza
    End Sub

    Private Sub PicTorso_Click(sender As Object, e As EventArgs) Handles PicTorso.Click
        Pattern.Tipo = Sintoma.TiposSintomas.Torso
    End Sub

    Private Sub PicExtremidades_Click(sender As Object, e As EventArgs) Handles PicExtremidades.Click
        Pattern.Tipo = Sintoma.TiposSintomas.Extremidades
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

    End Sub

    Private Sub BtnCross_Click(sender As Object, e As EventArgs) Handles BtnCross.Click
        TxtSearch.Text = ""
    End Sub
End Class