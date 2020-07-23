'Requerido para soportar varios idiomas
Imports System.Threading
Imports System.Globalization

Public Class F_Login


    Public Sub New()
        'Establezco el idioma a inglés (Estados Unidos)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        InitializeComponent()
        'Color del fondo del formulario
        Me.BackColor = ColorTranslator.FromHtml("#E9F4F5")
        'Testing
        Txt_Ci.Text = Thread.CurrentThread.CurrentUICulture.ToString
    End Sub

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        'Abre el formulario de ABM y cierra este
        F_ABM.Show()
        Me.Close()
    End Sub
End Class
