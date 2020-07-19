Imports System.Drawing
Public Class frmLogin

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.BackColor = ColorTranslator.FromHtml("#E9F4F5")

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        frm_mainSintomas.Show()

        Me.Hide()

    End Sub
End Class
