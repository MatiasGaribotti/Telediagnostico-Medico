Imports Logica
Public Class F_Sintomas
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Property Modo As Modos = Modos.Ingresar

    Private Enum Modos
        Buscar
        Ingresar
        Modificar
    End Enum

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If ValidateFields() Then
            Dim sintoma = GetSintoma()

            Select Case Modo
                Case Modos.Ingresar
                    If sintoma.Insert() Then
                        MsgBox("Sintoma ingresado correctamente.", MsgBoxStyle.Information)
                    Else
                        MsgBox("No se ingresó el síntoma.", MsgBoxStyle.Critical)
                    End If
                Case Modos.Modificar
                    sintoma.Modify()
            End Select
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
        LoadDgv()
    End Sub

    Private Sub BtnBAddItem_Click(sender As Object, e As EventArgs) Handles BtnBAddItem.Click
        If Not IsNothing(CmbBEnfermedad.Text) And Not CmbBEnfermedad.Text = "" Then
            CmbBEnfermedad.Items.Add(TxtBEnfermedad.Text)
            TxtBEnfermedad.Text = ""
        End If

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

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        If ValidateFields() Then
            Dim sintoma = GetPatern()
            Dim found As DataTable = sintoma.Filter()
            LoadDgv(found)
        End If
    End Sub

    Public Sub LoadDgv()
        Dim logica As New Sintoma()
        Dim dt As DataTable = logica.GetDgvData()
        DgvSintomas.DataSource = dt
        DgvSintomas.Refresh()
    End Sub

    Public Sub LoadDgv(dt As DataTable)
        DgvSintomas.DataSource = dt
        DgvSintomas.Refresh()
    End Sub

    Private Function GetPatern() As Sintoma
        Dim nombre = TxtBSintoma.Text
        Dim tipo As String = [Enum].Parse(GetType(Sintoma.TiposSintomas), CmbBTipo.SelectedIndex + 1)

        Dim sintoma As New Sintoma(nombre, tipo)

        For item As Integer = 0 To CmbBEnfermedad.Items.Count - 1
            Dim nombreEnfermedad As String = CmbIEnfermedad.Items.Item(item).ToString
            sintoma.AsociarEnfermedad(New Enfermedad(nombreEnfermedad))
        Next

        Return sintoma
    End Function

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim result = MsgBox("Está seguro de que desea eliminar el síntoma seleccionado?", MsgBoxStyle.YesNo)
        If result.Equals(vbYes) Then
            Dim idSintoma As Short = GetSintomaSelected().Id
            Dim sintoma As New Sintoma(idSintoma)
            If sintoma.Delete() Then
                MsgBox("Baja del síntoma efectuada correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("No se pudo eliminar el síntoma: ")
            End If
        End If

    End Sub

    Private Function GetSintomaSelected() As Sintoma
        Dim sintoma As Sintoma

        Dim id = DgvSintomas.SelectedRows.Item(0).Cells.Item(0).Value
        Dim nombre = DgvSintomas.SelectedRows.Item(0).Cells.Item(1).Value
        Dim descripcion = DgvSintomas.SelectedRows.Item(0).Cells.Item(2).Value
        Dim tipo = DgvSintomas.SelectedRows.Item(0).Cells.Item(3).Value

        Return New Sintoma(id, nombre, descripcion, tipo)
    End Function

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Modo = Modos.Modificar
        Dim sintoma = GetSintoma()
        sintoma.Find()


    End Sub
End Class