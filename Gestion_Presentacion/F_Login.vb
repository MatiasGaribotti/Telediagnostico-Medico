'Requerido para soportar varios idiomas
Imports System.Threading
Imports System.Globalization

Public Class F_Login
    Private _Language As CultureInfo

    Public Sub New()
        InitializeComponent()
        'Color del fondo del formulario
        Me.BackColor = ColorTranslator.FromHtml("#E9F4F5")
        'Testing
        TxtCi.Text = Thread.CurrentThread.CurrentUICulture.ToString
    End Sub

    Public Sub New(lang As CultureInfo)
        Thread.CurrentThread.CurrentUICulture = lang
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        TxtCi.Text = Thread.CurrentThread.CurrentUICulture.ToString
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        'Abre el formulario de ABM y cierra este

        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnChangeLang_Click(sender As Object, e As EventArgs) Handles BtnChangeLang.Click
        Dim v As New F_Login(New CultureInfo("en-US"))
        v.Show()
        Me.Close()
        MsgBox("Se cambió el idioma a " & Thread.CurrentThread.CurrentUICulture.ToString)
    End Sub
End Class
