Imports Logica
Imports Dominio
Public Class F_Sintomas
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        BtnCancelar.Visible = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Property Modo As Modos = Modos.Ingresar
    Private Property SintomaMod As Sintoma
    Private SintomaBUS As New SintomaBUS

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
        Select Case Modo
            Case Modos.Ingresar
                Try
                    Dim sintoma = GetSintoma()
                    SintomaBUS.Insert(sintoma)
                    LoadDgv()
                    MsgBox("Sintoma ingresado correctamente.", MsgBoxStyle.Information)
                    ClearFields()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case Modos.Modificar
                'Cargo el id en el nuevo síntoma
                Try
                    Dim EnfermedadBUS As New EnfermedadBUS
                    Dim sintoma = GetSintoma()
                    sintoma.Id = SintomaMod.Id
                    sintoma.Enfermedades = EnfermedadBUS.GetInfoEnfermedades(sintoma.Enfermedades)

                    SintomaBUS.Modify(sintoma)
                    LoadDgv()
                    ClearFields()
                    MsgBox("Sintoma modificado correctamente.")
                    ChangeMode(Modos.Ingresar)
                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally
                End Try
        End Select
    End Sub

    Private Sub ValidateFields()
        If String.IsNullOrWhiteSpace(TxtISintoma.Text) Then
            Throw New NoNullAllowedException("El nombre del síntoma no puede ser vacío.")

        End If
    End Sub

    Private Sub ClearFields()
        TxtISintoma.ResetText()
        TxtIDescripcion.ResetText()
        CmbITipo.SelectedIndex = 0
        CmbIEnfermedad.Items.Clear()
    End Sub

    Private Function GetSintoma() As Sintoma
        Try
            ValidateFields()
            Dim tipo = [Enum].Parse(GetType(Sintoma.TiposSintomas), CmbITipo.SelectedIndex + 1)

            Dim sintoma As New Sintoma(TxtISintoma.Text, TxtIDescripcion.Text, tipo)
            Dim cant_enfermedades = CmbIEnfermedad.Items.Count

            For item As Integer = 0 To cant_enfermedades - 1
                Dim nombreEnfermedad As String = CmbIEnfermedad.Items.Item(item).ToString
                SintomaBUS.AsociarEnfermedad(sintoma, New Enfermedad(nombreEnfermedad))
            Next
            Return sintoma

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Sub F_Sintomas_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbITipo.DataSource = [Enum].GetValues(GetType(Sintoma.TiposSintomas))
        CmbBTipo.DataSource = [Enum].GetValues(GetType(Sintoma.TiposSintomas))
        LoadDgv()
    End Sub

    Private Sub BtnBAddItem_Click(sender As Object, e As EventArgs) Handles BtnBAddItem.Click
        If Not String.IsNullOrEmpty(TxtBEnfermedad.Text) And Not String.IsNullOrWhiteSpace(TxtBEnfermedad.Text) Then
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
        Dim sintomaPattern = GetPatern()
        Dim found As DataTable = SintomaBUS.GetSintomas(sintomaPattern)
        LoadDgv(found)
    End Sub

    Public Sub LoadDgv()
        Dim dt As DataTable = SintomaBUS.GetSintomas()
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

        Dim SintomaBUS As New SintomaBUS()
        Dim sintoma As New Sintoma(nombre, tipo)

        For Each enfermedad In CmbBEnfermedad.Items
            SintomaBUS.AsociarEnfermedad(sintoma, New Enfermedad(enfermedad.ToString))
        Next
        Return sintoma
    End Function

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim result = MsgBox("Está seguro de que desea eliminar el síntoma seleccionado?", MsgBoxStyle.YesNo)
        If result.Equals(vbYes) Then
            Dim idSintoma As Short = GetSintomaSelected().Id
            Dim SintomaBUS As New SintomaBUS

            Try
                SintomaBUS.Delete(idSintoma)
                MsgBox("Baja del síntoma efectuada correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            LoadDgv()
        End If

    End Sub

    Private Function GetSintomaSelected() As Sintoma
        Dim id = DgvSintomas.SelectedRows.Item(0).Cells.Item(0).Value
        Dim nombre = DgvSintomas.SelectedRows.Item(0).Cells.Item(1).Value
        Dim descripcion = DgvSintomas.SelectedRows.Item(0).Cells.Item(2).Value
        Dim tipo = DgvSintomas.SelectedRows.Item(0).Cells.Item(3).Value

        Return New Sintoma(id, nombre, descripcion, [Enum].Parse(GetType(Sintoma.TiposSintomas), tipo))
    End Function

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ClearFields()
        ChangeMode(Modos.Modificar)
        Dim sintoma = GetSintomaSelected()
        Try
            sintoma.Enfermedades = SintomaBUS.GetEnfermedadesAsociadas(sintoma.Id)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Variable que alamcena el síntoma que
        'se está modificando
        SintomaMod = sintoma

        TxtISintoma.Text = sintoma.Nombre
        TxtIEnfermedad.Text = ""
        CmbITipo.SelectedIndex = sintoma.Tipo - 1
        TxtIDescripcion.Text = sintoma.Descripcion

        For Each enf In sintoma.Enfermedades
            CmbIEnfermedad.Items.Add(enf.Nombre)
        Next
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        ChangeMode(Modos.Ingresar)
        ClearFields()
    End Sub

    Private Sub ChangeMode(pMode As Modos)
        Modo = pMode
        BtnIngresar.Text = Modo.ToString

        If pMode = Modos.Ingresar Then
            BtnCancelar.Visible = False
        Else
            BtnCancelar.Visible = True
        End If
    End Sub

End Class