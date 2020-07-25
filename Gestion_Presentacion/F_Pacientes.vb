Imports System.Threading
Imports System.Globalization

Public Class F_Pacientes
    Private _Language As CultureInfo

    Public Function GetLanguage() As CultureInfo
        Return _Language
    End Function

    Public Sub SetLanguage(AutoPropertyValue As CultureInfo)
        _Language = AutoPropertyValue
    End Sub

    Public Sub New()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbl_tratamientos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbl_telefono_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnl_filtrar_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox27_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnl_contenedor_Paint(sender As Object, e As PaintEventArgs) Handles pnl_contenedor.Paint

    End Sub

    Private Sub Guna2TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TxtBApellidos2.TextChanged

    End Sub
End Class