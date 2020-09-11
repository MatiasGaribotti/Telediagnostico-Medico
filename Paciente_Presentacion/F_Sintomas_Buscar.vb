Imports Logica
Imports Dominio

Public Class F_Sintomas_Buscar
    Private Property pattern As Sintoma
    Public Sub New()
        InitializeComponent()
        LoadDgv()
    End Sub

    Public Sub New(patron As String, tipo As Sintoma.TiposSintomas)
        InitializeComponent()
        pattern = New Sintoma
        LoadDgv()

    End Sub

    ' "SELECT id,nombre,descripcion,tipo FROM sintomas WHERE ENABLED=1"
#Region "Tabla"
    Private Sub LoadDgv()
        Dim objSintoma As New SintomaBUS()
        Try
            Dim dt As DataTable = objSintoma.GetSintomas(pattern)
            DgvSintomas.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadDgv()
    End Sub

    Private Sub BtnCross_Click(sender As Object, e As EventArgs) Handles BtnCross.Click
        TxtBuscador.Text = ""
    End Sub
End Class