Imports Dominio
Imports Logica
Imports System.Threading
Public Class F_Enfermedades
    Private EnfermedadBUS As New EnfermedadBUS
    Private AdministradorBUS As New AdministradorBUS
    Private Modo As Modos = Modos.Ingresar
    Private IdEnfermedadMod As Short

    Private Enum Modos
        Ingresar
        Modificar
    End Enum
    Public Sub New()

        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        BtnCancelar.Visible = False
    End Sub

    Private Sub F_Enfermedades_Load(sender As Object, e As EventArgs) Handles Me.Load
        Translator.TranslateForm(Me)
        Refresh()
        CmbIUrgencia.DataSource = [Enum].GetValues(GetType(Enfermedad.Urgencias))
        CmbBUrgencia.DataSource = [Enum].GetValues(GetType(Enfermedad.Urgencias))
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

    Public Sub LoadDgv()
        Dim objEnfermedad As New Enfermedad()
        Try
            Dim dt As DataTable = EnfermedadBUS.GetEnfermedades()
            DgvEnfermedades.DataSource = dt
            DgvEnfermedades.Refresh()

        Catch ex As Exception
            MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))
        End Try
    End Sub
    Public Sub LoadDgv(dt As DataTable)
        DgvEnfermedades.DataSource = dt
        DgvEnfermedades.Refresh()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            ValidateFields()
            Dim enfermedad As Enfermedad = GetEnfermedad()
            If Modo = Modos.Ingresar Then
                AdministradorBUS.InsertEnfermedad(enfermedad)
                MsgBox("enfermedad_ingresada_exito", MsgBoxStyle.Information, Translator.TranslateKey("informacion"))

            ElseIf Modo = Modos.Modificar Then
                enfermedad.Id = IdEnfermedadMod
                AdministradorBUS.ModifyEnfermedad(enfermedad)
                MsgBox("enfermedad_modificada_exito", MsgBoxStyle.Information, Translator.TranslateKey("informacion"))
                ChangeMode(Modos.Ingresar)

            End If
            ClearFields()
            LoadDgv()

        Catch ex As Exception
            MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))

        End Try
    End Sub

    'Función que valida los campos
    Private Sub ValidateFields()
        EnfermedadBUS.ValidateFields(TxtIEnfermedad.Text,
                                     CmbITipoEnfermedad.SelectedItem.ToString,
                                     CmbIUrgencia.SelectedItem.ToString,
                                     TxtIDescripcion.Text)
    End Sub

    'Función que obtiene la información contenida en los campos
    Private Function GetEnfermedad() As Enfermedad
        Dim enfermedad As Enfermedad

        Dim urgencia As Enfermedad.Urgencias = [Enum].Parse(GetType(Enfermedad.Urgencias), CmbIUrgencia.SelectedItem.ToString)
        enfermedad = New Enfermedad(TxtIEnfermedad.Text, TxtIDescripcion.Text, urgencia, ChkICronica.Checked)
        Return enfermedad

    End Function

    Private Function GetPattern() As Enfermedad
        Dim urgencia As Enfermedad.Urgencias = [Enum].Parse(GetType(Enfermedad.Urgencias), CmbBUrgencia.SelectedItem.ToString)
        Return New Enfermedad(TxtBEnfermedad.Text, urgencia, ChkBCronica.Checked)

    End Function

    Private Sub ClearFields()
        TxtIEnfermedad.ResetText()
        CmbBUrgencia.SelectedIndex = 1
        TxtIDescripcion.ResetText()
        ChkICronica.Checked = False
    End Sub

    Private Sub LoadFields(pEnfermedad As Enfermedad)
        TxtIEnfermedad.Text = pEnfermedad.Nombre
        CmbIUrgencia.SelectedIndex = pEnfermedad.Urgencia - 1
        TxtIDescripcion.Text = pEnfermedad.Descripcion
        ChkICronica.Checked = pEnfermedad.Cronica
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ClearFields()
        ChangeMode(Modos.Modificar)
        Try
            Dim enfermedades = GetSelected()
            If enfermedades.Count <> 1 Then
                Dim error_message As String = Translator.TranslateKey("error_modificar_varios").Replace("[ENTIDAD]", Translator.TranslateKey("enfermedades"))

                MsgBox(error_message, MsgBoxStyle.Critical, Translator.TranslateKey("error"))
                ChangeMode(Modos.Ingresar)
            Else
                LoadFields(enfermedades.First)
                IdEnfermedadMod = enfermedades.First.Id
                ChangeMode(Modos.Modificar)
            End If

        Catch ex As Exception
            MsgBox(Translator.TranslateKey(ex.Message))
        End Try

    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim result = MsgBox("confirmacion_enfermedades_eliminar", MsgBoxStyle.YesNo, Translator.TranslateKey("confirmacion"))

        If result = MsgBoxResult.Yes Then
            Dim msg As String = "[COUNT] enfermedades eliminadas." & vbCrLf

            Try
                Dim enfermedades = GetSelected()
                Dim count = enfermedades.Count
                For Each enfermedad In enfermedades
                    Try
                        AdministradorBUS.DeleteEnfermedad(enfermedad.Id)
                    Catch ex As Exception
                        msg += Translator.TranslateKey(ex.Message).Replace("[NOMBRE_ENFERMEDAD]", enfermedad.Nombre) & vbCrLf
                        count -= 1
                    End Try
                Next
                msg.Replace("[COUNT]", count.ToString)

                MsgBox(msg, MsgBoxStyle.Information, Translator.TranslateKey("informacion"))
                LoadDgv()

            Catch ex As Exception
                MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))
            End Try

        End If
    End Sub

    ''' <summary>
    ''' Obtiene las enfermedades de las filas seleccionadas.
    ''' </summary>
    ''' <returns>Retorna la lista de enfermedades contenidas en las filas seleccionadas.</returns>
    Private Function GetSelected() As List(Of Enfermedad)
        Dim enfermedades As New List(Of Enfermedad)
        Dim rows = DgvEnfermedades.SelectedRows
        Try
            For i As Integer = 0 To rows.Count - 1
                Dim cells = rows.Item(i).Cells

                Dim id As Short = CShort(cells.Item(0).Value)
                Dim nombre As String = cells.Item(1).Value.ToString
                Dim cronica As Boolean = CBool(cells.Item(2).Value)
                Dim urgencia As Enfermedad.Urgencias = [Enum].Parse(GetType(Enfermedad.Urgencias), cells.Item(3).Value.ToString)
                Dim descripcion As String = cells.Item(4).Value.ToString

                enfermedades.Add(New Enfermedad(id, nombre, descripcion, urgencia, cronica))
            Next

            Return enfermedades

        Catch ex As Exception
            Throw New Exception("error_enfermedad_obtener")
        End Try

    End Function

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        ChangeMode(Modos.Ingresar)
        ClearFields()
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Dim pattern As Enfermedad = GetPattern()
        Dim dt As DataTable
        Try
            dt = EnfermedadBUS.GetEnfermedades(pattern)
            LoadDgv(dt)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Dim previewFileExtension As String = Translator.TranslateKey("filtro_csv")
        OFDialogCSV.Filter = previewFileExtension & "(*.csv)|*.csv"

        If OFDialogCSV.ShowDialog() = DialogResult.OK Then
            Try
                EnfermedadBUS.ImportCSV(OFDialogCSV.FileName)
                LoadDgv()
                MsgBox("enfermedad_import_exito", MsgBoxStyle.Information, Translator.TranslateKey("informacion"))
            Catch ex As Exception
                MsgBox(Translator.TranslateKey(ex.Message), MsgBoxStyle.Critical, Translator.TranslateKey("error"))
            End Try
        End If
    End Sub
End Class