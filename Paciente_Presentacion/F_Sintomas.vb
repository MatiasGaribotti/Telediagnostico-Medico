Imports Dominio
Imports Guna.UI2.WinForms
Imports Logica
Imports System.Threading
Public Class F_Sintomas
    Private table As New DataTable
    Private pattern As Sintoma
    Public Sub New()
        Thread.CurrentThread.CurrentCulture = Env.CurrentLangugage
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()

    End Sub

    Private Sub F_Sintomas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Translator.TranslateForm(Me)
        Refresh()
        pattern = New Sintoma
        ConfigureSelectedColumnVisibility()
        SwitchSelection()
        LoadDgv()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim result = MsgBox(Translator.TranslateKey("confirmacion_cerrar_sesion"), MsgBoxStyle.YesNo, Translator.TranslateKey("confirmacion"))

        If result = vbYes Then
            AuthenticationBUS.LogOut()
            F_Login.Show()
            Close()
        End If
    End Sub

    Private Sub LoadDgv()
        Dim SintomaBUS As New SintomaBUS()
        Try
            Dim dt As DataTable = SintomaBUS.GetSintomas()
            DgvAllSintomas.DataSource = dt
            ConfigureColumnVisibility()
            DgvAllSintomas.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadDgv(pattern As Sintoma)
        Dim SintomaBUS As New SintomaBUS()
        Try
            Dim dt As DataTable = SintomaBUS.GetSintomas(pattern)
            DgvAllSintomas.DataSource = dt
            ConfigureColumnVisibility()
            DgvAllSintomas.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigureColumnVisibility()
        For i As Integer = 0 To DgvAllSintomas.Columns.Count - 1
            If Not i = 1 Then
                DgvAllSintomas.Columns.Item(i).Visible = False
            Else
                DgvAllSintomas.Columns.Item(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If
        Next
    End Sub

    Private Sub ConfigureSelectedColumnVisibility()
        For i As Integer = 0 To DgvSelectedSintomas.Columns.Count - 1
            If Not i = 1 Then
                DgvSelectedSintomas.Columns.Item(i).Visible = False
            End If
        Next

        DgvSelectedSintomas.Refresh()
    End Sub

    Private Sub Btn_HC_Click(sender As Object, e As EventArgs) Handles BtnHCE.Click
        F_Login.Show()
        Close()
    End Sub

    Private Sub BtnCross_Click(sender As Object, e As EventArgs) Handles BtnCross.Click
        TxtSearch.ResetText()
    End Sub

    Private Sub DgvAllSintomas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAllSintomas.CellClick
        Dim sintomaSelected = GetSelectedToAdd()
        Try
            If Not AutoconsultaBUS.instance.SintomaAlreadySelected(sintomaSelected.Id) Then
                AutoconsultaBUS.instance.AddSintoma(sintomaSelected)
                DgvSelectedSintomas.Rows.Add(sintomaSelected.Id.ToString, sintomaSelected.Nombre.ToString, sintomaSelected.Descripcion.ToString, sintomaSelected.Tipo.ToString)
                DgvSelectedSintomas.Refresh()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgvSelectedSintomas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSelectedSintomas.CellClick
        Dim sintoma = GetSelectedToRemove()
        Try
            AutoconsultaBUS.instance.RemSintoma(sintoma)
            DgvSelectedSintomas.Rows.Remove(DgvSelectedSintomas.SelectedRows.Item(0))
            DgvSelectedSintomas.Refresh()

        Catch ex As Exception

        End Try
    End Sub

    Private Function GetSelectedToAdd() As Sintoma
        Dim cells = DgvAllSintomas.SelectedRows.Item(0).Cells

        Dim id As Integer = CInt(cells.Item(0).Value)
        Dim nombre As String = cells.Item(1).Value.ToString
        Dim descripcion As String = cells.Item(2).Value.ToString
        Dim tipo As Sintoma.TiposSintomas = [Enum].Parse(GetType(Sintoma.TiposSintomas), cells.Item(3).Value)
        Return New Sintoma(id, nombre, descripcion, tipo)
    End Function

    Private Function GetSelectedToRemove() As Sintoma
        Dim cells = DgvSelectedSintomas.SelectedRows.Item(0).Cells

        Dim id As Integer = CInt(cells.Item(0).Value)
        Dim nombre As String = cells.Item(1).Value.ToString
        Dim descripcion As String = cells.Item(2).Value.ToString
        Dim tipo As Sintoma.TiposSintomas = [Enum].Parse(GetType(Sintoma.TiposSintomas), cells.Item(3).Value)
        Return New Sintoma(id, nombre, descripcion, tipo)
    End Function

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim diagnosticos As List(Of Enfermedad) = AutoconsultaBUS.instance.GetDiagnosis()

            If diagnosticos.Count > 0 Then
                AutoconsultaBUS.instance.consulta.Diagnosticos = diagnosticos
                Dim outmsg As String = Translator.TranslateKey("diagnostico_primario_mensaje_salida_1") & vbCrLf & vbCrLf

                For Each diagnostico In diagnosticos
                    outmsg += "     -" & diagnostico.Nombre & vbCrLf

                Next

                outmsg += vbCrLf & Translator.TranslateKey("diagnostico_primario_mensaje_salida_2") & vbCrLf & vbCrLf &
                          Translator.TranslateKey("confirmacion_iniciar_chat")


                Dim result = MsgBox(outmsg, MsgBoxStyle.YesNo, Translator.TranslateKey("diagnostico"))

                If result = MsgBoxResult.Yes Then
                    AutoconsultaBUS.instance.Insert(True)

                    'Iniciamos el chat
                    Dim chat As New F_Chat(AutoconsultaBUS.instance.consulta)
                    chat.Show()
                    Me.Close()
                Else
                    AutoconsultaBUS.instance.Insert()
                    Reset()
                    MsgBox(Translator.TranslateKey("mensaje_despedida"), MsgBoxStyle.Information, Translator.TranslateKey("consulta_finalizada"))
                End If


            Else
                MsgBox(Translator.TranslateKey("diagnostico_ambiguo"),
                        MsgBoxStyle.Exclamation, Translator.TranslateKey("diagnostico"))

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnFullBody_Click(sender As Object, e As EventArgs) Handles BtnFullBody.Click
        SwitchSelection()
        LoadDgv()
    End Sub

    Private Sub BtnCabeza_Click(sender As Object, e As EventArgs) Handles BtnCabeza.Click
        pattern.Tipo = Sintoma.TiposSintomas.Cabeza
        SwitchSelection(pattern.Tipo)
        LoadDgv(pattern)
    End Sub

    Private Sub BtnTorso_Click(sender As Object, e As EventArgs) Handles BtnTorso.Click
        pattern.Tipo = Sintoma.TiposSintomas.Torso
        SwitchSelection(pattern.Tipo)
        LoadDgv(pattern)
    End Sub

    Private Sub BtnExtremidades_Click(sender As Object, e As EventArgs) Handles BtnExtremidades.Click
        pattern.Tipo = Sintoma.TiposSintomas.Extremidades
        SwitchSelection(pattern.Tipo)
        LoadDgv(pattern)
    End Sub

    Public Sub SwitchSelection(type As Sintoma.TiposSintomas)
        Select Case type
            Case Sintoma.TiposSintomas.Cabeza
                LblTodo.Visible = False
                LblCabeza.Visible = True
                LblTorso.Visible = False
                LblExtremidades.Visible = False
            Case Sintoma.TiposSintomas.Torso
                LblTodo.Visible = False
                LblCabeza.Visible = False
                LblTorso.Visible = True
                LblExtremidades.Visible = False
            Case Sintoma.TiposSintomas.Extremidades
                LblTodo.Visible = False
                LblCabeza.Visible = False
                LblTorso.Visible = False
                LblExtremidades.Visible = True

            Case Else
                LblTodo.Visible = True
                LblCabeza.Visible = False
                LblTorso.Visible = False
                LblExtremidades.Visible = False
        End Select
    End Sub

    Public Sub SwitchSelection()
        LblTodo.Visible = True
        LblCabeza.Visible = False
        LblTorso.Visible = False
        LblExtremidades.Visible = False
    End Sub

    Public Sub Reset()
        AutoconsultaBUS.instance.ResetInstance()
        DgvSelectedSintomas.Rows.Clear()
    End Sub
End Class
