Public Class F_Sintomas

    Public Sub New()

        InitializeComponent()
        LeftPanel.BackColor = ColorTranslator.FromHtml("#E9F4F5")
        tblPane.BackColor = ColorTranslator.FromHtml("#B7E1DE")

    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        OpenMainRightPanel()
    End Sub

    'Este procedimiento abri el panel derecho principal
    Private Sub OpenMainRightPanel()

        Dim frmSintomasTipo As New F_Sintomas_Buscar_Tipo With {
           .MdiParent = Me
       }
        frmSintomasTipo.Show()
        frmSintomasTipo.SetBounds(960, 0, 955, 1075) ' 5px menos de ancho y alto para que no aparezcan las scrollbars
        frmSintomasTipo.AutoScroll = False
    End Sub

    Private Sub OpenMainRightPanel2()

        Dim frmSintomasTipo As New F_Sintomas_Buscar With {
           .MdiParent = Me
       }
        frmSintomasTipo.Show()
        frmSintomasTipo.SetBounds(960, 0, 955, 1075) ' 5px menos de ancho y alto para que no aparezcan las scrollbars
        frmSintomasTipo.AutoScroll = False
    End Sub

    Private Sub Btn_HC_Click(sender As Object, e As EventArgs) Handles Btn_HC.Click
        F_Login.Show()
        Close()
    End Sub

    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        OpenMainRightPanel2()
    End Sub
End Class
