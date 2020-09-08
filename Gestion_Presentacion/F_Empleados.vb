Imports System.Threading
Imports System.Globalization
Imports Logica

Public Class F_Empleados

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Logica.Env.CurrentLangugage
        InitializeComponent()
        ConfigMode()
    End Sub


    Private especialidades As List(Of Especialidad)
    Private empleado As Empleado

    ''' <summary>
    ''' Configura los controles de acuerdo con el usuario que ingresa
    ''' a la ventana, dado que ciertos usuarios no pueden realizar
    ''' determinadas tareas(Permisos en la base de datos).
    ''' </summary>
    Public Sub ConfigMode()
        Select Case Env.UserType
            Case Env.UserType = Env.UserTypes.Recepcionista Or Env.UserType = Env.UserTypes.Administrador
                BtnModificar.Enabled = False
                BtnEliminar.Enabled = False
                BtnResetPassword.Enabled = False
                BtnHacerAdmin.Enabled = False
                BtnIngresar.Enabled = False
            Case Env.UserType = Env.UserTypes.RRHH
                'La ventana, por defecto está configurada
                'para RRHH, por tanto, no hago nada
            Case Else

        End Select

        BtnHacerAdmin.Visible = False
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        Dim empleado = GetEmpleado()
        Dim medico As New Medico(
                            CInt(TxtICi.Text),
                            TxtINombre.Text,
                            TxtIApellidoP.Text,
                            TxtIApellidoM.Text,
                            New Direccion(TxtICalle.Text,
                                            CInt(TxtINumero.Text),
                                            TxtILocalidad.Text,
                                            CmbIDepartamento.SelectedItem.ToString),
                            CInt(TxtITelefono.Text),
                            Format(DTPickerFNac.Value, "yyyy-MM-dd"),
                            "Medicina In General",
                            "password"
                            )
        Try
            Dim objRRHH As RRHH = Env.CurrentUser
            objRRHH.IngresarMedico(medico)
            LoadDgv()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetEmpleado() As Empleado
        Try
            ValidateFields()

        Catch ex As Exception

        End Try
    End Function

    Public Sub ValidateFields()

    End Sub

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
        Dim objMedico As New Medico()
        Try
            Dim dt As DataTable = objMedico.GetEmpleados()
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
        Dim LogicaEmpleado As New Empleado
        Dim roles As List(Of String) = LogicaEmpleado.GetRoles()
        CmbBRol.DataSource = roles
        CmbRol.DataSource = roles
    End Sub

    Public Sub ConfigComboBox()
        Dim LogicaMedico As New Medico
        Dim especialidades As List(Of Especialidad) = LogicaMedico.GetEspecialidades()

        For Each i As Especialidad In especialidades
            CmbBEspecialidades.Items.Add(i.Nombre)
            CmbIEspecialidades.Items.Add(i.Nombre)
        Next

    End Sub
End Class