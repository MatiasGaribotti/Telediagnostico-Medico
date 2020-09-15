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
    Private Property IdSintomaMod As Short
    Private AdministradorBUS As New AdministradoBUS
    Private SintomaBUS As New SintomaBUS

    Private Enum Modos
        Buscar
        Ingresar
        Modificar
    End Enum

    Private Sub F_Sintomas_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbITipo.DataSource = [Enum].GetValues(GetType(Sintoma.TiposSintomas))
        CmbBTipo.DataSource = [Enum].GetValues(GetType(Sintoma.TiposSintomas))
        LoadDgv()
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

    Private Sub ValidateFields()
        If String.IsNullOrWhiteSpace(TxtISintoma.Text) Then
            Throw New NoNullAllowedException("El nombre del síntoma no puede ser vacío.")

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
            Throw New Exception("No se pudieron obtener los síntomas seleccionados.")
        End Try
    End Function

    Public Sub LoadDgv()
        Try
            Dim dt As DataTable = SintomaBUS.GetSintomas()
            DgvSintomas.DataSource = dt
            DgvSintomas.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
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
                    sintoma.Id = IdSintomaMod
                    sintoma.Enfermedades = EnfermedadBUS.GetInfoEnfermedades(sintoma.Enfermedades)

                    AdministradorBUS.ModifySintoma(sintoma)
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

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Dim sintomaPattern = GetPatern()
        Dim found As DataTable = SintomaBUS.GetSintomas(sintomaPattern)
        LoadDgv(found)
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim count = DgvSintomas.SelectedRows.Count
        Dim confirmation As Boolean

        If count = 1 Then
            confirmation = MsgBox("Está seguro de que desea eliminar el síntoma seleccionado?", MsgBoxStyle.YesNo)
        ElseIf count > 1 Then
            confirmation = MsgBox("¿Está seguro de que desea eliminar los " & count & " sintomas seleccionados?", MsgBoxStyle.YesNo)

        End If


        If confirmation Then
            Try
                Dim sintomas = GetSelected()
                Dim AdministradorBUS As New AdministradoBUS

                Dim msg As String = " sintomas eliminados." & vbCrLf
                For Each sintoma In sintomas
                    Try
                        AdministradorBUS.DeleteSintoma(sintoma.Id)

                    Catch ex As Exception
                        msg += ex.Message & sintoma.Nombre & "." & vbCrLf
                        count -= 1
                    End Try
                Next

                msg = count & msg

                If msg.Contains("No se pudo") Then
                    MsgBox(msg, MsgBoxStyle.Exclamation, "Advertencia")
                Else
                    MsgBox(msg, MsgBoxStyle.Information, "Información")
                End If
                LoadDgv()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
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
                MsgBox("No se puede modificar más de un síntoma a la vez.", MsgBoxStyle.Exclamation, "Modificar Síntoma")
            Else
                Dim sintoma = listSintomas.First
                sintoma.Enfermedades = AdministradorBUS.GetEnfermedadesAsociadas(sintoma.Id)
                IdSintomaMod = sintoma.Id
                LoadFields(sintoma)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

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
End Class