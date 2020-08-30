Imports Logica
Public Class F_Enfermedades

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If ValidateFields() Then
            Dim enfermedad As Enfermedad = GetEnfermedad()
            Try
                enfermedad.Insert()
                MsgBox("Enfermedad ingresada con éxito.", MsgBoxStyle.Information)
                ClearFields()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    'Función que valida los campos
    Private Function ValidateFields() As Boolean
        Dim valid = False


        'Return valid
        Return True
    End Function

    'Función que obtiene la información contenida en los campos
    Private Function GetEnfermedad() As Enfermedad
        Dim urgencia As String = [Enum].Parse(GetType(Sintoma.TiposSintomas), CmbIUrgencia.SelectedIndex)
        Dim enfermedad As New Enfermedad(TxtIEnfermedad.Text, TxtIDescripcion.Text, urgencia)

        Return enfermedad
    End Function

    Public Sub ClearFields()
        TxtIEnfermedad.Text = Nothing
        CmbBUrgencia.SelectedIndex = 0
        TxtIDescripcion.Text = Nothing
    End Sub

    Private Sub F_Enfermedades_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbIUrgencia.DataSource = [Enum].GetValues(GetType(Enfermedad.Urgencias))
        CmbBUrgencia.DataSource = [Enum].GetValues(GetType(Enfermedad.Urgencias))
        LoadDgv()
    End Sub

    Public Sub LoadDgv()
        Dim objEnfermedad As New Enfermedad()
        Dim dt As DataTable = objEnfermedad.GetEnfermedades()
        DgvEnfermedades.DataSource = dt
        DgvEnfermedades.Refresh()
    End Sub
End Class