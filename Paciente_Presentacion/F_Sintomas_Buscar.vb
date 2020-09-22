Imports Logica
Imports Dominio

Public Class F_Sintomas_Buscar
    Public Property pattern As Sintoma

    Public Sub New()
        InitializeComponent()
        pattern = New Sintoma
        LoadDgv()
    End Sub

    Public Sub New(pNombre As String, pTipo As Sintoma.TiposSintomas)
        InitializeComponent()
        pattern = New Sintoma(pNombre, pTipo)
        LoadDgv()

    End Sub

    ' "SELECT id,nombre,descripcion,tipo FROM sintomas WHERE ENABLED=1""

    Private Sub LoadDgv()
        Dim SintomaBUS As New SintomaBUS()
        Try
            Dim dt As DataTable = SintomaBUS.GetSintomas(pattern)
            DgvSintomas.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadDgv()
    End Sub

    Private Sub BtnCross_Click(sender As Object, e As EventArgs) Handles BtnCross.Click
        TxtSearch.Text = ""
    End Sub

    Private Sub BtnCabeza_Click(sender As Object, e As EventArgs) Handles BtnCabeza.Click

    End Sub

    Private Sub BtnTorso_Click(sender As Object, e As EventArgs) Handles BtnTorso.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles BtnExtremidades.Click

    End Sub
End Class