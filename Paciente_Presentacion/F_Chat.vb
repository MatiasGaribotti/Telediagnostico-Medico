Imports Dominio
Imports Logica

Public Class F_Chat

    Private Property ConsultaMedica As ConsultaMedica
    Private Property PacienteBUS As New PacienteBUS

    Public Sub New(autoconsulta As Autoconsulta)
        InitializeComponent()
        ConsultaMedica = New ConsultaMedica(autoconsulta)

    End Sub

    Private Sub F_Chat_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimerChat.Interval = 1000
        TimerChat.Start()
    End Sub

    Private Sub TimerChatStatus_Tick(sender As Object, e As EventArgs) Handles TimerChatStatus.Tick
        Try
            ConsultaMedica.Chat.Status = PacienteBUS.GetChatStatusByIdConsulta(ConsultaMedica.Id)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TimerChat_Tick(sender As Object, e As EventArgs) Handles TimerChat.Tick
        If ConsultaMedica.Chat.Status = Chat.ChatStatus.Waiting Then

            If TimerChatStatus.Enabled = False Then
                TimerChatStatus.Start()

            End If

        ElseIf ConsultaMedica.Chat.Status = Chat.ChatStatus.Active Then
            Static iteration = 0
            ' Si es la primera iteración en la que se detectó que el
            ' estado del chat es activo, paro el timer y cargo la
            ' información de la consulta
            If iteration = 0 Then
                ConsultaMedica.Chat = PacienteBUS.GetChat(ConsultaMedica.Id)
                ConsultaMedica.Medico = PacienteBUS.GetMedico(ConsultaMedica)
                LoadInfoConsulta()
                UnSetWaitingRoom()
                iteration += 1
            Else
                RefreshChat()

            End If

        Else
            AutoconsultaBUS.instance.ResetInstance()
            TimerChatStatus.Stop()
            TimerChat.Stop()
            F_Sintomas.Show()
            Close()
            MsgBox(Translator.TranslateKey("mensaje_chat_finalizado"), MsgBoxStyle.Information, Translator.TranslateKey("titulo_chat_finalizado"))
        End If
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        SendMsg()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Dim result = MsgBox(Translator.TranslateKey("confirmacion_cerrar_sesion"), MsgBoxStyle.YesNo, Translator.TranslateKey("confirmacion"))

        If result = MsgBoxResult.Yes Then
            PacienteBUS.EndChat(ConsultaMedica.Chat.Id)

            AutoconsultaBUS.instance.ResetInstance()
            AuthenticationBUS.LogOut()

            F_Login.Show()
            Close()
        End If
    End Sub

    Private Sub BtnFinalizarChat_Click(sender As Object, e As EventArgs) Handles BtnFinalizarChat.Click
        Dim result = MsgBox(Translator.TranslateKey("confirmacion_finalizar_chat"), MsgBoxStyle.YesNo)

        If result = MsgBoxResult.Yes Then
            Dim PacienteBUS As New PacienteBUS
            PacienteBUS.EndChat(ConsultaMedica.Chat.Id)

            AutoconsultaBUS.instance.ResetInstance()
            F_Sintomas.Show()
            Close()
        End If
    End Sub


    Private Sub UnSetWaitingRoom()
        BtnSend.Enabled = True
        TxtMsg.Enabled = True
        BtnHistorialClinico.Enabled = True
        BtnFinalizarChat.Enabled = True
        PnlChat.Controls.Remove(PicWaiting)
        PnlChat.Controls.Remove(LblWaiting)
    End Sub

    Private Sub LoadInfoConsulta()
        ' Información del Médico
        LblNameMedico.Text = ConsultaMedica.Medico.Nombre
        LblEspecialidadMedico.Text = ConsultaMedica.Medico.Especialidades.First.Nombre

        ' Diagnósticos
        For Each diagnostico As Enfermedad In ConsultaMedica.Diagnosticos
            DgvDiagnosticos.Rows.Add(
                diagnostico.Id.ToString,
                diagnostico.Nombre,
                diagnostico.Descripcion,
                diagnostico.Urgencia.ToString
            )

        Next

        ' Síntomas
        For Each sintoma In ConsultaMedica.Sintomas
            DgvSintomas.Rows.Add(
                sintoma.Id.ToString,
                sintoma.Nombre,
                sintoma.Tipo.ToString()
            )
        Next
    End Sub


    Private Sub RefreshChat()
        Dim startIndex As Long = PacienteBUS.GetGreatestMsgIndex(ConsultaMedica.Chat.Mensajes)
        Dim newMensajes As List(Of Mensaje) = PacienteBUS.GetMensajes(Me.ConsultaMedica.Chat.Id, startIndex)

        If newMensajes.Count > 0 Then
            For Each newMensaje As Mensaje In newMensajes
                ConsultaMedica.Chat.Mensajes.Add(newMensaje)
            Next

            Dim LastPoint As Point = GetLastPoint(PnlChat)

            For Each mensaje As Mensaje In newMensajes
                PrintMensaje(mensaje, LastPoint)

            Next

        End If
    End Sub

    Private Function GetLastPoint(panel As Panel)
        If panel.Controls.Count > 0 Then
            Dim point = panel.Controls.Item(panel.Controls.Count - 1).Location
            point.Y += panel.Controls.Item(0).Height + 5
            Return point

        Else
            Return New Point(20, 20)
        End If
    End Function

    Private Sub PrintMensaje(mensaje As Mensaje, ByRef lastpoint As Point)
        Dim txtMsj = mensaje.Persona.Nombre & ": " & mensaje.Texto

        Dim label As New Label With {.Text = txtMsj, .Location = lastpoint, .Font = New Font("Roboto", 16, FontStyle.Regular, GraphicsUnit.Pixel)}
        label.AutoSize = True
        label.BackColor = Color.White
        label.BringToFront()
        PnlChat.Controls.Add(label)

        lastpoint.Y += label.Height + 5

        PnlChat.Refresh()
    End Sub

    Private Sub SendMsg()
        If TxtMsg.Text.Length > 0 And Not String.IsNullOrWhiteSpace(TxtMsg.Text) Then

            Dim PacienteBUS As New PacienteBUS
            PacienteBUS.SendMsg(ConsultaMedica.Chat.Id, New Mensaje(Env.CurrentUser, TxtMsg.Text, Date.Now))

        End If
    End Sub

    Private Sub TxtMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtMsg.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendMsg()
            TxtMsg.ResetText()
        End If
    End Sub
End Class