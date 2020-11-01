Imports Logica
Imports Dominio
Public Class F_Sintomas

    Private Property Modo As Modos = Modos.Ingresar
    Private Property IdSintomaMod As Short
    Private AdministradorBUS As New AdministradorBUS
    Private Enum Modos
        Ingresar
        Modificar
    End Enum
    Private SintomaBUS As New SintomaBUS
    Public Sub New()
        InitializeComponent()
        BtnCancelar.Visible = False

    End Sub


    Private Sub F_Sintomas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Translator.TranslateForm(Me)
        CmbITipo.DataSource = [Enum].GetValues(GetType(Sintoma.TiposSintomas))
        CmbBTipo.DataSource = [Enum].GetValues(GetType(Sintoma.TiposSintomas))
        LoadDgv()
    End Sub

    Private Sub ChangeMode(pMode As Modos)
        Modo = pMode
        BtnIngresar.Text = Translator.TranslateKey(Modo.ToString.ToLower)

        If pMode = Modos.Ingresar Then
            BtnCancelar.Visible = False
        Else
            BtnCancelar.Visible = True
        End If
    End Sub

    Private Sub ValidateFields()
        If String.IsNullOrWhiteSpace(TxtISintoma.Text) Then
            Throw New NoNullAllowedException("error_campo_obligatorio_nombre_sintoma")

        End If
    End Sub

    Public Sub LoadFields(sintoma As Sintoma)
        TxtISintoma.Text = sintoma.Nombre
        TxtIEnfermedad.Text = ""
        CmbITipo.SelectedIndex = sintoma.Tipo - 1
        TxtIDescripcion.Text = sintoma.Descripcion

        For Each enf In sintoma.Enfermedades
            CmbIEnfermedad.Items.Add(enf.Nombre)
        Next
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
                AdministradorBUS.AsociarEnfermedad(sintoma, New Enfermedad(nombreEnfermedad))
            Next
            Return sintoma

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GetSelected() As List(Of Sintoma)
        Dim sintomas As New List(Of Sintoma)
        Dim rows = DgvSintomas.SelectedRows


        Try
            For i As Integer = 0 To rows.Count - 1
                Dim cells = rows.Item(i).Cells

                Dim id As Short = CShort(cells.Item(0).Value)
                Dim nombre As String = cells.Item(1).Value.ToString
                Dim descripcion As String = cells.Item(2).Value.ToString
                Dim tipo As Sintoma.TiposSintomas = [Enum].Parse(GetType(Sintoma.TiposSintomas), cells.Item(3).Value)

                sintomas.Add(New Sintoma(id, nombre, descripcion, tipo))
            Next

            Return sintomas
        Catch ex As Exception
            Throw New Exception("error_sintomas_obtener")
        End Try
    End Function

    Public Sub LoadDgv()
        Try
            Dim dt As DataTable = SintomaBUS.GetSintomas()
            DgvSintomas.DataSource = dt
            DgvSintomas.Refresh()

        Catch ex As Exception
            MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))
        End Try
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
            AdministradorBUS.AsociarEnfermedad(sintoma, New Enfermedad(enfermedad.ToString))
        Next
        Return sintoma
    End Function

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Select Case Modo
            Case Modos.Ingresar
                Try
                    Dim sintoma = GetSintoma()
                    AdministradorBUS.InsertSintoma(sintoma)
                    LoadDgv()
                    MsgBox("sintoma_ingresar_exito", MsgBoxStyle.Information, Translator.TranslateKey("informacion"))
                    ClearFields()

                Catch ex As Exception
                    MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))

                End Try

            Case Modos.Modificar
                Try
                    Dim EnfermedadBUS As New EnfermedadBUS
                    Dim sintoma = GetSintoma()

                    'Cargo el id en el nuevo síntoma
                    sintoma.Id = IdSintomaMod
                    sintoma.Enfermedades = EnfermedadBUS.GetInfoEnfermedades(sintoma.Enfermedades)

                    AdministradorBUS.ModifySintoma(sintoma)
                    LoadDgv()
                    ClearFields()
                    MsgBox(Translator.TranslateKey("sintoma_modificar_exito"), MsgBoxStyle.Information, Translator.TranslateKey("informacion"))
                    ChangeMode(Modos.Ingresar)

                Catch ex As Exception
                    MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))

                End Try
        End Select
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Dim sintomaPattern = GetPatern()
        Dim found As DataTable = SintomaBUS.GetSintomas(sintomaPattern)
        LoadDgv(found)
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim count = DgvSintomas.SelectedRows.Count
        Dim confirmation As Boolean

        If count = 1 Then
            confirmation = MsgBox(Translator.TranslateKey("confirmacion_sintoma_eliminar"), MsgBoxStyle.YesNo)
        ElseIf count > 1 Then
            Dim message As String = Translator.TranslateKey("confirmacion_sintoma_eliminar_varios").Replace("[COUNT]", count)
            confirmation = MsgBox(message, MsgBoxStyle.YesNo, Translator.TranslateKey("confirmacion"))

        End If


        If confirmation Then
            Try
                Dim sintomas = GetSelected()
                Dim AdministradorBUS As New AdministradorBUS

                Dim output_message As String = Translator.TranslateKey("sintoma_eliminar_exito")
                For Each sintoma In sintomas
                    Try
                        AdministradorBUS.DeleteSintoma(sintoma.Id)

                    Catch ex As Exception
                        output_message += ex.Message & sintoma.Nombre & "." & vbCrLf
                        count -= 1
                    End Try
                Next

                output_message.Replace("[COUNT]", count.ToString)

                MsgBox(output_message, MsgBoxStyle.Information, Translator.TranslateKey("información"))
                LoadDgv()

            Catch ex As Exception
                MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))

            End Try
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ClearFields()
        ChangeMode(Modos.Modificar)
        Try
            Dim listSintomas = GetSelected()

            If listSintomas.Count <> 1 Then
                ChangeMode(Modos.Ingresar)

                Dim error_message As String = Translator.TranslateKey("error_modificar_varios").Replace("[ENTIDAD]", Translator.TranslateKey("sintoma"))

                MsgBox(error_message, MsgBoxStyle.Exclamation, Translator.TranslateKey("error"))
            Else
                Dim SintomaBUS As New SintomaBUS()
                Dim sintoma = listSintomas.First
                sintoma.Enfermedades = SintomaBUS.GetEnfermedadesAsociadas(sintoma.Id)
                IdSintomaMod = sintoma.Id
                LoadFields(sintoma)

            End If

        Catch ex As Exception
            MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))

        End Try
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        ChangeMode(Modos.Ingresar)
        ClearFields()
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

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Dim previewFileExtension As String = Translator.TranslateKey("filtro_csv")
        OFDialogCSV.Filter = previewFileExtension & "(*.csv)|*.csv"

        If OFDialogCSV.ShowDialog() = DialogResult.OK Then
            Try
                SintomaBUS.ImportCSV(OFDialogCSV.FileName)
                LoadDgv()
                MsgBox(Translator.TranslateKey("sintoma_import_exito"), MsgBoxStyle.Information, Translator.TranslateKey("informacion"))

            Catch ex As Exception
                MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))

            End Try
        End If
    End Sub
End Class