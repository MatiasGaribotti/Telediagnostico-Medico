Imports Dominio
Imports Logica
Imports System.Threading

Public Class F_Main
    Private Property ConsultasActivas As New List(Of ConsultaMedica)
    Private Property TemplateChat As TabPage

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage

        InitializeComponent()

        Me.TemplateChat = TabTemplateChat
        TabControl1.TabPages.Remove(TabTemplateChat)

    End Sub

    Private Sub F_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDgv()

    End Sub

    Private Function GetTemplateChat() As TabPage
        Return TemplateChat
    End Function

    Private Sub LoadDgv()
        Dim MedicoBUS As New MedicoBUS

        Try
            Dim dt = MedicoBUS.GetChats()
            DgvChats.DataSource = dt
            DgvChats.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgvChats_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvChats.CellDoubleClick
        Dim result = MsgBox("¿Está seguro de que desea iniciar el chat con el paciente seleccionado?", MsgBoxStyle.YesNo, "Confirmación")

        If result = vbYes Then
            StartChat()
            SetUpChat(consultasActivas.Last)
            LoadDgv()
        End If
    End Sub

    Private Sub StartChat()
        Dim MedicoBUS As New MedicoBUS
        Dim consulta As ConsultaMedica = New ConsultaMedica(GetSelected())

        Try
            consulta.Chat = MedicoBUS.GetChat(consulta.Id)
            MedicoBUS.StartChat(consulta.Id, Env.CurrentUser.Ci)
            consultasActivas.Add(consulta)

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

        'Dim tab As TabPage = GetTemplateChat()
        Dim tab As New TabPage

        tab.BackColor = Color.White
        Dim chatControls As New ChatUtilities
        tab.Controls.Add(chatControls)
        chatControls.Location = New Point(20, TabSolicitudesChats.Height - 90)
        tab.Name = "TabChat-" & consulta.Chat.Id
        tab.Text = consulta.Paciente.Nombre

        tab.BringToFront()
        tab.Refresh()
        TabControl1.TabPages.Add(tab)

        ' Selecciono la última tab
        TabControl1.SelectedTab = TabControl1.TabPages.Item(TabControl1.TabPages.Count - 1)
        TabControl1.Refresh()
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        MsgBox(TabControl1.SelectedTab.Name)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadDgv()
    End Sub
End Class