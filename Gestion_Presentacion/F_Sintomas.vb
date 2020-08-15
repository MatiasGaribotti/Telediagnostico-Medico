Imports Logica
Public Class F_Sintomas
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim sintoma = GetSintoma()
        If sintoma.Insert() Then
            MsgBox("Sintoma ingresado correctamente.", MsgBoxStyle.Information)
        Else
            MsgBox("No se ingresó el síntoma.", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Function ValidateFields() As Boolean

        Return True
    End Function
    Private Function GetSintoma() As Sintoma
        If ValidateFields() Then
            Dim tipo = [Enum].Parse(GetType(Sintoma.TiposSintomas), CmbITipo.SelectedIndex + 1)

            Dim sintoma As New Sintoma(TxtISintoma.Text, TxtIDescripcion.Text, tipo)
            Dim cant_enfermedades = CmbIEnfermedad.Items.Count

            For item As Integer = 0 To cant_enfermedades - 1
                Dim nombreEnfermedad As String = CmbIEnfermedad.Items.Item(item).ToString
                sintoma.AsociarEnfermedad(New Enfermedad(nombreEnfermedad))
            Next

            Return sintoma
        Else
            Return Nothing
        End If
    End Function

    Private Sub PnlSide_Paint(sender As Object, e As PaintEventArgs) Handles PnlSide.Paint

    End Sub

    Private Sub F_Sintomas_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbITipo.DataSource = [Enum].GetValues(GetType(Sintoma.TiposSintomas))
        CmbBTipo.DataSource = [Enum].GetValues(GetType(Sintoma.TiposSintomas))
    End Sub

    Private Sub BtnBAddItem_Click(sender As Object, e As EventArgs) Handles BtnBAddItem.Click
        CmbBEnfermedad.Items.Add(TxtBEnfermedad.Text)
        TxtBEnfermedad.Text = ""
    End Sub

    Private Sub BtnIAddItem_Click(sender As Object, e As EventArgs) Handles BtnIAddItem.Click
        CmbIEnfermedad.Items.Add(TxtIEnfermedad.Text)
        TxtIEnfermedad.Text = ""
    End Sub

    Private Sub BtnBDelItem_Click(sender As Object, e As EventArgs) Handles BtnBDelItem.Click
        CmbBEnfermedad.Items.Remove(CmbBEnfermedad.SelectedItem)
    End Sub

    Private Sub BtnIDelItem_Click(sender As Object, e As EventArgs) Handles BtnIDelItem.Click
        CmbIEnfermedad.Items.Remove(CmbIEnfermedad.SelectedItem)
    End Sub
End Class