Imports Dominio
Imports Logica


Public Class ChatUtilities
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        If TxtMsg.Text.Length > 0 Then
            Dim MedicoBUS As New MedicoBUS

            Dim idConsulta As Long = Long.Parse(Me.Parent.Name.Split("-").ElementAt(1))
            Dim idChat As Long = MedicoBUS.GetChat(idConsulta).Id
            Try
                MedicoBUS.SendMsg(idChat, New Mensaje(Env.CurrentUser, TxtMsg.Text, Date.Now))

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub


End Class
