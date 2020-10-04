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
    Private Sub TimerSolicitudes_Tick(sender As Object, e As EventArgs) Handles TimerSolicitudes.Tick
        LoadSolicitudesChats()
    End Sub
    Private Sub TimerMensajes_Tick(sender As Object, e As EventArgs) Handles TimerMensajes.Tick

        Dim MedicoBUS As New MedicoBUS

        Try
            MedicoBUS.UpdateChats(ConsultasActivas)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        RefreshChats()
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

    Private Sub RefreshChats()

        ' Recorro todas las tabs para actualizar todos los chats activos
        For Each tabPage As TabPage In TabControl1.TabPages

            ' La tab con el nombre "TabSolicitudesChats" no corresponde a un chat
            If Not tabPage.Name = "TabSolicitudesChats" Then

                ' Limpio el panel en donde van los mensajes del chat.
                For Each control As Control In tabPage.Controls
                    If TypeOf control Is Panel Then
                        Dim panel As Panel = DirectCast(control, Panel)
                        panel.Controls.Clear()
                    End If
                Next


                ' Obtengo el id de la consulta
                Dim currentIdConsulta As Long

                If Long.TryParse(tabPage.Name.Split("-").ElementAt(1), currentIdConsulta) Then

                    Dim consultaActual As ConsultaMedica = GetConsultaActivaById(currentIdConsulta)

                    ' Evaluo que la consulta no sea nula.
                    If Not consultaActual Is Nothing Then

                        Dim LastPoint As Point = New Point(20, 20)

                        ' Imprimo todos los mensajes.
                        For Each mensaje As Mensaje In consultaActual.Chat.Mensajes
                            PrintMensaje(mensaje, tabPage, LastPoint)

                        Next

                        tabPage.Refresh()
                    End If

                End If
            End If
        Next
    End Sub

    Private Sub PrintMensaje(ByVal mensaje As Mensaje, ByRef containter As TabPage, ByRef lastPoint As Point)
        Dim txtMsj = mensaje.Persona.Nombre & ": " & mensaje.Texto

        Dim label As New Label With {
            .Text = txtMsj,
            .Location = lastPoint,
            .Font = New Font("Roboto", 16, FontStyle.Regular, GraphicsUnit.Pixel),
            .AutoSize = True
        }

        containter.Controls.Add(label)
        label.BringToFront()

        lastPoint.Y += label.Height + 5
    End Sub
End Class