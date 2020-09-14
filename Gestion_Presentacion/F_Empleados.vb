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

    Public Sub ClearFields()
        TxtICi.ResetText()
        TxtINombre.ResetText()
        TxtIApellidoP.ResetText()
        TxtIApellidoM.ResetText()
        DTPickerFNac.Value = Date.Now
        TxtICalle.ResetText()
        TxtINumero.ResetText()
        TxtIDetalle.ResetText()
        TxtILocalidad.ResetText()
        CmbIDepartamento.SelectedIndex = 1
        TxtITelefono.ResetText()
        CmbIRol.SelectedIndex = 1
        CmbIngresadasEspecialidades.Items.Clear()
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
                                     CmbIRol.SelectedItem.ToString
                                     )
            empleado = GetEmpleado()
            Dim RRHHBUS As New RRHHBUS
            RRHHBUS.InsertEmployee(empleado)
            LoadDgv()

            Dim exitMessage = " ingresado con éxito."
            If empleado.IsMedico Then
                exitMessage = "Medico" & exitMessage

            ElseIf empleado.IsRRHH Then
                exitMessage = "Personal de Recursos humanos" & exitMessage

            ElseIf empleado.IsRecepcionista Then
                exitMessage = "Recepcionista" & exitMessage

            End If

            MsgBox(exitMessage, MsgBoxStyle.Information, "Empleado Ingresado")
            ClearFields()

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


        If CmbIRol.SelectedItem = "Medico" Then
            Dim especialidades As New List(Of Especialidad)

            For Each item In CmbIngresadasEspecialidades.Items
                especialidades.Add(New Especialidad(item.ToString))
            Next
            EmpleadoVO = New Medico(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento, especialidades, password)

        Else

            If CmbIRol.SelectedItem = "Recursos_Humanos" Then
                EmpleadoVO = New RRHH(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento, password)

            ElseIf CmbIRol.SelectedItem = "Recepcionista" Then
                EmpleadoVO = New Recepcionista(ci, nombre, apellidoP, apellidoM, direccion, telefono, fechaNacimiento, password)
            End If
        End If

        Return EmpleadoVO
    End Function

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConfigComboBox()
        LoadDgv()
        ConfigDgvAppearance()
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

    Private Sub ConfigDgvAppearance()
        Dim fill As Integer = DgvMedicos.Width

        DgvMedicos.Columns.Item(0).Width = 50
        DgvMedicos.Columns.Item(1).Width = 130
        DgvMedicos.Columns.Item(2).Width = 80
        DgvMedicos.Columns.Item(3).Width = 80
        DgvMedicos.Columns.Item(4).Width = 150
        DgvMedicos.Columns.Item(5).Width = 300

    End Sub

    Public Sub HideBooleansDgv()
        Dim count = DgvMedicos.Columns.Count
        DgvMedicos.Columns.Item(count - 1).Visible = False
        DgvMedicos.Columns.Item(count - 2).Visible = False
        DgvMedicos.Columns.Item(count - 3).Visible = False
        DgvMedicos.Columns.Item(count - 4).Visible = False

    End Sub

    Public Sub ConfigComboBox()
        Dim MedicoBUS As New MedicoBUS
        Try
            CmbIDepartamento.DataSource = [Enum].GetValues(GetType(Direccion.Departamentos))

            Dim especialidades As List(Of Especialidad) = MedicoBUS.GetEspecialidades()

            For Each i As Especialidad In especialidades
                CmbBEspecialidades.Items.Add(i.Nombre)
                CmbIEspecialidades.Items.Add(i.Nombre)
            Next

            ' Roles
            Dim EmpleadoBUS As New EmpleadoBUS

            ' Es necesario que llame a GetRoles dos veces
            ' para que no se me linkeen los datasources y
            ' cuando cambie el item seleccionado en uno
            ' también cambie en el otro.

            Dim rolesIngreso As List(Of String) = EmpleadoBUS.GetRoles()
            Dim rolesBuscar As List(Of String) = EmpleadoBUS.GetRoles()
            rolesBuscar.Insert(0, "Todos")

            CmbIRol.DataSource = rolesIngreso
            CmbBRol.DataSource = rolesBuscar
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

    Private Sub CmbRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbIRol.SelectedIndexChanged
        If CmbIRol.SelectedItem.ToString = "Medico" Then
            CmbIEspecialidades.Enabled = True
            CmbIngresadasEspecialidades.Enabled = True
            BtnAddEspecialidad.Enabled = True
            BtnDelEspecialidad.Enabled = True
        Else
            CmbIEspecialidades.Enabled = False
            CmbIngresadasEspecialidades.Enabled = False
            BtnAddEspecialidad.Enabled = False
            BtnDelEspecialidad.Enabled = False
        End If
    End Sub
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

    End Sub
End Class