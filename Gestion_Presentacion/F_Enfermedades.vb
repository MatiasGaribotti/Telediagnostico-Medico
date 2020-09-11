Imports Dominio
Imports Logica
Public Class F_Enfermedades
    Private EnfermedadBUS As New EnfermedadBUS

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        Dim enfermedad As Enfermedad = GetEnfermedad()
        Try
            ValidateFields()
            EnfermedadBUS.Insert(enfermedad)
            MsgBox("Enfermedad ingresada con éxito.", MsgBoxStyle.Information)
            ClearFields()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    'Función que valida los campos
    Private Sub ValidateFields()
    End Sub

    'Función que obtiene la información contenida en los campos
    Private Function GetEnfermedad() As Enfermedad
        Dim urgencia As String = [Enum].Parse(GetType(Sintoma.TiposSintomas), CmbIUrgencia.SelectedIndex)
        Dim enfermedad As New Enfermedad(TxtIEnfermedad.Text, TxtIDescripcion.Text, urgencia)

        Return enfermedad
    End Function

    Public Sub ClearFields()
        TxtIEnfermedad.ResetText()
        CmbBUrgencia.SelectedIndex = 0
        TxtIDescripcion.ResetText()
    End Sub

    Private Sub F_Enfermedades_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbIUrgencia.DataSource = [Enum].GetValues(GetType(Enfermedad.Urgencias))
        CmbBUrgencia.DataSource = [Enum].GetValues(GetType(Enfermedad.Urgencias))
        LoadDgv()
    End Sub

    Public Sub LoadDgv()
        Dim objEnfermedad As New Enfermedad()
        Try
            Dim dt As DataTable = EnfermedadBUS.GetEnfermedades()
            DgvEnfermedades.DataSource = dt
            DgvEnfermedades.Refresh()

        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class