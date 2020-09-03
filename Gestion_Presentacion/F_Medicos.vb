Imports System.Threading
Imports System.Globalization
Imports Logica

Public Class F_Medicos

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Logica.Env.CurrentLangugage
        InitializeComponent()
        ConfigMode()
    End Sub

    'Configura los controles de acuerdo con el usuario que ingresa
    'a la ventana, dado que ciertos usuarios no pueden realizar
    'determinadas tareas (Permisos en la base de datos).
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

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbIDepartamento.DataSource = [Enum].GetValues(GetType(Direccion.Departamentos))
        LoadDgv()
    End Sub

    Private Sub BtnHorarios_Click(sender As Object, e As EventArgs) Handles BtnHorarios.Click
        F_Medicos_Horarios.Show()
        Close()
    End Sub

    Private Sub LoadDgv()
        Dim objMedico As New Medico()
        Dim dt As DataTable = objMedico.GetMedicos()
        DgvMedicos.DataSource = dt
    End Sub
End Class