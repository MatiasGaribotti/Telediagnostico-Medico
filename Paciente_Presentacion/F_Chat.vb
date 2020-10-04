Imports Dominio
Imports Logica

Public Class F_Chat

    Private Property ConsultaMedica As ConsultaMedica
    Private Property PacienteBUS As New PacienteBUS

    Public Sub New(autoconsulta As Autoconsulta)
        InitializeComponent()
        ConsultaMedica = New ConsultaMedica(autoconsulta) With {.Chat = Nothing}

    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        If TxtMsg.Text.Length > 0 And Not String.IsNullOrWhiteSpace(TxtMsg.Text) Then

            Dim PacienteBUS As New PacienteBUS
            PacienteBUS.SendMsg(ConsultaMedica.Chat.Id, New Mensaje(Env.CurrentUser, TxtMsg.Text, Date.Now))

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
            Dim output As Chat = GetChatIfBeingDealt(ConsultaMedica.Id)

            If Not output Is Nothing Then
                Me.ConsultaMedica.Chat = output
                ConsultaMedica.Medico = PacienteBUS.GetMedico(ConsultaMedica)
                If Not ConsultaMedica.Medico Is Nothing Then
                    LoadInfoConsulta()

                End If

            End If

        Else
            SetWaitingRoom(False)
            RefreshChat()
        End If
    End Sub

    Private Function GetChatIfBeingDealt(idConsulta As Long) As Chat
        Return PacienteBUS.GetChatIfBeingDealt(idConsulta)
    End Function

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

            PnlChat.Controls.Clear()

            Dim LastPoint As Point = New Point(20, 20)

            For Each mensaje As Mensaje In ConsultaMedica.Chat.Mensajes
                PrintMensaje(mensaje, LastPoint)

            Next

        End If
    End Sub

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

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Dim result = MsgBox("¿Está seguro que desea cerrar sesión?", MsgBoxStyle.YesNo, "Confirmación")

        If result = MsgBoxResult.Yes Then
            AutoconsultaBUS.instance.ResetInstance()
            AuthenticationBUS.LogOut()

            F_Login.Show()
            Close()
        End If
    End Sub
End Class