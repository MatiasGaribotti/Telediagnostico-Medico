Imports Logica.Sintoma
Public Class F_Sintomas_Buscar_Tipo
    Public Sub New()
        InitializeComponent()

    End Sub
    Dim filtro As String = ""
    Dim type As TiposSintomas = 0
    Private Sub BtnCross_Click(sender As Object, e As EventArgs) Handles BtnCross.Click
        TxtBuscador.Text = ""
    End Sub

    Private Sub PicTorso_Click(sender As Object, e As EventArgs) Handles PicTorso.Click
        type = TiposSintomas.Torso
    End Sub

    Private Sub PicExtremidades_Click(sender As Object, e As EventArgs) Handles PicExtremidades.Click
        type = TiposSintomas.Extremidades
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        type = TiposSintomas.Cabeza
    End Sub
End Class