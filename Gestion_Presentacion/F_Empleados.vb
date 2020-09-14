Imports System.Threading
Imports System.Globalization
Imports Dominio
Imports Logica

Public Class F_Empleados

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Env.CurrentLangugage
        InitializeComponent()
        ConfigMode()
    End Sub


    Private especialidades As List(Of Especialidad)
    Private empleado As Empleado

    ''' <summary>
    ''' Configura los controles de acuerdo con el usuario que a la ventana, dado que ciertos usuarios no pueden realizar determinadas tareas(Permisos en la base de datos).
    ''' </summary>
    Public Sub ConfigMode()

        If Env.CurrentUser.IsRecepcionista Or Env.CurrentUser.IsAdministrador Then
            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False
            BtnResetPassword.Enabled = False
            BtnHacerAdmin.Enabled = False
            BtnIngresar.Enabled = False

        End If

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim EmpleadoBUS As New EmpleadoBUS
        Dim empleado As Empleado

        Try
            EmpleadoBUS.ValidateFields(TxtICi.Text,
                                     TxtINombre.Text,
                                     TxtIApellidoP.Text,
                                     TxtIApellidoM.Text,
                                     TxtICalle.Text,
                                     TxtINumero.Text,
                                     TxtILocalidad.Text,
                                     TxtITelefono.Text,
                                     CmbRol.SelectedItem.ToString
                                     )
            empleado = GetEmpleado()
            Dim RRHHBUS As New RRHHBUS
            RRHHBUS.InsertEmployee(empleado)
            LoadDgv()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function GetEmpleado() As Empleado
        Dim EmpleadoVO As Empleado

        Dim ci = CInt(TxtICi.Text)
        Dim nombre = TxtINombre.Text
        Dim apellidoP = TxtIApellidoP.Text
        Dim apellidoM = TxtIApellidoM.Text
        Dim fechaNacimiento As Date = Format(DTPickerFNac.Value, "yyyy-MM-dd")
        Dim calle = TxtICalle.Text
        Dim numero = CInt(TxtINumero.Text)
        Dim localidad = TxtILocalidad.Text
        Dim departamento = [Enum].Parse(GetType(Direccion.Departamentos), CmbIDepartamento.SelectedItem)
        Dim direccion As New Direccion(calle, numero, localidad, departamento)
        Dim telefono = CInt(TxtITelefono.Text)
        Dim password = Logica.Password.Generate(New Random)


        If CmbRol.SelectedItem = "Medico" Then
            Dim especialidades As New List(Of Especialidad)

            For Each item In CmbIngresadasEspecialidades.Items
                especialidades.Add(New Especialidad(item.ToString))
            Next
            EmpleadoVO = New Medico(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento, especialidades, password)

        Else

            EmpleadoVO = New Empleado(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento, password)
            If CmbRol.SelectedItem = "Recursos_Humanos" Then
                EmpleadoVO.IsRRHH = True
            ElseIf CmbRol.SelectedItem = "Recepcionista" Then
                EmpleadoVO.IsRecepcionista = True
            End If
        End If

        Return EmpleadoVO
    End Function

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbIDepartamento.DataSource = [Enum].GetValues(GetType(Direccion.Departamentos))
        ConfigRoles()
        ConfigComboBox()
        LoadDgv()
    End Sub

    Private Sub BtnHorarios_Click(sender As Object, e As EventArgs) Handles BtnHorarios.Click
        F_Empleados_Horarios.Show()
        Close()
    End Sub

    Private Sub LoadDgv()
        Dim MedicoBUS As New MedicoBUS()
        Try
            Dim dt As DataTable = MedicoBUS.GetEmpleados()
            DgvMedicos.DataSource = dt
            HideBooleansDgv()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub HideBooleansDgv()
        Dim count = DgvMedicos.Columns.Count
        DgvMedicos.Columns.Item(count - 1).Visible = False
        DgvMedicos.Columns.Item(count - 2).Visible = False
        DgvMedicos.Columns.Item(count - 3).Visible = False
        DgvMedicos.Columns.Item(count - 4).Visible = False

    End Sub

    Private Sub CmbBRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBRol.SelectedIndexChanged
        ' Si el rol seleccionado es el de médico, el ComboBox
        ' de Especialidades se habilita

    End Sub

    Private Sub ConfigRoles()
        Dim EmpleadoBUS As New EmpleadoBUS
        Dim roles As List(Of String) = EmpleadoBUS.GetRoles()
        CmbBRol.DataSource = roles
        CmbRol.DataSource = roles
    End Sub

    Public Sub ConfigComboBox()
        Dim MedicoBUS As New MedicoBUS
        Try
            Dim especialidades As List(Of Especialidad) = MedicoBUS.GetEspecialidades()

            For Each i As Especialidad In especialidades
                CmbBEspecialidades.Items.Add(i.Nombre)
                CmbIEspecialidades.Items.Add(i.Nombre)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnAddEspecialidad_Click(sender As Object, e As EventArgs) Handles BtnAddEspecialidad.Click
        CmbIngresadasEspecialidades.Items.Add(CmbIEspecialidades.SelectedItem)
    End Sub

    Private Sub BtnDelEspecialidad_Click(sender As Object, e As EventArgs) Handles BtnDelEspecialidad.Click
        CmbIngresadasEspecialidades.Items.RemoveAt(CmbIngresadasEspecialidades.SelectedIndex)
    End Sub
End Class