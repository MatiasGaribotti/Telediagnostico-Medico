Imports Dominio
Imports Logica

Public Class F_Chat

    Private Property ConsultaMedica As ConsultaMedica
    Private Property PacienteBUS As New PacienteBUS

    Public Sub New(autoconsulta As Autoconsulta)
        InitializeComponent()
        ConsultaMedica = New ConsultaMedica(autoconsulta) With {.Chat = Nothing}

    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs)
        If TxtMsg.Text.Length > 0 And Not String.IsNullOrWhiteSpace(TxtMsg.Text) Then

            Dim PacienteBUS As New PacienteBUS
            'PacienteBUS.SendMsg()

        End If
    End Sub

    Private Sub F_Chat_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetWaitingRoom(True)
        TimerChat.Interval = 1000
        TimerChat.Start()
    End Sub

    Private Sub SetWaitingRoom(value As Boolean)
        If value Then
            BtnHistorialClinico.Enabled = False
            BtnFinalizarChat.Enabled = False
            PicWaiting.Visible = True
            LblWaiting.Visible = True
        Else
            BtnHistorialClinico.Enabled = True
            BtnFinalizarChat.Enabled = True
            PicWaiting.Visible = False
            LblWaiting.Visible = False
        End If
    End Sub

    Private Sub TimerChat_Tick(sender As Object, e As EventArgs) Handles TimerChat.Tick
        If Me.ConsultaMedica.Chat Is Nothing Then
            Try
                Dim output As Chat = GetChatIfActive(ConsultaMedica.Id)
                If Not output Is Nothing Then
                    Me.ConsultaMedica.Chat = output
                End If

            Catch ex As Exception

            End Try


        Else

            RefreshChat()
        End If
    End Sub

    Private Function GetChatIfActive(idConsulta As Long) As Chat
        Return PacienteBUS.GetChatIfActive(idConsulta)
    End Function

    Private Sub RefreshChat(Optional startIndex As Long = 0)
        Dim mensajes As List(Of Mensaje) = PacienteBUS.GetMensajes(Me.ConsultaMedica.Chat.Id, startIndex)

        PnlChat.Controls.Clear()

        Dim LastPoint As Point = New Point(20, 20)

        For Each mensaje As Mensaje In mensajes

            Dim txtMsj = mensaje.CiPersona & ": " & mensaje.Texto

            Dim label As New Label With {.Text = txtMsj, .Location = LastPoint, .Font = New Font("Roboto", 16, FontStyle.Regular, GraphicsUnit.Pixel)}
            label.AutoSize = True
            label.BackColor = Color.White
            label.BringToFront()
            PnlChat.Controls.Add(label)

            LastPoint.Y += label.Height + 5

            PnlChat.Refresh()
        Next
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Dim result = MsgBox("¿Está seguro que desea cerrar sesión?", MsgBoxStyle.YesNo, "Confirmación")

        If result = MsgBoxResult.Yes Then
            AuthenticationBUS.LogOut()
            F_Login.Show()
            Close()
        End If
    End Sub
End Class