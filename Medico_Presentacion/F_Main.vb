Imports Dominio
Imports Logica
Imports System.Threading

Public Class F_Main
    Private Property ConsultasActivas As New List(Of ConsultaMedica)

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()

    End Sub

    Private Sub F_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSolicitudesChats()

        TimerSolicitudes.Interval = 5000
        TimerSolicitudes.Start()

        TimerChatStatus.Interval = 1000
        TimerChatStatus.Start()

        TimerMensajes.Interval = 1000
        TimerMensajes.Start()
    End Sub

    Private Sub LoadSolicitudesChats()
        Dim MedicoBUS As New MedicoBUS

        Try
            Dim dt = MedicoBUS.GetChats()
            DgvChats.DataSource = dt
            DgvChats.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TimerChatStatus_Tick(sender As Object, e As EventArgs) Handles TimerChatStatus.Tick
        Dim MedicoBUS As New MedicoBUS
        Dim deleteConsultas As New List(Of ConsultaMedica)

        For Each consulta In ConsultasActivas
            Dim status = MedicoBUS.GetChatStatusByIdConsulta(consulta.Id)

            If status = Chat.ChatStatus.Ended Then
                deleteConsultas.Add(consulta)

            End If
        Next

        For Each consulta In deleteConsultas
            EndConsulta(consulta)

        Next
    End Sub

    Public Sub EndConsulta(consulta As ConsultaMedica)
        ConsultasActivas.Remove(consulta)
        Dim tab = GetTabByIdConsulta(consulta.Id)

        If tab IsNot Nothing Then
            TabControl1.TabPages.Remove(tab)
            TabControl1.Refresh()

        End If

        MsgBox("chat_ended", MsgBoxStyle.Information, "title_chat_ended")
    End Sub

    Private Sub TimerSolicitudes_Tick(sender As Object, e As EventArgs) Handles TimerSolicitudes.Tick
        LoadSolicitudesChats()
    End Sub
    Private Sub TimerMensajes_Tick(sender As Object, e As EventArgs) Handles TimerMensajes.Tick

        Dim MedicoBUS As New MedicoBUS

        Try
            For Each consulta In ConsultasActivas
                Dim nuevosMensajes = MedicoBUS.UpdateChat(consulta)
                RefreshChat(consulta, nuevosMensajes)

                For Each nuevoMensaje In nuevosMensajes
                    consulta.Chat.Mensajes.Add(nuevoMensaje)
                Next
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvChats_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvChats.CellDoubleClick
        Dim result = MsgBox("¿Está seguro de que desea iniciar el chat con el paciente seleccionado?", MsgBoxStyle.YesNo, "Confirmación")

        If result = vbYes Then
            StartChat()
            SetUpChat(ConsultasActivas.Last)
            LoadSolicitudesChats()
        End If
    End Sub

    Private Sub StartChat()
        Dim MedicoBUS As New MedicoBUS
        Dim consulta As ConsultaMedica = New ConsultaMedica(GetSelected())

        Try
            consulta.Chat = MedicoBUS.GetChat(consulta.Id)
            MedicoBUS.StartChat(consulta.Id, Env.CurrentUser.Ci)


            Dim paciente As Paciente = MedicoBUS.GetPacienteByCi(consulta.Paciente.Ci)
            Dim sintomas As List(Of Sintoma) = MedicoBUS.GetSintomasRegistrados(consulta.Id)
            Dim diagnosticos As List(Of Enfermedad) = MedicoBUS.GetDiagnosticos(consulta.Id)

            If Not paciente Is Nothing Then
                consulta.Paciente = paciente
                LoadInfoPaciente(paciente)
            End If

            If Not sintomas Is Nothing Then
                consulta.Sintomas = sintomas
                LoadDgvSintomas(sintomas)
            End If

            If Not diagnosticos Is Nothing Then
                consulta.Diagnosticos = diagnosticos
                LoadDgvDiagnosticos(diagnosticos)
            End If

            ConsultasActivas.Add(consulta)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetSelected() As Autoconsulta
        Dim cells = DgvChats.SelectedRows.Item(0).Cells

        Dim id As Long = Long.Parse(cells.Item(0).Value)
        Dim ciPaciente As Integer = Integer.Parse(cells.Item(1).Value)
        Return New Autoconsulta(id, New Paciente(ciPaciente))
    End Function

    Public Sub SetUpChat(consulta As ConsultaMedica)
        Dim tab As New TabPage With {
            .Name = "TabChat-" & consulta.Id, 'Modified consulta.Chat.Id
            .BackColor = Color.White,
            .Text = consulta.Paciente.Nombre
        }

        Dim PnlChat As New Guna.UI2.WinForms.Guna2Panel With {
            .Name = "PnlChat",
            .BackColor = Color.White,
            .Location = New Point(0, 0),
            .Width = TabControl1.Width,
            .Height = TabControl1.Height - 110,
            .AutoScroll = True
        }
        PnlChat.BringToFront()

        Dim chatControls As New ChatUtilities With {
            .Location = New Point(20, TabControl1.Height - 110)
        }

        tab.Controls.Add(PnlChat)
        tab.Controls.Add(chatControls)
        TabControl1.TabPages.Add(tab)
        TabControl1.SelectedTab = TabControl1.TabPages.Item(TabControl1.TabPages.Count - 1)

        TabControl1.Refresh()
        tab.BringToFront()
        tab.Refresh()
    End Sub

    Private Function GetConsultaActivaById(idConsulta As Long) As ConsultaMedica
        For Each consulta In ConsultasActivas
            If consulta.Id = idConsulta Then
                Return consulta
            End If
        Next
        Return Nothing
    End Function

    Private Sub RefreshChat(consulta As ConsultaMedica, mensajes As List(Of Mensaje))
        If mensajes.Count > 0 Then
            Dim tab As TabPage = GetTabByIdConsulta(consulta.Id)

            Dim panelMensajes As Panel = DirectCast(tab.Controls.Find("PnlChat", True).First, Panel)
            Dim lastPoint As Point = GetLastPoint(panelMensajes)

            For Each mensaje In mensajes
                PrintMensaje(mensaje, panelMensajes, lastPoint)
            Next

            tab.Refresh()
        End If
    End Sub

    Private Function GetLastPoint(panel As Panel) As Point
        If panel.Controls.Count > 0 Then
            Dim point = panel.Controls.Item(0).Location
            point.Y += panel.Controls.Item(0).Height + 5
            Return point
        Else
            Return New Point(20, 20)
        End If
    End Function

    Private Function GetTabByIdConsulta(idConsulta As Long) As TabPage
        For Each tab As TabPage In TabControl1.TabPages
            If tab.Name = "TabChat-" & idConsulta Then
                Return tab
            End If
        Next
        Return Nothing
    End Function

    Private Sub PrintMensaje(ByVal mensaje As Mensaje, ByRef containter As Panel, ByRef lastPoint As Point)
        Dim txtMsj = mensaje.Persona.Nombre & ": " & mensaje.Texto

        Dim label As New Label With {
            .Name = mensaje.Id,
            .Text = txtMsj,
            .Location = lastPoint,
            .Font = New Font("Roboto", 16, FontStyle.Regular, GraphicsUnit.Pixel),
            .AutoSize = True
        }

        containter.Controls.Add(label)
        label.BringToFront()

        lastPoint.Y += label.Height + 5
    End Sub

    Private Sub LoadInfoPaciente(paciente As Paciente)
        ' Información del paciente
        Dim age = GetAge(paciente.Fecha_Nacimiento)

        LblNamePaciente.Text = paciente.Nombre
        LblEdadPaciente.Text = age & " Años"
    End Sub

    Private Function GetAge(birthday As Date) As Byte
        Dim today As Date = Date.Now
        Dim age = today.Year - birthday.Year

        If birthday > today.AddYears(-age) Then
            age -= 1
        End If

        Return age
    End Function

    Private Sub LoadDgvSintomas(sintomas As List(Of Sintoma))
        ' Síntomas
        DgvSintomas.Rows.Clear()
        For Each sintoma In sintomas
            DgvSintomas.Rows.Add(
                sintoma.Id.ToString,
                sintoma.Nombre,
                sintoma.Tipo.ToString()
            )
        Next
    End Sub

    Private Sub LoadDgvDiagnosticos(diagnosticos As List(Of Enfermedad))
        ' Diagnósticos
        DgvDiagnosticos.Rows.Clear()
        For Each diagnostico As Enfermedad In diagnosticos
            DgvDiagnosticos.Rows.Add(
                diagnostico.Id.ToString,
                diagnostico.Nombre,
                diagnostico.Descripcion,
                diagnostico.Urgencia.ToString
            )

        Next
    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged
        If TabControl1.SelectedTab.Name <> "TabSolicitudesChats" And TabControl1.SelectedTab.Name.Length > 0 Then
            Dim idConsulta As Long = GetIdConsultaFromSelectedTab()
            Dim consulta As ConsultaMedica = GetConsultaActivaById(idConsulta)

            LoadInfoPaciente(consulta.Paciente)
            LoadDgvSintomas(consulta.Sintomas)
            LoadDgvDiagnosticos(consulta.Diagnosticos)

        End If
    End Sub

    Private Function GetIdConsultaFromSelectedTab() As Long
        Return CLng(TabControl1.SelectedTab.Name.Split("-").ElementAt(1))
    End Function

    Private Sub BtnFinalizarChat_Click(sender As Object, e As EventArgs) Handles BtnFinalizarChat.Click
        Dim result = MsgBox("¿Está seguro de que desea finalizar el chat con el paciente '" & TabControl1.SelectedTab.Text & "' ?", MsgBoxStyle.YesNo, "Confirmación")

        If result = MsgBoxResult.Yes Then
            Dim MedicoBUS As New MedicoBUS
            Dim idConsulta As Long = GetIdConsultaFromSelectedTab()
            Dim consulta As ConsultaMedica = GetConsultaActivaById(idConsulta)

            Try
                MedicoBUS.EndChat(consulta.Chat.Id)
                ConsultasActivas.Remove(consulta)
                TabControl1.TabPages.Remove(TabControl1.SelectedTab)
                TabControl1.Refresh()
                MsgBox("chat_ended", MsgBoxStyle.Information, "title_chat_ended")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End If
    End Sub
End Class