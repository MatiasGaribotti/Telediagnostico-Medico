Public Class F_Template_Printing
    Public Property Ci As Integer
    Public Property Password As String

    Public Sub New(ci As Integer, password As String)
        InitializeComponent()
        LblUser.Text = ci.ToString
        LblPassword.Text = password
    End Sub

    Public Sub Print()
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDoc.Print()
        End If
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim bm As New Bitmap(PnlPrint.Width, PnlPrint.Height)

        PnlPrint.DrawToBitmap(bm, New Rectangle(0, 0, PnlPrint.Width, PnlPrint.Height))
        e.Graphics.DrawImage(bm, 0, 0)

        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDoc
    End Sub
End Class