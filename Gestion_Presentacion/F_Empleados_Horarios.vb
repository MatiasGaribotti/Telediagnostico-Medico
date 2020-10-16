Imports System.Threading
Imports System.Globalization
Imports Logica
Imports Dominio
Public Class F_Empleados_Horarios

    Private Sucursales As New List(Of Sucursal)
    Private tempHorario As Horario
    Private Modo As Modos

    Public Enum Modos
        Ingresar
        Modificar
    End Enum

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()

    End Sub

    Private Sub F_Empleados_Horarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetSucursales()
        LoadCmbSucursales()
        LoadDgv()
    End Sub

    Private Sub Btn_volver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        If Env.CurrentUser.IsRecepcionista Then
            F_ABM.Show()

        Else
            F_Empleados.Show()
        End If

        Close()
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Dim pattern As Horario = GetSearchPattern()
        Dim dt As DataTable

        Try
            Dim RRHHBUS As New RRHHBUS
            dt = RRHHBUS.GetHorariosEmpleados(pattern)
            LoadDgv(dt)
        Catch ex As Exception
            MsgBox("error_horario_buscar",MsgBoxStyle.Critical,"error")
        End Try

    End Sub

    Private Sub Btn_ingresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim horario As Horario = GetHorario()

        Try
            Dim RRHHBUS As New RRHHBUS
            ClearFields()

            Select Case Modo
                Case Modos.Ingresar
                    RRHHBUS.InsertHorarioEmpleado(horario)
                    MsgBox("horario_ingresar_exito", MsgBoxStyle.Information, "str_informacion")

                Case Modos.Modificar
                    RRHHBUS.ModifyHorarioEmpleado(horario, tempHorario)
                    MsgBox("horario_modificar_exito", MsgBoxStyle.Information, "str_informacion")
            End Select

            LoadDgv()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ChangeMode(Modos.Modificar)
        tempHorario = GetSelected.First
        LoadFields(tempHorario)

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim selected As List(Of Horario) = GetSelected()
        Dim result = MsgBox("horario_eliminar_confirmacion", MsgBoxStyle.YesNo, "confirmacion")

        If result = MsgBoxResult.Yes Then
            Dim RRHHBUS As New RRHHBUS

            For Each selection In selected
                Try
                    RRHHBUS.DeleteHorarioEmpleado(selection)
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            Next
            LoadDgv()
            MsgBox("horario_eliminar_exito", MsgBoxStyle.Information, "informacion")

        End If
    End Sub

    Private Sub ChangeMode(pMode As Modos)
        Modo = pMode

        If Modo = Modos.Modificar Then
            BtnIngresar.Text = "Modificar"

        Else
            BtnIngresar.Text = "Ingresar"

        End If
    End Sub

    Private Sub ClearFields()
        TxtICi.ResetText()
        CmbISucursal.SelectedIndex = 0

        ChkILunes.Checked = False
        ChkIMartes.Checked = False
        ChkIMiercoles.Checked = False
        ChkIJueves.Checked = False
        ChkIViernes.Checked = False
        ChkISabado.Checked = False
        ChkIDomingo.Checked = False

        TxtIEntrada.ResetText()
        TxtISalida.ResetText()
    End Sub

    Private Function GetHorario() As Horario

        Dim ci As Integer = Integer.Parse(TxtICi.Text)
        Dim nombreSucursal As String = CmbISucursal.SelectedItem.ToString
        Dim strHorarioEntrada As String() = TxtIEntrada.Text.Split(":")
        Dim horaEntrada As Integer = Integer.Parse(strHorarioEntrada.ElementAt(0))
        Dim minutosEntrada As Integer = Integer.Parse(strHorarioEntrada.ElementAt(1))

        Dim sucursal As Sucursal = GetSucursalByName(nombreSucursal)

        Dim strHorarioSalida As String() = TxtISalida.Text.Split(":")
        Dim horaSalida As Integer = Integer.Parse(strHorarioSalida.ElementAt(0))
        Dim minutosSalida As Integer = Integer.Parse(strHorarioSalida.ElementAt(1))

        Dim horarioEntrada As New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, horaEntrada, minutosEntrada, 0)
        Dim horarioSalida As New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, horaSalida, minutosSalida, 0)

        Dim diasGuardia As List(Of Horario.DiasSemana) = GetCheckedDiasInsert()

        Return New Horario(New Empleado(ci), sucursal, diasGuardia, horarioEntrada, horarioSalida)
    End Function

    Private Function GetSearchPattern() As Horario
        Dim horario As New Horario
        Const TIME_FORMAT As String = "##:##"


        If TxtBCi.Text.Length > 0 Then
            Integer.TryParse(TxtBCi.Text, horario.Empleado.Ci)

        End If

        Dim nombreSucursal As String = CmbBSucursal.SelectedItem.ToString
        horario.Sucursal = GetSucursalByName(nombreSucursal)
        horario.Dias = GetCheckedDiasSearch()


        If TxtBEntrada.Text Like TIME_FORMAT And TxtBSalida.Text Like TIME_FORMAT Then
            Dim strHorarioEntrada As String() = TxtBEntrada.Text.Split(":")
            Dim horaEntrada, minutosEntrada, horaSalida, minutosSalida As Integer

            Dim horarioEntrada As New Date
            Dim horarioSalida As New Date

            horaEntrada = Integer.Parse(strHorarioEntrada.ElementAt(0))
            minutosEntrada = Integer.Parse(strHorarioEntrada.ElementAt(1))

            Dim strHorarioSalida As String() = TxtBSalida.Text.Split(":")

            horaSalida = Integer.Parse(strHorarioSalida.ElementAt(0))
            minutosSalida = Integer.Parse(strHorarioSalida.ElementAt(1))

            If horaEntrada < 24 And horaSalida < 24 And minutosEntrada < 60 And minutosSalida < 60 Then
                horario.HoraInicio = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, horaEntrada, minutosEntrada, 0)
                horario.HoraFin = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, horaSalida, minutosSalida, 0)

            End If

        End If

        Return horario
    End Function

    Private Sub GetSucursales()
        Dim RRHHBUS As New RRHHBUS

        Try
            Sucursales = RRHHBUS.GetSucursales()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error_titulo")
        End Try

    End Sub

    Private Function GetSucursalByName(name As String) As Sucursal
        For Each sucursal In Sucursales
            If sucursal.Nombre = name Then Return sucursal
        Next

        Return New Sucursal(0)
    End Function

    Private Sub LoadCmbSucursales()
        CmbISucursal.Items.Clear()
        CmbBSucursal.Items.Clear()

        CmbBSucursal.Items.Add("cualquiera")

        For Each sucursal In Sucursales
            CmbBSucursal.Items.Add(sucursal.Nombre)
            CmbISucursal.Items.Add(sucursal.Nombre)
        Next

        CmbBSucursal.SelectedIndex = 0
        CmbISucursal.SelectedIndex = 0
    End Sub

    Private Sub LoadDgv()
        Dim RRHHBUS As New RRHHBUS
        Dim dt As DataTable

        Try
            dt = RRHHBUS.GetHorariosEmpleados()
            DgvHorarios.DataSource = dt
            DgvHorarios.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadDgv(dt As DataTable)

        Try
            DgvHorarios.DataSource = dt
            DgvHorarios.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadFields(horario As Horario)
        TxtICi.Text = horario.Empleado.Ci
        CmbISucursal.SelectedItem = horario.Sucursal.Nombre
        SwitchCheckBoxSelections(horario.Dias.First)
        TxtIEntrada.Text = horario.HoraInicio.ToShortTimeString
        TxtISalida.Text = horario.HoraFin.ToShortTimeString

    End Sub

    Private Sub SwitchCheckBoxSelections(dia As Horario.DiasSemana)
        Select Case dia
            Case Horario.DiasSemana.Lunes
                ChkILunes.Checked = True
                ChkIMartes.Checked = False
                ChkIMiercoles.Checked = False
                ChkIJueves.Checked = False
                ChkIViernes.Checked = False
                ChkISabado.Checked = False
                ChkIDomingo.Checked = False


            Case Horario.DiasSemana.Martes
                ChkILunes.Checked = False
                ChkIMartes.Checked = True
                ChkIMiercoles.Checked = False
                ChkIJueves.Checked = False
                ChkIViernes.Checked = False
                ChkISabado.Checked = False
                ChkIDomingo.Checked = False

            Case Horario.DiasSemana.Miercoles
                ChkILunes.Checked = False
                ChkIMartes.Checked = False
                ChkIMiercoles.Checked = True
                ChkIJueves.Checked = False
                ChkIViernes.Checked = False
                ChkISabado.Checked = False
                ChkIDomingo.Checked = False

            Case Horario.DiasSemana.Jueves
                ChkILunes.Checked = False
                ChkIMartes.Checked = False
                ChkIMiercoles.Checked = False
                ChkIJueves.Checked = True
                ChkIViernes.Checked = False
                ChkISabado.Checked = False
                ChkIDomingo.Checked = False

            Case Horario.DiasSemana.Viernes
                ChkILunes.Checked = False
                ChkIMartes.Checked = False
                ChkIMiercoles.Checked = False
                ChkIJueves.Checked = False
                ChkIViernes.Checked = True
                ChkISabado.Checked = False
                ChkIDomingo.Checked = False

            Case Horario.DiasSemana.Sabado
                ChkILunes.Checked = False
                ChkIMartes.Checked = False
                ChkIMiercoles.Checked = False
                ChkIJueves.Checked = False
                ChkIViernes.Checked = False
                ChkISabado.Checked = True
                ChkIDomingo.Checked = False

            Case Horario.DiasSemana.Domingo
                ChkILunes.Checked = False
                ChkIMartes.Checked = False
                ChkIMiercoles.Checked = False
                ChkIJueves.Checked = False
                ChkIViernes.Checked = False
                ChkISabado.Checked = False
                ChkIDomingo.Checked = True
        End Select
    End Sub

    Private Function GetCheckedDiasInsert() As List(Of Horario.DiasSemana)
        Dim dias As New List(Of Horario.DiasSemana)

        If ChkILunes.Checked Then
            dias.Add(Horario.DiasSemana.Lunes)
        End If

        If ChkIMartes.Checked Then
            dias.Add(Horario.DiasSemana.Martes)
        End If

        If ChkIMiercoles.Checked Then
            dias.Add(Horario.DiasSemana.Miercoles)
        End If

        If ChkIJueves.Checked Then
            dias.Add(Horario.DiasSemana.Jueves)
        End If

        If ChkIViernes.Checked Then
            dias.Add(Horario.DiasSemana.Viernes)
        End If

        If ChkISabado.Checked Then
            dias.Add(Horario.DiasSemana.Sabado)
        End If

        If ChkIDomingo.Checked Then
            dias.Add(Horario.DiasSemana.Domingo)
        End If

        Return dias
    End Function

    Private Function GetCheckedDiasSearch() As List(Of Horario.DiasSemana)
        Dim dias As New List(Of Horario.DiasSemana)

        If ChkBLunes.Checked Then
            dias.Add(Horario.DiasSemana.Lunes)
        End If

        If ChkBMartes.Checked Then
            dias.Add(Horario.DiasSemana.Martes)
        End If

        If ChkBMiercoles.Checked Then
            dias.Add(Horario.DiasSemana.Miercoles)
        End If

        If ChkBJueves.Checked Then
            dias.Add(Horario.DiasSemana.Jueves)
        End If

        If ChkBViernes.Checked Then
            dias.Add(Horario.DiasSemana.Viernes)
        End If

        If ChkBSabado.Checked Then
            dias.Add(Horario.DiasSemana.Sabado)
        End If

        If ChkBDomingo.Checked Then
            dias.Add(Horario.DiasSemana.Domingo)
        End If

        Return dias
    End Function

    Private Function GetSelected() As List(Of Horario)
        Dim horarios As New List(Of Horario)

        For i As Integer = 0 To DgvHorarios.SelectedRows.Count - 1
            Dim cells = DgvHorarios.SelectedRows.Item(i).Cells

            Dim ciEmpleado = Integer.Parse(cells.Item("CI").Value)
            Dim nombreSucursal = cells.Item("Sucursal").Value.ToString
            Dim sucursal As Sucursal = GetSucursalByName(nombreSucursal)

            Dim dia As Horario.DiasSemana = [Enum].Parse(GetType(Horario.DiasSemana), cells.Item("Dia").Value)

            Dim horaEntrada = Date.Parse(cells.Item("Entrada").Value)
            Dim horaSalida = Date.Parse(cells.Item("Salida").Value)

            Dim horario As New Horario(New Empleado(ciEmpleado),
                                       sucursal, New List(Of Horario.DiasSemana)({dia}),
                                       horaEntrada,
                                       horaSalida)


            horarios.Add(horario)
        Next

        Return horarios
    End Function
End Class