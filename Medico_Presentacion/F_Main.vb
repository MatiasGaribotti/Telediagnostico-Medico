Imports Dominio
Imports Logica

Public Class F_Main
    Private Property consultasActivas As New List(Of ConsultaMedica)

    Private Sub F_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDgv()
    End Sub

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
            TabControl1.SelectedTab = TabPage2

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

        Dim id As Int64 = Int64.Parse(cells.Item(0).Value)
        Dim ciPaciente As Integer = Integer.Parse(cells.Item(1).Value)

        Return New Autoconsulta(id, New Paciente(ciPaciente))
    End Function

    'Public Sub SetUpChat()

    'End Sub
End Class