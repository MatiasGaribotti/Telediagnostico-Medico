Public Class frm_mainSintomas

    Public Sub New()

        InitializeComponent()
        LeftPanel.BackColor = ColorTranslator.FromHtml("#E9F4F5")
        tblpane.BackColor = ColorTranslator.FromHtml("#B7E1DE")

    End Sub

    Private Sub Btn_HC_Click(sender As Object, e As EventArgs) Handles Btn_HC.Click, Btn_Cancelar.Click, Btn_Aceptar.Click
        OpenMainRightPanel()
    End Sub

    'Este procedimiento abri el panel derecho principal
    Private Sub OpenMainRightPanel()

        Dim frmSintomasTipo As New Frm_Sintomas_Buscar_Tipo With {
           .MdiParent = Me
       }
        frmSintomasTipo.Show()
        frmSintomasTipo.SetBounds(960, 0, 955, 1075) ' 5px menos de ancho y alto para que no aparezcan las scrollbars
        frmSintomasTipo.AutoScroll = False
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
