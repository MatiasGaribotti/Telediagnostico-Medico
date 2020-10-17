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
        CmbIUrgencia.DataSource = [Enum].GetValues(GetType(Enfermedad.Urgencias))
        CmbBUrgencia.DataSource = [Enum].GetValues(GetType(Enfermedad.Urgencias))
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

    Public Sub LoadDgv()
        Dim objEnfermedad As New Enfermedad()
        Try
            Dim dt As DataTable = EnfermedadBUS.GetEnfermedades()
            DgvEnfermedades.DataSource = dt
            DgvEnfermedades.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
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
                MsgBox("Enfermedad ingresada con éxito.", MsgBoxStyle.Information)

            ElseIf Modo = Modos.Modificar Then
                enfermedad.Id = IdEnfermedadMod
                AdministradorBUS.ModifyEnfermedad(enfermedad)
                MsgBox("Enfermedad modificada con éxito.", MsgBoxStyle.Information, "Informacion")
                ChangeMode(Modos.Ingresar)

            End If
            ClearFields()
            LoadDgv()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    'Función que valida los campos
    Private Sub ValidateFields()

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
                MsgBox("No se puede modificar más de una enfermedad a la vez.", MsgBoxStyle.Critical, "Error")
                ChangeMode(Modos.Ingresar)
            Else
                LoadFields(enfermedades.First)
                IdEnfermedadMod = enfermedades.First.Id
                ChangeMode(Modos.Modificar)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim result = MsgBox("enfermedades_eliminar_confirmacion", MsgBoxStyle.YesNo, "confirmacion")

        If result = MsgBoxResult.Yes Then
            Dim msg As String = " enfermedades eliminadas." & vbCrLf

            Try
                Dim enfermedades = GetSelected()
                Dim count = enfermedades.Count
                For Each enfermedad In enfermedades
                    Try
                        AdministradorBUS.DeleteEnfermedad(enfermedad.Id)
                    Catch ex As Exception
                        msg += ex.Message & enfermedad.Nombre & "." & vbCrLf
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
            Throw New Exception("No se pudieron obtener las enfermedades seleccionadas.")
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
        OFDialogCSV.Filter = "Archivos CSV (*.csv)|*.csv"

        If OFDialogCSV.ShowDialog() = DialogResult.OK Then
            Try
                EnfermedadBUS.ImportCSV(OFDialogCSV.FileName)
                LoadDgv()
                MsgBox("enfermedad_import_exito", MsgBoxStyle.Information, "informacion")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "error_title")
            End Try
        End If
    End Sub
End Class